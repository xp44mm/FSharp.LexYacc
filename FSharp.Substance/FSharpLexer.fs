module FSharp.Substance.FSharpLexer
open System
open FSharp.Idioms
open FSharp.Idioms.Literal
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
open FSharp.Substance
let anal:Analyzer = {nextStates=Map [0u,set [[-7,9;11,12;14,31;33,33;36,38;43,43;47,47;63,64;92,92;94,94;126,127;65536,1048575],78u;[10,10],2u;[13,13],1u;[32,32],3u;[34,34],67u;[35,35],17u;[39,39],47u;[40,40],9u;[41,41],10u;[42,42],20u;[44,44],8u;[45,45],18u;[46,46],4u;[48,48],24u;[49,57],31u;[58,58],5u;[59,59],6u;[60,60],15u;[61,61],7u;[62,62],16u;[65,90;95,95;97,122;128,65535],77u;[91,91],13u;[93,93],14u;[96,96],71u;[123,123],11u;[124,124],22u;[125,125],12u];1u,set [[10,10],2u];2u,set [[32,32],2u];3u,set [[32,32],3u];13u,set [[124,124],21u];18u,set [[62,62],19u];22u,set [[93,93],23u];24u,set [[46,46],42u;[48,57],31u;[66,66;98,98],30u;[69,69;101,101],43u;[76,76],35u;[79,79;111,111],28u;[85,85],40u;[88,88;120,120],26u;[108,108],34u;[115,115],33u;[117,117],36u;[121,121],32u];25u,set [[48,57;65,70;97,102],25u;[76,76],35u;[85,85],40u;[108,108],34u;[115,115],33u;[117,117],36u;[121,121],32u];26u,set [[48,57;65,70;97,102],25u];27u,set [[48,55],27u;[76,76],35u;[85,85],40u;[108,108],34u;[115,115],33u;[117,117],36u;[121,121],32u];28u,set [[48,55],27u];29u,set [[48,49],29u;[76,76],35u;[85,85],40u;[108,108],34u;[115,115],33u;[117,117],36u;[121,121],32u];30u,set [[48,49],29u];31u,set [[46,46],42u;[48,57],31u;[69,69;101,101],43u;[76,76],35u;[85,85],40u;[108,108],34u;[115,115],33u;[117,117],36u;[121,121],32u];36u,set [[76,76],41u;[108,108],39u;[115,115],38u;[121,121],37u];40u,set [[76,76],41u];42u,set [[48,57],42u;[69,69;101,101],43u;[70,70;102,102],46u];43u,set [[43,43;45,45],44u;[48,57],45u];44u,set [[48,57],45u];45u,set [[48,57],45u;[70,70;102,102],46u];47u,set [[-7,38;40,64;91,91;93,94;96,96;123,1048575],65u;[65,90;95,95;97,122],48u;[92,92],50u];48u,set [[39,39],66u;[48,57;65,90;95,95;97,122],49u];49u,set [[48,57;65,90;95,95;97,122],49u];50u,set [[-7,116;118,119;121,1048575],51u;[117,117],53u;[120,120],52u];51u,set [[39,39],54u];52u,set [[-7,38;40,1048575],57u;[39,39],55u];53u,set [[-7,38;40,1048575],60u;[39,39],56u];55u,set [[-7,1048575],58u];56u,set [[-7,1048575],61u];57u,set [[-7,1048575],58u];58u,set [[39,39],59u];60u,set [[-7,1048575],61u];61u,set [[-7,1048575],62u];62u,set [[-7,1048575],63u];63u,set [[39,39],64u];65u,set [[39,39],66u];67u,set [[-7,33;35,91;93,1048575],68u;[34,34],70u;[92,92],69u];68u,set [[-7,33;35,91;93,1048575],68u;[34,34],70u;[92,92],69u];69u,set [[-7,1048575],68u];71u,set [[96,96],73u];72u,set [[-7,9;11,12;14,95;97,1048575],72u;[96,96],75u];73u,set [[-7,9;11,12;14,95;97,1048575],72u;[96,96],74u];74u,set [[-7,9;11,12;14,95;97,1048575],72u];75u,set [[-7,9;11,12;14,95;97,1048575],72u;[96,96],76u];77u,set [[39,39;48,57;65,90;95,95;97,122;128,65535],77u]];flags=Map [1u,set [40uy,Accept];2u,set [0uy,Accept];3u,set [1uy,Accept];4u,set [2uy,Accept];5u,set [3uy,Accept];6u,set [4uy,Accept];7u,set [5uy,Accept];8u,set [6uy,Accept];9u,set [7uy,Accept];10u,set [8uy,Accept];11u,set [9uy,Accept];12u,set [10uy,Accept];13u,set [11uy,Accept];14u,set [12uy,Accept];15u,set [13uy,Accept];16u,set [14uy,Accept];17u,set [15uy,Accept];18u,set [17uy,Accept];19u,set [16uy,Accept];20u,set [18uy,Accept];21u,set [19uy,Accept];22u,set [20uy,Accept];23u,set [21uy,Accept];24u,set [24uy,Accept];25u,set [24uy,Accept];27u,set [24uy,Accept];29u,set [24uy,Accept];31u,set [24uy,Accept];32u,set [22uy,Accept];33u,set [23uy,Accept];34u,set [24uy,Accept];35u,set [25uy,Accept];36u,set [28uy,Accept];37u,set [26uy,Accept];38u,set [27uy,Accept];39u,set [28uy,Accept];41u,set [29uy,Accept];42u,set [30uy,Accept];45u,set [30uy,Accept];46u,set [31uy,Accept];47u,set [40uy,Accept];48u,set [32uy,Accept];49u,set [32uy,Accept];54u,set [33uy,Accept];55u,set [33uy,Accept];56u,set [33uy,Accept];59u,set [34uy,Accept];64u,set [35uy,Accept];66u,set [36uy,Accept];67u,set [40uy,Accept];70u,set [37uy,Accept];71u,set [40uy,Accept];76u,set [38uy,Accept];77u,set [39uy,Accept];78u,set [40uy,Accept]];lookbehinds=Map []}
let actions : Map<byte,  char list -> FSharpToken list > = Map [
    0uy, fun buff -> 
        let len = buff |> List.skipWhile ((<>) ' ') |> List.length
        [NEW_LINE len]
    1uy, fun buff -> [WHITESPACE]
    2uy, fun buff -> [DOT]
    3uy, fun buff -> [COLON]
    4uy, fun buff -> [SEMICOLON]
    5uy, fun buff -> [EQUALS]
    6uy, fun buff -> [COMMA]
    7uy, fun buff -> [LPAREN]
    8uy, fun buff -> [RPAREN]
    9uy, fun buff -> [LBRACE]
    10uy, fun buff -> [RBRACE]
    11uy, fun buff -> [LBRACK]
    12uy, fun buff -> [RBRACK]
    13uy, fun buff -> [LESS]
    14uy, fun buff -> [GREATER]
    15uy, fun buff -> [HASH]
    16uy, fun buff -> [RARROW]
    17uy, fun buff -> [MINUS]
    18uy, fun buff -> [STAR]
    19uy, fun buff -> [LBRACK_BAR]
    20uy, fun buff -> [BAR]
    21uy, fun buff -> [BAR_RBRACK]
    22uy, fun buff -> [LITERAL(Literal.int8 buff)]
    23uy, fun buff -> [LITERAL(Literal.int16 buff)]
    24uy, fun buff -> [LITERAL(Literal.int32 buff)]
    25uy, fun buff -> [LITERAL(Literal.int64 buff)]
    26uy, fun buff -> [LITERAL(Literal.uint8 buff)]
    27uy, fun buff -> [LITERAL(Literal.uint16 buff)]
    28uy, fun buff -> [LITERAL(Literal.uint32 buff)]
    29uy, fun buff -> [LITERAL(Literal.uint64 buff)]
    30uy, fun buff -> [LITERAL(Literal.float buff)]
    31uy, fun buff -> [LITERAL(Literal.single buff)]
    32uy, fun buff -> [TYPAR(String.build buff)]
    33uy, fun buff -> [LITERAL(Literal.char buff)]
    34uy, fun buff -> [LITERAL(Literal.char buff)]
    35uy, fun buff -> [LITERAL(Literal.char buff)]
    36uy, fun buff -> [LITERAL(Literal.char buff)]
    37uy, fun buff -> [LITERAL(Literal.string buff)]
    38uy, fun buff -> [IDENT(String.build buff)]
    39uy, fun buff -> 
        let tok =
            match String.build buff with
            | "module" -> MODULE
            | "open" -> OPEN
            | "let" -> LET
            | "fun" -> FUN
            | "match" -> MATCH
            | "with" -> WITH
            | "true" -> LITERAL(Literal.TRUE)
            | "false" -> LITERAL(Literal.FALSE)
            | s -> IDENT s
        [tok]
    40uy, fun buff -> failwith(stringify buff.[0])
    ]