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

/// 
let lex_filter (states: YaccState list) (newline: int option) (la: FSharpToken) =
    match states, newline, la with
    | PEEK_BAR ls -> ls
    | PEEK_NEWLINE_MODULE ls -> ls
    | PEEK_SEMICOLON ls -> ls
    | PEEK_RPAREN ls -> ls
    | PEEK_RBRACK ls -> ls
    | PEEK_RBRACE ls -> ls

    | PEEK_NEW_BLOCK ls -> ls
    | PEEK_NEWLINE_VIRTUAL ls -> ls
    | PEEK_EOF ls -> ls
    | _ -> [ newline, la ]
