module FSharp.LexYacc.Bootstrap.BracesLexer
open System
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
let anal:Analyzer = {nextStates=Map [0u,set [[-7,33;35,38;41,46;48,95;97,122;124,124;126,1048575],20u;[34,34],14u;[39,39],11u;[40,40],3u;[47,47],1u;[96,96],5u;[123,123],18u;[125,125],19u];1u,set [[47,47],2u];2u,set [[-7,9;11,12;14,1048575],2u];3u,set [[42,42],4u];5u,set [[96,96],7u];6u,set [[-7,95;97,1048575],6u;[96,96],9u];7u,set [[-7,95;97,1048575],6u;[96,96],8u];8u,set [[-7,95;97,1048575],6u];9u,set [[-7,95;97,1048575],6u;[96,96],10u];11u,set [[123,123;125,125],12u];12u,set [[39,39],13u];14u,set [[-7,33;35,91;93,1048575],15u;[34,34],17u;[92,92],16u];15u,set [[-7,33;35,91;93,1048575],15u;[34,34],17u;[92,92],16u];16u,set [[-7,1048575],15u]];flags=Map [1u,set [7uy,Accept];2u,set [0uy,Accept];3u,set [7uy,Accept];4u,set [1uy,Accept];5u,set [7uy,Accept];10u,set [2uy,Accept];11u,set [7uy,Accept];13u,set [3uy,Accept];14u,set [7uy,Accept];17u,set [4uy,Accept];18u,set [5uy,Accept];19u,set [6uy,Accept];20u,set [7uy,Accept]];lookbehinds=Map []}
let actions restBlockComment: Map<byte,  char list -> BracesToken > = Map [
    0uy, fun buff -> BUFF buff
    1uy, fun buff -> 
        let rest = restBlockComment()
        BUFF [ yield! buff; yield! rest ]
    2uy, fun buff -> BUFF buff
    3uy, fun buff -> BUFF buff
    4uy, fun buff -> BUFF buff
    5uy, fun buff -> LBRACE
    6uy, fun buff -> RBRACE
    7uy, fun buff -> BUFF buff
    ]