module FSharp.LexYacc.FslexTagCompiler

open System
open FSharp.Idioms.Literal

let parser =
    FslexTagYaccNew.app.getParser<FslexToken>(FslexToken.tag, FslexToken.lexeme)

let tbl = FslexTagYaccNew.app.getTable parser

let parseTokens (tokens: seq<FslexToken>) =
    tokens |> parser.parse |> FslexTagYaccNew.unboxRoot

/// 解析文本为结构化数据
let compile (txt: string) =
    FslexLexer.tokenize txt
    |> Seq.concat
    |> FslexFilter.tokenize
    |> Seq.concat
    |> parser.parse
    |> FslexTagYaccNew.unboxRoot

////let mutable tokens = []
//let mutable states = [ 0, null ]
//|> Seq.iter(fun lookahead ->
//    //match parser.tryReduce(states,lookahead) with
//    //| Some x -> states <- x
//    //| None -> ()
//    states <- parser.shift(states, lookahead)
//)

//match parser.tryReduce(states) with
//| None -> ()
//| Some x -> states <- x

//match states with
//| [ 1, lxm; 0, null ] -> FslexTagYaccNew.unboxRoot lxm
//| _ -> failwith $"{stringify states}"
