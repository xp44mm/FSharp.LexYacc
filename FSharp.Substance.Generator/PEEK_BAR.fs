module FSharp.Substance.PEEK_BAR

let f =
    fun x ->
        match x with
        | 0 -> "zero"
        | 1 ->
            [] |> ignore
            "one"
        | _ -> "other"

let tgt =
    [
        "FSharp"
        "Substance"
        "PEEK_BAR"
    ],
    [
        LetBindingExpr(
            IdentPattern "f",
            [
                LambdaExpr(
                    IdentPattern "x",
                    [
                        MatchExpr(
                            IdentExpr "x",
                            [
                                RuleClause(IdentPattern "_", None, [ LiteralExpr(STRING "other") ])
                            ]
                        )
                    ]
                )
            ]
        )
    ]
