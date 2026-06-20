module FSharp.Substance.Light

open FSharp.Idioms
open FSharp.LexYacc
open Microsoft.FSharp.Reflection

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

let tokenRow indent tok : TokenRow<int option * FSharpToken> =
    {
        token = indent, tok
        tag = FSharpToken.tag tok
        lexeme = FSharpToken.offsideLexeme indent tok
    }

let none = tokenRow None

let None_RRPAREN = tokenRow None RRPAREN
let None_RHSEND = tokenRow None RHSEND
let None_SEMICOLON = tokenRow None SEMICOLON

let unionType = typeof<FSharpToken>
let getTag (tok: FSharpToken) =
    let caseInfo, _ = FSharpValue.GetUnionFields(tok, unionType)
    caseInfo.Name

/// 根据符号得到其名称
let nameofsymbols =
    FSharpToken.symbols
    |> List.map(fun (tok, symbol) -> symbol, getTag tok)
    |> Map.ofList

let getName (symbol: string) =
    if nameofsymbols.ContainsKey symbol then
        nameofsymbols.[symbol]
    else
        symbol

let important =
    set
        [
            FSharpToken.tag FSharpToken.LLPAREN
            FSharpToken.tag FSharpToken.RHSEND
            FSharpToken.tag FSharpToken.RRPAREN
            FSharpToken.tag FSharpToken.SEMICOLON
        ]

let famous =
    set
        [
            //FSharpToken.tag FSharpToken.BAR
            FSharpToken.tag FSharpToken.BAR_RBRACK
            //FSharpToken.tag FSharpToken.EOF
            FSharpToken.tag FSharpToken.LBRACE
            FSharpToken.tag FSharpToken.LBRACK
            FSharpToken.tag FSharpToken.LBRACK_BAR
            FSharpToken.tag FSharpToken.LPAREN
            FSharpToken.tag FSharpToken.RBRACE
            FSharpToken.tag FSharpToken.RBRACK
            FSharpToken.tag FSharpToken.RPAREN
        ]

/// 蜕化
let degenerate ctor (revList: (option<int> * 'a) list) =
    let i, ls = revList |> List.rev |> List.unzip

    let pat =
        if ls.Length > 1 then
            ctor ls
        else
            ls.[0]
    i.[0], pat


/// 
let mapsnd (revList: (option<int> * 'a) list) =
    revList |> List.rev |> List.map snd


