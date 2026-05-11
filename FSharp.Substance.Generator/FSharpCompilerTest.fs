namespace FSharp.Substance

open Xunit
open FSharp.xUnit
open FSharp.Idioms.Literal

open System.IO
open System.Text
open System.Reflection

type FSharpCompilerTest(output: ITestOutputHelper) =
    let test filename (tgt:string list*Expr list) =
        let path = Path.Combine(__SOURCE_DIRECTORY__, filename + ".fs")
        let lines = File.ReadAllLines(path, Encoding.UTF8)
        let groups = Pen.getTopLevels lines
        let len = groups.Length
        let src =
            groups.[.. len - 2]
            |> List.concat
            |> String.concat "\n"

        let nodes = FSharpCompiler.compile src
        output.WriteLine("let tgt = " + stringify nodes)
        Should.equal nodes tgt


    [<Fact>]
    member _.``PEEK_BAR``() =
        let name = MethodBase.GetCurrentMethod().Name
        test name PEEK_BAR.tgt

    [<Fact>]
    member _.``PEEK_NEWLINE_MODULE``() =
        let name = MethodBase.GetCurrentMethod().Name
        test name PEEK_NEWLINE_MODULE.tgt

    [<Fact>]
    member _.``PEEK_SEMICOLON``() =
        let name = MethodBase.GetCurrentMethod().Name
        test name PEEK_SEMICOLON.tgt

    [<Fact>]
    member _.``PEEK_RPAREN``() =
        let name = MethodBase.GetCurrentMethod().Name
        test name PEEK_RPAREN.tgt

    [<Fact>]
    member _.``PEEK_RBRACK``() =
        let name = MethodBase.GetCurrentMethod().Name
        test name PEEK_RBRACK.tgt

    [<Fact>]
    member _.``PEEK_NEW_BLOCK``() =
        let name = MethodBase.GetCurrentMethod().Name
        test name PEEK_NEW_BLOCK.tgt

    [<Fact>]
    member _.``PEEK_NEWLINE_NEW_DECL``() =
        let name = MethodBase.GetCurrentMethod().Name
        test name PEEK_NEWLINE_NEW_DECL.tgt

    [<Fact>]
    member _.``PEEK_EOF``() =
        let name = MethodBase.GetCurrentMethod().Name
        test name PEEK_EOF.tgt


