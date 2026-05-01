namespace FSharp.Substance

open Xunit
open FSharp.xUnit

open FSharp.Idioms
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
open FSharp.Substance

open System.IO
open System.Text
open FSharp.Idioms.Literal

type TypeArgumentYaccTest(output: ITestOutputHelper) as this =
    let name =
        let x = this.GetType().Name
        x.Substring(0, x.Length - "YaccTest".Length)

    let srcPath = Path.Combine(__SOURCE_DIRECTORY__, name + ".fsyacc")
    let text = File.ReadAllText(srcPath, Encoding.UTF8)

    [<Fact>]
    member _.``conflicted productions``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let prods =
            bnf.getConflictedProductions()
            |> Set.toList
        match prods with
        | [] -> output.WriteLine("no conflicted productions.")
        | _ ->
            output.WriteLine("conflicted productions:")
            for cp in prods do
                output.WriteLine($"{stringify cp}")

    [<Fact(Skip = "不必重复生成")>] //
    member _.``生成``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc

        let yaccFile = FsyaccFilePrinter.from flatFsyacc

        let src = yaccFile.printYaccModule(flatFsyacc.header)
        //output.WriteLine(src)

        let path = Path.Combine(Dir.main, name + "Yacc.fs")
        File.WriteAllText(path, src, Encoding.UTF8)
        output.WriteLine($"output:\r\n{path}")
        ()

    [<Fact>]
    member _.``所有符号``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let printline s = "%"+ $"type<_> {RawFsyaccFilePrinter.renderSymbol s}"

        for s in bnf.nonterminals do
            output.WriteLine(printline s)

        for s in bnf.terminals do
            output.WriteLine(printline s)



