namespace FSharp.Substance

open Xunit
open FSharp.LexYacc
open FSharp.Idioms.Literal

type TokenGenerationTest(output: ITestOutputHelper) =
    let symbols = FSharpTokenData.symbols
    [<Fact>]
    member _.``生成FSharpToken模块``() =
        let outp = DiscriminatedUnions.generate_module symbols
        output.WriteLine(outp)

    [<Fact>]
    member _.``生成Yacc文件中的typedef``() =
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
