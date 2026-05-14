namespace FSharp.Substance

type FSharpToken =
    //| AMP
    //| AMP_AMP
    //| AMP_AMP_AMP
    //| AT
    //| BAR_BAR
    //| BAR_BAR_BAR
    //| BAR_BAR_BAR_GREATER
    //| BAR_BAR_GREATER
    //| CARET_CARET_CARET
    //| COLON_COLON
    //| COLON_QMARK
    //| COLON_QMARK_GREATER
    //| DIV
    //| DOT_DOT
    //| DOT_DOT_DOT
    //| DUMMY
    //| GREATER_GREATER_GREATER
    //| LESS_BAR_BAR
    //| LESS_BAR_BAR_BAR
    //| LESS_GREATER
    //| LESS_LESS_LESS
    //| LPIPE
    //| PERCENT
    //| RPIPE
    //| STAR_STAR
    //| TILDE_TILDE_TILDE
    //| HASH

    | ALWAYS_INFIX of string
    | ALWAYS_PREFIX of string
    | BAR
    | BAR_RBRACE
    | BAR_RBRACK
    | BAR_RPAREN
    | COLON
    | COMMA
    | DO
    | DOT
    | EOF
    | EQUALS
    | EXCLAM
    | FUN
    | GREATER
    | GREATER_GREATER
    | IDENT of string
    | LARROW
    | LBRACE
    | LBRACE_BAR
    | LBRACK
    | LBRACK_BAR
    | LESS
    | LESS_LESS
    | LET
    | LITERAL of Literal
    | LLPAREN
    | LPAREN
    | LPAREN_BAR
    | MATCH
    | MINUS
    | MODULE
    | NEW_LINE of space: int
    | OPEN
    | PLUS
    | RARROW
    | RBRACE
    | RBRACK
    | RHSEND
    | RPAREN
    | RRPAREN
    | SEMICOLON
    | STAR
    | TYPAR of string
    | WHITESPACE
    | WITH

module FSharpToken =
    let index (tok:FSharpToken) =
        match tok with
        | FSharpToken.ALWAYS_INFIX _ -> 0
        | FSharpToken.ALWAYS_PREFIX _ -> 1
        | FSharpToken.BAR -> 2
        | FSharpToken.BAR_RBRACE -> 3
        | FSharpToken.BAR_RBRACK -> 4
        | FSharpToken.BAR_RPAREN -> 5
        | FSharpToken.COLON -> 6
        | FSharpToken.COMMA -> 7
        | FSharpToken.DO -> 8
        | FSharpToken.DOT -> 9
        | FSharpToken.EOF -> 10
        | FSharpToken.EQUALS -> 11
        | FSharpToken.EXCLAM -> 12
        | FSharpToken.FUN -> 13
        | FSharpToken.GREATER -> 14
        | FSharpToken.GREATER_GREATER -> 15
        | FSharpToken.IDENT _ -> 16
        | FSharpToken.LARROW -> 17
        | FSharpToken.LBRACE -> 18
        | FSharpToken.LBRACE_BAR -> 19
        | FSharpToken.LBRACK -> 20
        | FSharpToken.LBRACK_BAR -> 21
        | FSharpToken.LESS -> 22
        | FSharpToken.LESS_LESS -> 23
        | FSharpToken.LET -> 24
        | FSharpToken.LITERAL _ -> 25
        | FSharpToken.LLPAREN -> 26
        | FSharpToken.LPAREN -> 27
        | FSharpToken.LPAREN_BAR -> 28
        | FSharpToken.MATCH -> 29
        | FSharpToken.MINUS -> 30
        | FSharpToken.MODULE -> 31
        | FSharpToken.NEW_LINE _ -> 32
        | FSharpToken.OPEN -> 33
        | FSharpToken.PLUS -> 34
        | FSharpToken.RARROW -> 35
        | FSharpToken.RBRACE -> 36
        | FSharpToken.RBRACK -> 37
        | FSharpToken.RHSEND -> 38
        | FSharpToken.RPAREN -> 39
        | FSharpToken.RRPAREN -> 40
        | FSharpToken.SEMICOLON -> 41
        | FSharpToken.STAR -> 42
        | FSharpToken.TYPAR _ -> 43
        | FSharpToken.WHITESPACE -> 44
        | FSharpToken.WITH -> 45
    let tag (tok:FSharpToken) =
        match tok with
        | FSharpToken.ALWAYS_INFIX _ -> "ALWAYS_INFIX"
        | FSharpToken.ALWAYS_PREFIX _ -> "ALWAYS_PREFIX"
        | FSharpToken.BAR -> "|"
        | FSharpToken.BAR_RBRACE -> "|}"
        | FSharpToken.BAR_RBRACK -> "|]"
        | FSharpToken.BAR_RPAREN -> "|)"
        | FSharpToken.COLON -> ":"
        | FSharpToken.COMMA -> ","
        | FSharpToken.DO -> "DO"
        | FSharpToken.DOT -> "."
        | FSharpToken.EOF -> "EOF"
        | FSharpToken.EQUALS -> "="
        | FSharpToken.EXCLAM -> "!"
        | FSharpToken.FUN -> "FUN"
        | FSharpToken.GREATER -> ">"
        | FSharpToken.GREATER_GREATER -> ">>"
        | FSharpToken.IDENT _ -> "IDENT"
        | FSharpToken.LARROW -> "<-"
        | FSharpToken.LBRACE -> "{"
        | FSharpToken.LBRACE_BAR -> "{|"
        | FSharpToken.LBRACK -> "["
        | FSharpToken.LBRACK_BAR -> "[|"
        | FSharpToken.LESS -> "<"
        | FSharpToken.LESS_LESS -> "<<"
        | FSharpToken.LET -> "LET"
        | FSharpToken.LITERAL _ -> "LITERAL"
        | FSharpToken.LLPAREN -> "LLPAREN"
        | FSharpToken.LPAREN -> "("
        | FSharpToken.LPAREN_BAR -> "(|"
        | FSharpToken.MATCH -> "MATCH"
        | FSharpToken.MINUS -> "-"
        | FSharpToken.MODULE -> "MODULE"
        | FSharpToken.NEW_LINE _ -> "NEW_LINE"
        | FSharpToken.OPEN -> "OPEN"
        | FSharpToken.PLUS -> "+"
        | FSharpToken.RARROW -> "->"
        | FSharpToken.RBRACE -> "}"
        | FSharpToken.RBRACK -> "]"
        | FSharpToken.RHSEND -> "RHSEND"
        | FSharpToken.RPAREN -> ")"
        | FSharpToken.RRPAREN -> "RRPAREN"
        | FSharpToken.SEMICOLON -> ";"
        | FSharpToken.STAR -> "*"
        | FSharpToken.TYPAR _ -> "TYPAR"
        | FSharpToken.WHITESPACE -> "WHITESPACE"
        | FSharpToken.WITH -> "WITH"
    let tagToIndex (tag:string) =
        match tag with
        | "ALWAYS_INFIX" -> 0
        | "ALWAYS_PREFIX" -> 1
        | "|" -> 2
        | "|}" -> 3
        | "|]" -> 4
        | "|)" -> 5
        | ":" -> 6
        | "," -> 7
        | "DO" -> 8
        | "." -> 9
        | "EOF" -> 10
        | "=" -> 11
        | "!" -> 12
        | "FUN" -> 13
        | ">" -> 14
        | ">>" -> 15
        | "IDENT" -> 16
        | "<-" -> 17
        | "{" -> 18
        | "{|" -> 19
        | "[" -> 20
        | "[|" -> 21
        | "<" -> 22
        | "<<" -> 23
        | "LET" -> 24
        | "LITERAL" -> 25
        | "LLPAREN" -> 26
        | "(" -> 27
        | "(|" -> 28
        | "MATCH" -> 29
        | "-" -> 30
        | "MODULE" -> 31
        | "NEW_LINE" -> 32
        | "OPEN" -> 33
        | "+" -> 34
        | "->" -> 35
        | "}" -> 36
        | "]" -> 37
        | "RHSEND" -> 38
        | ")" -> 39
        | "RRPAREN" -> 40
        | ";" -> 41
        | "*" -> 42
        | "TYPAR" -> 43
        | "WHITESPACE" -> 44
        | "WITH" -> 45
        | _ -> failwithf "unexpected tag:%s" tag
    let lexeme (tok:FSharpToken) =
        match tok with
        | FSharpToken.ALWAYS_INFIX x -> box x
        | FSharpToken.ALWAYS_PREFIX x -> box x
        | FSharpToken.BAR -> null
        | FSharpToken.BAR_RBRACE -> null
        | FSharpToken.BAR_RBRACK -> null
        | FSharpToken.BAR_RPAREN -> null
        | FSharpToken.COLON -> null
        | FSharpToken.COMMA -> null
        | FSharpToken.DO -> null
        | FSharpToken.DOT -> null
        | FSharpToken.EOF -> null
        | FSharpToken.EQUALS -> null
        | FSharpToken.EXCLAM -> null
        | FSharpToken.FUN -> null
        | FSharpToken.GREATER -> null
        | FSharpToken.GREATER_GREATER -> null
        | FSharpToken.IDENT x -> box x
        | FSharpToken.LARROW -> null
        | FSharpToken.LBRACE -> null
        | FSharpToken.LBRACE_BAR -> null
        | FSharpToken.LBRACK -> null
        | FSharpToken.LBRACK_BAR -> null
        | FSharpToken.LESS -> null
        | FSharpToken.LESS_LESS -> null
        | FSharpToken.LET -> null
        | FSharpToken.LITERAL x -> box x
        | FSharpToken.LLPAREN -> null
        | FSharpToken.LPAREN -> null
        | FSharpToken.LPAREN_BAR -> null
        | FSharpToken.MATCH -> null
        | FSharpToken.MINUS -> null
        | FSharpToken.MODULE -> null
        | FSharpToken.NEW_LINE x -> box x
        | FSharpToken.OPEN -> null
        | FSharpToken.PLUS -> null
        | FSharpToken.RARROW -> null
        | FSharpToken.RBRACE -> null
        | FSharpToken.RBRACK -> null
        | FSharpToken.RHSEND -> null
        | FSharpToken.RPAREN -> null
        | FSharpToken.RRPAREN -> null
        | FSharpToken.SEMICOLON -> null
        | FSharpToken.STAR -> null
        | FSharpToken.TYPAR x -> box x
        | FSharpToken.WHITESPACE -> null
        | FSharpToken.WITH -> null
