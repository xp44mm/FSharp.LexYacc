module FSharp.LexYacc.Braces

open System
open FSharp.Idioms

let unbraces (braces: string) =
    if braces = "" then
        ""
    else
        braces.Substring(1, braces.Length - 2)

///打印头
let sliceContent (braces: string) =
    let u = unbraces braces

    let lines =
        u
        |> Line.splitToLines
        |> Array.filter(fun ln -> not(String.IsNullOrWhiteSpace ln))

    if lines.Length = 0 then
        ""
    elif lines.Length = 1 then
        u.Trim()
    else
        // 如果有换行，{后面不允许有内容，单行注释，多行注释，也需要遵守缩进规则

        //代码左侧的空白
        let prefix =
            lines.[0] // 第一行一定是最靠右的
            |> Seq.takeWhile((=) ' ')
            |> Seq.length

        lines
        |> Array.map(fun ln -> ln.Substring(prefix))
        |> String.concat "\r\n"

let (|Empty|SingleLine|MultiLine|) (braces: string) =
    let u = unbraces braces

    let lines =
        u
        |> Line.splitToLines
        |> Array.filter(fun ln -> not(String.IsNullOrWhiteSpace ln))

    if lines.Length = 0 then
        Empty
    elif lines.Length = 1 then
        SingleLine(u.Trim())
    else
        // 如果有换行，{后面不允许有内容，单行注释，多行注释，也需要遵守缩进规则

        //代码左侧的空白
        let prefix =
            lines.[0] // 第一行一定是最靠右的
            |> Seq.takeWhile((=) ' ')
            |> Seq.length
        let lines =
            lines |> Array.map(fun ln -> ln.Substring(prefix))
        //|> String.concat "\r\n"
        MultiLine lines
