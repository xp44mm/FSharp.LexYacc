namespace FSharp.LexYacc

open FSharp.Idioms

///rule_id: byte;
type DFA<'state, 'lbl when 'state: comparison and 'lbl: comparison> = {
    transitions: Set<Transition<'state, 'lbl>>
    flags: Map<'state, (byte * DFAStateFlag) Set>
} with
    /// 用状态索引来重新为状态编号
    member this.indexed() =
        let allStates =
            this.transitions
            |> Transition.allStates
            |> Seq.mapi(fun i s -> s, uint32 i)
            |> Map.ofSeq

        let transition =
            this.transitions
            |> Set.map(fun tran -> tran.mapStates(fun s -> allStates.[s]))

        let flags =
            this.flags
            |> Seq.map(fun (KeyValue(s, info)) -> allStates.[s], info)
            |> Map.ofSeq

        { transitions = transition; flags = flags }

    member this.allStates =
        this.transitions |> Transition.allStates

module DFA =
    let subsetDFA (nfa: LexerNFA) =
        let exploded =
            SubsetConstruction.explode nfa.transitions

        let closures = SubsetConstruction.closures exploded
        let moves = SubsetConstruction.moves exploded
        let dtran =
            SubsetConstruction.dfaTransitions closures moves

        /// 3.8.3 查找接受狀態的算法
        /// DFA状态是NFA状态的集合
        /// 一个DFA状态可以有若干个状态标记，一个DFA状态即可以是NFA的这个接受状态，也可能另一个接受状态。零个状态标记是普通状态
        let getFlags =
            dtran
            |> Transition.allStates
            |> DFAStateFlag.fromNFA

        let flags =
            nfa.finals
            |> List.mapi(fun rule_id state -> getFlags rule_id state)
            |> Seq.concat
            |> Map.fromDuplicateKeys
            |> Map.map(fun _ v ->
                // 解决冲突
                let accepts, looks =
                    set v
                    |> Set.partition(fun (rule_id, flag) ->
                        match flag with
                        | Accept
                        | Seen -> true
                        | Look -> false
                    )
                if accepts.IsEmpty then
                    looks
                else
                    // 注意一个事实：同一状态下，接受长度相同，而accept长度一定大于seen的lexeme长度。
                    // 所以，有多个accept/seen时，先取accept
                    // 当都是accept，或者都是seen时，取最小的rule_id
                    let flag, rule_id =
                        accepts
                        |> Set.map(fun (rule_id, flag) -> flag, rule_id)
                        |> Set.minElement

                    looks |> Set.add(rule_id, flag)
            )
        { transitions = dtran; flags = flags }
