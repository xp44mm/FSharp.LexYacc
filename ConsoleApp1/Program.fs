open System.IO
open System.Text
open System

open FSharp.Substance
open FSharp.Idioms.Literal
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
open FSharp.Substance.RightSententialForm

let path = Path.Combine(__SOURCE_DIRECTORY__, "Sample.fs")
let text = File.ReadAllText(path, Encoding.UTF8)

let nodes = FSharpCompiler.compile text
Console.WriteLine(stringify nodes)


//let lookaheads = lookaheads.Keys |> Seq.toList
//Console.WriteLine(stringify lookaheads)
//for p in
//    lookaheads.["EOF"]
//    |> Set.ofSeq
//    do
//    Console.WriteLine(stringify p)
