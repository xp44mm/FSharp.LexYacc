namespace FSharp.Substance

open FSharp.Substance.FSharpYacc

open FSharp.Idioms.Literal

open FSharp.LexYacc

type YaccStateInfo =
    {
        position: int option
        tag: string
        data: string
    }

    //static member from(state: YaccState) =
    //    let tag = stateSymbols.[state.state]
    //    let position, data =
    //        match tag with
    //        | "!"
    //        | "#"
    //        | "*"
    //        | "("
    //        | "(|"
    //        | ")"
    //        | "+"
    //        | ","
    //        | "-"
    //        | "->"
    //        | "."
    //        | ":"
    //        | ";"
    //        | "<"
    //        | "<-"
    //        | "="
    //        | ">"
    //        | "DO"
    //        | "EOF"
    //        | "FUN"
    //        | "LET"
    //        | "LLPAREN"
    //        | "MATCH"
    //        | "MODULE"
    //        | "OPEN"
    //        | "RHSEND"
    //        | "RRPAREN"
    //        | "WHITESPACE"
    //        | "WITH"
    //        | "["
    //        | "[|"
    //        | "]"
    //        | "opt_semicolon"
    //        | "{"
    //        | "{|"
    //        | "|"
    //        | "|)"
    //        | "|]"
    //        | "|}"
    //        | "}" -> unbox<option<int>> state.lexeme, tag

    //        | "ALWAYS_INFIX"
    //        | "ALWAYS_PREFIX"
    //        | "IDENT"
    //        | "TYPAR"
    //        | "infix"
    //        | "prefix" ->
    //            let i, d = unbox<option<int> * string> state.lexeme
    //            i, stringify d
    //        | "LITERAL" ->
    //            let i, d = unbox<option<int> * Literal> state.lexeme
    //            i, stringify d
    //        | "appExpr"
    //        | "arrayExpr"
    //        | "atomicExpr"
    //        | "binaryExpr"
    //        | "declExpr"
    //        | "identExpr"
    //        | "lambdaExpr"
    //        | "letBinding"
    //        | "listExpr"
    //        | "openOrLet"
    //        | "parenExpr"
    //        | "qualificationExpr"
    //        | "qualificationSuffix"
    //        | "tupleExpr"
    //        | "unaryExpr"
    //        | "valueExpr" ->
    //            let i, d = unbox<option<int> * Expr> state.lexeme
    //            i, stringify d
    //        | "appType" ->
    //            let (i, targ), ls =
    //                unbox<(option<int> * TypeArgument) * list<option<int> * SuffixType>>
    //                    state.lexeme
    //            let ls = ls |> List.map snd
    //            i, stringify(targ, ls)
    //        | "atomType"
    //        | "typeArgument" ->
    //            let i, d = unbox<option<int> * TypeArgument> state.lexeme
    //            i, stringify d
    //        | "atomicPattern"
    //        | "bindingPattern"
    //        | "parameterPattern" ->
    //            let i, d = unbox<option<int> * Pattern> state.lexeme
    //            i, stringify d
    //        | "file" -> None, stringifyDynamic typeof<list<string> * list<Expr>> state.lexeme
    //        | "funType"
    //        | "tupleType"
    //        | "typeArguments" ->
    //            let ls = unbox<list<option<int> * TypeArgument>> state.lexeme
    //            let i, ls = ls |> List.unzip
    //            i.[0], stringify ls
    //        | "longid" ->
    //            let i, d = unbox<option<int> * list<string>> state.lexeme
    //            i, stringify d
    //        | "revAppExpr"
    //        | "revOpenOrLets"
    //        | "revQualificationExpr"
    //        | "revSequentialExpr"
    //        | "revTupleExpr" ->
    //            let ls = unbox<list<option<int> * Expr>> state.lexeme
    //            let i, ls = ls |> List.unzip
    //            i.[0], stringify ls
    //        | "revBinaryExpr" ->
    //            let ls = unbox<list<(option<int> * string) * (option<int> * Expr)>> state.lexeme
    //            let i = ls |> Seq.map(fun (a, _) -> fst a) |> Seq.head
    //            let data = ls |> List.map(fun (a, b) -> snd a, snd b)
    //            i, stringify data
    //        | "revLongid" ->
    //            let ls = unbox<list<option<int> * string>> state.lexeme
    //            let i, ls = ls |> List.unzip
    //            i.[0], stringify ls
    //        | "rhsBlock" ->
    //            let i, d = unbox<option<int> * list<Expr>> state.lexeme
    //            i, stringify d
    //        | "suffixType" ->
    //            let i, d = unbox<option<int> * SuffixType> state.lexeme
    //            i, stringify d
    //        | "tuplePattern" ->
    //            let ls = unbox<list<option<int> * Pattern>> state.lexeme
    //            let i, ls = ls |> List.unzip
    //            i.[0], stringify ls

    //        | symbol -> failwith $"没有这个符号:{symbol}"
    //    {
    //        position = position
    //        tag = tag
    //        data = data
    //    }

    static member from(state: YaccState) =
        let tag = stateSymbols.[state.state]
        let position, data =
            match tag with
            | "!"
            | "#"
            | "("
            | "(|"
            | ")"
            | "*"
            | "+"
            | ","
            | "-"
            | "->"
            | "."
            | ":"
            | ";"
            | "<"
            | "<-"
            | "="
            | ">"
            | "DO"
            | "EOF"
            | "FUN"
            | "LET"
            | "LLPAREN"
            | "MATCH"
            | "MODULE"
            | "OPEN"
            | "RHSEND"
            | "RRPAREN"
            | "WHEN"
            | "WHITESPACE"
            | "WITH"
            | "["
            | "[|"
            | "]"
            | "opt_bar"
            | "opt_semicolon"
            | "{"
            | "{|"
            | "|"
            | "|)"
            | "|]"
            | "|}"
            | "}" -> unbox<option<int>> state.lexeme, tag
            | "ALWAYS_INFIX"
            | "ALWAYS_PREFIX"
            | "IDENT"
            | "TYPAR"
            | "infix"
            | "prefix" ->
                let i, d = unbox<option<int> * string> state.lexeme
                i, stringify d
            | "LITERAL" ->
                let i, d = unbox<option<int> * Literal> state.lexeme
                i, stringify d
            | "appExpr"
            | "arrayExpr"
            | "atomicExpr"
            | "binaryExpr"
            | "declExpr"
            | "identExpr"
            | "lambdaExpr"
            | "letBinding"
            | "listExpr"
            | "matchExpr"
            | "openOrLet"
            | "parenExpr"
            | "qualificationExpr"
            | "qualificationSuffix"
            | "tupleExpr"
            | "unaryExpr"
            | "valueExpr" ->
                let i, d = unbox<option<int> * Expr> state.lexeme
                i, stringify d
            | "appType" ->
                let (i, targ), ls =
                    unbox<(option<int> * TypeArgument) * list<option<int> * SuffixType>>
                        state.lexeme
                let ls = ls |> List.map snd
                i, stringify(targ, ls)
            | "atomType"
            | "typeArgument" ->
                let i, d = unbox<option<int> * TypeArgument> state.lexeme
                i, stringify d
            | "atomicPattern"
            | "bindingPattern"
            | "matchPattern"
            | "parameterPattern" ->
                let i, d = unbox<option<int> * Pattern> state.lexeme
                i, stringify d
            | "file" -> None, stringifyDynamic typeof<list<string> * list<Expr>> state.lexeme
            | "funType"
            | "tupleType"
            | "typeArguments" ->
                let ls = unbox<list<option<int> * TypeArgument>> state.lexeme
                let i, ls = ls |> List.unzip
                i.[0], stringify ls
            | "longid" ->
                let i, d = unbox<option<int> * list<string>> state.lexeme
                i, stringify d
            | "patternAndGuard" ->
                let i, p, e = unbox<option<int> * Pattern * option<Expr>> state.lexeme
                i, stringify(p, e)
            | "revAppExpr"
            | "revOpenOrLets"
            | "revQualificationExpr"
            | "revSequentialExpr"
            | "revTupleExpr" ->
                let ls = unbox<list<option<int> * Expr>> state.lexeme
                let i, ls = ls |> List.unzip
                i.[0], stringify ls
            | "revBinaryExpr" ->
                let ls =
                    unbox<list<(option<int> * string) * (option<int> * Expr)>> state.lexeme
                let i =
                    ls
                    |> Seq.map(fun (a, _) -> fst a)
                    |> Seq.head
                let data =
                    ls
                    |> List.map(fun (a, b) -> snd a, snd b)
                i, stringify data
            | "revLongid" ->
                let ls = unbox<list<option<int> * string>> state.lexeme
                let i, ls = ls |> List.unzip
                i.[0], stringify ls
            | "revRuleClauses" ->
                let ls = unbox<list<option<int> * RuleClause>> state.lexeme
                let i, ls = ls |> List.unzip
                i.[0], stringify ls
            | "ruleClause" ->
                let i, d = unbox<option<int> * RuleClause> state.lexeme
                i, stringify d
            | "suffixType" ->
                let i, d = unbox<option<int> * SuffixType> state.lexeme
                i, stringify d
            | "tuplePattern" ->
                let ls = unbox<list<option<int> * Pattern>> state.lexeme
                let i, ls = ls |> List.unzip
                i.[0], stringify ls

            | symbol -> failwith $"没有这个符号:{symbol}"
        {
            position = position
            tag = tag
            data = data
        }
