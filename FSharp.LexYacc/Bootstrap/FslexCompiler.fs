module FSharp.LexYacc.Bootstrap.FslexCompiler

open FSharp.Idioms
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap

let parseTokens (tokens: seq<FslexToken>) =
    tokens
    |> Seq.map(fun t ->
        id<TokenRow<_>> {
            token = t
            tag = FslexToken.tag t
            lexeme = FslexToken.lexeme t
        }
    )
    |> Iterator
    |> FslexYacc.parser.parse

/// 解析文本为结构化数据
let compile (input: string) =
    let iter = LexicalIterator.forChar input

    iter
    |> FslexLexerTailer.tokenize
    |> FslexFilterTailer.tokenize
    |> parseTokens
    |> FslexYacc.unboxRoot
