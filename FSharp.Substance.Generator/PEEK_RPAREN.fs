module FSharp.Substance.PEEK_RPAREN

let r1 = (1 + 2)

let r2 = (
    let x = 1
    x + 2
    )

let tgt = ["FSharp";"Substance";"PEEK_RPAREN"],
            [LetBindingExpr(IdentPattern "r1",[ParenExpr [BinaryExpr(LiteralExpr(INT32 1),
            ["+",LiteralExpr(INT32 2)])]]);
            LetBindingExpr(IdentPattern "r2",
            [ParenExpr [LetBindingExpr(IdentPattern "x",[LiteralExpr(INT32 1)]);
            BinaryExpr(IdentExpr "x",["+",LiteralExpr(INT32 2)])]])]
