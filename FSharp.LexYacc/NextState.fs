namespace FSharp.LexYacc

type NextState =
    | NoSource of srcState: int
    | NoSymbol of tag: string
    | Accepted
    | NoZero of tag: string
    | Shifted of states: list<int * obj>
    | Reduced of states: list<int * obj>
