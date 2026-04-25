namespace FSharp.LexYacc

open FSharp.Idioms
open FSharp.Idioms.Literal

    ///// shift/reduce
    //member this.isSRConflict () =
    //    /// 只有一个reduce的冲突，一定是sr冲突
    //    if this.items.Count > 1 then
    //        let reduces =
    //            this.items
    //            |> Set.filter(fun i -> i.dotmax)
    //        reduces.Count = 1
    //    else false

    //member this.isConflict () =
    //    // 无需限定冲突符号必须是终结符号，
    //    // 冲突一定存在reduce，reduce的lookahead一定是终结符号
    //    if this.items.Count > 1 then
    //        this.items
    //        |> Set.exists(fun i -> i.dotmax)
    //    else false


    ///// 删除冲突的项目
    //member this.disambiguate(tryGetPrecedenceCode:string list -> int option ) =
    //    let reduces,shifts =
    //        this.items
    //        |> Set.partition(fun i -> i.dotmax )

    //    if reduces.IsEmpty then
    //        //shift/shift 经常有一个以上的符号(终结符或非终结符)，无需去重
    //        // ifexp : @ if b then e else e
    //        //       | @ if b then e
    //        // 所有项目将共享一个shift动作。
    //        shifts
    //    elif shifts.IsEmpty then
    //        // A Reduce-Reduce error is a caused when a grammar allows two or more different rules 
    //        // to be reduced at the same time, for the same token. When this happens, 
    //        // the grammar becomes ambiguous since a program can be interpreted more than one way. 
    //        // This error can be caused when the same rule is reached by more than one path.
    //        if reduces.Count = 1 then
    //            reduces
    //        else 
    //            // reduce/reduce 说明BNF写错了
    //            failwith $"R/R conflict:{stringify reduces}"
    //    else
    //        let rdc = Seq.exactlyOne reduces //只能有一个reduce元素
    //        let sft = Set.minElement shifts  //可以有多个shift元素

    //        let rprec = tryGetPrecedenceCode rdc.production //reduce产生式的优先级
    //        let sprec = tryGetPrecedenceCode sft.production //任何shift产生式的优先级

    //        match sprec,rprec with
    //        | _,None | None,_ -> shifts
    //        | Some sprec, Some rprec ->
    //        if rprec > sprec then
    //            reduces
    //        elif rprec < sprec then
    //            shifts
    //        else
    //            match rprec % 10 with
    //            | 0 -> // %nonassoc
    //                Set.empty
    //            | 1 -> // %right
    //                shifts
    //            | 9 -> // %left
    //                reduces
    //            | _ -> failwith $"precedence should int [0;1;9] but {rprec}."

