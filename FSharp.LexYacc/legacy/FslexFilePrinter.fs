module FSharp.LexYacc.FslexFilePrinter

open System
open System.Text.RegularExpressions

open FSharp.Idioms
open FSharp.Idioms.Literal

let printAction (act:string) =
    let act = Braces.sliceContent act
    if
        act
        |> Seq.exists(fun c -> c = '\r' || c = '\n')
    then
        let act = Line.identAll 8 [act]
        "fun buff -> \r\n" + act
    else
        "fun buff -> " + act

let printChar (header: string) (data: EagerAnalyzerData) (actions: string list) =
    [
        Braces.sliceContent header

        "let transitions: Set<DFATransition> = "
        + stringify data.transitions

        "let flags: Map<uint32, Set<byte * DFAStateFlag>> = "
        + stringify data.flags

        "let lookbehinds: Map<byte, Set<DFATransition> * Set<uint32>> = "
        + stringify data.lookbehinds

        "let anal = LexicalAnalyzer(transitions, flags, lookbehinds)"

        // yield! trailer

        "let actions: Map<byte, char list -> _> = Map ["
        for i, act in actions |> Seq.indexed do
            let b = byte i
            let f = printAction act
            Line.ident 4 $"{stringify b}, {f}"
        Line.ident 4 "]"

        "let tokenize (input: string) =         "
        "    input.ToCharArray()                "
        "    |> Array.map(fun ch -> ch, int ch) "
        "    |> ArrayStack                      "
        "    |> LexicalIterator.ofArrayStack    "
        "    |> anal.split                      "
        "    |> Seq.map(fun (rule_id, buff) ->  "
        "        let action = actions.[rule_id] "
        "        action buff                    "
        "    )                                  "
    ]
    |> List.map(fun line -> line.TrimEnd())
    |> String.concat "\r\n"

let printTag (header: string) (data: EagerAnalyzerData) (actions: string list) (tokenType:string) =
    [
        Braces.sliceContent header

        "let transitions: Set<DFATransition> = "
        + stringify data.transitions

        "let flags: Map<uint32, Set<byte * DFAStateFlag>> = "
        + stringify data.flags

        "let lookbehinds: Map<byte, Set<DFATransition> * Set<uint32>> = "
        + stringify data.lookbehinds

        "let anal = LexicalAnalyzer(transitions, flags, lookbehinds)"

        // yield! trailer
        $"let actions: Map<byte, {tokenType} list -> _> = Map ["
        for i, act in actions |> Seq.indexed do
            let b = byte i
            let f = printAction act
            Line.ident 4 $"{stringify b}, {f}"
        Line.ident 4 "]"

        $"let tokenize (tokens: seq<{tokenType}>) ="
        $"    tokens"
        $"    |> Seq.map(fun tok -> tok, {tokenType}.index tok)"
        $"    |> BufferIterator"
        $"    |> LexicalIterator.ofBufferIterator"
        $"    |> anal.split"
        $"    |> Seq.map(fun (rule_id, buff) ->"
        $"        let action = actions.[rule_id]"
        $"        action buff"
        $"    )"
    ]
    |> List.map(fun line -> line.TrimEnd())
    |> String.concat "\r\n"
