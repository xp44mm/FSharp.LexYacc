namespace FSharp.LexYacc

open FSharp.Idioms

type LexicalIterator<'a> = {
    tryNext: unit -> 'a option
    //hasEnded: unit -> bool
    pop: int -> unit
} with
    static member ofArrayStack(iterator: ArrayStack<'a>) = {
        tryNext = iterator.tryNext
        //hasEnded = fun () -> iterator.current >= iterator.count
        pop = iterator.pop
    }

    static member ofBufferIterator(iterator: CircularBufferIterator<'a>) = {
        tryNext = iterator.tryNext
        //hasEnded = fun () -> iterator.current.IsNone
        pop = iterator.dequeue
    }

module LexicalIterator =
    let forChar (input: string) =
        input.ToCharArray()
        |> Array.map(fun ch -> ch, int ch)
        |> ArrayStack
        |> LexicalIterator.ofArrayStack

    let forString indexed (tokens: seq<'tok>) =
        tokens
        |> Seq.map(fun tok -> tok, indexed tok)
        |> CircularBufferIterator
        |> LexicalIterator.ofBufferIterator

