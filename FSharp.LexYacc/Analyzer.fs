namespace FSharp.LexYacc

open System
open System.Diagnostics

open FSharp.Idioms
open FSharp.Idioms.Literal

type Analyzer = {
    nextStates: Map<uint32, Set<(int * int) list * uint32>>
    flags: Map<uint32, (byte * DFAStateFlag) Set>
    lookbehinds: Map<byte, LazyAnalyzer>
} with
    static member just(nextStates, flags, lookbehinds) = {
        nextStates = nextStates
        flags = flags
        lookbehinds = lookbehinds
    }

    member this.getIterator(iterator: LexicalIterator<'tok * int>) =
        let lookbehinds: Map<byte, uint32 list -> _ -> _> =
            this.lookbehinds
            |> Map.map(fun rule_id anal -> anal.loobehind rule_id this.flags)

        // [s0] -c0-> [s1] -c1-> [s2] -c2-> [s3] ...
        let rec retract
            (revStates: uint32 list)
            (revTokens: ('tok * int) list)
            =
            match revStates with
            | [] -> failwith "at least [0u]"
            | s0 :: tail ->
                match Map.tryFind s0 this.flags with
                | None ->
                    //普通状态，丢弃一行
                    if revTokens.IsEmpty then
                        failwith $"输入序列retract回退到头却没有匹配"
                    else
                        retract tail revTokens.Tail
                | Some flags ->
                    match
                        flags
                        |> Seq.tryPick(fun (rule_id, flag) ->
                            match flag with
                            | DFAStateFlag.Accept -> Some(rule_id, revTokens)
                            | DFAStateFlag.Seen ->
                                let lookbehind = lookbehinds.[rule_id]
                                let restTokens = lookbehind tail revTokens
                                Some(rule_id, restTokens)
                            | DFAStateFlag.Look -> None
                        )
                    with
                    | None ->
                        //flags里面只有Look,没有Accept/Seen
                        retract tail revTokens.Tail
                    | Some x -> x

        // 输入参数是已经遍历的状态链：
        // [s0] -c0-> [s1] -c1-> [s2] -c2-> [s3] ...
        let rec forward (states: uint32 list) (chars: ('tok * int) list) =
            match iterator.tryNext() with
            | None ->
                //字符序列结束
                states, chars
            | Some((tok, c) as next) ->
                //iterator读取一个字符
                match Interval.tryNextState this.nextStates states.Head c with
                | None ->
                    //没有下一个状态了
                    states, chars
                | Some state ->
                    //确定了下一状态，继续循环
                    forward (state :: states) (next :: chars)

        let tryNext () =
            match forward [ 0u ] [] with
            | [ 0u ], [] ->
                if iterator.tryNext().IsNone then
                    //序列遍历结束，正常退出
                    None
                else
                    failwith $"输入序列forward失败"
            | revStates, revChars ->
                let rule_id, revChars = retract revStates revChars

                let len, lexbuf = revChars |> List.countRev
                //在基准指针向前移动之前，此时所有数据都是可以回撤的可以在此处设置beforeEvent(rule_id,lexbuf)
                iterator.pop(len)
                let buff = List.map fst lexbuf
                Some(rule_id, buff) //此时还未执行action(rule_id) buff
        tryNext

    member this.split(iterator: LexicalIterator<'tok * int>) =
        let tryNext = this.getIterator iterator
        let rec loop () = seq {
            match tryNext() with
            | Some(rule_id, buff) ->
                yield rule_id, buff
                yield! loop()
            | None -> ()
        }
        loop()

    static member from(patterns: LookaheadRegExp list) =
        let nextStatesAndFlags nfa =
            let dfa = (DFA.subsetDFA nfa).indexed()
            let minDfa = Partition.hopcroft dfa
            let nextStates =
                minDfa.transitions
                |> Transition.mergeLabel
                |> Transition.getNextStates
            nextStates, minDfa.flags

        let nfa = LexerNFA.fromRgx patterns
        let nextStates, flags = nextStatesAndFlags nfa

        let lookbehinds =
            patterns
            |> List.mapi(fun i pat ->
                pat.tail |> Option.map(fun r -> byte i, r.rev())
            )
            |> List.choose id
            |> List.map(fun (i, regex) ->
                let nfa = LexerNFA.fromSingleRgx regex
                let nextStates, flags = nextStatesAndFlags nfa
                let accepts = flags |> Map.keys |> Set.ofSeq
                i, LazyAnalyzer.just(nextStates, accepts)
            )
            |> Map.ofList

        { nextStates = nextStates; flags = flags; lookbehinds = lookbehinds }
