namespace FSharp.Substance

open Xunit
open FSharp.LexYacc
open FSharp.Idioms.Literal
open FSharp.Idioms

type TokenGenerationTest(output: ITestOutputHelper) =
    let symbols = FSharpToken.symbols

    [<Fact>]
    member _.``生成FSharpToken模块``() =
        let content =
            [
                DiscriminatedUnions.symbol_entries symbols            
                DiscriminatedUnions.module_index<FSharpToken>
                DiscriminatedUnions.module_tag symbols
                DiscriminatedUnions.module_tagToIndex symbols
                DiscriminatedUnions.module_lexeme<FSharpToken>
                DiscriminatedUnions.lexeme_offside<FSharpToken>
            ]
            |> List.concat
        let outp = 
            [
                $"module {typeof<FSharpToken>.Name} ="
                yield! content |> List.map(Line.indent 4)
            ]
            |> String.concat "\r\n"

        output.WriteLine(outp)

    [<Fact>]
    member _.``生成 offside typedef``() =
        let outp = DiscriminatedUnions.percent_type_offside_group<FSharpToken> symbols
        output.WriteLine outp

