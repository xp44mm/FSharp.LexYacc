module FSharp.LexYacc.BnfUtils

open FSharp.Idioms
open System.Collections.Generic

/// 展开栈顶非终结符号，直到栈顶为终结符号
let derive (bnf: BNF) (stack: string list) : Set<list<string>> =
    let rec expand (currentStack: string list) (seenNonTerminals: Set<string>) =
        seq {
            match currentStack with
            | [] -> ()
            | top :: rest ->
                if bnf.terminals.Contains(top) then
                    yield currentStack
                else if seenNonTerminals.Contains(top) then
                    ()
                else
                    let newSeen = seenNonTerminals.Add(top)
                    let topProds =
                        bnf.productions
                        |> Seq.filter(fun p ->
                            match p with
                            | lhs :: _ -> lhs = top
                            | [] -> false
                        )
                    for prod in topProds do
                        let newStack = List.move prod.Tail rest
                        yield! expand newStack newSeen
        }

    expand stack Set.empty |> Set.ofSeq

/// 终结符所在产生式的左侧展开，注意此时la没有进入栈
let deriveLeftOfSymbol (bnf: BNF) (lookahead: string) : Set<list<string>> =
    bnf.productions
    |> Seq.collect(fun prod ->
        let body = prod.Tail
        match List.tryFindIndex ((=) lookahead) body with
        | Some idx ->
            let leftPart = List.take idx body
            let revSymbols = List.rev leftPart
            derive bnf revSymbols
        | None -> Set.empty
    )
    |> Set.ofSeq

/// 同bnf.last，只是包括非终结符号在内的所有符号
let getLastSymbols (bnf: BNF) (symbol: string) : Set<string> =
    let st = HashSet<string>(HashIdentity.Structural)
    let rec loop (element: string) =
        bnf.productions
        |> Set.filter(fun prod -> List.head prod = element)
        |> Seq.iter(fun prod ->
            match List.tryLast prod with
            | Some s when st.Add(s) -> loop s
            | _ -> ()
        )
    loop symbol
    st |> Set.ofSeq

///// 终结符所在产生式的左侧规约
//let reduceLeftOfSymbol (bnf: BNF) (top: string) =
//    bnf.productions
//    |> Seq.choose(fun prod ->
//        match prod with
//        | head :: body ->
//            body
//            |> List.tryFindIndex((=) top)
//            |> Option.map(fun idx ->
//                let leftPart = body |> List.take(idx + 1) |> List.rev
//                leftPart, head
//            )
//        | [] -> None
//    )
//    |> Set.ofSeq

