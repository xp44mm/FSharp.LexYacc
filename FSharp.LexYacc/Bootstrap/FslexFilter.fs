module FSharp.LexYacc.Bootstrap.FslexFilter
open System
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
let anal:Analyzer = {nextStates=Map [0u,set [[-7,0;2,7;11,12;19,19;22,1048575],9u;[1,1;8,8;13,17;20,21],7u;[9,10],4u;[18,18],1u];1u,set [[-7,4;6,1048575],2u;[5,5],3u];2u,set [[-7,4;6,1048575],2u;[5,5],3u];4u,set [[-7,15;17,1048575],5u;[16,16],6u];5u,set [[-7,15;17,1048575],5u;[16,16],6u];7u,set [[1,1;8,10;12,12;15,15;21,21],8u]];flags=Map [1u,set [3uy,Accept];3u,set [0uy,Accept];4u,set [1uy,Look;3uy,Accept];5u,set [1uy,Look];6u,set [1uy,Seen];7u,set [2uy,Look;3uy,Accept];8u,set [2uy,Seen];9u,set [3uy,Accept]];lookbehinds=Map [1uy,{nextStates=Map [0u,set [[16,16],1u]];accepts=set [1u]};2uy,{nextStates=Map [0u,set [[1,1;8,10;12,12;15,15;21,21],1u]];accepts=set [1u]}]}
let actions : Map<byte,  FslexToken list -> FslexToken list > = Map [
    0uy, fun buff -> buff
    1uy, fun buff -> buff
    2uy, fun buff -> buff @ [AMP]
    3uy, fun buff -> buff
    ]