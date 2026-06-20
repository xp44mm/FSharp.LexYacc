module FSharp.Substance.FSharpLexer
open System
open FSharp.Idioms
open FSharp.Idioms.Literal
open FSharp.LexYacc
open FSharp.Substance
let anal:Analyzer = {nextStates=Map [0u,set [[-7,9;11,12;14,31;36,36;63,63;92,92;94,94;127,127;65536,1048575],111u;[10,10],2u;[13,13],1u;[32,32],3u;[33,33],4u;[34,34],96u;[35,35],109u;[37,37],5u;[38,38],6u;[39,39],75u;[40,40],7u;[41,41],8u;[42,42],9u;[43,43],10u;[44,44],11u;[45,45],12u;[46,46],13u;[47,47],14u;[48,48],52u;[49,57],59u;[58,58],15u;[59,59],16u;[60,60],17u;[61,61],18u;[62,62],19u;[64,64],20u;[65,90;95,95;128,65535],107u;[91,91],21u;[93,93],22u;[96,96],100u;[97,122],106u;[123,123],23u;[124,124],24u;[125,125],25u;[126,126],28u];1u,set [[10,10],2u];2u,set [[32,32],2u];3u,set [[32,32],3u];6u,set [[38,38],26u];7u,set [[41,41],31u;[124,124],32u];9u,set [[42,42],33u];12u,set [[62,62],34u];13u,set [[46,46],35u];15u,set [[58,58],36u;[63,63],37u];17u,set [[45,45],39u;[62,62],40u;[124,124],41u];21u,set [[124,124],44u];24u,set [[41,41],45u;[62,62],46u;[93,93],47u;[124,124],48u];26u,set [[38,38],27u];28u,set [[126,126],29u];29u,set [[126,126],30u];37u,set [[62,62],38u];41u,set [[124,124],42u];42u,set [[124,124],43u];48u,set [[62,62],49u;[124,124],50u];50u,set [[62,62],51u];52u,set [[46,46],70u;[48,57],59u;[66,66;98,98],58u;[69,69;101,101],71u;[76,76],63u;[79,79;111,111],56u;[85,85],68u;[88,88;120,120],54u;[108,108],62u;[115,115],61u;[117,117],64u;[121,121],60u];53u,set [[48,57;65,70;97,102],53u;[76,76],63u;[85,85],68u;[108,108],62u;[115,115],61u;[117,117],64u;[121,121],60u];54u,set [[48,57;65,70;97,102],53u];55u,set [[48,55],55u;[76,76],63u;[85,85],68u;[108,108],62u;[115,115],61u;[117,117],64u;[121,121],60u];56u,set [[48,55],55u];57u,set [[48,49],57u;[76,76],63u;[85,85],68u;[108,108],62u;[115,115],61u;[117,117],64u;[121,121],60u];58u,set [[48,49],57u];59u,set [[46,46],70u;[48,57],59u;[69,69;101,101],71u;[76,76],63u;[85,85],68u;[108,108],62u;[115,115],61u;[117,117],64u;[121,121],60u];64u,set [[76,76],69u;[108,108],67u;[115,115],66u;[121,121],65u];68u,set [[76,76],69u];70u,set [[48,57],70u;[69,69;101,101],71u;[70,70;102,102],74u];71u,set [[43,43;45,45],72u;[48,57],73u];72u,set [[48,57],73u];73u,set [[48,57],73u;[70,70;102,102],74u];75u,set [[-7,38;40,64;91,91;93,94;96,96;123,1048575],94u;[65,90;95,95;97,122],76u;[92,92],79u];76u,set [[-7,38;40,47;58,64;91,94;96,96;123,1048575],78u;[39,39],95u;[48,57;65,90;95,95;97,122],77u];77u,set [[-7,38;40,47;58,64;91,94;96,96;123,1048575],78u;[48,57;65,90;95,95;97,122],77u];79u,set [[-7,116;118,119;121,1048575],80u;[117,117],82u;[120,120],81u];80u,set [[39,39],83u];81u,set [[-7,38;40,1048575],86u;[39,39],84u];82u,set [[-7,38;40,1048575],89u;[39,39],85u];84u,set [[-7,1048575],87u];85u,set [[-7,1048575],90u];86u,set [[-7,1048575],87u];87u,set [[39,39],88u];89u,set [[-7,1048575],90u];90u,set [[-7,1048575],91u];91u,set [[-7,1048575],92u];92u,set [[39,39],93u];94u,set [[39,39],95u];96u,set [[-7,33;35,91;93,1048575],97u;[34,34],99u;[92,92],98u];97u,set [[-7,33;35,91;93,1048575],97u;[34,34],99u;[92,92],98u];98u,set [[-7,1048575],97u];100u,set [[96,96],102u];101u,set [[-7,9;11,12;14,95;97,1048575],101u;[96,96],104u];102u,set [[-7,9;11,12;14,95;97,1048575],101u;[96,96],103u];103u,set [[-7,9;11,12;14,95;97,1048575],101u];104u,set [[-7,9;11,12;14,95;97,1048575],101u;[96,96],105u];106u,set [[33,33],108u;[39,39;48,57;65,90;95,95;128,65535],107u;[97,122],106u];107u,set [[39,39;48,57;65,90;95,95;97,122;128,65535],107u];109u,set [[65,90;95,95;97,122;128,65535],110u];110u,set [[39,39;48,57;65,90;95,95;97,122;128,65535],110u]];flags=Map [1u,set [67uy,Accept];2u,set [0uy,Accept];3u,set [1uy,Accept];4u,set [2uy,Accept];5u,set [3uy,Accept];6u,set [4uy,Accept];7u,set [5uy,Accept];8u,set [6uy,Accept];9u,set [7uy,Accept];10u,set [8uy,Accept];11u,set [9uy,Accept];12u,set [10uy,Accept];13u,set [11uy,Accept];14u,set [12uy,Accept];15u,set [13uy,Accept];16u,set [14uy,Accept];17u,set [15uy,Accept];18u,set [16uy,Accept];19u,set [17uy,Accept];20u,set [18uy,Accept];21u,set [19uy,Accept];22u,set [20uy,Accept];23u,set [21uy,Accept];24u,set [22uy,Accept];25u,set [23uy,Accept];26u,set [24uy,Accept];27u,set [25uy,Accept];28u,set [67uy,Accept];30u,set [26uy,Accept];31u,set [27uy,Accept];32u,set [28uy,Accept];33u,set [29uy,Accept];34u,set [30uy,Accept];35u,set [31uy,Accept];36u,set [32uy,Accept];37u,set [34uy,Accept];38u,set [33uy,Accept];39u,set [35uy,Accept];40u,set [36uy,Accept];41u,set [39uy,Accept];42u,set [38uy,Accept];43u,set [37uy,Accept];44u,set [40uy,Accept];45u,set [41uy,Accept];46u,set [42uy,Accept];47u,set [43uy,Accept];48u,set [46uy,Accept];49u,set [44uy,Accept];51u,set [45uy,Accept];52u,set [49uy,Accept];53u,set [49uy,Accept];55u,set [49uy,Accept];57u,set [49uy,Accept];59u,set [49uy,Accept];60u,set [47uy,Accept];61u,set [48uy,Accept];62u,set [49uy,Accept];63u,set [50uy,Accept];64u,set [53uy,Accept];65u,set [51uy,Accept];66u,set [52uy,Accept];67u,set [53uy,Accept];69u,set [54uy,Accept];70u,set [55uy,Accept];73u,set [55uy,Accept];74u,set [56uy,Accept];75u,set [67uy,Accept];76u,set [57uy,Look];77u,set [57uy,Seen;57uy,Look];78u,set [57uy,Seen];83u,set [58uy,Accept];84u,set [58uy,Accept];85u,set [58uy,Accept];88u,set [59uy,Accept];93u,set [60uy,Accept];95u,set [61uy,Accept];96u,set [67uy,Accept];99u,set [62uy,Accept];100u,set [67uy,Accept];105u,set [63uy,Accept];106u,set [64uy,Accept];107u,set [64uy,Accept];108u,set [65uy,Accept];109u,set [67uy,Accept];110u,set [66uy,Accept];111u,set [67uy,Accept]];lookbehinds=Map [57uy,{nextStates=Map [0u,set [[-7,38;40,1048575],1u]];accepts=set [1u]}]}
let actions : Map<byte,  char list -> FSharpToken list > = Map [
    0uy, (fun buff -> 
        let len = buff |> List.skipWhile ((<>) ' ') |> List.length
        [NEW_LINE len] )
    1uy, (fun buff -> [WHITESPACE])
    2uy, (fun buff -> [EXCLAM])
    3uy, (fun buff -> [ALWAYS_INFIX "%"])
    4uy, (fun buff -> [ALWAYS_INFIX "&"])
    5uy, (fun buff -> [LPAREN])
    6uy, (fun buff -> [RPAREN])
    7uy, (fun buff -> [STAR])
    8uy, (fun buff -> [PLUS])
    9uy, (fun buff -> [COMMA])
    10uy, (fun buff -> [MINUS])
    11uy, (fun buff -> [DOT])
    12uy, (fun buff -> [ALWAYS_INFIX "/"])
    13uy, (fun buff -> [COLON])
    14uy, (fun buff -> [SEMICOLON])
    15uy, (fun buff -> [LESS])
    16uy, (fun buff -> [EQUALS])
    17uy, (fun buff -> [GREATER])
    18uy, (fun buff -> [ALWAYS_INFIX "@"])
    19uy, (fun buff -> [LBRACK])
    20uy, (fun buff -> [RBRACK])
    21uy, (fun buff -> [LBRACE])
    22uy, (fun buff -> [BAR])
    23uy, (fun buff -> [RBRACE])
    24uy, (fun buff -> [ALWAYS_INFIX "&&"])
    25uy, (fun buff -> [ALWAYS_INFIX "&&&"])
    26uy, (fun buff -> [ALWAYS_PREFIX "~~~"])
    27uy, (fun buff -> [LITERAL(Literal.UNIT)])
    28uy, (fun buff -> [LPAREN_BAR])
    29uy, (fun buff -> [ALWAYS_INFIX "**"])
    30uy, (fun buff -> [RARROW])
    31uy, (fun buff -> [ALWAYS_INFIX ".."])
    32uy, (fun buff -> [ALWAYS_INFIX "::"])
    33uy, (fun buff -> [ALWAYS_INFIX ":?>"])
    34uy, (fun buff -> [ALWAYS_INFIX ":?"])
    35uy, (fun buff -> [LARROW])
    36uy, (fun buff -> [ALWAYS_INFIX "<>"])
    37uy, (fun buff -> [ALWAYS_INFIX "<|||"])
    38uy, (fun buff -> [ALWAYS_INFIX "<||"])
    39uy, (fun buff -> [ALWAYS_INFIX "<|"])
    40uy, (fun buff -> [LBRACK_BAR])
    41uy, (fun buff -> [BAR_RPAREN])
    42uy, (fun buff -> [ALWAYS_INFIX "|>"])
    43uy, (fun buff -> [BAR_RBRACK])
    44uy, (fun buff -> [ALWAYS_INFIX "||>"])
    45uy, (fun buff -> [ALWAYS_INFIX "|||>"])
    46uy, (fun buff -> [ALWAYS_INFIX "||"])
    47uy, (fun buff -> [LITERAL(Literal.int8 buff)])
    48uy, (fun buff -> [LITERAL(Literal.int16 buff)])
    49uy, (fun buff -> [LITERAL(Literal.int32 buff)])
    50uy, (fun buff -> [LITERAL(Literal.int64 buff)])
    51uy, (fun buff -> [LITERAL(Literal.uint8 buff)])
    52uy, (fun buff -> [LITERAL(Literal.uint16 buff)])
    53uy, (fun buff -> [LITERAL(Literal.uint32 buff)])
    54uy, (fun buff -> [LITERAL(Literal.uint64 buff)])
    55uy, (fun buff -> [LITERAL(Literal.float buff)])
    56uy, (fun buff -> [LITERAL(Literal.single buff)])
    57uy, (fun buff -> [TYPAR(String.build buff)])
    58uy, (fun buff -> [LITERAL(Literal.char buff)])
    59uy, (fun buff -> [LITERAL(Literal.char buff)])
    60uy, (fun buff -> [LITERAL(Literal.char buff)])
    61uy, (fun buff -> [LITERAL(Literal.char buff)])
    62uy, (fun buff -> [LITERAL(Literal.string buff)])
    63uy, (fun buff -> [IDENT(String.build buff)])
    64uy, (fun buff -> 
        let tok =
            match String.build buff with
            | "and" -> AND
            | "as" -> AS
            | "do" -> DO
            | "elif" -> ELIF
            | "else" -> ELSE
            | "finally" -> FINALLY
            | "for" -> FOR
            | "false" -> LITERAL(Literal.FALSE)
            | "fun" -> FUN
            | "function" -> FUNCTION
            | "if" -> IF
            | "in" -> IN
            | "let" -> LET
            | "match" -> MATCH
            | "module" -> MODULE
            | "mutable" -> MUTABLE
            | "null" -> LITERAL(Literal.NULL)
            | "open" -> OPEN
            | "rec" -> REC
            | "return" -> RETURN
            | "then" -> THEN
            | "try" -> TRY
            | "type" -> TYPE
            | "use" -> USE
            | "when" -> WHEN
            | "while" -> WHILE
            | "true" -> LITERAL(Literal.TRUE)
            | "with" -> WITH
            | "yield" -> YIELD
            | s -> IDENT s
        [tok])
    65uy, (fun buff -> 
        let tok =
            match String.build buff with
            | "and!" -> AND_BANG
            | "do!" -> DO_BANG
            | "let!" -> LET_BANG
            | "match!" -> MATCH_BANG
            | "return!" -> RETURN_BANG
            | "use!" -> USE_BANG
            | "while!" -> WHILE_BANG
            | "yield!" -> YIELD_BANG
            | _ -> failwith $"{buff}"
        [tok])
    66uy, (fun buff -> [IDENT(String.build buff)])
    67uy, (fun buff -> failwith(stringify buff.[0]))
    ]
