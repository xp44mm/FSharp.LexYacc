module FSharp.Substance.FSharpYacc

open FSharp.LexYacc
let stateSymbols: string[] = [|
    ""
    "file"
    "statements"
    "IDENT"
    "longid"
    "longid"
    "."
    "IDENT"
    "MODULE"
    "OPEN"
    "statement"
    "statement"
|]
let actions: (string * int) list list = [
    [
        "MODULE", 8
        "OPEN", 9
        "file", 1
        "statement", 10
        "statements", 2
    ]
    [ "", 0 ]
    [
        "", -1
        "MODULE", 8
        "OPEN", 9
        "statement", 11
    ]
    [
        "", -2
        ".", -2
        "MODULE", -2
        "OPEN", -2
    ]
    [
        "", -4
        ".", 6
        "MODULE", -4
        "OPEN", -4
    ]
    [
        "", -5
        ".", 6
        "MODULE", -5
        "OPEN", -5
    ]
    [ "IDENT", 7 ]
    [
        "", -3
        ".", -3
        "MODULE", -3
        "OPEN", -3
    ]
    [ "IDENT", 3; "longid", 4 ]
    [ "IDENT", 3; "longid", 5 ]
    [ "", -6; "MODULE", -6; "OPEN", -6 ]
    [ "", -7; "MODULE", -7; "OPEN", -7 ]
]
let rules: list<string list * (obj list -> obj)> = [
    [ ""; "file" ], fun (ss: obj list) -> ss.[0]
    [ "file"; "statements" ],
    fun (ss: obj list) ->
        let s0 = unbox<ModuleStatement list> ss.[0]
        let result: ModuleStatement list = List.rev s0
        box result
    [ "longid"; "IDENT" ],
    fun (ss: obj list) ->
        let s0 = unbox<string> ss.[0]
        let result: string list = [ s0 ]
        box result
    [ "longid"; "longid"; "."; "IDENT" ],
    fun (ss: obj list) ->
        let s0 = unbox<string list> ss.[0]
        let s2 = unbox<string> ss.[2]
        let result: string list = s2 :: s0
        box result
    [ "statement"; "MODULE"; "longid" ],
    fun (ss: obj list) ->
        let s1 = unbox<string list> ss.[1]
        let result: ModuleStatement = ModuleIntro(List.rev s1)
        box result
    [ "statement"; "OPEN"; "longid" ],
    fun (ss: obj list) ->
        let s1 = unbox<string list> ss.[1]
        let result: ModuleStatement = OpenStatement(List.rev s1)
        box result
    [ "statements"; "statement" ],
    fun (ss: obj list) ->
        let s0 = unbox<ModuleStatement> ss.[0]
        let result: ModuleStatement list = [ s0 ]
        box result
    [
        "statements"
        "statements"
        "statement"
    ],
    fun (ss: obj list) ->
        let s0 = unbox<ModuleStatement list> ss.[0]
        let s1 = unbox<ModuleStatement> ss.[1]
        let result: ModuleStatement list = s1 :: s0
        box result
]
let unboxRoot = unbox<ModuleStatement list>
let parser = ParseTable.from(rules, actions)
