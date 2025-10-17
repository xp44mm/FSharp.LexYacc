namespace FSharp.LexYacc

/// 独立式产生式规则，而非成组式规则
type Rule = {
    production: string list
    dummy: string
    reducer: string
} with

    static member just(production, dummy, reducer) = {
        production = production
        dummy = dummy
        reducer = reducer
    }

    static member augment(startSymbol) = {
        production = [ ""; startSymbol ]
        dummy = ""
        reducer = ""
    }
