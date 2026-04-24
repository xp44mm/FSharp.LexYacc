module FSharp.Substance.StackOps

open FSharp.Substance.FSharpYacc

open FSharp.Idioms
open FSharp.Idioms.Literal

open FSharp.LexYacc

open System
open System.Diagnostics

let getPosition (state: YaccState) =
    match stateSymbols.[state.state] with
    | "("
    | ")"
    | ","
    | "-"
    | "."
    | ";"
    | "="
    | "DUMMY"
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
    | "lambdaOrTupleExpr"
    | "letBinding"
    | "listExpr"
    | "parenExpr"
    | "tupleExpr"
    | "unaryExpr" ->
        unbox<option<int> * Expr> state.lexeme
        |> fst
    | "file" ->
        unbox<list<string> * list<Expr>> state.lexeme
        |> ignore
        None
    | "longid" ->
        unbox<option<int> * list<string>> state.lexeme
        |> fst
    | "revAppExpr"
    | "revSequentialExpr"
    | "revTupleExpr" ->
        unbox<list<option<int> * Expr>> state.lexeme
        |> List.head
        |> fst
    | "revLongid" ->
        unbox<list<option<int> * string>> state.lexeme
        |> List.head
        |> fst
    | "rhsBlock"
    | "sequentialExpr" ->
        unbox<option<int> * list<Expr>> state.lexeme
        |> fst
    | symbol -> failwith $"没有这个符号:{symbol}"

//| "" -> Some 0
//| "("
//| ")"
//| ","
//| "-"
//| "."
//| ";"
//| "="
//| "FUN"
//| "LET"
//| "MODULE"
//| "OPEN"
//| "["
//| "[|"
//| "]"
//| "|]" -> unbox<option<int>> state.lexeme
//| "IDENT" ->
//    unbox<option<int> * string> state.lexeme
//    |> fst
//| "LITERAL" ->
//    unbox<option<int> * Literal> state.lexeme
//    |> fst
//| "appExpr"
//| "arrayExpr"
//| "atomicExpr"
//| "declExpr"
//| "lambdaExpr"
//| "letBinding"
//| "listExpr"
//| "parenExpr"
//| "tupleExpr"
//| "unaryExpr" ->
//    unbox<option<int> * Expr> state.lexeme
//    |> fst
//| "file" ->
//    unbox<string list * Expr list> state.lexeme
//    |> ignore
//    Some 0
//| "longid" ->
//    unbox<option<int> * string list> state.lexeme
//    |> fst
//| "revAppExpr"
//| "revTupleExpr" ->
//    unbox<(option<int> * Expr) list> state.lexeme
//    |> List.last
//    |> fst
//| "revSequentialExpr" ->
//    unbox<(option<int> * Expr) list> state.lexeme
//    |> List.head
//    |> fst

//| "revLongid" ->
//    unbox<(option<int> * string) list> state.lexeme
//    |> List.last
//    |> fst

//| "rhsBlock"
//| "sequentialExpr" ->
//    unbox<option<int> * Expr list> state.lexeme
//    |> fst
//| "LLPAREN" -> failwith "请使用LLPAREN内部第一个语句的位置"
//| "RRPAREN"
//| "RHSEND" -> None

let getSymbols (states: YaccState list) =
    states
    |> List.map(fun s -> stateSymbols.[s.state])

/// 这个函数是检查一个字符串列表（prefix）是否是另一个YaccState列表（states）的“前缀”。
let isPrefixOf (states: YaccState list) (symbols: string list) =
    let rec loop (sts: YaccState list) (syms: string list) =
        match sts, syms with
        | _, [] -> true
        | [], _ -> false
        | st :: restStates, sym :: restSymbols ->
            sym = stateSymbols.[st.state]
            && loop restStates restSymbols
    loop states symbols

let (|TOP_LEFT_BOUND|_|) (states: YaccState list) =
    match states with
    | s :: _ ->
        let tag = stateSymbols.[s.state]
        match tag with
        | "("
        | "LLPAREN"
        | "["
        | "[|" -> Some tag
        | _ -> None
    | [] -> None

let (|TOP_RRPAREN|_|) (states: YaccState list) =
    ViablePrefix.top_rrparen
    |> Seq.tryFind(isPrefixOf states)

let (|TOP_RHSEND|_|) (states: YaccState list) =
    ViablePrefix.top_rhsend
    |> Seq.tryFind(isPrefixOf states)

let (|TOP_SEMICOLON|_|) (states: YaccState list) =
    ViablePrefix.top_semicolon
    |> Seq.tryFind(isPrefixOf states)

let (|LOOKAHEAD_LLPAREN|_|) (states: YaccState list) =
    ViablePrefix.la_llparen
    |> Seq.tryFind(isPrefixOf states)

let (|LOOKAHEAD_RRPAREN|_|) (states: YaccState list) =
    ViablePrefix.la_rrparen
    |> Seq.tryFind(isPrefixOf states)

let (|LOOKAHEAD_RHSEND|_|) (states: YaccState list) =
    ViablePrefix.la_rhsend
    |> Seq.tryFind(isPrefixOf states)

let (|LOOKAHEAD_SEMICOLON|_|) (states: YaccState list) =
    ViablePrefix.la_semicolon
    |> Seq.tryFind(isPrefixOf states)

let (|OPEN_LONGID|_|) (states: YaccState list) =
    RightSententialForm.open_longid
    |> Seq.tryFind(isPrefixOf states)
    |> Option.map(fun symbols ->
        let lead = states.[symbols.Length - 1]
        symbols, getPosition lead
    )

///栈顶的decl；可能不完整
let (|DECL_EXPR|_|) (states: YaccState list) =
    stateSymbols.[states.[0].state]
    |> ViablePrefix.topOf
    |> Seq.tryFind(fun symbols ->
        Console.WriteLine($"DECL_EXPR:{stringify symbols}")
        isPrefixOf states symbols
        && RightSententialForm.precede_declExpr.Contains
            stateSymbols.[states.[symbols.Length].state]
    )
    |> Option.map(fun symbols ->
        let lead = states.[symbols.Length - 1]
        symbols, getPosition lead
    )

//let tryHeadProd (states: YaccState list) =
