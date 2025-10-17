module FSharp.LexYacc.Experimental.FslexFilterTailer

open FSharp.Idioms

open FSharp.LexYacc
open FSharp.LexYacc.Experimental

let tokenize (tokens: seq<FSharp.LexYacc.Experimental.FslexToken>) =
    tokens
    |> Seq.map(fun tok -> tok, FSharp.LexYacc.Experimental.FslexToken.index tok)
    |> BufferIterator
    |> LexicalIterator.ofBufferIterator

    |> FSharp.LexYacc.Experimental.FslexFilter.anal.split
    |> Seq.collect(fun (rule_id, buff) ->
        let action = FSharp.LexYacc.Experimental.FslexFilter.actions.[rule_id]
        action buff
    )
