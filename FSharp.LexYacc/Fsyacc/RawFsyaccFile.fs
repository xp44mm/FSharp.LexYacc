namespace FSharp.LexYacc

open System

open FSharp.Idioms
open FSharp.Idioms.Line

type PrecedenceStatement = { assoc: Associativity; ids: string list }
module PrecedenceStatement =
    let just (assoc, ids) = { assoc = assoc; ids = ids }

type DeclarationStatement = { typeTitle: string; ids: string list }
module DeclarationStatement =
    let just (typeTitle, ids) = { typeTitle = typeTitle; ids = ids }

//内嵌在*.yacc源文件的reducer中，表示yacc的返回结果。
type RawFsyaccFile = {
    header: string
    ruleGroups: RuleGroup list
    precedenceStmts: PrecedenceStatement list
    declarationStmts: DeclarationStatement list
}

module RawFsyaccFile =
    let just (header, ruleGroups, precedenceStmts, declarationStmts) = {
        header = header
        ruleGroups = ruleGroups
        precedenceStmts = precedenceStmts
        declarationStmts = declarationStmts
    }
