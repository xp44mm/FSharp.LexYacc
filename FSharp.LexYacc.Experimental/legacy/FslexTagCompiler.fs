module FSharp.LexYacc.Experimental.FslexTagCompiler

open System

open FSharp.Idioms
open FSharp.Idioms.Literal

open FSharp.LexYacc
open FSharp.LexYacc.Experimental

let parser =
    FslexTagYacc.app.getParser<FSharp.LexYacc.Experimental.FslexToken>(
        FSharp.LexYacc.Experimental.FslexToken.tag,
        FSharp.LexYacc.Experimental.FslexToken.lexeme
    )

let tbl = FslexTagYacc.app.getTable parser

let parseTokens (tokens: seq<FSharp.LexYacc.Experimental.FslexToken>) =
    tokens |> parser.parse |> FslexTagYacc.unboxRoot

/// 解析文本为结构化数据
let compile (txt: string) =
    let iter =
        txt.ToCharArray()
        |> Array.map(fun ch -> ch, int ch)
        |> ArrayStack
        |> FSharp.LexYacc.LexicalIterator.ofArrayStack

    iter
    |> FslexLexerTailer.tokenize
    |> FSharp.LexYacc.Experimental.FslexFilterTailer.tokenize
    |> parseTokens
    |> FslexTagYacc.unboxRoot
