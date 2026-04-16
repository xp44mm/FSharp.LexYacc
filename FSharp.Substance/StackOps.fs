module FSharp.Substance.StackOps

open FSharp.Idioms
open FSharp.LexYacc
open FSharp.Idioms.Literal

open System.Diagnostics
open System

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

let getSymbols (states: YaccState list) =
    states
    |> List.map(fun s -> FSharpYacc.stateSymbols.[s.state])

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
    | "revSequentialExpr"
    | "revTupleExpr" ->
        unbox<(option<int> * Expr) list> state.lexeme
        |> List.last
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
