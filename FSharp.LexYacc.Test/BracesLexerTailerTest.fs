namespace FSharp.LexYacc

open System.IO
open System.Text
open Xunit

open FSharp.xUnit
open FSharp.Idioms.Literal
open FSharp.Idioms

type BracesLexerTailerTest(output: ITestOutputHelper) =
    [<Theory>]
    [<Natural(6)>]
    member _.``tokenize test``(i: int) =
        let rows = [
            "}"
            "{}}"
            "``{``}"
            "(*{*)}"
            "'{'}"
            "buff}"
        ]
        let txt = rows.[i]

        let iter =
            txt.ToCharArray()
            |> Array.map(fun ch -> ch, int ch)
            |> ArrayStack
            |> LexicalIterator.ofArrayStack

        let buff =
            Bootstrap.BracesLexerTailer.restBraces iter
            |> String.build

        output.WriteLine(stringify buff)
        output.WriteLine(stringify(iter.tryNext()))

        ()
