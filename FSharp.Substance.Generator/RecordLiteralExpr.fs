module FSharp.Substance.RecordLiteralExpr
open FSharp.LexYacc

let src =
    [
        { source = 0; label = 'a'; target = 1}
        { 
            source = 1; label = 'b'; target = 2}
        { 
            source = 3
            label = 'c' 
            target = 4
            }

        { 
            source = 5;
            label = 'd'; 
            target = 6;
            }
    ]

let tgt =
    [
        "RecordLiteralExpr"
    ],
    [ LetBindingExpr(IdentPattern "src", [ LiteralExpr(INT32 0) ]) ]
