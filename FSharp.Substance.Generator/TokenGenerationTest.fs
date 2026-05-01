namespace FSharp.Substance

open Xunit
open FSharp.LexYacc
open FSharp.Idioms.Literal

type TokenGenerationTest(output: ITestOutputHelper) =
    //只需列出与 union case 名不同的符号名称
    let symbols = [
        FSharpToken.AMP, "&"
        FSharpToken.AMP_AMP, "&&"
        //FSharpToken.AMP_AMP_AMP, "&&&"
        FSharpToken.AT, "@"
        FSharpToken.BAR, "|"
        FSharpToken.BAR_BAR, "||"
        //FSharpToken.BAR_BAR_BAR, "|||"
        FSharpToken.BAR_BAR_BAR_GREATER, "|||>"
        FSharpToken.BAR_BAR_GREATER, "||>"
        FSharpToken.BAR_RBRACE, "|}"
        FSharpToken.BAR_RBRACK, "|]"
        FSharpToken.BAR_RPAREN, "|)"
        //FSharpToken.CARET_CARET_CARET, "^^^"
        FSharpToken.COLON, ":"
        FSharpToken.COLON_COLON, "::"
        FSharpToken.COLON_QMARK, ":?"
        FSharpToken.COLON_QMARK_GREATER, ":?>"
        FSharpToken.COMMA, ","
        FSharpToken.DIV, "/"
        FSharpToken.DOT, "."
        FSharpToken.DOT_DOT, ".."
        //FSharpToken.DOT_DOT_DOT, "..."
        FSharpToken.EQUALS, "="
        FSharpToken.EXCLAM, "!"
        FSharpToken.GREATER, ">"
        FSharpToken.GREATER_GREATER, ">>"
        //FSharpToken.GREATER_GREATER_GREATER, ">>>"
        FSharpToken.HASH, "#"
        FSharpToken.LARROW, "<-"
        FSharpToken.LBRACE, "{"
        FSharpToken.LBRACE_BAR, "{|"
        FSharpToken.LBRACK, "["
        FSharpToken.LBRACK_BAR, "[|"
        FSharpToken.LESS, "<"
        FSharpToken.LESS_BAR_BAR, "<||"
        FSharpToken.LESS_BAR_BAR_BAR, "<|||"
        FSharpToken.LESS_GREATER, "<>"
        FSharpToken.LESS_LESS, "<<"
        //FSharpToken.LESS_LESS_LESS, "<<<"
        FSharpToken.LPAREN, "("
        FSharpToken.LPAREN_BAR, "(|"
        FSharpToken.LPIPE, "<|"
        FSharpToken.MINUS, "-"
        FSharpToken.PERCENT, "%"
        FSharpToken.PLUS, "+"
        FSharpToken.RARROW, "->"
        FSharpToken.RBRACE, "}"
        FSharpToken.RBRACK, "]"
        FSharpToken.RPAREN, ")"
        FSharpToken.RPIPE, "|>"
        FSharpToken.SEMICOLON, ";"
        FSharpToken.STAR, "*"    
        FSharpToken.STAR_STAR, "**"
        //FSharpToken.TILDE_TILDE_TILDE, "~~~"
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
        let outp = DiscriminatedUnions.percent_type_offside_group<FSharpToken> symbols
        output.WriteLine outp
