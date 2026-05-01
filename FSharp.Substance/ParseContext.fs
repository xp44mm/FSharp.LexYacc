module FSharp.Substance.ParseContext

open FSharp.Substance.FSharpYacc

open FSharp.Idioms
open FSharp.Idioms.Literal

open FSharp.LexYacc

open System
open System.Diagnostics

/// 依次的命名为：lead top gap la
let (|OPEN_LONGID|_|) (states: YaccState list, indent: int option, la: FSharpToken) =
    RightSententialForm.open_longid
    |> Seq.tryFind(StackOps.isPrefixOf states)
    |> Option.map(fun symbols ->
        let lead = states.[symbols.Length - 1]
        let pos = StackOps.getPosition lead
        match indent, pos with
        | Some i, Some j ->
            if i = j then
                [
                    None, SEMICOLON
                    indent, la
                ]
            else
                [ indent, la ]
        | _ -> failwith "notImpl"
    )
