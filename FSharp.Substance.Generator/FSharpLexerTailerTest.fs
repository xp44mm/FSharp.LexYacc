namespace FSharp.Substance

open Xunit

open FSharp.xUnit
open FSharp.Idioms.Literal

open System.IO
open System.Text
open System
open FSharp.LexYacc
open FSharp.Idioms

type FSharpLexerTailerTest(output: ITestOutputHelper) =

    [<Theory>]
    [<Natural(16)>]
    member _.``tokenize test``(i: int) =
        let rows = [
            "\n  ", NEW_LINE 2
            " ", WHITESPACE
            ".", DOT
            "0y", LITERAL(Literal.INT8 0y)
            "0s", LITERAL(Literal.INT16 0s)
            "0", LITERAL(Literal.INT32 0)
            "0L", LITERAL(Literal.INT64 0L)
            "0uy", LITERAL(Literal.UINT8 0uy)
            "0us", LITERAL(Literal.UINT16 0us)
            "0u", LITERAL(Literal.UINT32 0u)
            "0uL", LITERAL(Literal.UINT64 0uL)
            "0.0", LITERAL(Literal.FLOAT 0.0)
            "0.0f", LITERAL(Literal.SINGLE 0.0f)
            "'c'", LITERAL(Literal.CHAR 'c')
            "\"\"", LITERAL(Literal.STRING "")
            "_", IDENT("_")
            "'c", TYPAR("'c")
        ]

        let txt, exp = rows.[i]
        output.WriteLine(stringify txt)
        let iter =
            txt.ToCharArray()
            |> Array.map(fun ch -> ch, int ch)
            |> ArrayStack
            |> LexicalIterator.ofArrayStack

        let tok = FSharpLexerTailer.tokenize iter |> Seq.head

        output.WriteLine(stringify txt)
        output.WriteLine(stringify tok)
        Should.equal exp tok
        ()

    [<Theory>]
    [<InlineData("JsonLexer")>]
    [<InlineData("JsonYacc")>]
    member _.``real file lex test``(file: string) =
        let root =
            @"D:\Application Data\GitHub\xp44mm\FSharp.RfcJson\FSharp.RfcJson\"
        let path = Path.Combine(root, file + ".fs")
        let text = File.ReadAllText(path, Encoding.UTF8)
        let iter =
            //text.ToCharArray()
            //|> Array.map(fun ch -> ch, int ch)
            //|> ArrayStack
            //|> LexicalIterator.ofArrayStack
            $"\n{text}" |> LexicalIterator.forChar

        let tokens = FSharpLexerTailer.tokenize iter |> Seq.toList
        for tok in tokens do
            output.WriteLine(stringify tok)
