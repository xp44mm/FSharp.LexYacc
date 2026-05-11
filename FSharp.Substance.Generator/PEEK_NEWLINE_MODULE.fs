module FSharp.Substance.PEEK_NEWLINE_MODULE

open System

let m1 = 1
let m2 = 
    1 + 2

let tgt = ["FSharp";"Substance";"PEEK_NEWLINE_MODULE"],[OpenExpr ["System"];LetBindingExpr(IdentPattern "m1",[LiteralExpr(INT32 1)]);LetBindingExpr(IdentPattern "m2",[BinaryExpr(LiteralExpr(INT32 1),["+",LiteralExpr(INT32 2)])])]
