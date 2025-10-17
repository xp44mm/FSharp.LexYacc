namespace FSharp.LexYacc

type NFA_Transition<'lbl when 'lbl: comparison> = Transition<uint32, 'lbl option>
        
/// 单个RegExp的NFA
type RegExpNFA = {
    transitions: Set<NFA_Transition<CharClass> >
    /// 最小状态是开始状态
    minState: uint32 // 可以从transition计算出来，这里用于缓存,optional

    /// 最大状态就是接受状态，到达接受状态意味着匹配，无法到达，意味着不匹配
    maxState: uint32 // 可以从transition计算出来，这里用于缓存,optional
}

/// 假设操作数的状态编号不需要重新整理
/// 状态编号由小到大排列，没有重复，没有空位：i,s,t
module RegExpNFA =
    /// Figure 3.40: NFA for the union of two NFA transition
    let union (i: uint32) (s: RegExpNFA) (t: RegExpNFA) =
        let f = t.maxState + 1u
        id<RegExpNFA> {
            transitions =
                s.transitions + t.transitions
                |> Set.add (Transition<_,_>.just(i, None, s.minState))
                |> Set.add (Transition<_,_>.just(i, None, t.minState))
                |> Set.add (Transition<_,_>.just(s.maxState, None, f))
                |> Set.add (Transition<_,_>.just(t.maxState, None, f))
            minState = i
            maxState = f
        }

    /// Figure 3.41: NFA for the concatenation of two NFA transition
    /// 状态编号：x的最大状态，就是y的最小状态
    let concat (s: RegExpNFA) (t: RegExpNFA) =
        id<RegExpNFA> {
            transitions = s.transitions + t.transitions
            minState = s.minState
            maxState = t.maxState
        }

    /// 数量词：零个或多个*
    let repetition (i: uint32) (nfa: RegExpNFA) =
        let si = nfa.minState
        let sf = nfa.maxState
        let f = nfa.maxState + 1u
        id<RegExpNFA> {
            transitions =
                nfa.transitions
                |> Set.add (Transition<_,_>.just(i, None, si))
                |> Set.add (Transition<_,_>.just(i, None, f))
                |> Set.add (Transition<_,_>.just(sf, None, si))
                |> Set.add (Transition<_,_>.just(sf, None, f))
            minState = i
            maxState = f
        }

    /// 数量词：一个或多个+
    let strictRepetition (nfa: RegExpNFA) =
        let si = nfa.minState
        let sf = nfa.maxState
        id<RegExpNFA> {
            nfa with
                transitions =
                    nfa.transitions
                    |> Set.add (Transition<_,_>.just(sf, None, si))
        }

    /// 数量词：零个或一个?
    let option (i: uint32) (nfa: RegExpNFA) =
        let si = nfa.minState
        let sf = nfa.maxState
        let f = nfa.maxState + 1u
        id<RegExpNFA> {
            transitions =
                nfa.transitions
                |> Set.add (Transition<_,_>.just(i, None, si))
                |> Set.add (Transition<_,_>.just(i, None, f))
                |> Set.add (Transition<_,_>.just(sf, None, f))
            minState = i
            maxState = f
        }

    /// Algorithm 3.23: The McNaughton-Yamada-Thompson algorithm to convert a regular expression to an NFA.
    let rec fromRgx i =
        function
        | RgxLeaf r ->
            let f = i + 1u
            id<RegExpNFA> {
                transitions = set [ Transition<_,_>.just(i, Some r, f) ]
                minState = i
                maxState = f
            }

        | RgxAlt(r1, r2) ->
            let n1 = fromRgx (i + 1u) r1
            let n2 = fromRgx (n1.maxState + 1u) r2
            union i n1 n2

        | RgxCat(r1, r2) ->
            let n1 = fromRgx i r1
            let n2 = fromRgx (n1.maxState) r2
            concat n1 n2

        | RgxStar r ->
            let n = fromRgx (i + 1u) r
            repetition i n

        | RgxPlus r ->
            let n = fromRgx i r
            strictRepetition n

        | RgxOpt r ->
            let n = fromRgx (i + 1u) r
            option i n
