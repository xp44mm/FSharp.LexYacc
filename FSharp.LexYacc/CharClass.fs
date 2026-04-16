namespace FSharp.LexYacc

type CharClass =
    | SingleChar of int
    | RangeChar of int * int
    | Union of CharClass list
    | Negate of CharClass

    static member empty = Union []
    static member any = Negate CharClass.empty

open System
open FSharp.LexYacc.Interval

module CharClass =
    let validChar c =
        if c >= 0 && c <= int UInt16.MaxValue then
            ()
        else
            failwith "should c >= 0 && c <= int UInt16.MaxValue"

    let validRange (x: int) (y: int) =
        if x < y then
            ()
        else
            failwith "Should Range(x < y)"

    let SingleOrRange (a, b) =
        validChar a
        validChar b
        if a = b then
            SingleChar a
        else
            RangeChar(a, b)

    /// 将字符类转换为标准化形式（使用边界标记）
    let toIntervals (charClass: CharClass) =
        let rec loop (cc: CharClass) =
            match cc with
            | SingleChar c ->
                validChar c
                [ c, c ]

            | RangeChar(x, y) ->
                validChar x
                validChar y
                validRange x y
                [ x, y ]
            | Union [] -> []
            | Union ls -> ls |> List.collect loop
            | Negate(Union []) -> [ Interval.FULL_RANGE ]
            | Negate((SingleChar _ | RangeChar _ | Union _) as inner) -> complement(loop inner)
            | Negate(Negate inner) -> loop inner

        loop charClass |> Interval.merge
