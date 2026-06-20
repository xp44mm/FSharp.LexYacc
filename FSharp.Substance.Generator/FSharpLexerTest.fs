namespace FSharp.Substance

open Xunit
open FSharp.xUnit

open System.IO
open System.Text

open FSharp.LexYacc.Bootstrap
open FSharp.Substance

type FSharpLexerTest(output: ITestOutputHelper) as this =
    let name =
        let x = this.GetType().Name
        x.Substring(0, x.Length - "LexerTest".Length)

    let srcPath = Path.Combine(__SOURCE_DIRECTORY__, name + ".fslex")

    let text = File.ReadAllText(srcPath, Encoding.UTF8)

    [<Fact>] //(Skip = "没有改变，不必重复生成")
    member _.``生成``() =
        let printer = FslexFilePrinter.forChar text
        let src = printer.print()
        //output.WriteLine(src)

        let path = Path.Combine(Dir.main, name + "Lexer.fs")
        File.WriteAllText(path, src, Encoding.UTF8)
        output.WriteLine($"output:\r\n{path}")

        ()

    [<Fact>]
    member _.``验证``() =
        // actual
        let anal = FSharpLexer.anal
        let actions = FSharpLexer.actions

        // expect
        let printer = FslexFilePrinter.forChar text
        //output.WriteLine(stringify printer.anal)
        Should.equal printer.anal anal

        let rule_ids1 = printer.ruler.actions |> List.map fst
        //output.WriteLine(stringify rule_ids1)

        let rule_ids2 = actions.Keys |> List.ofSeq
        Should.equal rule_ids1 rule_ids2

        // todo: header 比较
        // todo: actions 比较

        ()
