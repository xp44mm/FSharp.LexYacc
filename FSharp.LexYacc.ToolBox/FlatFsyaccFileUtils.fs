module FSharp.LexYacc.FlatFsyaccFileUtils

open FSharp.Idioms
open FSharp.Idioms.Literal

// symbol -> typeName
let printDeclarations (declarations: Map<string, string>) =
    [
        "let declarations: (string*Type) list = ["
        for KeyValue(symbol, typename) in declarations do
            let typename = typename.Substring("%type".Length)
            $"    {stringify symbol}, typeof{typename}"
        "]"
    ]
    |> String.concat "\r\n"
