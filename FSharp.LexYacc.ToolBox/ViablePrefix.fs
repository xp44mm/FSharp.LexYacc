namespace FSharp.LexYacc

type ViablePrefix =
    {
        prefix: string list
        head: string
    }

    /// shift 一个tok以后，yacc parser 栈顶的viable prefix
    static member top(bnf: BNF) =
        bnf.terminals
        |> Set.map(fun topTok ->
            bnf.productions
            |> Seq.choose(fun prod ->
                match prod with
                | head :: body ->
                    body
                    |> List.tryFindIndex((=) topTok)
                    |> Option.map(fun idx ->
                        let leftPart = body |> List.take(idx + 1) |> List.rev
                        { prefix = leftPart; head = head }
                    )
                | [] -> None
            )
            |> Set.ofSeq
        )
        |> Set.unionMany

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
