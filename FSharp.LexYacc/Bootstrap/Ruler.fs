namespace FSharp.LexYacc.Bootstrap

open System
open FSharp.Idioms.Literal
open FSharp.LexYacc
open FSharp.Idioms

type LexicalRule<'a> = {
    head: ParsedRgx<'a>
    tail: ParsedRgx<'a> option
    action: string
} with

    //遇到最外层的Class开始转化为CharClass
    member rule.replaceId(definitions: Map<string, ParsedRgx<'a>>) =
        let replace = ParsedRgx.replaceId definitions
        {
            head = replace rule.head
            tail = Option.map replace rule.tail
            action = rule.action
        }

module LexicalRule =
    let just (head: ParsedRgx<'a>, tail: ParsedRgx<'a> option, action: string) = {
        head = head
        tail = tail
        action = action
    }

type Ruler<'a> = {
    parameters: string list
    funType: string
    rules: LexicalRule<'a> list
}

module Ruler =
    let just (parameters, funType, rules) = {
        parameters = parameters
        funType = funType
        rules = rules
    }

type RulerPrinter = {
    parameters: string list
    funType: string
    actions: (byte * string) list
} with
    static member from(ruler: Ruler<_>) = {
        parameters = ruler.parameters
        funType = ruler.funType
        actions =
            ruler.rules
            |> List.mapi(fun i rule -> byte i, rule.action)
    }

    member this.print() =
        let parameters = String.concat " " this.parameters
        [
            $"let actions {parameters}: Map<byte, {this.funType}> = Map ["
            for i, act in this.actions do
                let headLine =
                    Line.ident 4 $"{stringify i}, fun buff -> "
                match act with
                | Braces.SingleLine ln -> headLine + ln
                | Braces.MultiLine ls ->
                    let act = Line.identAll 8 ls
                    headLine + "\r\n" + act
                | Braces.Empty -> headLine + "failwith String.empty"
            Line.ident 4 "]"
        ]
        |> List.map(fun line -> line.TrimEnd())
        |> String.concat "\r\n"
