module FSharp.LexYacc.Bootstrap.BlockCommentLexer
open System
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
let anal:Analyzer = {nextStates=Map [0u,set [[-7,41;43,1048575],4u;[42,42],1u];1u,set [[-7,40;42,1048575],3u;[41,41],2u]];flags=Map [1u,set [1uy,Look;2uy,Accept];2u,set [0uy,Accept];3u,set [1uy,Seen];4u,set [2uy,Accept]];lookbehinds=Map [1uy,{nextStates=Map [0u,set [[-7,40;42,1048575],1u]];accepts=set [1u]}]}
let actions : Map<byte,  char list -> char list > = Map [
    0uy, fun buff -> buff
    1uy, fun buff -> buff
    2uy, fun buff -> buff
    ]