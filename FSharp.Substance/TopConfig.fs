module FSharp.Substance.TopConfig

let ALWAYS_INFIX: list<string list * string Set> = [
  ["("],set ["atomicExpr"]
  ["revBinaryExpr"],set ["revBinaryExpr"]
]

let ALWAYS_PREFIX: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
]

let appExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["prefix"],set ["unaryExpr"]
]

let appType: list<string list * string Set> = [
  ["("],set ["atomType"]
  ["*";"tupleType"],set ["tupleType"]
  [",";"typeArguments"],set ["typeArguments"]
  ["->";"funType"],set ["funType"]
  [":";"IDENT"],set ["atomicPattern"]
  ["<";"IDENT"],set ["identExpr"]
  ["<";"longid"],set ["atomType"]
]

let arrayExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["prefix"],set ["unaryExpr"]
  ["revAppExpr"],set ["revAppExpr"]
]

let atomicExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["prefix"],set ["unaryExpr"]
  ["revAppExpr"],set ["revAppExpr"]
]

let atomicPattern: list<string list * string Set> = [
  ["("],set ["parameterPattern"]
  [",";"tuplePattern"],set ["tuplePattern"]
  ["LET"],set ["letBinding"]
]

let atomType: list<string list * string Set> = [
  ["("],set ["atomType"]
  ["*";"tupleType"],set ["tupleType"]
  [",";"typeArguments"],set ["typeArguments"]
  ["->";"funType"],set ["funType"]
  [":";"IDENT"],set ["atomicPattern"]
  ["<";"IDENT"],set ["identExpr"]
  ["<";"longid"],set ["atomType"]
]

// "|"
let BAR: list<string list * string Set> = [
  ["WITH";"tupleExpr";"MATCH"],set ["matchExpr"]
  ["revRuleClauses"],set ["revRuleClauses"]
]

// "|]"
let BAR_RBRACK: list<string list * string Set> = [
  ["[|"],set ["arrayExpr"]
  ["revSequentialExpr";"[|"],set ["arrayExpr"]
]

let binaryExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
]

let bindingPattern: list<string list * string Set> = [
  ["("],set ["parameterPattern"]
  ["LET"],set ["letBinding"]
]

// ":"
let COLON: list<string list * string Set> = [
  ["IDENT"],set ["atomicPattern"]
]

// ","
let COMMA: list<string list * string Set> = [
  ["revTupleExpr"],set ["revTupleExpr"]
  ["tuplePattern"],set ["tuplePattern"]
  ["typeArguments"],set ["typeArguments"]
]

let declExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["["],set ["listExpr"]
  ["[|"],set ["arrayExpr"]
]

// "."
let DOT: list<string list * string Set> = [
  ["revLongid"],set ["revLongid"]
  ["revQualificationExpr"],set ["revQualificationExpr"]
]

let EOF: list<string list * string Set> = [
  ["longid";"MODULE"],set ["file"]
  ["revOpenOrLets";"longid";"MODULE"],set ["file"]
]

// "="
let EQUALS: list<string list * string Set> = [
  ["("],set ["atomicExpr"]
  ["IDENT"],set ["fieldBinding"]
  ["bindingPattern";"LET"],set ["letBinding"]
  ["revBinaryExpr"],set ["revBinaryExpr"]
]

let fieldBinding: list<string list * string Set> = [
  [";";"fieldBindings"],set ["fieldBindings"]
  ["{"],set ["recdLiteralExpr"]
]

let fieldBindings: list<string list * string Set> = [
  ["{"],set ["recdLiteralExpr"]
]

let FUN: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["["],set ["listExpr"]
  ["[|"],set ["arrayExpr"]
]

let funType: list<string list * string Set> = [
  ["("],set ["atomType"]
  [",";"typeArguments"],set ["typeArguments"]
  [":";"IDENT"],set ["atomicPattern"]
  ["<";"IDENT"],set ["identExpr"]
  ["<";"longid"],set ["atomType"]
]

// ">"
let GREATER: list<string list * string Set> = [
  ["typeArguments";"<";"IDENT"],set ["identExpr"]
  ["typeArguments";"<";"longid"],set ["atomType"]
]

let IDENT: list<string list * string Set> = [
  ["("],set ["atomType";"parameterPattern";"parenExpr"]
  ["*";"tupleType"],set ["tupleType"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  [",";"tuplePattern"],set ["tuplePattern"]
  [",";"typeArguments"],set ["typeArguments"]
  ["->";"funType"],set ["funType"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  ["."],set ["qualificationSuffix"]
  [".";"revLongid"],set ["revLongid"]
  [":";"IDENT"],set ["atomicPattern"]
  [";";"fieldBindings"],set ["fieldBindings"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["<";"IDENT"],set ["identExpr"]
  ["<";"longid"],set ["atomType"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["FUN"],set ["lambdaExpr"]
  ["LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["MODULE"],set ["file"]
  ["OPEN"],set ["openOrLet"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["appType"],set ["appType"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["opt_bar";"WITH";"tupleExpr";"MATCH"],set ["matchExpr"]
  ["prefix"],set ["unaryExpr"]
  ["revAppExpr"],set ["revAppExpr"]
  ["{"],set ["recdLiteralExpr"]
  ["|";"revRuleClauses"],set ["revRuleClauses"]
]

let identExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  ["."],set ["qualificationSuffix"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["prefix"],set ["unaryExpr"]
  ["revAppExpr"],set ["revAppExpr"]
]

let infix: list<string list * string Set> = [
  ["("],set ["atomicExpr"]
  ["revBinaryExpr"],set ["revBinaryExpr"]
]

let lambdaExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["["],set ["listExpr"]
  ["[|"],set ["arrayExpr"]
]

// "{"
let LBRACE: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["prefix"],set ["unaryExpr"]
  ["revAppExpr"],set ["revAppExpr"]
]

// "["
let LBRACK: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  ["."],set ["qualificationSuffix"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["appType"],set ["appType"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["prefix"],set ["unaryExpr"]
  ["revAppExpr"],set ["revAppExpr"]
]

// "[|"
let LBRACK_BAR: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["prefix"],set ["unaryExpr"]
  ["revAppExpr"],set ["revAppExpr"]
]

// "<"
let LESS: list<string list * string Set> = [
  ["IDENT"],set ["identExpr"]
  ["longid"],set ["atomType"]
]

let LET: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [";";"revOpenOrLets"],set ["revOpenOrLets"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["["],set ["listExpr"]
  ["[|"],set ["arrayExpr"]
  ["longid";"MODULE"],set ["file"]
]

let letBinding: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [";";"revOpenOrLets"],set ["revOpenOrLets"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["["],set ["listExpr"]
  ["[|"],set ["arrayExpr"]
  ["longid";"MODULE"],set ["file"]
]

let listExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["prefix"],set ["unaryExpr"]
  ["revAppExpr"],set ["revAppExpr"]
]

let LITERAL: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["opt_bar";"WITH";"tupleExpr";"MATCH"],set ["matchExpr"]
  ["prefix"],set ["unaryExpr"]
  ["revAppExpr"],set ["revAppExpr"]
  ["|";"revRuleClauses"],set ["revRuleClauses"]
]

let LLPAREN: list<string list * string Set> = [
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
]

let longid: list<string list * string Set> = [
  ["("],set ["atomType"]
  ["*";"tupleType"],set ["tupleType"]
  [",";"typeArguments"],set ["typeArguments"]
  ["->";"funType"],set ["funType"]
  [":";"IDENT"],set ["atomicPattern"]
  ["<";"IDENT"],set ["identExpr"]
  ["<";"longid"],set ["atomType"]
  ["MODULE"],set ["file"]
  ["OPEN"],set ["openOrLet"]
  ["appType"],set ["appType"]
]

// "("
let LPAREN: list<string list * string Set> = [
  ["("],set ["atomType";"parameterPattern";"parenExpr"]
  ["*";"tupleType"],set ["tupleType"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  [",";"tuplePattern"],set ["tuplePattern"]
  [",";"typeArguments"],set ["typeArguments"]
  ["->";"funType"],set ["funType"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [":";"IDENT"],set ["atomicPattern"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["<";"IDENT"],set ["identExpr"]
  ["<";"longid"],set ["atomType"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["FUN"],set ["lambdaExpr"]
  ["LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["prefix"],set ["unaryExpr"]
  ["revAppExpr"],set ["revAppExpr"]
]

let MATCH: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["["],set ["listExpr"]
  ["[|"],set ["arrayExpr"]
]

let matchExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["["],set ["listExpr"]
  ["[|"],set ["arrayExpr"]
]

let matchPattern: list<string list * string Set> = [
  ["opt_bar";"WITH";"tupleExpr";"MATCH"],set ["matchExpr"]
  ["|";"revRuleClauses"],set ["revRuleClauses"]
]

// "-"
let MINUS: list<string list * string Set> = [
  ["("],set ["atomicExpr";"parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["revBinaryExpr"],set ["revBinaryExpr"]
]

let OPEN: list<string list * string Set> = [
  [";";"revOpenOrLets"],set ["revOpenOrLets"]
  ["longid";"MODULE"],set ["file"]
]

let openOrLet: list<string list * string Set> = [
  [";";"revOpenOrLets"],set ["revOpenOrLets"]
  ["longid";"MODULE"],set ["file"]
]

let opt_bar: list<string list * string Set> = [
  ["WITH";"tupleExpr";"MATCH"],set ["matchExpr"]
]

let parameterPattern: list<string list * string Set> = [
  ["("],set ["parameterPattern"]
  [",";"tuplePattern"],set ["tuplePattern"]
  ["FUN"],set ["lambdaExpr"]
  ["LET"],set ["letBinding"]
]

let parenExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["prefix"],set ["unaryExpr"]
  ["revAppExpr"],set ["revAppExpr"]
]

let patternAndGuard: list<string list * string Set> = [
  ["opt_bar";"WITH";"tupleExpr";"MATCH"],set ["matchExpr"]
  ["|";"revRuleClauses"],set ["revRuleClauses"]
]

// "+"
let PLUS: list<string list * string Set> = [
  ["("],set ["atomicExpr";"parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["revBinaryExpr"],set ["revBinaryExpr"]
]

let prefix: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
]

let qualificationExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["prefix"],set ["unaryExpr"]
  ["revAppExpr"],set ["revAppExpr"]
]

let qualificationSuffix: list<string list * string Set> = [
  ["revQualificationExpr"],set ["revQualificationExpr"]
]

// "->"
let RARROW: list<string list * string Set> = [
  ["funType"],set ["funType"]
  ["parameterPattern";"FUN"],set ["lambdaExpr"]
  ["patternAndGuard"],set ["ruleClause"]
]

// "}"
let RBRACE: list<string list * string Set> = [
  ["fieldBindings";"{"],set ["recdLiteralExpr"]
]

// "]"
let RBRACK: list<string list * string Set> = [
  ["["],set ["listExpr";"suffixType"]
  ["revSequentialExpr";"["],set ["listExpr"]
  ["tupleExpr";"[";"."],set ["qualificationSuffix"]
]

let recdLiteralExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["prefix"],set ["unaryExpr"]
  ["revAppExpr"],set ["revAppExpr"]
]

let revAppExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["prefix"],set ["unaryExpr"]
]

let revBinaryExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
]

let revLongid: list<string list * string Set> = [
  ["("],set ["atomType"]
  ["*";"tupleType"],set ["tupleType"]
  [",";"typeArguments"],set ["typeArguments"]
  ["->";"funType"],set ["funType"]
  [":";"IDENT"],set ["atomicPattern"]
  ["<";"IDENT"],set ["identExpr"]
  ["<";"longid"],set ["atomType"]
  ["MODULE"],set ["file"]
  ["OPEN"],set ["openOrLet"]
  ["appType"],set ["appType"]
]

let revOpenOrLets: list<string list * string Set> = [
  ["longid";"MODULE"],set ["file"]
]

let revQualificationExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["prefix"],set ["unaryExpr"]
  ["revAppExpr"],set ["revAppExpr"]
]

let revRuleClauses: list<string list * string Set> = [
  ["opt_bar";"WITH";"tupleExpr";"MATCH"],set ["matchExpr"]
]

let revSequentialExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["["],set ["listExpr"]
  ["[|"],set ["arrayExpr"]
]

let revTupleExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
]

let RHSEND: list<string list * string Set> = [
  ["revRuleClauses";"opt_bar";"WITH";"tupleExpr";"MATCH"],set ["matchExpr"]
]

// ")"
let RPAREN: list<string list * string Set> = [
  ["bindingPattern";"("],set ["parameterPattern"]
  ["infix";"("],set ["atomicExpr"]
  ["revSequentialExpr";"("],set ["parenExpr"]
  ["typeArgument";"("],set ["atomType"]
]

let RRPAREN: list<string list * string Set> = [
  ["revSequentialExpr";"LLPAREN"],set ["tupleRhs";"valueRhs"]
]

let ruleClause: list<string list * string Set> = [
  ["opt_bar";"WITH";"tupleExpr";"MATCH"],set ["matchExpr"]
  ["|";"revRuleClauses"],set ["revRuleClauses"]
]

// ";"
let SEMICOLON: list<string list * string Set> = [
  ["fieldBindings"],set ["fieldBindings"]
  ["revOpenOrLets"],set ["revOpenOrLets"]
  ["revSequentialExpr"],set ["revSequentialExpr"]
]

// "*"
let STAR: list<string list * string Set> = [
  ["("],set ["atomicExpr"]
  ["revBinaryExpr"],set ["revBinaryExpr"]
  ["tupleType"],set ["tupleType"]
]

let suffixType: list<string list * string Set> = [
  ["appType"],set ["appType"]
]

let tupleExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
]

let tuplePattern: list<string list * string Set> = [
  ["("],set ["parameterPattern"]
  ["LET"],set ["letBinding"]
]

let tupleRhs: list<string list * string Set> = [
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
]

let tupleType: list<string list * string Set> = [
  ["("],set ["atomType"]
  [",";"typeArguments"],set ["typeArguments"]
  ["->";"funType"],set ["funType"]
  [":";"IDENT"],set ["atomicPattern"]
  ["<";"IDENT"],set ["identExpr"]
  ["<";"longid"],set ["atomType"]
]

let TYPAR: list<string list * string Set> = [
  ["("],set ["atomType"]
  ["*";"tupleType"],set ["tupleType"]
  [",";"typeArguments"],set ["typeArguments"]
  ["->";"funType"],set ["funType"]
  [":";"IDENT"],set ["atomicPattern"]
  ["<";"IDENT"],set ["identExpr"]
  ["<";"longid"],set ["atomType"]
]

let typeArgument: list<string list * string Set> = [
  ["("],set ["atomType"]
  [",";"typeArguments"],set ["typeArguments"]
  [":";"IDENT"],set ["atomicPattern"]
  ["<";"IDENT"],set ["identExpr"]
  ["<";"longid"],set ["atomType"]
]

let typeArguments: list<string list * string Set> = [
  ["<";"IDENT"],set ["identExpr"]
  ["<";"longid"],set ["atomType"]
]

let unaryExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH"],set ["matchExpr"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["["],set ["listExpr"]
  ["[";"."],set ["qualificationSuffix"]
  ["[|"],set ["arrayExpr"]
  ["infix";"revBinaryExpr"],set ["revBinaryExpr"]
]

let valueExpr: list<string list * string Set> = [
  ["("],set ["parenExpr"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["["],set ["listExpr"]
  ["[|"],set ["arrayExpr"]
]

let valueRhs: list<string list * string Set> = [
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
]

let WHEN: list<string list * string Set> = [
  ["matchPattern"],set ["patternAndGuard"]
]

let WITH: list<string list * string Set> = [
  ["tupleExpr";"MATCH"],set ["matchExpr"]
]


let catalog: Map<string, _ > = Map [
  "ALWAYS_INFIX", ALWAYS_INFIX
  "ALWAYS_PREFIX", ALWAYS_PREFIX
  "appExpr", appExpr
  "appType", appType
  "arrayExpr", arrayExpr
  "atomicExpr", atomicExpr
  "atomicPattern", atomicPattern
  "atomType", atomType
  "BAR", BAR// "|"
  "BAR_RBRACK", BAR_RBRACK// "|]"
  "binaryExpr", binaryExpr
  "bindingPattern", bindingPattern
  "COLON", COLON// ":"
  "COMMA", COMMA// ","
  "declExpr", declExpr
  "DOT", DOT// "."
  "EOF", EOF
  "EQUALS", EQUALS// "="
  "fieldBinding", fieldBinding
  "fieldBindings", fieldBindings
  "FUN", FUN
  "funType", funType
  "GREATER", GREATER// ">"
  "IDENT", IDENT
  "identExpr", identExpr
  "infix", infix
  "lambdaExpr", lambdaExpr
  "LBRACE", LBRACE// "{"
  "LBRACK", LBRACK// "["
  "LBRACK_BAR", LBRACK_BAR// "[|"
  "LESS", LESS// "<"
  "LET", LET
  "letBinding", letBinding
  "listExpr", listExpr
  "LITERAL", LITERAL
  "LLPAREN", LLPAREN
  "longid", longid
  "LPAREN", LPAREN// "("
  "MATCH", MATCH
  "matchExpr", matchExpr
  "matchPattern", matchPattern
  "MINUS", MINUS// "-"
  "OPEN", OPEN
  "openOrLet", openOrLet
  "opt_bar", opt_bar
  "parameterPattern", parameterPattern
  "parenExpr", parenExpr
  "patternAndGuard", patternAndGuard
  "PLUS", PLUS// "+"
  "prefix", prefix
  "qualificationExpr", qualificationExpr
  "qualificationSuffix", qualificationSuffix
  "RARROW", RARROW// "->"
  "RBRACE", RBRACE// "}"
  "RBRACK", RBRACK// "]"
  "recdLiteralExpr", recdLiteralExpr
  "revAppExpr", revAppExpr
  "revBinaryExpr", revBinaryExpr
  "revLongid", revLongid
  "revOpenOrLets", revOpenOrLets
  "revQualificationExpr", revQualificationExpr
  "revRuleClauses", revRuleClauses
  "revSequentialExpr", revSequentialExpr
  "revTupleExpr", revTupleExpr
  "RHSEND", RHSEND
  "RPAREN", RPAREN// ")"
  "RRPAREN", RRPAREN
  "ruleClause", ruleClause
  "SEMICOLON", SEMICOLON// ";"
  "STAR", STAR// "*"
  "suffixType", suffixType
  "tupleExpr", tupleExpr
  "tuplePattern", tuplePattern
  "tupleRhs", tupleRhs
  "tupleType", tupleType
  "TYPAR", TYPAR
  "typeArgument", typeArgument
  "typeArguments", typeArguments
  "unaryExpr", unaryExpr
  "valueExpr", valueExpr
  "valueRhs", valueRhs
  "WHEN", WHEN
  "WITH", WITH
]
let TERMINALS: list<string list * string Set> = [
  ["(";"("],set ["atomType";"parameterPattern";"parenExpr"]
  ["(";"*";"tupleType"],set ["tupleType"]
  ["(";",";"revTupleExpr"],set ["revTupleExpr"]
  ["(";",";"tuplePattern"],set ["tuplePattern"]
  ["(";",";"typeArguments"],set ["typeArguments"]
  ["(";"->";"funType"],set ["funType"]
  ["(";"->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["(";"->";"patternAndGuard"],set ["ruleClause"]
  ["(";":";"IDENT"],set ["atomicPattern"]
  ["(";";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["(";"<";"IDENT"],set ["identExpr"]
  ["(";"<";"longid"],set ["atomType"]
  ["(";"=";"IDENT"],set ["fieldBinding"]
  ["(";"=";"bindingPattern";"LET"],set ["letBinding"]
  ["(";"FUN"],set ["lambdaExpr"]
  ["(";"LET"],set ["letBinding"]
  ["(";"LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["(";"MATCH"],set ["matchExpr"]
  ["(";"WHEN";"matchPattern"],set ["patternAndGuard"]
  ["(";"["],set ["listExpr"]
  ["(";"[";"."],set ["qualificationSuffix"]
  ["(";"[|"],set ["arrayExpr"]
  ["(";"infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["(";"prefix"],set ["unaryExpr"]
  ["(";"revAppExpr"],set ["revAppExpr"]
  [")";"bindingPattern";"("],set ["parameterPattern"]
  [")";"infix";"("],set ["atomicExpr"]
  [")";"revSequentialExpr";"("],set ["parenExpr"]
  [")";"typeArgument";"("],set ["atomType"]
  ["*";"("],set ["atomicExpr"]
  ["*";"revBinaryExpr"],set ["revBinaryExpr"]
  ["*";"tupleType"],set ["tupleType"]
  ["+";"("],set ["atomicExpr";"parenExpr"]
  ["+";",";"revTupleExpr"],set ["revTupleExpr"]
  ["+";"->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["+";"->";"patternAndGuard"],set ["ruleClause"]
  ["+";";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["+";"=";"IDENT"],set ["fieldBinding"]
  ["+";"=";"bindingPattern";"LET"],set ["letBinding"]
  ["+";"LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["+";"MATCH"],set ["matchExpr"]
  ["+";"WHEN";"matchPattern"],set ["patternAndGuard"]
  ["+";"["],set ["listExpr"]
  ["+";"[";"."],set ["qualificationSuffix"]
  ["+";"[|"],set ["arrayExpr"]
  ["+";"infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["+";"revBinaryExpr"],set ["revBinaryExpr"]
  [",";"revTupleExpr"],set ["revTupleExpr"]
  [",";"tuplePattern"],set ["tuplePattern"]
  [",";"typeArguments"],set ["typeArguments"]
  ["-";"("],set ["atomicExpr";"parenExpr"]
  ["-";",";"revTupleExpr"],set ["revTupleExpr"]
  ["-";"->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["-";"->";"patternAndGuard"],set ["ruleClause"]
  ["-";";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["-";"=";"IDENT"],set ["fieldBinding"]
  ["-";"=";"bindingPattern";"LET"],set ["letBinding"]
  ["-";"LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["-";"MATCH"],set ["matchExpr"]
  ["-";"WHEN";"matchPattern"],set ["patternAndGuard"]
  ["-";"["],set ["listExpr"]
  ["-";"[";"."],set ["qualificationSuffix"]
  ["-";"[|"],set ["arrayExpr"]
  ["-";"infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["-";"revBinaryExpr"],set ["revBinaryExpr"]
  ["->";"funType"],set ["funType"]
  ["->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["->";"patternAndGuard"],set ["ruleClause"]
  [".";"revLongid"],set ["revLongid"]
  [".";"revQualificationExpr"],set ["revQualificationExpr"]
  [":";"IDENT"],set ["atomicPattern"]
  [";";"fieldBindings"],set ["fieldBindings"]
  [";";"revOpenOrLets"],set ["revOpenOrLets"]
  [";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["<";"IDENT"],set ["identExpr"]
  ["<";"longid"],set ["atomType"]
  ["=";"("],set ["atomicExpr"]
  ["=";"IDENT"],set ["fieldBinding"]
  ["=";"bindingPattern";"LET"],set ["letBinding"]
  ["=";"revBinaryExpr"],set ["revBinaryExpr"]
  [">";"typeArguments";"<";"IDENT"],set ["identExpr"]
  [">";"typeArguments";"<";"longid"],set ["atomType"]
  ["ALWAYS_INFIX";"("],set ["atomicExpr"]
  ["ALWAYS_INFIX";"revBinaryExpr"],set ["revBinaryExpr"]
  ["ALWAYS_PREFIX";"("],set ["parenExpr"]
  ["ALWAYS_PREFIX";",";"revTupleExpr"],set ["revTupleExpr"]
  ["ALWAYS_PREFIX";"->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["ALWAYS_PREFIX";"->";"patternAndGuard"],set ["ruleClause"]
  ["ALWAYS_PREFIX";";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["ALWAYS_PREFIX";"=";"IDENT"],set ["fieldBinding"]
  ["ALWAYS_PREFIX";"=";"bindingPattern";"LET"],set ["letBinding"]
  ["ALWAYS_PREFIX";"LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["ALWAYS_PREFIX";"MATCH"],set ["matchExpr"]
  ["ALWAYS_PREFIX";"WHEN";"matchPattern"],set ["patternAndGuard"]
  ["ALWAYS_PREFIX";"["],set ["listExpr"]
  ["ALWAYS_PREFIX";"[";"."],set ["qualificationSuffix"]
  ["ALWAYS_PREFIX";"[|"],set ["arrayExpr"]
  ["ALWAYS_PREFIX";"infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["EOF";"longid";"MODULE"],set ["file"]
  ["EOF";"revOpenOrLets";"longid";"MODULE"],set ["file"]
  ["FUN";"("],set ["parenExpr"]
  ["FUN";";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["FUN";"=";"IDENT"],set ["fieldBinding"]
  ["FUN";"=";"bindingPattern";"LET"],set ["letBinding"]
  ["FUN";"LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["FUN";"["],set ["listExpr"]
  ["FUN";"[|"],set ["arrayExpr"]
  ["IDENT";"("],set ["atomType";"parameterPattern";"parenExpr"]
  ["IDENT";"*";"tupleType"],set ["tupleType"]
  ["IDENT";",";"revTupleExpr"],set ["revTupleExpr"]
  ["IDENT";",";"tuplePattern"],set ["tuplePattern"]
  ["IDENT";",";"typeArguments"],set ["typeArguments"]
  ["IDENT";"->";"funType"],set ["funType"]
  ["IDENT";"->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["IDENT";"->";"patternAndGuard"],set ["ruleClause"]
  ["IDENT";"."],set ["qualificationSuffix"]
  ["IDENT";".";"revLongid"],set ["revLongid"]
  ["IDENT";":";"IDENT"],set ["atomicPattern"]
  ["IDENT";";";"fieldBindings"],set ["fieldBindings"]
  ["IDENT";";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["IDENT";"<";"IDENT"],set ["identExpr"]
  ["IDENT";"<";"longid"],set ["atomType"]
  ["IDENT";"=";"IDENT"],set ["fieldBinding"]
  ["IDENT";"=";"bindingPattern";"LET"],set ["letBinding"]
  ["IDENT";"FUN"],set ["lambdaExpr"]
  ["IDENT";"LET"],set ["letBinding"]
  ["IDENT";"LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["IDENT";"MATCH"],set ["matchExpr"]
  ["IDENT";"MODULE"],set ["file"]
  ["IDENT";"OPEN"],set ["openOrLet"]
  ["IDENT";"WHEN";"matchPattern"],set ["patternAndGuard"]
  ["IDENT";"["],set ["listExpr"]
  ["IDENT";"[";"."],set ["qualificationSuffix"]
  ["IDENT";"[|"],set ["arrayExpr"]
  ["IDENT";"appType"],set ["appType"]
  ["IDENT";"infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["IDENT";"opt_bar";"WITH";"tupleExpr";"MATCH"],set ["matchExpr"]
  ["IDENT";"prefix"],set ["unaryExpr"]
  ["IDENT";"revAppExpr"],set ["revAppExpr"]
  ["IDENT";"{"],set ["recdLiteralExpr"]
  ["IDENT";"|";"revRuleClauses"],set ["revRuleClauses"]
  ["LET";"("],set ["parenExpr"]
  ["LET";";";"revOpenOrLets"],set ["revOpenOrLets"]
  ["LET";";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["LET";"LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["LET";"["],set ["listExpr"]
  ["LET";"[|"],set ["arrayExpr"]
  ["LET";"longid";"MODULE"],set ["file"]
  ["LITERAL";"("],set ["parenExpr"]
  ["LITERAL";",";"revTupleExpr"],set ["revTupleExpr"]
  ["LITERAL";"->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["LITERAL";"->";"patternAndGuard"],set ["ruleClause"]
  ["LITERAL";";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["LITERAL";"=";"IDENT"],set ["fieldBinding"]
  ["LITERAL";"=";"bindingPattern";"LET"],set ["letBinding"]
  ["LITERAL";"LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["LITERAL";"MATCH"],set ["matchExpr"]
  ["LITERAL";"WHEN";"matchPattern"],set ["patternAndGuard"]
  ["LITERAL";"["],set ["listExpr"]
  ["LITERAL";"[";"."],set ["qualificationSuffix"]
  ["LITERAL";"[|"],set ["arrayExpr"]
  ["LITERAL";"infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["LITERAL";"opt_bar";"WITH";"tupleExpr";"MATCH"],set ["matchExpr"]
  ["LITERAL";"prefix"],set ["unaryExpr"]
  ["LITERAL";"revAppExpr"],set ["revAppExpr"]
  ["LITERAL";"|";"revRuleClauses"],set ["revRuleClauses"]
  ["LLPAREN";"->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["LLPAREN";"->";"patternAndGuard"],set ["ruleClause"]
  ["LLPAREN";"=";"IDENT"],set ["fieldBinding"]
  ["LLPAREN";"=";"bindingPattern";"LET"],set ["letBinding"]
  ["MATCH";"("],set ["parenExpr"]
  ["MATCH";";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["MATCH";"=";"IDENT"],set ["fieldBinding"]
  ["MATCH";"=";"bindingPattern";"LET"],set ["letBinding"]
  ["MATCH";"LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["MATCH";"["],set ["listExpr"]
  ["MATCH";"[|"],set ["arrayExpr"]
  ["OPEN";";";"revOpenOrLets"],set ["revOpenOrLets"]
  ["OPEN";"longid";"MODULE"],set ["file"]
  ["RHSEND";"revRuleClauses";"opt_bar";"WITH";"tupleExpr";"MATCH"],set ["matchExpr"]
  ["RRPAREN";"revSequentialExpr";"LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["TYPAR";"("],set ["atomType"]
  ["TYPAR";"*";"tupleType"],set ["tupleType"]
  ["TYPAR";",";"typeArguments"],set ["typeArguments"]
  ["TYPAR";"->";"funType"],set ["funType"]
  ["TYPAR";":";"IDENT"],set ["atomicPattern"]
  ["TYPAR";"<";"IDENT"],set ["identExpr"]
  ["TYPAR";"<";"longid"],set ["atomType"]
  ["WHEN";"matchPattern"],set ["patternAndGuard"]
  ["WITH";"tupleExpr";"MATCH"],set ["matchExpr"]
  ["[";"("],set ["parenExpr"]
  ["[";",";"revTupleExpr"],set ["revTupleExpr"]
  ["[";"->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["[";"->";"patternAndGuard"],set ["ruleClause"]
  ["[";"."],set ["qualificationSuffix"]
  ["[";";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["[";"=";"IDENT"],set ["fieldBinding"]
  ["[";"=";"bindingPattern";"LET"],set ["letBinding"]
  ["[";"LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["[";"MATCH"],set ["matchExpr"]
  ["[";"WHEN";"matchPattern"],set ["patternAndGuard"]
  ["[";"["],set ["listExpr"]
  ["[";"[";"."],set ["qualificationSuffix"]
  ["[";"[|"],set ["arrayExpr"]
  ["[";"appType"],set ["appType"]
  ["[";"infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["[";"prefix"],set ["unaryExpr"]
  ["[";"revAppExpr"],set ["revAppExpr"]
  ["[|";"("],set ["parenExpr"]
  ["[|";",";"revTupleExpr"],set ["revTupleExpr"]
  ["[|";"->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["[|";"->";"patternAndGuard"],set ["ruleClause"]
  ["[|";";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["[|";"=";"IDENT"],set ["fieldBinding"]
  ["[|";"=";"bindingPattern";"LET"],set ["letBinding"]
  ["[|";"LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["[|";"MATCH"],set ["matchExpr"]
  ["[|";"WHEN";"matchPattern"],set ["patternAndGuard"]
  ["[|";"["],set ["listExpr"]
  ["[|";"[";"."],set ["qualificationSuffix"]
  ["[|";"[|"],set ["arrayExpr"]
  ["[|";"infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["[|";"prefix"],set ["unaryExpr"]
  ["[|";"revAppExpr"],set ["revAppExpr"]
  ["]";"["],set ["listExpr";"suffixType"]
  ["]";"revSequentialExpr";"["],set ["listExpr"]
  ["]";"tupleExpr";"[";"."],set ["qualificationSuffix"]
  ["{";"("],set ["parenExpr"]
  ["{";",";"revTupleExpr"],set ["revTupleExpr"]
  ["{";"->";"parameterPattern";"FUN"],set ["lambdaExpr"]
  ["{";"->";"patternAndGuard"],set ["ruleClause"]
  ["{";";";"revSequentialExpr"],set ["revSequentialExpr"]
  ["{";"=";"IDENT"],set ["fieldBinding"]
  ["{";"=";"bindingPattern";"LET"],set ["letBinding"]
  ["{";"LLPAREN"],set ["tupleRhs";"valueRhs"]
  ["{";"MATCH"],set ["matchExpr"]
  ["{";"WHEN";"matchPattern"],set ["patternAndGuard"]
  ["{";"["],set ["listExpr"]
  ["{";"[";"."],set ["qualificationSuffix"]
  ["{";"[|"],set ["arrayExpr"]
  ["{";"infix";"revBinaryExpr"],set ["revBinaryExpr"]
  ["{";"prefix"],set ["unaryExpr"]
  ["{";"revAppExpr"],set ["revAppExpr"]
  ["|";"WITH";"tupleExpr";"MATCH"],set ["matchExpr"]
  ["|";"revRuleClauses"],set ["revRuleClauses"]
  ["|]";"[|"],set ["arrayExpr"]
  ["|]";"revSequentialExpr";"[|"],set ["arrayExpr"]
  ["}";"fieldBindings";"{"],set ["recdLiteralExpr"]
]

