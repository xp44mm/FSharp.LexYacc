module FSharp.Substance.FsYaccData

open System

let declarations: (string*Type) list = [
    "!", typeof<option<int>>
    "#", typeof<option<int>>
    "(", typeof<option<int>>
    "(|", typeof<option<int>>
    ")", typeof<option<int>>
    "*", typeof<option<int>>
    "+", typeof<option<int>>
    ",", typeof<option<int>>
    "-", typeof<option<int>>
    "->", typeof<option<int>>
    ".", typeof<option<int>>
    ":", typeof<option<int>>
    ";", typeof<option<int>>
    "<", typeof<option<int>>
    "<-", typeof<option<int>>
    "=", typeof<option<int>>
    ">", typeof<option<int>>
    "ALWAYS_INFIX", typeof<option<int>*string>
    "ALWAYS_PREFIX", typeof<option<int>*string>
    "DO", typeof<option<int>>
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
    "WHEN", typeof<option<int>>
    "WHITESPACE", typeof<option<int>>
    "WITH", typeof<option<int>>
    "[", typeof<option<int>>
    "[|", typeof<option<int>>
    "]", typeof<option<int>>
    "appExpr", typeof<option<int>*Expr>
    "appType", typeof<(option<int>*TypeArgument)*((option<int> * SuffixType) list)>
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
    "matchExpr", typeof<option<int>*Expr>
    "matchPattern", typeof<option<int>*Pattern>
    "openOrLet", typeof<option<int>*Expr>
    "opt_bar", typeof<option<int>>
    "opt_semicolon", typeof<option<int>>
    "parameterPattern", typeof<option<int>*Pattern>
    "parenExpr", typeof<option<int>*Expr>
    "patternAndGuard", typeof<option<int>*Pattern*Expr option>
    "prefix", typeof<option<int>*string>
    "qualificationExpr", typeof<option<int>*Expr>
    "qualificationSuffix", typeof<option<int>*Expr>
    "revAppExpr", typeof<(option<int>*Expr) list>
    "revBinaryExpr", typeof<((option<int>*string)*(option<int>*Expr)) list>
    "revLongid", typeof<(option<int>*string) list>
    "revOpenOrLets", typeof<(option<int>*Expr) list>
    "revQualificationExpr", typeof<(option<int>*Expr) list>
    "revRuleClauses", typeof<(option<int>*RuleClause) list>
    "revSequentialExpr", typeof<(option<int>*Expr) list>
    "revTupleExpr", typeof<(option<int>*Expr) list>
    "ruleClause", typeof<option<int>*RuleClause>
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
    "|]", typeof<option<int>>
    "|}", typeof<option<int>>
    "}", typeof<option<int>>
]
