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

    [<Fact>]
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

    [<Fact>] //(Skip = "没有改变，不必重复生成")
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
    member _.``derive declExpr``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let revSymbols = [ "declExpr" ]
        let st =
            BnfUtils.derive bnf revSymbols
            |> Set.toList
            |> List.sortDescending

        for prod in st do
            output.WriteLine(stringify prod)

    [<Fact>]
    member _.``derive Left Of LLPAREN``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let symbol = "rhsBlock" // LLPAREN = first rhsBlock
        let st = BnfUtils.deriveLeftOfSymbol bnf symbol
        for prod in st do
            output.WriteLine(stringify prod)

    [<Fact>]
    member _.``derive Left Of RHSEND``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let terminal = "RHSEND"
        let st = BnfUtils.deriveLeftOfSymbol bnf terminal
        for prod in st do
            output.WriteLine(stringify prod)

    [<Fact>]
    member _.``derive Left Of RRPAREN``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let terminal = "RRPAREN"
        let st = BnfUtils.deriveLeftOfSymbol bnf terminal
        for prod in st do
            output.WriteLine(stringify prod)

    [<Fact>]
    member _.``derive Left Of RRPAREN and RHSEND``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let rrparen =
            BnfUtils.deriveLeftOfSymbol bnf "RRPAREN"
            |> Set.map(fun prod -> prod, RRPAREN)

        let rhsend =
            BnfUtils.deriveLeftOfSymbol bnf "RHSEND"
            |> Set.map(fun prod -> prod, RHSEND)

        //收尾符号升序排列，优先匹配最短的产生式
        let ls = rrparen + rhsend |> Set.toList

        for prod in ls do
            output.WriteLine(stringify prod)

    [<Fact>]
    member _.``declarations``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc

        let declarations =
            flatFsyacc.declarations
            |> FlatFsyaccFileUtils.printDeclarations

        output.WriteLine(declarations)

    [<Fact>]
    member _.``符号类型``() =
        //let rawFsyacc = FsyaccCompiler.compile text
        //let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        //let decls =
        //    flatFsyacc.declarations
        //    |> Seq.groupBy(fun kvp -> kvp.Value)
        //    |> Seq.map(fun (typename, sq) ->
        //        let symbols =
        //            sq
        //            |> Seq.map(fun kvp -> kvp.Key)
        //            |> Seq.toList
        //        symbols,typename
        //    )

        //避免因为书写格式不同多出分组
        let decls =
            RightSententialForm.declarations
            |> List.groupBy snd
            |> List.map(fun (typ, ls) ->
                let symbols = ls |> List.map fst
                symbols, typ
            )

        for symbols, typ in decls do
            output.WriteLine(stringify symbols)
            output.WriteLine(stringifyTypeDynamic typ)

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
        let st = bnf.firsts.[symbol]// - bnf.firsts.["atomicExpr"]
        for prod in st do
            output.WriteLine(stringify prod)

    [<Fact>]
    member _.``derive declExpr lookahead of semicolon rrparen rhsend``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let revAppExpr =
            BnfUtils.derive bnf [ "revAppExpr" ]

        // lookahead semicolon
        let declExpr =
            BnfUtils.derive bnf [ "declExpr" ]
            |> Set.toList

        //output.WriteLine("declExpr")
        //for prod in declExpr do
        //    output.WriteLine(stringify prod)

        // lookahead RHSEND
        let rhsend =
            declExpr
            |> List.choose(fun ls ->
                match ls with
                | "RHSEND" :: t -> Some t
                | _ -> None
            )
            |> List.collect(fun leftPart ->
                BnfUtils.derive bnf leftPart
                |> Set.toList
            )

        //output.WriteLine("RHSEND")
        //for prod in rhsend do
        //    output.WriteLine(stringify prod)

        // lookahead RRPAREN
        let rrparen =
            declExpr
            |> List.choose(fun ls ->
                match ls with
                | "RRPAREN" :: t -> Some t
                | _ -> None
            )
            |> List.collect(fun leftPart ->
                BnfUtils.derive bnf leftPart
                |> Set.toList
            )
        //output.WriteLine("RRPAREN")
        //for prod in rrparen do
        //    output.WriteLine(stringify prod)
        let res =
            [
                yield!
                    declExpr
                    |> Seq.map(fun prod -> 
                        if revAppExpr.Contains prod then
                            prod, WHITESPACE // 代替app运算
                        else
                            // 代替declExpr完成
                            prod, SEMICOLON)
                yield!
                    rhsend
                    |> Seq.map(fun prod -> prod, RHSEND)
                yield!
                    rrparen
                    |> Seq.map(fun prod -> prod, RRPAREN)
            ]
            |> List.sort

        for item in res do
            output.WriteLine(stringify item)


    [<Fact>]
    member _.``reduce Left Of semicolon``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let st = BnfUtils.reduceLeftOfSymbol bnf ";"
        for prod in st do
            output.WriteLine(stringify prod)


