module FSharp.Substance.ViablePrefix

let topOf tp =
    RightSententialForm.tops
    |> List.filter(fun v ->
        not v.prefix.IsEmpty
        && v.prefix.[0] = tp
    )
    |> List.map(fun v -> v.prefix)
    |> Set.ofList //确保最短在先

let top_llparen = topOf "LLPAREN"

let top_rrparen = topOf "RRPAREN"

let top_rhsend = topOf "RHSEND"

let top_semicolon = topOf ";"

let lookaheadOf la =
    RightSententialForm.lookaheads
    |> List.filter(fun (v, look_ahead) -> look_ahead = la)
    |> List.map(fun (v, la) -> v.prefix)
    |> Set.ofList //确保最短在先

let la_llparen = lookaheadOf "LLPAREN"

let la_rrparen = lookaheadOf "RRPAREN"

let la_rhsend = lookaheadOf "RHSEND"

let la_semicolon = lookaheadOf ";"

let declarations = [
    "!", typeof<option<int>>
    "#", typeof<option<int>>
    "%", typeof<option<int>>
    "&", typeof<option<int>>
    "&&", typeof<option<int>>
    "(", typeof<option<int>>
    "(|", typeof<option<int>>
    ")", typeof<option<int>>
    "*", typeof<option<int>>
    "**", typeof<option<int>>
    "+", typeof<option<int>>
    ",", typeof<option<int>>
    "-", typeof<option<int>>
    "->", typeof<option<int>>
    ".", typeof<option<int>>
    "..", typeof<option<int>>
    "/", typeof<option<int>>
    ":", typeof<option<int>>
    "::", typeof<option<int>>
    ":?", typeof<option<int>>
    ":?>", typeof<option<int>>
    ";", typeof<option<int>>
    "<", typeof<option<int>>
    "<-", typeof<option<int>>
    "<<", typeof<option<int>>
    "<>", typeof<option<int>>
    "<|", typeof<option<int>>
    "<||", typeof<option<int>>
    "<|||", typeof<option<int>>
    "=", typeof<option<int>>
    ">", typeof<option<int>>
    ">>", typeof<option<int>>
    "@", typeof<option<int>>
    "DO", typeof<option<int>>
    "DUMMY", typeof<option<int>>
    "EOF", typeof<option<int>>
    "FUN", typeof<option<int>>
    "IDENT", typeof<option<int>*string>
    "LET", typeof<option<int>>
    "LITERAL", typeof<option<int>*Literal>
    "LLPAREN", typeof<option<int>>
    "MATCH", typeof<option<int>>
    "MODULE", typeof<option<int>>
    "OPEN", typeof<option<int>>
    "RHSEND", typeof<option<int>>
    "RRPAREN", typeof<option<int>>
    "TYPAR", typeof<option<int>*string>
    "WHITESPACE", typeof<option<int>>
    "WITH", typeof<option<int>>
    "[", typeof<option<int>>
    "[|", typeof<option<int>>
    "]", typeof<option<int>>
    "appExpr", typeof<option<int>*Expr>
    "appType", typeof<(option<int> * TypeArgument)*((option<int> * SuffixType) list)>
    "arrayExpr", typeof<option<int>*Expr>
    "atomType", typeof<option<int>*TypeArgument>
    "atomicExpr", typeof<option<int>*Expr>
    "atomicPattern", typeof<option<int>*Pattern>
    "binaryExpr", typeof<option<int>*Expr>
    "bindingPattern", typeof<option<int>*Pattern>
    "declExpr", typeof<option<int>*Expr>
    "file", typeof<string list*Expr list>
    "funType", typeof<(option<int>*TypeArgument) list>
    "identExpr", typeof<option<int>*Expr>
    "infix", typeof<option<int>*string>
    "lambdaExpr", typeof<option<int>*Expr>
    "letBinding", typeof<option<int>*Expr>
    "listExpr", typeof<option<int>*Expr>
    "longid", typeof<option<int>*string list>
    "parameterPattern", typeof<option<int>*Pattern>
    "parenExpr", typeof<option<int>*Expr>
    "prifix", typeof<option<int>*string>
    "qualificationExpr", typeof<option<int>*Expr>
    "qualificationSuffix", typeof<option<int>*Expr>
    "revAppExpr", typeof<(option<int>*Expr) list>
    "revBinaryExpr", typeof<((option<int>*string)*(option<int>*Expr)) list>
    "revLongid", typeof<(option<int>*string) list>
    "revQualificationExpr", typeof<(option<int>*Expr) list>
    "revSequentialExpr", typeof<(option<int>*Expr) list>
    "revTupleExpr", typeof<(option<int>*Expr) list>
    "rhsBlock", typeof<option<int>*Expr list>
    "sequentialExpr", typeof<option<int>*Expr list>
    "suffixType", typeof<option<int>*SuffixType>
    "tupleExpr", typeof<option<int>*Expr>
    "tuplePattern", typeof<(option<int>*Pattern)list>
    "tupleType", typeof<(option<int>*TypeArgument) list>
    "typeArgument", typeof<option<int>*TypeArgument>
    "typeArguments", typeof<(option<int>*TypeArgument) list>
    "unaryExpr", typeof<option<int>*Expr>
    "valueExpr", typeof<option<int>*Expr>
    "{", typeof<option<int>>
    "{|", typeof<option<int>>
    "|", typeof<option<int>>
    "|)", typeof<option<int>>
    "|>", typeof<option<int>>
    "|]", typeof<option<int>>
    "||", typeof<option<int>>
    "||>", typeof<option<int>>
    "|||", typeof<option<int>>
    "|||>", typeof<option<int>>
    "|}", typeof<option<int>>
    "}", typeof<option<int>>
]
