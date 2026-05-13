module FSharp.Substance.FSharpYacc
open FSharp.LexYacc
let stateSymbols: string[] = [|"";"file";"revAppExpr";"appType";"appType";"suffixType";"atomType";"[|";"revSequentialExpr";"opt_semicolon";"|]";"|]";"(";"typeArgument";")";"TYPAR";"longid";"<";"typeArguments";">";"(";")";"infix";")";"LITERAL";"arrayExpr";"identExpr";"listExpr";"parenExpr";"recdLiteralExpr";"IDENT";":";"typeArgument";"parameterPattern";"revBinaryExpr";"tuplePattern";"letBinding";"matchExpr";"valueExpr";"IDENT";"=";"LLPAREN";"revSequentialExpr";"opt_semicolon";"RRPAREN";"valueExpr";"RHSEND";"fieldBinding";"fieldBindings";";";"fieldBinding";"MODULE";"longid";"EOF";"revOpenOrLets";"opt_semicolon";"EOF";"funType";"->";"tupleType";"tupleType";"IDENT";"<";"typeArguments";">";"*";"+";"+";"-";"-";"=";"ALWAYS_INFIX";"FUN";"parameterPattern";"->";"LLPAREN";"revSequentialExpr";"opt_semicolon";"RRPAREN";"valueExpr";"RHSEND";"LET";"bindingPattern";"=";"LLPAREN";"revSequentialExpr";"opt_semicolon";"RRPAREN";"valueExpr";"RHSEND";"[";"]";"revSequentialExpr";"opt_semicolon";"]";"revLongid";"MATCH";"tupleExpr";"WITH";"opt_bar";"revRuleClauses";"IDENT";"LITERAL";"OPEN";"longid";"letBinding";"|";";";";";"(";"bindingPattern";")";"IDENT";"revSequentialExpr";"opt_semicolon";")";"matchPattern";"WHEN";"binaryExpr";"+";"-";"ALWAYS_PREFIX";"revQualificationExpr";".";"[";"tupleExpr";"]";"identExpr";"{";"opt_semicolon";"}";"qualificationExpr";"qualificationExpr";"infix";"unaryExpr";"unaryExpr";"IDENT";".";"IDENT";"openOrLet";"openOrLet";"atomicExpr";"qualificationSuffix";"|";"ruleClause";"ruleClause";"declExpr";"revSequentialExpr";"declExpr";"binaryExpr";"revTupleExpr";",";"binaryExpr";"patternAndGuard";"->";"LLPAREN";"opt_semicolon";"RRPAREN";"valueExpr";"RHSEND";"[";"]";"longid";"atomicPattern";",";"atomicPattern";"*";"typeArgument";",";"typeArgument";"appExpr";"prefix";"appExpr";"lambdaExpr";"tupleExpr"|]
let actions: (string * int) list list = [["MODULE",51;"file",1];["",0];["(",20;")",-1;"*",-1;"+",-1;",",-1;"-",-1;"->",-1;";",-1;"=",-1;"ALWAYS_INFIX",-1;"IDENT",61;"LITERAL",24;"RHSEND",-1;"RRPAREN",-1;"WITH",-1;"[",90;"[|",7;"]",-1;"arrayExpr",25;"atomicExpr",141;"identExpr",26;"listExpr",27;"parenExpr",28;"qualificationExpr",132;"recdLiteralExpr",29;"revQualificationExpr",122;"{",128;"|]",-1];[")",-91;"*",-91;",",-91;"->",-91;"=",-91;">",-91;"IDENT",136;"[",160;"longid",162;"revLongid",95;"suffixType",5];[")",-92;"*",-92;",",-92;"->",-92;"=",-92;">",-92;"IDENT",136;"[",160;"longid",162;"revLongid",95;"suffixType",5];[")",-2;"*",-2;",",-2;"->",-2;"=",-2;">",-2;"IDENT",-2;"[",-2];[")",-3;"*",-3;",",-3;"->",-3;"=",-3;">",-3;"IDENT",-3;"[",-3];["(",20;"+",119;"-",120;"ALWAYS_PREFIX",121;"FUN",72;"IDENT",61;"LET",81;"LITERAL",24;"MATCH",96;"[",90;"[|",7;"appExpr",170;"arrayExpr",25;"atomicExpr",141;"binaryExpr",149;"declExpr",146;"identExpr",26;"lambdaExpr",173;"letBinding",36;"listExpr",27;"matchExpr",37;"parenExpr",28;"prefix",171;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revBinaryExpr",34;"revQualificationExpr",122;"revSequentialExpr",8;"revTupleExpr",150;"tupleExpr",174;"unaryExpr",135;"valueExpr",38;"{",128;"|]",11];[";",108;"opt_semicolon",9;"|]",-54];["|]",10];["(",-4;")",-4;"*",-4;"+",-4;",",-4;"-",-4;"->",-4;".",-4;";",-4;"=",-4;"ALWAYS_INFIX",-4;"IDENT",-4;"LITERAL",-4;"RHSEND",-4;"RRPAREN",-4;"WITH",-4;"[",-4;"[|",-4;"]",-4;"{",-4;"|]",-4];["(",-5;")",-5;"*",-5;"+",-5;",",-5;"-",-5;"->",-5;".",-5;";",-5;"=",-5;"ALWAYS_INFIX",-5;"IDENT",-5;"LITERAL",-5;"RHSEND",-5;"RRPAREN",-5;"WITH",-5;"[",-5;"[|",-5;"]",-5;"{",-5;"|]",-5];["(",12;"IDENT",136;"TYPAR",15;"appType",3;"atomType",6;"funType",57;"longid",16;"revLongid",95;"tupleType",60;"typeArgument",13];[")",14];[")",-6;"*",-6;",",-6;"->",-6;"=",-6;">",-6;"IDENT",-6;"[",-6];[")",-7;"*",-7;",",-7;"->",-7;"=",-7;">",-7;"IDENT",-7;"[",-7];[")",-8;"*",-8;",",-8;"->",-8;"<",17;"=",-8;">",-8;"IDENT",-8;"[",-8];["(",12;"IDENT",136;"TYPAR",15;"appType",3;"atomType",6;"funType",57;"longid",16;"revLongid",95;"tupleType",60;"typeArgument",167;"typeArguments",18];[",",168;">",19];[")",-9;"*",-9;",",-9;"->",-9;"=",-9;">",-9;"IDENT",-9;"[",-9];["(",20;")",21;"*",65;"+",67;"-",69;"=",70;"ALWAYS_INFIX",71;"ALWAYS_PREFIX",121;"FUN",72;"IDENT",61;"LET",81;"LITERAL",24;"MATCH",96;"[",90;"[|",7;"appExpr",170;"arrayExpr",25;"atomicExpr",141;"binaryExpr",149;"declExpr",146;"identExpr",26;"infix",22;"lambdaExpr",173;"letBinding",36;"listExpr",27;"matchExpr",37;"parenExpr",28;"prefix",171;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revBinaryExpr",34;"revQualificationExpr",122;"revSequentialExpr",113;"revTupleExpr",150;"tupleExpr",174;"unaryExpr",135;"valueExpr",38;"{",128];["(",-10;")",-10;"*",-10;"+",-10;",",-10;"-",-10;"->",-10;".",-10;";",-10;"=",-10;"ALWAYS_INFIX",-10;"IDENT",-10;"LITERAL",-10;"RHSEND",-10;"RRPAREN",-10;"WITH",-10;"[",-10;"[|",-10;"]",-10;"{",-10;"|]",-10];[")",23];["(",-11;")",-11;"*",-11;"+",-11;",",-11;"-",-11;"->",-11;".",-11;";",-11;"=",-11;"ALWAYS_INFIX",-11;"IDENT",-11;"LITERAL",-11;"RHSEND",-11;"RRPAREN",-11;"WITH",-11;"[",-11;"[|",-11;"]",-11;"{",-11;"|]",-11];["(",-12;")",-12;"*",-12;"+",-12;",",-12;"-",-12;"->",-12;".",-12;";",-12;"=",-12;"ALWAYS_INFIX",-12;"IDENT",-12;"LITERAL",-12;"RHSEND",-12;"RRPAREN",-12;"WITH",-12;"[",-12;"[|",-12;"]",-12;"{",-12;"|]",-12];["(",-13;")",-13;"*",-13;"+",-13;",",-13;"-",-13;"->",-13;".",-13;";",-13;"=",-13;"ALWAYS_INFIX",-13;"IDENT",-13;"LITERAL",-13;"RHSEND",-13;"RRPAREN",-13;"WITH",-13;"[",-13;"[|",-13;"]",-13;"{",-13;"|]",-13];["(",-14;")",-14;"*",-14;"+",-14;",",-14;"-",-14;"->",-14;".",-14;";",-14;"=",-14;"ALWAYS_INFIX",-14;"IDENT",-14;"LITERAL",-14;"RHSEND",-14;"RRPAREN",-14;"WITH",-14;"[",-14;"[|",-14;"]",-14;"{",-14;"|]",-14];["(",-15;")",-15;"*",-15;"+",-15;",",-15;"-",-15;"->",-15;".",-15;";",-15;"=",-15;"ALWAYS_INFIX",-15;"IDENT",-15;"LITERAL",-15;"RHSEND",-15;"RRPAREN",-15;"WITH",-15;"[",-15;"[|",-15;"]",-15;"{",-15;"|]",-15];["(",-16;")",-16;"*",-16;"+",-16;",",-16;"-",-16;"->",-16;".",-16;";",-16;"=",-16;"ALWAYS_INFIX",-16;"IDENT",-16;"LITERAL",-16;"RHSEND",-16;"RRPAREN",-16;"WITH",-16;"[",-16;"[|",-16;"]",-16;"{",-16;"|]",-16];["(",-17;")",-17;"*",-17;"+",-17;",",-17;"-",-17;"->",-17;".",-17;";",-17;"=",-17;"ALWAYS_INFIX",-17;"IDENT",-17;"LITERAL",-17;"RHSEND",-17;"RRPAREN",-17;"WITH",-17;"[",-17;"[|",-17;"]",-17;"{",-17;"|]",-17];[")",-57;",",-57;":",31;"=",-57];["(",12;"IDENT",136;"TYPAR",15;"appType",3;"atomType",6;"funType",57;"longid",16;"revLongid",95;"tupleType",60;"typeArgument",32];[")",-18;",",-18;"=",-18];[")",-19;",",-19;"=",-19];[")",-20;"*",65;"+",66;",",-20;"-",68;"->",-20;";",-20;"=",70;"ALWAYS_INFIX",71;"RHSEND",-20;"RRPAREN",-20;"WITH",-20;"]",-20;"infix",133;"|]",-20];[")",-21;",",164;"=",-21];[")",-22;";",-22;"RRPAREN",-22;"]",-22;"|]",-22];[")",-23;";",-23;"RRPAREN",-23;"]",-23;"|]",-23];[")",-24;";",-24;"RRPAREN",-24;"]",-24;"|]",-24];["=",40];["(",20;"+",119;"-",120;"ALWAYS_PREFIX",121;"FUN",72;"IDENT",61;"LITERAL",24;"LLPAREN",41;"[",90;"[|",7;"appExpr",170;"arrayExpr",25;"atomicExpr",141;"binaryExpr",149;"identExpr",26;"lambdaExpr",173;"listExpr",27;"parenExpr",28;"prefix",171;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revBinaryExpr",34;"revQualificationExpr",122;"revTupleExpr",150;"tupleExpr",174;"unaryExpr",135;"valueExpr",45;"{",128];["(",20;"+",119;"-",120;"ALWAYS_PREFIX",121;"FUN",72;"IDENT",61;"LET",81;"LITERAL",24;"MATCH",96;"[",90;"[|",7;"appExpr",170;"arrayExpr",25;"atomicExpr",141;"binaryExpr",149;"declExpr",146;"identExpr",26;"lambdaExpr",173;"letBinding",36;"listExpr",27;"matchExpr",37;"parenExpr",28;"prefix",171;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revBinaryExpr",34;"revQualificationExpr",122;"revSequentialExpr",42;"revTupleExpr",150;"tupleExpr",174;"unaryExpr",135;"valueExpr",38;"{",128];[";",108;"RRPAREN",-54;"opt_semicolon",43];["RRPAREN",44];[";",-25;"}",-25];["RHSEND",46];[";",-26;"}",-26];[";",-27;"}",-27];[";",49;"opt_semicolon",129;"}",-54];["IDENT",39;"fieldBinding",50;"}",-55];[";",-28;"}",-28];["IDENT",136;"longid",52;"revLongid",95];["EOF",53;"LET",81;"OPEN",103;"letBinding",105;"openOrLet",139;"revOpenOrLets",54];["",-29];[";",107;"EOF",-54;"opt_semicolon",55];["EOF",56];["",-30];[")",-93;",",-93;"->",58;"=",-93;">",-93];["(",12;"IDENT",136;"TYPAR",15;"appType",3;"atomType",6;"longid",16;"revLongid",95;"tupleType",59];[")",-31;"*",166;",",-31;"->",-31;"=",-31;">",-31];[")",-32;"*",166;",",-32;"->",-32;"=",-32;">",-32];["(",-33;")",-33;"*",-33;"+",-33;",",-33;"-",-33;"->",-33;".",-33;";",-33;"<",62;"=",-33;"ALWAYS_INFIX",-33;"IDENT",-33;"LITERAL",-33;"RHSEND",-33;"RRPAREN",-33;"WITH",-33;"[",-33;"[|",-33;"]",-33;"{",-33;"|]",-33];["(",12;"IDENT",136;"TYPAR",15;"appType",3;"atomType",6;"funType",57;"longid",16;"revLongid",95;"tupleType",60;"typeArgument",167;"typeArguments",63];[",",168;">",64];["(",-34;")",-34;"*",-34;"+",-34;",",-34;"-",-34;"->",-34;".",-34;";",-34;"=",-34;"ALWAYS_INFIX",-34;"IDENT",-34;"LITERAL",-34;"RHSEND",-34;"RRPAREN",-34;"WITH",-34;"[",-34;"[|",-34;"]",-34;"{",-34;"|]",-34];["(",-35;")",-35;"+",-35;"-",-35;"ALWAYS_PREFIX",-35;"IDENT",-35;"LITERAL",-35;"[",-35;"[|",-35;"{",-35];["(",-36;"+",-36;"-",-36;"ALWAYS_PREFIX",-36;"IDENT",-36;"LITERAL",-36;"[",-36;"[|",-36;"{",-36];["(",-61;")",-36;"IDENT",-61;"LITERAL",-61;"[",-61;"[|",-61;"{",-61];["(",-37;"+",-37;"-",-37;"ALWAYS_PREFIX",-37;"IDENT",-37;"LITERAL",-37;"[",-37;"[|",-37;"{",-37];["(",-62;")",-37;"IDENT",-62;"LITERAL",-62;"[",-62;"[|",-62;"{",-62];["(",-38;")",-38;"+",-38;"-",-38;"ALWAYS_PREFIX",-38;"IDENT",-38;"LITERAL",-38;"[",-38;"[|",-38;"{",-38];["(",-39;")",-39;"+",-39;"-",-39;"ALWAYS_PREFIX",-39;"IDENT",-39;"LITERAL",-39;"[",-39;"[|",-39;"{",-39];["(",109;"IDENT",112;"parameterPattern",73];["->",74];["(",20;"+",119;"-",120;"ALWAYS_PREFIX",121;"FUN",72;"IDENT",61;"LITERAL",24;"LLPAREN",75;"[",90;"[|",7;"appExpr",170;"arrayExpr",25;"atomicExpr",141;"binaryExpr",149;"identExpr",26;"lambdaExpr",173;"listExpr",27;"parenExpr",28;"prefix",171;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revBinaryExpr",34;"revQualificationExpr",122;"revTupleExpr",150;"tupleExpr",174;"unaryExpr",135;"valueExpr",79;"{",128];["(",20;"+",119;"-",120;"ALWAYS_PREFIX",121;"FUN",72;"IDENT",61;"LET",81;"LITERAL",24;"MATCH",96;"[",90;"[|",7;"appExpr",170;"arrayExpr",25;"atomicExpr",141;"binaryExpr",149;"declExpr",146;"identExpr",26;"lambdaExpr",173;"letBinding",36;"listExpr",27;"matchExpr",37;"parenExpr",28;"prefix",171;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revBinaryExpr",34;"revQualificationExpr",122;"revSequentialExpr",76;"revTupleExpr",150;"tupleExpr",174;"unaryExpr",135;"valueExpr",38;"{",128];[";",108;"RRPAREN",-54;"opt_semicolon",77];["RRPAREN",78];[")",-40;";",-40;"RHSEND",-40;"RRPAREN",-40;"]",-40;"|]",-40];["RHSEND",80];[")",-41;";",-41;"RHSEND",-41;"RRPAREN",-41;"]",-41;"|]",-41];["(",109;"IDENT",30;"atomicPattern",163;"bindingPattern",82;"parameterPattern",33;"tuplePattern",35];["=",83];["(",20;"+",119;"-",120;"ALWAYS_PREFIX",121;"FUN",72;"IDENT",61;"LITERAL",24;"LLPAREN",84;"[",90;"[|",7;"appExpr",170;"arrayExpr",25;"atomicExpr",141;"binaryExpr",149;"identExpr",26;"lambdaExpr",173;"listExpr",27;"parenExpr",28;"prefix",171;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revBinaryExpr",34;"revQualificationExpr",122;"revTupleExpr",150;"tupleExpr",174;"unaryExpr",135;"valueExpr",88;"{",128];["(",20;"+",119;"-",120;"ALWAYS_PREFIX",121;"FUN",72;"IDENT",61;"LET",81;"LITERAL",24;"MATCH",96;"[",90;"[|",7;"appExpr",170;"arrayExpr",25;"atomicExpr",141;"binaryExpr",149;"declExpr",146;"identExpr",26;"lambdaExpr",173;"letBinding",36;"listExpr",27;"matchExpr",37;"parenExpr",28;"prefix",171;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revBinaryExpr",34;"revQualificationExpr",122;"revSequentialExpr",85;"revTupleExpr",150;"tupleExpr",174;"unaryExpr",135;"valueExpr",38;"{",128];[";",108;"RRPAREN",-54;"opt_semicolon",86];["RRPAREN",87];[")",-42;";",-42;"EOF",-42;"RRPAREN",-42;"]",-42;"|]",-42];["RHSEND",89];[")",-43;";",-43;"EOF",-43;"RRPAREN",-43;"]",-43;"|]",-43];["(",20;"+",119;"-",120;"ALWAYS_PREFIX",121;"FUN",72;"IDENT",61;"LET",81;"LITERAL",24;"MATCH",96;"[",90;"[|",7;"]",91;"appExpr",170;"arrayExpr",25;"atomicExpr",141;"binaryExpr",149;"declExpr",146;"identExpr",26;"lambdaExpr",173;"letBinding",36;"listExpr",27;"matchExpr",37;"parenExpr",28;"prefix",171;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revBinaryExpr",34;"revQualificationExpr",122;"revSequentialExpr",92;"revTupleExpr",150;"tupleExpr",174;"unaryExpr",135;"valueExpr",38;"{",128];["(",-44;")",-44;"*",-44;"+",-44;",",-44;"-",-44;"->",-44;".",-44;";",-44;"=",-44;"ALWAYS_INFIX",-44;"IDENT",-44;"LITERAL",-44;"RHSEND",-44;"RRPAREN",-44;"WITH",-44;"[",-44;"[|",-44;"]",-44;"{",-44;"|]",-44];[";",108;"]",-54;"opt_semicolon",93];["]",94];["(",-45;")",-45;"*",-45;"+",-45;",",-45;"-",-45;"->",-45;".",-45;";",-45;"=",-45;"ALWAYS_INFIX",-45;"IDENT",-45;"LITERAL",-45;"RHSEND",-45;"RRPAREN",-45;"WITH",-45;"[",-45;"[|",-45;"]",-45;"{",-45;"|]",-45];[")",-46;"*",-46;",",-46;"->",-46;".",137;";",-46;"<",-46;"=",-46;">",-46;"EOF",-46;"IDENT",-46;"LET",-46;"OPEN",-46;"[",-46];["(",20;"+",119;"-",120;"ALWAYS_PREFIX",121;"IDENT",61;"LITERAL",24;"[",90;"[|",7;"appExpr",170;"arrayExpr",25;"atomicExpr",141;"binaryExpr",149;"identExpr",26;"listExpr",27;"parenExpr",28;"prefix",171;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revBinaryExpr",34;"revQualificationExpr",122;"revTupleExpr",150;"tupleExpr",97;"unaryExpr",135;"{",128];["WITH",98];["IDENT",-52;"LITERAL",-52;"opt_bar",99;"|",106];["IDENT",101;"LITERAL",102;"matchPattern",116;"patternAndGuard",153;"revRuleClauses",100;"ruleClause",145];[")",-47;";",-47;"RRPAREN",-47;"]",-47;"|",143;"|]",-47];["->",-48;"WHEN",-48];["->",-49;"WHEN",-49];["IDENT",136;"longid",104;"revLongid",95];[";",-50;"EOF",-50];[";",-51;"EOF",-51];["IDENT",-53;"LITERAL",-53];["EOF",-55;"LET",81;"OPEN",103;"letBinding",105;"openOrLet",140];["(",20;")",-55;"+",119;"-",120;"ALWAYS_PREFIX",121;"FUN",72;"IDENT",61;"LET",81;"LITERAL",24;"MATCH",96;"RRPAREN",-55;"[",90;"[|",7;"]",-55;"appExpr",170;"arrayExpr",25;"atomicExpr",141;"binaryExpr",149;"declExpr",148;"identExpr",26;"lambdaExpr",173;"letBinding",36;"listExpr",27;"matchExpr",37;"parenExpr",28;"prefix",171;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revBinaryExpr",34;"revQualificationExpr",122;"revTupleExpr",150;"tupleExpr",174;"unaryExpr",135;"valueExpr",38;"{",128;"|]",-55];["(",109;"IDENT",30;"atomicPattern",163;"bindingPattern",110;"parameterPattern",33;"tuplePattern",35];[")",111];[")",-56;",",-56;"->",-56;"=",-56];["->",-57];[")",-54;";",108;"opt_semicolon",114];[")",115];["(",-58;")",-58;"*",-58;"+",-58;",",-58;"-",-58;"->",-58;".",-58;";",-58;"=",-58;"ALWAYS_INFIX",-58;"IDENT",-58;"LITERAL",-58;"RHSEND",-58;"RRPAREN",-58;"WITH",-58;"[",-58;"[|",-58;"]",-58;"{",-58;"|]",-58];["->",-59;"WHEN",117];["(",20;"+",119;"-",120;"ALWAYS_PREFIX",121;"IDENT",61;"LITERAL",24;"[",90;"[|",7;"appExpr",170;"arrayExpr",25;"atomicExpr",141;"binaryExpr",118;"identExpr",26;"listExpr",27;"parenExpr",28;"prefix",171;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revBinaryExpr",34;"revQualificationExpr",122;"unaryExpr",135;"{",128];["->",-60];["(",-61;"IDENT",-61;"LITERAL",-61;"[",-61;"[|",-61;"{",-61];["(",-62;"IDENT",-62;"LITERAL",-62;"[",-62;"[|",-62;"{",-62];["(",-63;"IDENT",-63;"LITERAL",-63;"[",-63;"[|",-63;"{",-63];["(",-64;")",-64;"*",-64;"+",-64;",",-64;"-",-64;"->",-64;".",123;";",-64;"=",-64;"ALWAYS_INFIX",-64;"IDENT",-64;"LITERAL",-64;"RHSEND",-64;"RRPAREN",-64;"WITH",-64;"[",-64;"[|",-64;"]",-64;"qualificationSuffix",142;"{",-64;"|]",-64];["IDENT",61;"[",124;"identExpr",127];["(",20;"+",119;"-",120;"ALWAYS_PREFIX",121;"IDENT",61;"LITERAL",24;"[",90;"[|",7;"appExpr",170;"arrayExpr",25;"atomicExpr",141;"binaryExpr",149;"identExpr",26;"listExpr",27;"parenExpr",28;"prefix",171;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revBinaryExpr",34;"revQualificationExpr",122;"revTupleExpr",150;"tupleExpr",125;"unaryExpr",135;"{",128];["]",126];["(",-65;")",-65;"*",-65;"+",-65;",",-65;"-",-65;"->",-65;".",-65;";",-65;"=",-65;"ALWAYS_INFIX",-65;"IDENT",-65;"LITERAL",-65;"RHSEND",-65;"RRPAREN",-65;"WITH",-65;"[",-65;"[|",-65;"]",-65;"{",-65;"|]",-65];["(",-66;")",-66;"*",-66;"+",-66;",",-66;"-",-66;"->",-66;".",-66;";",-66;"=",-66;"ALWAYS_INFIX",-66;"IDENT",-66;"LITERAL",-66;"RHSEND",-66;"RRPAREN",-66;"WITH",-66;"[",-66;"[|",-66;"]",-66;"{",-66;"|]",-66];["IDENT",39;"fieldBinding",47;"fieldBindings",48];["}",130];["(",-67;")",-67;"*",-67;"+",-67;",",-67;"-",-67;"->",-67;".",-67;";",-67;"=",-67;"ALWAYS_INFIX",-67;"IDENT",-67;"LITERAL",-67;"RHSEND",-67;"RRPAREN",-67;"WITH",-67;"[",-67;"[|",-67;"]",-67;"{",-67;"|]",-67];["(",-68;")",-68;"*",-68;"+",-68;",",-68;"-",-68;"->",-68;";",-68;"=",-68;"ALWAYS_INFIX",-68;"IDENT",-68;"LITERAL",-68;"RHSEND",-68;"RRPAREN",-68;"WITH",-68;"[",-68;"[|",-68;"]",-68;"{",-68;"|]",-68];["(",-69;")",-69;"*",-69;"+",-69;",",-69;"-",-69;"->",-69;";",-69;"=",-69;"ALWAYS_INFIX",-69;"IDENT",-69;"LITERAL",-69;"RHSEND",-69;"RRPAREN",-69;"WITH",-69;"[",-69;"[|",-69;"]",-69;"{",-69;"|]",-69];["(",20;"+",119;"-",120;"ALWAYS_PREFIX",121;"IDENT",61;"LITERAL",24;"[",90;"[|",7;"appExpr",170;"arrayExpr",25;"atomicExpr",141;"identExpr",26;"listExpr",27;"parenExpr",28;"prefix",171;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revQualificationExpr",122;"unaryExpr",134;"{",128];[")",-70;"*",-70;"+",-70;",",-70;"-",-70;"->",-70;";",-70;"=",-70;"ALWAYS_INFIX",-70;"RHSEND",-70;"RRPAREN",-70;"WITH",-70;"]",-70;"|]",-70];[")",-71;"*",-71;"+",-71;",",-71;"-",-71;"->",-71;";",-71;"=",-71;"ALWAYS_INFIX",-71;"RHSEND",-71;"RRPAREN",-71;"WITH",-71;"]",-71;"|]",-71];[")",-72;"*",-72;",",-72;"->",-72;".",-72;";",-72;"<",-72;"=",-72;">",-72;"EOF",-72;"IDENT",-72;"LET",-72;"OPEN",-72;"[",-72];["IDENT",138];[")",-73;"*",-73;",",-73;"->",-73;".",-73;";",-73;"<",-73;"=",-73;">",-73;"EOF",-73;"IDENT",-73;"LET",-73;"OPEN",-73;"[",-73];[";",-74;"EOF",-74];[";",-75;"EOF",-75];["(",-76;")",-76;"*",-76;"+",-76;",",-76;"-",-76;"->",-76;".",-76;";",-76;"=",-76;"ALWAYS_INFIX",-76;"IDENT",-76;"LITERAL",-76;"RHSEND",-76;"RRPAREN",-76;"WITH",-76;"[",-76;"[|",-76;"]",-76;"{",-76;"|]",-76];["(",-77;")",-77;"*",-77;"+",-77;",",-77;"-",-77;"->",-77;".",-77;";",-77;"=",-77;"ALWAYS_INFIX",-77;"IDENT",-77;"LITERAL",-77;"RHSEND",-77;"RRPAREN",-77;"WITH",-77;"[",-77;"[|",-77;"]",-77;"{",-77;"|]",-77];["IDENT",101;"LITERAL",102;"matchPattern",116;"patternAndGuard",153;"ruleClause",144];[")",-78;";",-78;"RRPAREN",-78;"]",-78;"|",-78;"|]",-78];[")",-79;";",-79;"RRPAREN",-79;"]",-79;"|",-79;"|]",-79];[")",-80;";",-80;"RRPAREN",-80;"]",-80;"|]",-80];[";",108;"RRPAREN",-54;"opt_semicolon",156];[")",-81;";",-81;"RRPAREN",-81;"]",-81;"|]",-81];[")",-82;",",-82;";",-82;"RHSEND",-82;"RRPAREN",-82;"WITH",-82;"]",-82;"|]",-82];[")",-88;",",151;";",-88;"RHSEND",-88;"RRPAREN",-88;"WITH",-88;"]",-88;"|]",-88];["(",20;"+",119;"-",120;"ALWAYS_PREFIX",121;"IDENT",61;"LITERAL",24;"[",90;"[|",7;"appExpr",170;"arrayExpr",25;"atomicExpr",141;"binaryExpr",152;"identExpr",26;"listExpr",27;"parenExpr",28;"prefix",171;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revBinaryExpr",34;"revQualificationExpr",122;"unaryExpr",135;"{",128];[")",-83;",",-83;";",-83;"RHSEND",-83;"RRPAREN",-83;"WITH",-83;"]",-83;"|]",-83];["->",154];["(",20;"+",119;"-",120;"ALWAYS_PREFIX",121;"FUN",72;"IDENT",61;"LITERAL",24;"LLPAREN",155;"[",90;"[|",7;"appExpr",170;"arrayExpr",25;"atomicExpr",141;"binaryExpr",149;"identExpr",26;"lambdaExpr",173;"listExpr",27;"parenExpr",28;"prefix",171;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revBinaryExpr",34;"revQualificationExpr",122;"revTupleExpr",150;"tupleExpr",174;"unaryExpr",135;"valueExpr",158;"{",128];["(",20;"+",119;"-",120;"ALWAYS_PREFIX",121;"FUN",72;"IDENT",61;"LET",81;"LITERAL",24;"MATCH",96;"[",90;"[|",7;"appExpr",170;"arrayExpr",25;"atomicExpr",141;"binaryExpr",149;"declExpr",146;"identExpr",26;"lambdaExpr",173;"letBinding",36;"listExpr",27;"matchExpr",37;"parenExpr",28;"prefix",171;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revBinaryExpr",34;"revQualificationExpr",122;"revSequentialExpr",147;"revTupleExpr",150;"tupleExpr",174;"unaryExpr",135;"valueExpr",38;"{",128];["RRPAREN",157];[")",-84;";",-84;"RRPAREN",-84;"]",-84;"|",-84;"|]",-84];["RHSEND",159];[")",-85;";",-85;"RRPAREN",-85;"]",-85;"|",-85;"|]",-85];["]",161];[")",-86;"*",-86;",",-86;"->",-86;"=",-86;">",-86;"IDENT",-86;"[",-86];[")",-87;"*",-87;",",-87;"->",-87;"=",-87;">",-87;"IDENT",-87;"[",-87];[")",-89;",",-89;"=",-89];["(",109;"IDENT",30;"atomicPattern",165;"parameterPattern",33];[")",-90;",",-90;"=",-90];["(",12;"IDENT",136;"TYPAR",15;"appType",4;"atomType",6;"longid",16;"revLongid",95];[",",-94;">",-94];["(",12;"IDENT",136;"TYPAR",15;"appType",3;"atomType",6;"funType",57;"longid",16;"revLongid",95;"tupleType",60;"typeArgument",169];[",",-95;">",-95];[")",-96;"*",-96;"+",-96;",",-96;"-",-96;"->",-96;";",-96;"=",-96;"ALWAYS_INFIX",-96;"RHSEND",-96;"RRPAREN",-96;"WITH",-96;"]",-96;"|]",-96];["(",20;"IDENT",61;"LITERAL",24;"[",90;"[|",7;"appExpr",172;"arrayExpr",25;"atomicExpr",141;"identExpr",26;"listExpr",27;"parenExpr",28;"qualificationExpr",131;"recdLiteralExpr",29;"revAppExpr",2;"revQualificationExpr",122;"{",128];[")",-97;"*",-97;"+",-97;",",-97;"-",-97;"->",-97;";",-97;"=",-97;"ALWAYS_INFIX",-97;"RHSEND",-97;"RRPAREN",-97;"WITH",-97;"]",-97;"|]",-97];[")",-98;";",-98;"RHSEND",-98;"RRPAREN",-98;"]",-98;"|]",-98];[")",-99;";",-99;"RHSEND",-99;"RRPAREN",-99;"]",-99;"|]",-99]]
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
    ["atomicExpr";"recdLiteralExpr"], (fun(ss:obj list)->
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
    ["declExpr";"matchExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
    ["declExpr";"valueExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
    ["fieldBinding";"IDENT";"=";"LLPAREN";"revSequentialExpr";"opt_semicolon";"RRPAREN"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<(option<int>*Expr) list> ss.[3]
        let s4 = unbox<option<int>> ss.[4]
        let s5 = unbox<option<int>> ss.[5]
        let result:option<int>*RecordFiledBinding =
            fst s0, RecordFiledBinding(snd s0, snd(Expr.ofSequentialExpr s3))
        box result)
    ["fieldBinding";"IDENT";"=";"valueExpr";"RHSEND"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*RecordFiledBinding =
            fst s0, RecordFiledBinding(snd s0, [snd s2])
        box result)
    ["fieldBindings";"fieldBinding"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*RecordFiledBinding> ss.[0]
        let result:(option<int>*RecordFiledBinding) list =
            [s0]
        box result)
    ["fieldBindings";"fieldBindings";";";"fieldBinding"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*RecordFiledBinding) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*RecordFiledBinding> ss.[2]
        let result:(option<int>*RecordFiledBinding) list =
            s2::s0
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
    ["infix";"*"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "*"
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
    ["lambdaExpr";"FUN";"parameterPattern";"->";"LLPAREN";"revSequentialExpr";"opt_semicolon";"RRPAREN"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Pattern> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let s4 = unbox<(option<int>*Expr) list> ss.[4]
        let s5 = unbox<option<int>> ss.[5]
        let s6 = unbox<option<int>> ss.[6]
        let result:option<int>*Expr =
            s0, LambdaExpr(snd s1, snd(Expr.ofSequentialExpr s4))
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
    ["letBinding";"LET";"bindingPattern";"=";"LLPAREN";"revSequentialExpr";"opt_semicolon";"RRPAREN"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Pattern> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let s4 = unbox<(option<int>*Expr) list> ss.[4]
        let s5 = unbox<option<int>> ss.[5]
        let s6 = unbox<option<int>> ss.[6]
        let result:option<int>*Expr =
            s0, LetBindingExpr(snd s1, snd(Expr.ofSequentialExpr s4))
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
    ["matchExpr";"MATCH";"tupleExpr";"WITH";"opt_bar";"revRuleClauses"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Expr> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let s4 = unbox<(option<int>*RuleClause) list> ss.[4]
        let result:option<int>*Expr =
            let ruleClauses = s4 |> List.map snd |> List.rev
            s0, MatchExpr(snd s1, ruleClauses)
        box result)
    ["matchPattern";"IDENT"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let result:option<int>*Pattern =
            fst s0, IdentPattern(snd s0)
        box result)
    ["matchPattern";"LITERAL"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Literal> ss.[0]
        let result:option<int>*Pattern =
            fst s0, LiteralPattern(snd s0)
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
    ["opt_bar"], (fun(ss:obj list)->
        let result:option<int> =
            None
        box result)
    ["opt_bar";"|"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int> =
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
    ["patternAndGuard";"matchPattern"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Pattern> ss.[0]
        let result:option<int>*Pattern*Expr option =
            fst s0,snd s0, None
        box result)
    ["patternAndGuard";"matchPattern";"WHEN";"binaryExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Pattern> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let result:option<int>*Pattern*Expr option =
            fst s0,snd s0, Some(snd s2)
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
    ["recdLiteralExpr";"{";"fieldBindings";"opt_semicolon";"}"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(option<int>*RecordFiledBinding) list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*Expr =
            let ls = s1 |> List.map snd |> List.rev
            s0, RecordLiteralExpr ls
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
    ["revRuleClauses";"revRuleClauses";"|";"ruleClause"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*RuleClause) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*RuleClause> ss.[2]
        let result:(option<int>*RuleClause) list =
            s2::s0
        box result)
    ["revRuleClauses";"ruleClause"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*RuleClause> ss.[0]
        let result:(option<int>*RuleClause) list =
            [s0]
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
    ["ruleClause";"patternAndGuard";"->";"LLPAREN";"revSequentialExpr";"opt_semicolon";"RRPAREN"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Pattern*Expr option> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<(option<int>*Expr) list> ss.[3]
        let s4 = unbox<option<int>> ss.[4]
        let s5 = unbox<option<int>> ss.[5]
        let result:option<int>*RuleClause =
            let i,p,g = s0
            let r = s3 |> List.map snd |> List.rev
            i, RuleClause(p, g, r)
        box result)
    ["ruleClause";"patternAndGuard";"->";"valueExpr";"RHSEND"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Pattern*Expr option> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*RuleClause =
            let i,p,g = s0
            i, RuleClause(p, g, [snd s2])
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
        let s1 = unbox<option<int>> ss.[1]
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