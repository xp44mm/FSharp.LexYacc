module FSharp.LexYacc.Bootstrap.FsyaccCompiler

open System
open FSharp.Idioms
open FSharp.Idioms.Literal
open FSharp.LexYacc

let parseTokens (tokens: seq<FsyaccToken>) =
    tokens
    |> Seq.map(fun tok -> {
        token = tok
        tag = FsyaccToken.tag tok
        lexeme = FsyaccToken.lexeme tok
    })
    |> Iterator
    |> FsyaccYacc.parser.parse

/// 解析文本为结构化数据
let compile (input: string) =
    let iter = LexicalIterator.forChar input

    iter
    |> FsyaccLexerTailer.tokenize
    |> Seq.map(fun tok -> 
        Console.WriteLine(stringify tok)
        tok
    
    )
    |> parseTokens
    |> FsyaccYacc.unboxRoot

