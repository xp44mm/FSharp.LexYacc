module FSharp.Substance.FSharpLexer
open System
open FSharp.Idioms
open FSharp.Idioms.Literal
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
open FSharp.Substance
let anal:Analyzer = {nextStates=Map [0u,set [[-7,9;11,12;14,31;36,36;63,63;92,92;94,94;126,127;65536,1048575],102u;[10,10],2u;[13,13],1u;[32,32],3u;[33,33],4u;[34,34],91u;[35,35],5u;[37,37],6u;[38,38],7u;[39,39],71u;[40,40],8u;[41,41],9u;[42,42],10u;[43,43],11u;[44,44],12u;[45,45],13u;[46,46],14u;[47,47],15u;[48,48],48u;[49,57],55u;[58,58],16u;[59,59],17u;[60,60],18u;[61,61],19u;[62,62],20u;[64,64],21u;[65,90;95,95;97,122;128,65535],101u;[91,91],22u;[93,93],23u;[96,96],95u;[123,123],24u;[124,124],25u;[125,125],26u];1u,set [[10,10],2u];2u,set [[32,32],2u];3u,set [[32,32],3u];7u,set [[38,38],27u];8u,set [[124,124],28u];10u,set [[42,42],29u];13u,set [[62,62],30u];14u,set [[46,46],31u];16u,set [[58,58],32u;[63,63],33u];18u,set [[45,45],35u;[62,62],36u;[124,124],37u];22u,set [[124,124],40u];25u,set [[41,41],41u;[62,62],42u;[93,93],43u;[124,124],44u];33u,set [[62,62],34u];37u,set [[124,124],38u];38u,set [[124,124],39u];44u,set [[62,62],45u;[124,124],46u];46u,set [[62,62],47u];48u,set [[46,46],66u;[48,57],55u;[66,66;98,98],54u;[69,69;101,101],67u;[76,76],59u;[79,79;111,111],52u;[85,85],64u;[88,88;120,120],50u;[108,108],58u;[115,115],57u;[117,117],60u;[121,121],56u];49u,set [[48,57;65,70;97,102],49u;[76,76],59u;[85,85],64u;[108,108],58u;[115,115],57u;[117,117],60u;[121,121],56u];50u,set [[48,57;65,70;97,102],49u];51u,set [[48,55],51u;[76,76],59u;[85,85],64u;[108,108],58u;[115,115],57u;[117,117],60u;[121,121],56u];52u,set [[48,55],51u];53u,set [[48,49],53u;[76,76],59u;[85,85],64u;[108,108],58u;[115,115],57u;[117,117],60u;[121,121],56u];54u,set [[48,49],53u];55u,set [[46,46],66u;[48,57],55u;[69,69;101,101],67u;[76,76],59u;[85,85],64u;[108,108],58u;[115,115],57u;[117,117],60u;[121,121],56u];60u,set [[76,76],65u;[108,108],63u;[115,115],62u;[121,121],61u];64u,set [[76,76],65u];66u,set [[48,57],66u;[69,69;101,101],67u;[70,70;102,102],70u];67u,set [[43,43;45,45],68u;[48,57],69u];68u,set [[48,57],69u];69u,set [[48,57],69u;[70,70;102,102],70u];71u,set [[-7,38;40,64;91,91;93,94;96,96;123,1048575],89u;[65,90;95,95;97,122],72u;[92,92],74u];72u,set [[39,39],90u;[48,57;65,90;95,95;97,122],73u];73u,set [[48,57;65,90;95,95;97,122],73u];74u,set [[-7,116;118,119;121,1048575],75u;[117,117],77u;[120,120],76u];75u,set [[39,39],78u];76u,set [[-7,38;40,1048575],81u;[39,39],79u];77u,set [[-7,38;40,1048575],84u;[39,39],80u];79u,set [[-7,1048575],82u];80u,set [[-7,1048575],85u];81u,set [[-7,1048575],82u];82u,set [[39,39],83u];84u,set [[-7,1048575],85u];85u,set [[-7,1048575],86u];86u,set [[-7,1048575],87u];87u,set [[39,39],88u];89u,set [[39,39],90u];91u,set [[-7,33;35,91;93,1048575],92u;[34,34],94u;[92,92],93u];92u,set [[-7,33;35,91;93,1048575],92u;[34,34],94u;[92,92],93u];93u,set [[-7,1048575],92u];95u,set [[96,96],97u];96u,set [[-7,9;11,12;14,95;97,1048575],96u;[96,96],99u];97u,set [[-7,9;11,12;14,95;97,1048575],96u;[96,96],98u];98u,set [[-7,9;11,12;14,95;97,1048575],96u];99u,set [[-7,9;11,12;14,95;97,1048575],96u;[96,96],100u];101u,set [[39,39;48,57;65,90;95,95;97,122;128,65535],101u]];flags=Map [1u,set [63uy,Accept];2u,set [0uy,Accept];3u,set [1uy,Accept];4u,set [2uy,Accept];5u,set [3uy,Accept];6u,set [4uy,Accept];7u,set [5uy,Accept];8u,set [6uy,Accept];9u,set [7uy,Accept];10u,set [8uy,Accept];11u,set [9uy,Accept];12u,set [10uy,Accept];13u,set [11uy,Accept];14u,set [12uy,Accept];15u,set [13uy,Accept];16u,set [14uy,Accept];17u,set [15uy,Accept];18u,set [16uy,Accept];19u,set [17uy,Accept];20u,set [18uy,Accept];21u,set [19uy,Accept];22u,set [20uy,Accept];23u,set [21uy,Accept];24u,set [22uy,Accept];25u,set [23uy,Accept];26u,set [24uy,Accept];27u,set [25uy,Accept];28u,set [26uy,Accept];29u,set [27uy,Accept];30u,set [28uy,Accept];31u,set [29uy,Accept];32u,set [30uy,Accept];33u,set [32uy,Accept];34u,set [31uy,Accept];35u,set [33uy,Accept];36u,set [34uy,Accept];37u,set [37uy,Accept];38u,set [36uy,Accept];39u,set [35uy,Accept];40u,set [38uy,Accept];41u,set [39uy,Accept];42u,set [40uy,Accept];43u,set [41uy,Accept];44u,set [44uy,Accept];45u,set [42uy,Accept];47u,set [43uy,Accept];48u,set [47uy,Accept];49u,set [47uy,Accept];51u,set [47uy,Accept];53u,set [47uy,Accept];55u,set [47uy,Accept];56u,set [45uy,Accept];57u,set [46uy,Accept];58u,set [47uy,Accept];59u,set [48uy,Accept];60u,set [51uy,Accept];61u,set [49uy,Accept];62u,set [50uy,Accept];63u,set [51uy,Accept];65u,set [52uy,Accept];66u,set [53uy,Accept];69u,set [53uy,Accept];70u,set [54uy,Accept];71u,set [63uy,Accept];72u,set [55uy,Accept];73u,set [55uy,Accept];78u,set [56uy,Accept];79u,set [56uy,Accept];80u,set [56uy,Accept];83u,set [57uy,Accept];88u,set [58uy,Accept];90u,set [59uy,Accept];91u,set [63uy,Accept];94u,set [60uy,Accept];95u,set [63uy,Accept];100u,set [61uy,Accept];101u,set [62uy,Accept];102u,set [63uy,Accept]];lookbehinds=Map []}
let actions : Map<byte,  char list -> FSharpToken list > = Map [
    0uy, fun buff -> 
        let len = buff |> List.skipWhile ((<>) ' ') |> List.length
        [NEW_LINE len]
    1uy, fun buff -> [WHITESPACE]
    2uy, fun buff -> [EXCLAM]
    3uy, fun buff -> [HASH]
    4uy, fun buff -> [PERCENT]
    5uy, fun buff -> [AMP]
    6uy, fun buff -> [LPAREN]
    7uy, fun buff -> [RPAREN]
    8uy, fun buff -> [STAR]
    9uy, fun buff -> [PLUS]
    10uy, fun buff -> [COMMA]
    11uy, fun buff -> [MINUS]
    12uy, fun buff -> [DOT]
    13uy, fun buff -> [DIV]
    14uy, fun buff -> [COLON]
    15uy, fun buff -> [SEMICOLON]
    16uy, fun buff -> [LESS]
    17uy, fun buff -> [EQUALS]
    18uy, fun buff -> [GREATER]
    19uy, fun buff -> [AT]
    20uy, fun buff -> [LBRACK]
    21uy, fun buff -> [RBRACK]
    22uy, fun buff -> [LBRACE]
    23uy, fun buff -> [BAR]
    24uy, fun buff -> [RBRACE]
    25uy, fun buff -> [AMP_AMP]
    26uy, fun buff -> [LPAREN_BAR]
    27uy, fun buff -> [STAR_STAR]
    28uy, fun buff -> [RARROW]
    29uy, fun buff -> [DOT_DOT]
    30uy, fun buff -> [COLON_COLON]
    31uy, fun buff -> [COLON_QMARK_GREATER]
    32uy, fun buff -> [COLON_QMARK]
    33uy, fun buff -> [LARROW]
    34uy, fun buff -> [LESS_GREATER]
    35uy, fun buff -> [LESS_BAR_BAR_BAR]
    36uy, fun buff -> [LESS_BAR_BAR]
    37uy, fun buff -> [LPIPE]
    38uy, fun buff -> [LBRACK_BAR]
    39uy, fun buff -> [BAR_RPAREN]
    40uy, fun buff -> [RPIPE]
    41uy, fun buff -> [BAR_RBRACK]
    42uy, fun buff -> [BAR_BAR_GREATER]
    43uy, fun buff -> [BAR_BAR_BAR_GREATER]
    44uy, fun buff -> [BAR_BAR]
    45uy, fun buff -> [LITERAL(Literal.int8 buff)]
    46uy, fun buff -> [LITERAL(Literal.int16 buff)]
    47uy, fun buff -> [LITERAL(Literal.int32 buff)]
    48uy, fun buff -> [LITERAL(Literal.int64 buff)]
    49uy, fun buff -> [LITERAL(Literal.uint8 buff)]
    50uy, fun buff -> [LITERAL(Literal.uint16 buff)]
    51uy, fun buff -> [LITERAL(Literal.uint32 buff)]
    52uy, fun buff -> [LITERAL(Literal.uint64 buff)]
    53uy, fun buff -> [LITERAL(Literal.float buff)]
    54uy, fun buff -> [LITERAL(Literal.single buff)]
    55uy, fun buff -> [TYPAR(String.build buff)]
    56uy, fun buff -> [LITERAL(Literal.char buff)]
    57uy, fun buff -> [LITERAL(Literal.char buff)]
    58uy, fun buff -> [LITERAL(Literal.char buff)]
    59uy, fun buff -> [LITERAL(Literal.char buff)]
    60uy, fun buff -> [LITERAL(Literal.string buff)]
    61uy, fun buff -> [IDENT(String.build buff)]
    62uy, fun buff -> 
        let tok =
            match String.build buff with
            | "module" -> MODULE
            | "open" -> OPEN
            | "let" -> LET
            | "fun" -> FUN
            | "match" -> MATCH
            | "with" -> WITH
            | "do" -> DO
            | "true" -> LITERAL(Literal.TRUE)
            | "false" -> LITERAL(Literal.FALSE)
            | "null" -> LITERAL(Literal.NULL)
            | s -> IDENT s
        [tok]
    63uy, fun buff -> failwith(stringify buff.[0])
    ]