module FSharp.Substance.FSharpCompiler

open System
open System.Diagnostics

open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
open FSharp.Idioms
open FSharp.Idioms.Literal
open FSharp.Substance
open FSharp.Idioms.Json

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

let context (states: YaccState list) (space: int option) (la: FSharpToken) =
    if la = EOF then
        [
            "忽略i"
            "past是分号则shift dummy"
            "rec gap => rrparen || rhsend"
            "EOF"
        ]
    elif la = SEMICOLON then
        [
            "忽略i"
            "past是分号则删除la"
            "rec gap => rrparen || rhsend"
            "SEMICOLON"
        ]

    elif la = RPAREN then
        [ "找到栈中的对应左括号，在此范围内补全" ]
    elif la = LPAREN then
        [ "可以合并进入first atom" ]
    else
        match space with
        | None -> [ "没有换行，也不是重要的标点符号" ]
        | Some i ->
            // "有换行，检查栈顶最短的词组"
            match states with
            | _ when true -> [ "栈顶是标点符号" ]
            | b ->
                [
                    "说明：前面已经排除la=标点符号,分号，左括号，右括号，结尾"
                    "states is shortest expr"
                    "中缀：不添加token"
                    "计算ij关系"
                    "如果符合revAppExpr，且i>j继续缩进新行：不添加token"
                    "i>j,符合declexpr，不符合revAppExpr,"
                    "如果符合declexpr完整，且对齐，lookahead是declexpr first；"
                    ""

                ]

let beforeEOF (states: YaccState list) =
    let rec loop currentStates =
        [
            match
                StackOps.rrparen_rhsend
                |> StackOps.tryFirstPrefix2 currentStates
            with
            | Some(symbols, rightBound) ->
                yield None, rightBound
                let nextStates = yaccShift currentStates (Light.tokenRow None rightBound)
                yield! loop nextStates
            | None -> ()
        ]
    [
        match YaccStateSegment.takeLatest states with
        | Semicolon ->
            yield None, DUMMY
            let dummyStates = yaccShift states (Light.tokenRow None DUMMY)

            yield None, RRPAREN
            let rrparenStates = yaccShift dummyStates (Light.tokenRow None RRPAREN)

            yield! loop rrparenStates
        | _ -> yield! loop states
    ]

let beforeSemicolon (states: YaccState list) =
    //补齐rhsend
    let rec loop currentStates =
        [
            match
                RightSententialForm.rhsend
                |> StackOps.tryFirstPrefix currentStates
            with
            | Some(symbols) ->
                yield None, RHSEND
                let nextStates = yaccShift currentStates (Light.tokenRow None RHSEND)
                yield! loop nextStates
            | None -> ()
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

    | Some i, (LET | FUN | OPEN | LPAREN | IDENT _ | LITERAL _ | LBRACK | LBRACK_BAR | MINUS) -> // first declExpr
        match YaccStateSegment.takeLatest states with
        | LeftBound _ ->
            //左边界后面，直接first decl是ok的，忽略任何空白
            [ space, la ]
        | ModuleHead (seg, pos)
        | LeftOfllparen(seg, pos) ->
            Debug.WriteLine($"{i}:=:{pos}不循环")
            [
                pos, LLPAREN
                Some i, la
            ]
        | Semicolon ->
            match YaccStateSegment.takeLatest states.Tail with
            | DeclSegment(decl, pos) ->
                Console.WriteLine(stringify decl)
                match pos with
                | None -> failwith "notImpl:decl语句没有新起一行"
                | Some j ->
                    if i > j then
                        failwith "不可能在一个分号后继续缩进"
                    elif i = j then
                        //对齐无需补充任何符号
                        [ space, la ]
                    elif i < j then
                        [
                            None,DUMMY
                            None,RRPAREN
                            //循环，直到i>=j补充右括号，补充到i缩进。
                            yield! []
                            space,la
                        ]
                    else
                        failwith "never"
            | _ -> failwith "分号前面一定是完整的Decl"

        | DeclSegment(seg, pos) ->
            match pos with
            | None -> failwith "notImpl:前面的decl没有新启一行"
            | Some j ->
                if i > j then
                    // 只要(i > j)缩进更多，一定是续航
                    [ space, la ]
                elif i = j then
                    //无分号的对齐decl处理
                    if RightSententialForm.declExpr |> Seq.exists((=)seg) then     
                        [
                            None, SEMICOLON
                            space, la
                        ]
                    elif RightSententialForm.rhsend  |> Seq.exists((=)seg) then
                        failwith "添加循环补充多个rhsend"
                        [
                            yield! beforeSemicolon []
                            None, SEMICOLON
                            space, la
                        ]
                    else //续航
                        [ space, la ]
                else
                    // i < j 补充右括号，补充到i缩进。
                    []
        | Rest symbols -> failwith $"decl之前不可能：{stringify symbols}"

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
