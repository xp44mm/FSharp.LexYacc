module FSharp.LexYacc.FsyaccLexer
open System
open FSharp.LexYacc
open FSharp.Idioms
open FSharp.Idioms.Literal
let transitions: Set<DFATransition> = set [{source=0u;label=[-7,9;11,12;14,31;33,33;35,36;38,39;41,46;48,57;59,64;91,94;96,96;125,1048575];target=46u};{source=0u;label=[10,10;13,13;32,32];target=1u};{source=0u;label=[34,34];target=39u};{source=0u;label=[37,37];target=11u};{source=0u;label=[40,40];target=4u};{source=0u;label=[47,47];target=2u};{source=0u;label=[58,58];target=44u};{source=0u;label=[65,90;95,95;97,122];target=43u};{source=0u;label=[123,123];target=8u};{source=0u;label=[124,124];target=45u};{source=1u;label=[10,10;13,13;32,32];target=1u};{source=2u;label=[47,47];target=3u};{source=3u;label=[-7,9;11,12;14,1048575];target=3u};{source=4u;label=[42,42];target=5u};{source=5u;label=[-7,41;43,1048575];target=5u};{source=5u;label=[42,42];target=6u};{source=6u;label=[41,41];target=7u};{source=8u;label=[-7,124;126,1048575];target=9u};{source=8u;label=[125,125];target=10u};{source=9u;label=[-7,124;126,1048575];target=9u};{source=9u;label=[125,125];target=10u};{source=11u;label=[108,108];target=18u};{source=11u;label=[110,110];target=27u};{source=11u;label=[112,112];target=35u};{source=11u;label=[114,114];target=22u};{source=11u;label=[116,116];target=12u};{source=12u;label=[121,121];target=13u};{source=13u;label=[112,112];target=14u};{source=14u;label=[101,101];target=15u};{source=15u;label=[60,60];target=16u};{source=16u;label=[-7,9;11,12;14,61;63,1048575];target=16u};{source=16u;label=[62,62];target=17u};{source=17u;label=[-7,9;11,12;14,61;63,1048575];target=16u};{source=17u;label=[62,62];target=17u};{source=18u;label=[101,101];target=19u};{source=19u;label=[102,102];target=20u};{source=20u;label=[116,116];target=21u};{source=22u;label=[105,105];target=23u};{source=23u;label=[103,103];target=24u};{source=24u;label=[104,104];target=25u};{source=25u;label=[116,116];target=26u};{source=27u;label=[111,111];target=28u};{source=28u;label=[110,110];target=29u};{source=29u;label=[97,97];target=30u};{source=30u;label=[115,115];target=31u};{source=31u;label=[115,115];target=32u};{source=32u;label=[111,111];target=33u};{source=33u;label=[99,99];target=34u};{source=35u;label=[114,114];target=36u};{source=36u;label=[101,101];target=37u};{source=37u;label=[99,99];target=38u};{source=39u;label=[-7,33;35,91;93,1048575];target=40u};{source=39u;label=[34,34];target=42u};{source=39u;label=[92,92];target=41u};{source=40u;label=[-7,33;35,91;93,1048575];target=40u};{source=40u;label=[34,34];target=42u};{source=40u;label=[92,92];target=41u};{source=41u;label=[-7,1048575];target=40u};{source=43u;label=[48,57;65,90;95,95;97,122];target=43u}]
let flags: Map<uint32, Set<byte * DFAStateFlag>> = Map [1u,set [0uy,Accept];2u,set [13uy,Accept];3u,set [1uy,Accept];4u,set [13uy,Accept];7u,set [2uy,Accept];8u,set [13uy,Accept];10u,set [3uy,Accept];11u,set [13uy,Accept];17u,set [4uy,Accept];21u,set [5uy,Accept];26u,set [6uy,Accept];34u,set [7uy,Accept];38u,set [8uy,Accept];39u,set [13uy,Accept];42u,set [9uy,Accept];43u,set [10uy,Accept];44u,set [11uy,Accept];45u,set [12uy,Accept];46u,set [13uy,Accept]]
let lookbehinds: Map<byte, Set<DFATransition> * Set<uint32>> = Map []
let actions: Map<byte, char list -> _> = Map [
    0uy, fun buff -> []
    1uy, fun buff -> []
    2uy, fun buff -> []
    3uy, fun buff -> [FsyaccToken.BRACES(String.fromChars buff)]
    4uy, fun buff -> [FsyaccToken.PERCENT_TYPE(String.fromChars buff)]
    5uy, fun buff -> [FsyaccToken.LEFTASSOC]
    6uy, fun buff -> [FsyaccToken.RIGHTASSOC]
    7uy, fun buff -> [FsyaccToken.NONASSOC]
    8uy, fun buff -> [FsyaccToken.PREC]
    9uy, fun buff -> [FsyaccToken.QUOTE(EscapeLexerTailer.unquote buff)]
    10uy, fun buff -> [FsyaccToken.ID(String.fromChars buff)]
    11uy, fun buff -> [FsyaccToken.COLON]
    12uy, fun buff -> [FsyaccToken.BAR]
    13uy, fun buff -> failwith(stringify buff.[0])
    ]
let anal = LexicalAnalyzer(transitions, flags, lookbehinds)
let tokenize (input: string) =
    input.ToCharArray()
    |> Array.map(fun ch -> ch, int ch)
    |> ArrayStack
    |> LexicalIterator.ofArrayStack
    |> anal.split
    |> Seq.map(fun (rule_id, buff) ->
        let action = actions.[rule_id]
        action buff
    )