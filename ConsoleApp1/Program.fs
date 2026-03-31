open System.IO
open System.Text
open System

open FSharp.Substance
open FSharp.Idioms.Literal


let res = [
    ModuleIntro [ "FSharp"; "Substance"; "FSharpLexer" ]
    OpenStatement [ "System" ]
    OpenStatement [ "FSharp"; "Idioms" ]
    OpenStatement [ "FSharp"; "Idioms"; "Literal" ]
    OpenStatement [ "FSharp"; "LexYacc" ]
    OpenStatement [ "FSharp"; "LexYacc"; "Bootstrap" ]
    OpenStatement [ "FSharp"; "Substance" ]
]

// For more information see https://aka.ms/fsharp-console-apps
let path = @"D:\FSharpLexer.fs"
let text = File.ReadAllText(path, Encoding.UTF8)

let nodes = FSharpCompiler.compile text
Console.WriteLine(stringify nodes)
