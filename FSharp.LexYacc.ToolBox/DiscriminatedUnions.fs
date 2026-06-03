module FSharp.LexYacc.DiscriminatedUnions

open System
open System.IO
open System.Text

open FSharp.Reflection

open FSharp.Idioms
open FSharp.Idioms.Literal
open System.Text.RegularExpressions

/// 工具函数，获取可区分联合的案例信息
let getUnionCases (unionType: Type) =
    let cases = FSharpType.GetUnionCases(unionType)
    cases
    |> Array.mapi(fun i case ->
        let fields = case.GetFields()
        let fieldTypes =
            fields
            |> Array.map(fun field -> field.PropertyType)
        i, case.Name, fieldTypes
    )

/// 工具函数，获取可区分联合的案例信息，带Tag符号信息
let tagedUnionCases<'u> (symbols: ('u * string) list) =
    let unionType = typeof<'u>

    let cases = FSharpType.GetUnionCases(unionType)

    let getTag (tok: 'u) =
        let caseInfo, _ = FSharpValue.GetUnionFields(tok, unionType)
        caseInfo.Name

    let symbols =
        symbols
        |> List.map(fun (tok, s) -> getTag tok, s)
        |> Map.ofList

    cases
    |> Array.mapi(fun i case ->
        let fields = case.GetFields()
        let fieldTypes =
            fields
            |> Array.map(fun field -> field.PropertyType)

        let tag =
            if symbols.ContainsKey case.Name then
                symbols.[case.Name]
            else
                case.Name
        i, case.Name, tag, fieldTypes
    )

let module_index<'u> =
    let unionType = typeof<'u>
    let cases = getUnionCases unionType

    let rhs =
        [
            "match tok with"
            yield!
                cases
                |> Array.map(fun (i, name, fields) ->
                    if fields.Length = 0 then
                        $"| {unionType.Name}.{name} -> {i}"
                    else
                        $"| {unionType.Name}.{name} _ -> {i}"
                )
        ]

    [
        $"let index (tok:{unionType.Name}) ="
        yield! rhs |> List.map(Line.indent 4)
    ]

let module_tag<'u> (symbols: ('u * string) list) =
    let unionType = typeof<'u>
    let cases = tagedUnionCases symbols
    let rhs =
        [
            "match tok with"
            yield!
                cases
                |> Array.map(fun (i, name, tag, fields) ->
                    if fields.Length = 0 then
                        $"| {unionType.Name}.{name} -> {stringify tag}"
                    else
                        $"| {unionType.Name}.{name} _ -> {stringify tag}"
                )
        ]

    [
        $"let tag (tok:{unionType.Name}) ="
        yield! rhs |> List.map(Line.indent 4)
    ]

let module_tagToIndex<'u> (symbols: ('u * string) list) =
    let unionType = typeof<'u>
    let cases = tagedUnionCases symbols
    let rhs =
        [
            "match tag with"
            yield!
                cases
                |> Array.map(fun (i, name, tag, fields) -> $"| {stringify tag} -> {i}")
            "| _ -> failwithf \"unexpected tag:%s\" tag"
        ]

    [
        "let tagToIndex (tag:string) ="
        yield! rhs |> List.map(Line.indent 4)
    ]

///传给yacc的荷载数据
let module_lexeme<'u> =
    let unionType = typeof<'u>
    let cases = getUnionCases unionType
    let rhs =
        [
            "match tok with"
            yield!
                cases
                |> Array.map(fun (i, name, fields) ->
                    match fields.Length with
                    | 0 -> $"| {unionType.Name}.{name} -> null"
                    | 1 -> $"| {unionType.Name}.{name} x -> box x"
                    | len ->
                        let ps =
                            [ 0 .. len - 1 ]
                            |> List.map(fun i -> string(char(int 'a' + i)))
                            |> String.concat ","
                        $"| {unionType.Name}.{name}({ps}) -> box({ps})"
                )
        ]

    [
        $"let lexeme (tok:{unionType.Name}) ="
        yield! rhs |> List.map(Line.indent 4)
    ]

/// 生成token模块中的常用方法
let generate_module<'u> (symbols: ('u * string) list) =
    let content =
        [
            module_index<'u>
            module_tag symbols
            module_tagToIndex symbols
            module_lexeme<'u>
        ]
        |> List.concat

    [
        $"module {typeof<'u>.Name} ="
        yield! content |> List.map(Line.indent 4)
    ]
    |> String.concat "\r\n"

///定义yacc中的token类型
let percent_type<'u> (symbols: ('u * string) list) =
    let cases = tagedUnionCases symbols
    cases
    |> Array.filter(fun (i, nm, tag, fs) -> fs.Length > 0)
    |> Array.map(fun (i, name, tag, fields) ->
        let typ =
            match fields.Length with
            | 0 -> failwith "filtered"
            | 1 -> fields.[0]
            | _ -> FSharpType.MakeTupleType fields
        "%type<"
        + stringifyTypeDynamic typ
        + "> "
        + stringify tag
    )
    |> String.concat "\r\n"

///缩进信息传给yacc
let lexeme_offside<'u> =
    let unionType = typeof<'u>
    let cases = getUnionCases unionType
    let rhs =
        [
            "match tok with"
            yield!
                cases
                |> Array.map(fun (i, name, fields) ->
                    match fields.Length with
                    | 0 -> $"| {unionType.Name}.{name} -> box spaces"
                    | 1 -> $"| {unionType.Name}.{name} x -> box(spaces, x)"
                    | len ->
                        let ps =
                            [ 0 .. len - 1 ]
                            |> List.map(fun i -> string(char(int 'a' + i)))
                            |> String.concat ", "
                        $"| {unionType.Name}.{name}({ps}) -> box(spaces, {ps})"
                )
        ]

    [
        $"let offsideLexeme (spaces:int option) (tok:{unionType.Name}) ="
        yield! rhs |> List.map(Line.indent 4)
    ]


///定义yacc中的token类型，带缩进信息
let percent_type_offside<'u> (symbols: ('u * string) list) =
    let cases = tagedUnionCases symbols
    cases
    |> Array.map(fun (i, name, tag, fields) ->
        let typ =
            match fields.Length with
            | 0 -> typeof<int option>
            | _ ->
                FSharpType.MakeTupleType
                    [|
                        typeof<int option>
                        yield! fields
                    |]

        "%type<"
        + stringifyTypeDynamic typ
        + "> "
        + RawFsyaccFilePrinter.renderSymbol tag
    )
    |> String.concat "\r\n"

///定义yacc中的token类型，带缩进信息
let percent_type_offside_group<'u> (symbols: ('u * string) list) =
    let cases = tagedUnionCases symbols
    cases
    |> Array.groupBy(fun (i, name, tag, fields) ->
        match fields.Length with
        | 0 -> typeof<int option>
        | _ ->
            FSharpType.MakeTupleType
                [|
                    typeof<int option>
                    yield! fields
                |]
    )
    |> Array.map(fun (typ, group) ->
        let tags =
            group
            |> Array.map(fun (_, _, tag, _) -> tag)
            |> Array.sort
            |> Array.map RawFsyaccFilePrinter.renderSymbol
            |> String.concat " "
        "%type<"
        + stringifyTypeDynamic typ
        + "> "
        + tags
    )
    |> String.concat "\r\n"

let symbol_entries<'u> (symbols: ('u * string) list) =
    let unionType = typeof<'u>
    let cases = tagedUnionCases symbols
    let rhs =
        [
            yield!
                cases
                |> Array.filter(fun (i, name, tag, fields) ->
                    symbols
                    |> Seq.exists(fun (_,symbol_tag) -> symbol_tag = tag)
                )
                |> Array.map(fun (i, name, tag, fields) ->
                    if fields.Length = 0 then
                        $"{unionType.Name}.{name}, {stringify tag}"
                    else
                        $"没有实现带参数的：{stringify (i, name)}"
                )
        ]

    [
        "/// 只需列出与 union case name 不同的符号名称"
        "let symbols = ["
        yield! rhs |> List.map(Line.indent 4)
        "]"
    ]
