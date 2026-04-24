open System.IO
open System.Text
open System

open FSharp.Substance
open FSharp.Idioms.Literal
open FSharp.LexYacc

let x =
    [
        "FSharp"
        "Substance"
        "Sample"
    ],
    [
        OpenExpr
            [
                "FSharp"
                "Idioms"
            ]
        OpenExpr
            [
                "FSharp"
                "Substance"
            ]
        LetBindingExpr(
            "actions",
            [
                AppExpr
                    [
                        IdentExpr [ "Map" ]
                        ListExpr
                            [
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 1uy)
                                        LambdaExpr(
                                            "buff",
                                            [ ListExpr [ IdentExpr [ "WHITESPACE" ] ] ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 2uy)
                                        LambdaExpr("buff", [ ListExpr [ IdentExpr [ "DOT" ] ] ])
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 3uy)
                                        LambdaExpr("buff", [ ListExpr [ IdentExpr [ "COLON" ] ] ])
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 4uy)
                                        LambdaExpr(
                                            "buff",
                                            [ ListExpr [ IdentExpr [ "SEMICOLON" ] ] ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 5uy)
                                        LambdaExpr("buff", [ ListExpr [ IdentExpr [ "EQUALS" ] ] ])
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 6uy)
                                        LambdaExpr("buff", [ ListExpr [ IdentExpr [ "COMMA" ] ] ])
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 7uy)
                                        LambdaExpr("buff", [ ListExpr [ IdentExpr [ "LPAREN" ] ] ])
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 8uy)
                                        LambdaExpr("buff", [ ListExpr [ IdentExpr [ "RPAREN" ] ] ])
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 9uy)
                                        LambdaExpr("buff", [ ListExpr [ IdentExpr [ "LBRACE" ] ] ])
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 10uy)
                                        LambdaExpr("buff", [ ListExpr [ IdentExpr [ "RBRACE" ] ] ])
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 11uy)
                                        LambdaExpr("buff", [ ListExpr [ IdentExpr [ "LBRACK" ] ] ])
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 12uy)
                                        LambdaExpr("buff", [ ListExpr [ IdentExpr [ "RBRACK" ] ] ])
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 13uy)
                                        LambdaExpr("buff", [ ListExpr [ IdentExpr [ "LESS" ] ] ])
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 14uy)
                                        LambdaExpr("buff", [ ListExpr [ IdentExpr [ "GREATER" ] ] ])
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 15uy)
                                        LambdaExpr("buff", [ ListExpr [ IdentExpr [ "HASH" ] ] ])
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 16uy)
                                        LambdaExpr("buff", [ ListExpr [ IdentExpr [ "RARROW" ] ] ])
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 17uy)
                                        LambdaExpr("buff", [ ListExpr [ IdentExpr [ "MINUS" ] ] ])
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 18uy)
                                        LambdaExpr("buff", [ ListExpr [ IdentExpr [ "STAR" ] ] ])
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 19uy)
                                        LambdaExpr(
                                            "buff",
                                            [ ListExpr [ IdentExpr [ "LBRACK_BAR" ] ] ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 20uy)
                                        LambdaExpr("buff", [ ListExpr [ IdentExpr [ "BAR" ] ] ])
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 21uy)
                                        LambdaExpr(
                                            "buff",
                                            [ ListExpr [ IdentExpr [ "BAR_RBRACK" ] ] ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 22uy)
                                        LambdaExpr(
                                            "buff",
                                            [
                                                ListExpr
                                                    [
                                                        AppExpr
                                                            [
                                                                IdentExpr [ "LITERAL" ]
                                                                ParenExpr
                                                                    [
                                                                        AppExpr
                                                                            [
                                                                                IdentExpr
                                                                                    [
                                                                                        "Literal"
                                                                                        "int8"
                                                                                    ]
                                                                                IdentExpr [ "buff" ]
                                                                            ]
                                                                    ]
                                                            ]
                                                    ]
                                            ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 23uy)
                                        LambdaExpr(
                                            "buff",
                                            [
                                                ListExpr
                                                    [
                                                        AppExpr
                                                            [
                                                                IdentExpr [ "LITERAL" ]
                                                                ParenExpr
                                                                    [
                                                                        AppExpr
                                                                            [
                                                                                IdentExpr
                                                                                    [
                                                                                        "Literal"
                                                                                        "int16"
                                                                                    ]
                                                                                IdentExpr [ "buff" ]
                                                                            ]
                                                                    ]
                                                            ]
                                                    ]
                                            ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 24uy)
                                        LambdaExpr(
                                            "buff",
                                            [
                                                ListExpr
                                                    [
                                                        AppExpr
                                                            [
                                                                IdentExpr [ "LITERAL" ]
                                                                ParenExpr
                                                                    [
                                                                        AppExpr
                                                                            [
                                                                                IdentExpr
                                                                                    [
                                                                                        "Literal"
                                                                                        "int32"
                                                                                    ]
                                                                                IdentExpr [ "buff" ]
                                                                            ]
                                                                    ]
                                                            ]
                                                    ]
                                            ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 25uy)
                                        LambdaExpr(
                                            "buff",
                                            [
                                                ListExpr
                                                    [
                                                        AppExpr
                                                            [
                                                                IdentExpr [ "LITERAL" ]
                                                                ParenExpr
                                                                    [
                                                                        AppExpr
                                                                            [
                                                                                IdentExpr
                                                                                    [
                                                                                        "Literal"
                                                                                        "int64"
                                                                                    ]
                                                                                IdentExpr [ "buff" ]
                                                                            ]
                                                                    ]
                                                            ]
                                                    ]
                                            ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 26uy)
                                        LambdaExpr(
                                            "buff",
                                            [
                                                ListExpr
                                                    [
                                                        AppExpr
                                                            [
                                                                IdentExpr [ "LITERAL" ]
                                                                ParenExpr
                                                                    [
                                                                        AppExpr
                                                                            [
                                                                                IdentExpr
                                                                                    [
                                                                                        "Literal"
                                                                                        "uint8"
                                                                                    ]
                                                                                IdentExpr [ "buff" ]
                                                                            ]
                                                                    ]
                                                            ]
                                                    ]
                                            ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 27uy)
                                        LambdaExpr(
                                            "buff",
                                            [
                                                ListExpr
                                                    [
                                                        AppExpr
                                                            [
                                                                IdentExpr [ "LITERAL" ]
                                                                ParenExpr
                                                                    [
                                                                        AppExpr
                                                                            [
                                                                                IdentExpr
                                                                                    [
                                                                                        "Literal"
                                                                                        "uint16"
                                                                                    ]
                                                                                IdentExpr [ "buff" ]
                                                                            ]
                                                                    ]
                                                            ]
                                                    ]
                                            ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 28uy)
                                        LambdaExpr(
                                            "buff",
                                            [
                                                ListExpr
                                                    [
                                                        AppExpr
                                                            [
                                                                IdentExpr [ "LITERAL" ]
                                                                ParenExpr
                                                                    [
                                                                        AppExpr
                                                                            [
                                                                                IdentExpr
                                                                                    [
                                                                                        "Literal"
                                                                                        "uint32"
                                                                                    ]
                                                                                IdentExpr [ "buff" ]
                                                                            ]
                                                                    ]
                                                            ]
                                                    ]
                                            ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 29uy)
                                        LambdaExpr(
                                            "buff",
                                            [
                                                ListExpr
                                                    [
                                                        AppExpr
                                                            [
                                                                IdentExpr [ "LITERAL" ]
                                                                ParenExpr
                                                                    [
                                                                        AppExpr
                                                                            [
                                                                                IdentExpr
                                                                                    [
                                                                                        "Literal"
                                                                                        "uint64"
                                                                                    ]
                                                                                IdentExpr [ "buff" ]
                                                                            ]
                                                                    ]
                                                            ]
                                                    ]
                                            ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 30uy)
                                        LambdaExpr(
                                            "buff",
                                            [
                                                ListExpr
                                                    [
                                                        AppExpr
                                                            [
                                                                IdentExpr [ "LITERAL" ]
                                                                ParenExpr
                                                                    [
                                                                        AppExpr
                                                                            [
                                                                                IdentExpr
                                                                                    [
                                                                                        "Literal"
                                                                                        "float"
                                                                                    ]
                                                                                IdentExpr [ "buff" ]
                                                                            ]
                                                                    ]
                                                            ]
                                                    ]
                                            ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 31uy)
                                        LambdaExpr(
                                            "buff",
                                            [
                                                ListExpr
                                                    [
                                                        AppExpr
                                                            [
                                                                IdentExpr [ "LITERAL" ]
                                                                ParenExpr
                                                                    [
                                                                        AppExpr
                                                                            [
                                                                                IdentExpr
                                                                                    [
                                                                                        "Literal"
                                                                                        "single"
                                                                                    ]
                                                                                IdentExpr [ "buff" ]
                                                                            ]
                                                                    ]
                                                            ]
                                                    ]
                                            ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 32uy)
                                        LambdaExpr(
                                            "buff",
                                            [
                                                ListExpr
                                                    [
                                                        AppExpr
                                                            [
                                                                IdentExpr [ "TYPAR" ]
                                                                ParenExpr
                                                                    [
                                                                        AppExpr
                                                                            [
                                                                                IdentExpr
                                                                                    [
                                                                                        "String"
                                                                                        "build"
                                                                                    ]
                                                                                IdentExpr [ "buff" ]
                                                                            ]
                                                                    ]
                                                            ]
                                                    ]
                                            ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 33uy)
                                        LambdaExpr(
                                            "buff",
                                            [
                                                ListExpr
                                                    [
                                                        AppExpr
                                                            [
                                                                IdentExpr [ "LITERAL" ]
                                                                ParenExpr
                                                                    [
                                                                        AppExpr
                                                                            [
                                                                                IdentExpr
                                                                                    [
                                                                                        "Literal"
                                                                                        "char"
                                                                                    ]
                                                                                IdentExpr [ "buff" ]
                                                                            ]
                                                                    ]
                                                            ]
                                                    ]
                                            ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 34uy)
                                        LambdaExpr(
                                            "buff",
                                            [
                                                ListExpr
                                                    [
                                                        AppExpr
                                                            [
                                                                IdentExpr [ "LITERAL" ]
                                                                ParenExpr
                                                                    [
                                                                        AppExpr
                                                                            [
                                                                                IdentExpr
                                                                                    [
                                                                                        "Literal"
                                                                                        "char"
                                                                                    ]
                                                                                IdentExpr [ "buff" ]
                                                                            ]
                                                                    ]
                                                            ]
                                                    ]
                                            ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 35uy)
                                        LambdaExpr(
                                            "buff",
                                            [
                                                ListExpr
                                                    [
                                                        AppExpr
                                                            [
                                                                IdentExpr [ "LITERAL" ]
                                                                ParenExpr
                                                                    [
                                                                        AppExpr
                                                                            [
                                                                                IdentExpr
                                                                                    [
                                                                                        "Literal"
                                                                                        "char"
                                                                                    ]
                                                                                IdentExpr [ "buff" ]
                                                                            ]
                                                                    ]
                                                            ]
                                                    ]
                                            ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 36uy)
                                        LambdaExpr(
                                            "buff",
                                            [
                                                ListExpr
                                                    [
                                                        AppExpr
                                                            [
                                                                IdentExpr [ "LITERAL" ]
                                                                ParenExpr
                                                                    [
                                                                        AppExpr
                                                                            [
                                                                                IdentExpr
                                                                                    [
                                                                                        "Literal"
                                                                                        "char"
                                                                                    ]
                                                                                IdentExpr [ "buff" ]
                                                                            ]
                                                                    ]
                                                            ]
                                                    ]
                                            ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 37uy)
                                        LambdaExpr(
                                            "buff",
                                            [
                                                ListExpr
                                                    [
                                                        AppExpr
                                                            [
                                                                IdentExpr [ "LITERAL" ]
                                                                ParenExpr
                                                                    [
                                                                        AppExpr
                                                                            [
                                                                                IdentExpr
                                                                                    [
                                                                                        "Literal"
                                                                                        "string"
                                                                                    ]
                                                                                IdentExpr [ "buff" ]
                                                                            ]
                                                                    ]
                                                            ]
                                                    ]
                                            ]
                                        )
                                    ]
                                TupleExpr
                                    [
                                        LiteralExpr(UINT8 38uy)
                                        LambdaExpr(
                                            "buff",
                                            [
                                                ListExpr
                                                    [
                                                        AppExpr
                                                            [
                                                                IdentExpr [ "IDENT" ]
                                                                ParenExpr
                                                                    [
                                                                        AppExpr
                                                                            [
                                                                                IdentExpr
                                                                                    [
                                                                                        "String"
                                                                                        "build"
                                                                                    ]
                                                                                IdentExpr [ "buff" ]
                                                                            ]
                                                                    ]
                                                            ]
                                                    ]
                                            ]
                                        )
                                    ]
                            ]
                    ]
            ]
        )
    ]

let path = Path.Combine(__SOURCE_DIRECTORY__, "Sample.fs")
let text = File.ReadAllText(path, Encoding.UTF8)

let nodes = FSharpCompiler.compile text
Console.WriteLine(stringify nodes)

//for p in ViablePrefix.topOf "IDENT" do
//    Console.WriteLine(stringify p)
