namespace FSharp.LexYacc

open Xunit

open FSharp.xUnit
open FSharp.Idioms.Literal
open System.IO
open System.Text
open FSharp.Jsons.JsonStringLexer

type JsonStringLexerTest(output: ITestOutputHelper) =

    [<Theory>]
    [<Natural(4)>]
    member _.``tokenize test``(i:int) =
        let rows = [
            "\"\""
            "abc"
            "\r"
            "\\"
        ]
        let x = rows.[i]
        let iter = LexicalIterator.forChar x
        let y = FSharp.Jsons.JsonStringLexerTailer.tokenize iter |> Seq.toList
        output.WriteLine(stringify y)
        ()
