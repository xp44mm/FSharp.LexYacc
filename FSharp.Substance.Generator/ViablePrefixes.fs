namespace FSharp.Substance

open FSharp.LexYacc
open FSharp.Substance

open FSharp.Idioms
open FSharp.Idioms.Literal

open System
open System.IO
open System.Text
open Microsoft.FSharp.Reflection

type ViablePrefixes =
    {
        /// 栈顶前缀
        prefix: string list

        /// 各段的头位置
        positions: int Set

    }

    ///栈中前后相接切片
    static member from(prefixes: string list list) =
        {
            prefix = prefixes |> List.concat
            positions =
                let lens = prefixes |> List.map List.length
                lens.Tail
                |> List.scan (+) lens.Head
                |> Set.ofSeq
        }

    static member cons(lookaheads: Set<ViablePrefix>, tops: Map<string, string list Set>) =
        lookaheads
        |> Set.map(fun v ->
            Deeper.second tops v
            |> List.map ViablePrefixes.from
            |> Set.ofList
        )
        |> Set.unionMany




