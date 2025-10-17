module FSharp.LexYacc.Experimental.Program

open FSharp.xUnit
open FSharp.Idioms.Literal

open System.IO
open System.Text
open FSharp.LexYacc
open System
let anal = {
    nextStates =
        Map [
            0u,
            set [
                [ -7, 91; 93, 1048575 ], 19u
                [ 92, 92 ], 1u
            ]
            1u,
            set [
                [ 34, 34 ], 11u
                [ 92, 92 ], 2u
                [ 97, 97 ], 12u
                [ 98, 98 ], 13u
                [ 102, 102 ], 17u
                [ 110, 110 ], 15u
                [ 114, 114 ], 18u
                [ 116, 116 ], 14u
                [ 117, 117 ], 3u
                [ 118, 118 ], 16u
                [ 120, 120 ], 8u
            ]
            3u, set [ [ 48, 57; 65, 70; 97, 102 ], 4u ]
            4u, set [ [ 48, 57; 65, 70; 97, 102 ], 5u ]
            5u, set [ [ 48, 57; 65, 70; 97, 102 ], 6u ]
            6u, set [ [ 48, 57; 65, 70; 97, 102 ], 7u ]
            8u, set [ [ 48, 57; 65, 70; 97, 102 ], 9u ]
            9u, set [ [ 48, 57; 65, 70; 97, 102 ], 10u ]
        ]
    flags =
        Map [
            1u, set [ 11uy, Accept ]
            2u, set [ 0uy, Accept ]
            7u, set [ 1uy, Accept ]
            10u, set [ 2uy, Accept ]
            11u, set [ 3uy, Accept ]
            12u, set [ 4uy, Accept ]
            13u, set [ 5uy, Accept ]
            14u, set [ 6uy, Accept ]
            15u, set [ 7uy, Accept ]
            16u, set [ 8uy, Accept ]
            17u, set [ 9uy, Accept ]
            18u, set [ 10uy, Accept ]
            19u, set [ 11uy, Accept ]
        ]
    lookbehinds = Map []
}

[<EntryPoint>]
let main _ = 0
