namespace FSharp.LexYacc

type ParsedRgx<'a> =
    | ParsedRgxAny
    | ParsedRgxId of string
    | ParsedRgxSingle of 'a
    | ParsedRgxRange of 'a * 'a // 只用于 ParsedRgxClass | ParsedRgxNegClass
    | ParsedRgxClass of ParsedRgx<'a> list // list中元素只能是：ParsedRgxId+ParsedRgxChar+ParsedRgxRange
    | ParsedRgxNegClass of ParsedRgx<'a> list // list中元素只能是：ParsedRgxId+ParsedRgxChar+ParsedRgxRange
    | ParsedRgxAlt of a: ParsedRgx<'a> * b: ParsedRgx<'a>
    | ParsedRgxCat of a: ParsedRgx<'a> * b: ParsedRgx<'a>
    | ParsedRgxStar of ParsedRgx<'a>
    | ParsedRgxPlus of ParsedRgx<'a>
    | ParsedRgxOpt of ParsedRgx<'a>

module ParsedRgx =

    // 辅助函数：替换单个表达式中的ID
    let rec replaceId
        (definitions: Map<string, ParsedRgx<'a>>)
        (rgx: ParsedRgx<'a>)
        : ParsedRgx<'a>
        =
        match rgx with
        | ParsedRgxId id -> definitions.[id]

        | ParsedRgxAny
        | ParsedRgxSingle _
        | ParsedRgxRange _ -> rgx

        | ParsedRgxClass items ->
            let newItems =
                items
                |> List.map(fun item ->
                    match item with
                    | ParsedRgxId id -> definitions.[id]
                    | ParsedRgxAny
                    | ParsedRgxSingle _
                    | ParsedRgxRange _ -> item
                    | _ -> failwith "never"
                )
            ParsedRgxClass(newItems)

        | ParsedRgxNegClass items ->
            let newItems =
                items
                |> List.map(fun item ->
                    match item with
                    | ParsedRgxId id -> definitions.[id]
                    | ParsedRgxAny
                    | ParsedRgxSingle _
                    | ParsedRgxRange _ -> item
                    | _ -> failwith "never"
                )
            ParsedRgxNegClass(newItems)

        | ParsedRgxAlt(a, b) ->
            ParsedRgxAlt(replaceId definitions a, replaceId definitions b)
        | ParsedRgxCat(a, b) ->
            ParsedRgxCat(replaceId definitions a, replaceId definitions b)
        | ParsedRgxStar inner -> ParsedRgxStar(replaceId definitions inner)
        | ParsedRgxPlus inner -> ParsedRgxPlus(replaceId definitions inner)
        | ParsedRgxOpt inner -> ParsedRgxOpt(replaceId definitions inner)

    /// 定义的右侧，即定义的正则表达式标准化。
    let replaceAllIds (definitions: list<string * ParsedRgx<'a>>) =
        let rec loop mp defs =
            match defs with
            | [] -> mp
            | (id, expr) :: rest ->
                let expr = replaceId mp expr
                let newMp = Map.add id expr mp
                loop newMp rest
        match definitions with
        | [] -> Map.empty
        | h :: t -> loop (Map [ h ]) t

    let toRegExp (getValue: 'a -> int) (rgx: ParsedRgx<'a>) =
        let rec loopClass (rgx: ParsedRgx<'a>) =
            match rgx with
            | ParsedRgxId id -> failwith "请先消除ID"
            | ParsedRgxAny -> CharClass.any
            | ParsedRgxSingle c ->
                let i = getValue c
                CharClass.SingleChar i
            | ParsedRgxRange(s, e) ->
                let x1 = getValue s
                let x2 = getValue e
                CharClass.RangeChar(x1, x2)

            | ParsedRgxClass items -> CharClass.Union(List.map loopClass items)

            | ParsedRgxNegClass items ->
                CharClass.Negate(CharClass.Union(List.map loopClass items))

            | ParsedRgxAlt _
            | ParsedRgxCat _
            | ParsedRgxStar _
            | ParsedRgxPlus _
            | ParsedRgxOpt _ -> failwith "字符类不要包括正则表达式变量"

        let rec loop (rgx: ParsedRgx<'a>) =
            match rgx with
            | ParsedRgxId id -> failwith "请先消除ID"
            | ParsedRgxAny -> RegExp.RgxLeaf CharClass.any
            | ParsedRgxSingle c ->
                let i = getValue c
                RegExp.RgxLeaf(CharClass.SingleChar i)
            | ParsedRgxRange(s, e) ->
                let x1 = getValue s
                let x2 = getValue e
                RegExp.RgxLeaf(CharClass.RangeChar(x1, x2))

            | ParsedRgxClass _
            | ParsedRgxNegClass _ -> RegExp.RgxLeaf(loopClass rgx)

            | ParsedRgxAlt(a, b) -> RegExp.RgxAlt(loop a, loop b)
            | ParsedRgxCat(a, b) -> RegExp.RgxCat(loop a, loop b)
            | ParsedRgxStar inner -> RegExp.RgxStar(loop inner)
            | ParsedRgxPlus inner -> RegExp.RgxPlus(loop inner)
            | ParsedRgxOpt inner -> RegExp.RgxOpt(loop inner)
        loop rgx
