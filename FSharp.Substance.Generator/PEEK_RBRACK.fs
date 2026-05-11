module FSharp.Substance.PEEK_RBRACK

let b1 = [1; 2; 3]

let b2 = [
    1
    2
    3]

let x = [1].[0]

let tgt = ["FSharp";"Substance";"PEEK_RBRACK"],[LetBindingExpr(IdentPattern "b1",[ListExpr [LiteralExpr(INT32 1);LiteralExpr(INT32 2);LiteralExpr(INT32 3)]]);LetBindingExpr(IdentPattern "b2",[ListExpr [LiteralExpr(INT32 1);LiteralExpr(INT32 2);LiteralExpr(INT32 3)]]);LetBindingExpr(IdentPattern "x",[QualificationExpr [ListExpr [LiteralExpr(INT32 1)];LiteralExpr(INT32 0)]])]
