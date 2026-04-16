module FSharp.Substance.FSharpYacc
open FSharp.LexYacc
let stateSymbols: string[] = [|"";"file";"revAppExpr";"[|";"sequentialExpr";"|]";"|]";"LITERAL";"arrayExpr";"listExpr";"longid";"parenExpr";"DUMMY";"OPEN";"longid";"lambdaExpr";"letBinding";"MODULE";"longid";"rhsBlock";"EOF";"FUN";"IDENT";"->";"lambdaExpr";"RHSEND";"rhsBlock";"tupleExpr";"LET";"IDENT";"=";"lambdaExpr";"RHSEND";"rhsBlock";"[";"]";"sequentialExpr";"]";"revLongid";"(";")";"sequentialExpr";")";"atomicExpr";"atomicExpr";"IDENT";".";"IDENT";"declExpr";"revSequentialExpr";";";"declExpr";"revTupleExpr";",";"unaryExpr";"unaryExpr";"LLPAREN";"sequentialExpr";"RRPAREN";"-";"appExpr";"appExpr"|]
let actions: (string * int) list list = [["MODULE",17;"file",1];["",0];["(",39;")",-1;",",-1;";",-1;"IDENT",45;"LITERAL",7;"RHSEND",-1;"RRPAREN",-1;"[",34;"[|",3;"]",-1;"arrayExpr",8;"atomicExpr",44;"listExpr",9;"longid",10;"parenExpr",11;"revLongid",38;"|]",-1];["(",39;"-",59;"DUMMY",12;"FUN",21;"IDENT",45;"LET",28;"LITERAL",7;"OPEN",13;"[",34;"[|",3;"appExpr",61;"arrayExpr",8;"atomicExpr",43;"declExpr",48;"lambdaExpr",15;"letBinding",16;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",38;"revSequentialExpr",49;"revTupleExpr",52;"sequentialExpr",4;"tupleExpr",27;"unaryExpr",55;"|]",6];["|]",5];["(",-2;")",-2;",",-2;";",-2;"IDENT",-2;"LITERAL",-2;"RHSEND",-2;"RRPAREN",-2;"[",-2;"[|",-2;"]",-2;"|]",-2];["(",-3;")",-3;",",-3;";",-3;"IDENT",-3;"LITERAL",-3;"RHSEND",-3;"RRPAREN",-3;"[",-3;"[|",-3;"]",-3;"|]",-3];["(",-4;")",-4;",",-4;";",-4;"IDENT",-4;"LITERAL",-4;"RHSEND",-4;"RRPAREN",-4;"[",-4;"[|",-4;"]",-4;"|]",-4];["(",-5;")",-5;",",-5;";",-5;"IDENT",-5;"LITERAL",-5;"RHSEND",-5;"RRPAREN",-5;"[",-5;"[|",-5;"]",-5;"|]",-5];["(",-6;")",-6;",",-6;";",-6;"IDENT",-6;"LITERAL",-6;"RHSEND",-6;"RRPAREN",-6;"[",-6;"[|",-6;"]",-6;"|]",-6];["(",-7;")",-7;",",-7;";",-7;"IDENT",-7;"LITERAL",-7;"RHSEND",-7;"RRPAREN",-7;"[",-7;"[|",-7;"]",-7;"|]",-7];["(",-8;")",-8;",",-8;";",-8;"IDENT",-8;"LITERAL",-8;"RHSEND",-8;"RRPAREN",-8;"[",-8;"[|",-8;"]",-8;"|]",-8];[")",-9;";",-9;"RRPAREN",-9;"]",-9;"|]",-9];["IDENT",45;"longid",14;"revLongid",38];[")",-10;";",-10;"RRPAREN",-10;"]",-10;"|]",-10];[")",-11;";",-11;"RRPAREN",-11;"]",-11;"|]",-11];[")",-12;";",-12;"RRPAREN",-12;"]",-12;"|]",-12];["IDENT",45;"longid",18;"revLongid",38];["LLPAREN",56;"rhsBlock",19];["EOF",20];["",-13];["IDENT",22];["->",23];["(",39;"-",59;"FUN",21;"IDENT",45;"LITERAL",7;"LLPAREN",56;"[",34;"[|",3;"appExpr",61;"arrayExpr",8;"atomicExpr",43;"lambdaExpr",24;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",38;"revTupleExpr",52;"rhsBlock",26;"tupleExpr",27;"unaryExpr",55];["RHSEND",25];[")",-14;";",-14;"RHSEND",-14;"RRPAREN",-14;"]",-14;"|]",-14];[")",-15;";",-15;"RHSEND",-15;"RRPAREN",-15;"]",-15;"|]",-15];[")",-16;";",-16;"RHSEND",-16;"RRPAREN",-16;"]",-16;"|]",-16];["IDENT",29];["=",30];["(",39;"-",59;"FUN",21;"IDENT",45;"LITERAL",7;"LLPAREN",56;"[",34;"[|",3;"appExpr",61;"arrayExpr",8;"atomicExpr",43;"lambdaExpr",31;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",38;"revTupleExpr",52;"rhsBlock",33;"tupleExpr",27;"unaryExpr",55];["RHSEND",32];[")",-17;";",-17;"RRPAREN",-17;"]",-17;"|]",-17];[")",-18;";",-18;"RRPAREN",-18;"]",-18;"|]",-18];["(",39;"-",59;"DUMMY",12;"FUN",21;"IDENT",45;"LET",28;"LITERAL",7;"OPEN",13;"[",34;"[|",3;"]",35;"appExpr",61;"arrayExpr",8;"atomicExpr",43;"declExpr",48;"lambdaExpr",15;"letBinding",16;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",38;"revSequentialExpr",49;"revTupleExpr",52;"sequentialExpr",36;"tupleExpr",27;"unaryExpr",55];["(",-19;")",-19;",",-19;";",-19;"IDENT",-19;"LITERAL",-19;"RHSEND",-19;"RRPAREN",-19;"[",-19;"[|",-19;"]",-19;"|]",-19];["]",37];["(",-20;")",-20;",",-20;";",-20;"IDENT",-20;"LITERAL",-20;"RHSEND",-20;"RRPAREN",-20;"[",-20;"[|",-20;"]",-20;"|]",-20];["(",-21;")",-21;",",-21;".",46;";",-21;"IDENT",-21;"LITERAL",-21;"LLPAREN",-21;"RHSEND",-21;"RRPAREN",-21;"[",-21;"[|",-21;"]",-21;"|]",-21];["(",39;")",40;"-",59;"DUMMY",12;"FUN",21;"IDENT",45;"LET",28;"LITERAL",7;"OPEN",13;"[",34;"[|",3;"appExpr",61;"arrayExpr",8;"atomicExpr",43;"declExpr",48;"lambdaExpr",15;"letBinding",16;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",38;"revSequentialExpr",49;"revTupleExpr",52;"sequentialExpr",41;"tupleExpr",27;"unaryExpr",55];["(",-22;")",-22;",",-22;";",-22;"IDENT",-22;"LITERAL",-22;"RHSEND",-22;"RRPAREN",-22;"[",-22;"[|",-22;"]",-22;"|]",-22];[")",42];["(",-23;")",-23;",",-23;";",-23;"IDENT",-23;"LITERAL",-23;"RHSEND",-23;"RRPAREN",-23;"[",-23;"[|",-23;"]",-23;"|]",-23];["(",-24;")",-24;",",-24;";",-24;"IDENT",-24;"LITERAL",-24;"RHSEND",-24;"RRPAREN",-24;"[",-24;"[|",-24;"]",-24;"|]",-24];["(",-25;")",-25;",",-25;";",-25;"IDENT",-25;"LITERAL",-25;"RHSEND",-25;"RRPAREN",-25;"[",-25;"[|",-25;"]",-25;"|]",-25];["(",-26;")",-26;",",-26;".",-26;";",-26;"IDENT",-26;"LITERAL",-26;"LLPAREN",-26;"RHSEND",-26;"RRPAREN",-26;"[",-26;"[|",-26;"]",-26;"|]",-26];["IDENT",47];["(",-27;")",-27;",",-27;".",-27;";",-27;"IDENT",-27;"LITERAL",-27;"LLPAREN",-27;"RHSEND",-27;"RRPAREN",-27;"[",-27;"[|",-27;"]",-27;"|]",-27];[")",-28;";",-28;"RRPAREN",-28;"]",-28;"|]",-28];[")",-33;";",50;"RRPAREN",-33;"]",-33;"|]",-33];["(",39;"-",59;"DUMMY",12;"FUN",21;"IDENT",45;"LET",28;"LITERAL",7;"OPEN",13;"[",34;"[|",3;"appExpr",61;"arrayExpr",8;"atomicExpr",43;"declExpr",51;"lambdaExpr",15;"letBinding",16;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",38;"revTupleExpr",52;"tupleExpr",27;"unaryExpr",55];[")",-29;";",-29;"RRPAREN",-29;"]",-29;"|]",-29];[")",-34;",",53;";",-34;"RHSEND",-34;"RRPAREN",-34;"]",-34;"|]",-34];["(",39;"-",59;"IDENT",45;"LITERAL",7;"[",34;"[|",3;"appExpr",61;"arrayExpr",8;"atomicExpr",43;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",38;"unaryExpr",54];[")",-30;",",-30;";",-30;"RHSEND",-30;"RRPAREN",-30;"]",-30;"|]",-30];[")",-31;",",-31;";",-31;"RHSEND",-31;"RRPAREN",-31;"]",-31;"|]",-31];["(",39;"-",59;"DUMMY",12;"FUN",21;"IDENT",45;"LET",28;"LITERAL",7;"OPEN",13;"[",34;"[|",3;"appExpr",61;"arrayExpr",8;"atomicExpr",43;"declExpr",48;"lambdaExpr",15;"letBinding",16;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",38;"revSequentialExpr",49;"revTupleExpr",52;"sequentialExpr",57;"tupleExpr",27;"unaryExpr",55];["RRPAREN",58];[")",-32;";",-32;"EOF",-32;"RHSEND",-32;"RRPAREN",-32;"]",-32;"|]",-32];["(",39;"IDENT",45;"LITERAL",7;"[",34;"[|",3;"appExpr",60;"arrayExpr",8;"atomicExpr",43;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",38];[")",-35;",",-35;";",-35;"RHSEND",-35;"RRPAREN",-35;"]",-35;"|]",-35];[")",-36;",",-36;";",-36;"RHSEND",-36;"RRPAREN",-36;"]",-36;"|]",-36]]
let rules: list<string list*(obj list->obj)> = [
    ["";"file"], fun (ss:obj list) -> ss.[0]
    ["appExpr";"revAppExpr"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let result:option<int>*Expr =
            let i,ls = s0 |> List.rev |> List.unzip
            let e = if ls.Length > 1 then AppExpr ls else ls.[0]
            i.[0], e
        box result
    ["arrayExpr";"[|";"sequentialExpr";"|]"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Expr list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:option<int>*Expr =
            s0, ArrayExpr(snd s1)
        box result
    ["arrayExpr";"[|";"|]"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let result:option<int>*Expr =
            s0, ArrayExpr []
        box result
    ["atomicExpr";"LITERAL"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Literal> ss.[0]
        let result:option<int>*Expr =
            let i,v = s0
            i,LiteralExpr v
        box result
    ["atomicExpr";"arrayExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result
    ["atomicExpr";"listExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result
    ["atomicExpr";"longid"], fun(ss:obj list)->
        let s0 = unbox<option<int>*string list> ss.[0]
        let result:option<int>*Expr =
            fst s0, IdentExpr(snd s0)
        box result
    ["atomicExpr";"parenExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result
    ["declExpr";"DUMMY"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*Expr =
            s0, DummyExpr
        box result
    ["declExpr";"OPEN";"longid"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*string list> ss.[1]
        let result:option<int>*Expr =
            s0, OpenExpr(snd s1)
        box result
    ["declExpr";"lambdaExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result
    ["declExpr";"letBinding"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result
    ["file";"MODULE";"longid";"rhsBlock";"EOF"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*string list> ss.[1]
        let s2 = unbox<option<int>*Expr list> ss.[2]
        let result:string list*Expr list =
            snd s1, snd s2
        box result
    ["lambdaExpr";"FUN";"IDENT";"->";"lambdaExpr";"RHSEND"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*string> ss.[1]
        let s3 = unbox<option<int>*Expr> ss.[3]
        let result:option<int>*Expr =
            s0, LambdaExpr(snd s1, [snd s3])
        box result
    ["lambdaExpr";"FUN";"IDENT";"->";"rhsBlock"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*string> ss.[1]
        let s3 = unbox<option<int>*Expr list> ss.[3]
        let result:option<int>*Expr =
            s0, LambdaExpr(snd s1, snd s3)
        box result
    ["lambdaExpr";"tupleExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result
    ["letBinding";"LET";"IDENT";"=";"lambdaExpr";"RHSEND"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*string> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>*Expr> ss.[3]
        let result:option<int>*Expr =
            s0, LetBindingExpr(snd s1, [snd s3])
        box result
    ["letBinding";"LET";"IDENT";"=";"rhsBlock"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*string> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>*Expr list> ss.[3]
        let result:option<int>*Expr =
            s0, LetBindingExpr(snd s1, snd s3)
        box result
    ["listExpr";"[";"]"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let result:option<int>*Expr =
            s0, ListExpr []
        box result
    ["listExpr";"[";"sequentialExpr";"]"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Expr list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:option<int>*Expr =
            s0, ListExpr(snd s1)
        box result
    ["longid";"revLongid"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*string) list> ss.[0]
        let result:option<int>*string list =
            let i,ls = s0 |> List.rev |> List.unzip
            i.[0], ls
        box result
    ["parenExpr";"(";")"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let result:option<int>*Expr =
            s0, LiteralExpr Literal.UNIT
        box result
    ["parenExpr";"(";"sequentialExpr";")"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Expr list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:option<int>*Expr =
            s0, ParenExpr(snd s1)
        box result
    ["revAppExpr";"atomicExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:(option<int>*Expr) list =
            [s0]
        box result
    ["revAppExpr";"revAppExpr";"atomicExpr"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let s1 = unbox<option<int>*Expr> ss.[1]
        let result:(option<int>*Expr) list =
            s1::s0
        box result
    ["revLongid";"IDENT"], fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let result:(option<int>*string) list =
            [s0]
        box result
    ["revLongid";"revLongid";".";"IDENT"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*string) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*string> ss.[2]
        let result:(option<int>*string) list =
            s2 :: s0
        box result
    ["revSequentialExpr";"declExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:(option<int>*Expr) list =
            [s0]
        box result
    ["revSequentialExpr";"revSequentialExpr";";";"declExpr"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let result:(option<int>*Expr) list =
            s2::s0
        box result
    ["revTupleExpr";"revTupleExpr";",";"unaryExpr"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let result:(option<int>*Expr) list =
            s2::s0
        box result
    ["revTupleExpr";"unaryExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:(option<int>*Expr) list =
            [s0]
        box result
    ["rhsBlock";"LLPAREN";"sequentialExpr";"RRPAREN"], fun(ss:obj list)->
        let s1 = unbox<option<int>*Expr list> ss.[1]
        let result:option<int>*Expr list =
            s1
        box result
    ["sequentialExpr";"revSequentialExpr"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let result:option<int>*Expr list =
            let s0 =
                match s0 with
                | (_, DummyExpr) :: tail -> tail
                | _ -> s0
            let i,ls = s0 |> List.rev |> List.unzip
            i.[0], ls
        box result
    ["tupleExpr";"revTupleExpr"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let result:option<int>*Expr =
            let i,ls = s0 |> List.rev |> List.unzip
            let e = if ls.Length > 1 then TupleExpr(ls) else ls.[0]
            i.[0], e
        box result
    ["unaryExpr";"-";"appExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Expr> ss.[1]
        let result:option<int>*Expr =
            s0, snd s1
        box result
    ["unaryExpr";"appExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result
]
let unboxRoot =
    unbox<string list*Expr list>
let parser = ParseTable.from(rules, actions)