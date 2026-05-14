open System.IO
open System.Text
open System

open FSharp.Substance
open FSharp.Idioms.Literal
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
open FSharp.Substance.RightSententialForm
open System.Diagnostics

let path = Path.Combine(__SOURCE_DIRECTORY__, "Sample.fs")

let heads () =
    let lines = File.ReadAllLines(path, Encoding.UTF8)
    let groups = Pen.getTopLevels lines
    Console.WriteLine($"组数：{groups.Length}")
    for g in groups do
        Console.WriteLine($"每组第一行：{g.[0]}")

let smoke () =
    let text = File.ReadAllText(path, Encoding.UTF8)

    let nodes = FSharpCompiler.compile text
    //Debug.Assert((snd nodes = expected))
    Console.WriteLine(stringify nodes)

let test () =
    let lines = File.ReadAllLines(path, Encoding.UTF8)
    let groups = Pen.getTopLevels lines
    let len = groups.Length
    let src =
        groups.[.. len - 2]
        |> List.concat
        |> String.concat "\n"

    let nodes = FSharpCompiler.compile src
    Console.WriteLine("let tgt = " + stringify nodes)

//smoke()

Console.WriteLine(nameof FSharpToken.BAR)
Console.WriteLine(nameof FSharpToken.ALWAYS_INFIX)

//let lookaheads =
//    lookaheads
//    |> Set.filter(fun v -> v.head = "revSequentialExpr")

//Console.WriteLine(stringify lookaheads)
//for p in lookaheads do
//    Console.WriteLine(stringify p)
