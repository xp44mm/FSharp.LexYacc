namespace FSharp.LexYacc

/// Lex文件对应的NFA
type LexerNFA = {
    transitions: Set<NFA_Transition<CharClass>>
    finals: NFAFinalState list
}

//（看到的最长字符串）是 Maximal Munch 原则下的探索边界。
//（实际取出的状态）是 获胜规则对应的 Accepting State 。
module LexerNFA =
    let unionMany (nfas: LookaheadNFA list) =
        let transition =
            nfas
            |> List.map (fun nfa ->
                nfa.transitions
                |> Set.add (Transition<_, _>.just (0u, None, nfa.minState))
            )
            |> Set.unionMany

        let finals =
            nfas |> List.map (fun nfa -> nfa.finalState)

        id<LexerNFA> {
            transitions = transition
            finals = finals
        }

    /// 从lex regular expressions得到正则表达式
    let fromRgx (lookaheads: LookaheadRegExp list) =
        (1u, lookaheads)
        |> List.unfold (fun (i, lookaheads) ->
            match lookaheads with
            | [] -> None
            | h :: t ->
                let nfa = LookaheadNFA.fromRgx i h
                let nextState = nfa.maxState + 1u, t
                Some(nfa, nextState)
        )
        |> unionMany

    let fromSingleRgx (rgx: RegExp) =
        let nfa = RegExpNFA.fromRgx 0u rgx
        id<LexerNFA> {
            transitions = nfa.transitions
            finals = [ SingleAccept nfa.maxState ]
        }



