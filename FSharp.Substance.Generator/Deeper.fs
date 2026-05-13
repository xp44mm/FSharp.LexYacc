module FSharp.Substance.Deeper

open FSharp.LexYacc
open FSharp.Substance

open FSharp.Idioms
open FSharp.Idioms.Literal

open System
open System.IO
open System.Text
open Microsoft.FSharp.Reflection

/// 从top位置向栈底，可能的符号序列选项
let take (tops: Map<string list, string Set>) (top: string) =
    tops
    |> Map.filter(fun prefix heads -> prefix.[0] = top)
    |> Map.mapKey(fun prefix heads -> prefix.Tail)
    |> Map.map(fun prefix heads -> Set.unionMany heads)

let second (tops: Map<string, string list Set>) (v: ViablePrefix) =
    [
        match Map.tryFind v.head tops with
        | None -> [ v.prefix ]
        | Some prefixes ->
            for prefix in prefixes do
                [
                    v.prefix
                    prefix
                ]
    ]

/// llparen栈顶形状枚举
let top_entry (tops: Map<string list, string Set>) (top: string) =
    let prefixes =
        top
        |> take tops
        |> Map.keys
        |> Set.ofSeq
    top, prefixes
