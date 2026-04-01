module FSharp.Substance.FSharpCompiler

open FSharp.Idioms
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
open System
open FSharp.Idioms.Literal

let getSymbols (states: StateInParseStack list) =
    states
    |> List.map(fun s -> FSharpYacc.stateSymbols.[s.state])

/// 解析文本为结构化数据
let compile (input: string) =
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
        //此处补全缺省的token: uniform
        |> Seq.map snd
        // states对于每个层次应该有ident信息。
    seq {
        yield! tokens
        yield EOF
    }
    |> Seq.map(fun tok ->
        { token = tok; tag = FSharpToken.tag tok; lexeme = FSharpToken.lexeme tok }
        : TokenRow<FSharpToken>
    )
    |> Seq.iter(fun tok -> states <- FSharpYacc.parser.shift states tok)

    match FSharpYacc.parser.tryReduceBeforeAccept(states) with
    | Some reducedstates -> states <- reducedstates
    | None -> ()

    match states with
    | [ { state = 1; lexeme = lxm }; { state = 0; lexeme = null } ] -> FSharpYacc.unboxRoot lxm
    | _ ->
        let symbols = getSymbols states
        failwith $"{stringify symbols}"
