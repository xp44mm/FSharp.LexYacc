module FSharp.Substance.PEEK_BAR

let f =
    let x = 1
    match x with
    | 0 -> "zero"
    | 1 ->
        [] |> ignore
        "one"
    | _ -> "other"
    |> ignore
    let y = 2
    y

