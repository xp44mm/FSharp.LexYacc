namespace FSharp.LexYacc.Bootstrap

open FSharp.Idioms.Literal

open FSharp.LexYacc

type FslexFilePrinter = {
    header: string
    anal: Analyzer
    ruler: RulerPrinter
} with
    /// 用于char lexer
    static member forChar(text: string) =
        let ast = FslexCompiler.compile text
        let patterns = ast.getPatterns(int)

        let anal = Analyzer.from patterns
        let ruler = RulerPrinter.from ast.ruler
        { header = ast.header; anal = anal; ruler = ruler }

    /// 用于Tag/string lexer
    static member forTag (tagToValue: string -> int) (text: string) =
        let ast = FslexTagCompiler.compile text
        let patterns = ast.getPatterns(tagToValue)

        let anal = Analyzer.from patterns
        let ruler: RulerPrinter = RulerPrinter.from ast.ruler
        { header = ast.header; anal = anal; ruler = ruler }

    member this.print() =
        [
            Braces.sliceContent this.header
            "let anal:Analyzer = " + stringify this.anal
            this.ruler.print()
        ]
        |> List.map(fun line -> line.TrimEnd())
        |> String.concat "\r\n"
