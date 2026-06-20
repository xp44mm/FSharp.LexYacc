namespace FSharp.Substance

open FSharp.Substance.FSharpYacc

open FSharp.Idioms.Literal

open FSharp.LexYacc
open FSharp.Idioms

type YaccStateInfo =
    {
        position: int option
        tag: string
        data: string
    }

    static member from(state: YaccState) =
        let tag = stateSymbols.[state.state]
        let position, data =
            match tag with
            | "(" | "(|" | ")" | "*" | "+" | "," | "-" | "->" | "." | ":" | ";" | "<" | "<-" | "=" | ">" | "AND" | "AND_BANG" | "DO" | "DO_BANG" | "ELIF" | "ELSE" | "EOF" | "FOR" | "FUN" | "FUNCTION" | "IF" | "IN" | "LET" | "LET_BANG" | "LLPAREN" | "MATCH" | "MATCH_BANG" | "MODULE" | "OPEN" | "RETURN" | "RETURN_BANG" | "RHSEND" | "RRPAREN" | "THEN" | "USE" | "USE_BANG" | "WHEN" | "WHILE" | "WHILE_BANG" | "WITH" | "YIELD" | "YIELD_BANG" | "[" | "[|" | "]" | "opt_bar" | "{" | "|" | "|)" | "|]" | "}"
                ->
                unbox<option<int>> state.lexeme, tag
            | "ALWAYS_INFIX" | "ALWAYS_PREFIX" | "IDENT" | "TYPAR" | "bindKeyword" | "infix" | "matchKeyword" | "prefix" | "produceKeyword" | "whileKeyword"
                ->
                let i, d = unbox<option<int>*string> state.lexeme
                i, stringify d
            | "LITERAL"
                ->
                let i, d = unbox<option<int>*Literal> state.lexeme
                i, stringify d
            | "appExpr" | "arrayExpr" | "atomicExpr" | "binaryExpr" | "bindExpr" | "declExpr" | "identExpr" | "ifExpr" | "lambdaExpr" | "listExpr" | "matchExpr" | "openOrLet" | "parenExpr" | "qualificationExpr" | "qualificationSuffix" | "recdLiteralExpr" | "tupleExpr" | "unaryExpr" | "valueExpr"
                ->
                let i, d = unbox<option<int>*Expr> state.lexeme
                i, stringify d
            | "appType"
                ->
                let (i, targ), ls = unbox<(option<int>*TypeArgument)*list<option<int>*SuffixType>> state.lexeme
                let ls = ls |> List.map snd
                i, stringify(targ, ls)
            | "atomType" | "typeArgument"
                ->
                let i, d = unbox<option<int>*TypeArgument> state.lexeme
                i, stringify d
            | "atomicPattern" | "bindingPattern" | "matchPattern" | "parameterPattern"
                ->
                let i, d = unbox<option<int>*Pattern> state.lexeme
                i, stringify d
            | "fieldBinding"
                ->
                let i, d = unbox<option<int>*RecordFiledBinding> state.lexeme
                i, stringify d
            | "fieldBindings"
                ->
                let ls = unbox<list<option<int>*RecordFiledBinding>> state.lexeme
                let i, ls = ls |> List.unzip
                i.[0], stringify ls
            | "file"
                ->
                None, stringifyDynamic typeof<list<string>*list<Expr>> state.lexeme
            | "funType" | "tupleType" | "typeArguments"
                ->
                let ls = unbox<list<option<int>*TypeArgument>> state.lexeme
                let i, ls = ls |> List.unzip
                i.[0], stringify ls
            | "longid"
                ->
                let i, d = unbox<option<int>*list<string>> state.lexeme
                i, stringify d
            | "matchClause"
                ->
                let i, d = unbox<option<int>*RuleClause> state.lexeme
                i, stringify d
            | "patternAndGuard"
                ->
                let i, p, e = unbox<option<int>*Pattern*option<Expr>> state.lexeme
                i, stringify(p, e)
            | "revAppExpr" | "revOpenOrLets" | "revQualificationExpr" | "revSequentialExpr" | "revTupleExpr" | "tupleRhs" | "valueRhs"
                ->
                let ls = unbox<list<option<int>*Expr>> state.lexeme
                let i, ls = ls |> List.unzip
                i.[0], stringify ls
            | "revBinaryExpr"
                ->
                let ls = unbox<list<option<int>*Either<string,Expr>>> state.lexeme
                let i, ls = ls |> List.unzip
                i.[0], stringify ls
            | "revIfParts"
                ->
                let ls = unbox<list<option<int>*IfBranch>> state.lexeme
                let i, ls = ls |> List.unzip
                i.[0], stringify ls
            | "revLongid"
                ->
                let ls = unbox<list<option<int>*string>> state.lexeme
                let i, ls = ls |> List.unzip
                i.[0], stringify ls
            | "revMatchClauses"
                ->
                let ls = unbox<list<option<int>*RuleClause>> state.lexeme
                let i, ls = ls |> List.unzip
                i.[0], stringify ls
            | "suffixType"
                ->
                let i, d = unbox<option<int>*SuffixType> state.lexeme
                i, stringify d
            | "tuplePattern"
                ->
                let ls = unbox<list<option<int>*Pattern>> state.lexeme
                let i, ls = ls |> List.unzip
                i.[0], stringify ls

            | symbol -> failwith $"没有这个符号:{symbol}"
        {
            position = position
            tag = tag
            data = data
        }
