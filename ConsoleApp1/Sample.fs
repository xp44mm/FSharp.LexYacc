module FSharp.Substance.Sample

let src = 0

let tgt =
    [
        "FSharp"
        "Substance"
        "Sample"
    ],
    [ LetBindingExpr(IdentPattern "src", [ LiteralExpr(INT32 0) ]) ]
