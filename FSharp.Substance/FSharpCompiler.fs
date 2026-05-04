module FSharp.Substance.FSharpCompiler

open System
open System.Diagnostics

open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
open FSharp.Idioms
open FSharp.Idioms.Literal
open FSharp.Substance
open FSharp.Idioms.Json
open FSharp.Substance.StackOps
open FSharpYacc

/// 解析文本为结构化数据
let compile (input: string) =
    //let mutable revTokens: FSharpToken list = []
    let mutable states = [ { state = 0; lexeme = null } ]

    let input = "\n" + input
    let iter = LexicalIterator.forChar input

    let tokens =
        iter
        |> FSharpLexerTailer.tokenize
        |> Seq.filter(fun tok ->
            match tok with
            | WHITESPACE -> false
            | _ -> true
        )
        |> Light.transform

    seq {
        yield! tokens
        yield Some 0, EOF
    }
    |> Seq.collect(fun (spaces, tok) ->
        Console.WriteLine(stringify(StackOps.getSymbols states |> List.rev))
        LexFilter.lex_filter states spaces tok
    )
    |> Seq.map(fun (i, tok) ->
        //Console.WriteLine(stringify(i, tok))
        Light.tokenRow i tok
    )
    |> Seq.iter(fun tok -> states <- parser.shift states tok
    //Console.WriteLine(stringify(StackOps.getSymbols states |> List.rev))
    )

    match FSharpYacc.parser.tryReduceBeforeAccept(states) with
    | Some reducedstates -> states <- reducedstates
    | None -> ()

    match states with
    | [ { state = 1; lexeme = lxm }; { state = 0; lexeme = null } ] ->
        Console.WriteLine(stringify(StackOps.getSymbols states |> List.rev))
        FSharpYacc.unboxRoot lxm
    | _ ->
        let symbols = StackOps.getSymbols states
        failwith $"{stringify symbols}"
