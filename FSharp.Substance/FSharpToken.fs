namespace FSharp.Substance

type FSharpToken =
    | ALWAYS_INFIX of string
    | ALWAYS_PREFIX of string
    | AND
    | AND_BANG
    | AS
    | BAR
    | BAR_RBRACE
    | BAR_RBRACK
    | BAR_RPAREN
    | COLON
    | COMMA
    | DO
    | DOT
    | DO_BANG
    | ELIF
    | ELSE
    | EOF
    | EQUALS
    | EXCLAM
    | FINALLY
    | FOR
    | FUN
    | FUNCTION
    | GREATER
    | GREATER_GREATER
    | IDENT of string
    | IF
    | IN
    | LARROW
    | LBRACE
    | LBRACE_BAR
    | LBRACK
    | LBRACK_BAR
    | LESS
    | LESS_LESS
    | LET
    | LET_BANG
    | LITERAL of Literal
    | LLPAREN
    | LPAREN
    | LPAREN_BAR
    | MATCH
    | MATCH_BANG
    | MINUS
    | MODULE
    | MUTABLE
    | NEW_LINE of space: int
    | OPEN
    | PLUS
    | RARROW
    | RBRACE
    | RBRACK
    | REC
    | RETURN
    | RETURN_BANG
    | RHSEND
    | RPAREN
    | RRPAREN
    | SEMICOLON
    | STAR
    | THEN
    | TRY
    | TYPAR of string
    | TYPE
    | USE
    | USE_BANG
    | WHEN
    | WHILE
    | WHILE_BANG
    | WHITESPACE
    | WITH
    | YIELD
    | YIELD_BANG

module FSharpToken =
    /// 只需列出与 union case name 不同的符号名称
    let symbols = [
        FSharpToken.BAR, "|"
        FSharpToken.BAR_RBRACE, "|}"
        FSharpToken.BAR_RBRACK, "|]"
        FSharpToken.BAR_RPAREN, "|)"
        FSharpToken.COLON, ":"
        FSharpToken.COMMA, ","
        FSharpToken.DOT, "."
        FSharpToken.EQUALS, "="
        FSharpToken.EXCLAM, "!"
        FSharpToken.GREATER, ">"
        FSharpToken.GREATER_GREATER, ">>"
        FSharpToken.LARROW, "<-"
        FSharpToken.LBRACE, "{"
        FSharpToken.LBRACE_BAR, "{|"
        FSharpToken.LBRACK, "["
        FSharpToken.LBRACK_BAR, "[|"
        FSharpToken.LESS, "<"
        FSharpToken.LESS_LESS, "<<"
        FSharpToken.LPAREN, "("
        FSharpToken.LPAREN_BAR, "(|"
        FSharpToken.MINUS, "-"
        FSharpToken.PLUS, "+"
        FSharpToken.RARROW, "->"
        FSharpToken.RBRACE, "}"
        FSharpToken.RBRACK, "]"
        FSharpToken.RPAREN, ")"
        FSharpToken.SEMICOLON, ";"
        FSharpToken.STAR, "*"
    ]
    let index (tok:FSharpToken) =
        match tok with
        | FSharpToken.ALWAYS_INFIX _ -> 0
        | FSharpToken.ALWAYS_PREFIX _ -> 1
        | FSharpToken.AND -> 2
        | FSharpToken.AND_BANG -> 3
        | FSharpToken.AS -> 4
        | FSharpToken.BAR -> 5
        | FSharpToken.BAR_RBRACE -> 6
        | FSharpToken.BAR_RBRACK -> 7
        | FSharpToken.BAR_RPAREN -> 8
        | FSharpToken.COLON -> 9
        | FSharpToken.COMMA -> 10
        | FSharpToken.DO -> 11
        | FSharpToken.DOT -> 12
        | FSharpToken.DO_BANG -> 13
        | FSharpToken.ELIF -> 14
        | FSharpToken.ELSE -> 15
        | FSharpToken.EOF -> 16
        | FSharpToken.EQUALS -> 17
        | FSharpToken.EXCLAM -> 18
        | FSharpToken.FINALLY -> 19
        | FSharpToken.FOR -> 20
        | FSharpToken.FUN -> 21
        | FSharpToken.FUNCTION -> 22
        | FSharpToken.GREATER -> 23
        | FSharpToken.GREATER_GREATER -> 24
        | FSharpToken.IDENT _ -> 25
        | FSharpToken.IF -> 26
        | FSharpToken.IN -> 27
        | FSharpToken.LARROW -> 28
        | FSharpToken.LBRACE -> 29
        | FSharpToken.LBRACE_BAR -> 30
        | FSharpToken.LBRACK -> 31
        | FSharpToken.LBRACK_BAR -> 32
        | FSharpToken.LESS -> 33
        | FSharpToken.LESS_LESS -> 34
        | FSharpToken.LET -> 35
        | FSharpToken.LET_BANG -> 36
        | FSharpToken.LITERAL _ -> 37
        | FSharpToken.LLPAREN -> 38
        | FSharpToken.LPAREN -> 39
        | FSharpToken.LPAREN_BAR -> 40
        | FSharpToken.MATCH -> 41
        | FSharpToken.MATCH_BANG -> 42
        | FSharpToken.MINUS -> 43
        | FSharpToken.MODULE -> 44
        | FSharpToken.MUTABLE -> 45
        | FSharpToken.NEW_LINE _ -> 46
        | FSharpToken.OPEN -> 47
        | FSharpToken.PLUS -> 48
        | FSharpToken.RARROW -> 49
        | FSharpToken.RBRACE -> 50
        | FSharpToken.RBRACK -> 51
        | FSharpToken.REC -> 52
        | FSharpToken.RETURN -> 53
        | FSharpToken.RETURN_BANG -> 54
        | FSharpToken.RHSEND -> 55
        | FSharpToken.RPAREN -> 56
        | FSharpToken.RRPAREN -> 57
        | FSharpToken.SEMICOLON -> 58
        | FSharpToken.STAR -> 59
        | FSharpToken.THEN -> 60
        | FSharpToken.TRY -> 61
        | FSharpToken.TYPAR _ -> 62
        | FSharpToken.TYPE -> 63
        | FSharpToken.USE -> 64
        | FSharpToken.USE_BANG -> 65
        | FSharpToken.WHEN -> 66
        | FSharpToken.WHILE -> 67
        | FSharpToken.WHILE_BANG -> 68
        | FSharpToken.WHITESPACE -> 69
        | FSharpToken.WITH -> 70
        | FSharpToken.YIELD -> 71
        | FSharpToken.YIELD_BANG -> 72
    let tag (tok:FSharpToken) =
        match tok with
        | FSharpToken.ALWAYS_INFIX _ -> "ALWAYS_INFIX"
        | FSharpToken.ALWAYS_PREFIX _ -> "ALWAYS_PREFIX"
        | FSharpToken.AND -> "AND"
        | FSharpToken.AND_BANG -> "AND_BANG"
        | FSharpToken.AS -> "AS"
        | FSharpToken.BAR -> "|"
        | FSharpToken.BAR_RBRACE -> "|}"
        | FSharpToken.BAR_RBRACK -> "|]"
        | FSharpToken.BAR_RPAREN -> "|)"
        | FSharpToken.COLON -> ":"
        | FSharpToken.COMMA -> ","
        | FSharpToken.DO -> "DO"
        | FSharpToken.DOT -> "."
        | FSharpToken.DO_BANG -> "DO_BANG"
        | FSharpToken.ELIF -> "ELIF"
        | FSharpToken.ELSE -> "ELSE"
        | FSharpToken.EOF -> "EOF"
        | FSharpToken.EQUALS -> "="
        | FSharpToken.EXCLAM -> "!"
        | FSharpToken.FINALLY -> "FINALLY"
        | FSharpToken.FOR -> "FOR"
        | FSharpToken.FUN -> "FUN"
        | FSharpToken.FUNCTION -> "FUNCTION"
        | FSharpToken.GREATER -> ">"
        | FSharpToken.GREATER_GREATER -> ">>"
        | FSharpToken.IDENT _ -> "IDENT"
        | FSharpToken.IF -> "IF"
        | FSharpToken.IN -> "IN"
        | FSharpToken.LARROW -> "<-"
        | FSharpToken.LBRACE -> "{"
        | FSharpToken.LBRACE_BAR -> "{|"
        | FSharpToken.LBRACK -> "["
        | FSharpToken.LBRACK_BAR -> "[|"
        | FSharpToken.LESS -> "<"
        | FSharpToken.LESS_LESS -> "<<"
        | FSharpToken.LET -> "LET"
        | FSharpToken.LET_BANG -> "LET_BANG"
        | FSharpToken.LITERAL _ -> "LITERAL"
        | FSharpToken.LLPAREN -> "LLPAREN"
        | FSharpToken.LPAREN -> "("
        | FSharpToken.LPAREN_BAR -> "(|"
        | FSharpToken.MATCH -> "MATCH"
        | FSharpToken.MATCH_BANG -> "MATCH_BANG"
        | FSharpToken.MINUS -> "-"
        | FSharpToken.MODULE -> "MODULE"
        | FSharpToken.MUTABLE -> "MUTABLE"
        | FSharpToken.NEW_LINE _ -> "NEW_LINE"
        | FSharpToken.OPEN -> "OPEN"
        | FSharpToken.PLUS -> "+"
        | FSharpToken.RARROW -> "->"
        | FSharpToken.RBRACE -> "}"
        | FSharpToken.RBRACK -> "]"
        | FSharpToken.REC -> "REC"
        | FSharpToken.RETURN -> "RETURN"
        | FSharpToken.RETURN_BANG -> "RETURN_BANG"
        | FSharpToken.RHSEND -> "RHSEND"
        | FSharpToken.RPAREN -> ")"
        | FSharpToken.RRPAREN -> "RRPAREN"
        | FSharpToken.SEMICOLON -> ";"
        | FSharpToken.STAR -> "*"
        | FSharpToken.THEN -> "THEN"
        | FSharpToken.TRY -> "TRY"
        | FSharpToken.TYPAR _ -> "TYPAR"
        | FSharpToken.TYPE -> "TYPE"
        | FSharpToken.USE -> "USE"
        | FSharpToken.USE_BANG -> "USE_BANG"
        | FSharpToken.WHEN -> "WHEN"
        | FSharpToken.WHILE -> "WHILE"
        | FSharpToken.WHILE_BANG -> "WHILE_BANG"
        | FSharpToken.WHITESPACE -> "WHITESPACE"
        | FSharpToken.WITH -> "WITH"
        | FSharpToken.YIELD -> "YIELD"
        | FSharpToken.YIELD_BANG -> "YIELD_BANG"
    let tagToIndex (tag:string) =
        match tag with
        | "ALWAYS_INFIX" -> 0
        | "ALWAYS_PREFIX" -> 1
        | "AND" -> 2
        | "AND_BANG" -> 3
        | "AS" -> 4
        | "|" -> 5
        | "|}" -> 6
        | "|]" -> 7
        | "|)" -> 8
        | ":" -> 9
        | "," -> 10
        | "DO" -> 11
        | "." -> 12
        | "DO_BANG" -> 13
        | "ELIF" -> 14
        | "ELSE" -> 15
        | "EOF" -> 16
        | "=" -> 17
        | "!" -> 18
        | "FINALLY" -> 19
        | "FOR" -> 20
        | "FUN" -> 21
        | "FUNCTION" -> 22
        | ">" -> 23
        | ">>" -> 24
        | "IDENT" -> 25
        | "IF" -> 26
        | "IN" -> 27
        | "<-" -> 28
        | "{" -> 29
        | "{|" -> 30
        | "[" -> 31
        | "[|" -> 32
        | "<" -> 33
        | "<<" -> 34
        | "LET" -> 35
        | "LET_BANG" -> 36
        | "LITERAL" -> 37
        | "LLPAREN" -> 38
        | "(" -> 39
        | "(|" -> 40
        | "MATCH" -> 41
        | "MATCH_BANG" -> 42
        | "-" -> 43
        | "MODULE" -> 44
        | "MUTABLE" -> 45
        | "NEW_LINE" -> 46
        | "OPEN" -> 47
        | "+" -> 48
        | "->" -> 49
        | "}" -> 50
        | "]" -> 51
        | "REC" -> 52
        | "RETURN" -> 53
        | "RETURN_BANG" -> 54
        | "RHSEND" -> 55
        | ")" -> 56
        | "RRPAREN" -> 57
        | ";" -> 58
        | "*" -> 59
        | "THEN" -> 60
        | "TRY" -> 61
        | "TYPAR" -> 62
        | "TYPE" -> 63
        | "USE" -> 64
        | "USE_BANG" -> 65
        | "WHEN" -> 66
        | "WHILE" -> 67
        | "WHILE_BANG" -> 68
        | "WHITESPACE" -> 69
        | "WITH" -> 70
        | "YIELD" -> 71
        | "YIELD_BANG" -> 72
        | _ -> failwithf "unexpected tag:%s" tag
    let lexeme (tok:FSharpToken) =
        match tok with
        | FSharpToken.ALWAYS_INFIX x -> box x
        | FSharpToken.ALWAYS_PREFIX x -> box x
        | FSharpToken.AND -> null
        | FSharpToken.AND_BANG -> null
        | FSharpToken.AS -> null
        | FSharpToken.BAR -> null
        | FSharpToken.BAR_RBRACE -> null
        | FSharpToken.BAR_RBRACK -> null
        | FSharpToken.BAR_RPAREN -> null
        | FSharpToken.COLON -> null
        | FSharpToken.COMMA -> null
        | FSharpToken.DO -> null
        | FSharpToken.DOT -> null
        | FSharpToken.DO_BANG -> null
        | FSharpToken.ELIF -> null
        | FSharpToken.ELSE -> null
        | FSharpToken.EOF -> null
        | FSharpToken.EQUALS -> null
        | FSharpToken.EXCLAM -> null
        | FSharpToken.FINALLY -> null
        | FSharpToken.FOR -> null
        | FSharpToken.FUN -> null
        | FSharpToken.FUNCTION -> null
        | FSharpToken.GREATER -> null
        | FSharpToken.GREATER_GREATER -> null
        | FSharpToken.IDENT x -> box x
        | FSharpToken.IF -> null
        | FSharpToken.IN -> null
        | FSharpToken.LARROW -> null
        | FSharpToken.LBRACE -> null
        | FSharpToken.LBRACE_BAR -> null
        | FSharpToken.LBRACK -> null
        | FSharpToken.LBRACK_BAR -> null
        | FSharpToken.LESS -> null
        | FSharpToken.LESS_LESS -> null
        | FSharpToken.LET -> null
        | FSharpToken.LET_BANG -> null
        | FSharpToken.LITERAL x -> box x
        | FSharpToken.LLPAREN -> null
        | FSharpToken.LPAREN -> null
        | FSharpToken.LPAREN_BAR -> null
        | FSharpToken.MATCH -> null
        | FSharpToken.MATCH_BANG -> null
        | FSharpToken.MINUS -> null
        | FSharpToken.MODULE -> null
        | FSharpToken.MUTABLE -> null
        | FSharpToken.NEW_LINE x -> box x
        | FSharpToken.OPEN -> null
        | FSharpToken.PLUS -> null
        | FSharpToken.RARROW -> null
        | FSharpToken.RBRACE -> null
        | FSharpToken.RBRACK -> null
        | FSharpToken.REC -> null
        | FSharpToken.RETURN -> null
        | FSharpToken.RETURN_BANG -> null
        | FSharpToken.RHSEND -> null
        | FSharpToken.RPAREN -> null
        | FSharpToken.RRPAREN -> null
        | FSharpToken.SEMICOLON -> null
        | FSharpToken.STAR -> null
        | FSharpToken.THEN -> null
        | FSharpToken.TRY -> null
        | FSharpToken.TYPAR x -> box x
        | FSharpToken.TYPE -> null
        | FSharpToken.USE -> null
        | FSharpToken.USE_BANG -> null
        | FSharpToken.WHEN -> null
        | FSharpToken.WHILE -> null
        | FSharpToken.WHILE_BANG -> null
        | FSharpToken.WHITESPACE -> null
        | FSharpToken.WITH -> null
        | FSharpToken.YIELD -> null
        | FSharpToken.YIELD_BANG -> null
    let offsideLexeme (spaces:int option) (tok:FSharpToken) =
        match tok with
        | FSharpToken.ALWAYS_INFIX x -> box(spaces, x)
        | FSharpToken.ALWAYS_PREFIX x -> box(spaces, x)
        | FSharpToken.AND -> box spaces
        | FSharpToken.AND_BANG -> box spaces
        | FSharpToken.AS -> box spaces
        | FSharpToken.BAR -> box spaces
        | FSharpToken.BAR_RBRACE -> box spaces
        | FSharpToken.BAR_RBRACK -> box spaces
        | FSharpToken.BAR_RPAREN -> box spaces
        | FSharpToken.COLON -> box spaces
        | FSharpToken.COMMA -> box spaces
        | FSharpToken.DO -> box spaces
        | FSharpToken.DOT -> box spaces
        | FSharpToken.DO_BANG -> box spaces
        | FSharpToken.ELIF -> box spaces
        | FSharpToken.ELSE -> box spaces
        | FSharpToken.EOF -> box spaces
        | FSharpToken.EQUALS -> box spaces
        | FSharpToken.EXCLAM -> box spaces
        | FSharpToken.FINALLY -> box spaces
        | FSharpToken.FOR -> box spaces
        | FSharpToken.FUN -> box spaces
        | FSharpToken.FUNCTION -> box spaces
        | FSharpToken.GREATER -> box spaces
        | FSharpToken.GREATER_GREATER -> box spaces
        | FSharpToken.IDENT x -> box(spaces, x)
        | FSharpToken.IF -> box spaces
        | FSharpToken.IN -> box spaces
        | FSharpToken.LARROW -> box spaces
        | FSharpToken.LBRACE -> box spaces
        | FSharpToken.LBRACE_BAR -> box spaces
        | FSharpToken.LBRACK -> box spaces
        | FSharpToken.LBRACK_BAR -> box spaces
        | FSharpToken.LESS -> box spaces
        | FSharpToken.LESS_LESS -> box spaces
        | FSharpToken.LET -> box spaces
        | FSharpToken.LET_BANG -> box spaces
        | FSharpToken.LITERAL x -> box(spaces, x)
        | FSharpToken.LLPAREN -> box spaces
        | FSharpToken.LPAREN -> box spaces
        | FSharpToken.LPAREN_BAR -> box spaces
        | FSharpToken.MATCH -> box spaces
        | FSharpToken.MATCH_BANG -> box spaces
        | FSharpToken.MINUS -> box spaces
        | FSharpToken.MODULE -> box spaces
        | FSharpToken.MUTABLE -> box spaces
        | FSharpToken.NEW_LINE x -> box(spaces, x)
        | FSharpToken.OPEN -> box spaces
        | FSharpToken.PLUS -> box spaces
        | FSharpToken.RARROW -> box spaces
        | FSharpToken.RBRACE -> box spaces
        | FSharpToken.RBRACK -> box spaces
        | FSharpToken.REC -> box spaces
        | FSharpToken.RETURN -> box spaces
        | FSharpToken.RETURN_BANG -> box spaces
        | FSharpToken.RHSEND -> box spaces
        | FSharpToken.RPAREN -> box spaces
        | FSharpToken.RRPAREN -> box spaces
        | FSharpToken.SEMICOLON -> box spaces
        | FSharpToken.STAR -> box spaces
        | FSharpToken.THEN -> box spaces
        | FSharpToken.TRY -> box spaces
        | FSharpToken.TYPAR x -> box(spaces, x)
        | FSharpToken.TYPE -> box spaces
        | FSharpToken.USE -> box spaces
        | FSharpToken.USE_BANG -> box spaces
        | FSharpToken.WHEN -> box spaces
        | FSharpToken.WHILE -> box spaces
        | FSharpToken.WHILE_BANG -> box spaces
        | FSharpToken.WHITESPACE -> box spaces
        | FSharpToken.WITH -> box spaces
        | FSharpToken.YIELD -> box spaces
        | FSharpToken.YIELD_BANG -> box spaces
