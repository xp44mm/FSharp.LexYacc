namespace FSharp.Substance

type Pattern =
    | IdentPattern of string
    | TypeAnnotationPattern of string * TypeArgument
    | ParenPattern of Pattern
    | TuplePattern of Pattern list

module Pattern =
    let ofTuplePattern (molecularPatterns: (option<int> * Pattern) list) =
        let i, ls =
            molecularPatterns
            |> List.rev
            |> List.unzip

        let pat =
            if ls.Length > 1 then
                TuplePattern(ls)
            else
                ls.[0]

        i.[0], pat
