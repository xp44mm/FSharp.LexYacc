namespace FSharp.Substance

open System
open System.Diagnostics

open FSharp.Idioms
open FSharp.Idioms.Literal

type IfBranch = IfBranch of condition: Expr option * result: Expr list
and RuleClause = RuleClause of Pattern * guard: Expr option * result: Expr list
and RecordFiledBinding = RecordFiledBinding of string * Expr list
and Expr =
    | RecordLiteralExpr of RecordFiledBinding list
    | OpenExpr of string list
    | OperatorSectionExpr of string
    | LetBindingExpr of keyword: string * string list * Pattern * Expr list
    | IfExpr of IfBranch list
    | MatchExpr of keyword: string * Expr * RuleClause list
    | TryWithExpr of Expr list* RuleClause list
    | TryFinallyExpr  of Expr list* Expr list
    | FunctionExpr of RuleClause list
    | LambdaExpr of Pattern * Expr list
    | TupleExpr of Expr list
    | BinaryExpr of (Expr * string) list
    | UnaryExpr of string * Expr
    | AppExpr of Expr list
    | LiteralExpr of Literal
    | IdentExpr of string
    | ParenExpr of Expr list
    | ListExpr of Expr list
    | ArrayExpr of Expr list
    | BraceExpr of Expr list
    | QualificationExpr of Expr list
    | TypeApplicationExpr of string * TypeArgument list
    | AssignmentExpr of Expr * Expr list
    | WhileExpr of keyword: string * Expr * Expr list
    | ForExpr of Pattern * Expr * Expr list
    | ProduceExpr of keyword: string * Expr
    | TypeAnnotatedExpr of Expr * TypeArgument

module Expr =
    let ofSequentialExpr (revSequentialExpr: (option<int> * Expr) list) =
        let i, ls =
            revSequentialExpr
            |> List.rev
            |> List.unzip
        i.[0], ls

    let ofTupleExpr (revTupleExpr: (option<int> * Expr) list) =
        Light.degenerate TupleExpr revTupleExpr

        //let i, ls = revTupleExpr |> List.rev |> List.unzip
        //let e =
        //    if ls.Length > 1 then
        //        TupleExpr(ls)
        //    else
        //        ls.[0]
        //i.[0], e

    let ofBinaryExpr (revBinaryExpr: (option<int> * Either<string, Expr>) list) =
        let operators, operands =
            revBinaryExpr
            |> List.partition(fun (_, e) ->
                match e with
                | Left _ -> true
                | _ -> false
            )

        let operators =
            operators
            |> List.map(fun (i, e) ->
                match e with
                | Left l -> l
                | _ -> failwith ""
            )

        let i = operands |> List.map(fst) |> Seq.head

        let operands =
            operands
            |> List.map(fun (i, e) ->
                match e with
                | Right l -> l
                | _ -> failwith ""
            )

        let e =
            if operands.Length > 1 then
                let ls = List.zip operands ("" :: operators)
                BinaryExpr(List.rev ls)
            else
                Debug.Assert((operators = []))
                operands.[0]
        i, e

    let ofAppExpr (revAppExpr: (option<int> * Expr) list) =
        Light.degenerate AppExpr revAppExpr

        //let i, ls = revAppExpr |> List.rev |> List.unzip
        //let e =
        //    if ls.Length > 1 then
        //        AppExpr ls
        //    else
        //        ls.[0]
        //i.[0], e

    let ofQualification (revExprs: (option<int> * Expr) list) =
        Light.degenerate QualificationExpr revExprs

        //let i, ls = revAppExpr |> List.rev |> List.unzip
        //let e =
        //    if ls.Length > 1 then
        //        QualificationExpr ls
        //    else
        //        ls.[0]
        //i.[0], e

    let ofIfExpr (revIfParts:(option<int>*IfBranch) list) =
        let i, ls = revIfParts |> List.rev |> List.unzip
        i.[0], IfExpr ls
