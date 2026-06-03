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
open System
open Microsoft.FSharp.Reflection

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

    [<Fact>]
    member _.``conflicted productions``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let prods = bnf.getConflictedProductions()

        if Set.isEmpty prods then
            output.WriteLine("no conflicted production.")
        else
            output.WriteLine("conflicted productions:")
            prods
            |> Set.iter(stringify >> output.WriteLine)

        Assert.Empty(prods)
        ()

    [<Fact>]
    member _.``declarations``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc

        let declarations =
            flatFsyacc.declarations
            |> FlatFsyaccFileUtils.printDeclarations

        output.WriteLine(declarations)

    [<Fact>]
    member _.``generate YaccStateInfo``() =
        let isPairAndFirstIsIntOption (t: Type) =
            if FSharpType.IsTuple t then
                let elements = FSharpType.GetTupleElements t
                elements.Length = 2
                && elements.[0] = typeof<option<int>>
            else
                false

        let isTripleAndFirstIsIntOption (t: Type) =
            if FSharpType.IsTuple t then
                let elements = FSharpType.GetTupleElements t
                elements.Length = 3
                && elements.[0] = typeof<option<int>>
            else
                false

        let isListType (t: Type) =
            t.IsGenericType
            && t.GetGenericTypeDefinition() = typedefof<list<_>>

        let isListOfPairAndFirstIsIntOption (t: Type) =
            if isListType t then
                let elementType = t.GetGenericArguments().[0]
                isPairAndFirstIsIntOption elementType
            else
                false

        // 特殊类型：嵌套元组 (option<int> * A) * list<option<int> * B>
        let isNestedTupleWithList (t: Type) =
            if FSharpType.IsTuple t then
                let elements = FSharpType.GetTupleElements t
                elements.Length = 2
                && isPairAndFirstIsIntOption elements.[0]
                && isListOfPairAndFirstIsIntOption elements.[1]
            else
                false

        // 特殊类型：list<(option<int> * A) * (option<int> * B)>
        let isListOfPairPair (t: Type) =
            if isListType t then
                let elementType = t.GetGenericArguments().[0]
                if FSharpType.IsTuple elementType then
                    let elements = FSharpType.GetTupleElements elementType
                    elements.Length = 2
                    && isPairAndFirstIsIntOption elements.[0]
                    && isPairAndFirstIsIntOption elements.[1]
                else
                    false
            else
                false

        // 生成 match 分支
        let generateBranch (symbols: string list) (typ: Type) =
            let symbolList =
                symbols
                |> List.map(fun s -> "| " + stringify s)
                |> String.concat " "

            match symbols, typ with
            | _, t when t = typeof<option<int>> ->
                [
                    symbolList
                    Line.indent 4 "->"
                    Line.indent 4 $"unbox<{stringifyTypeDynamic t}> state.lexeme, tag"
                ]

            | _, t when isPairAndFirstIsIntOption t ->
                [
                    symbolList
                    Line.indent 4 "->"
                    Line.indent 4 $"let i, d = unbox<{stringifyTypeDynamic t}> state.lexeme"
                    Line.indent 4 "i, stringify d"
                ]

            | _, t when isListOfPairAndFirstIsIntOption t ->
                [
                    symbolList
                    Line.indent 4 "->"
                    Line.indent 4 $"let ls = unbox<{stringifyTypeDynamic t}> state.lexeme"
                    Line.indent 4 "let i, ls = ls |> List.unzip"
                    Line.indent 4 "i.[0], stringify ls"
                ]

            | _, t when isTripleAndFirstIsIntOption t ->
                [
                    symbolList
                    Line.indent 4 "->"
                    Line.indent 4 $"let i, p, e = unbox<{stringifyTypeDynamic t}> state.lexeme"
                    Line.indent 4 "i, stringify(p, e)"
                ]

            | [ "file" ], t ->
                [
                    symbolList
                    Line.indent 4 "->"
                    Line.indent
                        4
                        $"None, stringifyDynamic typeof<{stringifyTypeDynamic t}> state.lexeme"
                ]

            | _, t when t = typeof<(option<int> * TypeArgument) * ((option<int> * SuffixType) list)> ->
                [
                    symbolList
                    Line.indent 4 "->"
                    Line.indent
                        4
                        $"let (i, targ), ls = unbox<{stringifyTypeDynamic t}> state.lexeme"
                    Line.indent 4 "let ls = ls |> List.map snd"
                    Line.indent 4 "i, stringify(targ, ls)"

                ]

            | _, t when t = typeof<((option<int> * string) * (option<int> * Expr)) list> ->
                [
                    symbolList
                    Line.indent 4 "->"
                    Line.indent 4 $"let ls = unbox<{stringifyTypeDynamic t}> state.lexeme"
                    Line.indent 4 "let i = ls |> Seq.map(fun (a, _) -> fst a) |> Seq.head"
                    Line.indent 4 "let data = ls |> List.map(fun (a, b) -> snd a, snd b)"
                    Line.indent 4 "i, stringify data"
                ]

            | _, t ->
                [
                    symbolList
                    Line.indent 4 "->"
                    Line.indent 4 $"let obj = unbox<{stringifyTypeDynamic t}> state.lexeme"
                    Line.indent 4 "None"
                ]

        let decls =
            FsYaccData.declarations
            |> List.groupBy snd
            |> List.map(fun (typ, ls) ->
                let symbols = ls |> List.map fst |> List.sort
                symbols, typ
            )

        for symbols, typ in decls do
            generateBranch symbols typ
            |> List.map(Line.indent 12)
            |> List.iter(fun l -> output.WriteLine(l))

    [<Fact>]
    member _.``check bnf``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc

        let analysis = BnfAnalysisRecord.Create(flatFsyacc)

        output.WriteLine(
            $"let orphan_bnf = "
            + stringify analysis.OrphanBnf
        )
        output.WriteLine(
            $"let absence_decl = "
            + stringify analysis.AbsenceDecl
        )
        output.WriteLine(
            $"let orphan_decl = "
            + stringify analysis.OrphanDecl
        )

    [<Fact>]
    member _.``LookaheadConfig and TopConfig``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf
        let names = Light.nameofsymbols

        let comp =
            bnf.terminals
            - Light.important
            - Light.famous
        let sq =
            [
                Light.important
                Light.famous
                comp
            ]

        //output.WriteLine(stringify impr)
        //output.WriteLine(stringify comp)

        Configuration.generateAllConfigs_many bnf names sq Dir.main
        output.WriteLine("ok! 成功")

    [<Fact>]
    member _.``Grammar Data``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let outputPath = Path.Combine(Dir.main, "GrammarData.fs")
        use writer = new StreamWriter(outputPath, false, Encoding.UTF8)
        writer.WriteLine("module FSharp.Substance.GrammarData")

        // precedes key可以是终结符号，也可以是非终结符号
        writer.WriteLine("let follow_semicolon: string Set =")
        let follow_semicolon = bnf.follows.[";"]
        writer.WriteLine("  " + stringify follow_semicolon)

        writer.WriteLine("let precede_semicolon: string Set =")
        let precede_semicolon = bnf.precedes.[";"]
        writer.WriteLine("  " + stringify precede_semicolon)

        let precede_declExpr: string Set = bnf.precedes.["declExpr"]
        writer.WriteLine(
            "let precede_declExpr: string Set = "
            + stringify precede_declExpr
        )

        let first_declExpr: string Set = bnf.firsts.["declExpr"]
        writer.WriteLine(
            "let first_declExpr: string Set = "
            + stringify first_declExpr
        )

        let first_valueExpr: string Set = bnf.firsts.["valueExpr"]
        writer.WriteLine(
            "let first_valueExpr: string Set = "
            + stringify first_valueExpr
        )

        let appExprSymbol = "appExpr"
        let f = bnf.firsts.[appExprSymbol]
        let l = bnf.lasts.[appExprSymbol]

        writer.WriteLine($"let first_appExpr = {stringify f}")
        writer.WriteLine($"let last_appExpr = {stringify l}")

    [<Fact>]
    member _.``viable prefix``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let outputPath = Path.Combine(Dir.main, "ViablePrefix.fs")
        use writer = new StreamWriter(outputPath, false, Encoding.UTF8)

        writer.WriteLine("module FSharp.Substance.ViablePrefix")
        writer.WriteLine("let module_statement: string list Set = set [")
        let module_statement =
            BnfUtils.derive
                bnf
                [
                    "longid"
                    "MODULE"
                ]
        for prefix in module_statement do
            writer.WriteLine($"  {stringify prefix}")
        writer.WriteLine("]")

        writer.WriteLine("let atomicExpr: string list Set = set [")
        let atomicExpr = BnfUtils.derive bnf [ "atomicExpr" ]
        for prefix in atomicExpr do
            writer.WriteLine($"  {stringify prefix}")
        writer.WriteLine("]")

        writer.WriteLine("let tupleExpr: string list Set = set [")
        let tupleExpr = BnfUtils.derive bnf [ "tupleExpr" ]
        for prefix in tupleExpr do
            writer.WriteLine($"  {stringify prefix}")
        writer.WriteLine("]")

        writer.WriteLine("let valueExpr: string list Set = set [")
        let valueExpr = BnfUtils.derive bnf [ "valueExpr" ]
        for prefix in valueExpr do
            writer.WriteLine($"  {stringify prefix}")
        writer.WriteLine("]")

        writer.WriteLine("let declExpr: string list Set = set [")
        let declExpr = BnfUtils.derive bnf [ "declExpr" ]
        for prefix in declExpr do
            writer.WriteLine($"  {stringify prefix}")
        writer.WriteLine("]")
