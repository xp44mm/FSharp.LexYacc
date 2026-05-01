namespace FSharp.Substance

type FSharpToken =
    | EXCLAM
    | PERCENT
    | AMP
    | PLUS
    | DIV
    | AT
    | STAR_STAR
    | AMP_AMP
    | BAR_BAR
    | LESS_GREATER
    | COLON_QMARK_GREATER
    | COLON_QMARK
    | COLON_COLON
    | LARROW
    | RPIPE
    | LPIPE
    | BAR_RPAREN
    | LPAREN_BAR
    | LESS_BAR_BAR
    | LESS_BAR_BAR_BAR
    | BAR_BAR_GREATER
    | BAR_BAR_BAR_GREATER
    //| AMP_AMP_AMP
    //| BAR_BAR_BAR
    //| CARET_CARET_CARET
    //| TILDE_TILDE_TILDE
    //| LESS_LESS_LESS
    //| GREATER_GREATER_GREATER
    | GREATER_GREATER
    | LESS_LESS
    | DOT_DOT
    //| DOT_DOT_DOT

    | LLPAREN
    | RRPAREN
    | RHSEND
    | DUMMY

    | NEW_LINE of space: int
    | WHITESPACE
    | EOF

    | SEMICOLON
    | BAR

    | DO
    | EQUALS
    | RARROW

    | BAR_RBRACE
    | BAR_RBRACK
    | COLON
    | COMMA
    | DOT
    | FUN
    | GREATER
    | HASH
    | IDENT of string
    | LBRACE
    | LBRACE_BAR
    | LBRACK
    | LBRACK_BAR
    | LESS
    | LET
    | LITERAL of Literal
    | LPAREN
    | MATCH
    | MINUS
    | MODULE
    | OPEN
    | RBRACE
    | RBRACK
    | RPAREN
    | STAR
    | WITH

    | TYPAR of string


module FSharpToken =
    let index (tok:FSharpToken) =
        match tok with
        | FSharpToken.EXCLAM -> 0
        | FSharpToken.PERCENT -> 1
        | FSharpToken.AMP -> 2
        | FSharpToken.PLUS -> 3
        | FSharpToken.DIV -> 4
        | FSharpToken.AT -> 5
        | FSharpToken.STAR_STAR -> 6
        | FSharpToken.AMP_AMP -> 7
        | FSharpToken.BAR_BAR -> 8
        | FSharpToken.LESS_GREATER -> 9
        | FSharpToken.COLON_QMARK_GREATER -> 10
        | FSharpToken.COLON_QMARK -> 11
        | FSharpToken.COLON_COLON -> 12
        | FSharpToken.LARROW -> 13
        | FSharpToken.RPIPE -> 14
        | FSharpToken.LPIPE -> 15
        | FSharpToken.BAR_RPAREN -> 16
        | FSharpToken.LPAREN_BAR -> 17
        | FSharpToken.LESS_BAR_BAR -> 18
        | FSharpToken.LESS_BAR_BAR_BAR -> 19
        | FSharpToken.BAR_BAR_GREATER -> 20
        | FSharpToken.BAR_BAR_BAR_GREATER -> 21
        | FSharpToken.GREATER_GREATER -> 22
        | FSharpToken.LESS_LESS -> 23
        | FSharpToken.DOT_DOT -> 24
        | FSharpToken.LLPAREN -> 25
        | FSharpToken.RRPAREN -> 26
        | FSharpToken.RHSEND -> 27
        | FSharpToken.DUMMY -> 28
        | FSharpToken.NEW_LINE _ -> 29
        | FSharpToken.WHITESPACE -> 30
        | FSharpToken.EOF -> 31
        | FSharpToken.SEMICOLON -> 32
        | FSharpToken.BAR -> 33
        | FSharpToken.DO -> 34
        | FSharpToken.EQUALS -> 35
        | FSharpToken.RARROW -> 36
        | FSharpToken.BAR_RBRACE -> 37
        | FSharpToken.BAR_RBRACK -> 38
        | FSharpToken.COLON -> 39
        | FSharpToken.COMMA -> 40
        | FSharpToken.DOT -> 41
        | FSharpToken.FUN -> 42
        | FSharpToken.GREATER -> 43
        | FSharpToken.HASH -> 44
        | FSharpToken.IDENT _ -> 45
        | FSharpToken.LBRACE -> 46
        | FSharpToken.LBRACE_BAR -> 47
        | FSharpToken.LBRACK -> 48
        | FSharpToken.LBRACK_BAR -> 49
        | FSharpToken.LESS -> 50
        | FSharpToken.LET -> 51
        | FSharpToken.LITERAL _ -> 52
        | FSharpToken.LPAREN -> 53
        | FSharpToken.MATCH -> 54
        | FSharpToken.MINUS -> 55
        | FSharpToken.MODULE -> 56
        | FSharpToken.OPEN -> 57
        | FSharpToken.RBRACE -> 58
        | FSharpToken.RBRACK -> 59
        | FSharpToken.RPAREN -> 60
        | FSharpToken.STAR -> 61
        | FSharpToken.WITH -> 62
        | FSharpToken.TYPAR _ -> 63
    let tag (tok:FSharpToken) =
        match tok with
        | FSharpToken.EXCLAM -> "!"
        | FSharpToken.PERCENT -> "%"
        | FSharpToken.AMP -> "&"
        | FSharpToken.PLUS -> "+"
        | FSharpToken.DIV -> "/"
        | FSharpToken.AT -> "@"
        | FSharpToken.STAR_STAR -> "**"
        | FSharpToken.AMP_AMP -> "&&"
        | FSharpToken.BAR_BAR -> "||"
        | FSharpToken.LESS_GREATER -> "<>"
        | FSharpToken.COLON_QMARK_GREATER -> ":?>"
        | FSharpToken.COLON_QMARK -> ":?"
        | FSharpToken.COLON_COLON -> "::"
        | FSharpToken.LARROW -> "<-"
        | FSharpToken.RPIPE -> "|>"
        | FSharpToken.LPIPE -> "<|"
        | FSharpToken.BAR_RPAREN -> "|)"
        | FSharpToken.LPAREN_BAR -> "(|"
        | FSharpToken.LESS_BAR_BAR -> "<||"
        | FSharpToken.LESS_BAR_BAR_BAR -> "<|||"
        | FSharpToken.BAR_BAR_GREATER -> "||>"
        | FSharpToken.BAR_BAR_BAR_GREATER -> "|||>"
        | FSharpToken.GREATER_GREATER -> ">>"
        | FSharpToken.LESS_LESS -> "<<"
        | FSharpToken.DOT_DOT -> ".."
        | FSharpToken.LLPAREN -> "LLPAREN"
        | FSharpToken.RRPAREN -> "RRPAREN"
        | FSharpToken.RHSEND -> "RHSEND"
        | FSharpToken.DUMMY -> "DUMMY"
        | FSharpToken.NEW_LINE _ -> "NEW_LINE"
        | FSharpToken.WHITESPACE -> "WHITESPACE"
        | FSharpToken.EOF -> "EOF"
        | FSharpToken.SEMICOLON -> ";"
        | FSharpToken.BAR -> "|"
        | FSharpToken.DO -> "DO"
        | FSharpToken.EQUALS -> "="
        | FSharpToken.RARROW -> "->"
        | FSharpToken.BAR_RBRACE -> "|}"
        | FSharpToken.BAR_RBRACK -> "|]"
        | FSharpToken.COLON -> ":"
        | FSharpToken.COMMA -> ","
        | FSharpToken.DOT -> "."
        | FSharpToken.FUN -> "FUN"
        | FSharpToken.GREATER -> ">"
        | FSharpToken.HASH -> "#"
        | FSharpToken.IDENT _ -> "IDENT"
        | FSharpToken.LBRACE -> "{"
        | FSharpToken.LBRACE_BAR -> "{|"
        | FSharpToken.LBRACK -> "["
        | FSharpToken.LBRACK_BAR -> "[|"
        | FSharpToken.LESS -> "<"
        | FSharpToken.LET -> "LET"
        | FSharpToken.LITERAL _ -> "LITERAL"
        | FSharpToken.LPAREN -> "("
        | FSharpToken.MATCH -> "MATCH"
        | FSharpToken.MINUS -> "-"
        | FSharpToken.MODULE -> "MODULE"
        | FSharpToken.OPEN -> "OPEN"
        | FSharpToken.RBRACE -> "}"
        | FSharpToken.RBRACK -> "]"
        | FSharpToken.RPAREN -> ")"
        | FSharpToken.STAR -> "*"
        | FSharpToken.WITH -> "WITH"
        | FSharpToken.TYPAR _ -> "TYPAR"
    let tagToIndex (tag:string) =
        match tag with
        | "!" -> 0
        | "%" -> 1
        | "&" -> 2
        | "+" -> 3
        | "/" -> 4
        | "@" -> 5
        | "**" -> 6
        | "&&" -> 7
        | "||" -> 8
        | "<>" -> 9
        | ":?>" -> 10
        | ":?" -> 11
        | "::" -> 12
        | "<-" -> 13
        | "|>" -> 14
        | "<|" -> 15
        | "|)" -> 16
        | "(|" -> 17
        | "<||" -> 18
        | "<|||" -> 19
        | "||>" -> 20
        | "|||>" -> 21
        | ">>" -> 22
        | "<<" -> 23
        | ".." -> 24
        | "LLPAREN" -> 25
        | "RRPAREN" -> 26
        | "RHSEND" -> 27
        | "DUMMY" -> 28
        | "NEW_LINE" -> 29
        | "WHITESPACE" -> 30
        | "EOF" -> 31
        | ";" -> 32
        | "|" -> 33
        | "DO" -> 34
        | "=" -> 35
        | "->" -> 36
        | "|}" -> 37
        | "|]" -> 38
        | ":" -> 39
        | "," -> 40
        | "." -> 41
        | "FUN" -> 42
        | ">" -> 43
        | "#" -> 44
        | "IDENT" -> 45
        | "{" -> 46
        | "{|" -> 47
        | "[" -> 48
        | "[|" -> 49
        | "<" -> 50
        | "LET" -> 51
        | "LITERAL" -> 52
        | "(" -> 53
        | "MATCH" -> 54
        | "-" -> 55
        | "MODULE" -> 56
        | "OPEN" -> 57
        | "}" -> 58
        | "]" -> 59
        | ")" -> 60
        | "*" -> 61
        | "WITH" -> 62
        | "TYPAR" -> 63
        | _ -> failwithf "unexpected tag:%s" tag
    let lexeme (tok:FSharpToken) =
        match tok with
        | FSharpToken.EXCLAM -> null
        | FSharpToken.PERCENT -> null
        | FSharpToken.AMP -> null
        | FSharpToken.PLUS -> null
        | FSharpToken.DIV -> null
        | FSharpToken.AT -> null
        | FSharpToken.STAR_STAR -> null
        | FSharpToken.AMP_AMP -> null
        | FSharpToken.BAR_BAR -> null
        | FSharpToken.LESS_GREATER -> null
        | FSharpToken.COLON_QMARK_GREATER -> null
        | FSharpToken.COLON_QMARK -> null
        | FSharpToken.COLON_COLON -> null
        | FSharpToken.LARROW -> null
        | FSharpToken.RPIPE -> null
        | FSharpToken.LPIPE -> null
        | FSharpToken.BAR_RPAREN -> null
        | FSharpToken.LPAREN_BAR -> null
        | FSharpToken.LESS_BAR_BAR -> null
        | FSharpToken.LESS_BAR_BAR_BAR -> null
        | FSharpToken.BAR_BAR_GREATER -> null
        | FSharpToken.BAR_BAR_BAR_GREATER -> null
        | FSharpToken.GREATER_GREATER -> null
        | FSharpToken.LESS_LESS -> null
        | FSharpToken.DOT_DOT -> null
        | FSharpToken.LLPAREN -> null
        | FSharpToken.RRPAREN -> null
        | FSharpToken.RHSEND -> null
        | FSharpToken.DUMMY -> null
        | FSharpToken.NEW_LINE x -> box x
        | FSharpToken.WHITESPACE -> null
        | FSharpToken.EOF -> null
        | FSharpToken.SEMICOLON -> null
        | FSharpToken.BAR -> null
        | FSharpToken.DO -> null
        | FSharpToken.EQUALS -> null
        | FSharpToken.RARROW -> null
        | FSharpToken.BAR_RBRACE -> null
        | FSharpToken.BAR_RBRACK -> null
        | FSharpToken.COLON -> null
        | FSharpToken.COMMA -> null
        | FSharpToken.DOT -> null
        | FSharpToken.FUN -> null
        | FSharpToken.GREATER -> null
        | FSharpToken.HASH -> null
        | FSharpToken.IDENT x -> box x
        | FSharpToken.LBRACE -> null
        | FSharpToken.LBRACE_BAR -> null
        | FSharpToken.LBRACK -> null
        | FSharpToken.LBRACK_BAR -> null
        | FSharpToken.LESS -> null
        | FSharpToken.LET -> null
        | FSharpToken.LITERAL x -> box x
        | FSharpToken.LPAREN -> null
        | FSharpToken.MATCH -> null
        | FSharpToken.MINUS -> null
        | FSharpToken.MODULE -> null
        | FSharpToken.OPEN -> null
        | FSharpToken.RBRACE -> null
        | FSharpToken.RBRACK -> null
        | FSharpToken.RPAREN -> null
        | FSharpToken.STAR -> null
        | FSharpToken.WITH -> null
        | FSharpToken.TYPAR x -> box x
