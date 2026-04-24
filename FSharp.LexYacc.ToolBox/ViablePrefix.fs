namespace FSharp.LexYacc

// 每个 viable prefix 直接对应一个解析器栈的合法状态
type ViablePrefix =
    {
        prefix: string list
        head: string
    }

    /// 栈顶形状的各种可能性
    static member top(bnf: BNF) =
        let takeLeftOfBody topSymbol =
            [
                for prod in bnf.productions do
                    match prod with
                    | head :: body ->
                        match List.tryFindIndex ((=) topSymbol) body with
                        | Some idx ->
                            let leftPart = body |> List.take(idx + 1) |> List.rev
                            { prefix = leftPart; head = head }
                        | None -> ()
                    | [] -> ()
            ]

        bnf.symbols
        |> Seq.collect(takeLeftOfBody)
        |> Set.ofSeq

    ///返回(ViablePrefix,lookahead)集合
    static member lookahead(bnf: BNF) =
        //返回某个la的(ViablePrefix,lookahead)集合
        let rec deriveLeftOf (symbol: string) (visited: Set<string>) =
            seq {
                for prod in bnf.productions do
                    match prod with
                    | head :: body ->
                        match List.tryFindIndex ((=) symbol) body with
                        | Some 0 ->
                            if not(visited.Contains head) then
                                yield! deriveLeftOf head (Set.add head visited)
                        | Some idx ->
                            let leftPart = body |> List.take idx |> List.rev
                            let derivations = BnfUtils.derive bnf leftPart
                            for prefix in derivations do
                                yield { prefix = prefix; head = head }
                        | None -> ()
                    | [] -> ()
            }

        bnf.terminals
        |> Seq.collect(fun la ->
            deriveLeftOf la Set.empty
            |> Seq.map(fun vp -> vp, la) //记住顶层的la
        )
        |> Set.ofSeq
