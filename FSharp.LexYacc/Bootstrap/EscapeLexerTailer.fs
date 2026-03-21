module FSharp.LexYacc.Bootstrap.EscapeLexerTailer

open System
open FSharp.LexYacc
open FSharp.Idioms

//let tokenize (iter:LexicalIterator<char*int>) =
//    iter
//    |> EscapeLexer.anal.split
//    |> Seq.map(fun (rule_id, buff) ->
//        let action = EscapeLexer.actions.[rule_id]
//        action buff
//    )

/// "\\r\\n" -> "\r\n"
let unquote (buff: char list) =
    buff.[1 .. buff.Length - 2]
    |> List.toArray
    |> Array.map(fun ch -> ch, int ch)
    |> ArrayStack
    |> LexicalIterator.ofArrayStack
    |> EscapeLexer.anal.split
    |> Seq.map(fun (rule_id, buff) ->
        let action = EscapeLexer.actions.[rule_id]
        action buff
    )
    |> String.build
