module FSharp.LexYacc.FslexLexer
open System
open FSharp.LexYacc
open FSharp.Idioms
open FSharp.Idioms.Literal
let transitions: Set<DFATransition> = set [{source=0u;label=[-7,9;11,12;14,31;33,33;35,36;44,44;46,46;48,60;62,62;64,64;92,92;94,94;96,96;125,1048575];target=63u};{source=0u;label=[10,10;13,13;32,32];target=16u};{source=0u;label=[34,34];target=24u};{source=0u;label=[37,37];target=14u};{source=0u;label=[38,38];target=1u};{source=0u;label=[39,39];target=28u};{source=0u;label=[40,40];target=2u};{source=0u;label=[41,41];target=3u};{source=0u;label=[42,42];target=4u};{source=0u;label=[43,43];target=5u};{source=0u;label=[45,45];target=13u};{source=0u;label=[47,47];target=6u};{source=0u;label=[61,61];target=7u};{source=0u;label=[63,63];target=8u};{source=0u;label=[65,90];target=22u};{source=0u;label=[91,91];target=9u};{source=0u;label=[93,93];target=11u};{source=0u;label=[95,95];target=18u};{source=0u;label=[97,107;109,122];target=23u};{source=0u;label=[108,108];target=19u};{source=0u;label=[123,123];target=60u};{source=0u;label=[124,124];target=12u};{source=6u;label=[47,47];target=17u};{source=9u;label=[94,94];target=10u};{source=14u;label=[37,37];target=15u};{source=16u;label=[10,10;13,13;32,32];target=16u};{source=17u;label=[-7,9;11,12;14,1048575];target=17u};{source=18u;label=[48,57;65,90;95,95;97,122];target=23u};{source=19u;label=[48,57;65,90;95,95;97,100;102,122];target=23u};{source=19u;label=[101,101];target=20u};{source=20u;label=[48,57;65,90;95,95;97,115;117,122];target=23u};{source=20u;label=[116,116];target=21u};{source=21u;label=[48,57;65,90;95,95;97,122];target=23u};{source=22u;label=[48,57;97,122];target=23u};{source=22u;label=[65,90;95,95];target=22u};{source=23u;label=[48,57;65,90;95,95;97,122];target=23u};{source=24u;label=[-7,33;35,91;93,1048575];target=25u};{source=24u;label=[34,34];target=27u};{source=24u;label=[92,92];target=26u};{source=25u;label=[-7,33;35,91;93,1048575];target=25u};{source=25u;label=[34,34];target=27u};{source=25u;label=[92,92];target=26u};{source=26u;label=[-7,1048575];target=25u};{source=28u;label=[-7,38;40,91;93,1048575];target=29u};{source=28u;label=[92,92];target=31u};{source=29u;label=[39,39];target=30u};{source=31u;label=[39,39];target=32u};{source=31u;label=[92,92];target=34u};{source=31u;label=[97,97];target=36u};{source=31u;label=[98,98];target=38u};{source=31u;label=[102,102];target=46u};{source=31u;label=[110,110];target=42u};{source=31u;label=[114,114];target=48u};{source=31u;label=[116,116];target=40u};{source=31u;label=[117,117];target=54u};{source=31u;label=[118,118];target=44u};{source=31u;label=[120,120];target=50u};{source=32u;label=[39,39];target=33u};{source=34u;label=[39,39];target=35u};{source=36u;label=[39,39];target=37u};{source=38u;label=[39,39];target=39u};{source=40u;label=[39,39];target=41u};{source=42u;label=[39,39];target=43u};{source=44u;label=[39,39];target=45u};{source=46u;label=[39,39];target=47u};{source=48u;label=[39,39];target=49u};{source=50u;label=[48,57;65,70;97,102];target=51u};{source=51u;label=[48,57;65,70;97,102];target=52u};{source=52u;label=[39,39];target=53u};{source=54u;label=[48,57;65,70;97,102];target=55u};{source=55u;label=[48,57;65,70;97,102];target=56u};{source=56u;label=[48,57;65,70;97,102];target=57u};{source=57u;label=[48,57;65,70;97,102];target=58u};{source=58u;label=[39,39];target=59u};{source=60u;label=[-7,124;126,1048575];target=61u};{source=60u;label=[125,125];target=62u};{source=61u;label=[-7,124;126,1048575];target=61u};{source=61u;label=[125,125];target=62u}]
let flags: Map<uint32, Set<byte * DFAStateFlag>> = Map [1u,set [0uy,Accept];2u,set [1uy,Accept];3u,set [2uy,Accept];4u,set [3uy,Accept];5u,set [4uy,Accept];6u,set [5uy,Accept];7u,set [6uy,Accept];8u,set [7uy,Accept];9u,set [8uy,Accept];10u,set [9uy,Accept];11u,set [10uy,Accept];12u,set [11uy,Accept];13u,set [12uy,Accept];14u,set [34uy,Accept];15u,set [13uy,Accept];16u,set [14uy,Accept];17u,set [15uy,Accept];18u,set [16uy,Accept];19u,set [19uy,Accept];20u,set [19uy,Accept];21u,set [17uy,Accept];22u,set [18uy,Accept];23u,set [19uy,Accept];24u,set [34uy,Accept];27u,set [20uy,Accept];28u,set [34uy,Accept];30u,set [21uy,Accept];33u,set [22uy,Accept];35u,set [23uy,Accept];37u,set [24uy,Accept];39u,set [25uy,Accept];41u,set [26uy,Accept];43u,set [27uy,Accept];45u,set [28uy,Accept];47u,set [29uy,Accept];49u,set [30uy,Accept];53u,set [31uy,Accept];59u,set [32uy,Accept];60u,set [34uy,Accept];62u,set [33uy,Accept];63u,set [34uy,Accept]]
let lookbehinds: Map<byte, Set<DFATransition> * Set<uint32>> = Map []

let actions: Map<byte, char list -> _> = Map [
    0uy, fun buff -> [AMP]
    1uy, fun buff -> [LPAREN]
    2uy, fun buff -> [RPAREN]
    3uy, fun buff -> [STAR]
    4uy, fun buff -> [PLUS]
    5uy, fun buff -> [SLASH]
    6uy, fun buff -> [EQUALS]
    7uy, fun buff -> [QMARK]
    8uy, fun buff -> [LBRACK]
    9uy, fun buff -> [LBRACK_CARET]
    10uy, fun buff -> [RBRACK]
    11uy, fun buff -> [BAR]
    12uy, fun buff -> [HYPHEN]
    13uy, fun buff -> [PERCENT]
    14uy, fun buff -> []
    15uy, fun buff -> []
    16uy, fun buff -> [UNDERSCORE]
    17uy, fun buff -> [LET]
    18uy, fun buff -> [QUOTE(String.fromChars buff)]
    19uy, fun buff -> [ID(String.fromChars buff)]
    20uy, fun buff -> [QUOTE(EscapeLexerTailer.unquote buff)]
    21uy, fun buff -> [APOSTROPHE buff.[1]]
    22uy, fun buff -> [APOSTROPHE '\'']
    23uy, fun buff -> [APOSTROPHE '\\']
    24uy, fun buff -> [APOSTROPHE '\a']
    25uy, fun buff -> [APOSTROPHE '\b']
    26uy, fun buff -> [APOSTROPHE '\t']
    27uy, fun buff -> [APOSTROPHE '\n']
    28uy, fun buff -> [APOSTROPHE '\v']
    29uy, fun buff -> [APOSTROPHE '\f']
    30uy, fun buff -> [APOSTROPHE '\r']
    31uy, fun buff -> [APOSTROPHE(buff |> List.skip 3 |> Hexadecimal.getChar 2)]
    32uy, fun buff -> [APOSTROPHE(buff |> List.skip 3 |> Hexadecimal.getChar 4)]
    33uy, fun buff -> [BRACES(String.fromChars buff)]
    34uy, fun buff -> failwith(stringify buff.[0])
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
