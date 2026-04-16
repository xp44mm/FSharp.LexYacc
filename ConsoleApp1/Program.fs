open System.IO
open System.Text
open System

open FSharp.Substance
open FSharp.Idioms.Literal


let path = Path.Combine(__SOURCE_DIRECTORY__, "Sample.fs")
let text = File.ReadAllText(path, Encoding.UTF8)

let nodes = FSharpCompiler.compile text
Console.WriteLine(stringify nodes)
