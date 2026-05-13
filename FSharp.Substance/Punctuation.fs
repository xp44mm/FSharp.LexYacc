module FSharp.Substance.Punctuation

open System

open FSharp.LexYacc
open FSharp.Substance
open FSharp.Substance.RightSententialForm

open FSharp.Substance.FSharpYacc
open FSharp.Substance.RightSententialForm
open FSharp.Substance.ViablePrefix

open FSharp.Idioms
open FSharp.Idioms.Literal

open FSharp.LexYacc

open System
open System.Diagnostics
open StackOps

/// 是否是decl的开始，前面是分界符号
let is_new_decl =
    function
    | "->"
    | "="
    | "LLPAREN" -> false
    | _ -> true

///前瞻到了什么虚拟符号？
let exists (states: YaccState list) =
    if
        lookahead_rrparen
        |> Set.exists(fun prefix -> StackOps.isPrefixOf states prefix)
    then
        RRPAREN
    elif
        lookahead_rhsend
        |> Set.exists(fun prefix -> StackOps.isPrefixOf states prefix)
    then
        RHSEND
    else
        SEMICOLON

let find (states: YaccState list) =
    match
        lookahead_rrparen
        |> Seq.tryFind(StackOps.isPrefixOf states)
    with
    | Some prefix -> RRPAREN, prefix
    | None ->
        match
            lookahead_rhsend
            |> Seq.tryFind(StackOps.isPrefixOf states)
        with
        | Some prefix -> RHSEND, prefix
        | None -> SEMICOLON, []
