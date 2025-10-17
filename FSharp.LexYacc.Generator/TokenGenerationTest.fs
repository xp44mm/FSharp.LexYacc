namespace FSharp.LexYacc

open Xunit
open Xunit.Abstractions

open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap

type TokenGenerationTest (output: ITestOutputHelper) =

    [<Fact>]
    member _.``生成FslexToken代码``() =
        //只需列出与案例名不同的符号名称
        let symbols = [
            FslexToken.HYPHEN, "-"
            FslexToken.EQUALS, "="
            FslexToken.LPAREN, "("
            FslexToken.RPAREN, ")"
            FslexToken.LBRACK_CARET, "[^"
            FslexToken.LBRACK, "["
            FslexToken.RBRACK, "]"
            FslexToken.PLUS, "+"
            FslexToken.STAR, "*"
            FslexToken.SLASH, "/"
            FslexToken.BAR, "|"
            FslexToken.QMARK, "?"
            FslexToken.AMP, "&"
            FslexToken.COLON, ":"
        ]
        let src = DiscriminatedUnions.generate symbols
        output.WriteLine(src)

    [<Fact>]
    member _.``生成FsyaccToken代码``() =
        //只需列出与案例名不同的符号名称
        let symbols = [
            FsyaccToken.COLON, ":"
            FsyaccToken.BAR, "|"
            FsyaccToken.LEFTASSOC, "%left"
            FsyaccToken.RIGHTASSOC, "%right"
            FsyaccToken.NONASSOC, "%nonassoc"
            FsyaccToken.PREC, "%prec"
        ]

        let outp = DiscriminatedUnions.generate symbols
        output.WriteLine(outp)
