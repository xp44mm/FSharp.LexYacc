namespace FSharp.LexYacc

//transition数据流，转化顺序

type Transition<'state, 'lbl when 'state: comparison and 'lbl: comparison> = {
    source: 'state
    label: 'lbl
    target: 'state
} with
    member this.replaceLabel(newLabel) = {
        source = this.source
        label = newLabel
        target = this.target
    }

    /// todo: mapStates
    member this.mapStates(mapper) = {
        source = mapper this.source
        label = this.label
        target = mapper this.target
    }

    static member just(s, l, t) = { source = s; label = l; target = t }

    member this.getStates() = [ this.source; this.target ]

open FSharp.Idioms

module Transition =
    let allStates (transitions: #seq<Transition<'state, 'lbl>>) =
        transitions
        |> Seq.map(fun tran -> tran.getStates())
        |> Seq.concat
        |> Set.ofSeq

    let minState (transition: Set<Transition<'s, 'lbl>>) =
        transition.MinimumElement.source

    let allLabels (transitions: Set<Transition<uint32, 'lbl>>) =
        transitions |> Set.map(fun t -> t.label)

    let mergeLabel (transitions: Set<Transition<'state, int * int>>) =
        transitions
        |> Seq.groupBy(fun tran -> tran.source, tran.target)
        |> Seq.map(fun ((source, target), trans) ->
            let ls =
                trans
                |> Seq.map(fun tran -> tran.label)
                |> Seq.toList
                |> Interval.merge

            { source = source; target = target; label = ls }
        )
        |> Set.ofSeq

    /// DFA:
    /// source -> 'lbl -> target
    let getNextStates
        (transitions: Set<Transition<uint32, 'lbl>>)
        : Map<uint32, Set<'lbl * uint32>>
        =
        transitions
        |> Set.map(fun tran -> tran.source, (tran.label, tran.target))
        |> Map.fromDuplicateKeys
        |> Map.map(fun _ sq -> Set.ofSeq sq)
