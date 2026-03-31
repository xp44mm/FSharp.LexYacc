module FSharp.Substance.Dir

open System.IO

let solutionPath = DirectoryInfo(__SOURCE_DIRECTORY__).Parent.FullName

let main = Path.Combine(solutionPath, "FSharp.Substance")


