namespace FSharp.LexYacc

open System
open System.Text.RegularExpressions

open FSharp.Idioms
open FSharp.Idioms.Line

type RuleBody = {
    rhs: string list // right hand side
    dummy: string
    reducer: string // action
} // with


module RuleBody =
    let just (rhs, dummy, reducer) = {
        rhs = rhs
        dummy = dummy
        reducer = reducer
    }
