module FSharp.Substance.PEEK_SEMICOLON

let s1 = 1
let s2 = 2; 

let s3 = 3

let s4 = 
    let a = 1;
    a
let s5 = 2

let tgt = ["FSharp";"Substance";"PEEK_SEMICOLON"],[LetBindingExpr(IdentPattern "s1",[LiteralExpr(INT32 1)]);LetBindingExpr(IdentPattern "s2",[LiteralExpr(INT32 2)]);LetBindingExpr(IdentPattern "s3",[LiteralExpr(INT32 3)]);LetBindingExpr(IdentPattern "s4",[LetBindingExpr(IdentPattern "a",[LiteralExpr(INT32 1)]);IdentExpr "a"]);LetBindingExpr(IdentPattern "s5",[LiteralExpr(INT32 2)])]
