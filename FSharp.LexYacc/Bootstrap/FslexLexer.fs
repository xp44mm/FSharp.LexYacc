module FSharp.LexYacc.Bootstrap.FslexLexer
open System
open FSharp.Idioms
open FSharp.Idioms.Literal
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
let anal:Analyzer = {nextStates=Map [0u,set [[-7,9;11,12;14,31;33,33;35,37;44,44;46,46;48,57;59,60;62,62;64,64;92,92;94,94;96,96;125,1048575],65u;[10,10;13,13;32,32],17u;[34,34],29u;[38,38],5u;[39,39],33u;[40,40],1u;[41,41],6u;[42,42],7u;[43,43],8u;[45,45],16u;[47,47],9u;[58,58],4u;[61,61],10u;[63,63],11u;[65,90],27u;[91,91],12u;[93,93],14u;[95,95],19u;[97,107;109,113;115,122],28u;[108,108],20u;[114,114],23u;[123,123],3u;[124,124],15u];1u,set [[42,42],2u];4u,set [[-7,60;62,1048575],4u];9u,set [[47,47],18u];12u,set [[94,94],13u];17u,set [[10,10;13,13;32,32],17u];18u,set [[-7,9;11,12;14,1048575],18u];19u,set [[48,57;65,90;95,95;97,122],28u];20u,set [[48,57;65,90;95,95;97,100;102,122],28u;[101,101],21u];21u,set [[48,57;65,90;95,95;97,115;117,122],28u;[116,116],22u];22u,set [[48,57;65,90;95,95;97,122],28u];23u,set [[48,57;65,90;95,95;97,116;118,122],28u;[117,117],24u];24u,set [[48,57;65,90;95,95;97,107;109,122],28u;[108,108],25u];25u,set [[48,57;65,90;95,95;97,100;102,122],28u;[101,101],26u];26u,set [[48,57;65,90;95,95;97,122],28u];27u,set [[48,57;97,122],28u;[65,90;95,95],27u];28u,set [[48,57;65,90;95,95;97,122],28u];29u,set [[-7,33;35,91;93,1048575],30u;[34,34],32u;[92,92],31u];30u,set [[-7,33;35,91;93,1048575],30u;[34,34],32u;[92,92],31u];31u,set [[-7,1048575],30u];33u,set [[-7,38;40,91;93,1048575],34u;[92,92],36u];34u,set [[39,39],35u];36u,set [[39,39],37u;[92,92],39u;[97,97],41u;[98,98],43u;[102,102],51u;[110,110],47u;[114,114],53u;[116,116],45u;[117,117],59u;[118,118],49u;[120,120],55u];37u,set [[39,39],38u];39u,set [[39,39],40u];41u,set [[39,39],42u];43u,set [[39,39],44u];45u,set [[39,39],46u];47u,set [[39,39],48u];49u,set [[39,39],50u];51u,set [[39,39],52u];53u,set [[39,39],54u];55u,set [[48,57;65,70;97,102],56u];56u,set [[48,57;65,70;97,102],57u];57u,set [[39,39],58u];59u,set [[48,57;65,70;97,102],60u];60u,set [[48,57;65,70;97,102],61u];61u,set [[48,57;65,70;97,102],62u];62u,set [[48,57;65,70;97,102],63u];63u,set [[39,39],64u]];flags=Map [1u,set [4uy,Accept];2u,set [0uy,Accept];3u,set [1uy,Accept];4u,set [2uy,Accept];5u,set [3uy,Accept];6u,set [5uy,Accept];7u,set [6uy,Accept];8u,set [7uy,Accept];9u,set [8uy,Accept];10u,set [9uy,Accept];11u,set [10uy,Accept];12u,set [11uy,Accept];13u,set [12uy,Accept];14u,set [13uy,Accept];15u,set [14uy,Accept];16u,set [15uy,Accept];17u,set [16uy,Accept];18u,set [17uy,Accept];19u,set [18uy,Accept];20u,set [22uy,Accept];21u,set [22uy,Accept];22u,set [19uy,Accept];23u,set [22uy,Accept];24u,set [22uy,Accept];25u,set [22uy,Accept];26u,set [20uy,Accept];27u,set [21uy,Accept];28u,set [22uy,Accept];29u,set [36uy,Accept];32u,set [23uy,Accept];33u,set [36uy,Accept];35u,set [24uy,Accept];38u,set [25uy,Accept];40u,set [26uy,Accept];42u,set [27uy,Accept];44u,set [28uy,Accept];46u,set [29uy,Accept];48u,set [30uy,Accept];50u,set [31uy,Accept];52u,set [32uy,Accept];54u,set [33uy,Accept];58u,set [34uy,Accept];64u,set [35uy,Accept];65u,set [36uy,Accept]];lookbehinds=Map []}
let actions restBlockComment restBraces: Map<byte,  char list -> FslexToken list > = Map [
    0uy, fun buff -> 
        let _ = restBlockComment()
        []
    1uy, fun buff -> 
        let rest = restBraces()
        [BRACES("{"+String.fromChars rest)]
    2uy, fun buff -> [COLON;FUN_TYPE(String.fromChars buff.Tail)]
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
    34uy, fun buff -> 
        let i =
            buff
            |> List.skip 3
            |> Hexadecimal.getValueN 2
            |> fst
        [ APOSTROPHE(char i) ]
    35uy, fun buff -> 
        let i =
            buff
            |> List.skip 3
            |> Hexadecimal.getValueN 4
            |> fst
        [ APOSTROPHE(char i) ]
    36uy, fun buff -> failwith(stringify buff.[0])
    ]