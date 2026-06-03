module FSharp.LexYacc.ViablePrefixData

let generateConfig (loop: string -> seq<string list * string>) (st: Set<string>) =
    st
    |> Seq.collect(fun symbol ->
        loop symbol
        |> Seq.map(fun (prefix, head) -> symbol, prefix, head)
    )
    |> Seq.groupBy(fun (symbol, prefix, hd) -> symbol, prefix)
    |> Seq.map(fun ((symbol, prefix), items) ->
        let heads =
            items
            |> Seq.map(fun (_, _, h) -> h)
            |> Set.ofSeq
        symbol, (prefix, heads)
    )
    |> Seq.groupBy fst
    |> Seq.map(fun (symbol, sq) ->
        let ls = sq |> Seq.map snd |> Set.ofSeq
        symbol, ls
    )
    |> Map.ofSeq

let loop_getTops (bnf: BNF) =
    let rec loop (visited: Set<string>) (topSymbol: string) =
        seq {
            for prod in bnf.productions do
                match prod with
                | head :: body ->
                    match List.tryFindIndex ((=) topSymbol) body with
                    | Some 0 ->
                        if not(visited.Contains head) then
                            let vst = Set.add head visited
                            yield! loop vst head
                    | Some idx ->
                        // 不包括自己
                        let leftPart = body |> List.take idx |> List.rev
                        yield leftPart, head
                    | None -> ()
                | [] -> ()
        }
    loop

/// 符号已经移入栈中的形状
let getTops (bnf: BNF) =
    bnf.symbols
    |> generateConfig(loop_getTops bnf Set.empty)

let getTopTerminals (bnf: BNF) =
    bnf.terminals
    |> Seq.collect(fun symbol ->
        loop_getTops bnf Set.empty symbol
        |> Seq.map(fun (prefix, head) -> symbol, prefix, head)
    )
    |> Seq.groupBy(fun (symbol, prefix, hd) -> symbol, prefix)
    |> Seq.map(fun ((symbol, prefix), items) ->
        let heads =
            items
            |> Seq.map(fun (_, _, h) -> h)
            |> Set.ofSeq
        symbol :: prefix, heads
    )
    |> Set.ofSeq

let rec loop_getLookaheads (bnf: BNF) (visited: Set<string>) (symbol: string) =
    seq {
        for prod in bnf.productions do
            match prod with
            | head :: body ->
                match List.tryFindIndex ((=) symbol) body with
                | Some 0 ->
                    if not(visited.Contains head) then
                        let vst = Set.add head visited
                        yield! loop_getLookaheads (bnf: BNF) vst head
                | Some idx ->
                    // 不包括自己
                    let leftPart = body |> List.take idx |> List.rev
                    let derivations = BnfUtils.derive bnf leftPart
                    for prefix in derivations do
                        yield prefix, head
                | None -> ()
            | [] -> ()
    }

/// 前瞻符号，将要移入栈中的形状
let getLookaheads (bnf: BNF) =
    bnf.terminals
    |> generateConfig(loop_getLookaheads (bnf: BNF) Set.empty)

/// 前瞻符号，将要移入栈中的形状
let manyLookaheads (bnf: BNF) (sq: seq<Set<string>>) =
    sq
    |> Seq.map(fun st ->
        st
        |> generateConfig(loop_getLookaheads (bnf: BNF) Set.empty)
    )
