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
    let lookaheads = RightSententialForm.lookaheads.[ la]

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
                    |> Seq.exists(fun vp -> isPrefixOf currentStates vp.prefix)
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
                    | Some k when k < indent -> ()
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

/// 依次的命名为：lead top gap la
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

    | _, RPAREN ->
        let vp =
            RightSententialForm.lookaheads.[")"]
            |> List.filter(fun vp ->
                StackOps.isPrefixOf states vp.prefix
            )

        if not vp.IsEmpty && vp.[0].head = "atomicPattern" then
            [ space, la ]
        else
            [
                yield! beforeRight states la
                space, la
            ]

    | _, RBRACK ->
        let vp =
            RightSententialForm.lookaheads.["]"]
            |> List.filter(fun (v) ->
                StackOps.isPrefixOf states v.prefix
            )

        if not vp.IsEmpty && vp.[0].head = "qualificationSuffix" then
            [ space, la ]
        else
            [
                yield! beforeRight states la
                space, la
            ]

    | _, (RBRACE | BAR_RBRACK) ->
        [
            yield! beforeRight states la
            space, la
        ]

    | Some indent, _ ->
        if Light.semicolon_may_follow la |> not then
            [ space, la ]
        else
            let top = stateSymbols.[states.[0].state]
            if RightSententialForm.lBounds.Contains top then
                [ space, la ]
            else
                match states with
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
                | LOOKAHEAD_LLPAREN(symbols) ->
                    [
                        None, LLPAREN
                        Some indent, la
                    ]
                | LOOKAHEAD_RHSEND symbols
                | LOOKAHEAD_RRPAREN symbols ->
                    [
                        yield! beforeNewLine indent states
                        None, SEMICOLON
                        space, la
                    ]

                | TOP_SEMICOLON symbols ->
                    let revSequentialExpr = states.[1]
                    match StackOps.getPosition revSequentialExpr with
                    | None -> failwith "notImpl"
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

                | LOOKAHEAD_SEMICOLON prefixes ->
                    // 上一行的缩进
                    let j =
                        prefixes
                        |> Seq.map(fun p -> p.prefix.Length - 1)
                        |> Seq.map(fun i ->
                            let lead = states.[i]
                            getPosition lead
                        )
                        |> Seq.pick id

                    if indent > j then
                        //表示是app续行
                        [ space, la ]
                    elif indent = j then
                        //对齐序列
                        [
                            None, SEMICOLON
                            space, la
                        ]
                    else
                        //缩回块
                        [
                            yield! beforeNewLine indent states
                            None, SEMICOLON
                            space, la
                        ]

                | STACK_TOP vps ->
                    Console.WriteLine("STACK_TOP")
                    let prefixes =
                        vps
                        |> List.map(fun vp -> vp.prefix)
                        |> Set.ofList
                        |> Set.toList

                    Debug.Assert((prefixes.Length = 1))
                    Console.WriteLine(stringify prefixes.[0])

                    // 此步就是为了排除续行
                    if not vps.[0].prefix.IsEmpty then
                        [ space, la ]
                    else
                        let symbols = StackOps.getSymbols states |> List.rev
                        Console.WriteLine("stack:" + stringify symbols)
                        Console.WriteLine("alts:" + stringify vps)
                        Console.WriteLine("lookahead:" + stringify(space, la))
                        failwith "notImpl"

    | _ -> [ space, la ]

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
