module FSharp.LexYacc.EscapeLexerTailer

open System
open FSharp.Idioms

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
    |> String.fromChars
