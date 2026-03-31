module FSharp.Substance.FSharpCompiler

open FSharp.Idioms
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
open System
open FSharp.Idioms.Literal

let parseTokens (tokens: seq<FSharpToken>) =
    tokens
    |> Seq.map(fun tok ->
        id<TokenRow<_>> { token = tok; tag = FSharpToken.tag tok; lexeme = FSharpToken.lexeme tok }
    )
    |> Iterator
    |> FSharpYacc.parser.parse

/// 解析文本为结构化数据
let compile (input: string) =
    let input = "\n" + input
    let iter = LexicalIterator.forChar input

    iter
    |> FSharpLexerTailer.tokenize
    |> Seq.filter(fun tok ->
        match tok with
        //| NEW_LINE _ -> false
        | WHITESPACE -> false
        | _ -> true
    )
    |> Light.transform
    |> Seq.map(fun (ident, tok) ->
        {
            token = (ident, tok)
            tag = FSharpToken.tag tok
            lexeme = box(ident, FSharpToken.lexeme tok)
        }
        : TokenRow<int option * FSharpToken>
    )
    //|> supplement 
    |> Iterator
    |> FSharpYacc.parser.parse
    |> FSharpYacc.unboxRoot
