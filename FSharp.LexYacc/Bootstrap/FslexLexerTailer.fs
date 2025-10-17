module FSharp.LexYacc.Bootstrap.FslexLexerTailer

open System

open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap

/// 分析*.fslex文件
let tokenize (iter: LexicalIterator<char * int>) =
    let restBlockComment () =
        BlockCommentLexerTailer.restBlockComment iter

    let restBraces () = 
        BracesLexerTailer.restBraces iter

    let actions = FslexLexer.actions restBlockComment restBraces

    let tryNext = FslexLexer.anal.getIterator iter

    let rec loop () =
        seq {
            match tryNext() with
            | None -> ()
            | Some(rule_id, buff) ->
                let action = actions.[rule_id]
                let tok = action buff
                yield! tok
                yield! loop ()
        }
    loop ()
