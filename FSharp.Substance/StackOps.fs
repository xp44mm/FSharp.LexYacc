module FSharp.Substance.StackOps

open FSharp.Substance.FSharpYacc
open FSharp.Substance.ViablePrefix

open FSharp.Idioms
open FSharp.Idioms.Literal

open FSharp.LexYacc

open System
open System.Diagnostics


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

let (|StartsWith|_|) (prefix: string list) (states: YaccState list) =
    if isPrefixOf states prefix then
        Some()
    else None

///向前看见一个右括号，向栈内找配对的左括号
let balanceLeft (left: string) (right: string) (states: YaccState list) =
    let rec loop (acc: YaccState list) (i: int) (ls: YaccState list) =
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

///向前看见一个右括号，向栈内找配对的左括号
let tryBalance (left: string) (right: string) (states: YaccState list) =
    let rec loop (acc: YaccState list) (i: int) (ls: YaccState list) =
        match i, ls with
        | 0, _ ->
            // 返回左括号符号和它的位置（即最后一个acc元素的索引）
            let leftState = List.head acc // acc的第一个元素是匹配的左括号状态
            let leftSymbol = stateSymbols.[leftState.state]
            let position = acc.Length - 1 // 左括号在原始列表中的位置偏移
            Some(leftSymbol, position)
        | _, [] -> None
        | _, h :: t ->
            let sym = stateSymbols.[h.state]
            let i =
                if sym = left then (i - 1)
                elif sym = right then (i + 1)
                else i
            loop (h :: acc) i t
    loop [] 1 states

/// 注：可以利用第一个返回值确定匹配的括号
let (|Balanced|_|) (states: YaccState list) =
    let pairs = [
        ("{", "}")
        ("[", "]")
        ("(", ")")
        ("[|", "|]")
    ]    
    pairs |> List.tryPick (fun (left, right) -> tryBalance left right states)

let nextTops (symbol: string) (states: YaccState list) =
    TopConfig.catalog.[symbol]
    |> List.filter(fun (px, hds) -> isPrefixOf states px)

let firstTops (states: YaccState list) =
    let symbol = FSharpYacc.stateSymbols.[states.[0].state]
    symbol, nextTops symbol states.Tail

let (|Lookahead|_|) (las: seq<string list * string Set>) (states: YaccState list) =
    let st =
        las
        |> Seq.filter(fun (prefix, prod_heads) -> isPrefixOf states prefix)
        |> Set.ofSeq
        |> Set.toArray
    if st.Length = 0 then None else Some st

let (|TryFind|_|) (prefixes: seq<string list>) (states: YaccState list) =
    prefixes
    |> Seq.tryFind(fun prefix -> isPrefixOf states prefix)

// 先获取第一个状态的符号
let (|FirstStateSymbol|_|) (states: YaccState list) =
    match states with
    | h :: _ -> Some FSharpYacc.stateSymbols.[h.state]
    | _ -> None

/// 无条件补齐所有省略的虚拟结束token
let rrparen_or_rhsend (states: YaccState list) : (int option * FSharpToken) list =
    let rec loop (currentStates: YaccState list) =
        [
            match currentStates with
            //| Lookahead LookaheadConfig0.RHSEND ls ->

            //    yield None, RHSEND
            //    let nextStates = parser.shift currentStates Light.None_RHSEND
            //    yield! loop nextStates
            //| Lookahead LookaheadConfig0.RRPAREN _ ->
            //    yield None, RRPAREN
            //    let nextStates = parser.shift currentStates Light.None_RRPAREN
            //    yield! loop nextStates
            | _ -> ()
        ]
    loop states

let newline_decl_rhsend_or_rrparen (i: int) (states: YaccState list) =
    let rec loop (current_states: YaccState list) =
        let continue_loop (rtok: FSharpToken) =
            let next_states = parser.shift current_states (Light.none rtok)
            [
                (None: int option), rtok
                yield! loop next_states
            ]

        match current_states with
        //| Lookahead LookaheadConfig0.LLPAREN st ->
        //    let prefix, _ = Seq.exactlyOne st
        //    let firstDecl = YaccStateInfo.from current_states.[prefix.Length - 2]
        //    match firstDecl.position with
        //    | Some j ->
        //        if i = j then
        //            //内部对齐，停止补充
        //            []
        //        elif i < j then
        //            //offside
        //            continue_loop LLPAREN
        //        else
        //            //更加缩进
        //            []
        //    | None -> failwith "llparen must newline."

        //| Lookahead LookaheadConfig0.RHSEND st ->
        //    let prefix, heads = st |> Seq.exactlyOne
        //    //match,function
        //    let keyword = YaccStateInfo.from current_states.[prefix.Length - 1]

        //    match keyword.position with
        //    | Some j ->
        //        if i = j then
        //            //内部对齐，停止补充
        //            [ None, RHSEND ]
        //        elif i < j then
        //            //offside
        //            continue_loop RHSEND
        //        else
        //            //更加缩进
        //            []
        //    | None ->
        //        //嵌套的match/function
        //        continue_loop RHSEND

        | _ -> []

    loop states

/// 从栈顶往下找到集合中的第一个Tag
let findTag (rest_states: YaccState list) (keys: string Set) =
    rest_states
    |> Seq.pick(fun s ->
        let lead = YaccStateInfo.from s
        if keys.Contains lead.tag then
            Some lead
        else
            None
    )

/// 从栈顶往下找到集合中的第一个Tag
let findIndex (rest_states: YaccState list) (keys: string Set) =
    rest_states
    |> List.findIndex(fun s ->
        let lead = YaccStateInfo.from s
        keys.Contains lead.tag
    )

