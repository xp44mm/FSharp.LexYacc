namespace FSharp.Substance

open Xunit

open FSharp.xUnit
open FSharp.Idioms.Literal

open System.IO
open System.Text
open System
open FSharp.LexYacc

type SpliterTest(output: ITestOutputHelper) =

    [<Theory>]
    [<InlineData("EscapeLexer")>]
    [<InlineData("FslexYacc")>]
    member _.``分割模块代码``(file) =
        let path =
            @"D:\Application Data\GitHub\xp44mm\FSharp.LexYacc\FSharp.LexYacc\Bootstrap\"
        let path = Path.Combine(path, file + ".fs")

        let groups = Pen.getTopLevels path

        output.WriteLine($"{groups.Length}")

        for g in groups do
            output.WriteLine($"{g.[0]}")

        let bds = Pen.getBindings path

        output.WriteLine($"{bds.Length}")

        for (lhs, rhs) in bds do
            //output.WriteLine($"{lhs}")
            output.WriteLine($"{rhs}")

        ()

    [<Theory>]
    [<InlineData("FslexYacc")>]
    member _.``yacc string array``(file) =
        let path =
            @"D:\Application Data\GitHub\xp44mm\FSharp.LexYacc\FSharp.LexYacc\Bootstrap\"
        let path = Path.Combine(path, file + ".fs")

        let bds = Pen.getBindings path

        //output.WriteLine($"{bds.Length}")

        //for (lhs,rhs) in bds do
        //    //output.WriteLine($"{lhs}")
        //    output.WriteLine($"{rhs}")
        let code = bds.[0] |> snd |> String.concat "\n"
        output.WriteLine($"{code}")

        let iter = LexicalIterator.forChar code
        let tokens =
            iter |> FSharpLexerTailer.tokenize

        for tok in tokens do
            output.WriteLine(stringify tok)
            
        ()
