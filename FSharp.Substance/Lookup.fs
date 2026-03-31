module FSharp.Substance.Lookup

open System
open System.IO
open System.Text

let fsharpKeywords =
    set [
        "and"
        "as"
        "assert"
        "base"
        "begin"
        "class"
        "default"
        "delegate"
        "do"
        "done"
        "downcast"
        "downto"
        "elif"
        "else"
        "end"
        "exception"
        "extern"
        "false"
        "finally"
        "fixed"
        "for"
        "fun"
        "function"
        "if"
        "in"
        "inherit"
        "interface"
        "internal"
        "lazy"
        "let"
        "match"
        "member"
        "module"
        "mutable"
        "namespace"
        "new"
        "null"
        "of"
        "open"
        "or"
        "override"
        "private"
        "public"
        "rec"
        "return"
        "select"
        "static"
        "struct"
        "then"
        "to"
        "true"
        "try"
        "type"
        "upcast"
        "use"
        "val"
        "void"
        "when"
        "while"
        "with"
        "yield"
    ]

let queryKeywords =
    set [
        "contains"
        "count"
        "distinct"
        "do"
        "exactlyOne"
        "exactlyOneOrDefault"
        "for"
        "groupBy"
        "groupJoin"
        "head"
        "headOrDefault"
        "in"
        "join"
        "last"
        "lastOrDefault"
        "select"
        "sortBy"
        "sortByDescending"
        "thenBy"
        "thenByDescending"
        "where"
    ]

let reservedIdentifiers =
    set [
        "__LINE__"
        "__SOURCE_DIRECTORY__"
        "__SOURCE_FILE__"
    ]

let futureKeywords =
    set [
        "atomic"
        "break"
        "checked"
        "component"
        "const"
        "constraint"
        "constructor"
        "continue"
        "eager"
        "event"
        "external"
        "functor"
        "include"
        "method"
        "mixin"
        "object"
        "parallel"
        "params"
        "process"
        "protected"
        "pure"
        "sealed"
        "tailcall"
        "trait"
        "virtual"
        "volatile"
    ]

let operatorKeywords =
    set [
        "op_Addition"
        "op_Division"
        "op_Equality"
        "op_GreaterThan"
        "op_GreaterThanOrEqual"
        "op_Inequality"
        "op_LessThan"
        "op_LessThanOrEqual"
        "op_Modulus"
        "op_Multiply"
        "op_Subtraction"
    ]

// 合并所有关键字（不包括查询关键字，因为它们只在特定上下文中）
let allKeywords =
    fsharpKeywords
    + reservedIdentifiers
    + futureKeywords
    + operatorKeywords

let computationKeywords =
    set [
        "and!"
        "do!"
        "let!"
        "match!"
        "return!"
        "use!"
        "while!"
        "yield!"
    ]
