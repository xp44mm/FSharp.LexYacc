module FSharp.LexYacc.Experimental.FslexFilePrinter

open System
open System.Text.RegularExpressions

open FSharp.Idioms
open FSharp.Idioms.Literal

open FSharp.LexYacc

let printAction (act: string) =
    match act with
    | Braces.SingleLine ln -> "fun buff -> " + ln
    | Braces.MultiLine ls ->
        let act = Line.identAll 8 ls
        "fun buff -> \r\n" + act
    | Braces.Empty -> "fun buff -> failwith String.empty"

let printChar
    (header: string)
    (data: EagerAnalyzerData)
    (parameters: string list)
    (actions: string list)
    (funType:string)
    =
    let parameters = String.concat " " parameters
    [
        Braces.sliceContent header

        "let transitions: Set<DFATransition> = "
        + stringify data.transitions

        "let flags: Map<uint32, Set<byte * DFAStateFlag>> = "
        + stringify data.flags

        "let lookbehinds: Map<byte, Set<DFATransition> * Set<uint32>> = "
        + stringify data.lookbehinds

        "let anal = LexicalAnalyzer(transitions, flags, lookbehinds)"

        $"let actions {parameters}: Map<byte, {funType}> = Map ["
        for i, act in actions |> Seq.indexed do
            let b = byte i
            let f = printAction act
            Line.ident 4 $"{stringify b}, {f}"
        Line.ident 4 "]"

        // yield! trailer
        //"let tokenize (input: string) =         "
        //"    input.ToCharArray()                "
        //"    |> Array.map(fun ch -> ch, int ch) "
        //"    |> ArrayStack                      "
        //"    |> LexicalIterator.ofArrayStack    "
        //"    |> anal.split                      "
        //"    |> Seq.map(fun (rule_id, buff) ->  "
        //"        let action = actions.[rule_id] "
        //"        action buff                    "
        //"    )                                  "
    ]
    |> List.map(fun line -> line.TrimEnd())
    |> String.concat "\r\n"

let printTag
    (header: string)
    (data: EagerAnalyzerData)
    (parameters: string list)
    (actions: string list)
    (funType: string)
    =
    let parameters = String.concat " " parameters
    [
        Braces.sliceContent header

        "let transitions: Set<DFATransition> = "
        + stringify data.transitions

        "let flags: Map<uint32, Set<byte * DFAStateFlag>> = "
        + stringify data.flags

        "let lookbehinds: Map<byte, Set<DFATransition> * Set<uint32>> = "
        + stringify data.lookbehinds

        "let anal = LexicalAnalyzer(transitions, flags, lookbehinds)"

        $"let actions {parameters}: Map<byte, {funType}> = Map ["
        for i, act in actions |> Seq.indexed do
            let b = byte i
            let f = printAction act
            Line.ident 4 $"{stringify b}, {f}"
        Line.ident 4 "]"

        // yield! trailer
        //$"let tokenize (tokens: seq<{tokenType}>) ="
        //$"    tokens"
        //$"    |> Seq.map(fun tok -> tok, {tokenType}.index tok)"
        //$"    |> BufferIterator"
        //$"    |> LexicalIterator.ofBufferIterator"
        //$"    |> anal.split"
        //$"    |> Seq.map(fun (rule_id, buff) ->"
        //$"        let action = actions.[rule_id]"
        //$"        action buff"
        //$"    )"
    ]
    |> List.map(fun line -> line.TrimEnd())
    |> String.concat "\r\n"

/// 去掉开头的冒号
let strFunType (src:string) = src.Substring(1).Trim()

let generateLexerModule (text: string) =
    let ast =
        FSharp.LexYacc.Experimental.FslexCompiler.compile text
    let patterns = ast.getPatterns(int)
    let data = EagerAnalyzerData.from patterns
    let actions =
        ast.ruler.rules |> List.map(fun rule -> rule.action)
    let funType = strFunType ast.ruler.funType
    printChar ast.header data ast.ruler.parameters actions funType

let generateFilterModule (text: string) =
    let ast =
        FSharp.LexYacc.Experimental.FslexTagCompiler.compile text
    let patterns = ast.getPatterns(FSharp.LexYacc.Experimental.FslexToken.tagToValue)
    let data = EagerAnalyzerData.from patterns
    let actions =
        ast.ruler.rules |> List.map(fun rule -> rule.action)
    let funType = strFunType ast.ruler.funType    
    printTag ast.header data ast.ruler.parameters actions funType
