namespace FSharp.LexYacc

///检测bnf是否有不可达到的符号，是否有缺少，或多余的类型声明
type BnfAnalysisRecord =
    {
        OrphanBnf: Set<string>
        AbsenceDecl: Set<string>
        OrphanDecl: Set<string>
    }

    static member Create(flatFsyacc: FlatFsyaccFile) =
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let newRules = Symbol.crawl "" flatFsyacc.augmentRules

        let newBNF =
            newRules
            |> Set.ofList
            |> Set.map(fun rule -> rule.production)
            |> BNF.just

        let orphan_bnf = bnf.symbols - newBNF.symbols

        let decls =
            flatFsyacc.declarations
            |> Map.keys
            |> Set.ofSeq

        let absence_decl = newBNF.symbols.Remove "" - decls
        let orphan_decl = decls - newBNF.symbols

        {
            OrphanBnf = orphan_bnf
            AbsenceDecl = absence_decl
            OrphanDecl = orphan_decl
        }
