module FSharp.LexYacc.Dir

open System.IO

let solutionPath = DirectoryInfo(__SOURCE_DIRECTORY__).Parent.FullName

let experimental = Path.Combine(solutionPath,"FSharp.LexYacc.Experimental")

let core =
    Path.Combine(solutionPath, "FSharp.LexYacc")

let bootstrap =
    Path.Combine(core, "Bootstrap")

