module FSharp.Substance.LookaheadConfig

let catalog: Map<string, list<string list * string Set> > = 
    let ls0 = LookaheadConfig0.catalog |> Map.toSeq
    let ls1 = LookaheadConfig1.catalog |> Map.toSeq
    let ls2 = LookaheadConfig2.catalog |> Map.toSeq
    
    Map [
        yield! ls0
        yield! ls1
        yield! ls2
    ]
