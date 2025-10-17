module FSharp.LexYacc.Bootstrap.FslexFilterTailer

open FSharp.Idioms

open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
let tokenize (tokens: seq<FslexToken>) =

    let iter =
        tokens
        |> Seq.map(fun tok -> tok, FslexToken.index tok)
        |> CircularBufferIterator
        |> LexicalIterator.ofBufferIterator

    iter
    |> FslexFilter.anal.split
    |> Seq.collect(fun (rule_id, buff) ->
        let action = FslexFilter.actions.[rule_id]
        action buff
    )
