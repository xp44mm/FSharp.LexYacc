namespace FSharp.Substance

open Xunit
open FSharp.LexYacc
open FSharp.Idioms.Literal
open FSharp.Idioms

type TokenGenerationTest(output: ITestOutputHelper) =
    let symbols = FSharpToken.symbols

    /// 生成token模块中的常用方法
    let generate_module_FSharpToken (symbols: (FSharpToken * string) list) =
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

        [
            $"module {typeof<FSharpToken>.Name} ="
            yield! content |> List.map(Line.indent 4)
        ]
        |> String.concat "\r\n"

    [<Fact>]
    member _.``生成FSharpToken模块``() =
        let outp = generate_module_FSharpToken symbols
        output.WriteLine(outp)

    [<Fact>]
    member _.``生成 offside typedef``() =
        let outp = DiscriminatedUnions.percent_type_offside_group<FSharpToken> symbols
        output.WriteLine outp

    //[<Fact>]
    //member _.``生成Yacc文件中的typedef``() =
    //    let outp = DiscriminatedUnions.percent_type symbols
    //    output.WriteLine outp

    //[<Fact>]
    //member _.``生成 offside lexeme``() =
    //    let outp = 
    //        DiscriminatedUnions.lexeme_offside<FSharpToken>
    //        |> String.concat "\r\n"

    //    output.WriteLine outp
