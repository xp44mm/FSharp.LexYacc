module FSharp.LexYacc.SubsetConstruction
// subset construction
// Figure 3.31: Operations on NFA states

open FSharp.Idioms

let allLabels (transitions: NFA_Transition<CharClass> Set) =
    transitions
    |> Transition.allLabels
    |> Seq.choose id
    |> Set.ofSeq

// 获取NFA字符类的字母表
let getAlphabet (labels: CharClass Set) =
    labels
    |> Seq.collect (CharClass.toIntervals)
    |> Interval.disjoint
    |> Set.toList

/// 标签分解为字母表中的元素，每个元素单独一条transition
let explode (transitions: NFA_Transition<CharClass> Set) =
    let alphabet = getAlphabet (allLabels transitions)

    transitions
    |> Seq.collect (fun tran ->
        match tran.label with
        | None -> [ tran.replaceLabel (None) ]
        | Some label ->
            label
            |> CharClass.toIntervals
            |> Seq.collect (fun (s, t) -> Interval.slice alphabet s t)
            |> Seq.map (fun breaked -> tran.replaceLabel (Some breaked))
            |> Seq.toList
    )
    |> Set.ofSeq

// 构造得到的DFA的每个状态，对应于NFA的一个状态集合.

///ε-transition
let isEpsilon (tran: NFA_Transition<'lbl>) = tran.label.IsNone

/// 每个NFA状态：其发出的epsilon边（经零个或多个）指向的状态，所有状态组成的集合
let closures (transition: Set<NFA_Transition<'lbl>>) =
    /// 状态和他的等价状态集
    let allStates =
        transition
        |> Transition.allStates
        |> Set.map (fun s -> s, Set.singleton s)
        |> Map.ofSeq

    /// NFA ε边
    let epsilons = transition |> Set.filter isEpsilon

    //每個pair(1,2)代表如下：
    //(1)--None-->(2)
    let statePairs =
        epsilons
        |> Set.map (fun tran -> tran.source, tran.target)

    //單個NFA狀態的空閉包
    let closures: Map<_, Set<_>> =
        Graph.propagate allStates statePairs
    closures

/// start -> label -> set of targets 
let moves (transition: Set<NFA_Transition<'lbl>>) : Map<uint32, Map<_, Set<uint32>>> =
    transition
    |> Set.filter (fun tran -> not (isEpsilon tran))
    |> Set.map (fun tran -> tran.source, tran.label.Value, tran.target)
    |> Set.toJaggedMap

/// 例 3-21
let dfaTransitions
    (closures: Map<uint32, Set<uint32>>)
    (moves: Map<uint32, Map<'lbl, Set<uint32>>>)
    =
    let rec loop
        (dtran: Set<Transition<Set<uint32>, 'lbl>>)
        (dstates: Set<Set<uint32>>)
        (newDstates: Set<Set<uint32>>)
        =
        //由未完成遍歷的狀態，推導得到新的轉換詞條。
        let newDtrans: Set<Transition<Set<uint32>, 'lbl>> =
            newDstates
            |> Seq.collect (fun T ->
                T
                |> Set.filter (moves.ContainsKey)
                |> Seq.collect (fun s -> 
                    // s in T, 不必区分集合中的元素
                    let sq = moves.[s] |> Map.toSeq
                    sq
                )
                |> Set.unionByKey // key = 'lbl
                |> Set.map (fun (lbl, target) ->
                    let targets =
                        target
                        |> Set.map (fun t -> closures.[t]) // 每個目標向前空變換
                        |> Set.unionMany
                    lbl, targets
                )
                |> Set.map (fun (lbl, target) -> {
                    source = T
                    label = lbl
                    target = target
                })
            )
            |> Set.ofSeq

        //已經完成遍歷的狀態
        let overDstates = dstates + newDstates

        let dtran = dtran + newDtrans

        //未遍歷的狀態
        let newDstates =
            newDtrans
            |> Seq.map (fun tran -> tran.target)
            |> Set.ofSeq
            |> Set.difference
            <| overDstates

        if newDstates.IsEmpty then
            dtran
        else
            loop dtran overDstates newDstates

    if closures.IsEmpty then
        Set.empty
    else
        /// nfa开始状态
        let startState =
            closures |> Seq.map (fun x -> x.Key) |> Seq.min

        let dtran =
            Set.singleton closures.[startState]
            |> loop Set.empty (Set.singleton Set.empty)
        dtran
