open System.IO
open System.Text
open System

open FSharp.Substance
open FSharp.Idioms.Literal
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
open System.Diagnostics

let smoke () =
    let srcPath = ""
    let text = File.ReadAllText(srcPath, Encoding.UTF8)
    let nodes = FSharpCompiler.compile text
    //Debug.Assert((snd nodes = expected))
    Console.WriteLine(stringify nodes)


let yacc() =
    let srcPath = @"D:\Application Data\GitHub\xp44mm\FSharp.LexYacc\FSharp.Substance.Generator\fsharp.fsyacc"
    let text = File.ReadAllText(srcPath, Encoding.UTF8)
    let rawFsyacc = FsyaccCompiler.compile text
    let flatFsyacc = FlatFsyaccFile.from rawFsyacc

    let get_symbols (productions:Set<string list>) =
        productions
        |> Set.map Set.ofList
        |> Set.unionMany

    let productions =
        flatFsyacc.augmentRules
        |> Set.map(fun rule -> rule.production)

    let newRules = Symbol.crawl "" flatFsyacc.augmentRules

    let newProductions =
        newRules
        |> Set.ofList
        |> Set.map(fun rule -> rule.production)

    let symbols = get_symbols productions
    let newSymbols = get_symbols newProductions
    let orphan_bnf = symbols - newSymbols

    let decls =
        flatFsyacc.declarations
        |> Map.keys
        |> Set.ofSeq

    let absence_decl = newSymbols - decls
    let orphan_decl = decls - newSymbols

    Console.WriteLine(
        $"let orphan_bnf = "
        + stringify orphan_bnf
    )

    Console.WriteLine(
        $"let absence_decl = "
        + stringify absence_decl
    )

    Console.WriteLine(
        $"let orphan_decl = "
        + stringify orphan_decl
    )


    //Console.WriteLine(stringify bnf.symbols)

yacc()
