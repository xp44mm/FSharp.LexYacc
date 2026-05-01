namespace FSharp.LexYacc

// 每个 viable prefix 直接对应一个解析器栈的合法状态
type ViablePrefix =
    {
        /// 已经出现的产生式体前缀
        prefix: string list
        /// 产生式头
        head: string
        /// 是否已经完全匹配了一个产生式
        isHandle: bool
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
                            {
                                prefix = leftPart
                                head = head
                                isHandle = (idx + 1 = body.Length)
                            }
                        | None -> ()
                    | [] -> ()
            ]

        bnf.symbols
        |> Seq.collect(takeLeftOfBody)
        |> Set.ofSeq

    ///返回(ViablePrefix,lookahead)集合
    static member lookahead(bnf: BNF) =
        //返回某个la的(ViablePrefix,lookahead)集合
        let rec deriveLeftOf (symbol: string) (isHandle: bool) (visited: Set<string>) =
            seq {
                for prod in bnf.productions do
                    match prod with
                    | head :: body ->
                        match List.tryFindIndex ((=) symbol) body with
                        | Some 0 ->
                            if not(visited.Contains head) then
                                let hdl = (body.Length = 1)
                                let vst = (Set.add head visited)
                                yield! deriveLeftOf head hdl vst
                        | Some idx ->
                            let leftPart = body |> List.take idx |> List.rev
                            let derivations = BnfUtils.derive bnf leftPart
                            for prefix in derivations do
                                let hdl = isHandle && (idx + 1 = body.Length) //在每层都要是最后一个
                                yield
                                    {
                                        prefix = prefix
                                        head = head
                                        isHandle = hdl
                                    }
                        | None -> ()
                    | [] -> ()
            }

        bnf.terminals
        |> Seq.collect(fun la ->
            deriveLeftOf la true Set.empty
            |> Seq.map(fun vp -> vp, la)
        )
        |> Set.ofSeq
