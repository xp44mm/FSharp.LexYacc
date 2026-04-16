namespace FSharp.LexYacc

[<RequireQualifiedAccess>]
type FsyaccToken =
    | BRACES of code: string // new
    | PERCENT_TYPE of string // new
    | QUOTE of literal: string // new
    | ID of string
    | COLON
    | BAR
    | LEFTASSOC
    | RIGHTASSOC
    | NONASSOC
    | PREC

module FsyaccToken =
    let index (tok:FsyaccToken) =
        match tok with
        | FsyaccToken.BRACES _ -> 0
        | FsyaccToken.PERCENT_TYPE _ -> 1
        | FsyaccToken.QUOTE _ -> 2
        | FsyaccToken.ID _ -> 3
        | FsyaccToken.COLON -> 4
        | FsyaccToken.BAR -> 5
        | FsyaccToken.LEFTASSOC -> 6
        | FsyaccToken.RIGHTASSOC -> 7
        | FsyaccToken.NONASSOC -> 8
        | FsyaccToken.PREC -> 9
    let tag (tok:FsyaccToken) =
        match tok with
        | FsyaccToken.BRACES _ -> "BRACES"
        | FsyaccToken.PERCENT_TYPE _ -> "PERCENT_TYPE"
        | FsyaccToken.QUOTE _ -> "QUOTE"
        | FsyaccToken.ID _ -> "ID"
        | FsyaccToken.COLON -> ":"
        | FsyaccToken.BAR -> "|"
        | FsyaccToken.LEFTASSOC -> "%left"
        | FsyaccToken.RIGHTASSOC -> "%right"
        | FsyaccToken.NONASSOC -> "%nonassoc"
        | FsyaccToken.PREC -> "%prec"
    let tagToIndex (tag:string) =
        match tag with
        | "BRACES" -> 0
        | "PERCENT_TYPE" -> 1
        | "QUOTE" -> 2
        | "ID" -> 3
        | ":" -> 4
        | "|" -> 5
        | "%left" -> 6
        | "%right" -> 7
        | "%nonassoc" -> 8
        | "%prec" -> 9
        | _ -> failwith tag
    let lexeme (tok:FsyaccToken) =
        match tok with
        | FsyaccToken.BRACES x -> box x
        | FsyaccToken.PERCENT_TYPE x -> box x
        | FsyaccToken.QUOTE x -> box x
        | FsyaccToken.ID x -> box x
        | FsyaccToken.COLON -> null
        | FsyaccToken.BAR -> null
        | FsyaccToken.LEFTASSOC -> null
        | FsyaccToken.RIGHTASSOC -> null
        | FsyaccToken.NONASSOC -> null
        | FsyaccToken.PREC -> null
