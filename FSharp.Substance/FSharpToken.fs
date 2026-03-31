namespace FSharp.Substance

type FSharpToken =
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
    let index (tok: FSharpToken) =
        match tok with
        | FSharpToken.BAR -> 0
        | FSharpToken.BAR_RBRACE -> 1
        | FSharpToken.BAR_RBRACK -> 2
        | FSharpToken.COLON -> 3
        | FSharpToken.COMMA -> 4
        | FSharpToken.DOT -> 5
        | FSharpToken.EOF -> 6
        | FSharpToken.EQUALS -> 7
        | FSharpToken.FUN -> 8
        | FSharpToken.GREATER -> 9
        | FSharpToken.HASH -> 10
        | FSharpToken.IDENT _ -> 11
        | FSharpToken.LBRACE -> 12
        | FSharpToken.LBRACE_BAR -> 13
        | FSharpToken.LBRACK -> 14
        | FSharpToken.LBRACK_BAR -> 15
        | FSharpToken.LESS -> 16
        | FSharpToken.LET -> 17
        | FSharpToken.LITERAL _ -> 18
        | FSharpToken.LPAREN -> 19
        | FSharpToken.MATCH -> 20
        | FSharpToken.MINUS -> 21
        | FSharpToken.MODULE -> 22
        | FSharpToken.NEW_LINE _ -> 23
        | FSharpToken.OPEN -> 24
        | FSharpToken.RARROW -> 25
        | FSharpToken.RBRACE -> 26
        | FSharpToken.RBRACK -> 27
        | FSharpToken.RPAREN -> 28
        | FSharpToken.SEMICOLON -> 29
        | FSharpToken.STAR -> 30
        | FSharpToken.TYPAR _ -> 31
        | FSharpToken.WHITESPACE -> 32
        | FSharpToken.WITH -> 33
    let tag (tok: FSharpToken) =
        match tok with
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
    let tagToValue (tag: string) =
        match tag with
        | "|" -> 0
        | "|}" -> 1
        | "|]" -> 2
        | ":" -> 3
        | "," -> 4
        | "." -> 5
        | "EOF" -> 6
        | "=" -> 7
        | "FUN" -> 8
        | ">" -> 9
        | "#" -> 10
        | "IDENT" -> 11
        | "{" -> 12
        | "{|" -> 13
        | "[" -> 14
        | "[|" -> 15
        | "<" -> 16
        | "LET" -> 17
        | "LITERAL" -> 18
        | "(" -> 19
        | "MATCH" -> 20
        | "-" -> 21
        | "MODULE" -> 22
        | "NEW_LINE" -> 23
        | "OPEN" -> 24
        | "->" -> 25
        | "}" -> 26
        | "]" -> 27
        | ")" -> 28
        | ";" -> 29
        | "*" -> 30
        | "TYPAR" -> 31
        | "WHITESPACE" -> 32
        | "WITH" -> 33
        | _ -> failwith tag
    let lexeme (tok: FSharpToken) =
        match tok with
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
