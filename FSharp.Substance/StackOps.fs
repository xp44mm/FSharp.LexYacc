module FSharp.Substance.StackOps

open FSharp.Idioms
open FSharp.LexYacc
open FSharp.Idioms.Literal

open System.Diagnostics
open System

let la_top_llparen =
    RightSententialForm.lookaheads
    |> List.filter(fun (v, la) ->
        match v.prefix with
        | "RRPAREN" :: _ -> true
        | _ -> false
    )
    |> List.filter(fun (v, la) ->
        match la with
        | ";" -> true
        | _ -> false
    )
    |> Set.ofList
    |> Set.toList

let la_llparen =
    RightSententialForm.lookaheads
    |> List.filter(fun (v, la) -> la = "LLPAREN")
    |> List.map fst

let la_rrparen =
    RightSententialForm.lookaheads
    |> List.filter(fun (v, la) -> la = "RRPAREN")
    |> List.map fst

let top_rrparen =
    RightSententialForm.tops
    |> List.filter(fun v ->
        not v.prefix.IsEmpty
        && v.prefix.[0] = "RRPAREN"
    )

let la_rhsend =
    RightSententialForm.lookaheads
    |> List.filter(fun (v, la) -> la = "RHSEND")
    |> List.map fst

let top_rhsend =
    RightSententialForm.tops
    |> List.filter(fun v ->
        not v.prefix.IsEmpty
        && v.prefix.[0] = "RHSEND"
    )

let top_semicolon =
    RightSententialForm.tops
    |> List.filter(fun v ->
        not v.prefix.IsEmpty
        && v.prefix.[0] = ";"
    )

let la_semicolon =
    RightSententialForm.lookaheads
    |> List.filter(fun (v, la) -> la = ";")
    |> List.map fst

let getSymbols (states: YaccState list) =
    states
    |> List.map(fun s -> FSharpYacc.stateSymbols.[s.state])

/// 这个函数是检查一个字符串列表（prefix）是否是另一个YaccState列表（states）的“前缀”。
let isPrefixOf (states: YaccState list) (symbols: string list) =
    let rec loop (sts: YaccState list) (syms: string list) =
        match sts, syms with
        | _, [] -> true
        | [], _ -> false
        | st :: restStates, sym :: restSymbols ->
            sym = FSharpYacc.stateSymbols.[st.state]
            && loop restStates restSymbols
    loop states symbols


let (|LOOKAHEAD_SEMICOLON|_|) (states: YaccState list) =
    la_semicolon
    |> List.map(fun v -> v.prefix)
    |> List.tryFind(isPrefixOf states)

let (|LOOKAHEAD_RRPAREN|_|) (states: YaccState list) =
    la_rrparen
    |> List.map(fun v -> v.prefix)
    |> List.tryFind(isPrefixOf states)

let (|LOOKAHEAD_RHSEND|_|) (states: YaccState list) =
    la_rhsend
    |> List.map(fun v -> v.prefix)
    |> List.tryFind(isPrefixOf states)

let (|TOP_SEMICOLON|_|) (states: YaccState list) =
    top_semicolon
    |> List.map(fun v -> v.prefix)
    |> List.tryFind(isPrefixOf states)

let (|TOP_RRPAREN|_|) (states: YaccState list) =
    top_rrparen
    |> List.map(fun v -> v.prefix)
    |> List.tryFind(isPrefixOf states)

let (|TOP_LEFT_BOUND|_|) (states: YaccState list) =
    match states with
    | [] -> None
    | s :: _ ->
        let tag = FSharpYacc.stateSymbols.[s.state]
        match tag with
        | "("
        | "LLPAREN"
        | "["
        | "[|" -> Some tag
        | _ -> None

/// 收尾符号升序排列，优先匹配最短的产生式
let rrparen_rhsend =
    [
        yield!
            RightSententialForm.rrparen
            |> List.map(fun prod -> prod, RRPAREN)

        yield!
            RightSententialForm.rhsend
            |> List.map(fun prod -> prod, RHSEND)
    ]
    |> List.sortBy fst

let getPosition (state: YaccState) =
    match FSharpYacc.stateSymbols.[state.state] with
    | "" -> Some 0
    | "("
    | ")"
    | ","
    | "-"
    | "."
    | ";"
    | "="
    | "FUN"
    | "LET"
    | "MODULE"
    | "OPEN"
    | "["
    | "[|"
    | "]"
    | "|]" -> unbox<option<int>> state.lexeme
    | "IDENT" ->
        unbox<option<int> * string> state.lexeme
        |> fst
    | "LITERAL" ->
        unbox<option<int> * Literal> state.lexeme
        |> fst
    | "appExpr"
    | "arrayExpr"
    | "atomicExpr"
    | "declExpr"
    | "lambdaExpr"
    | "letBinding"
    | "listExpr"
    | "parenExpr"
    | "tupleExpr"
    | "unaryExpr" ->
        unbox<option<int> * Expr> state.lexeme
        |> fst
    | "file" ->
        unbox<string list * Expr list> state.lexeme
        |> ignore
        Some 0
    | "longid" ->
        unbox<option<int> * string list> state.lexeme
        |> fst
    | "revAppExpr"
    | "revTupleExpr" ->
        unbox<(option<int> * Expr) list> state.lexeme
        |> List.last
        |> fst
    | "revSequentialExpr" ->
        //我们通常只关系最后（右）一个表达式的位置
        unbox<(option<int> * Expr) list> state.lexeme
        |> List.head
        |> fst

    | "revLongid" ->
        unbox<(option<int> * string) list> state.lexeme
        |> List.last
        |> fst

    | "rhsBlock"
    | "sequentialExpr" ->
        unbox<option<int> * Expr list> state.lexeme
        |> fst
    | "LLPAREN" -> failwith "请使用LLPAREN内部第一个语句的位置"
    | "RRPAREN"
    | "RHSEND" -> None
    | symbol -> failwith $"没有这个符号:{symbol}"

///栈顶的decl；可能不完整
let (|DECL_EXPR|_|) (states: YaccState list) =
    states
    |> List.tryFindIndex(fun s ->
        let tag = FSharpYacc.stateSymbols.[s.state]
        RightSententialForm.precede_declExpr.Contains tag
    )
    |> Option.map(fun i ->
        let states = states |> List.take i //实际上是count

        let pos = getPosition states.[states.Length - 1]
        let symbols =
            states
            |> List.map(fun s -> FSharpYacc.stateSymbols.[s.state])
        symbols, pos
    )

let (|LOOKAHEAD_LLPAREN|_|) (states: YaccState list) =
    la_llparen
    |> List.map(fun v -> v.prefix)
    |> List.tryFind(isPrefixOf states)
    |> Option.map(fun symbols ->
        let pos = getPosition states.[symbols.Length - 1]
        symbols, pos
    )

let tryPrefix (states: YaccState list) (prefix: string list) =
    let stateSymbols =
        states
        |> List.map(fun s -> FSharpYacc.stateSymbols.[s.state])

    if List.isPrefix prefix stateSymbols then
        states
        |> List.take prefix.Length
        |> Some
    else
        None

let tryFirstPrefix (states: YaccState list) (prefixes: string list list) =
    let stateSymbols =
        states
        |> List.map(fun s -> FSharpYacc.stateSymbols.[s.state])
    prefixes
    |> List.tryFind(fun prefix -> List.isPrefix prefix stateSymbols)

let tryFirstPrefix2 (states: YaccState list) (prefixes: (string list * 'a) list) =
    let stateSymbols =
        states
        |> List.map(fun s -> FSharpYacc.stateSymbols.[s.state])

    prefixes
    |> List.tryFind(fun (prefix, value) -> List.isPrefix prefix stateSymbols)

/// 缩回，关闭一个上下文
let tryUnindent (states: YaccState list) =
    let sentences = RightSententialForm.semicolon_rrparen_rhsend
    let punctuations = RightSententialForm.precede_declExpr

    let stateSymbols =
        states
        |> List.map(fun s -> FSharpYacc.stateSymbols.[s.state])

    sentences
    |> List.tryFind(fun (prefix, value) ->
        List.isPrefix prefix stateSymbols
        && punctuations.Contains stateSymbols.[prefix.Length]
    )

/// 活动模式：尝试缩回
let (|DeclExprWillEnd|_|) (states: YaccState list) = tryUnindent states

/// 取最短的上下文
let takeDeclExpr (states: YaccState list) =
    let stateSymbols =
        states
        |> List.map(fun s -> FSharpYacc.stateSymbols.[s.state])

    let punctuations = RightSententialForm.precede_declExpr
    match stateSymbols.[0] with
    | x when punctuations.Contains x -> Some(List.take 1 stateSymbols)
    | _ ->
        match List.tryFindIndex punctuations.Contains stateSymbols with
        | Some idx -> Some(List.take (idx + 1) stateSymbols)
        | None ->
            RightSententialForm.llparen
            |> List.tryFind(fun prefix -> List.isPrefix prefix stateSymbols)

let lefts = Map [ ")", "(" ]

let takeLeftBound (states: YaccState list) (rightBound: string) =
    let stateSymbols =
        states
        |> List.map(fun s -> FSharpYacc.stateSymbols.[s.state])

    let leftBound = lefts.[rightBound]

    if stateSymbols.[0] = rightBound then
        let ls =
            stateSymbols
            |> List.indexed
            |> List.choose(fun (i, sym) -> if sym = leftBound then Some i else None)
        ls.[1]

    else
        stateSymbols
        |> List.findIndex((=) leftBound)
