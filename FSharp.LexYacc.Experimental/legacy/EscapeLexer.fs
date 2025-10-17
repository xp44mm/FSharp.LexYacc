module FSharp.LexYacc.Experimental.EscapeLexer
open System
open FSharp.LexYacc
open FSharp.LexYacc.Experimental
let transitions: Set<DFATransition> = set [{source=0u;label=[-7,91;93,1048575];target=19u};{source=0u;label=[92,92];target=1u};{source=1u;label=[34,34];target=11u};{source=1u;label=[92,92];target=2u};{source=1u;label=[97,97];target=12u};{source=1u;label=[98,98];target=13u};{source=1u;label=[102,102];target=17u};{source=1u;label=[110,110];target=15u};{source=1u;label=[114,114];target=18u};{source=1u;label=[116,116];target=14u};{source=1u;label=[117,117];target=3u};{source=1u;label=[118,118];target=16u};{source=1u;label=[120,120];target=8u};{source=3u;label=[48,57;65,70;97,102];target=4u};{source=4u;label=[48,57;65,70;97,102];target=5u};{source=5u;label=[48,57;65,70;97,102];target=6u};{source=6u;label=[48,57;65,70;97,102];target=7u};{source=8u;label=[48,57;65,70;97,102];target=9u};{source=9u;label=[48,57;65,70;97,102];target=10u}]
let flags: Map<uint32, Set<byte * DFAStateFlag>> = Map [1u,set [11uy,Accept];2u,set [0uy,Accept];7u,set [1uy,Accept];10u,set [2uy,Accept];11u,set [3uy,Accept];12u,set [4uy,Accept];13u,set [5uy,Accept];14u,set [6uy,Accept];15u,set [7uy,Accept];16u,set [8uy,Accept];17u,set [9uy,Accept];18u,set [10uy,Accept];19u,set [11uy,Accept]]
let lookbehinds: Map<byte, Set<DFATransition> * Set<uint32>> = Map []
let anal = LexicalAnalyzer(transitions, flags, lookbehinds)
let actions : Map<byte, char list -> char> = Map [
    0uy, fun buff -> '\\'
    1uy, fun buff -> buff |> List.skip 2 |> Hexadecimal.getChar 4
    2uy, fun buff -> buff |> List.skip 2 |> Hexadecimal.getChar 2
    3uy, fun buff -> '"'
    4uy, fun buff -> '\a'
    5uy, fun buff -> '\b'
    6uy, fun buff -> '\t'
    7uy, fun buff -> '\n'
    8uy, fun buff -> '\v'
    9uy, fun buff -> '\f'
    10uy, fun buff -> '\r'
    11uy, fun buff -> buff.[0]
    ]