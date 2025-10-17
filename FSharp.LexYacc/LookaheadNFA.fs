namespace FSharp.LexYacc

/// re1 / re2 => NFA
type LookaheadNFA = {
    transitions: Set<NFA_Transition<CharClass>>
    minState: uint32
    finalState: NFAFinalState
} with

    member this.maxState =
        match this.finalState with
        | SingleAccept s
        | LookaheadAccept(_, s) -> s

    /// s/t: an s but only if it is followed by an t. The t is not part of the matched text.
    static member fromNFA(main: RegExpNFA, lookahead: RegExpNFA) = {
        transitions =
            main.transitions + lookahead.transitions
            |> Set.add (Transition<_,_>.just(main.maxState, None, lookahead.minState))
        minState = main.minState
        finalState = LookaheadAccept(lookahead.minState, lookahead.maxState)
    }

    static member fromNFA(main: RegExpNFA) = {
        transitions = main.transitions
        minState = main.minState
        finalState = SingleAccept(main.maxState)
    }

module LookaheadNFA =

    let fromRgx (i: uint32) (pattern: LookaheadRegExp) =
        let nfaHead = RegExpNFA.fromRgx i pattern.head
        match pattern.tail with
        | None -> LookaheadNFA.fromNFA nfaHead
        | Some tail ->
            let lexeme = nfaHead.maxState + 1u
            let nfaTail = RegExpNFA.fromRgx lexeme tail
            LookaheadNFA.fromNFA (nfaHead, nfaTail)
