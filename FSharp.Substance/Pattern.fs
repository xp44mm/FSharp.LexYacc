namespace FSharp.Substance

type Pattern =
    | LiteralPattern of Literal
    | NamedPattern of string list * TypeArgument list
    | AppPattern of Pattern list
    | AliasPattern of Pattern * string
    | DisjunctivePattern of Pattern list
    | ConjunctivePattern of Pattern list
    | ConsPattern of Pattern list
    | TypeAnnotatedPattern of Pattern * TypeArgument
    | TuplePattern of Pattern list
    | ParenPattern of Pattern
    | ListPattern of Pattern list
    | ArrayPattern of Pattern list
    | RecordPattern of (string * Pattern) list
    | DynamicTypeTestPattern of TypeArgument * string
    | BindingPattern of Pattern * TypeArgument option

module Pattern =
    let toDisjunctivePattern (revPatterns: (option<int> * Pattern) list) =
        Light.degenerate DisjunctivePattern revPatterns

    let toConjunctivePattern (revPatterns: (option<int> * Pattern) list) =
        Light.degenerate ConjunctivePattern revPatterns

    let toTuplePattern (revPatterns: (option<int> * Pattern) list) = 
        Light.degenerate TuplePattern revPatterns

    let toConsPattern (revPatterns: (option<int> * Pattern) list) = 
        Light.degenerate ConsPattern revPatterns

    let toListPattern (revElementPatterns: (option<int> * Pattern) list) =
        Light.degenerate ListPattern revElementPatterns

    let toAppPattern (patterns: (option<int> * Pattern) list) =
        Light.degenerate AppPattern patterns

