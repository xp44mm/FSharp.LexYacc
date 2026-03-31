namespace FSharp.Substance

open Xunit
open FSharp.xUnit
open FSharp.Idioms.Literal

open System.IO
open System.Text
open System.Reflection

type FSharpCompilerTest(output: ITestOutputHelper) =

    [<Fact>]
    member _.``TestData test``() =
        let path = @"D:\FSharpLexer.fs"
        let text = File.ReadAllText(path, Encoding.UTF8)
        let nodes = FSharpCompiler.compile text
        output.WriteLine(stringify nodes)

        //Should.equal e nodes
        ()
