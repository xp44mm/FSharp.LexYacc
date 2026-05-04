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

    [<Fact>] //(Skip = "不必重复生成")
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
    member _.``getPosition GEN``() =
        let decls =
            ViablePrefix.declarations
            |> List.groupBy snd
            |> List.map(fun (typ, ls) ->
                let symbols = ls |> List.map fst |> List.sort
                symbols, typ
            )

        for symbols, typ in decls do
            for s in symbols do
                output.WriteLine("| " + stringify s)
            output.WriteLine($"  -> unbox<{stringifyTypeDynamic typ}> state.lexeme")

    [<Fact>]
    member _.``bnf collections``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        // precedes key可以是终结符号，也可以是非终结符号
        output.WriteLine("let follow_semicolon: string Set =")
        let follow_semicolon = bnf.follows.[";"].Remove "DUMMY"
        output.WriteLine("  " + stringify follow_semicolon)

        // precedes key是任意符号，
        let precede_declExpr: string Set = bnf.precedes.["declExpr"]
        output.WriteLine(
            "let precede_declExpr: string Set = "
            + stringify precede_declExpr
        )

        let first_declExpr: string Set = bnf.firsts.["declExpr"].Remove "DUMMY"
        output.WriteLine(
            "let first_declExpr: string Set = "
            + stringify first_declExpr
        )

        let first_valueExpr: string Set = bnf.firsts.["valueExpr"]
        output.WriteLine(
            "let first_valueExpr: string Set = "
            + stringify first_valueExpr
        )

    [<Fact>]
    member _.``viable prefix``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let tops: Map<string, ViablePrefix Set> =
            ViablePrefix.top bnf
            |> Seq.groupBy(fun v -> v.prefix.[0])
            |> Seq.map(fun (sym, sq) -> sym, set sq)
            |> Map.ofSeq

        output.WriteLine("let tops: Map<string, ViablePrefix Set> = Map [")
        for KeyValue(tok, ls) in tops do
            output.WriteLine(Line.indent 2 $"{stringify tok},set [")
            for vp in ls do
                output.WriteLine(Line.indent 4 (stringify vp))
            output.WriteLine(Line.indent 2 "]")
        output.WriteLine("]")

        let lookaheads: Map<string, ViablePrefix Set> =
            ViablePrefix.lookahead bnf
            |> Seq.groupBy snd
            |> Seq.map(fun (tok, sq) ->
                let ls = sq |> Seq.map fst |> Set.ofSeq
                tok, ls
            )
            |> Map.ofSeq

        output.WriteLine("let lookaheads: Map<string, ViablePrefix Set> = Map [")
        for KeyValue(tok, ls) in lookaheads do
            output.WriteLine(Line.indent 2 $"{stringify tok},set [")
            for vp in ls do
                output.WriteLine(Line.indent 4 (stringify vp))
            output.WriteLine(Line.indent 2 "]")
        output.WriteLine("]")
    [<Fact>]
    member _.``top prefixes``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let top_prefixes: Map<string list, string Set> =
            ViablePrefix.top bnf
            |> Seq.groupBy(fun v -> v.prefix)
            |> Seq.map(fun (prefix, sq) ->
                let heads = sq |> Seq.map(fun v -> v.head)
                prefix, set heads
            )
            |> Map.ofSeq

        output.WriteLine("let top_prefixes: Map<string list, string Set> = Map [")
        for KeyValue(prefix, heads) in top_prefixes do
            output.WriteLine($"  {stringify prefix},{stringify heads}")
        output.WriteLine("]")
