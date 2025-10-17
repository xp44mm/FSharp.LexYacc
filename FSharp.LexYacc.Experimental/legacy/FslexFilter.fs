module FSharp.LexYacc.Experimental.FslexFilter
open System
open FSharp.LexYacc
open FSharp.LexYacc.Experimental
let transitions: Set<DFATransition> = set [{source=0u;label=[-7,0;2,6;10,11;18,18;21,1048575];target=9u};{source=0u;label=[1,1;7,7;12,16;19,20];target=7u};{source=0u;label=[8,9];target=4u};{source=0u;label=[17,17];target=1u};{source=1u;label=[-7,4;6,1048575];target=2u};{source=1u;label=[5,5];target=3u};{source=2u;label=[-7,4;6,1048575];target=2u};{source=2u;label=[5,5];target=3u};{source=4u;label=[-7,14;16,1048575];target=5u};{source=4u;label=[15,15];target=6u};{source=5u;label=[-7,14;16,1048575];target=5u};{source=5u;label=[15,15];target=6u};{source=7u;label=[1,1;7,9;11,11;14,14;20,20];target=8u}]
let flags: Map<uint32, Set<byte * DFAStateFlag>> = Map [1u,set [3uy,Accept];3u,set [0uy,Accept];4u,set [1uy,Look;3uy,Accept];5u,set [1uy,Look];6u,set [1uy,Seen];7u,set [2uy,Look;3uy,Accept];8u,set [2uy,Seen];9u,set [3uy,Accept]]
let lookbehinds: Map<byte, Set<DFATransition> * Set<uint32>> = Map [1uy,(set [{source=0u;label=[15,15];target=1u}],set [1u]);2uy,(set [{source=0u;label=[1,1;7,9;11,11;14,14;20,20];target=1u}],set [1u])]
let anal = LexicalAnalyzer(transitions, flags, lookbehinds)
let actions : Map<byte, FslexToken list -> FslexToken list> = Map [
    0uy, fun buff -> buff
    1uy, fun buff -> buff
    2uy, fun buff -> buff @ [AMP]
    3uy, fun buff -> buff
    ]
