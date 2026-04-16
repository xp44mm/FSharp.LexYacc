namespace FSharp.Substance

type FSharpToken =
    //非用户输入的token，推理补全用的token（token filtering/injection）（lookahead token rewriting）
    | LLPAREN
    | RRPAREN
    | RHSEND
    | DUMMY

    //三个空白用于推理
    | NEW_LINE of space: int
    | WHITESPACE
    | EOF

    //在这两个符号前推理加入语句结束符号
    | SEMICOLON
    | BAR

    //| DO
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
    | TYPAR of string
    | WITH

module FSharpToken =
    let index (tok:FSharpToken) =
        match tok with
        | FSharpToken.LLPAREN -> 0
        | FSharpToken.RRPAREN -> 1
        | FSharpToken.RHSEND -> 2
        | FSharpToken.DUMMY -> 3
        | FSharpToken.NEW_LINE _ -> 4
        | FSharpToken.WHITESPACE -> 5
        | FSharpToken.EOF -> 6
        | FSharpToken.SEMICOLON -> 7
        | FSharpToken.BAR -> 8
        | FSharpToken.EQUALS -> 9
        | FSharpToken.RARROW -> 10
        | FSharpToken.BAR_RBRACE -> 11
        | FSharpToken.BAR_RBRACK -> 12
        | FSharpToken.COLON -> 13
        | FSharpToken.COMMA -> 14
        | FSharpToken.DOT -> 15
        | FSharpToken.FUN -> 16
        | FSharpToken.GREATER -> 17
        | FSharpToken.HASH -> 18
        | FSharpToken.IDENT _ -> 19
        | FSharpToken.LBRACE -> 20
        | FSharpToken.LBRACE_BAR -> 21
        | FSharpToken.LBRACK -> 22
        | FSharpToken.LBRACK_BAR -> 23
        | FSharpToken.LESS -> 24
        | FSharpToken.LET -> 25
        | FSharpToken.LITERAL _ -> 26
        | FSharpToken.LPAREN -> 27
        | FSharpToken.MATCH -> 28
        | FSharpToken.MINUS -> 29
        | FSharpToken.MODULE -> 30
        | FSharpToken.OPEN -> 31
        | FSharpToken.RBRACE -> 32
        | FSharpToken.RBRACK -> 33
        | FSharpToken.RPAREN -> 34
        | FSharpToken.STAR -> 35
        | FSharpToken.TYPAR _ -> 36
        | FSharpToken.WITH -> 37
    let tag (tok:FSharpToken) =
        match tok with
        | FSharpToken.LLPAREN -> "LLPAREN"
        | FSharpToken.RRPAREN -> "RRPAREN"
        | FSharpToken.RHSEND -> "RHSEND"
        | FSharpToken.DUMMY -> "DUMMY"
        | FSharpToken.NEW_LINE _ -> "NEW_LINE"
        | FSharpToken.WHITESPACE -> "WHITESPACE"
        | FSharpToken.EOF -> "EOF"
        | FSharpToken.SEMICOLON -> ";"
        | FSharpToken.BAR -> "|"
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
        | FSharpToken.TYPAR _ -> "TYPAR"
        | FSharpToken.WITH -> "WITH"
    let tagToIndex (tag:string) =
        match tag with
        | "LLPAREN" -> 0
        | "RRPAREN" -> 1
        | "RHSEND" -> 2
        | "DUMMY" -> 3
        | "NEW_LINE" -> 4
        | "WHITESPACE" -> 5
        | "EOF" -> 6
        | ";" -> 7
        | "|" -> 8
        | "=" -> 9
        | "->" -> 10
        | "|}" -> 11
        | "|]" -> 12
        | ":" -> 13
        | "," -> 14
        | "." -> 15
        | "FUN" -> 16
        | ">" -> 17
        | "#" -> 18
        | "IDENT" -> 19
        | "{" -> 20
        | "{|" -> 21
        | "[" -> 22
        | "[|" -> 23
        | "<" -> 24
        | "LET" -> 25
        | "LITERAL" -> 26
        | "(" -> 27
        | "MATCH" -> 28
        | "-" -> 29
        | "MODULE" -> 30
        | "OPEN" -> 31
        | "}" -> 32
        | "]" -> 33
        | ")" -> 34
        | "*" -> 35
        | "TYPAR" -> 36
        | "WITH" -> 37
        | _ -> failwithf "unexpected tag:%s" tag
    let lexeme (tok:FSharpToken) =
        match tok with
        | FSharpToken.LLPAREN -> null
        | FSharpToken.RRPAREN -> null
        | FSharpToken.RHSEND -> null
        | FSharpToken.DUMMY -> null
        | FSharpToken.NEW_LINE x -> box x
        | FSharpToken.WHITESPACE -> null
        | FSharpToken.EOF -> null
        | FSharpToken.SEMICOLON -> null
        | FSharpToken.BAR -> null
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
        | FSharpToken.TYPAR x -> box x
        | FSharpToken.WITH -> null
