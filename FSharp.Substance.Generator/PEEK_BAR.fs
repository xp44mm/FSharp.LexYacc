module FSharp.Substance.PEEK_BAR

let f = fun x ->
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
                                {
                                    pattern = LiteralPattern(INT32 0)
                                    guard = None
                                    result = [ LiteralExpr(STRING "zero") ]
                                }
                                {
                                    pattern = LiteralPattern(INT32 1)
                                    guard = None
                                    result =
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
                                }
                                {
                                    pattern = IdentPattern "_"
                                    guard = None
                                    result = [ LiteralExpr(STRING "other") ]
                                }
                            ]
                        )
                    ]
                )
            ]
        )
    ]
