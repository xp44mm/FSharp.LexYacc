module FSharp.LexYacc.Experimental.FsyaccLexer
open System
open FSharp.Idioms
open FSharp.Idioms.Literal
open FSharp.LexYacc
open FSharp.LexYacc.Experimental
let transitions: Set<DFATransition> = set [{source=0u;label=[-7,9;11,12;14,31;33,33;35,36;38,39;41,46;48,57;59,64;91,94;96,96;125,1048575];target=42u};{source=0u;label=[10,10;13,13;32,32];target=4u};{source=0u;label=[34,34];target=37u};{source=0u;label=[37,37];target=9u};{source=0u;label=[40,40];target=1u};{source=0u;label=[47,47];target=7u};{source=0u;label=[58,58];target=5u};{source=0u;label=[65,90;95,95;97,122];target=41u};{source=0u;label=[123,123];target=3u};{source=0u;label=[124,124];target=6u};{source=1u;label=[42,42];target=2u};{source=4u;label=[10,10;13,13;32,32];target=4u};{source=7u;label=[47,47];target=8u};{source=8u;label=[-7,9;11,12;14,1048575];target=8u};{source=9u;label=[108,108];target=16u};{source=9u;label=[110,110];target=25u};{source=9u;label=[112,112];target=33u};{source=9u;label=[114,114];target=20u};{source=9u;label=[116,116];target=10u};{source=10u;label=[121,121];target=11u};{source=11u;label=[112,112];target=12u};{source=12u;label=[101,101];target=13u};{source=13u;label=[60,60];target=14u};{source=14u;label=[-7,9;11,12;14,61;63,1048575];target=14u};{source=14u;label=[62,62];target=15u};{source=15u;label=[-7,9;11,12;14,61;63,1048575];target=14u};{source=15u;label=[62,62];target=15u};{source=16u;label=[101,101];target=17u};{source=17u;label=[102,102];target=18u};{source=18u;label=[116,116];target=19u};{source=20u;label=[105,105];target=21u};{source=21u;label=[103,103];target=22u};{source=22u;label=[104,104];target=23u};{source=23u;label=[116,116];target=24u};{source=25u;label=[111,111];target=26u};{source=26u;label=[110,110];target=27u};{source=27u;label=[97,97];target=28u};{source=28u;label=[115,115];target=29u};{source=29u;label=[115,115];target=30u};{source=30u;label=[111,111];target=31u};{source=31u;label=[99,99];target=32u};{source=33u;label=[114,114];target=34u};{source=34u;label=[101,101];target=35u};{source=35u;label=[99,99];target=36u};{source=37u;label=[-7,33;35,91;93,1048575];target=38u};{source=37u;label=[34,34];target=40u};{source=37u;label=[92,92];target=39u};{source=38u;label=[-7,33;35,91;93,1048575];target=38u};{source=38u;label=[34,34];target=40u};{source=38u;label=[92,92];target=39u};{source=39u;label=[-7,1048575];target=38u};{source=41u;label=[48,57;65,90;95,95;97,122];target=41u}]
let flags: Map<uint32, Set<byte * DFAStateFlag>> = Map [1u,set [13uy,Accept];2u,set [0uy,Accept];3u,set [1uy,Accept];4u,set [2uy,Accept];5u,set [3uy,Accept];6u,set [4uy,Accept];7u,set [13uy,Accept];8u,set [5uy,Accept];9u,set [13uy,Accept];15u,set [6uy,Accept];19u,set [7uy,Accept];24u,set [8uy,Accept];32u,set [9uy,Accept];36u,set [10uy,Accept];37u,set [13uy,Accept];40u,set [11uy,Accept];41u,set [12uy,Accept];42u,set [13uy,Accept]]
let lookbehinds: Map<byte, Set<DFATransition> * Set<uint32>> = Map []
let anal = LexicalAnalyzer(transitions, flags, lookbehinds)
let actions restBlockComment restBraces: Map<byte, char list -> FsyaccToken list> = Map [
    0uy, fun buff -> 
        let _ = restBlockComment()
        []
    1uy, fun buff -> 
        let rest = restBraces()
        [FsyaccToken.BRACES("{"+String.fromChars rest)]
    2uy, fun buff -> []
    3uy, fun buff -> [FsyaccToken.COLON]
    4uy, fun buff -> [FsyaccToken.BAR]
    5uy, fun buff -> []
    6uy, fun buff -> [FsyaccToken.PERCENT_TYPE(String.fromChars buff)]
    7uy, fun buff -> [FsyaccToken.LEFTASSOC]
    8uy, fun buff -> [FsyaccToken.RIGHTASSOC]
    9uy, fun buff -> [FsyaccToken.NONASSOC]
    10uy, fun buff -> [FsyaccToken.PREC]
    11uy, fun buff -> [FsyaccToken.QUOTE(EscapeLexerTailer.unquote buff)]
    12uy, fun buff -> [FsyaccToken.ID(String.fromChars buff)]
    13uy, fun buff -> failwith(stringify buff.[0])
    ]