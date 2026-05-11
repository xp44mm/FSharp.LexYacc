module FSharp.Substance.PEEK_NEWLINE_NEW_DECL

let x =
    let y = 1
    y + 1

let tgt = ["FSharp";"Substance";"PEEK_NEWLINE_NEW_DECL"],[LetBindingExpr(IdentPattern "x",[LetBindingExpr(IdentPattern "y",[LiteralExpr(INT32 1)]);BinaryExpr(IdentExpr "y",["+",LiteralExpr(INT32 1)])])]
