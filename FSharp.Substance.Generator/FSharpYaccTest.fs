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
    member _.``规范化bnf``() =
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
    member _.``viable prefix``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        // precedes key可以是终结符号，也可以是非终结符号
        output.WriteLine("let follow_semicolon: string Set =")
        let follow_semicolon = bnf.follows.[";"]
        output.WriteLine("  " + stringify follow_semicolon)

        output.WriteLine("let precede_semicolon: string Set =")
        let precede_semicolon = bnf.precedes.[";"]
        output.WriteLine("  " + stringify precede_semicolon)

        let precede_declExpr: string Set = bnf.precedes.["declExpr"]
        output.WriteLine(
            "let precede_declExpr: string Set = "
            + stringify precede_declExpr
        )

        let first_declExpr: string Set = bnf.firsts.["declExpr"]
        output.WriteLine(
            "let first_declExpr: string Set = "
            + stringify first_declExpr
        )

        let first_valueExpr: string Set = bnf.firsts.["valueExpr"]
        output.WriteLine(
            "let first_valueExpr: string Set = "
            + stringify first_valueExpr
        )

        let appExprSymbol = "appExpr"
        let f = bnf.firsts.[appExprSymbol]
        let l = bnf.lasts.[appExprSymbol]

        output.WriteLine($"let first_appExpr = {stringify f}")
        output.WriteLine($"let last_appExpr = {stringify l}")

        output.WriteLine("let module_statement: string list Set = set [")
        let module_statement =
            BnfUtils.derive
                bnf
                [
                    "longid"
                    "MODULE"
                ]
        for prefix in module_statement do
            output.WriteLine($"  {stringify prefix}")
        output.WriteLine("]")

        output.WriteLine("let open_statement: string list Set = set [")
        let open_statement =
            BnfUtils.derive
                bnf
                [
                    "longid"
                    "OPEN"
                ]
        for prefix in open_statement do
            output.WriteLine($"  {stringify prefix}")
        output.WriteLine("]")

        //下面是前缀部分

        let tops: Map<string list, string Set> =
            ViablePrefix.top bnf
            |> Seq.groupBy(fun v -> v.prefix)
            |> Seq.map(fun (prefix, sq) ->
                let heads = sq |> Seq.map(fun v -> v.head)
                prefix, set heads
            )
            |> Map.ofSeq

        let lookaheads: Map<string, ViablePrefix Set> =
            ViablePrefix.lookahead bnf
            |> Seq.groupBy snd
            |> Seq.map(fun (tok, sq) ->
                let ls = sq |> Seq.map fst |> Set.ofSeq
                tok, ls
            )
            |> Map.ofSeq

        let lookahead_rparen: Set<string list> =
            lookaheads.[FSharpToken.tag RPAREN]
            |> Set.map(fun v -> v.prefix)
        output.WriteLine("let lookahead_rparen: Set<string list> = set [")
        for item in lookahead_rparen do
            output.WriteLine($"  {stringify item}")
        output.WriteLine("]")

        let lookahead_rbrack: Set<string list> =
            lookaheads.[FSharpToken.tag RBRACK]
            |> Set.map(fun v -> v.prefix)

        output.WriteLine("let lookahead_rbrack: Set<string list> = set [")
        for item in lookahead_rbrack do
            output.WriteLine($"  {stringify item}")
        output.WriteLine("]")

        let lookahead_bar_rbrack: Set<string list> =
            lookaheads.[FSharpToken.tag BAR_RBRACK]
            |> Set.map(fun v -> v.prefix)

        output.WriteLine("let lookahead_bar_rbrack: Set<string list> = set [")
        for item in lookahead_bar_rbrack do
            output.WriteLine($"  {stringify item}")
        output.WriteLine("]")

        let lookahead_rbrace: Set<string list> =
            lookaheads.[FSharpToken.tag RBRACE]
            |> Set.map(fun v -> v.prefix)

        output.WriteLine("let lookahead_rbrace: Set<string list> = set [")
        for item in lookahead_rbrace do
            output.WriteLine($"  {stringify item}")
        output.WriteLine("]")

        let lookahead_bar: Set<string list> =
            lookaheads.[FSharpToken.tag BAR]
            |> Set.map(fun v -> v.prefix)

        output.WriteLine("let lookahead_bar: Set<string list> = set [")
        for item in lookahead_bar do
            output.WriteLine($"  {stringify item}")
        output.WriteLine("]")

        //下面是需要拼接的栈顶前缀
        let tops =
            [ "fieldBinding" ]
            |> List.map(fun top -> Deeper.top_entry tops top)
            |> Map.ofList

        let lookahead_llparen: Set<string list> =
            ViablePrefixes.cons(lookaheads.[FSharpToken.tag LLPAREN], tops)
            |> Set.map(fun v -> v.prefix)

        output.WriteLine("let lookahead_llparen: Set<string list> = set [")
        for vp in lookahead_llparen do
            output.WriteLine(Line.indent 2 (stringify vp))
        output.WriteLine("]")

        let lookahead_rhsend: Set<string list> =
            ViablePrefixes.cons(lookaheads.[FSharpToken.tag RHSEND], tops)
            |> Set.map(fun v -> v.prefix)

        output.WriteLine("let lookahead_rhsend: Set<string list> = set [")
        for vp in lookahead_rhsend do
            output.WriteLine(Line.indent 2 (stringify vp))
        output.WriteLine("]")

        let lookahead_rrparen: Set<string list> =
            ViablePrefixes.cons(lookaheads.[FSharpToken.tag RRPAREN], tops)
            |> Set.map(fun v -> v.prefix)

        output.WriteLine("let lookahead_rrparen: Set<string list> = set [")
        for vp in lookahead_rrparen do
            output.WriteLine(Line.indent 2 (stringify vp))
        output.WriteLine("]")

    [<Fact>]
    member _.``LookaheadConfig``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let lookaheads: list<string Set * string * string list> =
            bnf
            |> ViablePrefix.lookahead
            |> Seq.map(fun (v, la) ->
                let hd = v.head
                let px = v.prefix
                hd, la, px
            )
            |> Seq.groupBy(fun (hd, la, px) -> la, px)
            |> Seq.map(fun ((la, px), sq) ->
                let hds =
                    sq
                    |> Seq.map(fun (hd, la, px) -> hd)
                    |> Set.ofSeq
                hds, la, px
            )
            |> Seq.toList

        let groups =
            lookaheads
            |> List.groupBy(fun (hds, la, px) -> la)
            |> List.map(fun (la, ls) ->
                let ls: (string list * string Set) list =
                    ls
                    |> List.map(fun (hds, la, px) -> px, hds)
                la, ls
            )
        let names = FSharpTokenData.nameofsymbols

        // 指定输出文件路径
        let filePath = Path.Combine(Dir.main, "LookaheadConfig.fs")
        use writer = new StreamWriter(filePath, false, Encoding.UTF8)

        writer.WriteLine("module FSharp.Substance.LookaheadConfig")
        for la, ls in groups do
            let ident =
                if names.ContainsKey la then
                    names.[la]
                else
                    la
            writer.WriteLine($"let {ident}: list<string list * string Set> = [")
            for item in ls do
                writer.WriteLine(Line.indent 2 (stringify item))
            writer.WriteLine("]")

        writer.WriteLine($"let catalog: Map<string, _ > = Map [")
        for la, ls in groups do
            let ident =
                if names.ContainsKey la then
                    names.[la]
                else
                    la
            writer.WriteLine(Line.indent 2 $"{stringify ident}, {ident}")
        writer.WriteLine("]")
        output.WriteLine($"output:\r\n{filePath}")

    [<Fact>]
    member _.``TopConfig``() =
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc
        let yacc = flatFsyacc.getYacc()
        let bnf: BNF = yacc.bnf

        let tops: list<string Set * string * string list> =
            bnf
            |> ViablePrefix.top

            |> Seq.map(fun v ->
                let hd = v.head
                let top = v.prefix.[0]
                let px = v.prefix.Tail
                hd, top, px
            )
            |> Seq.groupBy(fun (hd, tp, px) -> tp, px)
            |> Seq.map(fun ((tp, px), sq) ->
                let hds =
                    sq
                    |> Seq.map(fun (hd, tp, px) -> hd)
                    |> Set.ofSeq
                hds, tp, px
            )
            |> Seq.toList

        let groups =
            tops
            |> List.groupBy(fun (hds, tp, px) -> tp)
            |> List.map(fun (tp, ls) ->
                let ls: (string list * string Set) list =
                    ls
                    |> List.map(fun (hds, tp, px) -> px, hds)
                tp, ls
            )
        let names = FSharpTokenData.nameofsymbols

        // 指定输出文件路径
        let filePath = Path.Combine(Dir.main, "TopConfig.fs")
        use writer = new StreamWriter(filePath, false, Encoding.UTF8)

        writer.WriteLine("module FSharp.Substance.TopConfig")
        for tp, ls in groups do
            let ident =
                if names.ContainsKey tp then
                    names.[tp]
                else
                    tp
            writer.WriteLine($"let {ident}: list<string list * string Set> = [")
            for item in ls do
                writer.WriteLine(Line.indent 2 (stringify item))
            writer.WriteLine("]")

        writer.WriteLine($"let catalog: Map<string, _ > = Map [")
        for tp, ls in groups do
            let ident =
                if names.ContainsKey tp then
                    names.[tp]
                else
                    tp
            writer.WriteLine(Line.indent 2 $"{stringify ident}, {ident}")
        writer.WriteLine("]")
        output.WriteLine($"output:\r\n{filePath}")
