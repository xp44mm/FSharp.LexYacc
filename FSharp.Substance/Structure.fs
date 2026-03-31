namespace FSharp.Substance

open FSharp.LexYacc.Bootstrap

[<RequireQualifiedAccess>]
type Structure =
    | Primitive of Literal
    | Tuple of Structure list
    | List of Structure list
    | Array of Structure list
    | UnionCase of string * Structure list
    | Record of (string * Structure) list
