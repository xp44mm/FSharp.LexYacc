module FSharp.Substance.ParseContext

open FSharp.Substance.FSharpYacc

open FSharp.Idioms
open FSharp.Idioms.Literal

open FSharp.LexYacc

open System
open System.Diagnostics

/// 依次的命名为：lead top gap la
/// 简单语句的结束方法
let (|OPEN_LONGID|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    if newline.IsSome && la = LET || la = OPEN then
        RightSententialForm.open_longid
        |> Seq.tryFind(StackOps.isPrefixOf states)
        |> Option.map(fun symbols ->
            let lead = states.[symbols.Length - 1]
            let pos = StackOps.getPosition lead

            match newline.Value, pos with
            | i, Some j when i = j ->
                [
                    None, SEMICOLON
                    newline, la
                ]
            | _ -> failwith "notImpl"
        )
    else
        None

/// 右括号之前
let (|PEEK_RPAREN|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    if la = RPAREN then
        let vp =
            RightSententialForm.lookaheads.[")"]
            |> List.filter(fun (v) ->
                StackOps.isPrefixOf states v.prefix
            )

        if
            not vp.IsEmpty
            && vp.[0].head = "atomicPattern"
        then
            [ newline, la ]
        else
            [
                //yield! beforeRight states la
                newline, la
            ]
        |> Some
    else
        None

/// 右中括号之前
let (|PEEK_RBRACK|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    if la = RBRACK then
        let vp =
            RightSententialForm.lookaheads.["]"]
            |> List.filter(fun (v) ->
                StackOps.isPrefixOf states v.prefix
            )

        if
            not vp.IsEmpty
            && vp.[0].head = "qualificationSuffix"
        then
            [ newline, la ]
        else
            [
                //yield! beforeRight states la
                newline, la
            ]
        |> Some
    else
        None

///当看见换行时，首先看是否简单续行
let (|PEEK_NEWLINE_FIRST|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    match newline with
    | None -> None
    | Some _ ->
        let noSemicolon =
            if
                // 当向前看不能跟在分号后面不加分号
                la
                |> FSharpToken.tag
                |> RightSententialForm.follow_semicolon.Contains
                |> not
            then
                true
            elif
                // 当栈顶不能在分号前面不加分号
                ViablePrefix.la_semicolon
                |> Seq.exists(fun vp -> vp.prefix |> StackOps.isPrefixOf states)
                |> not
            then
                true
            else
                false

        if noSemicolon then
            Some [ newline, la ]
        else
            None

///当看见换行时，截取栈顶越位线之上的状态
let (|PEEK_NEWLINE_OFFSIDE|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    match newline with
    | None -> None
    | Some i ->
        let stateRows =
            states
            |> List.map(fun st ->
                let sym = stateSymbols.[st.state]
                let pos = StackOps.getPosition st
                pos, sym, st
            )
            |> List.advanceWhile(fun (pos, _, _) ->
                match pos with
                | None -> true
                | Some j -> j <= i
            )
        let tk, rest = stateRows

        //返回和越位对齐的栈顶
        Some(List.rev(rest.Head :: tk))

///当看见换行，并且添加LLPAREN
let (|PEEK_NEWLINE_LLPAREN|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    match newline with
    | None -> None
    | Some i ->
        if
            ViablePrefix.la_llparen
            |> Seq.exists(fun vp -> vp.prefix |> StackOps.isPrefixOf states)
        then
            Some
                [
                    None, LLPAREN
                    newline, la
                ]
        else
            None

open StackOps

///当看见EOF
let (|PEEK_EOF|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    if la <> EOF then
        None
    else
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
        Some
            [
                match states with
                | TOP_SEMICOLON _ ->
                    let dummyStates = parser.shift states (Light.tokenRow None DUMMY)
                    yield None, DUMMY
                    yield! loop dummyStates
                | _ -> yield! loop states
                yield Some 0, la
            ]

///当看见SEMICOLON
let (|PEEK_SEMICOLON|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    if la <> SEMICOLON then
        None
    else
        let rec loop (seenOffside: bool) currentStates =
            [
                match seenOffside, currentStates with
                | false, LOOKAHEAD_RHSEND vp ->
                    yield None, RHSEND
                    //不能越过let =,不能越过precede_decl
                    let seenOffside =
                        vp.head = "letBinding"
                        || RightSententialForm.precede_declExpr.Contains
                            stateSymbols.[currentStates.[vp.prefix.Length].state]
                    let rhsendStates = parser.shift currentStates (Light.tokenRow None RHSEND)
                    yield! loop seenOffside rhsendStates

                | _, LOOKAHEAD_SEMICOLON _ -> ()
                | _ -> failwith "never"
            ]

        Some
            [
                match states with
                | TOP_SEMICOLON _ -> ()
                | _ -> yield! loop false states
                yield None, la
            ]

///当栈顶是semicolon && 后面跟着newline
let (|SEMICOLON_PEEK_NEWLINE|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    match newline with
    | None -> None
    | Some i ->
        let st =
            ViablePrefix.top_semicolon
            |> Set.filter(StackOps.isPrefixOf states)
        if st.IsEmpty then
            None
        else
            //栈顶一定是{prefix=[";";"revSequentialExpr"];head="revSequentialExpr"}

            //检查是否对齐，offside，但不能新建块
            let st = states.[1]
            Debug.Assert(( stateSymbols.[st.state]="revSequentialExpr"))
            match StackOps.getPosition st with
            | None -> failwith "前一条语句应该单独一行"
            | Some j ->
                if j < i then
                    failwith "不能新建块"
                elif j = i then
                    //对齐
                    Some [ newline, la ]
                else
                    //offside
                    let rec loop (seenOffside: bool) (currentStates: YaccState list) =
                        [
                            match currentStates with
                            | LOOKAHEAD_RRPAREN symbols -> //"rhsBlock"
                                yield None, RRPAREN
                                let nextStates = parser.shift currentStates (Light.tokenRow None RRPAREN)
                                let llparen = nextStates.[2..]
                                let vp =
                                    RightSententialForm.tops
                                    |> List.filter(fun v -> v.prefix.[0] = "LLPAREN")
                                    |> List.filter(fun v -> StackOps.isPrefixOf llparen v.prefix)



                                yield! loop seenOffside nextStates
                            | LOOKAHEAD_RHSEND _ ->
                                yield None, RHSEND
                                let nextStates = parser.shift currentStates (Light.tokenRow None RHSEND)
                                yield! loop seenOffside nextStates
                            | _ -> ()
                        ]
                    Some
                        [
                            match states with
                            | TOP_SEMICOLON _ ->
                                let dummyStates = parser.shift states (Light.tokenRow None DUMMY)
                                yield None, DUMMY
                                yield! loop false dummyStates
                            | _ -> yield! loop false states
                            yield Some 0, la
                        ]
