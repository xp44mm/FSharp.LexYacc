module FSharp.LexYacc.Conflict

/// 删除冲突的项目
let disambiguate (tryGetPrecedence: string list -> option<int*Associativity>) (actions: ParseTableAction Set) =
    match Seq.toList actions with
    | [] -> failwith "never"
    | [x] -> Some x
    | [Shift k as s; Reduce p as r] ->
        //shift的优先级
        let sprec =
            (Seq.head k).production
            |> tryGetPrecedence

        //reduce的优先级
        let rprec = tryGetPrecedence p

        match sprec,rprec with
        | _,None | None,_ -> Some s
        | Some (sprec,sassoc), Some (rprec,rassoc) ->
        // 如果没有取得iprec则用shift
        if rprec > sprec then
            Some r
        elif rprec < sprec then
            Some s
        else
            if sassoc <> rassoc then failwith "never"
            //优先级相等，在同一行，有相同结合性
            match sassoc with
            | NonAssoc -> None
            | RightAssoc -> Some s
            | LeftAssoc -> Some r
    | ls -> failwith $"{ls}"

