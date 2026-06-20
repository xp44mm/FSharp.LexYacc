module FSharp.Substance.Sample

let absence_decl =
    set [ "functionExpr"; "parenPattern"; "thenPart"; "tryFinallyExpr"; "tryWithExpr" ]
let orphan_decl = set [ "(|"; "atomicPattern"; "tuplePattern"; "|)" ]
let x = 
    
    (Some 0) : int option
