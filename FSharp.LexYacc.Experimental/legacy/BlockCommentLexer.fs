module FSharp.LexYacc.Experimental.BlockCommentLexer
open System
open FSharp.LexYacc
open FSharp.LexYacc.Experimental
let transitions: Set<DFATransition> = set [{source=0u;label=[-7,41;43,1048575];target=4u};{source=0u;label=[42,42];target=1u};{source=1u;label=[-7,40;42,1048575];target=3u};{source=1u;label=[41,41];target=2u}]
let flags: Map<uint32, Set<byte * DFAStateFlag>> = Map [1u,set [1uy,Look;2uy,Accept];2u,set [0uy,Accept];3u,set [1uy,Seen];4u,set [2uy,Accept]]
let lookbehinds: Map<byte, Set<DFATransition> * Set<uint32>> = Map [1uy,(set [{source=0u;label=[-7,40;42,1048575];target=1u}],set [1u])]
let anal = LexicalAnalyzer(transitions, flags, lookbehinds)
let actions : Map<byte, char list -> char list> = Map [
    0uy, fun buff -> buff
    1uy, fun buff -> buff
    2uy, fun buff -> buff
    ]