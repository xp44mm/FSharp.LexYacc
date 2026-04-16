namespace FSharp.Substance

open FSharp.LexYacc
open FSharp.Idioms
open System
open FSharp.Idioms.Literal

//[<RequireQualifiedAccess>]
type YaccStateSegment =
    | LeftBound of string
    | Semicolon
    | ExplicitSemicolon of string list * lead: int option
    | Declaration of string list * lead: int option
    | FrontHalf
    | LeftOfllparen of string list * lead: int option
    | DeclSegment of string list * lead: int option
    | ModuleHead of string list * lead: int option
    | Rest of string list

    static member takeLatest(states: YaccState list) =
        let stateSymbols =
            states
            |> List.map(fun s -> FSharpYacc.stateSymbols.[s.state])

        let punctuations = RightSententialForm.precede_declExpr
        match stateSymbols.[0] with
        | ("(" | "LLPAREN" | "[" | "[|") as x -> LeftBound x
        | ";" ->
            YaccStateSegment.Semicolon
        | _ ->
            match List.tryFindIndex punctuations.Contains stateSymbols with
            | Some idx ->
                let pos = StackOps.getPosition states.[idx - 1]
                let seg = List.take (idx + 1) stateSymbols
                if
                    RightSententialForm.llparen
                    |> List.exists((=) seg)
                then
                    LeftOfllparen(seg, pos)
                else
                    DeclSegment(seg, pos)
            // 还有一种情况:let ident = lambda 这时候会取出lambda
            // 可以对这个区间的情况，详细分类
            | None ->
                if
                    List.exists
                        (PointFree.flip List.isPrefix stateSymbols)
                        RightSententialForm.llparen
                then
                    let lead = states.[stateSymbols.Length - 1]
                    let pos = StackOps.getPosition lead
                    ModuleHead(stateSymbols, pos)
                else
                    Rest stateSymbols
