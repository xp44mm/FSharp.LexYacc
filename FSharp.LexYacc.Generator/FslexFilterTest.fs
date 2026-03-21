namespace FSharp.LexYacc

open Xunit

open FSharp.xUnit
open FSharp.Idioms.Literal
open System.IO
open System.Text

open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap

type FslexFilterTest(output: ITestOutputHelper) as this =
    let name =
        let x = this.GetType().Name
        x.Substring(0, x.Length - 4)
    let srcPath =
        Path.Combine(__SOURCE_DIRECTORY__, "fslex_filter.fslex")
    let text = File.ReadAllText(srcPath, Encoding.UTF8)

    [<Fact>] // (Skip="掠过生成")
    member _.``生成``() =
        let printer =
            FslexFilePrinter.forTag FslexToken.tagToValue text
        let src = printer.print()
        output.WriteLine(src)

        //let path = Path.Combine(Dir.bootstrap, name + ".fs")
        //File.WriteAllText(path, src, Encoding.UTF8)
        //output.WriteLine($"output:\r\n{path}")

        ()
