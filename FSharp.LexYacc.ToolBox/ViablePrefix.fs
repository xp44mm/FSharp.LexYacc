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
        let deriveLeftOf (laTok: string) =
            bnf.productions
            |> Seq.choose(fun prod ->
                match prod with
                | [] -> None
                | head :: body ->
                    match List.tryFindIndex ((=) laTok) body with
                    | Some idx ->
                        let leftPart = body |> List.take idx |> List.rev
                        Some(head, leftPart)
                    | None -> None
            )
            |> Seq.collect(fun (head, leftPart) ->
                match leftPart with
                | [] -> Seq.singleton({ prefix = []; head = head }, laTok)
                | _ ->
                    BnfUtils.derive bnf leftPart
                    |> Seq.map(fun ps -> { prefix = ps; head = head }, laTok)
            )
            |> Set.ofSeq

        bnf.terminals
        |> Set.map(fun la -> deriveLeftOf la)
        |> Set.unionMany
