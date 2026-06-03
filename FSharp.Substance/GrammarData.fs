module FSharp.Substance.GrammarData
let follow_semicolon: string Set =
  set ["(";"+";"-";"ALWAYS_PREFIX";"FUN";"IDENT";"LET";"LITERAL";"MATCH";"OPEN";"[";"[|";"{"]
let precede_semicolon: string Set =
  set [")";">";"IDENT";"LITERAL";"RHSEND";"RRPAREN";"]";"|]";"}"]
let precede_declExpr: string Set = set ["(";";";"LLPAREN";"[";"[|"]
let first_declExpr: string Set = set ["(";"+";"-";"ALWAYS_PREFIX";"FUN";"IDENT";"LET";"LITERAL";"MATCH";"[";"[|";"{"]
let first_valueExpr: string Set = set ["(";"+";"-";"ALWAYS_PREFIX";"FUN";"IDENT";"LITERAL";"MATCH";"[";"[|";"{"]
let first_appExpr = set ["(";"IDENT";"LITERAL";"[";"[|";"{"]
let last_appExpr = set [")";">";"IDENT";"LITERAL";"]";"|]";"}"]
