namespace FSharp.Substance

open Xunit
open FSharp.xUnit
open FSharp.Idioms.Literal

open System.IO
open System.Text
open System.Reflection

type FSharpCompilerTest(output: ITestOutputHelper) =
    let entries = [
        //"PEEK_BAR", PEEK_BAR.tgt
        //"PEEK_NEWLINE_MODULE", PEEK_NEWLINE_MODULE.tgt
        "PEEK_SEMICOLON", PEEK_SEMICOLON.tgt
        //"PEEK_RPAREN", PEEK_RPAREN.tgt
        "PEEK_RBRACK", PEEK_RBRACK.tgt
        "PEEK_NEW_BLOCK", PEEK_NEW_BLOCK.tgt
        //"PEEK_NEWLINE_NEW_DECL", PEEK_NEWLINE_NEW_DECL.tgt
        "PEEK_EOF", PEEK_EOF.tgt
        "RecordLiteralExpr", RecordLiteralExpr.tgt
    ]

    [<Theory>]
    [<Natural 9>]
    member _.``light fsharp language``(i:int) =
        let filename,tgt = entries.[i]
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
