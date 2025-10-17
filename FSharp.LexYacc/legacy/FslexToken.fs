namespace FSharp.LexYacc

open FSharp.Idioms.ActivePatterns

/// 各个符号的含义见getTag/getLexeme函数
type FslexToken =
    | UNDERSCORE
    | HYPHEN
    | LET
    | APOSTROPHE of literal: char
    | QUOTE of literal: string
    | ID of name: string
    | BRACES of code: string
    | EQUALS
    | LPAREN
    | RPAREN
    | LBRACK_CARET
    | LBRACK
    | RBRACK
    | PLUS
    | STAR
    | SLASH
    | BAR
    | QMARK
    | AMP
    | PERCENT

    //static member tokenize(text: string) =
    //    let rec loop (src: string) = seq {
    //        match src with
    //        | "" -> ()
    //        | First '&' _ ->
    //            yield AMP
    //            let src = src.Substring(1)
    //            yield! loop src
    //        | First '(' _ ->
    //            yield LPAREN
    //            let src = src.Substring(1)
    //            yield! loop src
    //        | First ')' _ ->
    //            yield RPAREN
    //            let src = src.Substring(1)
    //            yield! loop src
    //        | First '*' _ ->
    //            yield STAR
    //            let src = src.Substring(1)
    //            yield! loop src
    //        | First '+' _ ->
    //            yield PLUS
    //            let src = src.Substring(1)
    //            yield! loop src
    //        | First '/' _ ->
    //            yield SLASH
    //            let src = src.Substring(1)
    //            yield! loop src
    //        | First '=' _ ->
    //            yield EQUALS
    //            let src = src.Substring(1)
    //            yield! loop src
    //        | First '?' _ ->
    //            yield QMARK
    //            let src = src.Substring(1)
    //            yield! loop src
    //        | First '[' _ ->
    //            let src = src.Substring(1)
    //            match src with
    //            | First '^' _ ->
    //                yield LBRACK_CARET
    //                let src = src.Substring(1)
    //                yield! loop src
    //            | _ ->
    //                yield LBRACK
    //                yield! loop src
    //        | First ']' _ ->
    //            yield RBRACK
    //            let src = src.Substring(1)
    //            yield! loop src
    //        | First '|' _ ->
    //            yield BAR
    //            let src = src.Substring(1)
    //            yield! loop src
    //        | First '-' _ ->
    //            yield HYPHEN
    //            let src = src.Substring(1)
    //            yield! loop src
    //        | Rgx @"^\s+" m ->
    //            let len = m.Length
    //            let src = src.Substring(len)
    //            yield! loop src
    //        | Rgx @"^//.*" m ->
    //            let len = m.Length
    //            let src = src.Substring(len)
    //            yield! loop src
    //        | Rgx @"^\w+" m ->
    //            yield
    //                match m.Value with
    //                | "_" -> FslexToken.UNDERSCORE
    //                | "let" -> FslexToken.LET
    //                | lxm -> FslexToken.ID lxm
    //            let src = src.Substring(m.Length)
    //            yield! loop src
    //        | StartsWith @"'\''" s ->
    //            yield APOSTROPHE '\''
    //            let src = src.Substring(s.Length)
    //            yield! loop src
    //        | StartsWith "%%" s ->
    //            yield PERCENT
    //            let src = src.Substring(s.Length)
    //            yield! loop src
    //        | Rgx @"^'[^\\']'" m ->
    //            let c = m.Value.[1]
    //            yield APOSTROPHE c
    //            let src = src.Substring(m.Length)
    //            yield! loop src
    //        | Rgx @"^'\\[^']'" m ->
    //            let c =
    //                match m.Value.[2] with
    //                | '\'' -> '\''
    //                | '\\' -> '\\'
    //                | 'a' -> '\a'
    //                | 'b' -> '\b'
    //                | 't' -> '\t'
    //                | 'n' -> '\n'
    //                | 'v' -> '\v'
    //                | 'f' -> '\f'
    //                | 'r' -> '\r'
    //                | _ -> failwith $"unimpl:{m.Value}"
    //            yield APOSTROPHE c
    //            let src = src.Substring(m.Length)
    //            yield! loop src
    //        | Rgx "^\"[^\"]*\"" m ->
    //            let l = m.Value.Substring(1,m.Length-2)
    //            yield QUOTE l
    //            let src = src.Substring(m.Length)
    //            yield! loop src
    //        | Rgx @"^\{[^}]*\}" m ->
    //            yield BRACES m.Value
    //            let src = src.Substring(m.Length)
    //            yield! loop src
    //        | _ -> failwith $"tokenize:{src}"
    //    }
    //    loop text

module FslexToken =
    let index (tok:FslexToken) =
        match tok with
        | UNDERSCORE -> 0
        | HYPHEN -> 1
        | LET -> 2
        | APOSTROPHE _ -> 3
        | QUOTE _ -> 4
        | ID _ -> 5
        | BRACES _ -> 6
        | EQUALS -> 7
        | LPAREN -> 8
        | RPAREN -> 9
        | LBRACK_CARET -> 10
        | LBRACK -> 11
        | RBRACK -> 12
        | PLUS -> 13
        | STAR -> 14
        | SLASH -> 15
        | BAR -> 16
        | QMARK -> 17
        | AMP -> 18
        | PERCENT -> 19
    let tag (tok:FslexToken) =
        match tok with
        | UNDERSCORE -> "UNDERSCORE"
        | HYPHEN -> "-"
        | LET -> "LET"
        | APOSTROPHE _ -> "APOSTROPHE"
        | QUOTE _ -> "QUOTE"
        | ID _ -> "ID"
        | BRACES _ -> "BRACES"
        | EQUALS -> "="
        | LPAREN -> "("
        | RPAREN -> ")"
        | LBRACK_CARET -> "[^"
        | LBRACK -> "["
        | RBRACK -> "]"
        | PLUS -> "+"
        | STAR -> "*"
        | SLASH -> "/"
        | BAR -> "|"
        | QMARK -> "?"
        | AMP -> "&"
        | PERCENT -> "%%"
    let tagToValue (tag:string) =
        match tag with
        | "UNDERSCORE" -> 0
        | "-" -> 1
        | "LET" -> 2
        | "APOSTROPHE" -> 3
        | "QUOTE" -> 4
        | "ID" -> 5
        | "BRACES" -> 6
        | "=" -> 7
        | "(" -> 8
        | ")" -> 9
        | "[^" -> 10
        | "[" -> 11
        | "]" -> 12
        | "+" -> 13
        | "*" -> 14
        | "/" -> 15
        | "|" -> 16
        | "?" -> 17
        | "&" -> 18
        | "%%" -> 19
        | _ -> failwith tag
    let lexeme (tok:FslexToken) =
        match tok with
        | UNDERSCORE -> null
        | HYPHEN -> null
        | LET -> null
        | APOSTROPHE x -> box x
        | QUOTE x -> box x
        | ID x -> box x
        | BRACES x -> box x
        | EQUALS -> null
        | LPAREN -> null
        | RPAREN -> null
        | LBRACK_CARET -> null
        | LBRACK -> null
        | RBRACK -> null
        | PLUS -> null
        | STAR -> null
        | SLASH -> null
        | BAR -> null
        | QMARK -> null
        | AMP -> null
        | PERCENT -> null


