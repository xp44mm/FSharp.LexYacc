namespace FSharp.Substance

/// 又名：signature syntax

type SuffixType =
    | IdentSuffix of string list
    | ArrayTypeSuffix of int

type TypeArgument =
    | FunType of TypeArgument list
    | TupleType of TypeArgument list
    | AppType of atomtype: TypeArgument * suffixTypes: SuffixType list
    | Typar of string
    | NamedType of longIdent: string list
    | GenericType of longIdent: string list * TypeArgument list
    | ParenType of TypeArgument

module TypeArgument =
    let ofApp (atomtype: option<int> * TypeArgument, suffixTypes: (option<int> * SuffixType) list) =
        match suffixTypes with
        | [] -> atomtype
        | _ ->
            let suffixTypes = suffixTypes |> List.rev |> List.map snd
            fst atomtype, AppType(snd atomtype, suffixTypes)

    let ofTuple (ls: (option<int> * TypeArgument) list) =
        match ls with
        | [] -> failwith ""
        | [ x ] -> x
        | _ ->
            let i, ls = ls |> List.rev |> List.unzip
            i.[0], TupleType(ls)

    let ofFun (ls: (option<int> * TypeArgument) list) =
        match ls with
        | [] -> failwith ""
        | [ x ] -> x
        | _ ->
            let i, ls = ls |> List.rev |> List.unzip
            i.[0], FunType(ls)

