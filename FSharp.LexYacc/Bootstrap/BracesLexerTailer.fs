module FSharp.LexYacc.Bootstrap.BracesLexerTailer

open System

open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap

let restBraces (iter: LexicalIterator<char * int>) =
    let restBlockComment () =
        BlockCommentLexerTailer.restBlockComment iter

    let actions = BracesLexer.actions restBlockComment
    let tryNext = BracesLexer.anal.getIterator iter

    let total = ResizeArray<char>()
    let rec loop countDown =
        match tryNext() with
        | None -> ()
        | Some(rule_id, buff) ->
            let action = actions.[rule_id]
            let tok = action buff
            match tok with
            | LBRACE ->
                total.Add '{'
                loop(countDown + 1)
            | RBRACE ->
                total.Add '}'
                if countDown = 1 then
                    ()
                else
                    loop(countDown - 1)
            | BUFF c ->
                total.AddRange c
                loop countDown
    loop 1
    total
