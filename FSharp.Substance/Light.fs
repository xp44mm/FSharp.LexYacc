module FSharp.Substance.Light

open FSharp.Idioms
open FSharp.LexYacc

///合并缩进到行首的token
let transform (tokens: FSharpToken seq) =
    let iterator = Iterator tokens
    let rec loop (prevToken: FSharpToken) =
        seq {
            match iterator.tryNext() with
            | None -> ()
            | Some(NEW_LINE _ as tok) -> yield! loop tok
            | Some tok ->
                let ident =
                    match prevToken with
                    | NEW_LINE i -> Some i
                    | _ -> None
                yield ident, tok
                yield! loop tok
        }

    loop(NEW_LINE 0)

let offsideLexeme (spaces: int option) (tok: FSharpToken) =
    match tok with
    | FSharpToken.EXCLAM -> box spaces
    | FSharpToken.PERCENT -> box spaces
    | FSharpToken.AMP -> box spaces
    | FSharpToken.PLUS -> box spaces
    | FSharpToken.DIV -> box spaces
    | FSharpToken.AT -> box spaces
    | FSharpToken.STAR_STAR -> box spaces
    | FSharpToken.AMP_AMP -> box spaces
    | FSharpToken.BAR_BAR -> box spaces
    | FSharpToken.LESS_GREATER -> box spaces
    | FSharpToken.COLON_QMARK_GREATER -> box spaces
    | FSharpToken.COLON_QMARK -> box spaces
    | FSharpToken.COLON_COLON -> box spaces
    | FSharpToken.LARROW -> box spaces
    | FSharpToken.RPIPE -> box spaces
    | FSharpToken.LPIPE -> box spaces
    | FSharpToken.BAR_RPAREN -> box spaces
    | FSharpToken.LPAREN_BAR -> box spaces
    | FSharpToken.LESS_BAR_BAR -> box spaces
    | FSharpToken.LESS_BAR_BAR_BAR -> box spaces
    | FSharpToken.BAR_BAR_GREATER -> box spaces
    | FSharpToken.BAR_BAR_BAR_GREATER -> box spaces
    | FSharpToken.GREATER_GREATER -> box spaces
    | FSharpToken.LESS_LESS -> box spaces
    | FSharpToken.DOT_DOT -> box spaces
    | FSharpToken.LLPAREN -> box spaces
    | FSharpToken.RRPAREN -> box spaces
    | FSharpToken.RHSEND -> box spaces
    | FSharpToken.DUMMY -> box spaces
    | FSharpToken.NEW_LINE x -> box(spaces, x)
    | FSharpToken.WHITESPACE -> box spaces
    | FSharpToken.EOF -> box spaces
    | FSharpToken.SEMICOLON -> box spaces
    | FSharpToken.BAR -> box spaces
    | FSharpToken.DO -> box spaces
    | FSharpToken.EQUALS -> box spaces
    | FSharpToken.RARROW -> box spaces
    | FSharpToken.BAR_RBRACE -> box spaces
    | FSharpToken.BAR_RBRACK -> box spaces
    | FSharpToken.COLON -> box spaces
    | FSharpToken.COMMA -> box spaces
    | FSharpToken.DOT -> box spaces
    | FSharpToken.FUN -> box spaces
    | FSharpToken.GREATER -> box spaces
    | FSharpToken.HASH -> box spaces
    | FSharpToken.IDENT x -> box(spaces, x)
    | FSharpToken.LBRACE -> box spaces
    | FSharpToken.LBRACE_BAR -> box spaces
    | FSharpToken.LBRACK -> box spaces
    | FSharpToken.LBRACK_BAR -> box spaces
    | FSharpToken.LESS -> box spaces
    | FSharpToken.LET -> box spaces
    | FSharpToken.LITERAL x -> box(spaces, x)
    | FSharpToken.LPAREN -> box spaces
    | FSharpToken.MATCH -> box spaces
    | FSharpToken.MINUS -> box spaces
    | FSharpToken.MODULE -> box spaces
    | FSharpToken.OPEN -> box spaces
    | FSharpToken.RBRACE -> box spaces
    | FSharpToken.RBRACK -> box spaces
    | FSharpToken.RPAREN -> box spaces
    | FSharpToken.STAR -> box spaces
    | FSharpToken.WITH -> box spaces
    | FSharpToken.TYPAR x -> box(spaces, x)

let tokenRow indent tok : TokenRow<int option * FSharpToken> =
    {
        token = indent, tok
        tag = FSharpToken.tag tok
        lexeme = offsideLexeme indent tok
    }

/// 用于lookahead判断
let semicolon_may_follow (tok: FSharpToken) =
    tok
    |> FSharpToken.tag
    |> RightSententialForm.follow_semicolon.Contains
