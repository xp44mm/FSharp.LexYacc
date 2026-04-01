namespace FSharp.Substance

open Xunit
open FSharp.xUnit
open FSharp.Idioms.Literal

open System.IO
open System.Text
open System.Reflection

type LightTest(output: ITestOutputHelper) =

    [<Fact>]
    member _.``TestData test``() =
        let x = [
            NEW_LINE 0
            MODULE
            WHITESPACE
            IDENT "FSharp"
            DOT
            IDENT "RfcJson"
            DOT
            IDENT "JsonLexer"
            NEW_LINE 0
            OPEN
            WHITESPACE
            IDENT "System"
            NEW_LINE 0
            OPEN
            WHITESPACE
            IDENT "FSharp"
            DOT
            IDENT "Idioms"
            NEW_LINE 0
            OPEN
            WHITESPACE
            IDENT "FSharp"
            DOT
            IDENT "Idioms"
            DOT
            IDENT "Literal"
            NEW_LINE 0
            OPEN
            WHITESPACE
            IDENT "FSharp"
            DOT
            IDENT "LexYacc"
            NEW_LINE 0
            OPEN
            WHITESPACE
            IDENT "FSharp"
            DOT
            IDENT "LexYacc"
            DOT
            IDENT "Bootstrap"
        ]
        let y = Light.transform x |> Seq.toList
        output.WriteLine(stringify y)
        let e = [
            Some 0, MODULE
            None, WHITESPACE
            None, IDENT "FSharp"
            None, DOT
            None, IDENT "RfcJson"
            None, DOT
            None, IDENT "JsonLexer"
            Some 0, OPEN
            None, WHITESPACE
            None, IDENT "System"
            Some 0, OPEN
            None, WHITESPACE
            None, IDENT "FSharp"
            None, DOT
            None, IDENT "Idioms"
            Some 0, OPEN
            None, WHITESPACE
            None, IDENT "FSharp"
            None, DOT
            None, IDENT "Idioms"
            None, DOT
            None, IDENT "Literal"
            Some 0, OPEN
            None, WHITESPACE
            None, IDENT "FSharp"
            None, DOT
            None, IDENT "LexYacc"
            Some 0, OPEN
            None, WHITESPACE
            None, IDENT "FSharp"
            None, DOT
            None, IDENT "LexYacc"
            None, DOT
            None, IDENT "Bootstrap"
        ]

        Should.equal e y
        ()
