module FSharp.LexYacc.Partition
//Minimizing the Number of States of a DFA
// State-Minimization Algorithm
open FSharp.Idioms
open System
open FSharp.Idioms.Literal

/// example 3-41
let initialPartition (dfa: DFA<uint32,int*int>) =
    let acceptBlocks =
        dfa.flags
        |> Seq.collect(fun (KeyValue(state, flags)) ->
            flags
            |> Seq.filter(fun (rule_id, flag) ->
                match flag with
                | Look -> false //删除Look状态
                | Accept
                | Seen -> true
            )
            |> Seq.map(fun (rule_id, flag) -> state, rule_id, flag)
        )
        |> Seq.groupBy(fun (state, rule_id, flag) -> rule_id, flag)
        |> Seq.map(fun (k, sq) ->
            sq
            |> Seq.map(fun (state, rule_id, flag) -> state)
            |> Set.ofSeq
        )
        |> Set.ofSeq

    let restBlock =
        dfa.allStates - Set.unionMany acceptBlocks
    acceptBlocks.Add restBlock

/// 最初的分区最少，通过迭代，将其分割。
let splitPartition
    (transitions: Set<Transition<uint32, 'lbl>>)
    (blocks: Set<Set<uint32>>)
    =

    // 目标落入相同组的开始状态为新组
    let collectBlock (group: Set<Transition<uint32, 'lbl>>) =
        group |> Set.map(fun tran -> tran.source)

    let rec loop (blocks: Set<Set<uint32>>) =
        //状态在哪个块中？
        let findBlock state =
            blocks
            |> Seq.find(fun block -> block.Contains state)

        // 相同源block,相同label,分为一组
        let srcLblGroups =
            transitions
            |> Seq.groupBy(fun tran ->
                let srcBlock = findBlock tran.source
                srcBlock, tran.label
            )
            |> Seq.map(fun (srclbl, sq) -> srclbl, Set.ofSeq sq)
            |> Seq.map snd

        // 相同源block,相同label，应该落入同样的block中
        let distinguish (group: Set<Transition<uint32, 'lbl>>) =
            let full = findBlock group.MinimumElement.source
            let this = collectBlock group
            let that = full - this
            let arr =
                group
                |> Set.groupBy(fun tran ->
                    // 根据目标所在的block分组
                    findBlock tran.target
                )
                |> Set.map snd

            // 一个block中的每个状态，在同一个lbl下，必须落入同样的目标block中
            if that.IsEmpty && arr.Count = 1 then
                None
            else
                //落入同样目标的源状态分到一组
                let tgt = arr |> Set.map collectBlock
                let tgt =
                    if that.IsEmpty then
                        tgt
                    else
                        //不在组中的状态相当于都落入空集合中
                        Set.add that tgt
                Some(full, tgt)

        //找到第一组分解，未找到结束
        match
            srcLblGroups
            |> Seq.tryPick(fun trans -> distinguish trans)
        with
        | None -> blocks
        | Some(block: Set<uint32>, newBlocks: Set<Set<uint32>>) ->
            let newBlocks =
                blocks |> Set.remove block |> Set.union newBlocks

            loop newBlocks

    loop blocks

///几个状态合并成一个状态，这个新状态按值排序，原状态与新状态的对照表
let replacement (states: Set<Set<uint32>>) =
    states
    |> Seq.indexed
    |> Seq.collect(fun (i, states) ->
        states |> Seq.map(fun state -> state, uint32 i)
    )
    |> Map.ofSeq

let hopcroft (srcDfa: DFA<uint32,int*int>) =
    let blocks = initialPartition srcDfa
    let states = splitPartition srcDfa.transitions blocks

    let mp = replacement states

    let transitions =
        srcDfa.transitions
        |> Set.map(fun tran -> tran.mapStates(fun state -> mp.[state]))

    let flags =
        srcDfa.flags
        |> Map.toSeq
        |> Seq.map(fun (state, st) -> mp.[state], st)
        |> Seq.groupBy fst
        |> Seq.map(fun (newState, flags) ->
            let flags = flags |> Seq.map snd |> Set.unionMany
            newState, flags
        )
        |> Map.ofSeq
    { transitions = transitions; flags = flags }
