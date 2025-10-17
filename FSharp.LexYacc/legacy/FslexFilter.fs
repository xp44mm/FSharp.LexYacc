module FSharp.LexYacc.FslexFilter
open System
open FSharp.LexYacc
open FSharp.Idioms
let transitions: Set<DFATransition> = set [{source=0u;label=[-7,-1;1,2;6,8;15,16;18,1048575];target=6u};{source=0u;label=[0,0;3,5;9,9;12,14;17,17];target=4u};{source=0u;label=[10,11];target=1u};{source=1u;label=[-7,11;13,1048575];target=2u};{source=1u;label=[12,12];target=3u};{source=2u;label=[-7,11;13,1048575];target=2u};{source=2u;label=[12,12];target=3u};{source=4u;label=[0,0;3,5;8,8;10,11];target=5u}]
let flags: Map<uint32, Set<byte * DFAStateFlag>> = Map [1u,set [0uy,Look;2uy,Accept];2u,set [0uy,Look];3u,set [0uy,Seen];4u,set [1uy,Look;2uy,Accept];5u,set [1uy,Seen];6u,set [2uy,Accept]]
let lookbehinds: Map<byte, Set<DFATransition> * Set<uint32>> = Map [0uy,(set [{source=0u;label=[12,12];target=1u}],set [1u]);1uy,(set [{source=0u;label=[0,0;3,5;8,8;10,11];target=1u}],set [1u])]

let anal = LexicalAnalyzer(transitions, flags, lookbehinds)

let actions: Map<byte, FslexToken list -> _> = Map [
    0uy, fun buff -> buff
    1uy, fun buff -> buff @ [AMP]
    2uy, fun buff -> buff
    ]
let tokenize (tokens: seq<FslexToken>) =
    tokens
    |> Seq.map(fun tok -> tok, FslexToken.index tok)
    |> BufferIterator
    |> LexicalIterator.ofBufferIterator
    |> anal.split
    |> Seq.map(fun (rule_id, buff) ->
        let action = actions.[rule_id]
        action buff
    )
