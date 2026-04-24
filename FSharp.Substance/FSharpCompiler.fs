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
open FSharpYacc

let beforeSemicolon (states: YaccState list) =
    let rec loop currentStates =
        [
            match currentStates with
            | LOOKAHEAD_RHSEND symbols ->
                let rhsendStates = parser.shift currentStates (Light.tokenRow None RHSEND)
                yield None, RHSEND
                yield! loop rhsendStates
            | LOOKAHEAD_SEMICOLON _ -> ()
            | _ -> failwith "never"
        ]
    loop states

let beforeEOF (states: YaccState list) =
    let rec loop (currentStates: YaccState list) =
        [
            match currentStates with
            | LOOKAHEAD_RRPAREN _ ->
                yield None, RRPAREN
                let nextStates = parser.shift currentStates (Light.tokenRow None RRPAREN)
                yield! loop nextStates
            | LOOKAHEAD_RHSEND _ ->
                yield None, RHSEND
                let nextStates = parser.shift currentStates (Light.tokenRow None RHSEND)
                yield! loop nextStates
            | _ -> ()
        ]
    [
        match states with
        | TOP_SEMICOLON _ ->
            let dummyStates = parser.shift states (Light.tokenRow None DUMMY)
            yield None, DUMMY
            yield! loop dummyStates
        | _ -> yield! loop states
    ]

let beforeRight (states: YaccState list) (laRight: FSharpToken) =
    let la = laRight |> FSharpToken.tag
    let lookaheads = ViablePrefix.lookaheadOf la

    let rec loop (currentStates: YaccState list) =
        [
            match currentStates with
            | LOOKAHEAD_RRPAREN _ ->
                yield None, RRPAREN
                let nextStates = parser.shift currentStates (Light.tokenRow None RRPAREN)
                yield! loop nextStates

            | LOOKAHEAD_RHSEND _ ->
                Console.WriteLine("LOOKAHEAD_RHSEND")
                yield None, RHSEND
                let nextStates = parser.shift currentStates (Light.tokenRow None RHSEND)
                yield! loop nextStates
            | _ ->
                if
                    lookaheads
                    |> Seq.exists(fun symbols -> isPrefixOf currentStates symbols)
                then
                    ()
                else
                    failwith $"beforeRight:{la}"
        ]
    [
        match states with
        | TOP_SEMICOLON _ ->
            let dummyStates = parser.shift states (Light.tokenRow None DUMMY)
            yield None, DUMMY
            yield! loop dummyStates
        | _ -> yield! loop states
    ]
///
let beforeNewLine indent (states: YaccState list) =
    let rec loop currentStates =
        [
            match currentStates with
            | LOOKAHEAD_RRPAREN _ ->
                let rrparenStates =
                    parser.shift currentStates (Light.tokenRow None RRPAREN)

                match rrparenStates with
                | TOP_RRPAREN symbols ->
                    let pos = getPosition rrparenStates.[1]
                    match pos with
                    | Some k when k <= indent -> ()
                    | _ ->
                        yield None, RRPAREN
                        yield! loop rrparenStates

                | _ -> failwith "never"

            | LOOKAHEAD_RHSEND _ ->
                let rhsendStates = parser.shift currentStates (Light.tokenRow None RHSEND)
                match rhsendStates with
                | TOP_RHSEND symbols ->
                    let pos = getPosition rhsendStates.[symbols.Length - 1]
                    match pos with
                    | Some k when k <= indent -> ()
                    | _ ->
                        yield None, RHSEND
                        yield! loop rhsendStates

                | _ -> failwith "never"

            | LOOKAHEAD_SEMICOLON _ -> ()
            | _ ->
                let symbols = StackOps.getSymbols currentStates
                failwith $"never:{symbols}"
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
    | _, (RPAREN | RBRACE | RBRACK) ->

        [
            yield! beforeRight states la
            space, la
        ]

    | Some _, COMMA -> [ space, la ]

    | Some indent, (OPEN | LET | FUN | LPAREN | IDENT _ | LITERAL _ | LBRACK | LBRACK_BAR | MINUS) -> // first declExpr
        match states with
        | LOOKAHEAD_LLPAREN(symbols) ->
            [
                None, LLPAREN
                Some indent, la
            ]
        | TOP_LEFT_BOUND _ ->
            // 左边界后面，直接first decl是ok的，忽略任何空白
            [ space, la ]

        | LOOKAHEAD_RHSEND symbols
        | LOOKAHEAD_RRPAREN symbols ->
            [
                //循环，直到i>=j补充右括号，补充到i缩进。
                yield! beforeNewLine indent states
                None, SEMICOLON
                space, la
            ]

        | TOP_SEMICOLON symbols ->
            let revSequentialExpr = states.[1]
            match StackOps.getPosition revSequentialExpr with
            | None -> failwith "notImpl: need borrow"
            | Some j ->
                if indent > j then
                    failwith "不可能在一个分号后继续缩进"
                elif indent = j then
                    //对齐无需补充任何符号
                    [ space, la ]
                elif indent < j then
                    [
                        let dummyStates = parser.shift states (Light.tokenRow None DUMMY)
                        None, DUMMY //栈顶分号已经被用掉了。
                        //循环，直到i>=j补充右括号，补充到i缩进。
                        yield! beforeNewLine indent dummyStates
                        None, SEMICOLON
                        space, la
                    ]
                else
                    failwith "never"

        | OPEN_LONGID(symbols, pos) ->
            match pos with
            | None -> failwith "notImpl"
            | Some j ->
                if indent = j then
                    [
                        None, SEMICOLON
                        space, la
                    ]
                else
                    failwith "缩进不正确"

        | DECL_EXPR(symbols, pos) ->
            //top是连接符
            if symbols.[0] = "," then
                [ space, la ]
            else
                // ident<=j
                match pos with
                | None -> failwith "notImpl:borrow"
                | Some j ->
                    if indent > j then
                        // 只要(i > j)缩进更多，一定是续航，并且应该是app，不加semicolon
                        [ space, la ]
                    else
                        [
                            yield! beforeNewLine indent states
                            None, SEMICOLON
                            space, la
                        ]
        | _ ->
            let symbols = StackOps.getSymbols states |> List.rev
            Console.WriteLine(stringify symbols)
            Console.WriteLine(stringify la)
            Console.WriteLine(stringify space)
            failwith "notImpl"

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
    |> Seq.iter(fun tok -> states <- parser.shift states tok
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
