module FSharp.Substance.FSharpLexer
open System
open FSharp.Idioms
open FSharp.Idioms.Literal
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
open FSharp.Substance
let anal:Analyzer = {nextStates=Map [0u,set [[-7,9;11,12;14,31;36,36;63,63;92,92;127,127;65536,1048575],114u;[10,10],2u;[13,13],1u;[32,32],3u;[33,33],4u;[34,34],103u;[35,35],5u;[37,37],6u;[38,38],7u;[39,39],83u;[40,40],8u;[41,41],9u;[42,42],10u;[43,43],11u;[44,44],12u;[45,45],13u;[46,46],14u;[47,47],15u;[48,48],60u;[49,57],67u;[58,58],16u;[59,59],17u;[60,60],18u;[61,61],19u;[62,62],20u;[64,64],21u;[65,90;95,95;97,122;128,65535],113u;[91,91],22u;[93,93],23u;[94,94],48u;[96,96],107u;[123,123],24u;[124,124],25u;[125,125],26u;[126,126],51u];1u,set [[10,10],2u];2u,set [[32,32],2u];3u,set [[32,32],3u];7u,set [[38,38],30u];8u,set [[124,124],41u];10u,set [[42,42],27u];13u,set [[62,62],36u];14u,set [[46,46],58u];16u,set [[58,58],35u;[63,63],33u];18u,set [[45,45],37u;[60,60],54u;[62,62],32u;[124,124],39u];20u,set [[62,62],56u];22u,set [[124,124],28u];25u,set [[41,41],40u;[62,62],38u;[93,93],29u;[124,124],31u];30u,set [[38,38],47u];31u,set [[62,62],44u;[124,124],45u];33u,set [[62,62],34u];39u,set [[124,124],42u];42u,set [[124,124],43u];45u,set [[62,62],46u];48u,set [[94,94],49u];49u,set [[94,94],50u];51u,set [[126,126],52u];52u,set [[126,126],53u];54u,set [[60,60],55u];56u,set [[62,62],57u];58u,set [[46,46],59u];60u,set [[46,46],78u;[48,57],67u;[66,66;98,98],66u;[69,69;101,101],79u;[76,76],71u;[79,79;111,111],64u;[85,85],76u;[88,88;120,120],62u;[108,108],70u;[115,115],69u;[117,117],72u;[121,121],68u];61u,set [[48,57;65,70;97,102],61u;[76,76],71u;[85,85],76u;[108,108],70u;[115,115],69u;[117,117],72u;[121,121],68u];62u,set [[48,57;65,70;97,102],61u];63u,set [[48,55],63u;[76,76],71u;[85,85],76u;[108,108],70u;[115,115],69u;[117,117],72u;[121,121],68u];64u,set [[48,55],63u];65u,set [[48,49],65u;[76,76],71u;[85,85],76u;[108,108],70u;[115,115],69u;[117,117],72u;[121,121],68u];66u,set [[48,49],65u];67u,set [[46,46],78u;[48,57],67u;[69,69;101,101],79u;[76,76],71u;[85,85],76u;[108,108],70u;[115,115],69u;[117,117],72u;[121,121],68u];72u,set [[76,76],77u;[108,108],75u;[115,115],74u;[121,121],73u];76u,set [[76,76],77u];78u,set [[48,57],78u;[69,69;101,101],79u;[70,70;102,102],82u];79u,set [[43,43;45,45],80u;[48,57],81u];80u,set [[48,57],81u];81u,set [[48,57],81u;[70,70;102,102],82u];83u,set [[-7,38;40,64;91,91;93,94;96,96;123,1048575],101u;[65,90;95,95;97,122],84u;[92,92],86u];84u,set [[39,39],102u;[48,57;65,90;95,95;97,122],85u];85u,set [[48,57;65,90;95,95;97,122],85u];86u,set [[-7,116;118,119;121,1048575],87u;[117,117],89u;[120,120],88u];87u,set [[39,39],90u];88u,set [[-7,38;40,1048575],93u;[39,39],91u];89u,set [[-7,38;40,1048575],96u;[39,39],92u];91u,set [[-7,1048575],94u];92u,set [[-7,1048575],97u];93u,set [[-7,1048575],94u];94u,set [[39,39],95u];96u,set [[-7,1048575],97u];97u,set [[-7,1048575],98u];98u,set [[-7,1048575],99u];99u,set [[39,39],100u];101u,set [[39,39],102u];103u,set [[-7,33;35,91;93,1048575],104u;[34,34],106u;[92,92],105u];104u,set [[-7,33;35,91;93,1048575],104u;[34,34],106u;[92,92],105u];105u,set [[-7,1048575],104u];107u,set [[96,96],109u];108u,set [[-7,9;11,12;14,95;97,1048575],108u;[96,96],111u];109u,set [[-7,9;11,12;14,95;97,1048575],108u;[96,96],110u];110u,set [[-7,9;11,12;14,95;97,1048575],108u];111u,set [[-7,9;11,12;14,95;97,1048575],108u;[96,96],112u];113u,set [[39,39;48,57;65,90;95,95;97,122;128,65535],113u]];flags=Map [1u,set [72uy,Accept];2u,set [0uy,Accept];3u,set [1uy,Accept];4u,set [2uy,Accept];5u,set [3uy,Accept];6u,set [4uy,Accept];7u,set [5uy,Accept];8u,set [6uy,Accept];9u,set [7uy,Accept];10u,set [8uy,Accept];11u,set [9uy,Accept];12u,set [10uy,Accept];13u,set [11uy,Accept];14u,set [12uy,Accept];15u,set [13uy,Accept];16u,set [14uy,Accept];17u,set [15uy,Accept];18u,set [16uy,Accept];19u,set [17uy,Accept];20u,set [18uy,Accept];21u,set [19uy,Accept];22u,set [20uy,Accept];23u,set [21uy,Accept];24u,set [22uy,Accept];25u,set [23uy,Accept];26u,set [24uy,Accept];27u,set [25uy,Accept];28u,set [26uy,Accept];29u,set [27uy,Accept];30u,set [28uy,Accept];31u,set [29uy,Accept];32u,set [30uy,Accept];33u,set [32uy,Accept];34u,set [31uy,Accept];35u,set [33uy,Accept];36u,set [34uy,Accept];37u,set [35uy,Accept];38u,set [36uy,Accept];39u,set [37uy,Accept];40u,set [38uy,Accept];41u,set [39uy,Accept];42u,set [40uy,Accept];43u,set [41uy,Accept];44u,set [42uy,Accept];45u,set [45uy,Accept];46u,set [43uy,Accept];47u,set [44uy,Accept];48u,set [72uy,Accept];50u,set [46uy,Accept];51u,set [72uy,Accept];53u,set [47uy,Accept];54u,set [51uy,Accept];55u,set [48uy,Accept];56u,set [50uy,Accept];57u,set [49uy,Accept];58u,set [52uy,Accept];59u,set [53uy,Accept];60u,set [56uy,Accept];61u,set [56uy,Accept];63u,set [56uy,Accept];65u,set [56uy,Accept];67u,set [56uy,Accept];68u,set [54uy,Accept];69u,set [55uy,Accept];70u,set [56uy,Accept];71u,set [57uy,Accept];72u,set [60uy,Accept];73u,set [58uy,Accept];74u,set [59uy,Accept];75u,set [60uy,Accept];77u,set [61uy,Accept];78u,set [62uy,Accept];81u,set [62uy,Accept];82u,set [63uy,Accept];83u,set [72uy,Accept];84u,set [64uy,Accept];85u,set [64uy,Accept];90u,set [65uy,Accept];91u,set [65uy,Accept];92u,set [65uy,Accept];95u,set [66uy,Accept];100u,set [67uy,Accept];102u,set [68uy,Accept];103u,set [72uy,Accept];106u,set [69uy,Accept];107u,set [72uy,Accept];112u,set [70uy,Accept];113u,set [71uy,Accept];114u,set [72uy,Accept]];lookbehinds=Map []}
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
    25uy, fun buff -> [STAR_STAR]
    26uy, fun buff -> [LBRACK_BAR]
    27uy, fun buff -> [BAR_RBRACK]
    28uy, fun buff -> [AMP_AMP]
    29uy, fun buff -> [BAR_BAR]
    30uy, fun buff -> [LESS_GREATER]
    31uy, fun buff -> [COLON_QMARK_GREATER]
    32uy, fun buff -> [COLON_QMARK]
    33uy, fun buff -> [COLON_COLON]
    34uy, fun buff -> [RARROW]
    35uy, fun buff -> [LARROW]
    36uy, fun buff -> [RPIPE]
    37uy, fun buff -> [LPIPE]
    38uy, fun buff -> [BAR_RPAREN]
    39uy, fun buff -> [LPAREN_BAR]
    40uy, fun buff -> [LESS_BAR_BAR]
    41uy, fun buff -> [LESS_BAR_BAR_BAR]
    42uy, fun buff -> [BAR_BAR_GREATER]
    43uy, fun buff -> [BAR_BAR_BAR_GREATER]
    44uy, fun buff -> [AMP_AMP_AMP]
    45uy, fun buff -> [BAR_BAR_BAR]
    46uy, fun buff -> [CARET_CARET_CARET]
    47uy, fun buff -> [TILDE_TILDE_TILDE]
    48uy, fun buff -> [LESS_LESS_LESS]
    49uy, fun buff -> [GREATER_GREATER_GREATER]
    50uy, fun buff -> [GREATER_GREATER]
    51uy, fun buff -> [LESS_LESS]
    52uy, fun buff -> [DOT_DOT]
    53uy, fun buff -> [DOT_DOT_DOT]
    54uy, fun buff -> [LITERAL(Literal.int8 buff)]
    55uy, fun buff -> [LITERAL(Literal.int16 buff)]
    56uy, fun buff -> [LITERAL(Literal.int32 buff)]
    57uy, fun buff -> [LITERAL(Literal.int64 buff)]
    58uy, fun buff -> [LITERAL(Literal.uint8 buff)]
    59uy, fun buff -> [LITERAL(Literal.uint16 buff)]
    60uy, fun buff -> [LITERAL(Literal.uint32 buff)]
    61uy, fun buff -> [LITERAL(Literal.uint64 buff)]
    62uy, fun buff -> [LITERAL(Literal.float buff)]
    63uy, fun buff -> [LITERAL(Literal.single buff)]
    64uy, fun buff -> [TYPAR(String.build buff)]
    65uy, fun buff -> [LITERAL(Literal.char buff)]
    66uy, fun buff -> [LITERAL(Literal.char buff)]
    67uy, fun buff -> [LITERAL(Literal.char buff)]
    68uy, fun buff -> [LITERAL(Literal.char buff)]
    69uy, fun buff -> [LITERAL(Literal.string buff)]
    70uy, fun buff -> [IDENT(String.build buff)]
    71uy, fun buff -> 
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
    72uy, fun buff -> failwith(stringify buff.[0])
    ]