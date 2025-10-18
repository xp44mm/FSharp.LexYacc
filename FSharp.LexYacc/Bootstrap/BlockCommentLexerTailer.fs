module FSharp.LexYacc.Bootstrap.BlockCommentLexerTailer

open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
open System.Text

let restBlockComment (iter: LexicalIterator<char * int>) =
    let next = BlockCommentLexer.anal.getIterator iter
    let result = StringBuilder(1024)
    let rec loop () =
        match next() with
        | None -> ()
        | Some(rule_id, buff) ->
            if buff.Length = 1 then
                result.Append(buff[0]) |> ignore
                loop ()
            else
                //result.Append(buff) |> ignore
                ()
    loop ()
    result.ToString()
