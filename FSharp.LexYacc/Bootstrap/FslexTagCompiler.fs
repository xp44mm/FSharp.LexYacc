module FSharp.LexYacc.Bootstrap.FslexTagCompiler

open System

open FSharp.Idioms
open FSharp.Idioms.Literal

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
    |> FslexTagYacc.parser.parse

/// 解析文本为结构化数据
let compile (input: string) =
    let iter = LexicalIterator.forChar input

    iter
    |> FslexLexerTailer.tokenize
    |> FslexFilterTailer.tokenize
    |> parseTokens
    |> FslexTagYacc.unboxRoot
