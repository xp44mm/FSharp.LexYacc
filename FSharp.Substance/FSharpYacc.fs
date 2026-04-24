module FSharp.Substance.FSharpYacc
open FSharp.LexYacc
let stateSymbols: string[] = [|"";"file";"revAppExpr";"[|";"sequentialExpr";"|]";"|]";"LITERAL";"arrayExpr";"listExpr";"longid";"parenExpr";"DUMMY";"OPEN";"longid";"lambdaOrTupleExpr";"letBinding";"MODULE";"longid";"rhsBlock";"EOF";"FUN";"IDENT";"->";"lambdaOrTupleExpr";"RHSEND";"rhsBlock";"lambdaExpr";"tupleExpr";"LET";"IDENT";"=";"lambdaOrTupleExpr";"RHSEND";"rhsBlock";"[";"]";"sequentialExpr";"]";"revLongid";"(";")";"sequentialExpr";")";"atomicExpr";"atomicExpr";"IDENT";".";"IDENT";"declExpr";"revSequentialExpr";";";"declExpr";"revTupleExpr";",";"unaryExpr";"unaryExpr";"LLPAREN";"sequentialExpr";"RRPAREN";"lambdaExpr";"-";"appExpr";"appExpr"|]
let actions: (string * int) list list = [["MODULE",17;"file",1];["",0];["(",40;")",-1;",",-1;";",-1;"IDENT",46;"LITERAL",7;"RHSEND",-1;"RRPAREN",-1;"[",35;"[|",3;"]",-1;"arrayExpr",8;"atomicExpr",45;"listExpr",9;"longid",10;"parenExpr",11;"revLongid",39;"|]",-1];["(",40;"-",61;"DUMMY",12;"FUN",21;"IDENT",46;"LET",29;"LITERAL",7;"OPEN",13;"[",35;"[|",3;"appExpr",63;"arrayExpr",8;"atomicExpr",44;"declExpr",49;"lambdaExpr",27;"lambdaOrTupleExpr",15;"letBinding",16;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",39;"revSequentialExpr",50;"revTupleExpr",53;"sequentialExpr",4;"tupleExpr",28;"unaryExpr",56;"|]",6];["|]",5];["(",-2;")",-2;",",-2;";",-2;"IDENT",-2;"LITERAL",-2;"RHSEND",-2;"RRPAREN",-2;"[",-2;"[|",-2;"]",-2;"|]",-2];["(",-3;")",-3;",",-3;";",-3;"IDENT",-3;"LITERAL",-3;"RHSEND",-3;"RRPAREN",-3;"[",-3;"[|",-3;"]",-3;"|]",-3];["(",-4;")",-4;",",-4;";",-4;"IDENT",-4;"LITERAL",-4;"RHSEND",-4;"RRPAREN",-4;"[",-4;"[|",-4;"]",-4;"|]",-4];["(",-5;")",-5;",",-5;";",-5;"IDENT",-5;"LITERAL",-5;"RHSEND",-5;"RRPAREN",-5;"[",-5;"[|",-5;"]",-5;"|]",-5];["(",-6;")",-6;",",-6;";",-6;"IDENT",-6;"LITERAL",-6;"RHSEND",-6;"RRPAREN",-6;"[",-6;"[|",-6;"]",-6;"|]",-6];["(",-7;")",-7;",",-7;";",-7;"IDENT",-7;"LITERAL",-7;"RHSEND",-7;"RRPAREN",-7;"[",-7;"[|",-7;"]",-7;"|]",-7];["(",-8;")",-8;",",-8;";",-8;"IDENT",-8;"LITERAL",-8;"RHSEND",-8;"RRPAREN",-8;"[",-8;"[|",-8;"]",-8;"|]",-8];[")",-9;";",-9;"RRPAREN",-9;"]",-9;"|]",-9];["IDENT",46;"longid",14;"revLongid",39];[")",-10;";",-10;"RRPAREN",-10;"]",-10;"|]",-10];[")",-11;";",-11;"RRPAREN",-11;"]",-11;"|]",-11];[")",-12;";",-12;"RRPAREN",-12;"]",-12;"|]",-12];["IDENT",46;"longid",18;"revLongid",39];["LLPAREN",57;"rhsBlock",19];["EOF",20];["",-13];["IDENT",22];["->",23];["(",40;"-",61;"FUN",21;"IDENT",46;"LITERAL",7;"LLPAREN",57;"[",35;"[|",3;"appExpr",63;"arrayExpr",8;"atomicExpr",44;"lambdaExpr",27;"lambdaOrTupleExpr",24;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",39;"revTupleExpr",53;"rhsBlock",26;"tupleExpr",28;"unaryExpr",56];["RHSEND",25];[")",-14;";",-14;"RHSEND",-14;"RRPAREN",-14;"]",-14;"|]",-14];[")",-15;";",-15;"RHSEND",-15;"RRPAREN",-15;"]",-15;"|]",-15];[")",-16;";",-16;"RHSEND",-16;"RRPAREN",-16;"]",-16;"|]",-16];[")",-17;";",-17;"RHSEND",-17;"RRPAREN",-17;"]",-17;"|]",-17];["IDENT",30];["=",31];["(",40;"-",61;"FUN",21;"IDENT",46;"LITERAL",7;"LLPAREN",57;"[",35;"[|",3;"appExpr",63;"arrayExpr",8;"atomicExpr",44;"lambdaExpr",27;"lambdaOrTupleExpr",32;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",39;"revTupleExpr",53;"rhsBlock",34;"tupleExpr",28;"unaryExpr",56];["RHSEND",33];[")",-18;";",-18;"RRPAREN",-18;"]",-18;"|]",-18];[")",-19;";",-19;"RRPAREN",-19;"]",-19;"|]",-19];["(",40;"-",61;"DUMMY",12;"FUN",21;"IDENT",46;"LET",29;"LITERAL",7;"OPEN",13;"[",35;"[|",3;"]",36;"appExpr",63;"arrayExpr",8;"atomicExpr",44;"declExpr",49;"lambdaExpr",27;"lambdaOrTupleExpr",15;"letBinding",16;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",39;"revSequentialExpr",50;"revTupleExpr",53;"sequentialExpr",37;"tupleExpr",28;"unaryExpr",56];["(",-20;")",-20;",",-20;";",-20;"IDENT",-20;"LITERAL",-20;"RHSEND",-20;"RRPAREN",-20;"[",-20;"[|",-20;"]",-20;"|]",-20];["]",38];["(",-21;")",-21;",",-21;";",-21;"IDENT",-21;"LITERAL",-21;"RHSEND",-21;"RRPAREN",-21;"[",-21;"[|",-21;"]",-21;"|]",-21];["(",-22;")",-22;",",-22;".",47;";",-22;"IDENT",-22;"LITERAL",-22;"LLPAREN",-22;"RHSEND",-22;"RRPAREN",-22;"[",-22;"[|",-22;"]",-22;"|]",-22];["(",40;")",41;"-",61;"DUMMY",12;"FUN",21;"IDENT",46;"LET",29;"LITERAL",7;"OPEN",13;"[",35;"[|",3;"appExpr",63;"arrayExpr",8;"atomicExpr",44;"declExpr",49;"lambdaExpr",27;"lambdaOrTupleExpr",15;"letBinding",16;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",39;"revSequentialExpr",50;"revTupleExpr",53;"sequentialExpr",42;"tupleExpr",28;"unaryExpr",56];["(",-23;")",-23;",",-23;";",-23;"IDENT",-23;"LITERAL",-23;"RHSEND",-23;"RRPAREN",-23;"[",-23;"[|",-23;"]",-23;"|]",-23];[")",43];["(",-24;")",-24;",",-24;";",-24;"IDENT",-24;"LITERAL",-24;"RHSEND",-24;"RRPAREN",-24;"[",-24;"[|",-24;"]",-24;"|]",-24];["(",-25;")",-25;",",-25;";",-25;"IDENT",-25;"LITERAL",-25;"RHSEND",-25;"RRPAREN",-25;"[",-25;"[|",-25;"]",-25;"|]",-25];["(",-26;")",-26;",",-26;";",-26;"IDENT",-26;"LITERAL",-26;"RHSEND",-26;"RRPAREN",-26;"[",-26;"[|",-26;"]",-26;"|]",-26];["(",-27;")",-27;",",-27;".",-27;";",-27;"IDENT",-27;"LITERAL",-27;"LLPAREN",-27;"RHSEND",-27;"RRPAREN",-27;"[",-27;"[|",-27;"]",-27;"|]",-27];["IDENT",48];["(",-28;")",-28;",",-28;".",-28;";",-28;"IDENT",-28;"LITERAL",-28;"LLPAREN",-28;"RHSEND",-28;"RRPAREN",-28;"[",-28;"[|",-28;"]",-28;"|]",-28];[")",-29;";",-29;"RRPAREN",-29;"]",-29;"|]",-29];[")",-34;";",51;"RRPAREN",-34;"]",-34;"|]",-34];["(",40;"-",61;"DUMMY",12;"FUN",21;"IDENT",46;"LET",29;"LITERAL",7;"OPEN",13;"[",35;"[|",3;"appExpr",63;"arrayExpr",8;"atomicExpr",44;"declExpr",52;"lambdaExpr",27;"lambdaOrTupleExpr",15;"letBinding",16;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",39;"revTupleExpr",53;"tupleExpr",28;"unaryExpr",56];[")",-30;";",-30;"RRPAREN",-30;"]",-30;"|]",-30];[")",-35;",",54;";",-35;"RHSEND",-35;"RRPAREN",-35;"]",-35;"|]",-35];["(",40;"-",61;"FUN",21;"IDENT",46;"LITERAL",7;"[",35;"[|",3;"appExpr",63;"arrayExpr",8;"atomicExpr",44;"lambdaExpr",60;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",39;"unaryExpr",55];[")",-31;",",-31;";",-31;"RHSEND",-31;"RRPAREN",-31;"]",-31;"|]",-31];[")",-32;",",-32;";",-32;"RHSEND",-32;"RRPAREN",-32;"]",-32;"|]",-32];["(",40;"-",61;"DUMMY",12;"FUN",21;"IDENT",46;"LET",29;"LITERAL",7;"OPEN",13;"[",35;"[|",3;"appExpr",63;"arrayExpr",8;"atomicExpr",44;"declExpr",49;"lambdaExpr",27;"lambdaOrTupleExpr",15;"letBinding",16;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",39;"revSequentialExpr",50;"revTupleExpr",53;"sequentialExpr",58;"tupleExpr",28;"unaryExpr",56];["RRPAREN",59];[")",-33;";",-33;"EOF",-33;"RHSEND",-33;"RRPAREN",-33;"]",-33;"|]",-33];[")",-36;";",-36;"RHSEND",-36;"RRPAREN",-36;"]",-36;"|]",-36];["(",40;"IDENT",46;"LITERAL",7;"[",35;"[|",3;"appExpr",62;"arrayExpr",8;"atomicExpr",44;"listExpr",9;"longid",10;"parenExpr",11;"revAppExpr",2;"revLongid",39];[")",-37;",",-37;";",-37;"RHSEND",-37;"RRPAREN",-37;"]",-37;"|]",-37];[")",-38;",",-38;";",-38;"RHSEND",-38;"RRPAREN",-38;"]",-38;"|]",-38]]
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
    ["declExpr";"lambdaOrTupleExpr"], fun(ss:obj list)->
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
    ["lambdaExpr";"FUN";"IDENT";"->";"lambdaOrTupleExpr";"RHSEND"], fun(ss:obj list)->
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
    ["lambdaOrTupleExpr";"lambdaExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result
    ["lambdaOrTupleExpr";"tupleExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result
    ["letBinding";"LET";"IDENT";"=";"lambdaOrTupleExpr";"RHSEND"], fun(ss:obj list)->
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
    ["tupleExpr";"revTupleExpr";",";"lambdaExpr"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let result:option<int>*Expr =
            let ls = s0 |> List.map snd
            fst s2, TupleExpr(snd s2 :: ls |> List.rev)
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