module FSharp.LexYacc.Configuration

open System.IO
open System.Text

open FSharp.Idioms
open FSharp.Idioms.Literal

let get_items (names: Map<string, string>) (groups: Map<string, Set<string list * string Set>>) =
    groups
    |> Seq.map(fun (KeyValue(key, itemList)) ->
        let ident =
            if names.ContainsKey key then
                names.[key]
            else
                key
        ident, key, itemList
    )
    |> Seq.sortBy(fun (ident, symbol, items) -> ident.ToLowerInvariant())

/// 将项写入文件的辅助函数
let private writeItems
    (writer: StreamWriter)
    (items: seq<string * string * Set<string list * string Set>>)
    =

    for (ident, symbol, sub_items) in items do
        if ident <> symbol then
            writer.WriteLine($"// {stringify symbol}")
        writer.WriteLine($"let {ident}: list<string list * string Set> = [")
        for item in sub_items do
            writer.WriteLine(Line.indent 2 (stringify item))
        writer.WriteLine("]")
        writer.WriteLine()

/// 写入 catalog 的辅助函数
let private writeCatalog
    (writer: StreamWriter)
    (items: seq<string * string * Set<string list * string Set>>)
    =
    writer.WriteLine("let catalog: Map<string, _ > = Map [")
    for (ident, symbol, _) in items do
        writer.Write(Line.indent 2 $"{stringify ident}, {ident}")
        if ident <> symbol then
            writer.WriteLine($"// {stringify symbol}")
        else
            writer.WriteLine()
    writer.WriteLine("]")

/// 
let generateLookaheadConfig (bnf: BNF) (names: Map<string, string>) (outputPath: string) =
    let groups = ViablePrefixData.getLookaheads bnf
    let items = get_items names groups
    use writer = new StreamWriter(outputPath, false, Encoding.UTF8)
    writer.WriteLine("module FSharp.Substance.LookaheadConfig")
    writer.WriteLine()
    writeItems writer items
    writer.WriteLine()
    writeCatalog writer items

/// 
let generateTopConfig (bnf: BNF) (names: Map<string, string>) (outputPath: string) =
    let groups = ViablePrefixData.getTops bnf
    let items = get_items names groups

    use writer = new StreamWriter(outputPath, false, Encoding.UTF8)

    writer.WriteLine("module FSharp.Substance.TopConfig")
    writer.WriteLine()
    writeItems writer items
    writer.WriteLine()
    writeCatalog writer items

    let terminals = ViablePrefixData.getTopTerminals bnf
    writer.WriteLine($"let TERMINALS: list<string list * string Set> = [")
    for item in terminals do
        writer.WriteLine(Line.indent 2 (stringify item))
    writer.WriteLine("]")
    writer.WriteLine()


/// 
let generateManyLookaheadConfig (bnf: BNF) (names: Map<string, string>) (sq: seq<Set<string>>) (outputPath: string) =
    let many_groups = 
        ViablePrefixData.manyLookaheads bnf sq
        |> Seq.indexed
    for i, groups in many_groups do        
        let items = get_items names groups
        let outputPath = Path.Combine(outputPath,$"LookaheadConfig{i}.fs")
        use writer = new StreamWriter(outputPath, false, Encoding.UTF8)
        writer.WriteLine($"module FSharp.Substance.LookaheadConfig{i}")
        writer.WriteLine()
        writeItems writer items
        writer.WriteLine()
        writeCatalog writer items

/// 同时生成所有配置
let generateAllConfigs_many (bnf: BNF) (names: Map<string, string>) (sq: seq<Set<string>>) (outputDir: string) =
    generateManyLookaheadConfig bnf names sq outputDir
    let topPath = Path.Combine(outputDir, "TopConfig.fs")
    generateTopConfig bnf names topPath


/// 同时生成所有配置
let generateAllConfigs (bnf: BNF) (names: Map<string, string>) (outputDir: string) =

    let lookaheadPath = Path.Combine(outputDir, "LookaheadConfig.fs")
    let topPath = Path.Combine(outputDir, "TopConfig.fs")
    generateLookaheadConfig bnf names lookaheadPath
    generateTopConfig bnf names topPath
