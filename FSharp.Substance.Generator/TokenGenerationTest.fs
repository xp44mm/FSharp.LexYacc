namespace FSharp.Substance

open Xunit
open FSharp.LexYacc
open FSharp.Idioms.Literal

type TokenGenerationTest(output: ITestOutputHelper) =
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


    [<Fact>]
    member _.``生成FSharpToken模块``() =
        let outp = DiscriminatedUnions.generate_module symbols
        output.WriteLine(outp)

    [<Fact>]
    member _.``生成Yacc文件中的typedef``() =
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

        let outp = DiscriminatedUnions.percent_type symbols
        output.WriteLine outp

    [<Fact>]
    member _.``生成 offside lexeme``() =
        let outp = DiscriminatedUnions.lexeme_offside<FSharpToken>
        output.WriteLine outp

    [<Fact>]
    member _.``生成 offside typedef``() =
        let outp = DiscriminatedUnions.percent_type_offside<FSharpToken> symbols
        output.WriteLine outp
