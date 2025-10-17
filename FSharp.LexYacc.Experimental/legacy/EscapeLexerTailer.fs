module FSharp.LexYacc.Experimental.EscapeLexerTailer

open System
open FSharp.LexYacc
open FSharp.Idioms

let tokenLexicalIterator (input: string) =
    input.ToCharArray()
    |> Array.map(fun ch -> ch, int ch)
    |> ArrayStack
    |> LexicalIterator.ofArrayStack

let tokenize (iter:LexicalIterator<char*int>) =
    iter
    |> FSharp.LexYacc.Experimental.EscapeLexer.anal.split
    |> Seq.map(fun (rule_id, buff) ->
        let action = FSharp.LexYacc.Experimental.EscapeLexer.actions.[rule_id]
        action buff
    )
