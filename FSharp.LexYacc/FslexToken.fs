namespace FSharp.LexYacc.Bootstrap

/// 各个符号的含义见getTag/getLexeme函数
type FslexToken =
    | AMP
    | APOSTROPHE of literal: char
    | BAR
    | BRACES of code: string
    | COLON
    | EQUALS
    | FUN_TYPE of funType: string
    | HYPHEN
    | ID of name: string
    | LBRACK
    | LBRACK_CARET
    | LET
    | LPAREN
    | PLUS
    | QMARK
    | QUOTE of literal: string
    | RBRACK
    | RPAREN
    | RULE
    | SLASH
    | STAR
    | UNDERSCORE

module FslexToken =
    let index (tok:FslexToken) =
        match tok with
        | FslexToken.AMP -> 0
        | FslexToken.APOSTROPHE _ -> 1
        | FslexToken.BAR -> 2
        | FslexToken.BRACES _ -> 3
        | FslexToken.COLON -> 4
        | FslexToken.EQUALS -> 5
        | FslexToken.FUN_TYPE _ -> 6
        | FslexToken.HYPHEN -> 7
        | FslexToken.ID _ -> 8
        | FslexToken.LBRACK -> 9
        | FslexToken.LBRACK_CARET -> 10
        | FslexToken.LET -> 11
        | FslexToken.LPAREN -> 12
        | FslexToken.PLUS -> 13
        | FslexToken.QMARK -> 14
        | FslexToken.QUOTE _ -> 15
        | FslexToken.RBRACK -> 16
        | FslexToken.RPAREN -> 17
        | FslexToken.RULE -> 18
        | FslexToken.SLASH -> 19
        | FslexToken.STAR -> 20
        | FslexToken.UNDERSCORE -> 21
    let tag (tok:FslexToken) =
        match tok with
        | FslexToken.AMP -> "&"
        | FslexToken.APOSTROPHE _ -> "APOSTROPHE"
        | FslexToken.BAR -> "|"
        | FslexToken.BRACES _ -> "BRACES"
        | FslexToken.COLON -> ":"
        | FslexToken.EQUALS -> "="
        | FslexToken.FUN_TYPE _ -> "FUN_TYPE"
        | FslexToken.HYPHEN -> "-"
        | FslexToken.ID _ -> "ID"
        | FslexToken.LBRACK -> "["
        | FslexToken.LBRACK_CARET -> "[^"
        | FslexToken.LET -> "LET"
        | FslexToken.LPAREN -> "("
        | FslexToken.PLUS -> "+"
        | FslexToken.QMARK -> "?"
        | FslexToken.QUOTE _ -> "QUOTE"
        | FslexToken.RBRACK -> "]"
        | FslexToken.RPAREN -> ")"
        | FslexToken.RULE -> "RULE"
        | FslexToken.SLASH -> "/"
        | FslexToken.STAR -> "*"
        | FslexToken.UNDERSCORE -> "UNDERSCORE"
    let tagToValue (tag:string) =
        match tag with
        | "&" -> 0
        | "APOSTROPHE" -> 1
        | "|" -> 2
        | "BRACES" -> 3
        | ":" -> 4
        | "=" -> 5
        | "FUN_TYPE" -> 6
        | "-" -> 7
        | "ID" -> 8
        | "[" -> 9
        | "[^" -> 10
        | "LET" -> 11
        | "(" -> 12
        | "+" -> 13
        | "?" -> 14
        | "QUOTE" -> 15
        | "]" -> 16
        | ")" -> 17
        | "RULE" -> 18
        | "/" -> 19
        | "*" -> 20
        | "UNDERSCORE" -> 21
        | _ -> failwith tag
    let lexeme (tok:FslexToken) =
        match tok with
        | FslexToken.AMP -> null
        | FslexToken.APOSTROPHE x -> box x
        | FslexToken.BAR -> null
        | FslexToken.BRACES x -> box x
        | FslexToken.COLON -> null
        | FslexToken.EQUALS -> null
        | FslexToken.FUN_TYPE x -> box x
        | FslexToken.HYPHEN -> null
        | FslexToken.ID x -> box x
        | FslexToken.LBRACK -> null
        | FslexToken.LBRACK_CARET -> null
        | FslexToken.LET -> null
        | FslexToken.LPAREN -> null
        | FslexToken.PLUS -> null
        | FslexToken.QMARK -> null
        | FslexToken.QUOTE x -> box x
        | FslexToken.RBRACK -> null
        | FslexToken.RPAREN -> null
        | FslexToken.RULE -> null
        | FslexToken.SLASH -> null
        | FslexToken.STAR -> null
        | FslexToken.UNDERSCORE -> null

