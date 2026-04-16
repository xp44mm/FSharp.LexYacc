namespace FSharp.LexYacc

open System
open FSharp.Idioms
open FSharp.Idioms.Literal

type AssocAndPrec =
    | Left of line: int
    | Right of line: int
    | Non of line: int

    static member from(assoc: Associativity, line: int) =
        match assoc with
        | LeftAssoc -> Left line
        | RightAssoc -> Right line
        | NonAssoc -> Non line

    member x.toAssoc() =
        match x with
        | Left i -> i, LeftAssoc
        | Right i -> i, RightAssoc
        | Non i -> i, NonAssoc

//集合表示顺序无关
type FlatFsyaccFile =
    {
        header: string
        augmentRules: Rule Set // augment Rules
        precedences: Map<string, AssocAndPrec> // symbol -> prec level
        declarations: Map<string, string> // symbol -> typeName
    }

    /// 不要检查，和crawl版本比较异同
    static member from(raw: RawFsyaccFile) =
        let rules = RuleSet.fromGroups raw.ruleGroups

        let precedences =
            raw.precedenceStmts
            |> List.indexed
            |> List.collect(fun (i, line) ->
                let data = AssocAndPrec.from(line.assoc, i)
                line.ids |> List.map(fun id -> id, data)

            )
            |> Map.ofList

        let declarations =
            raw.declarationStmts
            |> List.collect(fun line ->
                line.ids
                |> List.map(fun name -> name, line.typeTitle)
            )
            |> Map.ofList

        {
            header = raw.header
            augmentRules = rules
            precedences = precedences
            declarations = declarations
        }
    member this.rulesMap =
        this.augmentRules
        |> Seq.map(fun rule -> rule.production, rule)
        |> Map.ofSeq

    /// production -> action
    member this.reducers =
        this.augmentRules
        |> List.ofSeq
        |> List.map(fun rule -> rule.production, rule.reducer)

    /// covert to bnf
    member this.getBNF() =
        this.augmentRules
        |> Set.map(fun rule -> rule.production)
        |> BNF.just

    member flatFsyacc.getYacc() =
        let productions =
            flatFsyacc.augmentRules
            |> Set.map(fun rule -> rule.production)

        let dummyTokens =
            flatFsyacc.augmentRules
            |> Seq.filter(fun rule -> rule.dummy > "")
            |> Seq.map(fun rule -> rule.production, rule.dummy)
            |> Map.ofSeq

        let precedences =
            flatFsyacc.precedences
            |> Map.map(fun _ x -> x.toAssoc())

        YaccRow.from(productions, dummyTokens, precedences)

    member this.toRaw(rules: Rule list) =
        {
            header = this.header

            ruleGroups = RuleSet.toGroups rules

            precedenceStmts =
                this.precedences
                |> Seq.map(fun (KeyValue(id, assoc)) -> assoc, id)
                |> Seq.groupBy fst
                |> Seq.map(fun (assoc, sq) ->
                    let ls =
                        sq
                        |> Seq.map snd
                        |> Set.ofSeq
                        |> Set.toList

                    let i, assoc = assoc.toAssoc()
                    i, assoc, ls
                )
                |> Seq.sort
                |> Seq.map(fun (i, assoc, ls) -> PrecedenceStatement.just(assoc, ls))
                |> Seq.toList

            declarationStmts =
                this.declarations
                |> Seq.map(fun (KeyValue(id, typeName)) -> typeName, id)
                |> Seq.groupBy fst
                |> Seq.map(fun (typeName, sq) ->
                    let ls =
                        sq
                        |> Seq.map snd
                        |> Set.ofSeq
                        |> Set.toList
                    typeName, ls
                )
                |> Seq.map(fun (typeName, ls) -> DeclarationStatement.just(typeName, ls))
                |> Seq.toList

        }
        : RawFsyaccFile
