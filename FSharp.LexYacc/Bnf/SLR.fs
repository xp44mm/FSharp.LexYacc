namespace FSharp.LexYacc

open FSharp.Idioms
open FSharp.Idioms.Literal

type SLR = 
    {
    items: Set<ItemCore>
    }

    static member just(items) = { items = items }

    static member from(lalr: Set<ItemCore*Set<string>>) =
        lalr
        |> Set.filter(fun (i,_) -> i.isKernel )
        |> Set.map fst
        |> SLR.just

    /// 获取一个kernel/closure的Symbol
    member this.getSymbol() =
        let itemCore = 
            this.items
            |> Seq.find (fun itemCore -> itemCore.isKernel )
        // 如果前一个符号是产生式的lastTerm
        if itemCore.production.Head = "" && itemCore.dot = 0 then
            ""
        else
            itemCore.prevSymbol

    member this.toActions () =
        let reduces,shifts =
            this.items
            |> Set.partition( fun i -> i.dotmax )

        let shifts =
            if shifts.IsEmpty then
                Set.empty
            else
                let nextKernel =
                    shifts
                    |> Set.map( fun i -> i.dotIncr() )
                Set.singleton ( Shift nextKernel ) // all to 1

        let reduces =
            reduces
            |> Set.map(fun icore -> // 1 to 1
                Reduce icore.production
            )

        let actions = reduces + shifts
        actions
