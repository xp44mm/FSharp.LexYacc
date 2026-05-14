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
                                RuleClause(
                                    LiteralPattern(INT32 0),
                                    None,
                                    [ LiteralExpr(STRING "zero") ]
                                )
                                RuleClause(
                                    LiteralPattern(INT32 1),
                                    None,
                                    [
                                        BinaryExpr(
                                            ListExpr [],
                                            [
                                                "|>",
                                                AppExpr
                                                    [
                                                        IdentExpr "ignore"
                                                        LiteralExpr(STRING "one")
                                                    ]
                                            ]
                                        )
                                    ]
                                )
                                RuleClause(IdentPattern "_", None, [ LiteralExpr(STRING "other") ])
                            ]
                        )
                    ]
                )
            ]
        )
    ]
