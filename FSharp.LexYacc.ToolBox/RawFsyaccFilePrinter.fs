module FSharp.LexYacc.RawFsyaccFilePrinter

//打印自己

open System
open System.Text.RegularExpressions

open FSharp.Idioms
open FSharp.Idioms.Literal

let renderSymbol (sym: string) =
    if System.String.IsNullOrEmpty sym then
        "\"\""
    elif
        Regex.IsMatch(sym, @"^_+$")
        || Regex.IsMatch(sym, @"\W")
    then
        stringify sym
    else
        sym

let renderSymbols (symbols: string list) =
    symbols
    |> List.map renderSymbol
    |> String.concat " "

let renderAssociativity (assoc: Associativity) =
    match assoc with
    | LeftAssoc -> "%left"
    | RightAssoc -> "%right"
    | NonAssoc -> "%nonassoc"

let renderPrecedenceStatement (stmt: PrecedenceStatement) =
    "%" + $"{renderAssociativity stmt.assoc} {renderSymbols stmt.ids}"

let renderDeclarationStatement (stmt: DeclarationStatement) =
    "%" + $"type<{stmt.typeTitle}> {renderSymbols stmt.ids}"

//render表示生成.yacc文件
let renderRhs (body: string list) =
    if body.IsEmpty then
        "(* empty *)"
    else
        renderSymbols body

let renderRuleBody body =
    [
        yield "|"
        yield renderRhs body.rhs
        if body.dummy = "" then
            ()
        else
            yield "%prec " + renderSymbol body.dummy
        yield body.reducer
    ]
    |> String.concat " "

let renderRuleGroup this =
    [
        renderSymbol this.lhs + " :"
        this.bodies
        |> List.map(fun bd -> renderRuleBody bd)
        |> Line.indentAll(4 * 4)
    ]
    |> String.concat "\r\n"

let render (fsyacc: RawFsyaccFile) =
    let h = fsyacc.header

    let r =
        fsyacc.ruleGroups
        |> List.map(fun ruleGroup -> renderRuleGroup ruleGroup)
        //|> String.concat "\r\n"

    let p () =
        fsyacc.precedenceStmts
        |> List.map(fun prec -> renderPrecedenceStatement prec)
        //|> String.concat "\r\n"

    let d () =
        fsyacc.declarationStmts
        |> List.map(fun dec -> renderDeclarationStatement dec)
        //|> String.concat "\r\n"

    [
        h

        yield! r

        if fsyacc.precedenceStmts.IsEmpty then
            ()
        else
            yield! p()

        if fsyacc.declarationStmts.IsEmpty then
            ()
        else
            yield! d()
    ]
    |> String.concat "\r\n"
