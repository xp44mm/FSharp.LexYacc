module FSharp.LexYacc.DiscriminatedUnions
open System
open System.IO
open System.Text

open Microsoft.FSharp.Reflection

open FSharp.Idioms
open FSharp.Idioms.Literal

///利用反射生成TokenDiscriminatedUnion类型所需要的方法模块源代码
let generate<'u> (symbols: ('u * string) list) =
    let unionType = typeof<'u>
    let cases =
        FSharpType.GetUnionCases(unionType)
        |> Array.indexed

    let getTag (tok: 'u) =
        let caseInfo, _ =
            FSharpValue.GetUnionFields(tok, unionType)
        caseInfo.Name

    let symbols =
        symbols
        |> List.map(fun (tok, s) -> getTag tok, s)
        |> Map.ofList

    let index_outp = [
        $"let index (tok:{unionType.Name}) ="
        Line.ident 4 "match tok with"
        for (i, c) in cases do
            if c.GetFields().Length = 0 then
                Line.ident 4 $"| {unionType.Name}.{c.Name} -> {i}"
            else
                Line.ident 4 $"| {unionType.Name}.{c.Name} _ -> {i}"
    ]

    let tag_outp = [
        $"let tag (tok:{unionType.Name}) ="
        Line.ident 4 "match tok with"
        for (i, c) in cases do
            let tag =
                if symbols.ContainsKey c.Name then
                    symbols.[c.Name]
                else
                    c.Name

            if c.GetFields().Length = 0 then
                Line.ident 4 $"| {unionType.Name}.{c.Name} -> {stringify tag}"
            else
                Line.ident 4 $"| {unionType.Name}.{c.Name} _ -> {stringify tag}"
    ]

    let tagToValue_outp = [
        "let tagToValue (tag:string) ="
        Line.ident 4 "match tag with"
        for (i, c) in cases do
            let tag =
                if symbols.ContainsKey c.Name then
                    symbols.[c.Name]
                else
                    c.Name
            Line.ident 4 $"| {stringify tag} -> {i}"
        Line.ident 4 "| _ -> failwith tag"
    ]

    let lexeme_outp = [
        $"let lexeme (tok:{unionType.Name}) ="
        Line.ident 4 "match tok with"
        for (i, c) in cases do
            match c.GetFields().Length with
            | 0 -> Line.ident 4 $"| {unionType.Name}.{c.Name} -> null"
            | 1 -> Line.ident 4 $"| {unionType.Name}.{c.Name} x -> box x"
            | len ->
                let ps =
                    Array.create len "_"
                    |> String.concat ","
                    |> sprintf "(%s)"
                Line.ident 4 $"| {unionType.Name}.{c.Name}({ps} as ps) -> box ps"
    ]

    let content =
        [
            index_outp
            tag_outp
            tagToValue_outp
            lexeme_outp
        ]
        |> List.concat
        |> Line.identAll 4

    [
        $"module {unionType.Name} ="
        content
    ]
    |> String.concat "\r\n"
