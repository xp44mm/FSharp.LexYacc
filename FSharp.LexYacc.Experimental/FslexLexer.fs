module FSharp.LexYacc.Bootstrap.FslexLexer
open System
open FSharp.Idioms
open FSharp.Idioms.Literal
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
let transitions: Set<DFATransition> = set [{source=0u;label=[-7,9;11,12;14,31;33,33;35,37;44,44;46,46;48,57;59,60;62,62;64,64;92,92;94,94;96,96;125,1048575];target=65u};{source=0u;label=[10,10;13,13;32,32];target=17u};{source=0u;label=[34,34];target=29u};{source=0u;label=[38,38];target=5u};{source=0u;label=[39,39];target=33u};{source=0u;label=[40,40];target=1u};{source=0u;label=[41,41];target=6u};{source=0u;label=[42,42];target=7u};{source=0u;label=[43,43];target=8u};{source=0u;label=[45,45];target=16u};{source=0u;label=[47,47];target=9u};{source=0u;label=[58,58];target=4u};{source=0u;label=[61,61];target=10u};{source=0u;label=[63,63];target=11u};{source=0u;label=[65,90];target=27u};{source=0u;label=[91,91];target=12u};{source=0u;label=[93,93];target=14u};{source=0u;label=[95,95];target=19u};{source=0u;label=[97,107;109,113;115,122];target=28u};{source=0u;label=[108,108];target=20u};{source=0u;label=[114,114];target=23u};{source=0u;label=[123,123];target=3u};{source=0u;label=[124,124];target=15u};{source=1u;label=[42,42];target=2u};{source=4u;label=[-7,60;62,1048575];target=4u};{source=9u;label=[47,47];target=18u};{source=12u;label=[94,94];target=13u};{source=17u;label=[10,10;13,13;32,32];target=17u};{source=18u;label=[-7,9;11,12;14,1048575];target=18u};{source=19u;label=[48,57;65,90;95,95;97,122];target=28u};{source=20u;label=[48,57;65,90;95,95;97,100;102,122];target=28u};{source=20u;label=[101,101];target=21u};{source=21u;label=[48,57;65,90;95,95;97,115;117,122];target=28u};{source=21u;label=[116,116];target=22u};{source=22u;label=[48,57;65,90;95,95;97,122];target=28u};{source=23u;label=[48,57;65,90;95,95;97,116;118,122];target=28u};{source=23u;label=[117,117];target=24u};{source=24u;label=[48,57;65,90;95,95;97,107;109,122];target=28u};{source=24u;label=[108,108];target=25u};{source=25u;label=[48,57;65,90;95,95;97,100;102,122];target=28u};{source=25u;label=[101,101];target=26u};{source=26u;label=[48,57;65,90;95,95;97,122];target=28u};{source=27u;label=[48,57;97,122];target=28u};{source=27u;label=[65,90;95,95];target=27u};{source=28u;label=[48,57;65,90;95,95;97,122];target=28u};{source=29u;label=[-7,33;35,91;93,1048575];target=30u};{source=29u;label=[34,34];target=32u};{source=29u;label=[92,92];target=31u};{source=30u;label=[-7,33;35,91;93,1048575];target=30u};{source=30u;label=[34,34];target=32u};{source=30u;label=[92,92];target=31u};{source=31u;label=[-7,1048575];target=30u};{source=33u;label=[-7,38;40,91;93,1048575];target=34u};{source=33u;label=[92,92];target=36u};{source=34u;label=[39,39];target=35u};{source=36u;label=[39,39];target=37u};{source=36u;label=[92,92];target=39u};{source=36u;label=[97,97];target=41u};{source=36u;label=[98,98];target=43u};{source=36u;label=[102,102];target=51u};{source=36u;label=[110,110];target=47u};{source=36u;label=[114,114];target=53u};{source=36u;label=[116,116];target=45u};{source=36u;label=[117,117];target=59u};{source=36u;label=[118,118];target=49u};{source=36u;label=[120,120];target=55u};{source=37u;label=[39,39];target=38u};{source=39u;label=[39,39];target=40u};{source=41u;label=[39,39];target=42u};{source=43u;label=[39,39];target=44u};{source=45u;label=[39,39];target=46u};{source=47u;label=[39,39];target=48u};{source=49u;label=[39,39];target=50u};{source=51u;label=[39,39];target=52u};{source=53u;label=[39,39];target=54u};{source=55u;label=[48,57;65,70;97,102];target=56u};{source=56u;label=[48,57;65,70;97,102];target=57u};{source=57u;label=[39,39];target=58u};{source=59u;label=[48,57;65,70;97,102];target=60u};{source=60u;label=[48,57;65,70;97,102];target=61u};{source=61u;label=[48,57;65,70;97,102];target=62u};{source=62u;label=[48,57;65,70;97,102];target=63u};{source=63u;label=[39,39];target=64u}]
let flags: Map<uint32, Set<byte * DFAStateFlag>> = Map [1u,set [4uy,Accept];2u,set [0uy,Accept];3u,set [1uy,Accept];4u,set [2uy,Accept];5u,set [3uy,Accept];6u,set [5uy,Accept];7u,set [6uy,Accept];8u,set [7uy,Accept];9u,set [8uy,Accept];10u,set [9uy,Accept];11u,set [10uy,Accept];12u,set [11uy,Accept];13u,set [12uy,Accept];14u,set [13uy,Accept];15u,set [14uy,Accept];16u,set [15uy,Accept];17u,set [16uy,Accept];18u,set [17uy,Accept];19u,set [18uy,Accept];20u,set [22uy,Accept];21u,set [22uy,Accept];22u,set [19uy,Accept];23u,set [22uy,Accept];24u,set [22uy,Accept];25u,set [22uy,Accept];26u,set [20uy,Accept];27u,set [21uy,Accept];28u,set [22uy,Accept];29u,set [36uy,Accept];32u,set [23uy,Accept];33u,set [36uy,Accept];35u,set [24uy,Accept];38u,set [25uy,Accept];40u,set [26uy,Accept];42u,set [27uy,Accept];44u,set [28uy,Accept];46u,set [29uy,Accept];48u,set [30uy,Accept];50u,set [31uy,Accept];52u,set [32uy,Accept];54u,set [33uy,Accept];58u,set [34uy,Accept];64u,set [35uy,Accept];65u,set [36uy,Accept]]
let lookbehinds: Map<byte, Set<DFATransition> * Set<uint32>> = Map []
let anal = LexicalAnalyzer(transitions, flags, lookbehinds)
let actions restBlockComment restBraces: Map<byte, char list -> FslexToken list> = Map [
    0uy, fun buff -> 
        let _ = restBlockComment()
        []
    1uy, fun buff -> 
        let rest = restBraces()
        [BRACES("{"+String.fromChars rest)]
    2uy, fun buff -> [COLON;FUN_TYPE(String.fromChars buff)]
    3uy, fun buff -> [AMP]
    4uy, fun buff -> [LPAREN]
    5uy, fun buff -> [RPAREN]
    6uy, fun buff -> [STAR]
    7uy, fun buff -> [PLUS]
    8uy, fun buff -> [SLASH]
    9uy, fun buff -> [EQUALS]
    10uy, fun buff -> [QMARK]
    11uy, fun buff -> [LBRACK]
    12uy, fun buff -> [LBRACK_CARET]
    13uy, fun buff -> [RBRACK]
    14uy, fun buff -> [BAR]
    15uy, fun buff -> [HYPHEN]
    16uy, fun buff -> []
    17uy, fun buff -> []
    18uy, fun buff -> [UNDERSCORE]
    19uy, fun buff -> [LET]
    20uy, fun buff -> [RULE]
    21uy, fun buff -> [QUOTE(String.fromChars buff)]
    22uy, fun buff -> [ID(String.fromChars buff)]
    23uy, fun buff -> [QUOTE(EscapeLexerTailer.unquote buff)]
    24uy, fun buff -> [APOSTROPHE buff.[1]]
    25uy, fun buff -> [APOSTROPHE '\'']
    26uy, fun buff -> [APOSTROPHE '\\']
    27uy, fun buff -> [APOSTROPHE '\a']
    28uy, fun buff -> [APOSTROPHE '\b']
    29uy, fun buff -> [APOSTROPHE '\t']
    30uy, fun buff -> [APOSTROPHE '\n']
    31uy, fun buff -> [APOSTROPHE '\v']
    32uy, fun buff -> [APOSTROPHE '\f']
    33uy, fun buff -> [APOSTROPHE '\r']
    34uy, fun buff -> [APOSTROPHE(buff |> List.skip 3 |> Hexadecimal.getChar 2)]
    35uy, fun buff -> [APOSTROPHE(buff |> List.skip 3 |> Hexadecimal.getChar 4)]
    36uy, fun buff -> failwith(stringify buff.[0])
    ]