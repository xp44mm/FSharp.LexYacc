module FSharp.Substance.LexFilter

open FSharp.Substance.FSharpYacc
open FSharp.Substance.StackOps
open FSharp.Substance.ViablePrefix

open FSharp.Idioms
open FSharp.Idioms.Literal

open FSharp.LexYacc

open System
open System.Diagnostics

///
let lex_filter_refac (states: YaccState list) (newline: int option) (la: FSharpToken) =
    match newline, la with
    | Some 0, MODULE -> [ newline, la ]
    | _, EOF ->
        [
            yield! rrparen_or_rhsend states
            newline, la
        ]

    | Some 0, (OPEN | LET) ->
        match states with
        | TryFind ViablePrefix.module_statement ls -> [ newline, la ]
        | _ ->
            [
                yield! rrparen_or_rhsend states
                None, SEMICOLON
                newline, la
            ]

    | _, RPAREN ->
        match states with
        | Lookahead LookaheadConfig1.RPAREN ls -> [ newline, la ]
        | _ ->
            [
                yield! rrparen_or_rhsend states
                newline, la
            ]

    | _, RBRACK ->
        match states with
        | Lookahead LookaheadConfig1.RBRACK ls -> [ newline, la ]
        | _ ->
            [
                yield! rrparen_or_rhsend states
                newline, la
            ]
    | _, BAR_RBRACK ->
        match states with
        | Lookahead LookaheadConfig1.BAR_RBRACK ls -> [ newline, la ]
        | _ ->
            [
                yield! rrparen_or_rhsend states
                newline, la
            ]
    | _, RBRACE ->
        match states with
        | Lookahead LookaheadConfig1.RBRACE ls -> [ newline, la ]
        | _ ->
            [
                yield! rrparen_or_rhsend states
                newline, la
            ]
    | _, SEMICOLON ->
        match states with
        | Lookahead LookaheadConfig0.SEMICOLON ls -> [ newline, la ]
        | _ ->
            [
                yield! rrparen_or_rhsend states
                newline, la
            ]
    | Some i, BAR ->
        let rec loop current_states =
            match current_states with
            | TryFind Punctuation.BAR_MATCH ls ->
                let lead = YaccStateInfo.from current_states.[ls.Length - 1]
                match lead.position with
                | None ->
                    [
                        None, RHSEND
                        newline, la
                    ]
                | Some j ->
                    if j = i then
                        [ newline, la ]
                    elif j > i then
                        let next_states = parser.shift current_states (Light.none RHSEND)
                        [
                            None, RHSEND
                            yield! loop next_states
                        ]
                    else
                        failwith "stop"

            | Lookahead LookaheadConfig0.RRPAREN ls ->
                let ls, _ = Seq.exactlyOne ls
                let lead = YaccStateInfo.from current_states.[ls.Length - 2]
                match lead.position with
                | None -> failwith "llparen的第一个语句必须新启一行"
                | Some j ->
                    if j = i then
                        [ newline, la ]
                    elif j > i then
                        let next_states = parser.shift current_states (Light.none RRPAREN)
                        [
                            None, RRPAREN
                            yield! loop next_states
                        ]
                    else
                        failwith "没有对齐"
            | _ -> failwith "not impl"

        loop states
    | Some i, la ->
        let la_tag = FSharpToken.tag la
        if Punctuation.connectors.Contains la_tag then
            [ newline, la ]
        elif GrammarData.first_declExpr.Contains la_tag then
            match states with
            | StartsWith [ "[|" ] -> [ newline, la ]
            | StartsWith [ "[" ] -> [ newline, la ]
            | StartsWith [ "(" ] -> [ newline, la ]
            | StartsWith [ "{" ] -> [ newline, la ]
            | StartsWith [ "," ] -> [ newline, la ]
            | StartsWith [ "." ] -> [ newline, la ]
            | StartsWith [ ":" ] -> [ newline, la ]
            | StartsWith [ "*" ] -> [ newline, la ]
            | StartsWith [ "infix" ] -> [ newline, la ]
            | TryFind Punctuation.LLPAREN _ ->
                [
                    None, LLPAREN
                    newline, la
                ]
            | TryFind Punctuation.left_valueExpr ls ->
                let first = states.[ls.Length - 2]
                let s = YaccStateInfo.from first
                match s.position with
                | None -> failwith $"不支持格式：{s.tag}应该换行"
                | Some j ->
                    if j = i then
                        [
                            None, SEMICOLON
                            newline, la
                        ]
                    elif j < i then
                        [ newline, la ]
                    else
                        failwith $"不支持格式：{j} <= {i}"

            | Lookahead LookaheadConfig0.RHSEND _
            | Lookahead LookaheadConfig0.RRPAREN _ ->
                let ls = StackOps.newline_decl_rhsend_or_rrparen i states
                [
                    yield! ls
                    yield None, SEMICOLON
                    yield newline, la
                ]
            | _ -> [ newline, la ]

        else
            failwith "stop"

    | _ -> [ newline, la ]
