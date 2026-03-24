namespace FSharp.LexYacc

open System.IO
open System.Text

open Xunit


open FSharp.xUnit
open FSharp.Idioms.Literal
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap

type FslexLexerTest(output: ITestOutputHelper) as this =
    let name = 
        let x = this.GetType().Name
        x.Substring(0, x.Length - 4)
    let srcPath =
        Path.Combine(__SOURCE_DIRECTORY__, "fslex.fslex")
    let text = File.ReadAllText(srcPath, Encoding.UTF8)

    [<Fact(Skip="没有改变，不必重复生成")>] // 
    member _.``生成``() =
        let printer = FslexFilePrinter.forChar text
        let src = printer.print()
        output.WriteLine(src)

        let path = Path.Combine(Dir.bootstrap, name+".fs")
        File.WriteAllText(path, src, Encoding.UTF8)
        output.WriteLine($"output:\r\n{path}")

        ()

    [<Fact>]
    member _.``验证``() =
        let printer = FslexFilePrinter.forChar text
        output.WriteLine(stringify printer.anal)

        let anal = FslexLexer.anal
        let actions = FslexLexer.actions (fun () -> "") (fun () -> Seq.empty)

        Should.equal printer.anal anal

        let rule_ids1 = printer.ruler.actions |> List.map fst
        output.WriteLine(stringify rule_ids1)

        let rule_ids2 = actions.Keys |> List.ofSeq
        Should.equal rule_ids1 rule_ids2

        // todo: header 比较
        // todo: actions 比较

        ()






