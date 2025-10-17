module FSharp.Jsons.JsonStringLexer
open System
open FSharp.LexYacc
open FSharp.Idioms
let anal:Analyzer = {nextStates=Map [0u,set [[-7,91;93,1048575],15u;[92,92],1u];1u,set [[34,34],8u;[47,47],9u;[92,92],7u;[98,98],10u;[102,102],11u;[110,110],12u;[114,114],13u;[116,116],14u;[117,117],2u];2u,set [[48,57;65,70;97,102],3u];3u,set [[48,57;65,70;97,102],4u];4u,set [[48,57;65,70;97,102],5u];5u,set [[48,57;65,70;97,102],6u]];flags=Map [1u,set [9uy,Accept];6u,set [0uy,Accept];7u,set [1uy,Accept];8u,set [2uy,Accept];9u,set [3uy,Accept];10u,set [4uy,Accept];11u,set [5uy,Accept];12u,set [6uy,Accept];13u,set [7uy,Accept];14u,set [8uy,Accept];15u,set [9uy,Accept]];lookbehinds=Map []}
let actions : Map<byte, _> = Map [
    0uy, fun buff -> JsonStringToken.getChar buff
    1uy, fun buff -> '\\'
    2uy, fun buff -> '"'
    3uy, fun buff -> '/'
    4uy, fun buff -> '\b'
    5uy, fun buff -> '\f'
    6uy, fun buff -> '\n'
    7uy, fun buff -> '\r'
    8uy, fun buff -> '\t'
    9uy, fun buff -> buff.[0]
    ]