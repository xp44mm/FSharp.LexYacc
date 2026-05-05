module FSharp.Substance.FSharpYacc
open FSharp.LexYacc
let stateSymbols: string[] = [|"";"file";"revAppExpr";"appType";"appType";"suffixType";"atomType";"[|";"revSequentialExpr";"opt_semicolon";"|]";"|]";"(";"typeArgument";")";"TYPAR";"longid";"<";"typeArguments";">";"(";")";"infix";")";"LITERAL";"arrayExpr";"identExpr";"listExpr";"parenExpr";"IDENT";":";"typeArgument";"parameterPattern";"revBinaryExpr";"tuplePattern";"letBinding";"valueExpr";"MODULE";"longid";"EOF";"revOpenOrLets";"opt_semicolon";"EOF";"funType";"->";"tupleType";"tupleType";"IDENT";"<";"typeArguments";">";"+";"+";"-";"-";"=";"ALWAYS_INFIX";"FUN";"parameterPattern";"->";"rhsBlock";"valueExpr";"RHSEND";"LET";"bindingPattern";"=";"rhsBlock";"valueExpr";"RHSEND";"[";"]";"revSequentialExpr";"opt_semicolon";"]";"revLongid";"OPEN";"longid";"letBinding";";";";";"(";"bindingPattern";")";"IDENT";"revSequentialExpr";"opt_semicolon";")";"!";"+";"-";"ALWAYS_PREFIX";"revQualificationExpr";".";"[";"tupleExpr";"]";"identExpr";"qualificationExpr";"qualificationExpr";"infix";"unaryExpr";"unaryExpr";"IDENT";".";"IDENT";"openOrLet";"openOrLet";"atomicExpr";"qualificationSuffix";"declExpr";"revSequentialExpr";"declExpr";"binaryExpr";"revTupleExpr";",";"binaryExpr";"LLPAREN";"opt_semicolon";"RRPAREN";"[";"]";"longid";"lambdaExpr";"atomicPattern";",";"atomicPattern";"*";"typeArgument";",";"typeArgument";"appExpr";"prefix";"appExpr";"lambdaExpr";"tupleExpr"|]
let actions: (string * int) list list = [["MODULE",37;"file",1];["",0];["(",20;")",-1;"+",-1;",",-1;"-",-1;";",-1;"=",-1;"ALWAYS_INFIX",-1;"IDENT",47;"LITERAL",24;"RHSEND",-1;"RRPAREN",-1;"[",69;"[|",7;"]",-1;"arrayExpr",25;"atomicExpr",107;"identExpr",26;"listExpr",27;"parenExpr",28;"qualificationExpr",98;"revQualificationExpr",91;"|]",-1];[")",-75;"*",-75;",",-75;"->",-75;"=",-75;">",-75;"IDENT",102;"[",119;"longid",121;"revLongid",74;"suffixType",5];[")",-76;"*",-76;",",-76;"->",-76;"=",-76;">",-76;"IDENT",102;"[",119;"longid",121;"revLongid",74;"suffixType",5];[")",-2;"*",-2;",",-2;"->",-2;"=",-2;">",-2;"IDENT",-2;"[",-2];[")",-3;"*",-3;",",-3;"->",-3;"=",-3;">",-3;"IDENT",-3;"[",-3];["!",87;"(",20;"+",88;"-",89;"ALWAYS_PREFIX",90;"FUN",57;"IDENT",47;"LET",63;"LITERAL",24;"[",69;"[|",7;"appExpr",130;"arrayExpr",25;"atomicExpr",107;"binaryExpr",112;"declExpr",109;"identExpr",26;"lambdaExpr",133;"letBinding",35;"listExpr",27;"parenExpr",28;"prefix",131;"qualificationExpr",97;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",91;"revSequentialExpr",8;"revTupleExpr",113;"tupleExpr",134;"unaryExpr",101;"valueExpr",36;"|]",11];[";",79;"opt_semicolon",9;"|]",-42];["|]",10];["(",-4;")",-4;"+",-4;",",-4;"-",-4;".",-4;";",-4;"=",-4;"ALWAYS_INFIX",-4;"IDENT",-4;"LITERAL",-4;"RHSEND",-4;"RRPAREN",-4;"[",-4;"[|",-4;"]",-4;"|]",-4];["(",-5;")",-5;"+",-5;",",-5;"-",-5;".",-5;";",-5;"=",-5;"ALWAYS_INFIX",-5;"IDENT",-5;"LITERAL",-5;"RHSEND",-5;"RRPAREN",-5;"[",-5;"[|",-5;"]",-5;"|]",-5];["(",12;"IDENT",102;"TYPAR",15;"appType",3;"atomType",6;"funType",43;"longid",16;"revLongid",74;"tupleType",46;"typeArgument",13];[")",14];[")",-6;"*",-6;",",-6;"->",-6;"=",-6;">",-6;"IDENT",-6;"[",-6];[")",-7;"*",-7;",",-7;"->",-7;"=",-7;">",-7;"IDENT",-7;"[",-7];[")",-8;"*",-8;",",-8;"->",-8;"<",17;"=",-8;">",-8;"IDENT",-8;"[",-8];["(",12;"IDENT",102;"TYPAR",15;"appType",3;"atomType",6;"funType",43;"longid",16;"revLongid",74;"tupleType",46;"typeArgument",127;"typeArguments",18];[",",128;">",19];[")",-9;"*",-9;",",-9;"->",-9;"=",-9;">",-9;"IDENT",-9;"[",-9];["!",87;"(",20;")",21;"+",52;"-",54;"=",55;"ALWAYS_INFIX",56;"ALWAYS_PREFIX",90;"FUN",57;"IDENT",47;"LET",63;"LITERAL",24;"[",69;"[|",7;"appExpr",130;"arrayExpr",25;"atomicExpr",107;"binaryExpr",112;"declExpr",109;"identExpr",26;"infix",22;"lambdaExpr",133;"letBinding",35;"listExpr",27;"parenExpr",28;"prefix",131;"qualificationExpr",97;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",91;"revSequentialExpr",84;"revTupleExpr",113;"tupleExpr",134;"unaryExpr",101;"valueExpr",36];["(",-10;")",-10;"+",-10;",",-10;"-",-10;".",-10;";",-10;"=",-10;"ALWAYS_INFIX",-10;"IDENT",-10;"LITERAL",-10;"RHSEND",-10;"RRPAREN",-10;"[",-10;"[|",-10;"]",-10;"|]",-10];[")",23];["(",-11;")",-11;"+",-11;",",-11;"-",-11;".",-11;";",-11;"=",-11;"ALWAYS_INFIX",-11;"IDENT",-11;"LITERAL",-11;"RHSEND",-11;"RRPAREN",-11;"[",-11;"[|",-11;"]",-11;"|]",-11];["(",-12;")",-12;"+",-12;",",-12;"-",-12;".",-12;";",-12;"=",-12;"ALWAYS_INFIX",-12;"IDENT",-12;"LITERAL",-12;"RHSEND",-12;"RRPAREN",-12;"[",-12;"[|",-12;"]",-12;"|]",-12];["(",-13;")",-13;"+",-13;",",-13;"-",-13;".",-13;";",-13;"=",-13;"ALWAYS_INFIX",-13;"IDENT",-13;"LITERAL",-13;"RHSEND",-13;"RRPAREN",-13;"[",-13;"[|",-13;"]",-13;"|]",-13];["(",-14;")",-14;"+",-14;",",-14;"-",-14;".",-14;";",-14;"=",-14;"ALWAYS_INFIX",-14;"IDENT",-14;"LITERAL",-14;"RHSEND",-14;"RRPAREN",-14;"[",-14;"[|",-14;"]",-14;"|]",-14];["(",-15;")",-15;"+",-15;",",-15;"-",-15;".",-15;";",-15;"=",-15;"ALWAYS_INFIX",-15;"IDENT",-15;"LITERAL",-15;"RHSEND",-15;"RRPAREN",-15;"[",-15;"[|",-15;"]",-15;"|]",-15];["(",-16;")",-16;"+",-16;",",-16;"-",-16;".",-16;";",-16;"=",-16;"ALWAYS_INFIX",-16;"IDENT",-16;"LITERAL",-16;"RHSEND",-16;"RRPAREN",-16;"[",-16;"[|",-16;"]",-16;"|]",-16];[")",-45;",",-45;":",30;"=",-45];["(",12;"IDENT",102;"TYPAR",15;"appType",3;"atomType",6;"funType",43;"longid",16;"revLongid",74;"tupleType",46;"typeArgument",31];[")",-17;",",-17;"=",-17];[")",-18;",",-18;"=",-18];[")",-19;"+",51;",",-19;"-",53;";",-19;"=",55;"ALWAYS_INFIX",56;"RHSEND",-19;"RRPAREN",-19;"]",-19;"infix",99;"|]",-19];[")",-20;",",124;"=",-20];[")",-21;";",-21;"RRPAREN",-21;"]",-21;"|]",-21];[")",-22;";",-22;"RRPAREN",-22;"]",-22;"|]",-22];["IDENT",102;"longid",38;"revLongid",74];["EOF",39;"LET",63;"OPEN",75;"letBinding",77;"openOrLet",105;"revOpenOrLets",40];["",-23];[";",78;"EOF",-42;"opt_semicolon",41];["EOF",42];["",-24];[")",-77;",",-77;"->",44;"=",-77;">",-77];["(",12;"IDENT",102;"TYPAR",15;"appType",3;"atomType",6;"longid",16;"revLongid",74;"tupleType",45];[")",-25;"*",126;",",-25;"->",-25;"=",-25;">",-25];[")",-26;"*",126;",",-26;"->",-26;"=",-26;">",-26];["(",-27;")",-27;"+",-27;",",-27;"-",-27;".",-27;";",-27;"<",48;"=",-27;"ALWAYS_INFIX",-27;"IDENT",-27;"LITERAL",-27;"RHSEND",-27;"RRPAREN",-27;"[",-27;"[|",-27;"]",-27;"|]",-27];["(",12;"IDENT",102;"TYPAR",15;"appType",3;"atomType",6;"funType",43;"longid",16;"revLongid",74;"tupleType",46;"typeArgument",127;"typeArguments",49];[",",128;">",50];["(",-28;")",-28;"+",-28;",",-28;"-",-28;".",-28;";",-28;"=",-28;"ALWAYS_INFIX",-28;"IDENT",-28;"LITERAL",-28;"RHSEND",-28;"RRPAREN",-28;"[",-28;"[|",-28;"]",-28;"|]",-28];["!",-29;"(",-29;"+",-29;"-",-29;"ALWAYS_PREFIX",-29;"IDENT",-29;"LITERAL",-29;"[",-29;"[|",-29];["(",-48;")",-29;"IDENT",-48;"LITERAL",-48;"[",-48;"[|",-48];["!",-30;"(",-30;"+",-30;"-",-30;"ALWAYS_PREFIX",-30;"IDENT",-30;"LITERAL",-30;"[",-30;"[|",-30];["(",-49;")",-30;"IDENT",-49;"LITERAL",-49;"[",-49;"[|",-49];["!",-31;"(",-31;")",-31;"+",-31;"-",-31;"ALWAYS_PREFIX",-31;"IDENT",-31;"LITERAL",-31;"[",-31;"[|",-31];["!",-32;"(",-32;")",-32;"+",-32;"-",-32;"ALWAYS_PREFIX",-32;"IDENT",-32;"LITERAL",-32;"[",-32;"[|",-32];["(",80;"IDENT",83;"parameterPattern",58];["->",59];["!",87;"(",20;"+",88;"-",89;"ALWAYS_PREFIX",90;"FUN",57;"IDENT",47;"LITERAL",24;"LLPAREN",116;"[",69;"[|",7;"appExpr",130;"arrayExpr",25;"atomicExpr",107;"binaryExpr",112;"identExpr",26;"lambdaExpr",133;"listExpr",27;"parenExpr",28;"prefix",131;"qualificationExpr",97;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",91;"revTupleExpr",113;"rhsBlock",60;"tupleExpr",134;"unaryExpr",101;"valueExpr",61];[")",-33;";",-33;"RHSEND",-33;"RRPAREN",-33;"]",-33;"|]",-33];["RHSEND",62];[")",-34;";",-34;"RHSEND",-34;"RRPAREN",-34;"]",-34;"|]",-34];["(",80;"IDENT",29;"atomicPattern",123;"bindingPattern",64;"parameterPattern",32;"tuplePattern",34];["=",65];["!",87;"(",20;"+",88;"-",89;"ALWAYS_PREFIX",90;"FUN",57;"IDENT",47;"LITERAL",24;"LLPAREN",116;"[",69;"[|",7;"appExpr",130;"arrayExpr",25;"atomicExpr",107;"binaryExpr",112;"identExpr",26;"lambdaExpr",133;"listExpr",27;"parenExpr",28;"prefix",131;"qualificationExpr",97;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",91;"revTupleExpr",113;"rhsBlock",66;"tupleExpr",134;"unaryExpr",101;"valueExpr",67];[")",-35;";",-35;"EOF",-35;"RRPAREN",-35;"]",-35;"|]",-35];["RHSEND",68];[")",-36;";",-36;"EOF",-36;"RRPAREN",-36;"]",-36;"|]",-36];["!",87;"(",20;"+",88;"-",89;"ALWAYS_PREFIX",90;"FUN",57;"IDENT",47;"LET",63;"LITERAL",24;"[",69;"[|",7;"]",70;"appExpr",130;"arrayExpr",25;"atomicExpr",107;"binaryExpr",112;"declExpr",109;"identExpr",26;"lambdaExpr",133;"letBinding",35;"listExpr",27;"parenExpr",28;"prefix",131;"qualificationExpr",97;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",91;"revSequentialExpr",71;"revTupleExpr",113;"tupleExpr",134;"unaryExpr",101;"valueExpr",36];["(",-37;")",-37;"+",-37;",",-37;"-",-37;".",-37;";",-37;"=",-37;"ALWAYS_INFIX",-37;"IDENT",-37;"LITERAL",-37;"RHSEND",-37;"RRPAREN",-37;"[",-37;"[|",-37;"]",-37;"|]",-37];[";",79;"]",-42;"opt_semicolon",72];["]",73];["(",-38;")",-38;"+",-38;",",-38;"-",-38;".",-38;";",-38;"=",-38;"ALWAYS_INFIX",-38;"IDENT",-38;"LITERAL",-38;"RHSEND",-38;"RRPAREN",-38;"[",-38;"[|",-38;"]",-38;"|]",-38];[")",-39;"*",-39;",",-39;"->",-39;".",103;";",-39;"<",-39;"=",-39;">",-39;"EOF",-39;"IDENT",-39;"LET",-39;"OPEN",-39;"[",-39];["IDENT",102;"longid",76;"revLongid",74];[";",-40;"EOF",-40];[";",-41;"EOF",-41];["EOF",-43;"LET",63;"OPEN",75;"letBinding",77;"openOrLet",106];["!",87;"(",20;")",-43;"+",88;"-",89;"ALWAYS_PREFIX",90;"FUN",57;"IDENT",47;"LET",63;"LITERAL",24;"RRPAREN",-43;"[",69;"[|",7;"]",-43;"appExpr",130;"arrayExpr",25;"atomicExpr",107;"binaryExpr",112;"declExpr",111;"identExpr",26;"lambdaExpr",133;"letBinding",35;"listExpr",27;"parenExpr",28;"prefix",131;"qualificationExpr",97;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",91;"revTupleExpr",113;"tupleExpr",134;"unaryExpr",101;"valueExpr",36;"|]",-43];["(",80;"IDENT",29;"atomicPattern",123;"bindingPattern",81;"parameterPattern",32;"tuplePattern",34];[")",82];[")",-44;",",-44;"->",-44;"=",-44];["->",-45];[")",-42;";",79;"opt_semicolon",85];[")",86];["(",-46;")",-46;"+",-46;",",-46;"-",-46;".",-46;";",-46;"=",-46;"ALWAYS_INFIX",-46;"IDENT",-46;"LITERAL",-46;"RHSEND",-46;"RRPAREN",-46;"[",-46;"[|",-46;"]",-46;"|]",-46];["(",-47;"IDENT",-47;"LITERAL",-47;"[",-47;"[|",-47];["(",-48;"IDENT",-48;"LITERAL",-48;"[",-48;"[|",-48];["(",-49;"IDENT",-49;"LITERAL",-49;"[",-49;"[|",-49];["(",-50;"IDENT",-50;"LITERAL",-50;"[",-50;"[|",-50];["(",-51;")",-51;"+",-51;",",-51;"-",-51;".",92;";",-51;"=",-51;"ALWAYS_INFIX",-51;"IDENT",-51;"LITERAL",-51;"RHSEND",-51;"RRPAREN",-51;"[",-51;"[|",-51;"]",-51;"qualificationSuffix",108;"|]",-51];["IDENT",47;"[",93;"identExpr",96];["!",87;"(",20;"+",88;"-",89;"ALWAYS_PREFIX",90;"IDENT",47;"LITERAL",24;"[",69;"[|",7;"appExpr",130;"arrayExpr",25;"atomicExpr",107;"binaryExpr",112;"identExpr",26;"listExpr",27;"parenExpr",28;"prefix",131;"qualificationExpr",97;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",91;"revTupleExpr",113;"tupleExpr",94;"unaryExpr",101];["]",95];["(",-52;")",-52;"+",-52;",",-52;"-",-52;".",-52;";",-52;"=",-52;"ALWAYS_INFIX",-52;"IDENT",-52;"LITERAL",-52;"RHSEND",-52;"RRPAREN",-52;"[",-52;"[|",-52;"]",-52;"|]",-52];["(",-53;")",-53;"+",-53;",",-53;"-",-53;".",-53;";",-53;"=",-53;"ALWAYS_INFIX",-53;"IDENT",-53;"LITERAL",-53;"RHSEND",-53;"RRPAREN",-53;"[",-53;"[|",-53;"]",-53;"|]",-53];["(",-54;")",-54;"+",-54;",",-54;"-",-54;";",-54;"=",-54;"ALWAYS_INFIX",-54;"IDENT",-54;"LITERAL",-54;"RHSEND",-54;"RRPAREN",-54;"[",-54;"[|",-54;"]",-54;"|]",-54];["(",-55;")",-55;"+",-55;",",-55;"-",-55;";",-55;"=",-55;"ALWAYS_INFIX",-55;"IDENT",-55;"LITERAL",-55;"RHSEND",-55;"RRPAREN",-55;"[",-55;"[|",-55;"]",-55;"|]",-55];["!",87;"(",20;"+",88;"-",89;"ALWAYS_PREFIX",90;"IDENT",47;"LITERAL",24;"[",69;"[|",7;"appExpr",130;"arrayExpr",25;"atomicExpr",107;"identExpr",26;"listExpr",27;"parenExpr",28;"prefix",131;"qualificationExpr",97;"revAppExpr",2;"revQualificationExpr",91;"unaryExpr",100];[")",-56;"+",-56;",",-56;"-",-56;";",-56;"=",-56;"ALWAYS_INFIX",-56;"RHSEND",-56;"RRPAREN",-56;"]",-56;"|]",-56];[")",-57;"+",-57;",",-57;"-",-57;";",-57;"=",-57;"ALWAYS_INFIX",-57;"RHSEND",-57;"RRPAREN",-57;"]",-57;"|]",-57];[")",-58;"*",-58;",",-58;"->",-58;".",-58;";",-58;"<",-58;"=",-58;">",-58;"EOF",-58;"IDENT",-58;"LET",-58;"OPEN",-58;"[",-58];["IDENT",104];[")",-59;"*",-59;",",-59;"->",-59;".",-59;";",-59;"<",-59;"=",-59;">",-59;"EOF",-59;"IDENT",-59;"LET",-59;"OPEN",-59;"[",-59];[";",-60;"EOF",-60];[";",-61;"EOF",-61];["(",-62;")",-62;"+",-62;",",-62;"-",-62;".",-62;";",-62;"=",-62;"ALWAYS_INFIX",-62;"IDENT",-62;"LITERAL",-62;"RHSEND",-62;"RRPAREN",-62;"[",-62;"[|",-62;"]",-62;"|]",-62];["(",-63;")",-63;"+",-63;",",-63;"-",-63;".",-63;";",-63;"=",-63;"ALWAYS_INFIX",-63;"IDENT",-63;"LITERAL",-63;"RHSEND",-63;"RRPAREN",-63;"[",-63;"[|",-63;"]",-63;"|]",-63];[")",-64;";",-64;"RRPAREN",-64;"]",-64;"|]",-64];[";",79;"RRPAREN",-42;"opt_semicolon",117];[")",-65;";",-65;"RRPAREN",-65;"]",-65;"|]",-65];[")",-66;",",-66;";",-66;"RHSEND",-66;"RRPAREN",-66;"]",-66;"|]",-66];[")",-71;",",114;";",-71;"RHSEND",-71;"RRPAREN",-71;"]",-71;"|]",-71];["!",87;"(",20;"+",88;"-",89;"ALWAYS_PREFIX",90;"FUN",57;"IDENT",47;"LITERAL",24;"[",69;"[|",7;"appExpr",130;"arrayExpr",25;"atomicExpr",107;"binaryExpr",115;"identExpr",26;"lambdaExpr",122;"listExpr",27;"parenExpr",28;"prefix",131;"qualificationExpr",97;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",91;"unaryExpr",101];[")",-67;",",-67;";",-67;"RHSEND",-67;"RRPAREN",-67;"]",-67;"|]",-67];["!",87;"(",20;"+",88;"-",89;"ALWAYS_PREFIX",90;"FUN",57;"IDENT",47;"LET",63;"LITERAL",24;"[",69;"[|",7;"appExpr",130;"arrayExpr",25;"atomicExpr",107;"binaryExpr",112;"declExpr",109;"identExpr",26;"lambdaExpr",133;"letBinding",35;"listExpr",27;"parenExpr",28;"prefix",131;"qualificationExpr",97;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",91;"revSequentialExpr",110;"revTupleExpr",113;"tupleExpr",134;"unaryExpr",101;"valueExpr",36];["RRPAREN",118];[")",-68;";",-68;"EOF",-68;"RHSEND",-68;"RRPAREN",-68;"]",-68;"|]",-68];["]",120];[")",-69;"*",-69;",",-69;"->",-69;"=",-69;">",-69;"IDENT",-69;"[",-69];[")",-70;"*",-70;",",-70;"->",-70;"=",-70;">",-70;"IDENT",-70;"[",-70];[")",-72;";",-72;"RHSEND",-72;"RRPAREN",-72;"]",-72;"|]",-72];[")",-73;",",-73;"=",-73];["(",80;"IDENT",29;"atomicPattern",125;"parameterPattern",32];[")",-74;",",-74;"=",-74];["(",12;"IDENT",102;"TYPAR",15;"appType",4;"atomType",6;"longid",16;"revLongid",74];[",",-78;">",-78];["(",12;"IDENT",102;"TYPAR",15;"appType",3;"atomType",6;"funType",43;"longid",16;"revLongid",74;"tupleType",46;"typeArgument",129];[",",-79;">",-79];[")",-80;"+",-80;",",-80;"-",-80;";",-80;"=",-80;"ALWAYS_INFIX",-80;"RHSEND",-80;"RRPAREN",-80;"]",-80;"|]",-80];["(",20;"IDENT",47;"LITERAL",24;"[",69;"[|",7;"appExpr",132;"arrayExpr",25;"atomicExpr",107;"identExpr",26;"listExpr",27;"parenExpr",28;"qualificationExpr",97;"revAppExpr",2;"revQualificationExpr",91];[")",-81;"+",-81;",",-81;"-",-81;";",-81;"=",-81;"ALWAYS_INFIX",-81;"RHSEND",-81;"RRPAREN",-81;"]",-81;"|]",-81];[")",-82;";",-82;"RHSEND",-82;"RRPAREN",-82;"]",-82;"|]",-82];[")",-83;";",-83;"RHSEND",-83;"RRPAREN",-83;"]",-83;"|]",-83]]
let rules: list<string list*(obj list->obj)> = [
    ["";"file"], (fun (ss:obj list) -> ss.[0])
    ["appExpr";"revAppExpr"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let result:option<int>*Expr =
            Expr.ofAppExpr s0
        box result)
    ["appType";"appType";"suffixType"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*TypeArgument)*((option<int> * SuffixType) list)> ss.[0]
        let s1 = unbox<option<int>*SuffixType> ss.[1]
        let result:(option<int>*TypeArgument)*((option<int> * SuffixType) list) =
            fst s0, s1::snd s0
        box result)
    ["appType";"atomType"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*TypeArgument> ss.[0]
        let result:(option<int>*TypeArgument)*((option<int> * SuffixType) list) =
            s0,[]
        box result)
    ["arrayExpr";"[|";"revSequentialExpr";"opt_semicolon";"|]"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(option<int>*Expr) list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*Expr =
            s0, ArrayExpr(snd (Expr.ofSequentialExpr s1))
        box result)
    ["arrayExpr";"[|";"|]"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let result:option<int>*Expr =
            s0, ArrayExpr []
        box result)
    ["atomType";"(";"typeArgument";")"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*TypeArgument> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:option<int>*TypeArgument =
            fst s1, ParenType(snd s1)
        box result)
    ["atomType";"TYPAR"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let result:option<int>*TypeArgument =
            fst s0, Typar(snd s0)
        box result)
    ["atomType";"longid"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string list> ss.[0]
        let result:option<int>*TypeArgument =
            fst s0, NamedType(snd s0)
        box result)
    ["atomType";"longid";"<";"typeArguments";">"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int>*TypeArgument) list> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*TypeArgument =
            let s2 = s2 |> List.map snd |> List.rev
            fst s0, GenericType(snd s0, s2 )
        box result)
    ["atomicExpr";"(";")"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let result:option<int>*Expr =
            s0, LiteralExpr Literal.UNIT
        box result)
    ["atomicExpr";"(";"infix";")"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*string> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:option<int>*Expr =
            s0, OperatorSectionExpr(snd s1)
        box result)
    ["atomicExpr";"LITERAL"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Literal> ss.[0]
        let result:option<int>*Expr =
            let i,v = s0
            i,LiteralExpr v
        box result)
    ["atomicExpr";"arrayExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
    ["atomicExpr";"identExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
    ["atomicExpr";"listExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
    ["atomicExpr";"parenExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
    ["atomicPattern";"IDENT";":";"typeArgument"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*TypeArgument> ss.[2]
        let result:option<int>*Pattern =
            fst s0, TypeAnnotationPattern(snd s0, snd s2)
        box result)
    ["atomicPattern";"parameterPattern"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Pattern> ss.[0]
        let result:option<int>*Pattern =
            s0
        box result)
    ["binaryExpr";"revBinaryExpr"], (fun(ss:obj list)->
        let s0 = unbox<((option<int>*string)*(option<int>*Expr)) list> ss.[0]
        let result:option<int>*Expr =
            Expr.ofBinaryExpr s0
        box result)
    ["bindingPattern";"tuplePattern"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*Pattern)list> ss.[0]
        let result:option<int>*Pattern =
            Pattern.ofTuplePattern s0
        box result)
    ["declExpr";"letBinding"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
    ["declExpr";"valueExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
    ["file";"MODULE";"longid";"EOF"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*string list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:string list*Expr list =
            snd s1, []
        box result)
    ["file";"MODULE";"longid";"revOpenOrLets";"opt_semicolon";"EOF"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*string list> ss.[1]
        let s2 = unbox<(option<int>*Expr) list> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let s4 = unbox<option<int>> ss.[4]
        let result:string list*Expr list =
            let ls = s2 |> List.rev |> List.map snd
            snd s1, ls
        box result)
    ["funType";"funType";"->";"tupleType"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*TypeArgument) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int>*TypeArgument) list> ss.[2]
        let result:(option<int>*TypeArgument) list =
            let s2 = TypeArgument.ofTuple s2
            s2::s0
        box result)
    ["funType";"tupleType"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*TypeArgument) list> ss.[0]
        let result:(option<int>*TypeArgument) list =
            let s0 = TypeArgument.ofTuple s0
            [s0]
        box result)
    ["identExpr";"IDENT"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let result:option<int>*Expr =
            fst s0, IdentExpr(snd s0)
        box result)
    ["identExpr";"IDENT";"<";"typeArguments";">"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int>*TypeArgument) list> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*Expr =
            let targs = s2 |> List.map snd |> List.rev
            fst s0, TypeApplicationExpr(snd s0,targs) 
        box result)
    ["infix";"+"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "+"
        box result)
    ["infix";"-"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "-"
        box result)
    ["infix";"="], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "="
        box result)
    ["infix";"ALWAYS_INFIX"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let result:option<int>*string =
            s0
        box result)
    ["lambdaExpr";"FUN";"parameterPattern";"->";"rhsBlock"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Pattern> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>*Expr list> ss.[3]
        let result:option<int>*Expr =
            s0, LambdaExpr(snd s1, snd s3)
        box result)
    ["lambdaExpr";"FUN";"parameterPattern";"->";"valueExpr";"RHSEND"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Pattern> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>*Expr> ss.[3]
        let s4 = unbox<option<int>> ss.[4]
        let result:option<int>*Expr =
            s0, LambdaExpr(snd s1, [snd s3])
        box result)
    ["letBinding";"LET";"bindingPattern";"=";"rhsBlock"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Pattern> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>*Expr list> ss.[3]
        let result:option<int>*Expr =
            s0, LetBindingExpr(snd s1, snd s3)
        box result)
    ["letBinding";"LET";"bindingPattern";"=";"valueExpr";"RHSEND"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Pattern> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>*Expr> ss.[3]
        let s4 = unbox<option<int>> ss.[4]
        let result:option<int>*Expr =
            s0, LetBindingExpr(snd s1, [snd s3])
        box result)
    ["listExpr";"[";"]"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let result:option<int>*Expr =
            s0, ListExpr []
        box result)
    ["listExpr";"[";"revSequentialExpr";"opt_semicolon";"]"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(option<int>*Expr) list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*Expr =
            s0, ListExpr(snd (Expr.ofSequentialExpr s1))
        box result)
    ["longid";"revLongid"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*string) list> ss.[0]
        let result:option<int>*string list =
            let i,ls = s0 |> List.rev |> List.unzip
            i.[0], ls
        box result)
    ["openOrLet";"OPEN";"longid"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*string list> ss.[1]
        let result:option<int>*Expr =
            s0, OpenExpr(snd s1)
        box result)
    ["openOrLet";"letBinding"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
    ["opt_semicolon"], (fun(ss:obj list)->
        let result:option<int> =
            None
        box result)
    ["opt_semicolon";";"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int> =
            s0
        box result)
    ["parameterPattern";"(";"bindingPattern";")"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Pattern> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:option<int>*Pattern =
            s0, snd s1
        box result)
    ["parameterPattern";"IDENT"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let result:option<int>*Pattern =
            fst s0, IdentPattern(snd s0)
        box result)
    ["parenExpr";"(";"revSequentialExpr";"opt_semicolon";")"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(option<int>*Expr) list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*Expr =
            s0, ParenExpr(snd (Expr.ofSequentialExpr s1))
        box result)
    ["prefix";"!"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "!"
        box result)
    ["prefix";"+"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "+"
        box result)
    ["prefix";"-"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "-"
        box result)
    ["prefix";"ALWAYS_PREFIX"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let result:option<int>*string =
            s0
        box result)
    ["qualificationExpr";"revQualificationExpr"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let result:option<int>*Expr =
            Expr.ofQualification(s0)
        box result)
    ["qualificationSuffix";".";"[";"tupleExpr";"]"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*Expr =
            s2
        box result)
    ["qualificationSuffix";".";"identExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Expr> ss.[1]
        let result:option<int>*Expr =
            s1
        box result)
    ["revAppExpr";"qualificationExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:(option<int>*Expr) list =
            [s0]
        box result)
    ["revAppExpr";"revAppExpr";"qualificationExpr"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let s1 = unbox<option<int>*Expr> ss.[1]
        let result:(option<int>*Expr) list =
            s1::s0
        box result)
    ["revBinaryExpr";"revBinaryExpr";"infix";"unaryExpr"], (fun(ss:obj list)->
        let s0 = unbox<((option<int>*string)*(option<int>*Expr)) list> ss.[0]
        let s1 = unbox<option<int>*string> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let result:((option<int>*string)*(option<int>*Expr)) list =
            (s1,s2)::s0
        box result)
    ["revBinaryExpr";"unaryExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:((option<int>*string)*(option<int>*Expr)) list =
            [(None,""),s0]
        box result)
    ["revLongid";"IDENT"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let result:(option<int>*string) list =
            [s0]
        box result)
    ["revLongid";"revLongid";".";"IDENT"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*string) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*string> ss.[2]
        let result:(option<int>*string) list =
            s2 :: s0
        box result)
    ["revOpenOrLets";"openOrLet"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:(option<int>*Expr) list =
            [s0]
        box result)
    ["revOpenOrLets";"revOpenOrLets";";";"openOrLet"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let result:(option<int>*Expr) list =
            s2::s0
        box result)
    ["revQualificationExpr";"atomicExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:(option<int>*Expr) list =
            [s0]
        box result)
    ["revQualificationExpr";"revQualificationExpr";"qualificationSuffix"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let s1 = unbox<option<int>*Expr> ss.[1]
        let result:(option<int>*Expr) list =
            s1::s0
        box result)
    ["revSequentialExpr";"declExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:(option<int>*Expr) list =
            [s0]
        box result)
    ["revSequentialExpr";"revSequentialExpr";";";"declExpr"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let result:(option<int>*Expr) list =
            s2::s0
        box result)
    ["revTupleExpr";"binaryExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:(option<int>*Expr) list =
            [s0]
        box result)
    ["revTupleExpr";"revTupleExpr";",";"binaryExpr"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let result:(option<int>*Expr) list =
            s2::s0
        box result)
    ["rhsBlock";"LLPAREN";"revSequentialExpr";"opt_semicolon";"RRPAREN"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(option<int>*Expr) list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*Expr list =
            Expr.ofSequentialExpr s1
        box result)
    ["suffixType";"[";"]"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let result:option<int>*SuffixType =
            s0, ArrayTypeSuffix 0
        box result)
    ["suffixType";"longid"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string list> ss.[0]
        let result:option<int>*SuffixType =
            fst s0, IdentSuffix(snd s0)
        box result)
    ["tupleExpr";"revTupleExpr"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let result:option<int>*Expr =
            Expr.ofTupleExpr s0
        box result)
    ["tupleExpr";"revTupleExpr";",";"lambdaExpr"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let result:option<int>*Expr =
            Expr.ofTupleLambdaExpr s0 s2
        box result)
    ["tuplePattern";"atomicPattern"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Pattern> ss.[0]
        let result:(option<int>*Pattern)list =
            [s0]
        box result)
    ["tuplePattern";"tuplePattern";",";"atomicPattern"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*Pattern)list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Pattern> ss.[2]
        let result:(option<int>*Pattern)list =
            s2::s0
        box result)
    ["tupleType";"appType"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*TypeArgument)*((option<int> * SuffixType) list)> ss.[0]
        let result:(option<int>*TypeArgument) list =
            [TypeArgument.ofApp s0]
        box result)
    ["tupleType";"tupleType";"*";"appType"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*TypeArgument) list> ss.[0]
        let s2 = unbox<(option<int>*TypeArgument)*((option<int> * SuffixType) list)> ss.[2]
        let result:(option<int>*TypeArgument) list =
            TypeArgument.ofApp s2::s0
        box result)
    ["typeArgument";"funType"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*TypeArgument) list> ss.[0]
        let result:option<int>*TypeArgument =
            TypeArgument.ofFun s0
        box result)
    ["typeArguments";"typeArgument"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*TypeArgument> ss.[0]
        let result:(option<int>*TypeArgument) list =
            [s0]
        box result)
    ["typeArguments";"typeArguments";",";"typeArgument"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*TypeArgument) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*TypeArgument> ss.[2]
        let result:(option<int>*TypeArgument) list =
            s2::s0
        box result)
    ["unaryExpr";"appExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
    ["unaryExpr";"prefix";"appExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let s1 = unbox<option<int>*Expr> ss.[1]
        let result:option<int>*Expr =
            let indent, op = s0
            indent, UnaryExpr(op, snd s1)
        box result)
    ["valueExpr";"lambdaExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
    ["valueExpr";"tupleExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
]
let unboxRoot =
    unbox<string list*Expr list>
let parser = ParseTable.from(rules, actions)