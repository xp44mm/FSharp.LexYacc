module FSharp.LexYacc.Experimental.BlockCommentLexerTailer

open FSharp.LexYacc
open FSharp.LexYacc.Experimental

let restBlockComment (iter: LexicalIterator<char * int>) =
    let next = BlockCommentLexer.anal.getIterator iter
    let result = ResizeArray<char>()
    let rec loop () =
        match next() with
        | None -> ()
        | Some(rule_id, buff) ->
            result.AddRange(buff)
            if buff.Length = 1 then
                loop ()
    loop ()
    result

