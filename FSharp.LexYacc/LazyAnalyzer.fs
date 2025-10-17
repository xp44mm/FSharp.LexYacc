namespace FSharp.LexYacc

open FSharp.Idioms

///state: uint32;
///label: (int * int) list;
///input: int
type LazyAnalyzer = {
    nextStates: Map<uint32, Set<(int * int) list * uint32>>
    accepts: Set<uint32>
} with

    static member just(nextStates, accepts) = {
        nextStates = nextStates
        accepts = accepts
    }

    static member from(transitions: Set<Transition<uint32, (int * int) list>>, accepts: Set<uint32>) = {
        nextStates = Transition.getNextStates transitions
        accepts = accepts
    }

    /// 懒惰获得最近的接受状态
    member this.getIterator(input: int list) =
        let mutable remains = input
        let mutable state = 0u
        let mutable revAcc = []

        let rec onNextAccept () =
            match remains with
            | [] -> failwith "输入不匹配模式"
            | head :: tail ->
                match Interval.tryNextState this.nextStates state head with
                | None -> failwith "输入不匹配模式"
                | Some target ->
                    remains <- tail
                    state <- target
                    revAcc <- head :: revAcc

                    if this.accepts.Contains target then
                        revAcc
                    else
                        onNextAccept()
        onNextAccept

    /// 用懒惰方法回退，查找接受状态
    member this.loobehind
        (rule_id: byte)
        (flags: Map<uint32, (byte * DFAStateFlag) Set>)
        =

        let andalso state =
            flags.[state]
            |> Set.exists(fun (rid, flag) ->
                rid = rule_id && flag = DFAStateFlag.Look
            )
        /// myState lookbehind的当前状态，revStates/revTokens是被回溯的状态栈
        let rec loop
            (myState: uint32)
            (revStates: uint32 list)
            (revTokens: ('tok * int) list)
            =
            match revTokens with
            | [] -> failwith "输入不匹配模式"
            | (tok, i) :: tail ->
                match Interval.tryNextState this.nextStates myState i with
                | None -> failwith "输入不匹配模式"
                | Some target ->
                    if
                        this.accepts.Contains target
                        && andalso revStates.Head
                    then
                        revTokens.Tail
                    else
                        loop target revStates.Tail tail
        // revStates revTokens ||>
        loop 0u
