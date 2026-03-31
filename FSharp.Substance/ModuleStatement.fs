namespace FSharp.Substance

type ModuleStatement =
    | ModuleIntro of string list
    | OpenStatement of string list
    | LetBinding of obj * obj
