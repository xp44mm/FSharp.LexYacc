module FSharp.Substance.ViablePrefix

let lookaheadOf la =
    RightSententialForm.lookaheads
    |> List.filter(fun (v, look_ahead) -> look_ahead = la)
    |> List.map(fun (v, la) -> v.prefix)
    |> Set.ofList //确保最短在先

let topOf tp =
    RightSententialForm.tops
    |> List.filter(fun v ->
        not v.prefix.IsEmpty
        && v.prefix.[0] = tp
    )
    |> List.map(fun v -> v.prefix)
    |> Set.ofList //确保最短在先

let top_llparen = topOf "LLPAREN"

let top_rrparen = topOf "RRPAREN"

let top_rhsend = topOf "RHSEND"

let top_semicolon = topOf ";"

let la_llparen = lookaheadOf "LLPAREN"

let la_rrparen = lookaheadOf "RRPAREN"

let la_rhsend = lookaheadOf "RHSEND"

let la_semicolon = lookaheadOf ";"


