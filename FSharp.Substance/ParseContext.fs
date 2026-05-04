module FSharp.Substance.ParseContext

open FSharp.Substance.FSharpYacc
open FSharp.Substance.RightSententialForm

open FSharp.Idioms
open FSharp.Idioms.Literal

// 上下文从状态栈到token队列依次的命名为：lead top gap la

open FSharp.LexYacc

open System
open System.Diagnostics
open StackOps

/// 无条件补齐所有省略的虚拟结束token
let offside_rrparen_or_rhsend (states: YaccState list) =
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

/// 当看见EOF
let (|PEEK_EOF|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    if la <> EOF then
        None
    else
        Some
            [
                yield! offside_rrparen_or_rhsend states
                yield Some 0, la
            ]

/// 右圆括号之前
let (|PEEK_RPAREN|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    if la = RPAREN then
        if
            RightSententialForm.lookaheads.[")"]
            |> Set.exists(fun v -> StackOps.isPrefixOf states v.prefix)
        then
            Some [ newline, la ]
        else
            let i = StackOps.balanceLeft "(" ")" states
            let inner = List.take i states
            Some
                [
                    yield! offside_rrparen_or_rhsend inner
                    yield newline, la
                ]
    else
        None

/// 右方括号之前
let (|PEEK_RBRACK|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    if la = RBRACK then
        if
            RightSententialForm.lookaheads.["]"]
            |> Set.exists(fun v -> StackOps.isPrefixOf states v.prefix)
        then
            Some [ newline, la ]
        else
            let i = StackOps.balanceLeft "[" "]" states
            let inner = List.take i states
            Some
                [
                    yield! offside_rrparen_or_rhsend inner
                    yield newline, la
                ]
    else
        None

/// 当看见SEMICOLON
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

///当栈顶是SEMICOLON && 后面跟着NEWLINE
let (|SEMICOLON_PEEK_NEWLINE|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    match newline with
    | None -> None
    | Some i ->
        let st =
            tops.[";"]
            |> Set.filter(fun v -> v.prefix |> StackOps.isPrefixOf states)
        if st.IsEmpty then
            None
        else
            //栈顶一定是{prefix=[";";"revSequentialExpr"];head="revSequentialExpr"}

            //检查是否对齐，offside，但不能新建块
            let st = states.[1]
            Debug.Assert((stateSymbols.[st.state] = "revSequentialExpr"))
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
                                let nextStates =
                                    parser.shift currentStates (Light.tokenRow None RRPAREN)
                                //看block所属的头位置
                                let llparen = nextStates.[2..]
                                let vp =
                                    RightSententialForm.tops.["LLPAREN"]
                                    |> Set.filter(fun v -> StackOps.isPrefixOf llparen v.prefix)
                                    |> Seq.exactlyOne
                                let seenOffside =
                                    let pos = getPosition llparen.[vp.prefix.Length - 1]
                                    match pos with
                                    | None ->
                                        //stateSymbols.[llparen.[vp.prefix.Length].state]
                                        //|> precede_declExpr.Contains
                                        match vp.head with
                                        | "letBinding"
                                        | "file" -> failwith "必须新启一行"
                                        | "lambdaExpr" ->
                                            //let a = fun b -> fun c ->
                                            //    top;
                                            //lookahead()
                                            //没有越位，继续rhsend
                                            false
                                        | _ -> failwith $"SEMICOLON_PEEK_NEWLINE:{vp.head}"
                                    | Some jj -> jj >= i

                                yield! loop seenOffside nextStates
                            | LOOKAHEAD_RHSEND _ ->
                                yield None, RHSEND
                                let nextStates =
                                    parser.shift currentStates (Light.tokenRow None RHSEND)

                                yield! loop seenOffside nextStates
                            | _ -> ()
                        ]
                    Some
                        [
                            yield None, DUMMY
                            let dummyStates = parser.shift states (Light.tokenRow None DUMMY)
                            yield! loop false dummyStates
                            yield Some 0, la
                        ]

///看见换行时，看是否是续行
let (|PEEK_NEWLINE_APP|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    match newline with
    | None -> None
    | Some i ->
        let la_tag = FSharpToken.tag la
        //不加分号
        let noSemicolon =
            if
                la_tag
                |> follow_semicolon.Contains
                |> not
            then
                // 当向前看不能跟在分号后面
                true
            else
                //原理：appExpr每次应用后面都可以跟随分号
                match
                    ViablePrefix.la_semicolon
                    |> Seq.tryFind(fun vp -> vp.prefix |> StackOps.isPrefixOf states)
                with
                | None ->
                    // 原理：即使缺少rrparen, rhsend的栈顶也是可以跟随分号
                    // 不能跟随分号，意味着末尾是逗号，infix等未完成的decl
                    true
                | Some vp ->
                    // 此时栈顶符合APP的前缀
                    let rec loop (vp: ViablePrefix) (suffix_states: YaccState list) =
                        let lead = suffix_states.[vp.prefix.Length - 1]
                        match StackOps.getPosition lead with
                        | Some j ->
                            // 当新行继续缩进的时候，表示是APP续行
                            j < i
                        | None ->
                            let topVp =
                                tops.[stateSymbols.[lead.state]]
                                |> Seq.find(fun vp ->
                                    vp.prefix
                                    |> StackOps.isPrefixOf suffix_states
                                )
                            let suffix_states = suffix_states.[vp.prefix.Length - 1 ..]
                            loop topVp suffix_states

                    //首先看la是否是valueExpr这是app的条件；再看缩进是否符合APP
                    first_valueExpr.Contains la_tag
                    && loop vp states

        if noSemicolon then
            Some [ newline, la ]
        else
            None

/// 补齐rrparen,rhsend,semicolon => offside
let (|PEEK_NEWLINE_OFFSIDE|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    match newline with
    | None -> None
    | Some i ->
        //此时已经排除了la<>decl first，已经排除了stack top follow semicolon
        let tops = 
            top_prefixes
            |> Map.filter(fun prefix heads -> prefix |> StackOps.isPrefixOf states)

        Some tops
