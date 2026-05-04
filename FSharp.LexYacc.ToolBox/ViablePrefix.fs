namespace FSharp.LexYacc

// 每个 viable prefix 直接对应一个解析器栈的合法状态
type ViablePrefix =
    {
        /// 已经出现的产生式体前缀
        prefix: string list

        /// 产生式头
        head: string

    }

    /// 栈顶形状的各种可能性
    static member top(bnf: BNF) =
        let rec loop (visited: Set<string>) (topSymbol: string) =
            seq {
                for prod in bnf.productions do
                    match prod with
                    | head :: body ->
                        match List.tryFindIndex ((=) topSymbol) body with
                        | Some 0 ->
                            if not(visited.Contains head) then
                                let vst = (Set.add head visited)
                                yield! loop vst head
                        | Some idx ->
                            //不包括自己
                            let leftPart = body |> List.take(idx) |> List.rev
                            { prefix = leftPart; head = head }
                        | None -> ()
                    | [] -> ()
            }

        bnf.symbols
        |> Seq.collect(fun symbol ->
            symbol
            |> loop Set.empty
            |> Seq.map(fun vp -> { vp with prefix = symbol :: vp.prefix })
        )
        |> Set.ofSeq

    ///返回(ViablePrefix,lookahead)集合
    static member lookahead(bnf: BNF) =
        //返回某个la的(ViablePrefix,lookahead)集合
        let rec loop (visited: Set<string>) (symbol: string) =
            seq {
                for prod in bnf.productions do
                    match prod with
                    | head :: body ->
                        match List.tryFindIndex ((=) symbol) body with
                        | Some 0 ->
                            if not(visited.Contains head) then
                                let vst = (Set.add head visited)
                                yield! loop vst head
                        | Some idx ->
                            //不包括自己
                            let leftPart = body |> List.take idx |> List.rev
                            let derivations = BnfUtils.derive bnf leftPart
                            for prefix in derivations do
                                yield { prefix = prefix; head = head }
                        | None -> ()
                    | [] -> ()
            }

        bnf.terminals
        |> Seq.collect(fun la ->
            la
            |> loop Set.empty
            |> Seq.map(fun vp -> vp, la)
        )
        |> Set.ofSeq


