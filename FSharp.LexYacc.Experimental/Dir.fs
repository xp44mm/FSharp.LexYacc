module FSharp.LexYacc.Experimental.Dir

open System.IO

let solutionPath =
    DirectoryInfo(__SOURCE_DIRECTORY__).Parent.FullName

let generator =
    Path.Combine(solutionPath, "FSharp.LexYacc.Generator")

let core =
    Path.Combine(solutionPath, "FSharp.LexYacc")

let bootstrap =
    Path.Combine(core, "Bootstrap")

