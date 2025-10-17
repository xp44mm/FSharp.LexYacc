module FSharp.LexYacc.Interval

open System
open System.Diagnostics

open FSharp.Idioms.Literal

let MIN_NEVER = -7
let MAX_NEVER = 0xFFFFF

let FULL_RANGE = MIN_NEVER, MAX_NEVER

/// 合并重叠或相邻的范围
let merge (ranges: (int * int) list) =
    let rec loop (sorted: (int * int) list) =
        match sorted with
        | [] -> []
        | [ x ] -> [ x ]
        | (a1, b1) :: (a2, b2) :: rest ->
            if b1 >= a2 - 1 then
                loop((a1, max b1 b2) :: rest)
            else
                (a1, b1) :: loop((a2, b2) :: rest)

    ranges |> List.sort |> loop |> List.sort

/// 两个区间的交集
let intersect (s0, e0) (s1, e1) =
    let s2 = max s0 s1
    let e2 = min e0 e1
    if s2 <= e2 then Some(s2, e2) else None

//将重叠的区间分解成更小的、互不相交的子区间。
let disjoint (ranges: (int * int) seq) =
    // 获取所有边界点并排序
    let starts =
        ranges
        |> Seq.collect(fun (s, e) -> [ s; e + 1 ]) // 相邻区间的开始点 e + 1
        |> Set.ofSeq

    // 生成所有可能的子区间
    starts
    |> Seq.pairwise
    |> Seq.choose(fun (s0, s1) ->
        // 移除空区间
        if s0 >= s1 then
            None
        else
            Some(s0, s1 - 1)
    )
    |> Set.ofSeq

let complement (ranges: (int * int) list) =
    let merged = merge ranges
    if merged.IsEmpty then
        [ FULL_RANGE ]
    else
        // 获取所有边界点并排序
        let boundaries =
            merged |> List.collect(fun (s, e) -> [ s; e ]) //不要去重，点范围是重合的

        let complementBounds =
            if boundaries.Head = MIN_NEVER then
                boundaries.Tail // 要双不要单，会自动删除尾巴的MAX_NEVER
            else
                [
                    MIN_NEVER - 1
                    yield! boundaries
                    MAX_NEVER + 1
                ]

        complementBounds
        |> List.pairwise
        |> List.indexed
        |> List.choose(fun (i, (s, e)) ->
            if i % 2 = 0 then
                Some(s + 1, e - 1)
            else
                None
        )

///// 计算两个范围列表的差异 (left - right)
//let diff (left: (int * int) list) (right: (int * int) list) =
//    complement left @ right |> merge |> complement

/// 切分标签为字母表中的元素
let slice (alphabet: (int * int) list) (s: int) (e: int) =
    alphabet
    |> List.skipWhile(fun (_, i) -> i < s)
    |> List.takeWhile(fun (_, i) -> i <= e)

/// 已排序且不重叠的区间列表
let contains (e: int) (ranges: (int * int) list) : bool =
    let rec loop remaining =
        match remaining with
        | [] -> false
        | (s, f) :: rest ->
            if e < s then false // e 小于当前区间起点，后面区间更大，肯定不存在
            elif e <= f then true // e 在当前区间 [s, f] 内
            else loop rest // e > f，检查后面的区间
    loop ranges

let tryNextState
    (nextStates: Map<uint32, Set<(int * int) list * uint32>>)
    (state: uint32)
    (c: int)
    =
    match Map.tryFind state nextStates with
    | None -> None
    | Some ls ->
        ls
        |> Seq.tryPick(fun (cc, target) ->
            if contains c cc then
                Some target
            else
                None
        )
