module FSharp.Substance.Pen

open System
open System.IO
open System.Text

//FSharp.Literals

let isContinuation (line: string) =
    [ " "; "]"; "|]"; ")"; "|)"; "}"; "|}" ]
    |> Seq.exists(fun c -> line.StartsWith c)

let getTopLevels path =
    let lines =
        File.ReadAllLines(path, Encoding.UTF8)
        |> Array.toList
        |> List.filter(fun line -> String.IsNullOrWhiteSpace line |> not)

    let splitByIndent lines =
        let rec collect groups current =
            function
            | [] -> current :: groups
            | (h: string) :: t when isContinuation h -> collect groups (h :: current) t
            | h :: t -> collect (current :: groups) [ h ] t

        match lines with
        | [] -> []
        | (h: string) :: t when isContinuation h -> failwith "format error"
        | h :: t -> collect [] [ h ] t

    splitByIndent lines
    |> List.map List.rev
    |> List.rev

let getBindings path =
    path
    |> getTopLevels
    |> List.filter(fun lines -> lines.[0].StartsWith "let ")
    |> List.map(fun lines ->
        let i = lines.[0].IndexOf('=')
        let lhs = lines.[0].Substring(0, i)
        let rhs = lines.[0].Substring(i + 1)
        lhs, rhs :: lines.Tail
    )
