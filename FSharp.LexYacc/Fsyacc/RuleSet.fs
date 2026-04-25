module FSharp.LexYacc.RuleSet

open System
open FSharp.Idioms
open FSharp.Idioms.Literal

let fromGroups (ruleGroups: RuleGroup list) =
    let ruleList =
        ruleGroups
        |> List.collect(fun grp ->
            grp.bodies
            |> List.map(fun bd ->
                {
                    production = grp.lhs :: bd.rhs
                    dummy = bd.dummy
                    reducer = bd.reducer
                }
                : Rule
            )
        )

    //产生式去重
    let repl =
        ruleList
        |> List.groupBy(fun rule -> rule.production)
        |> List.filter(fun (p, ls) -> ls.Length > 1)

    if repl.IsEmpty then
        let startSymbol = ruleGroups.[0].lhs
        let augmentRule = Rule.augment startSymbol
        Set.ofList(augmentRule :: ruleList)
    else
        let ps = repl |> List.map fst
        failwith $"输入有重复的产生式：{stringify ps}"

let toGroups (rules: seq<Rule>) =
    rules
    |> Seq.groupBy(fun rule -> rule.production.Head)
    |> Seq.map(fun (hd, ls) ->
        let bodies =
            ls
            |> Seq.map(fun rule -> {
                rhs = rule.production.Tail
                dummy = rule.dummy
                reducer = rule.reducer
            })
            |> Seq.toList

        { lhs = hd; bodies = bodies }
    )
    |> Seq.toList
