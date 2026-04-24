namespace FSharp.Substance

type Expr =
    | DummyExpr
    | OpenExpr of string list
    | LetBindingExpr of string * Expr list
    | LambdaExpr of string * Expr list
    | TupleExpr of Expr list
    | BinaryExpr of string * Expr * Expr
    | UnaryExpr of string * Expr
    | AppExpr of Expr list
    | LiteralExpr of Literal
    | IdentExpr of string list
    | ParenExpr of Expr list
    | ListExpr of Expr list
    | ArrayExpr of Expr list
    | BraceExpr of Expr list
    | BraceBarExpr of Expr list


