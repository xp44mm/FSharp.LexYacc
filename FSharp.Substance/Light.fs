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

let offsideLexeme (spaces:int option) (tok:FSharpToken) =
    match tok with
    | FSharpToken.ALWAYS_INFIX x -> box(spaces, x)
    | FSharpToken.ALWAYS_PREFIX x -> box(spaces, x)
    | FSharpToken.BAR -> box spaces
    | FSharpToken.BAR_RBRACE -> box spaces
    | FSharpToken.BAR_RBRACK -> box spaces
    | FSharpToken.BAR_RPAREN -> box spaces
    | FSharpToken.COLON -> box spaces
    | FSharpToken.COMMA -> box spaces
    | FSharpToken.DO -> box spaces
    | FSharpToken.DOT -> box spaces
    | FSharpToken.EOF -> box spaces
    | FSharpToken.EQUALS -> box spaces
    | FSharpToken.EXCLAM -> box spaces
    | FSharpToken.FUN -> box spaces
    | FSharpToken.GREATER -> box spaces
    | FSharpToken.GREATER_GREATER -> box spaces
    | FSharpToken.IDENT x -> box(spaces, x)
    | FSharpToken.LARROW -> box spaces
    | FSharpToken.LBRACE -> box spaces
    | FSharpToken.LBRACE_BAR -> box spaces
    | FSharpToken.LBRACK -> box spaces
    | FSharpToken.LBRACK_BAR -> box spaces
    | FSharpToken.LESS -> box spaces
    | FSharpToken.LESS_LESS -> box spaces
    | FSharpToken.LET -> box spaces
    | FSharpToken.LITERAL x -> box(spaces, x)
    | FSharpToken.LLPAREN -> box spaces
    | FSharpToken.LPAREN -> box spaces
    | FSharpToken.LPAREN_BAR -> box spaces
    | FSharpToken.MATCH -> box spaces
    | FSharpToken.MINUS -> box spaces
    | FSharpToken.MODULE -> box spaces
    | FSharpToken.NEW_LINE x -> box(spaces, x)
    | FSharpToken.OPEN -> box spaces
    | FSharpToken.PLUS -> box spaces
    | FSharpToken.RARROW -> box spaces
    | FSharpToken.RBRACE -> box spaces
    | FSharpToken.RBRACK -> box spaces
    | FSharpToken.RHSEND -> box spaces
    | FSharpToken.RPAREN -> box spaces
    | FSharpToken.RRPAREN -> box spaces
    | FSharpToken.SEMICOLON -> box spaces
    | FSharpToken.STAR -> box spaces
    | FSharpToken.TYPAR x -> box(spaces, x)
    | FSharpToken.WHITESPACE -> box spaces
    | FSharpToken.WITH -> box spaces

let tokenRow indent tok : TokenRow<int option * FSharpToken> =
    {
        token = indent, tok
        tag = FSharpToken.tag tok
        lexeme = offsideLexeme indent tok
    }

let none = tokenRow None

let None_RRPAREN = tokenRow None RRPAREN
let None_RHSEND = tokenRow None RHSEND
let None_SEMICOLON = tokenRow None SEMICOLON
