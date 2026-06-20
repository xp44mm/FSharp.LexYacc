module FSharp.LexYacc.DeclarationStatementUtils

// TypeAnnotatedPattern
let duplicated_type_annotations (declarationStmts: DeclarationStatement list) =
    declarationStmts
    |> List.map(fun ds -> ds.ids)
    |> List.concat
    |> List.countBy id
    |> List.filter(fun (_, count) -> count > 1)
    |> List.map fst
