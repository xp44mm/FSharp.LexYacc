module FSharp.LexYacc.Symbol

open FSharp.Idioms.Literal

///获取重复的符号
let getDuplication (symbols: string list) =
    symbols
    |> List.groupBy id
    |> List.map snd
    |> List.filter(fun ls -> ls.Length > 1)
    |> List.map List.head

let getSymbols<'a> (lines: seq<'a * Set<string>>) = lines |> Seq.map snd |> Set.unionMany

let duplOperators (operatorsLines: list<Associativity * string list>) =
    match
        operatorsLines
        |> List.collect snd
        |> getDuplication
    with
    | [] -> ()
    | ls -> failwith $"操作符优先级有重复：{ls}"

let duplDeclar<'a> (declarationsLines: list<'a * string list>) =
    match
        declarationsLines
        |> List.collect snd
        |> getDuplication
    with
    | [] -> ()
    | ls -> failwith $"类型声明有重复：{ls}"

let getProperDummies (rules: Rule Set) =
    rules
    |> Set.filter(fun rule -> rule.dummy > "")

///检查多余的dummy
let redundantDummies (rules: Rule Set) =
    let dummies =
        rules
        |> Set.filter(fun rule -> rule.dummy > "")
        |> Set.map(fun rule -> rule.production)

    let bnf =
        rules
        |> Set.map(fun rule -> rule.production)
        |> BNF.just

    let conflictedProductions = bnf.getConflictedProductions()

    let diff = Set.difference dummies conflictedProductions

    if diff.IsEmpty then
        ()
    else
        failwith $"{stringify(List.ofSeq diff)}"

///这个函数通常用于：
///语法分析中的无用规则消除。
///依赖分析，找出从某个符号开始所有相关的产生式。
///语法简化，过滤掉不可达的规则。
let crawl (startSymbol: string) (rules: Set<Rule>) =
    let heads =
        rules
        |> Set.map(fun rule -> rule.production.Head)

    let rec loop (rules: Set<Rule>) (rulelist: list<Rule>) =
        let symbols =
            rulelist
            |> List.collect(fun rule -> rule.production.Tail)
            |> Set.ofList
            |> Set.filter(heads.Contains)

        let nextRules, remainRules =
            rules
            |> Set.partition(fun rule -> symbols.Contains rule.production.Head)
        if nextRules.IsEmpty then
            rulelist
        else
            let rulelist =
                [
                    yield! rulelist
                    yield! nextRules
                ]
            loop remainRules rulelist

    let nextRules, remainRules =
        rules
        |> Set.partition(fun rule -> rule.production.Head = startSymbol)
    nextRules
    |> List.ofSeq
    |> loop remainRules

/// 删除符号的产生式，不展开此符号
let removeHeads (heads: Set<string>) (rules: Set<Rule>) =
    rules
    |> Set.filter(fun rule ->
        rule.production.Head
        |> heads.Contains
        |> not
    )

/// 删除符号所在产生式
let removeSymbols (symbols: Set<string>) (rules: Set<Rule>) =
    rules
    |> Set.filter(fun rule ->
        rule.production
        |> List.exists(fun s -> symbols.Contains s)
        |> not
    )

/// 从产生式中删除此符号，但保留修改后的产生式
let deleteSymbols (symbols: Set<string>) (rules: Set<Rule>) =
    let mapper (rule: Rule) =
        let head, body =
            match rule.production with
            | head :: body -> head, body
            | _ -> failwith "unreachable"
        let body2 =
            body
            |> List.filter(symbols.Contains >> not)
        { rule with production = head :: body2 }

    rules |> Set.map(mapper)

/// 冲突产生式的dummy提示
let conflictDummies (rules: Set<Rule>) =
    let productions =
        rules
        |> Set.map(fun rule -> rule.production)

    let bnf = BNF.just productions

    let conflicts = bnf.getConflictedProductions()

    conflicts
    |> Set.map(fun production ->
        let rule =
            rules
            |> Seq.find(fun rule -> rule.production = production)
        let nm =
            match production with
            | Precedence.HeadAsDummy productions dummy -> dummy
            | Precedence.LastTerminalAsDummy bnf.terminals dummy -> dummy
            | _ -> ""

        production, nm, rule.dummy
    )
