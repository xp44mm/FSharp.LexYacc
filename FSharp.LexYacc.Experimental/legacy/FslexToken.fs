namespace FSharp.LexYacc.Experimental

/// 各个符号的含义见getTag/getLexeme函数
type FslexToken =
    | AMP
    | APOSTROPHE of literal: char
    | BAR
    | BRACES of code: string
    | COLON_AND_FUNTYPE of funType: string
    | EQUALS
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
        | FslexToken.COLON_AND_FUNTYPE _ -> 4
        | FslexToken.EQUALS -> 5
        | FslexToken.HYPHEN -> 6
        | FslexToken.ID _ -> 7
        | FslexToken.LBRACK -> 8
        | FslexToken.LBRACK_CARET -> 9
        | FslexToken.LET -> 10
        | FslexToken.LPAREN -> 11
        | FslexToken.PLUS -> 12
        | FslexToken.QMARK -> 13
        | FslexToken.QUOTE _ -> 14
        | FslexToken.RBRACK -> 15
        | FslexToken.RPAREN -> 16
        | FslexToken.RULE -> 17
        | FslexToken.SLASH -> 18
        | FslexToken.STAR -> 19
        | FslexToken.UNDERSCORE -> 20
    let tag (tok:FslexToken) =
        match tok with
        | FslexToken.AMP -> "&"
        | FslexToken.APOSTROPHE _ -> "APOSTROPHE"
        | FslexToken.BAR -> "|"
        | FslexToken.BRACES _ -> "BRACES"
        | FslexToken.COLON_AND_FUNTYPE _ -> "COLON_AND_FUNTYPE"
        | FslexToken.EQUALS -> "="
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
        | "COLON_AND_FUNTYPE" -> 4
        | "=" -> 5
        | "-" -> 6
        | "ID" -> 7
        | "[" -> 8
        | "[^" -> 9
        | "LET" -> 10
        | "(" -> 11
        | "+" -> 12
        | "?" -> 13
        | "QUOTE" -> 14
        | "]" -> 15
        | ")" -> 16
        | "RULE" -> 17
        | "/" -> 18
        | "*" -> 19
        | "UNDERSCORE" -> 20
        | _ -> failwith tag
    let lexeme (tok:FslexToken) =
        match tok with
        | FslexToken.AMP -> null
        | FslexToken.APOSTROPHE x -> box x
        | FslexToken.BAR -> null
        | FslexToken.BRACES x -> box x
        | FslexToken.COLON_AND_FUNTYPE x -> box x
        | FslexToken.EQUALS -> null
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




