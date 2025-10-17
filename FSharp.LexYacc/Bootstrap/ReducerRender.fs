module FSharp.LexYacc.Bootstrap.ReducerRender

open System
open FSharp.Idioms

let reducerBody
    (declarations: Map<string, string>)
    (production: string list)
    (reducer: string)
    =
    let bodySymbols =
        production
        |> List.tail
        |> List.mapi(fun i s -> i, s)
        |> List.filter(fun (i, s) -> declarations.ContainsKey s)

    let mainLines =
        [
            for (i, sym) in bodySymbols do
                if declarations.ContainsKey sym then
                    $"let s{i} = unbox<{declarations.[sym]}> ss.[{i}]"
                else
                    failwith $"type annot `{sym}` is required."

            if declarations.ContainsKey production.Head then

                $"let result:{declarations.[production.Head]} ="
                [reducer] |> Line.identAll 4
                $"box result"
            else
                reducer
                "null"
        ]
        |> String.concat Environment.NewLine

    if production.Head = "" then "ss.[0]"
    elif reducer = "" then "null"
    else mainLines

let decorateReducer
    (declarations: Map<string, string>)
    (production: string list)
    (reducer: string)
    =
    let body = reducerBody declarations production reducer
    let funcDef =
        [
            "fun(ss:obj list)->"
            [body] |> Line.identAll 4
        ]
        |> String.concat Environment.NewLine
    funcDef
