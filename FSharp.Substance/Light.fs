module FSharp.Substance.Light

open FSharp.Idioms

let transform (tokens: FSharpToken seq) =
    let iterator = Iterator tokens

    let rec loop (lastToken: FSharpToken) =
        seq {
            match iterator.tryNext() with
            | None -> ()
            | Some(NEW_LINE _ as tok) -> yield! loop tok
            | Some tok ->
                let ident =
                    match lastToken with
                    | NEW_LINE i -> Some i
                    | _ -> None
                yield ident, tok
                yield! loop tok
        }

    loop(NEW_LINE 0)
