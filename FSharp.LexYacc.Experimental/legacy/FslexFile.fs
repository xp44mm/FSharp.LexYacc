namespace FSharp.LexYacc.Experimental

open FSharp.LexYacc

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

/// 代表.fslex输入文件的结构化表示
type FslexFile<'a> = {
    header: string
    definitions: (string * ParsedRgx<'a>) list
    ruler: Ruler<'a>
} with
    member lexfile.getPatterns(getValue: 'a -> int) =
        let defs =
            lexfile.definitions |> ParsedRgx.replaceAllIds
        let rules =
            lexfile.ruler.rules
            |> List.map(fun rule -> rule.replaceId defs)
        let patterns =
            rules
            |> List.map(fun rule ->
                let head = ParsedRgx.toRegExp getValue rule.head
                let tail =
                    Option.map (ParsedRgx.toRegExp getValue) rule.tail
                id<LookaheadRegExp> { head = head; tail = tail }
            )
        patterns

module FslexFile =
    let just (header, definitions, ruler) = {
        header = header
        definitions = definitions
        ruler = ruler
    }
