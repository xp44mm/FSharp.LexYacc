namespace FSharp.LexYacc

///检测bnf是否有不可达到的符号，是否有缺少，或多余的类型声明
type BnfAnalysisRecord =
    {
        OrphanBnf: Set<string>
        AbsenceDecl: Set<string>
        OrphanDecl: Set<string>
    }

    static member Create(flatFsyacc: FlatFsyaccFile) =
        let get_symbols (productions:Set<string list>) =
            productions
            |> Set.map Set.ofList
            |> Set.unionMany

        let productions =
            flatFsyacc.augmentRules
            |> Set.map(fun rule -> rule.production)
        let symbols = 
            get_symbols productions
            |> Set.remove ""

        let newRules = Symbol.crawl "" flatFsyacc.augmentRules

        let newProductions =
            newRules
            |> Set.ofList
            |> Set.map(fun rule -> rule.production)

        let newSymbols = 
            get_symbols newProductions
            |> Set.remove ""

        let orphan_bnf = symbols - newSymbols

        let decls =
            flatFsyacc.declarations
            |> Map.keys
            |> Set.ofSeq

        let absence_decl = newSymbols - decls
        let orphan_decl = decls - newSymbols

        {
            OrphanBnf = orphan_bnf
            AbsenceDecl = absence_decl
            OrphanDecl = orphan_decl
        }
