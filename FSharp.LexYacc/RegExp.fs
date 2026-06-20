namespace FSharp.LexYacc

/// 3.3 正则表达式
type RegExp =
    | RgxLeaf of CharClass
    /// 'a' | 'b' disjunction
    | RgxAlt of a: RegExp * b: RegExp
    /// 'a' 'b' & conjunction
    | RgxCat of a: RegExp * b: RegExp
    /// a*
    | RgxStar of RegExp
    /// a+
    | RgxPlus of RegExp
    /// a?
    | RgxOpt of RegExp

    member this.rev() =
        let rec loop (re: RegExp) =
            match re with
            | RgxLeaf c -> re
            | RgxAlt(a, b) -> RgxAlt(loop a, loop b)
            | RgxCat(a, b) -> RgxCat(loop b, loop a)
            | RgxStar i -> RgxStar(loop i)
            | RgxPlus i -> RgxPlus(loop i)
            | RgxOpt i -> RgxOpt(loop i)
        loop this

type LookaheadRegExp = {
    head: RegExp
    tail: RegExp option
} with
    static member from(head, tail) = {
        head = head
        tail = Some tail
    }
    static member from(head) = {
        head = head
        tail = None
    }
