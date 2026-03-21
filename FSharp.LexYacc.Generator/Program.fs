module FSharp.LexYacc.Program

open Xunit

open FSharp.xUnit
open FSharp.Idioms.Literal
open System
open System.Text

[<EntryPoint>]
let main _ =
    let ls len =
        [0 .. len-1]
        |> List.map(fun i -> string(char (int 'a' + i)))
        |> String.concat ","
    Console.WriteLine (ls 0)
    Console.WriteLine (ls 1)
    Console.WriteLine (ls 2)
    Console.WriteLine (ls 3)
    Console.WriteLine (ls 4)
    Console.WriteLine (ls 5)


    0
