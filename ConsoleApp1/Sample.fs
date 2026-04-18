module FSharp.Substance.Sample

open System

let x =
    [
        [ [ "(" ], "parenExpr" ]
        [
            [
                ")"
                "("
            ],
            "parenExpr"
            [
                ")"
                "sequentialExpr"
                "("
            ],
            "parenExpr"
        ]
        [
            [
                ","
                "revTupleExpr"
            ],
            "revTupleExpr"
        ]
        [ [ "-" ], "unaryExpr" ]
        [
            [
                "->"
                "IDENT"
                "FUN"
            ],
            "lambdaExpr"
        ]
        [
            [
                "."
                "revLongid"
            ],
            "revLongid"
        ]
        [
            [
                ";"
                "revSequentialExpr"
            ],
            "revSequentialExpr"
        ]
        [
            [
                "="
                "IDENT"
                "LET"
            ],
            "letBinding"
        ]
        [ [ "DUMMY" ], "declExpr" ]
        [
            [
                "EOF"
                "rhsBlock"
                "longid"
                "MODULE"
            ],
            "file"
        ]
        [ [ "FUN" ], "lambdaExpr" ]
        [
            [ "IDENT" ], "revLongid"
            [
                "IDENT"
                "."
                "revLongid"
            ],
            "revLongid"
            [
                "IDENT"
                "FUN"
            ],
            "lambdaExpr"
            [
                "IDENT"
                "LET"
            ],
            "letBinding"
        ]
        [ [ "LET" ], "letBinding" ]
        [ [ "LITERAL" ], "atomicExpr" ]
        [ [ "LLPAREN" ], "rhsBlock" ]
        [ [ "MODULE" ], "file" ]
        [ [ "OPEN" ], "declExpr" ]
        [
            [
                "RHSEND"
                "lambdaExpr"
                "->"
                "IDENT"
                "FUN"
            ],
            "lambdaExpr"
            [
                "RHSEND"
                "lambdaExpr"
                "="
                "IDENT"
                "LET"
            ],
            "letBinding"
        ]
        [
            [
                "RRPAREN"
                "sequentialExpr"
                "LLPAREN"
            ],
            "rhsBlock"
        ]
        [ [ "[" ], "listExpr" ]
        [ [ "[|" ], "arrayExpr" ]
        [
            [
                "]"
                "["
            ],
            "listExpr"
            [
                "]"
                "sequentialExpr"
                "["
            ],
            "listExpr"
        ]
        [
            [
                "|]"
                "[|"
            ],
            "arrayExpr"
            [
                "|]"
                "sequentialExpr"
                "[|"
            ],
            "arrayExpr"
        ]
    ]
