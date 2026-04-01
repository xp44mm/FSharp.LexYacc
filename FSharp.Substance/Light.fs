module FSharp.Substance.Light

open FSharp.Idioms

let transform (tokens: FSharpToken seq) =
    let iterator = Iterator tokens

    let rec loop (lastToken: FSharpToken) =
        seq {
            match iterator.tryNext() with
            | None -> ()
            | Some(NEW_LINE _ as tok) -> yield! loop tok
            | Some tok ->
                let ident =
                    match lastToken with
                    | NEW_LINE i -> Some i
                    | _ -> None
                yield ident, tok
                yield! loop tok
        }

    loop(NEW_LINE 0)

let offsideLexeme (spaces:int option) (tok: FSharpToken) =
    match tok with
    | FSharpToken.LLPAREN -> box spaces
    | FSharpToken.RRPAREN -> box spaces
    | FSharpToken.BAR -> box spaces
    | FSharpToken.BAR_RBRACE -> box spaces
    | FSharpToken.BAR_RBRACK -> box spaces
    | FSharpToken.COLON -> box spaces
    | FSharpToken.COMMA -> box spaces
    | FSharpToken.DOT -> box spaces
    | FSharpToken.EOF -> box spaces
    | FSharpToken.EQUALS -> box spaces
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
    | FSharpToken.LITERAL x -> box x
    | FSharpToken.LPAREN -> box spaces
    | FSharpToken.MATCH -> box spaces
    | FSharpToken.MINUS -> box spaces
    | FSharpToken.MODULE -> box spaces
    | FSharpToken.OPEN -> box spaces
    | FSharpToken.RARROW -> box spaces
    | FSharpToken.RBRACE -> box spaces
    | FSharpToken.RBRACK -> box spaces
    | FSharpToken.RPAREN -> box spaces
    | FSharpToken.SEMICOLON -> box spaces
    | FSharpToken.STAR -> box spaces
    | FSharpToken.TYPAR x -> box(spaces, x)
    | FSharpToken.WITH -> box spaces
    | FSharpToken.NEW_LINE _
    | FSharpToken.WHITESPACE -> failwith "has elimed"

let offsideLexeme1 (spaces:int option) (tok:FSharpToken) =
    match tok with
    | FSharpToken.LLPAREN -> box spaces
    | FSharpToken.RRPAREN -> box spaces
    | FSharpToken.BAR -> box spaces
    | FSharpToken.BAR_RBRACE -> box spaces
    | FSharpToken.BAR_RBRACK -> box spaces
    | FSharpToken.COLON -> box spaces
    | FSharpToken.COMMA -> box spaces
    | FSharpToken.DOT -> box spaces
    | FSharpToken.EOF -> box spaces
    | FSharpToken.EQUALS -> box spaces
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
    | FSharpToken.NEW_LINE x -> box(spaces, x)
    | FSharpToken.OPEN -> box spaces
    | FSharpToken.RARROW -> box spaces
    | FSharpToken.RBRACE -> box spaces
    | FSharpToken.RBRACK -> box spaces
    | FSharpToken.RPAREN -> box spaces
    | FSharpToken.SEMICOLON -> box spaces
    | FSharpToken.STAR -> box spaces
    | FSharpToken.TYPAR x -> box(spaces, x)
    | FSharpToken.WHITESPACE -> box spaces
    | FSharpToken.WITH -> box spaces

