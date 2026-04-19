module FSharp.Substance.FSharpCompiler

open System
open System.Diagnostics

open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
open FSharp.Idioms
open FSharp.Idioms.Literal
open FSharp.Substance
open FSharp.Idioms.Json
open FSharp.Substance.StackOps

let yaccShift = FSharpYacc.parser.shift

let old (states: YaccState list) (i: int) (la: FSharpToken) =
    // 先看最长的匹配，确保不是进一步缩进。再看最短的匹配，确保balance是从内到外。
    match
        RightSententialForm.llparen
        |> StackOps.tryFirstPrefix states
    with
    | Some(symbols) ->
        let lead = states.[symbols.Length - 1]
        let j = StackOps.getPosition lead
        [
            j, LLPAREN
            Some i, la
        ]
    | _ ->
        // 排除缩进的llparen情况，栈顶是=号或->的情况。
        // 剩下的情况，新行一定是对齐和缩回。
        // 对齐和缩回一定是更短的匹配优先。

        // 处理完分号，shift进入dummy后，将不断补充rrparen&rhsend循环balance
        let rec loop currentStates =
            [ // 改为TakeFirstDecl
                match StackOps.tryUnindent currentStates with // 可以改为三种情况的活动模式
                | Some(symbols, laTok) ->
                    let lead = List.item (symbols.Length - 1) currentStates
                    match StackOps.getPosition lead with
                    | None -> failwith "declexpr没有顶行"
                    | Some j ->
                        if laTok = SEMICOLON && j = i then // semicolon是declexpr的指代
                            yield None, SEMICOLON
                            yield Some i, la
                        elif laTok = RHSEND && j = i then
                            yield None, RHSEND
                            let nextStates = yaccShift currentStates (Light.tokenRow None RHSEND)
                            yield! loop nextStates
                        elif laTok = RRPAREN && j >= i then
                            yield None, RRPAREN
                            let nextStates = yaccShift currentStates (Light.tokenRow None RRPAREN)
                            yield! loop nextStates
                        elif laTok = WHITESPACE then
                            if j = i then
                                yield None, SEMICOLON
                                yield Some i, la
                            elif j < i then
                                // first atom
                                Debug.Assert(
                                    match la with
                                    | LPAREN
                                    | IDENT _
                                    | LITERAL _
                                    | LBRACK
                                    | LBRACK_BAR
                                    | MINUS -> true
                                    | _ -> false
                                )
                                yield Some i, la
                            else
                                Console.WriteLine($"j{j},i{i},{laTok}")
                                failwith "notImpl"
                        else
                            Console.WriteLine($"j{j},i{i},{laTok}")
                            failwith "notImpl"

                | None -> failwith "out of semicolon_rrparen_rhsend"
            ]

        [
            match states with
            | h :: t ->
                match FSharpYacc.stateSymbols.[h.state] with
                | "["
                | "[|"
                | "("
                | "," ->
                    //比分号，无论优先级更高的逗号，还是优先级更低的左括号都直接忽略换行和缩进
                    yield Some i, la

                | ";" -> // 栈顶是分号
                    match StackOps.getPosition t.Head with
                    | None -> failwith "declExpr不顶行"
                    | Some j ->
                        if j = i then
                            //Console.WriteLine("对齐的两个declExpr，不必补充token")
                            yield Some i, la
                        elif j > i then
                            yield None, DUMMY
                            let dummyStates = yaccShift states (Light.tokenRow None DUMMY)
                            yield! loop dummyStates
                        else
                            failwith "不可能j<i"
                | _ -> yield! loop states
            | _ -> yield! loop states
        ]

let beforeEOF (states: YaccState list) =
    let rec loop (currentStates: YaccState list) =
        [
            match currentStates with
            | LOOKAHEAD_RRPAREN _ ->
                yield None, RRPAREN
                let nextStates = yaccShift currentStates (Light.tokenRow None RRPAREN)
                yield! loop nextStates
            | LOOKAHEAD_RHSEND _ ->
                yield None, RHSEND
                let nextStates = yaccShift currentStates (Light.tokenRow None RHSEND)
                yield! loop nextStates
            | _ -> ()
        ]
    [
        match states with
        | TOP_SEMICOLON _ ->
            yield None, DUMMY
            let dummyStates = yaccShift states (Light.tokenRow None DUMMY)
            yield! loop dummyStates
        | _ -> yield! loop states
    ]

let beforeSemicolon (states: YaccState list) =
    //补齐rhsend
    let rec loop currentStates =
        [
            match currentStates with
            | LOOKAHEAD_RHSEND symbols ->
                yield None, RHSEND
                let nextStates = yaccShift currentStates (Light.tokenRow None RHSEND)
                yield! loop nextStates
            | LOOKAHEAD_SEMICOLON _ -> ()
            | _ -> failwith "never"
        ]
    loop states

///前面的栈内是合法的decl
let getPosition_of_decl (states: YaccState list) =
    // 可以在后面加一个分号强制reduce
    let semicolonStates = yaccShift states (Light.tokenRow None SEMICOLON)
    //分号前的状态一定是
    let revSequentialExpr = semicolonStates.[1]
    getPosition revSequentialExpr

let beforeNewLine indent (states: YaccState list) =
    let rec loop currentStates =
        [
            match currentStates with
            | LOOKAHEAD_RRPAREN symbols ->
                yield None, RRPAREN
                let rrparenStates = yaccShift currentStates (Light.tokenRow None RRPAREN)
                match getPosition_of_decl rrparenStates with
                | None -> failwith "notImpl: need borrow"
                | Some k ->
                    if k = indent then
                        ()
                    else
                        yield! loop rrparenStates
            | LOOKAHEAD_RHSEND symbols ->
                yield None, RHSEND
                let nextStates = yaccShift currentStates (Light.tokenRow None RHSEND)
                match getPosition_of_decl nextStates with
                | None -> failwith "notImpl: need borrow"
                | Some k ->
                    if k = indent then
                        ()
                    else
                        yield! loop nextStates
            | DECL_EXPR symbols -> ()
            | _ -> failwith "never"
        ]
    loop states

/// top lead gap la (lookahead)
let complement (states: YaccState list) (space: int option) (la: FSharpToken) =
    match space, la with
    | _, EOF ->
        [
            yield! beforeEOF states
            space, la
        ]

    | _, SEMICOLON ->
        [
            yield! beforeSemicolon states
            space, la
        ]

    | Some indent, (LET | FUN | OPEN | LPAREN | IDENT _ | LITERAL _ | LBRACK | LBRACK_BAR | MINUS) -> // first declExpr
        match states with
        | TOP_LEFT_BOUND _ ->
            // 左边界后面，直接first decl是ok的，忽略任何空白
            let borrow = space // todo:左括号借用行首位置
            [ borrow, la ]
        | LOOKAHEAD_LLPAREN(symbols, pos) ->
            [
                pos, LLPAREN
                Some indent, la
            ]
        | TOP_SEMICOLON symbols ->
            Debug.Assert((symbols.[1] = "revSequentialExpr"))
            match StackOps.getPosition states.[1] with
            | None -> failwith "notImpl: need borrow"
            | Some j ->
                if indent > j then
                    failwith "不可能在一个分号后继续缩进"
                elif indent = j then
                    //对齐无需补充任何符号
                    [ space, la ]
                elif indent < j then
                    [
                        None, DUMMY //栈顶分号已经被用掉了。
                        let dummyStates = yaccShift states (Light.tokenRow None DUMMY)
                        //循环，直到i>=j补充右括号，补充到i缩进。
                        yield! beforeNewLine indent dummyStates
                        None, SEMICOLON
                        space, la
                    ]
                else
                    failwith "never"

        | DECL_EXPR(symbols, pos) -> //没有分号的换行，可能要处理decl以下的连接
            match pos with
            | None -> failwith "notImpl:borrow"
            | Some j ->
                if indent > j then
                    // 只要(i > j)缩进更多，一定是续航
                    [ space, la ]
                else
                    //先排除续航，后面
                    if
                        StackOps.la_semicolon
                        |> List.map(fun v -> v.prefix)
                        |> List.exists((=) symbols)
                    then
                        [
                            None, SEMICOLON
                            space, la
                        ]
                    elif
                        RightSententialForm.rhsend
                        |> Seq.exists((=) [])
                    then
                        [
                            yield! beforeNewLine indent states
                            //None, SEMICOLON
                            space, la
                        ]
                    else //续航
                        [ space, la ]

        | _ -> failwith $"不可能"

    | _ ->
        // la is not first decl
        [ space, la ]

/// 解析文本为结构化数据
let compile (input: string) =
    //let mutable revTokens: FSharpToken list = []
    let mutable states = [ { state = 0; lexeme = null } ]

    let input = "\n" + input
    let iter = LexicalIterator.forChar input

    let tokens =
        iter
        |> FSharpLexerTailer.tokenize
        |> Seq.filter(fun tok ->
            match tok with
            | WHITESPACE -> false
            | _ -> true
        )
        |> Light.transform

    seq {
        yield! tokens
        yield Some 0, EOF
    }
    |> Seq.collect(fun (spaces, tok) ->
        Console.WriteLine(stringify(StackOps.getSymbols states |> List.rev))
        complement states spaces tok
    )
    |> Seq.map(fun (i, tok) ->
        //Console.WriteLine(stringify(i, tok))
        Light.tokenRow i tok
    )
    |> Seq.iter(fun tok -> states <- yaccShift states tok
    //Console.WriteLine(stringify(StackOps.getSymbols states |> List.rev))
    )

    match FSharpYacc.parser.tryReduceBeforeAccept(states) with
    | Some reducedstates -> states <- reducedstates
    | None -> ()

    match states with
    | [ { state = 1; lexeme = lxm }; { state = 0; lexeme = null } ] ->
        Console.WriteLine(stringify(StackOps.getSymbols states |> List.rev))
        FSharpYacc.unboxRoot lxm
    | _ ->
        let symbols = StackOps.getSymbols states
        failwith $"{stringify symbols}"
