module FSharp.Substance.LexFilter

open FSharp.Substance.FSharpYacc
open FSharp.Substance.RightSententialForm
open FSharp.Substance.StackOps
open FSharp.Substance.ParseContext

open FSharp.Idioms
open FSharp.Idioms.Literal

// 上下文从状态栈到token队列依次的命名为：lead top gap la

open FSharp.LexYacc

open System
open System.Diagnostics

/// 依次的命名为：lead top gap la
let lex_filter (states: YaccState list) (newline: int option) (la: FSharpToken) =
    match states, newline, la with
    | PEEK_NEWLINE_OPEN ls -> ls
    | PEEK_EOF ls -> ls
    | PEEK_RPAREN ls -> ls
    | PEEK_RBRACK ls -> ls
    | PEEK_SEMICOLON ls -> ls
    | SEMICOLON_PEEK_NEWLINE ls -> ls
    | PEEK_NEWLINE_APP ls -> ls

    | _ -> [ newline, la ]
