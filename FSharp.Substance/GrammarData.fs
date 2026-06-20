module FSharp.Substance.GrammarData
let follow_semicolon: string Set =
  set ["(";"+";"-";"ALWAYS_PREFIX";"AND";"AND_BANG";"DO_BANG";"FOR";"FUN";"FUNCTION";"IDENT";"IF";"LET";"LET_BANG";"LITERAL";"MATCH";"MATCH_BANG";"OPEN";"RETURN";"RETURN_BANG";"USE";"USE_BANG";"WHILE";"WHILE_BANG";"YIELD";"YIELD_BANG";"[";"[|";"{"]
let precede_semicolon: string Set =
  set [")";">";"IDENT";"LITERAL";"RHSEND";"RRPAREN";"]";"|]";"}"]
let precede_declExpr: string Set = set ["(";";";"LLPAREN";"[";"[|"]
let first_declExpr: string Set = set ["(";"+";"-";"ALWAYS_PREFIX";"AND";"AND_BANG";"DO_BANG";"FOR";"FUN";"FUNCTION";"IDENT";"IF";"LET";"LET_BANG";"LITERAL";"MATCH";"MATCH_BANG";"RETURN";"RETURN_BANG";"USE";"USE_BANG";"WHILE";"WHILE_BANG";"YIELD";"YIELD_BANG";"[";"[|";"{"]
let first_valueExpr: string Set = set ["(";"+";"-";"ALWAYS_PREFIX";"FUN";"FUNCTION";"IDENT";"IF";"LITERAL";"MATCH";"MATCH_BANG";"[";"[|";"{"]
let first_appExpr: string Set = set ["(";"IDENT";"LITERAL";"[";"[|";"{"]
let last_appExpr: string Set = set [")";">";"IDENT";"LITERAL";"]";"|]";"}"]
