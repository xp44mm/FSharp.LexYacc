module FSharp.Substance.FsYaccData
open System
open FSharp.Idioms
let declarations: (string*Type) list = [
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
    "AND", typeof<option<int>>
    "AND_BANG", typeof<option<int>>
    "DO", typeof<option<int>>
    "DO_BANG", typeof<option<int>>
    "ELIF", typeof<option<int>>
    "ELSE", typeof<option<int>>
    "EOF", typeof<option<int>>
    "FOR", typeof<option<int>>
    "FUN", typeof<option<int>>
    "FUNCTION", typeof<option<int>>
    "IDENT", typeof<option<int>*string>
    "IF", typeof<option<int>>
    "IN", typeof<option<int>>
    "LET", typeof<option<int>>
    "LET_BANG", typeof<option<int>>
    "LITERAL", typeof<option<int>*Literal>
    "LLPAREN", typeof<option<int>>
    "MATCH", typeof<option<int>>
    "MATCH_BANG", typeof<option<int>>
    "MODULE", typeof<option<int>>
    "OPEN", typeof<option<int>>
    "RETURN", typeof<option<int>>
    "RETURN_BANG", typeof<option<int>>
    "RHSEND", typeof<option<int>>
    "RRPAREN", typeof<option<int>>
    "THEN", typeof<option<int>>
    "TYPAR", typeof<option<int>*string>
    "USE", typeof<option<int>>
    "USE_BANG", typeof<option<int>>
    "WHEN", typeof<option<int>>
    "WHILE", typeof<option<int>>
    "WHILE_BANG", typeof<option<int>>
    "WITH", typeof<option<int>>
    "YIELD", typeof<option<int>>
    "YIELD_BANG", typeof<option<int>>
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
    "bindExpr", typeof<option<int>*Expr>
    "bindKeyword", typeof<option<int>*string>
    "bindingPattern", typeof<option<int>*Pattern>
    "declExpr", typeof<option<int>*Expr>
    "fieldBinding", typeof<option<int>*RecordFiledBinding>
    "fieldBindings", typeof<(option<int>*RecordFiledBinding) list>
    "file", typeof<string list*Expr list>
    "funType", typeof<(option<int>*TypeArgument) list>
    "identExpr", typeof<option<int>*Expr>
    "ifExpr", typeof<option<int>*Expr>
    "infix", typeof<option<int>*string>
    "lambdaExpr", typeof<option<int>*Expr>
    "listExpr", typeof<option<int>*Expr>
    "longid", typeof<option<int>*string list>
    "matchClause", typeof<option<int>*RuleClause>
    "matchExpr", typeof<option<int>*Expr>
    "matchKeyword", typeof<option<int>*string>
    "matchPattern", typeof<option<int>*Pattern>
    "openOrLet", typeof<option<int>*Expr>
    "opt_bar", typeof<option<int>>
    "parameterPattern", typeof<option<int>*Pattern>
    "parenExpr", typeof<option<int>*Expr>
    "patternAndGuard", typeof<option<int>*Pattern*Expr option>
    "prefix", typeof<option<int>*string>
    "produceKeyword", typeof<option<int>*string>
    "qualificationExpr", typeof<option<int>*Expr>
    "qualificationSuffix", typeof<option<int>*Expr>
    "recdLiteralExpr", typeof<option<int>*Expr>
    "revAppExpr", typeof<(option<int>*Expr) list>
    "revBinaryExpr", typeof<(option<int> * Either<string, Expr>) list>
    "revIfParts", typeof<(option<int>*IfBranch) list>
    "revLongid", typeof<(option<int>*string) list>
    "revMatchClauses", typeof<(option<int>*RuleClause) list>
    "revOpenOrLets", typeof<(option<int>*Expr) list>
    "revQualificationExpr", typeof<(option<int>*Expr) list>
    "revSequentialExpr", typeof<(option<int>*Expr) list>
    "revTupleExpr", typeof<(option<int>*Expr) list>
    "suffixType", typeof<option<int>*SuffixType>
    "tupleExpr", typeof<option<int>*Expr>
    "tuplePattern", typeof<(option<int>*Pattern)list>
    "tupleRhs", typeof<(option<int>*Expr) list>
    "tupleType", typeof<(option<int>*TypeArgument) list>
    "typeArgument", typeof<option<int>*TypeArgument>
    "typeArguments", typeof<(option<int>*TypeArgument) list>
    "unaryExpr", typeof<option<int>*Expr>
    "valueExpr", typeof<option<int>*Expr>
    "valueRhs", typeof<(option<int>*Expr) list>
    "whileKeyword", typeof<option<int>*string>
    "{", typeof<option<int>>
    "|", typeof<option<int>>
    "|)", typeof<option<int>>
    "|]", typeof<option<int>>
    "}", typeof<option<int>>
]
