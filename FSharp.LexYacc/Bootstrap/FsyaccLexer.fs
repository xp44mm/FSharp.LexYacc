module FSharp.LexYacc.Bootstrap.FsyaccLexer
open System
open FSharp.Idioms
open FSharp.Idioms.Literal
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
let anal:Analyzer = {nextStates=Map [0u,set [[-7,9;11,12;14,31;33,33;35,36;38,39;41,46;48,57;59,64;91,94;96,96;125,1048575],42u;[10,10;13,13;32,32],4u;[34,34],37u;[37,37],9u;[40,40],1u;[47,47],7u;[58,58],5u;[65,90;95,95;97,122],41u;[123,123],3u;[124,124],6u];1u,set [[42,42],2u];4u,set [[10,10;13,13;32,32],4u];7u,set [[47,47],8u];8u,set [[-7,9;11,12;14,1048575],8u];9u,set [[108,108],16u;[110,110],25u;[112,112],33u;[114,114],20u;[116,116],10u];10u,set [[121,121],11u];11u,set [[112,112],12u];12u,set [[101,101],13u];13u,set [[60,60],14u];14u,set [[-7,9;11,12;14,33;35,61;63,1048575],14u;[62,62],15u];15u,set [[-7,9;11,12;14,33;35,61;63,1048575],14u;[62,62],15u];16u,set [[101,101],17u];17u,set [[102,102],18u];18u,set [[116,116],19u];20u,set [[105,105],21u];21u,set [[103,103],22u];22u,set [[104,104],23u];23u,set [[116,116],24u];25u,set [[111,111],26u];26u,set [[110,110],27u];27u,set [[97,97],28u];28u,set [[115,115],29u];29u,set [[115,115],30u];30u,set [[111,111],31u];31u,set [[99,99],32u];33u,set [[114,114],34u];34u,set [[101,101],35u];35u,set [[99,99],36u];37u,set [[-7,33;35,91;93,1048575],38u;[34,34],40u;[92,92],39u];38u,set [[-7,33;35,91;93,1048575],38u;[34,34],40u;[92,92],39u];39u,set [[-7,1048575],38u];41u,set [[48,57;65,90;95,95;97,122],41u]];flags=Map [1u,set [13uy,Accept];2u,set [0uy,Accept];3u,set [1uy,Accept];4u,set [2uy,Accept];5u,set [3uy,Accept];6u,set [4uy,Accept];7u,set [13uy,Accept];8u,set [5uy,Accept];9u,set [13uy,Accept];15u,set [6uy,Accept];19u,set [7uy,Accept];24u,set [8uy,Accept];32u,set [9uy,Accept];36u,set [10uy,Accept];37u,set [13uy,Accept];40u,set [11uy,Accept];41u,set [12uy,Accept];42u,set [13uy,Accept]];lookbehinds=Map []}
let actions restBlockComment restBraces: Map<byte,  char list -> FsyaccToken list > = Map [
    0uy, fun buff -> 
        let _ = restBlockComment()
        []
    1uy, fun buff -> 
        let rest = restBraces()
        [FsyaccToken.BRACES("{"+String.build rest)]
    2uy, fun buff -> []
    3uy, fun buff -> [FsyaccToken.COLON]
    4uy, fun buff -> [FsyaccToken.BAR]
    5uy, fun buff -> []
    6uy, fun buff -> [FsyaccToken.PERCENT_TYPE(String.build buff)]
    7uy, fun buff -> [FsyaccToken.LEFTASSOC]
    8uy, fun buff -> [FsyaccToken.RIGHTASSOC]
    9uy, fun buff -> [FsyaccToken.NONASSOC]
    10uy, fun buff -> [FsyaccToken.PREC]
    11uy, fun buff -> [FsyaccToken.QUOTE(EscapeLexerTailer.unquote buff)]
    12uy, fun buff -> [FsyaccToken.ID(String.build buff)]
    13uy, fun buff -> failwith(stringify buff.[0])
    ]