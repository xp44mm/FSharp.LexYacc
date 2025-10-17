namespace FSharp.LexYacc

open FSharp.Idioms

/// todo: 带上 of rule_id: byte
type DFAStateFlag =
    | Accept
    | Seen //Lookbehind
    | Look // re1 / re2 {} 到达了re1的接受状态，还没有到达re2的接受状态

module DFAStateFlag =

    let fromNFA
        (allStates: Set<Set<uint32>>)
        (rule_id: int)
        (state: NFAFinalState)
        =
        // 重要的NFA状态都要提供给DFA的单个状态，动态确定最后的状态
        [
            let rule_id = byte rule_id
            match state with
            | SingleAccept s -> yield s, (rule_id, Accept)
            | LookaheadAccept(h, t) ->
                yield h, (rule_id, Look)
                yield t, (rule_id, Seen)
        ]
        |> Seq.collect (fun (n, flag) ->
            allStates
            |> Seq.filter (fun nfas -> nfas.Contains n) // 找到所有包含标记集合的nfas集合
            |> Seq.map (fun nfas -> nfas, flag) // 每个集合都有源状态的标记
        )
