namespace FSharp.LexYacc.Bootstrap

open FSharp.Idioms
open FSharp.Idioms.Literal
open FSharp.LexYacc

type FsyaccFilePrinter =
    {
        rules: (string list * string) list
        actions: (string * int) list list // kernel -> symbol -> kernel
        startType: string
        stateSymbols: string[]
    }
    static member from(fsyacc: FlatFsyaccFile) =
        let yacc = fsyacc.getYacc()
        let bnf = yacc.bnf
        let encoder = ParseTableEncoder.from(bnf.productions, bnf.kernels)

        //let kernels = encoder.encodeKernels bnf.kernels

        ///状态号就是数组的索引号
        let stateSymbols = bnf.kernelSymbols |> Map.toArray |> Array.map snd

        let actions = encoder.encodeActions yacc.actions
        let declarations =
            fsyacc.declarations
            |> Map.map(fun _ dec -> dec.Substring(6, dec.Length - 7))
        let rules =
            match Set.toList fsyacc.augmentRules with
            | [] -> failwith "never"
            | s0 :: rules ->
                let augmentRule = s0.production, "fun (ss:obj list) -> ss.[0]"

                let rules =
                    rules
                    |> List.map(fun rule ->
                        let reducer =
                            rule.reducer
                            |> Braces.sliceContent
                            |> ReducerRender.decorateReducer
                                declarations
                                rule.production
                        rule.production, reducer
                    )
                augmentRule :: rules
        let startSymbol =
            match fst rules.Head with
            | [ ""; startSymbol ] -> startSymbol
            | _ -> failwith "never"
        let startType = declarations.[startSymbol]

        {
            rules = rules
            actions = actions
            startType = startType
            stateSymbols = stateSymbols
        }

    /// 生成 ParseTable Module
    /// 输入模块带名字空间的全名
    /// 删除Parse代码
    member this.printYaccModule(header: string) =
        let reducers =
            this.rules
            |> List.map(fun (prod, reducer) -> $"{stringify prod}, {reducer}")

        [
            Braces.sliceContent header
            "let stateSymbols: string[] = "
            + stringify this.stateSymbols
            "let actions: (string * int) list list = "
            + stringify this.actions
            "let rules: list<string list*(obj list->obj)> = ["
            Line.identAll 4 reducers
            "]"
            "let unboxRoot ="
            Line.ident 4 $"unbox<{this.startType}>"
            "let parser = ParseTable.from(rules, actions)"
        ]
        |> String.concat "\r\n"
