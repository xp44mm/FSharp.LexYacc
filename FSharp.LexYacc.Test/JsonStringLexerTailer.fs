module FSharp.Jsons.JsonStringLexerTailer
open System
open FSharp.Idioms

open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap

let tokenize (iter:LexicalIterator<char*int>) =
    iter
    |> EscapeLexer.anal.split
    |> Seq.map(fun (rule_id, buff) ->
        let action = EscapeLexer.actions.[rule_id]
        action buff
    )

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
