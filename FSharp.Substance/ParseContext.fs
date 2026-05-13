module FSharp.Substance.ParseContext

open FSharp.Substance.FSharpYacc
open FSharp.Substance.RightSententialForm
open FSharp.Substance.ViablePrefix

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
            match Punctuation.exists currentStates with
            | SEMICOLON -> ()
            | tok ->
                yield None, tok
                let nextStates = parser.shift currentStates (Light.tokenRow None tok)
                yield! loop nextStates
        ]
    loop states

/// 根据前后的词法lookahead,top
let (|PEEK_NEWLINE_MODULE|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    match newline with
    | None -> None
    | Some i ->
        let la_tag = FSharpToken.tag la
        if follow_semicolon.Contains la_tag then
            if
                module_statement
                |> Seq.exists(fun prefix -> isPrefixOf states prefix)
            then
                Debug.WriteLine($"MODULE语句不加分号")
                Some [ newline, la ]
            elif
                open_statement
                |> Seq.exists(fun prefix -> isPrefixOf states prefix)
            then
                Debug.WriteLine($"OPEN语句加分号")
                Some
                    [
                        None, SEMICOLON
                        newline, la
                    ]
            elif
                lookahead_llparen //此处需要分情况进一步查找栈底
                |> Set.exists(fun prefix -> StackOps.isPrefixOf states prefix)
            then
                Debug.WriteLine($"右手边开始，加LLPAREN")
                Some
                    [
                        None, LLPAREN
                        newline, la
                    ]
            elif
                stateSymbols.[states.[0].state]
                |> precede_semicolon.Contains
                |> not
            then
                Debug.WriteLine($"行末单词不可以加分号，不加分号")
                Some [ newline, la ]
            else
                None
        else
            Debug.WriteLine($"行首单词不能跟在分号后面，不加分号：{stringify la}")
            Some [ newline, la ]

/// 右括号之前
let (|PEEK_RPAREN|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    if la = RPAREN then
        if
            lookahead_rparen
            |> Set.exists(fun v -> StackOps.isPrefixOf states v)
        then
            Some [ newline, la ]
        else
            let i = StackOps.balanceLeft "(" ")" states
            let inner = List.take (i + 1) states
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
            lookahead_rbrack
            |> Set.exists(fun v -> StackOps.isPrefixOf states v)
        then
            Some [ newline, la ]
        else
            let i = StackOps.balanceLeft "[" "]" states
            let inner = List.take (i + 1) states
            Some
                [
                    yield! offside_rrparen_or_rhsend inner
                    yield newline, la
                ]
    else
        None

/// EOF之前
let (|PEEK_EOF|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    if la = EOF then
        Some
            [
                yield! offside_rrparen_or_rhsend states
                yield Some 0, EOF
            ]
    else
        None

///补充分号，补充分号之前需要补充rrparen,rhsend
let (|PEEK_NEW_BLOCK|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    match newline with
    | None -> None
    | Some i ->
        let line = StackOps.getLatestLine states
        let lead = YaccStateInfo.from(List.last line)
        if lead.position.Value < i then
            Some [ newline, la ]
        else
            None

/// 当看见SEMICOLON
let (|PEEK_SEMICOLON|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    if la <> SEMICOLON then
        None
    else
        let rec loop currentStates =
            [
                match Punctuation.find currentStates with
                | SEMICOLON, [] -> ()
                | (tok, prefix) ->
                    yield None, tok
                    let longer =
                        match prefix.[prefix.Length - 1] with
                        | "LET"
                        | "|"
                        | "{"
                        | "fieldBindings" ->
                            //不能越过let _ =；不能越过match子句
                            false
                        | "FUN" ->
                            //检测前缀是否是独立的DECL
                            let prevState = currentStates.[prefix.Length]
                            stateSymbols.[prevState.state]
                            |> Punctuation.is_new_decl
                            |> not
                        | _ -> failwith "never"
                    if longer then
                        let rhsendStates = parser.shift currentStates Light.None_RHSEND
                        yield! loop rhsendStates
            ]
        Some
            [

                match states with
                | st :: _ when
                    (let info = YaccStateInfo.from st
                     info.tag = "SEMICOLON")
                    ->
                    //如果前面是semicolon，过滤掉本semicolon
                    ()
                | _ ->
                    yield! loop states
                    yield None, la
            ]

let (|PEEK_NEWLINE_NEW_DECL|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    match newline with
    | None -> None
    | Some i ->
        let la_tag = FSharpToken.tag la
        if follow_semicolon.Contains(la_tag) then
            let rec loop (currentStates: YaccState list) =
                [
                    match Punctuation.find currentStates with
                    | SEMICOLON, [] -> ()
                    | right_tok, prefix ->
                        let lead = currentStates.[prefix.Length - 1]
                        let info = YaccStateInfo.from lead
                        match info.position with
                        | Some j when i > j -> ()
                        | _ ->
                            yield None, right_tok
                            let next = parser.shift currentStates (Light.tokenRow None right_tok)
                            yield! loop next
                ]

            Some
                [
                    yield! loop states
                    None, SEMICOLON
                    newline, la
                ]

        else
            None

let (|PEEK_BAR|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    // 问题：bar不总是子句的引导，模式中的bar，可区分联合的bar,还有香蕉夹
    match la with
    | BAR ->
        let vps =
            lookahead_bar
            |> Set.filter(fun prefix ->
                let top = prefix.[0]
                top = "WITH" || top = "FUNCTION"
            )
            |> Seq.tryFind(isPrefixOf states)

        match vps with
        | Some prefix ->
            let aligned =
                match newline with
                | None -> true
                | Some i ->
                    let lead = YaccStateInfo.from states.[prefix.Length - 1]
                    match lead.position with
                    | None -> false
                    | Some j -> i = j
            //这是top = "WITH" || "FUNCTION"
            if aligned then
                Some [ newline, la ]
            else
                failwith "`match`子句没有对齐"
        | None ->
            let rec loop (currentStates: YaccState list) =
                seq {
                    match Punctuation.find currentStates with
                    | SEMICOLON, [] -> ()
                    | virtual_tok, prefix ->
                        let ended =
                            if prefix.[prefix.Length - 1] = "patternAndGuard" then
                                //前面是bar / with / function领头
                                let lead = YaccStateInfo.from currentStates.[prefix.Length]
                                //需要对齐
                                let aligned =
                                    match newline, lead.position with
                                    | None, _ -> true
                                    | Some i, Some j when i = j -> true
                                    | _ -> false
                                //如果是ruleClause && aligned 那么表示结束补齐虚拟token的循环
                                aligned
                            else
                                //继续查找下一个虚拟token
                                false
                        yield None, virtual_tok
                        let nextStates =
                            parser.shift currentStates (Light.tokenRow None virtual_tok)
                        if not ended then
                            yield! loop nextStates
                }
            Some
                [
                    yield! loop states
                    newline, la
                ]

    | _ -> None
/// 右花括号之前
let (|PEEK_RBRACE|_|) (states: YaccState list, newline: int option, la: FSharpToken) =
    if la = RBRACE then
        if
            lookahead_rbrace
            |> Set.exists(StackOps.isPrefixOf states)
        then
            Some [ newline, la ]
        else
            let i = StackOps.balanceLeft "{" "}" states
            let inner = List.take (i + 1) states
            Some
                [
                    yield! offside_rrparen_or_rhsend inner
                    yield newline, la
                ]
    else
        None
