open System.IO
open System.Text
open System

open FSharp.Substance
open FSharp.Idioms.Literal
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap

//let path = Path.Combine(__SOURCE_DIRECTORY__, "Sample.fs")
//let text = File.ReadAllText(path, Encoding.UTF8)

//let nodes = FSharpCompiler.compile text
//Console.WriteLine(stringify nodes)



for p in
    ViablePrefix.la_rrparen
    |> List.map (fun v -> v.head)    
    do
    Console.WriteLine(stringify p)
