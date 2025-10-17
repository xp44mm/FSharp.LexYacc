module FSharp.LexYacc.Dir

open System.IO

let solutionPath = DirectoryInfo(__SOURCE_DIRECTORY__).Parent.FullName

let generator = Path.Combine(solutionPath,"FSharp.LexYacc.Generator")

let experimental = Path.Combine(solutionPath,"FSharp.LexYacc.Experimental")
