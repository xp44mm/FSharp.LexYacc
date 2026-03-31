module FSharp.Substance.FSharpLexerTailer

open FSharp.LexYacc

/// char具体的字符，int代表char所属的类编号
let tokenize (iter: LexicalIterator<char * int>) =
    let actions = FSharpLexer.actions
    let tryNext = FSharpLexer.anal.getIterator iter

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
