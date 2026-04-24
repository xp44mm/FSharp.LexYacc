namespace FSharp.Substance

open Xunit
open FSharp.xUnit

open FSharp.Idioms
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
open FSharp.Substance

open System.IO
open System.Text
open FSharp.Idioms.Literal

type FSharpYaccTest(output: ITestOutputHelper) as this =
    let name =
        let x = this.GetType().Name
        x.Substring(0, x.Length - "YaccTest".Length)

    let srcPath = Path.Combine(__SOURCE_DIRECTORY__, name + ".fsyacc")
    let text = File.ReadAllText(srcPath, Encoding.UTF8)

    [<Fact(Skip = "节约时间")>]
    member _.``验证生成的文件是否和定义一致``() =
        // actual
        let stateSymbols = FSharpYacc.stateSymbols
        let actions = FSharpYacc.actions
        let rules = FSharpYacc.rules

        // expect
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yaccFile = FsyaccFilePrinter.from flatFsyacc

        // compare
        Should.equal yaccFile.stateSymbols stateSymbols
        Should.equal yaccFile.actions actions

        let productions1 = yaccFile.rules |> List.map fst
        let productions2 = rules |> List.map fst
        Should.equal productions1 productions2

        // todo: header 比较
        // todo: actions 比较

        ()

    [<Fact(Skip = "不必重复生成")>] //
    member _.``生成``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc

        let yaccFile = FsyaccFilePrinter.from flatFsyacc

        let src = yaccFile.printYaccModule(flatFsyacc.header)
        //output.WriteLine(src)

        let path = Path.Combine(Dir.main, name + "Yacc.fs")
        File.WriteAllText(path, src, Encoding.UTF8)
        output.WriteLine($"output:\r\n{path}")
        ()

    [<Fact>]
    member _.``conflicted productions``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let prods =
            bnf.getConflictedProductions()
            |> Set.toList
        match prods with
        | [] -> output.WriteLine("no conflicted productions.")
        | _ ->
            output.WriteLine("conflicted productions:")
            for cp in prods do
                output.WriteLine($"{stringify cp}")

    [<Fact>]
    member _.``declarations``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc

        let declarations =
            flatFsyacc.declarations
            |> FlatFsyaccFileUtils.printDeclarations

        output.WriteLine(declarations)

    [<Fact>]
    member _.``gen getPosition``() =
        let decls =
            RightSententialForm.declarations
            |> List.groupBy snd
            |> List.map(fun (typ, ls) ->
                let symbols = ls |> List.map fst |> List.sort
                symbols, typ
            )

        for symbols, typ in decls do
            for s in symbols do
                output.WriteLine("| "+stringify s)
            output.WriteLine($"  -> unbox<{stringifyTypeDynamic typ}> state.lexeme")

    [<Fact>]
    member _.``precede declExpr``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf
        // precedes key是任意符号，
        let declExpr = bnf.precedes.["declExpr"] |> Set.toList
        output.WriteLine(stringify declExpr)

    [<Fact>]
    member _.``derive declExpr``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf
        let derivations =
            BnfUtils.derive bnf [ "declExpr" ]
            |> Set.toList
            |> List.sortDescending

        output.WriteLine("let declExpr = [")
        for derivation in derivations do
            output.WriteLine("    " + stringify derivation)
        output.WriteLine("]")

    [<Fact>]
    member _.``first atomicExpr``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let symbol = "atomicExpr"
        let st = bnf.firsts.[symbol]
        for prod in st do
            output.WriteLine(stringify prod)

    [<Fact>]
    member _.``first declExpr``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let symbol = "declExpr"
        let st = bnf.firsts.[symbol] // - bnf.firsts.["atomicExpr"]
        for prod in st do
            output.WriteLine(stringify prod)

    [<Fact>]
    member _.``viable prefix lookaheads``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let lookaheads = ViablePrefix.lookahead bnf
        output.WriteLine("let lookaheads = [")
        for la in lookaheads do
            output.WriteLine("  " + stringify la)
        output.WriteLine("]")

    [<Fact>]
    member _.``viable prefix tops``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let tops = ViablePrefix.top bnf
        output.WriteLine("let tops = [")
        for tp in tops do
            output.WriteLine("  " + stringify tp)
        output.WriteLine("]")

    [<Fact>]
    member _.``derive OPEN longid``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf
        let derivations =
            BnfUtils.derive bnf [ "longid" ; "OPEN"]
            |> Set.toList

        output.WriteLine("let open_longid = [")
        for derivation in derivations do
            output.WriteLine("    " + stringify derivation)
        output.WriteLine("]")
