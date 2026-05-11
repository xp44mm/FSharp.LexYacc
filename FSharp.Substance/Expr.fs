namespace FSharp.Substance

open System

type RuleClause = RuleClause of Pattern * guard: Expr option * result: Expr list
and RecordFiledBinding = RecordFiledBinding of string * Expr list
and Expr =
    | RecordLiteralExpr of RecordFiledBinding list
    | OpenExpr of string list
    | OperatorSectionExpr of string
    | LetBindingExpr of Pattern * Expr list
    | MatchExpr of Expr * RuleClause list
    | LambdaExpr of Pattern * Expr list
    | TupleExpr of Expr list
    | BinaryExpr of Expr * (string * Expr) list
    | UnaryExpr of string * Expr
    | AppExpr of Expr list
    | LiteralExpr of Literal
    | IdentExpr of string
    | ParenExpr of Expr list
    | ListExpr of Expr list
    | ArrayExpr of Expr list
    | BraceExpr of Expr list
    | BraceBarExpr of Expr list
    | QualificationExpr of Expr list
    | TypeApplicationExpr of string * TypeArgument list

module Expr =
    let ofSequentialExpr (revSequentialExpr: (option<int> * Expr) list) =
        let i, ls =
            revSequentialExpr
            |> List.rev
            |> List.unzip
        i.[0], ls

    let ofTupleExpr (revTupleExpr: (option<int> * Expr) list) =
        let i, ls = revTupleExpr |> List.rev |> List.unzip
        let e =
            if ls.Length > 1 then
                TupleExpr(ls)
            else
                ls.[0]
        i.[0], e

    ///最后一个元素是lambda表达式
    [<Obsolete("不再支持放宽规则")>]
    let ofTupleLambdaExpr
        (revTupleExpr: (option<int> * Expr) list)
        (lambdaExpr: option<int> * Expr)
        =
        let ls = revTupleExpr |> List.map snd
        let i, e = lambdaExpr
        let expr = TupleExpr(List.rev(e :: ls))
        i, expr

    let ofBinaryExpr (revBinaryExpr: ((option<int> * string) * (option<int> * Expr)) list) =
        let ops, exprs = revBinaryExpr |> List.rev |> List.unzip
        let ops = ops |> List.map snd
        let indents, exprs = exprs |> List.unzip
        let e =
            if exprs.Length > 1 then
                BinaryExpr(exprs.[0], List.zip ops.Tail exprs.Tail)
            else
                exprs.[0]
        indents.[0], e

    let ofAppExpr (revAppExpr: (option<int> * Expr) list) =
        let i, ls = revAppExpr |> List.rev |> List.unzip
        let e =
            if ls.Length > 1 then
                AppExpr ls
            else
                ls.[0]
        i.[0], e

    let ofQualification (revAppExpr: (option<int> * Expr) list) =
        let i, ls = revAppExpr |> List.rev |> List.unzip
        let e =
            if ls.Length > 1 then
                QualificationExpr ls
            else
                ls.[0]
        i.[0], e
