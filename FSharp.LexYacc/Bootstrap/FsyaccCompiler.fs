module FSharp.LexYacc.Bootstrap.FsyaccCompiler

open System
open FSharp.Idioms
open FSharp.Idioms.Literal
open FSharp.LexYacc



let parseTokens (tokens: seq<FsyaccToken>) =
    tokens
    |> Seq.map(fun tok ->
        {
            token = tok
            tag = FsyaccToken.tag tok
            lexeme = FsyaccToken.lexeme tok
        }
    )
    |> Iterator
    |> FsyaccYacc.parser.parse

/// 解析文本为结构化数据
let compile (input: string) =
    let iter = LexicalIterator.forChar input

    iter
    |> FsyaccLexerTailer.tokenize
    |> parseTokens
    |> FsyaccYacc.unboxRoot

//let parser =
//    FsyaccYaccOld.app.getParser<FsyaccToken>(FsyaccToken.tag, FsyaccToken.lexeme)

//let tbl = FsyaccYaccOld.app.getTable parser

/// 解析文本为结构化数据
//let compile (input: string) =
//    let iter = LexicalIterator.forChar input

//    FsyaccLexerTailer.tokenize iter
//    |> parser.parse
//    |> FsyaccYaccOld.unboxRoot
