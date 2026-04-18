open System.IO
open System.Text
open System

open FSharp.Substance
open FSharp.Idioms.Literal
open FSharp.LexYacc

let derived =
    Map
        [
            "(", set [ { head = "parenExpr"; prefix = [] } ]
            ")",
            set
                [
                    { head = "parenExpr"; prefix = [ "(" ] }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "("
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "("
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "("
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "DUMMY"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "DUMMY"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "OPEN"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "OPEN"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "OPEN"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "OPEN"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "LITERAL"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "LITERAL"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "LITERAL"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "LITERAL"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "->"
                                "IDENT"
                                "FUN"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "->"
                                "IDENT"
                                "FUN"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "="
                                "IDENT"
                                "LET"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "="
                                "IDENT"
                                "LET"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "->"
                                "IDENT"
                                "FUN"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "->"
                                "IDENT"
                                "FUN"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "="
                                "IDENT"
                                "LET"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "="
                                "IDENT"
                                "LET"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "["
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "["
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "["
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "parenExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "("
                            ]
                    }
                ]
            ",",
            set
                [
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                ")"
                                "("
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                ")"
                                "("
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix = [ "IDENT" ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "IDENT"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix = [ "LITERAL" ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "LITERAL"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "]"
                                "["
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "]"
                                "["
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revTupleExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                ]
            "-", set [ { head = "unaryExpr"; prefix = [] } ]
            "->",
            set
                [
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "IDENT"
                                "FUN"
                            ]
                    }
                ]
            ".",
            set
                [
                    {
                        head = "revLongid"
                        prefix = [ "IDENT" ]
                    }
                    {
                        head = "revLongid"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                            ]
                    }
                ]
            ";",
            set
                [
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "("
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "("
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "("
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "("
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix = [ "DUMMY" ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "DUMMY"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix = [ "IDENT" ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "OPEN"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "OPEN"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "OPEN"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "OPEN"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix = [ "LITERAL" ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "LITERAL"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "LITERAL"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "LITERAL"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "->"
                                "IDENT"
                                "FUN"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "="
                                "IDENT"
                                "LET"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "->"
                                "IDENT"
                                "FUN"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "="
                                "IDENT"
                                "LET"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "["
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "["
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "["
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "["
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                    {
                        head = "revSequentialExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                            ]
                    }
                ]
            "=",
            set
                [
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "IDENT"
                                "LET"
                            ]
                    }
                ]
            "DUMMY", set [ { head = "declExpr"; prefix = [] } ]
            "EOF",
            set
                [
                    {
                        head = "file"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "longid"
                                "MODULE"
                            ]
                    }
                ]
            "FUN", set [ { head = "lambdaExpr"; prefix = [] } ]
            "IDENT",
            set
                [
                    {
                        head = "lambdaExpr"
                        prefix = [ "FUN" ]
                    }
                    {
                        head = "letBinding"
                        prefix = [ "LET" ]
                    }
                    { head = "revLongid"; prefix = [] }
                    {
                        head = "revLongid"
                        prefix =
                            [
                                "."
                                "revLongid"
                            ]
                    }
                ]
            "LET", set [ { head = "letBinding"; prefix = [] } ]
            "LITERAL", set [ { head = "atomicExpr"; prefix = [] } ]
            "LLPAREN", set [ { head = "rhsBlock"; prefix = [] } ]
            "MODULE", set [ { head = "file"; prefix = [] } ]
            "OPEN", set [ { head = "declExpr"; prefix = [] } ]
            "RHSEND",
            set
                [
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                ")"
                                "("
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "IDENT"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "IDENT"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "LITERAL"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "LITERAL"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "->"
                                "IDENT"
                                "FUN"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "->"
                                "IDENT"
                                "FUN"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "]"
                                "["
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "lambdaExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "->"
                                "IDENT"
                                "FUN"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                ")"
                                "("
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                ")"
                                "("
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "IDENT"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "IDENT"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "LITERAL"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "LITERAL"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "->"
                                "IDENT"
                                "FUN"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "->"
                                "IDENT"
                                "FUN"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "]"
                                "["
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "]"
                                "["
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                    {
                        head = "letBinding"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "="
                                "IDENT"
                                "LET"
                            ]
                    }
                ]
            "RRPAREN",
            set
                [
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "("
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "("
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "("
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "("
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "DUMMY"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "DUMMY"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "OPEN"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "OPEN"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "OPEN"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "OPEN"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "LITERAL"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "LITERAL"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "LITERAL"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "LITERAL"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "->"
                                "IDENT"
                                "FUN"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "->"
                                "IDENT"
                                "FUN"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "="
                                "IDENT"
                                "LET"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "="
                                "IDENT"
                                "LET"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "->"
                                "IDENT"
                                "FUN"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "->"
                                "IDENT"
                                "FUN"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "="
                                "IDENT"
                                "LET"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "="
                                "IDENT"
                                "LET"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "["
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "["
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "["
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "["
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "LLPAREN"
                            ]
                    }
                    {
                        head = "rhsBlock"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "LLPAREN"
                            ]
                    }
                ]
            "[", set [ { head = "listExpr"; prefix = [] } ]
            "[|", set [ { head = "arrayExpr"; prefix = [] } ]
            "]",
            set
                [
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "("
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "("
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "("
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "DUMMY"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "DUMMY"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "OPEN"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "OPEN"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "OPEN"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "OPEN"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "LITERAL"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "LITERAL"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "LITERAL"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "LITERAL"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "->"
                                "IDENT"
                                "FUN"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "->"
                                "IDENT"
                                "FUN"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "="
                                "IDENT"
                                "LET"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "="
                                "IDENT"
                                "LET"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "->"
                                "IDENT"
                                "FUN"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "->"
                                "IDENT"
                                "FUN"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "="
                                "IDENT"
                                "LET"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "="
                                "IDENT"
                                "LET"
                                "["
                            ]
                    }
                    { head = "listExpr"; prefix = [ "[" ] }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "["
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "["
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "["
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "["
                            ]
                    }
                    {
                        head = "listExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "["
                            ]
                    }
                ]
            "|]",
            set
                [
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "("
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "("
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "("
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "("
                                "revAppExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                ")"
                                "sequentialExpr"
                                "("
                                "revAppExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "DUMMY"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "DUMMY"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "OPEN"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "OPEN"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "."
                                "revLongid"
                                "revAppExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "OPEN"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "OPEN"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "IDENT"
                                "revAppExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "LITERAL"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "LITERAL"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "LITERAL"
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "LITERAL"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "LITERAL"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "LITERAL"
                                "revAppExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "->"
                                "IDENT"
                                "FUN"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "->"
                                "IDENT"
                                "FUN"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "="
                                "IDENT"
                                "LET"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "RHSEND"
                                "lambdaExpr"
                                "="
                                "IDENT"
                                "LET"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "->"
                                "IDENT"
                                "FUN"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "->"
                                "IDENT"
                                "FUN"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "="
                                "IDENT"
                                "LET"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "RRPAREN"
                                "sequentialExpr"
                                "LLPAREN"
                                "="
                                "IDENT"
                                "LET"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix = [ "[|" ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "["
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "["
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "["
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "["
                                "revAppExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "]"
                                "sequentialExpr"
                                "["
                                "revAppExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "[|"
                                "revAppExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ","
                                "revTupleExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "-"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                ";"
                                "revSequentialExpr"
                                "[|"
                            ]
                    }
                    {
                        head = "arrayExpr"
                        prefix =
                            [
                                "|]"
                                "sequentialExpr"
                                "[|"
                                "revAppExpr"
                                "[|"
                            ]
                    }
                ]
        ]

let path = Path.Combine(__SOURCE_DIRECTORY__, "Sample.fs")
let text = File.ReadAllText(path, Encoding.UTF8)

let nodes = FSharpCompiler.compile text
Console.WriteLine(stringify nodes)
