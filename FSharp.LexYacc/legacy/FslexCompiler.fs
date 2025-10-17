module FSharp.LexYacc.FslexCompiler

open System

open FSharp.Idioms.Literal
open FSharp.Idioms

let parser =
    FslexYaccNew.app.getParser<FslexToken>(FslexToken.tag, FslexToken.lexeme)

let tbl = FslexYaccNew.app.getTable parser

let parseTokens (tokens: seq<FslexToken>) =
    tokens |> parser.parse |> FslexYaccNew.unboxRoot

/// 解析文本为结构化数据
let compile (txt: string) =
    let input =
        txt.ToCharArray()
        |> Array.map(fun ch -> ch, int ch)
        |> ArrayStack
        |> LexicalIterator.ofArrayStack

    FslexLexer.tokenize txt
    |> Seq.concat
    |> FslexFilter.tokenize
    |> Seq.concat
    |> parser.parse
    |> FslexYaccNew.unboxRoot

//let mutable states = [ 0, null ]
//|> Seq.iter(fun lookahead ->
//    states <- parser.shift(states, lookahead)
//)

//match parser.tryReduce(states) with
//| None -> ()
//| Some x -> states <- x

//match states with
//| [ 1, lxm; 0, null ] -> FslexYaccNew.unboxRoot lxm
//| _ -> failwith $"{stringify states}"
