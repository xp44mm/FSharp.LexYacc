module FSharp.Substance.StackOps

open FSharp.Substance.FSharpYacc
open FSharp.Substance.RightSententialForm

open FSharp.Idioms
open FSharp.Idioms.Literal

open FSharp.LexYacc

open System
open System.Diagnostics

let getPosition (state: YaccState) =
    match stateSymbols.[state.state] with
    | "!"
    | "#"
    | "("
    | "(|"
    | ")"
    | "+"
    | ","
    | "-"
    | "->"
    | "."
    | ":"
    | ";"
    | "<"
    | "<-"
    | "="
    | ">"
    | "DO"
    | "EOF"
    | "FUN"
    | "LET"
    | "LLPAREN"
    | "MATCH"
    | "MODULE"
    | "OPEN"
    | "RHSEND"
    | "RRPAREN"
    | "WHITESPACE"
    | "WITH"
    | "["
    | "[|"
    | "]"
    | "opt_semicolon"
    | "{"
    | "{|"
    | "|"
    | "|)"
    | "|]"
    | "|}"
    | "}" -> unbox<option<int>> state.lexeme
    | "ALWAYS_INFIX"
    | "ALWAYS_PREFIX"
    | "IDENT"
    | "TYPAR"
    | "infix"
    | "prefix" ->
        unbox<option<int> * string> state.lexeme
        |> fst
    | "LITERAL" ->
        unbox<option<int> * Literal> state.lexeme
        |> fst
    | "appExpr"
    | "arrayExpr"
    | "atomicExpr"
    | "binaryExpr"
    | "declExpr"
    | "identExpr"
    | "lambdaExpr"
    | "letBinding"
    | "listExpr"
    | "openOrLet"
    | "parenExpr"
    | "qualificationExpr"
    | "qualificationSuffix"
    | "tupleExpr"
    | "unaryExpr"
    | "valueExpr" ->
        unbox<option<int> * Expr> state.lexeme
        |> fst
    | "appType" ->
        unbox<(option<int> * TypeArgument) * list<option<int> * SuffixType>> state.lexeme
        |> fst
        |> fst
    | "atomType"
    | "typeArgument" ->
        unbox<option<int> * TypeArgument> state.lexeme
        |> fst
    | "atomicPattern"
    | "bindingPattern"
    | "parameterPattern" ->
        unbox<option<int> * Pattern> state.lexeme
        |> fst
    | "file" -> None //unbox<list<string>*list<Expr>> state.lexeme
    | "funType"
    | "tupleType"
    | "typeArguments" ->
        unbox<list<option<int> * TypeArgument>> state.lexeme
        |> List.head
        |> fst
    | "longid" ->
        unbox<option<int> * list<string>> state.lexeme
        |> fst
    | "revAppExpr"
    | "revOpenOrLets"
    | "revQualificationExpr"
    | "revSequentialExpr"
    | "revTupleExpr" ->
        unbox<list<option<int> * Expr>> state.lexeme
        |> List.head
        |> fst
    | "revBinaryExpr" ->
        unbox<list<(option<int> * string) * (option<int> * Expr)>> state.lexeme
        |> List.head
        |> snd
        |> fst
    | "revLongid" ->
        unbox<list<option<int> * string>> state.lexeme
        |> List.head
        |> fst
    | "rhsBlock" ->
        unbox<option<int> * list<Expr>> state.lexeme
        |> fst
    | "suffixType" ->
        unbox<option<int> * SuffixType> state.lexeme
        |> fst
    | "tuplePattern" ->
        unbox<list<option<int> * Pattern>> state.lexeme
        |> List.head
        |> fst

    | symbol -> failwith $"没有这个符号:{symbol}"

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

let equals (states: YaccState list) (symbols: string list) =
    let rec loop (sts: YaccState list) (syms: string list) =
        match sts, syms with
        | [], [] -> true
        | _, []
        | [], _ -> false
        | st :: restStates, sym :: restSymbols ->
            sym = stateSymbols.[st.state]
            && loop restStates restSymbols
    loop states symbols

let (|OPEN_LONGID|_|) (states: YaccState list) =
    let open_longid =
        [
            [
                "IDENT"
                "."
                "revLongid"
                "OPEN"
            ]
            [
                "IDENT"
                "OPEN"
            ]
        ]
    open_longid
    |> Seq.tryFind(isPrefixOf states)
    |> Option.map(fun symbols ->
        let lead = states.[symbols.Length - 1]
        symbols, getPosition lead
    )

///栈顶
let (|STACK_TOP|) (states: YaccState list) =
    let top = stateSymbols.[states.[0].state]
    let ls =
        top_prefixes
        |> Map.filter(fun prefix _ -> prefix |> isPrefixOf states)

    if ls.IsEmpty then
        Console.WriteLine("// 栈顶形状不匹配")
        Console.WriteLine("let 可能的栈顶 = " + stringify ls)
        Console.WriteLine(
            "let 此栈的形状 = "
            + stringify(getSymbols states)
        )
        failwith "notImpl"
    else
        ls

let (|TOP_RRPAREN|_|) (states: YaccState list) =
    top_prefixes
    |> Seq.tryFind(fun kvp -> isPrefixOf states kvp.Key)

let (|TOP_RHSEND|_|) (states: YaccState list) =
    top_prefixes
    |> Seq.tryFind(fun kvp -> isPrefixOf states kvp.Key)

let (|TOP_SEMICOLON|_|) (states: YaccState list) =
    top_prefixes
    |> Seq.tryFind(fun kvp -> isPrefixOf states kvp.Key)

let (|LOOKAHEAD_LLPAREN|_|) (states: YaccState list) =
    RightSententialForm.lookaheads.["LLPAREN"]
    |> Seq.tryFind(fun vp -> vp.prefix |> isPrefixOf states)

let (|LOOKAHEAD_RRPAREN|_|) (states: YaccState list) =
    RightSententialForm.lookaheads.["RRPAREN"]
    |> Seq.tryFind(fun vp -> vp.prefix |> isPrefixOf states)

let (|LOOKAHEAD_RHSEND|_|) (states: YaccState list) =
    RightSententialForm.lookaheads.["RHSEND"]
    |> Seq.tryFind(fun vp -> vp.prefix |> isPrefixOf states)

let (|LOOKAHEAD_SEMICOLON|_|) (states: YaccState list) =
    let m =
        RightSententialForm.lookaheads.[";"]
        |> Set.filter(fun vp -> vp.prefix |> isPrefixOf states)

    if m.IsEmpty then None else Some m

///向前看见一个右括号，向栈内找配对的左括号
let balanceLeft (left: string) (right: string) (states: YaccState list) =
    let rec loop (acc: YaccState list) i (ls: YaccState list) =
        match i, ls with
        | 0, _ -> acc.Length - 1
        | _, [] -> failwith "no balance"
        | _, h :: t ->
            let sym = stateSymbols.[h.state]
            let i =
                if sym = left then (i - 1)
                elif sym = right then (i + 1)
                else i
            loop (h :: acc) i t
    loop [] 1 states

/// truncate context
let (|Offside|Aligned|NewBlock|) (i: int) (states: YaccState list) =
    let rec loop rev (rest: YaccStateInfo list) =
        match rest with
        | [] ->
            //没有找到
            NewBlock
        | h :: t ->
            match h.position with
            | None -> loop (h :: rev) t
            | Some j ->
                if j > i then loop (h :: rev) t
                elif j = i then Aligned(List.rev rev)
                else Offside(List.rev rev)
    states
    |> List.map YaccStateInfo.from
    |> loop []

/// truncate context
let getLatestLine (states: YaccState list) =
    let i =
        states
        |> List.findIndex(fun st ->
            let info = YaccStateInfo.from st
            info.position.IsSome
        )
    states.[..i]
