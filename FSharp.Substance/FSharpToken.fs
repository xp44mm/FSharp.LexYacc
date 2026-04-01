namespace FSharp.Substance

type FSharpToken =
    | LLPAREN
    | RRPAREN

    | BAR
    | BAR_RBRACE
    | BAR_RBRACK
    | COLON
    | COMMA
    | DOT
    | EOF
    | EQUALS
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
    | NEW_LINE of space: int
    | OPEN
    | RARROW
    | RBRACE
    | RBRACK
    | RPAREN
    | SEMICOLON
    | STAR
    | TYPAR of string
    | WHITESPACE
    | WITH

module FSharpToken =
    let index (tok:FSharpToken) =
        match tok with
        | FSharpToken.LLPAREN -> 0
        | FSharpToken.RRPAREN -> 1
        | FSharpToken.BAR -> 2
        | FSharpToken.BAR_RBRACE -> 3
        | FSharpToken.BAR_RBRACK -> 4
        | FSharpToken.COLON -> 5
        | FSharpToken.COMMA -> 6
        | FSharpToken.DOT -> 7
        | FSharpToken.EOF -> 8
        | FSharpToken.EQUALS -> 9
        | FSharpToken.FUN -> 10
        | FSharpToken.GREATER -> 11
        | FSharpToken.HASH -> 12
        | FSharpToken.IDENT _ -> 13
        | FSharpToken.LBRACE -> 14
        | FSharpToken.LBRACE_BAR -> 15
        | FSharpToken.LBRACK -> 16
        | FSharpToken.LBRACK_BAR -> 17
        | FSharpToken.LESS -> 18
        | FSharpToken.LET -> 19
        | FSharpToken.LITERAL _ -> 20
        | FSharpToken.LPAREN -> 21
        | FSharpToken.MATCH -> 22
        | FSharpToken.MINUS -> 23
        | FSharpToken.MODULE -> 24
        | FSharpToken.NEW_LINE _ -> 25
        | FSharpToken.OPEN -> 26
        | FSharpToken.RARROW -> 27
        | FSharpToken.RBRACE -> 28
        | FSharpToken.RBRACK -> 29
        | FSharpToken.RPAREN -> 30
        | FSharpToken.SEMICOLON -> 31
        | FSharpToken.STAR -> 32
        | FSharpToken.TYPAR _ -> 33
        | FSharpToken.WHITESPACE -> 34
        | FSharpToken.WITH -> 35
    let tag (tok:FSharpToken) =
        match tok with
        | FSharpToken.LLPAREN -> "LLPAREN"
        | FSharpToken.RRPAREN -> "RRPAREN"
        | FSharpToken.BAR -> "|"
        | FSharpToken.BAR_RBRACE -> "|}"
        | FSharpToken.BAR_RBRACK -> "|]"
        | FSharpToken.COLON -> ":"
        | FSharpToken.COMMA -> ","
        | FSharpToken.DOT -> "."
        | FSharpToken.EOF -> "EOF"
        | FSharpToken.EQUALS -> "="
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
        | FSharpToken.NEW_LINE _ -> "NEW_LINE"
        | FSharpToken.OPEN -> "OPEN"
        | FSharpToken.RARROW -> "->"
        | FSharpToken.RBRACE -> "}"
        | FSharpToken.RBRACK -> "]"
        | FSharpToken.RPAREN -> ")"
        | FSharpToken.SEMICOLON -> ";"
        | FSharpToken.STAR -> "*"
        | FSharpToken.TYPAR _ -> "TYPAR"
        | FSharpToken.WHITESPACE -> "WHITESPACE"
        | FSharpToken.WITH -> "WITH"
    let tagToValue (tag:string) =
        match tag with
        | "LLPAREN" -> 0
        | "RRPAREN" -> 1
        | "|" -> 2
        | "|}" -> 3
        | "|]" -> 4
        | ":" -> 5
        | "," -> 6
        | "." -> 7
        | "EOF" -> 8
        | "=" -> 9
        | "FUN" -> 10
        | ">" -> 11
        | "#" -> 12
        | "IDENT" -> 13
        | "{" -> 14
        | "{|" -> 15
        | "[" -> 16
        | "[|" -> 17
        | "<" -> 18
        | "LET" -> 19
        | "LITERAL" -> 20
        | "(" -> 21
        | "MATCH" -> 22
        | "-" -> 23
        | "MODULE" -> 24
        | "NEW_LINE" -> 25
        | "OPEN" -> 26
        | "->" -> 27
        | "}" -> 28
        | "]" -> 29
        | ")" -> 30
        | ";" -> 31
        | "*" -> 32
        | "TYPAR" -> 33
        | "WHITESPACE" -> 34
        | "WITH" -> 35
        | _ -> failwith tag
    let lexeme (tok:FSharpToken) =
        match tok with
        | FSharpToken.LLPAREN -> null
        | FSharpToken.RRPAREN -> null
        | FSharpToken.BAR -> null
        | FSharpToken.BAR_RBRACE -> null
        | FSharpToken.BAR_RBRACK -> null
        | FSharpToken.COLON -> null
        | FSharpToken.COMMA -> null
        | FSharpToken.DOT -> null
        | FSharpToken.EOF -> null
        | FSharpToken.EQUALS -> null
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
        | FSharpToken.NEW_LINE x -> box x
        | FSharpToken.OPEN -> null
        | FSharpToken.RARROW -> null
        | FSharpToken.RBRACE -> null
        | FSharpToken.RBRACK -> null
        | FSharpToken.RPAREN -> null
        | FSharpToken.SEMICOLON -> null
        | FSharpToken.STAR -> null
        | FSharpToken.TYPAR x -> box x
        | FSharpToken.WHITESPACE -> null
        | FSharpToken.WITH -> null
