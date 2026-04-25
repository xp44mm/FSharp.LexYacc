open System.IO
open System.Text
open System

open FSharp.Substance
open FSharp.Idioms.Literal
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap


let srcPath = @"D:\Application Data\GitHub\xp44mm\FSharp.LexYacc\FSharp.Substance.Generator\fsharp.fsyacc"

let text = File.ReadAllText(srcPath, Encoding.UTF8)

let rawFsyacc = FsyaccCompiler.compile text

Console.WriteLine(stringify rawFsyacc)

//let path = Path.Combine(__SOURCE_DIRECTORY__, "Sample.fs")
//let text = File.ReadAllText(path, Encoding.UTF8)

//let nodes = FSharpCompiler.compile text
//Console.WriteLine(stringify nodes)

//for p in ViablePrefix.topOf "IDENT" do
//    Console.WriteLine(stringify p)
