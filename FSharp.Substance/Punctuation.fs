module FSharp.Substance.Punctuation

open FSharp.Substance
open FSharp.Substance.FSharpYacc

open System
open System.Diagnostics

open FSharp.Idioms
open FSharp.Idioms.Literal
open FSharp.LexYacc

///decl中的常见运算符号
let connectors = set [ ","; "."; "infix"; ":"; "*" ]

/// 是否是decl的开始，前面是分界符号
let is_new_decl =
    function
    | "->"
    | "="
    | "LLPAREN" -> false
    | _ -> true

let left_valueExpr =
    let left =
        [
            for l in [ "{"; "["; "("; "[|" ] do
                [ l ]
                [ ";"; "revSequentialExpr"; l ]
        ]
    set
        [
            for prefix in ViablePrefix.valueExpr do
                for l in left do
                    prefix @ l
        ]

let dot_lbrack_tupleExpr =
    set
        [
            for prefix in ViablePrefix.tupleExpr do
                prefix @ [ "["; "." ]
        ]

let lbrack_declExpr =
    let left = [ [ "[" ]; [ ";"; "revSequentialExpr"; "[" ] ]
    set
        [
            for prefix in ViablePrefix.declExpr do
                for l in left do
                    prefix @ l
        ]

let lparen_declExpr =
    let left = [ [ "(" ]; [ ";"; "revSequentialExpr"; "(" ] ]
    set
        [
            for prefix in ViablePrefix.declExpr do
                for l in left do
                    prefix @ l
        ]

//从TopConfig手动总结而来LLPAREN+fieldBinding
let LLPAREN: string list Set =
    set [ [ "->" ]; [ "="; "bindingPattern"; "LET" ]; [ "="; "IDENT"; ";"; "fieldBindings" ]; [ "="; "IDENT"; "{" ] ]

///前瞻Bar，回溯到对应的Match关键字
let BAR_MATCH: string list Set =
    let left: string list list =
        [
            [ "->"; "patternAndGuard"; "opt_bar"; "WITH"; "tupleExpr"; "MATCH" ]
            [
                "->"
                "patternAndGuard"
                "|"
                "revRuleClauses"
                "opt_bar"
                "WITH"
                "tupleExpr"
                "MATCH"
            ]
        ]
    set
        [
            [ "WITH"; "tupleExpr"; "MATCH" ]
            for l in left do
                for prefix in ViablePrefix.tupleExpr do
                    prefix @ l
                [ "RRPAREN"; "revSequentialExpr"; "LLPAREN" ]
                @ l
        ]
