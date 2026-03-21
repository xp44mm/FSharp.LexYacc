namespace FSharp.LexYacc

open Xunit

open FSharp.xUnit
open FSharp.Idioms.Literal
open System.IO
open System.Text
open FSharp.LexYacc.Bootstrap

type JsonStringTest(output: ITestOutputHelper) =
    let srcPath =
        Path.Combine(__SOURCE_DIRECTORY__, "jsonString.fslex")
    let text = File.ReadAllText(srcPath, Encoding.UTF8)

    [<Fact>]
    member _.``生成lex代码``() =
        let printer = FslexFilePrinter.forChar text
        let src = printer.print()
        //output.WriteLine(src)

        let path = Path.Combine(__SOURCE_DIRECTORY__, "JsonStringLexer.fs")
        File.WriteAllText(path, src, Encoding.UTF8)
        output.WriteLine($"output yacc:\r\n{path}")

        ()
