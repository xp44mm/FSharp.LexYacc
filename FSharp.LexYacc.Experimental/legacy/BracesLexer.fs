module FSharp.LexYacc.Experimental.BracesLexer
open System
open FSharp.LexYacc
open FSharp.LexYacc.Experimental
let transitions: Set<DFATransition> = set [{source=0u;label=[-7,33;35,38;41,46;48,95;97,122;124,124;126,1048575];target=20u};{source=0u;label=[34,34];target=14u};{source=0u;label=[39,39];target=11u};{source=0u;label=[40,40];target=3u};{source=0u;label=[47,47];target=1u};{source=0u;label=[96,96];target=5u};{source=0u;label=[123,123];target=18u};{source=0u;label=[125,125];target=19u};{source=1u;label=[47,47];target=2u};{source=2u;label=[-7,9;11,12;14,1048575];target=2u};{source=3u;label=[42,42];target=4u};{source=5u;label=[96,96];target=7u};{source=6u;label=[-7,95;97,1048575];target=6u};{source=6u;label=[96,96];target=9u};{source=7u;label=[-7,95;97,1048575];target=6u};{source=7u;label=[96,96];target=8u};{source=8u;label=[-7,95;97,1048575];target=6u};{source=9u;label=[-7,95;97,1048575];target=6u};{source=9u;label=[96,96];target=10u};{source=11u;label=[123,123;125,125];target=12u};{source=12u;label=[39,39];target=13u};{source=14u;label=[-7,33;35,91;93,1048575];target=15u};{source=14u;label=[34,34];target=17u};{source=14u;label=[92,92];target=16u};{source=15u;label=[-7,33;35,91;93,1048575];target=15u};{source=15u;label=[34,34];target=17u};{source=15u;label=[92,92];target=16u};{source=16u;label=[-7,1048575];target=15u}]
let flags: Map<uint32, Set<byte * DFAStateFlag>> = Map [1u,set [7uy,Accept];2u,set [0uy,Accept];3u,set [7uy,Accept];4u,set [1uy,Accept];5u,set [7uy,Accept];10u,set [2uy,Accept];11u,set [7uy,Accept];13u,set [3uy,Accept];14u,set [7uy,Accept];17u,set [4uy,Accept];18u,set [5uy,Accept];19u,set [6uy,Accept];20u,set [7uy,Accept]]
let lookbehinds: Map<byte, Set<DFATransition> * Set<uint32>> = Map []
let anal = LexicalAnalyzer(transitions, flags, lookbehinds)
let actions restBlockComment: Map<byte, char list -> BracesToken> = Map [
    0uy, fun buff -> BUFF buff
    1uy, fun buff -> 
        let rest = restBlockComment()
        BUFF [ yield! buff; yield! rest ]
    2uy, fun buff -> BUFF buff
    3uy, fun buff -> BUFF buff
    4uy, fun buff -> BUFF buff
    5uy, fun buff -> LBRACE
    6uy, fun buff -> RBRACE
    7uy, fun buff -> BUFF buff
    ]