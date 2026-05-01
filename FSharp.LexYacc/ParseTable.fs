namespace FSharp.LexYacc

open System

open FSharp.Idioms
open FSharp.Idioms.Literal

type YaccState =
    {
        state: int
        lexeme: obj
    }

    static member just(state, lexeme) = { state = state; lexeme = lexeme }

type ProductionRule =
    {
        production: string list
        action: obj list -> obj
    }

type NextParseAction =
    | NoSource of state: int
    | NoSymbol of tag: string
    | Rejected of tag: string
    | Accepted
    | Shifted of states: YaccState list
    | Reduced of states: YaccState list

type TokenRow<'tok> =
    {
        token: 'tok
        tag: string
        lexeme: obj
    }

type ParseTable =
    {
        rules: Map<int, ProductionRule>
        actions: Map<int, Map<string, int>> // action = shift + accept + reduce
    }

    member this.nextAction (states: YaccState list) (maybeToken: TokenRow<'tok> option) =
        let sm = states.Head

        if not(this.actions.ContainsKey sm.state) then
            NoSource sm.state
        else
            let lookaheads = this.actions.[sm.state]
            let ai, lexeme =
                match maybeToken with
                | None -> "", null
                | Some token -> token.tag, token.lexeme

            if not(lookaheads.ContainsKey ai) then
                NoSymbol ai
            else
                let i = lookaheads.[ai]
                if i = 0 then
                    // 0 - String.empty -> Accepted
                    if ai = "" then
                        Accepted
                    else
                        Rejected ai
                elif i > 0 then
                    Shifted(YaccState.just(i, lexeme) :: states)
                else
                    //产生式符号列表。比如产生式 e-> e + e 的符号列表为 [e;e;+;e]
                    let rule = this.rules.[i]

                    // 产生式的左侧
                    let leftside = rule.production.[0]
                    // 产生式右侧的长度
                    let len = rule.production.Length - 1
                    // 弹出产生式体符号对应的状态
                    let children, restStates = states |> List.advance len

                    // 产生式头的数据
                    let lexeme =
                        children
                        |> List.map(fun s -> s.lexeme)
                        |> rule.action

                    // 剩下状态栈最顶部的状态编号
                    let smr = restStates.Head // = s_{m-r}
                    // 根据顶部状态，产生式左侧，得到新状态
                    let newstate = this.actions.[smr.state].[leftside] // GOTO
                    // 压入新状态
                    Reduced(
                        YaccState.just(newstate, lexeme)
                        :: restStates
                    )

    /// 返回 shift token 行为执行完成后的状态
    member this.shift (states: YaccState list) (token: TokenRow<'tok>) =
        let maybeTok = Some token
        let rec loop ss =
            match this.nextAction ss maybeTok with
            | Reduced nss -> loop nss
            | Shifted nss -> nss //最后一步
            | x -> failwith("next action:" + stringify x)
        loop states

    /// 尝试执行 shift token 行为，成功返回 Some 状态，失败返回 None
    member this.tryShift (states: YaccState list) (token: TokenRow<'tok>) =
        let maybeTok = Some token
        let rec loop currentStates =
            match this.nextAction currentStates maybeTok with
            | Reduced nss -> loop nss
            | Shifted nss -> Some nss
            | _ -> None // 其他情况（如 Error 或 Accept 等）视为失败
        loop states

    /// Reduce / Shift
    member this.tryReduceBeforeShift (states: YaccState list) (token: TokenRow<'tok>) =
        // times用于记录Reduced次数
        let rec loop times currentStates =
            match this.nextAction currentStates (Some token) with
            | Reduced nss -> loop (times + 1) nss
            | Shifted _ -> if times > 0 then Some currentStates else None
            | x -> failwith(stringify x)
        loop 0 states

    /// Reduce / Accept
    member this.tryReduceBeforeAccept(states: YaccState list) =
        // times用于记录Reduced次数
        let rec loop times states =
            match this.nextAction states None with
            | Reduced nextStates -> loop (times + 1) nextStates
            | Accepted -> if times > 0 then Some states else None
            | x -> failwith(stringify x)
        loop 0 states

    member this.tryAccept(states: YaccState list) =
        let rec loop states =
            match this.nextAction states None with
            | Reduced nextStates -> loop nextStates
            | Accepted ->
                match states with
                // if s.state = 1 && s0.state = 0 && s0.lexeme = null then
                | [ { state = 1; lexeme = lxm }; { state = 0; lexeme = null } ] -> Some lxm
                | _ -> None
            | _ -> None
        loop states

    /// 简单解析过程，一步到底
    member this.parse(tokens: Iterator<TokenRow<'tok>>) =
        let rec loop (states: YaccState list) (maybeToken: TokenRow<'tok> option) =
            match this.nextAction states maybeToken with
            | Accepted -> states
            | Reduced nextStates -> loop nextStates maybeToken
            | Shifted nextStates -> tokens.tryNext() |> loop nextStates
            | x -> failwith(stringify x)

        let s =
            tokens.tryNext()
            |> loop [ { state = 0; lexeme = null } ] // init states
            |> List.head

        s.lexeme

    ///从打印的BNF获得实例
    static member from
        (rules: (string list * (obj list -> obj)) list, actions: (string * int) list list)
        =
        // code -> production * reducer
        let rules =
            rules
            |> List.mapi(fun i (prod, fn) -> -i, { production = prod; action = fn })
            |> Map.ofList

        /// state -> lookahead -> action
        let actions =
            actions
            |> List.mapi(fun src pairs -> src, Map.ofList pairs)
            |> Map.ofList

        { rules = rules; actions = actions }
