namespace FSharp.LexYacc

open System
open FSharp.Idioms
open FSharp.Idioms.Literal

//type ConflictedProduction = 
//    {
//        headOrLastTerminal: string
//        dummyToken: string
//        production: string list
//    }

//    static member from (rules: Rule Set) =
//        rules
//        |> RuleSet.conflictDummies 
//        |> Set.map(fun (p,h,d) -> {
//            headOrLastTerminal = h
//            dummyToken = d
//            production = p
//        })
