namespace FSharp.Substance

open Xunit
open FSharp.LexYacc

type TokenGenerationTest(output: ITestOutputHelper) =

    [<Fact>]
    member _.``生成FSharpToken模块``() =
        //只需列出与 union case 名不同的符号名称
        let symbols = [
            FSharpToken.BAR, "|"
            FSharpToken.BAR_RBRACE, "|}"
            FSharpToken.BAR_RBRACK, "|]"
            FSharpToken.COLON, ":"
            FSharpToken.COMMA, ","
            FSharpToken.DOT, "."
            FSharpToken.EQUALS, "="
            FSharpToken.GREATER, ">"
            FSharpToken.HASH, "#"
            FSharpToken.LBRACE, "{"
            FSharpToken.LBRACE_BAR, "{|"
            FSharpToken.LBRACK, "["
            FSharpToken.LBRACK_BAR, "[|"
            FSharpToken.LESS, "<"
            FSharpToken.LPAREN, "("
            FSharpToken.MINUS, "-"
            FSharpToken.RARROW, "->"
            FSharpToken.RBRACE, "}"
            FSharpToken.RBRACK, "]"
            FSharpToken.RPAREN, ")"
            FSharpToken.SEMICOLON, ";"
            FSharpToken.STAR, "*"
        ]

        let outp = DiscriminatedUnions.generate symbols
        output.WriteLine(outp)
