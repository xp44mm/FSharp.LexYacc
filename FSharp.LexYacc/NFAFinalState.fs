namespace FSharp.LexYacc

type NFAFinalState =
    | SingleAccept of uint32
    | LookaheadAccept of uint32 * uint32

    static member just(a: uint32) = SingleAccept a
    static member just(m: uint32, v: uint32) =
        if v < m then
            failwith "NFAFinalState(min,max)"
        elif v = m then
            SingleAccept m
        else
            LookaheadAccept(m, v)

