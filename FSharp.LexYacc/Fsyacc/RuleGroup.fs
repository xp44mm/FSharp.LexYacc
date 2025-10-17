namespace FSharp.LexYacc
open System
open FSharp.Idioms
open FSharp.Idioms.Line

type RuleGroup =
    {
        lhs: string // left hand side
        bodies: RuleBody list
    }

module RuleGroup =
    let just (lhs, bodies) = { lhs = lhs; bodies = bodies }
