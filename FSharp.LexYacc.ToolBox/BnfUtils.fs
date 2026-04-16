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

/// 终结符所在产生式的左侧规约
let reduceLeftOfSymbol (bnf: BNF) (top: string) =
    bnf.productions
    |> Seq.choose(fun prod ->
        match prod with
        | [] -> None
        | head::body ->
            match List.tryFindIndex ((=) top) body with
            | Some idx when idx > 0 ->
                let leftPart = List.take idx body
                Some(List.rev leftPart)
            | _ -> None
    )
    |> Set.ofSeq

/// 移入 top 后，在给定 lookahead 下，栈的可能状态
/// 返回 (栈内容, 可能的规约动作)
let getStackAfterShift (bnf: BNF) (top: string) : Set<list<string> * string> =
    let results = HashSet<list<string> * string>(HashIdentity.Structural)
    
    /// 递归查找所有可能的规约路径
    let rec findStackShapes (currentSym: string) (stackSuffix: list<string>) =
        // 找到所有产生式，其右部最后一个符号是 currentSym
        bnf.productions
        |> Set.filter (fun prod ->
            match List.tryLast prod with
            | Some last -> last = currentSym
            | None -> false
        )
        |> Seq.iter (fun prod ->
            match prod with
            | [] -> ()
            | head :: body ->
                let prefix = List.take (List.length body - 1) body
                let newStackSuffix = prefix @ [head] @ stackSuffix
                
                if List.isEmpty prefix then
                    // 规约到 head，检查是否应该规约
                    // 需要看 lookahead 是否在 FOLLOW(head) 中
                    results.Add(newStackSuffix, head) |> ignore
                else
                    let lastPrefix = List.last prefix
                    if bnf.nonterminals.Contains(lastPrefix) then
                        findStackShapes lastPrefix newStackSuffix
                    else
                        results.Add(newStackSuffix, head) |> ignore
        )
    
    // 初始栈：移入 top 后，top 在栈顶
    let initialStack = [top]
    
    // 尝试规约 top 及其左侧内容
    findStackShapes top initialStack
    
    // 如果没有规约，栈就是 [top]
    if results.Count = 0 then
        Set.singleton (initialStack, "shift")
    else
        Set.ofSeq results
