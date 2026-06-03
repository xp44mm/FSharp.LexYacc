module FSharp.Substance.FSharpYacc
open FSharp.LexYacc
open FSharp.Idioms
let stateSymbols: string[] = [|"";"file";"revAppExpr";"appType";"appType";"suffixType";"atomType";"[|";"revSequentialExpr";"|]";"|]";"(";"typeArgument";")";"TYPAR";"longid";"<";"typeArguments";">";"(";"infix";")";"LITERAL";"arrayExpr";"identExpr";"listExpr";"parenExpr";"recdLiteralExpr";"IDENT";":";"typeArgument";"parameterPattern";"revBinaryExpr";"tuplePattern";"letBinding";"valueExpr";"IDENT";"=";"valueRhs";"fieldBinding";"fieldBindings";";";"fieldBinding";"MODULE";"longid";"EOF";"revOpenOrLets";"EOF";"funType";"->";"tupleType";"tupleType";"IDENT";"<";"typeArguments";">";"*";"+";"+";"-";"-";"=";"ALWAYS_INFIX";"FUN";"parameterPattern";"->";"tupleRhs";"LET";"bindingPattern";"=";"valueRhs";"[";"]";"revSequentialExpr";"]";"revLongid";"MATCH";"tupleExpr";"WITH";"opt_bar";"revRuleClauses";"RHSEND";"IDENT";"LITERAL";"OPEN";"longid";"letBinding";"|";"(";"bindingPattern";")";"IDENT";"revSequentialExpr";")";"matchPattern";"WHEN";"binaryExpr";"+";"-";"ALWAYS_PREFIX";"revQualificationExpr";".";"[";"tupleExpr";"]";"identExpr";"{";"}";"qualificationExpr";"qualificationExpr";"infix";"unaryExpr";"unaryExpr";"IDENT";".";"IDENT";"openOrLet";";";"openOrLet";"atomicExpr";"qualificationSuffix";"|";"ruleClause";"ruleClause";"declExpr";"revSequentialExpr";"revSequentialExpr";";";"declExpr";"binaryExpr";"revTupleExpr";",";"binaryExpr";"patternAndGuard";"->";"tupleRhs";"[";"]";"longid";"atomicPattern";",";"atomicPattern";"LLPAREN";"RRPAREN";"tupleExpr";"*";"typeArgument";",";"typeArgument";"appExpr";"prefix";"appExpr";"lambdaExpr";"matchExpr";"tupleExpr";"LLPAREN";"RRPAREN";"valueExpr"|]
let actions: (string * int) list list = [["MODULE",43;"file",1];["",0];["(",19;")",-1;"*",-1;"+",-1;",",-1;"-",-1;"->",-1;";",-1;"=",-1;"ALWAYS_INFIX",-1;"EOF",-1;"IDENT",52;"LITERAL",22;"RHSEND",-1;"RRPAREN",-1;"WITH",-1;"[",71;"[|",7;"]",-1;"arrayExpr",23;"atomicExpr",119;"identExpr",24;"listExpr",25;"parenExpr",26;"qualificationExpr",109;"recdLiteralExpr",27;"revQualificationExpr",100;"{",106;"|",-1;"|]",-1;"}",-1];[")",-85;"*",-85;",",-85;"->",-85;"=",-85;">",-85;"IDENT",113;"[",136;"longid",138;"revLongid",75;"suffixType",5];[")",-86;"*",-86;",",-86;"->",-86;"=",-86;">",-86;"IDENT",113;"[",136;"longid",138;"revLongid",75;"suffixType",5];[")",-2;"*",-2;",",-2;"->",-2;"=",-2;">",-2;"IDENT",-2;"[",-2];[")",-3;"*",-3;",",-3;"->",-3;"=",-3;">",-3;"IDENT",-3;"[",-3];["(",19;"+",97;"-",98;"ALWAYS_PREFIX",99;"FUN",63;"IDENT",52;"LET",67;"LITERAL",22;"MATCH",76;"[",71;"[|",7;"appExpr",149;"arrayExpr",23;"atomicExpr",119;"binaryExpr",129;"declExpr",124;"identExpr",24;"lambdaExpr",152;"letBinding",34;"listExpr",25;"matchExpr",153;"parenExpr",26;"prefix",150;"qualificationExpr",108;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",100;"revSequentialExpr",8;"revTupleExpr",130;"tupleExpr",154;"unaryExpr",112;"valueExpr",35;"{",106;"|]",10];[";",127;"|]",9];["(",-4;")",-4;"*",-4;"+",-4;",",-4;"-",-4;"->",-4;".",-4;";",-4;"=",-4;"ALWAYS_INFIX",-4;"EOF",-4;"IDENT",-4;"LITERAL",-4;"RHSEND",-4;"RRPAREN",-4;"WITH",-4;"[",-4;"[|",-4;"]",-4;"{",-4;"|",-4;"|]",-4;"}",-4];["(",-5;")",-5;"*",-5;"+",-5;",",-5;"-",-5;"->",-5;".",-5;";",-5;"=",-5;"ALWAYS_INFIX",-5;"EOF",-5;"IDENT",-5;"LITERAL",-5;"RHSEND",-5;"RRPAREN",-5;"WITH",-5;"[",-5;"[|",-5;"]",-5;"{",-5;"|",-5;"|]",-5;"}",-5];["(",11;"IDENT",113;"TYPAR",14;"appType",3;"atomType",6;"funType",48;"longid",15;"revLongid",75;"tupleType",51;"typeArgument",12];[")",13];[")",-6;"*",-6;",",-6;"->",-6;"=",-6;">",-6;"IDENT",-6;"[",-6];[")",-7;"*",-7;",",-7;"->",-7;"=",-7;">",-7;"IDENT",-7;"[",-7];[")",-8;"*",-8;",",-8;"->",-8;"<",16;"=",-8;">",-8;"IDENT",-8;"[",-8];["(",11;"IDENT",113;"TYPAR",14;"appType",3;"atomType",6;"funType",48;"longid",15;"revLongid",75;"tupleType",51;"typeArgument",146;"typeArguments",17];[",",147;">",18];[")",-9;"*",-9;",",-9;"->",-9;"=",-9;">",-9;"IDENT",-9;"[",-9];["(",19;"*",56;"+",58;"-",60;"=",61;"ALWAYS_INFIX",62;"ALWAYS_PREFIX",99;"FUN",63;"IDENT",52;"LET",67;"LITERAL",22;"MATCH",76;"[",71;"[|",7;"appExpr",149;"arrayExpr",23;"atomicExpr",119;"binaryExpr",129;"declExpr",124;"identExpr",24;"infix",20;"lambdaExpr",152;"letBinding",34;"listExpr",25;"matchExpr",153;"parenExpr",26;"prefix",150;"qualificationExpr",108;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",100;"revSequentialExpr",92;"revTupleExpr",130;"tupleExpr",154;"unaryExpr",112;"valueExpr",35;"{",106];[")",21];["(",-10;")",-10;"*",-10;"+",-10;",",-10;"-",-10;"->",-10;".",-10;";",-10;"=",-10;"ALWAYS_INFIX",-10;"EOF",-10;"IDENT",-10;"LITERAL",-10;"RHSEND",-10;"RRPAREN",-10;"WITH",-10;"[",-10;"[|",-10;"]",-10;"{",-10;"|",-10;"|]",-10;"}",-10];["(",-11;")",-11;"*",-11;"+",-11;",",-11;"-",-11;"->",-11;".",-11;";",-11;"=",-11;"ALWAYS_INFIX",-11;"EOF",-11;"IDENT",-11;"LITERAL",-11;"RHSEND",-11;"RRPAREN",-11;"WITH",-11;"[",-11;"[|",-11;"]",-11;"{",-11;"|",-11;"|]",-11;"}",-11];["(",-12;")",-12;"*",-12;"+",-12;",",-12;"-",-12;"->",-12;".",-12;";",-12;"=",-12;"ALWAYS_INFIX",-12;"EOF",-12;"IDENT",-12;"LITERAL",-12;"RHSEND",-12;"RRPAREN",-12;"WITH",-12;"[",-12;"[|",-12;"]",-12;"{",-12;"|",-12;"|]",-12;"}",-12];["(",-13;")",-13;"*",-13;"+",-13;",",-13;"-",-13;"->",-13;".",-13;";",-13;"=",-13;"ALWAYS_INFIX",-13;"EOF",-13;"IDENT",-13;"LITERAL",-13;"RHSEND",-13;"RRPAREN",-13;"WITH",-13;"[",-13;"[|",-13;"]",-13;"{",-13;"|",-13;"|]",-13;"}",-13];["(",-14;")",-14;"*",-14;"+",-14;",",-14;"-",-14;"->",-14;".",-14;";",-14;"=",-14;"ALWAYS_INFIX",-14;"EOF",-14;"IDENT",-14;"LITERAL",-14;"RHSEND",-14;"RRPAREN",-14;"WITH",-14;"[",-14;"[|",-14;"]",-14;"{",-14;"|",-14;"|]",-14;"}",-14];["(",-15;")",-15;"*",-15;"+",-15;",",-15;"-",-15;"->",-15;".",-15;";",-15;"=",-15;"ALWAYS_INFIX",-15;"EOF",-15;"IDENT",-15;"LITERAL",-15;"RHSEND",-15;"RRPAREN",-15;"WITH",-15;"[",-15;"[|",-15;"]",-15;"{",-15;"|",-15;"|]",-15;"}",-15];["(",-16;")",-16;"*",-16;"+",-16;",",-16;"-",-16;"->",-16;".",-16;";",-16;"=",-16;"ALWAYS_INFIX",-16;"EOF",-16;"IDENT",-16;"LITERAL",-16;"RHSEND",-16;"RRPAREN",-16;"WITH",-16;"[",-16;"[|",-16;"]",-16;"{",-16;"|",-16;"|]",-16;"}",-16];[")",-50;",",-50;":",29;"=",-50];["(",11;"IDENT",113;"TYPAR",14;"appType",3;"atomType",6;"funType",48;"longid",15;"revLongid",75;"tupleType",51;"typeArgument",30];[")",-17;",",-17;"=",-17];[")",-18;",",-18;"=",-18];[")",-19;"*",56;"+",57;",",-19;"-",59;"->",-19;";",-19;"=",61;"ALWAYS_INFIX",62;"EOF",-19;"RHSEND",-19;"RRPAREN",-19;"WITH",-19;"]",-19;"infix",110;"|",-19;"|]",-19;"}",-19];[")",-20;",",140;"=",-20];[")",-21;";",-21;"RRPAREN",-21;"]",-21;"|]",-21];[")",-22;";",-22;"RRPAREN",-22;"]",-22;"|]",-22];["=",37];["(",19;"+",97;"-",98;"ALWAYS_PREFIX",99;"FUN",63;"IDENT",52;"LITERAL",22;"LLPAREN",155;"MATCH",76;"[",71;"[|",7;"appExpr",149;"arrayExpr",23;"atomicExpr",119;"binaryExpr",129;"identExpr",24;"lambdaExpr",152;"listExpr",25;"matchExpr",153;"parenExpr",26;"prefix",150;"qualificationExpr",108;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",100;"revTupleExpr",130;"tupleExpr",154;"unaryExpr",112;"valueExpr",157;"valueRhs",38;"{",106];[";",-23;"}",-23];[";",-24;"}",-24];[";",41;"}",107];["IDENT",36;"fieldBinding",42];[";",-25;"}",-25];["IDENT",113;"longid",44;"revLongid",75];["EOF",45;"LET",67;"OPEN",84;"letBinding",86;"openOrLet",116;"revOpenOrLets",46];["",-26];[";",117;"EOF",47];["",-27];[")",-87;",",-87;"->",49;"=",-87;">",-87];["(",11;"IDENT",113;"TYPAR",14;"appType",3;"atomType",6;"longid",15;"revLongid",75;"tupleType",50];[")",-28;"*",145;",",-28;"->",-28;"=",-28;">",-28];[")",-29;"*",145;",",-29;"->",-29;"=",-29;">",-29];["(",-30;")",-30;"*",-30;"+",-30;",",-30;"-",-30;"->",-30;".",-30;";",-30;"<",53;"=",-30;"ALWAYS_INFIX",-30;"EOF",-30;"IDENT",-30;"LITERAL",-30;"RHSEND",-30;"RRPAREN",-30;"WITH",-30;"[",-30;"[|",-30;"]",-30;"{",-30;"|",-30;"|]",-30;"}",-30];["(",11;"IDENT",113;"TYPAR",14;"appType",3;"atomType",6;"funType",48;"longid",15;"revLongid",75;"tupleType",51;"typeArgument",146;"typeArguments",54];[",",147;">",55];["(",-31;")",-31;"*",-31;"+",-31;",",-31;"-",-31;"->",-31;".",-31;";",-31;"=",-31;"ALWAYS_INFIX",-31;"EOF",-31;"IDENT",-31;"LITERAL",-31;"RHSEND",-31;"RRPAREN",-31;"WITH",-31;"[",-31;"[|",-31;"]",-31;"{",-31;"|",-31;"|]",-31;"}",-31];["(",-32;")",-32;"+",-32;"-",-32;"ALWAYS_PREFIX",-32;"IDENT",-32;"LITERAL",-32;"[",-32;"[|",-32;"{",-32];["(",-33;"+",-33;"-",-33;"ALWAYS_PREFIX",-33;"IDENT",-33;"LITERAL",-33;"[",-33;"[|",-33;"{",-33];["(",-54;")",-33;"IDENT",-54;"LITERAL",-54;"[",-54;"[|",-54;"{",-54];["(",-34;"+",-34;"-",-34;"ALWAYS_PREFIX",-34;"IDENT",-34;"LITERAL",-34;"[",-34;"[|",-34;"{",-34];["(",-55;")",-34;"IDENT",-55;"LITERAL",-55;"[",-55;"[|",-55;"{",-55];["(",-35;")",-35;"+",-35;"-",-35;"ALWAYS_PREFIX",-35;"IDENT",-35;"LITERAL",-35;"[",-35;"[|",-35;"{",-35];["(",-36;")",-36;"+",-36;"-",-36;"ALWAYS_PREFIX",-36;"IDENT",-36;"LITERAL",-36;"[",-36;"[|",-36;"{",-36];["(",88;"IDENT",91;"parameterPattern",64];["->",65];["(",19;"+",97;"-",98;"ALWAYS_PREFIX",99;"IDENT",52;"LITERAL",22;"LLPAREN",142;"[",71;"[|",7;"appExpr",149;"arrayExpr",23;"atomicExpr",119;"binaryExpr",129;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",150;"qualificationExpr",108;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",100;"revTupleExpr",130;"tupleExpr",144;"tupleRhs",66;"unaryExpr",112;"{",106];[")",-37;";",-37;"EOF",-37;"RRPAREN",-37;"]",-37;"|]",-37;"}",-37];["(",88;"IDENT",28;"atomicPattern",139;"bindingPattern",68;"parameterPattern",31;"tuplePattern",33];["=",69];["(",19;"+",97;"-",98;"ALWAYS_PREFIX",99;"FUN",63;"IDENT",52;"LITERAL",22;"LLPAREN",155;"MATCH",76;"[",71;"[|",7;"appExpr",149;"arrayExpr",23;"atomicExpr",119;"binaryExpr",129;"identExpr",24;"lambdaExpr",152;"listExpr",25;"matchExpr",153;"parenExpr",26;"prefix",150;"qualificationExpr",108;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",100;"revTupleExpr",130;"tupleExpr",154;"unaryExpr",112;"valueExpr",157;"valueRhs",70;"{",106];[")",-38;";",-38;"EOF",-38;"RRPAREN",-38;"]",-38;"|]",-38];["(",19;"+",97;"-",98;"ALWAYS_PREFIX",99;"FUN",63;"IDENT",52;"LET",67;"LITERAL",22;"MATCH",76;"[",71;"[|",7;"]",72;"appExpr",149;"arrayExpr",23;"atomicExpr",119;"binaryExpr",129;"declExpr",124;"identExpr",24;"lambdaExpr",152;"letBinding",34;"listExpr",25;"matchExpr",153;"parenExpr",26;"prefix",150;"qualificationExpr",108;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",100;"revSequentialExpr",73;"revTupleExpr",130;"tupleExpr",154;"unaryExpr",112;"valueExpr",35;"{",106];["(",-39;")",-39;"*",-39;"+",-39;",",-39;"-",-39;"->",-39;".",-39;";",-39;"=",-39;"ALWAYS_INFIX",-39;"EOF",-39;"IDENT",-39;"LITERAL",-39;"RHSEND",-39;"RRPAREN",-39;"WITH",-39;"[",-39;"[|",-39;"]",-39;"{",-39;"|",-39;"|]",-39;"}",-39];[";",127;"]",74];["(",-40;")",-40;"*",-40;"+",-40;",",-40;"-",-40;"->",-40;".",-40;";",-40;"=",-40;"ALWAYS_INFIX",-40;"EOF",-40;"IDENT",-40;"LITERAL",-40;"RHSEND",-40;"RRPAREN",-40;"WITH",-40;"[",-40;"[|",-40;"]",-40;"{",-40;"|",-40;"|]",-40;"}",-40];[")",-41;"*",-41;",",-41;"->",-41;".",114;";",-41;"<",-41;"=",-41;">",-41;"EOF",-41;"IDENT",-41;"LET",-41;"OPEN",-41;"[",-41];["(",19;"+",97;"-",98;"ALWAYS_PREFIX",99;"IDENT",52;"LITERAL",22;"[",71;"[|",7;"appExpr",149;"arrayExpr",23;"atomicExpr",119;"binaryExpr",129;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",150;"qualificationExpr",108;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",100;"revTupleExpr",130;"tupleExpr",77;"unaryExpr",112;"{",106];["WITH",78];["IDENT",-47;"LITERAL",-47;"opt_bar",79;"|",87];["IDENT",82;"LITERAL",83;"matchPattern",94;"patternAndGuard",133;"revRuleClauses",80;"ruleClause",123];["RHSEND",81;"|",121];[")",-42;";",-42;"EOF",-42;"RRPAREN",-42;"]",-42;"|]",-42;"}",-42];["->",-43;"WHEN",-43];["->",-44;"WHEN",-44];["IDENT",113;"longid",85;"revLongid",75];[";",-45;"EOF",-45];[";",-46;"EOF",-46];["IDENT",-48;"LITERAL",-48];["(",88;"IDENT",28;"atomicPattern",139;"bindingPattern",89;"parameterPattern",31;"tuplePattern",33];[")",90];[")",-49;",",-49;"->",-49;"=",-49];["->",-50];[")",93;";",127];["(",-51;")",-51;"*",-51;"+",-51;",",-51;"-",-51;"->",-51;".",-51;";",-51;"=",-51;"ALWAYS_INFIX",-51;"EOF",-51;"IDENT",-51;"LITERAL",-51;"RHSEND",-51;"RRPAREN",-51;"WITH",-51;"[",-51;"[|",-51;"]",-51;"{",-51;"|",-51;"|]",-51;"}",-51];["->",-52;"WHEN",95];["(",19;"+",97;"-",98;"ALWAYS_PREFIX",99;"IDENT",52;"LITERAL",22;"[",71;"[|",7;"appExpr",149;"arrayExpr",23;"atomicExpr",119;"binaryExpr",96;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",150;"qualificationExpr",108;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",100;"unaryExpr",112;"{",106];["->",-53];["(",-54;"IDENT",-54;"LITERAL",-54;"[",-54;"[|",-54;"{",-54];["(",-55;"IDENT",-55;"LITERAL",-55;"[",-55;"[|",-55;"{",-55];["(",-56;"IDENT",-56;"LITERAL",-56;"[",-56;"[|",-56;"{",-56];["(",-57;")",-57;"*",-57;"+",-57;",",-57;"-",-57;"->",-57;".",101;";",-57;"=",-57;"ALWAYS_INFIX",-57;"EOF",-57;"IDENT",-57;"LITERAL",-57;"RHSEND",-57;"RRPAREN",-57;"WITH",-57;"[",-57;"[|",-57;"]",-57;"qualificationSuffix",120;"{",-57;"|",-57;"|]",-57;"}",-57];["IDENT",52;"[",102;"identExpr",105];["(",19;"+",97;"-",98;"ALWAYS_PREFIX",99;"IDENT",52;"LITERAL",22;"[",71;"[|",7;"appExpr",149;"arrayExpr",23;"atomicExpr",119;"binaryExpr",129;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",150;"qualificationExpr",108;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",100;"revTupleExpr",130;"tupleExpr",103;"unaryExpr",112;"{",106];["]",104];["(",-58;")",-58;"*",-58;"+",-58;",",-58;"-",-58;"->",-58;".",-58;";",-58;"=",-58;"ALWAYS_INFIX",-58;"EOF",-58;"IDENT",-58;"LITERAL",-58;"RHSEND",-58;"RRPAREN",-58;"WITH",-58;"[",-58;"[|",-58;"]",-58;"{",-58;"|",-58;"|]",-58;"}",-58];["(",-59;")",-59;"*",-59;"+",-59;",",-59;"-",-59;"->",-59;".",-59;";",-59;"=",-59;"ALWAYS_INFIX",-59;"EOF",-59;"IDENT",-59;"LITERAL",-59;"RHSEND",-59;"RRPAREN",-59;"WITH",-59;"[",-59;"[|",-59;"]",-59;"{",-59;"|",-59;"|]",-59;"}",-59];["IDENT",36;"fieldBinding",39;"fieldBindings",40];["(",-60;")",-60;"*",-60;"+",-60;",",-60;"-",-60;"->",-60;".",-60;";",-60;"=",-60;"ALWAYS_INFIX",-60;"EOF",-60;"IDENT",-60;"LITERAL",-60;"RHSEND",-60;"RRPAREN",-60;"WITH",-60;"[",-60;"[|",-60;"]",-60;"{",-60;"|",-60;"|]",-60;"}",-60];["(",-61;")",-61;"*",-61;"+",-61;",",-61;"-",-61;"->",-61;";",-61;"=",-61;"ALWAYS_INFIX",-61;"EOF",-61;"IDENT",-61;"LITERAL",-61;"RHSEND",-61;"RRPAREN",-61;"WITH",-61;"[",-61;"[|",-61;"]",-61;"{",-61;"|",-61;"|]",-61;"}",-61];["(",-62;")",-62;"*",-62;"+",-62;",",-62;"-",-62;"->",-62;";",-62;"=",-62;"ALWAYS_INFIX",-62;"EOF",-62;"IDENT",-62;"LITERAL",-62;"RHSEND",-62;"RRPAREN",-62;"WITH",-62;"[",-62;"[|",-62;"]",-62;"{",-62;"|",-62;"|]",-62;"}",-62];["(",19;"+",97;"-",98;"ALWAYS_PREFIX",99;"IDENT",52;"LITERAL",22;"[",71;"[|",7;"appExpr",149;"arrayExpr",23;"atomicExpr",119;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",150;"qualificationExpr",108;"recdLiteralExpr",27;"revAppExpr",2;"revQualificationExpr",100;"unaryExpr",111;"{",106];[")",-63;"*",-63;"+",-63;",",-63;"-",-63;"->",-63;";",-63;"=",-63;"ALWAYS_INFIX",-63;"EOF",-63;"RHSEND",-63;"RRPAREN",-63;"WITH",-63;"]",-63;"|",-63;"|]",-63;"}",-63];[")",-64;"*",-64;"+",-64;",",-64;"-",-64;"->",-64;";",-64;"=",-64;"ALWAYS_INFIX",-64;"EOF",-64;"RHSEND",-64;"RRPAREN",-64;"WITH",-64;"]",-64;"|",-64;"|]",-64;"}",-64];[")",-65;"*",-65;",",-65;"->",-65;".",-65;";",-65;"<",-65;"=",-65;">",-65;"EOF",-65;"IDENT",-65;"LET",-65;"OPEN",-65;"[",-65];["IDENT",115];[")",-66;"*",-66;",",-66;"->",-66;".",-66;";",-66;"<",-66;"=",-66;">",-66;"EOF",-66;"IDENT",-66;"LET",-66;"OPEN",-66;"[",-66];[";",-67;"EOF",-67];["LET",67;"OPEN",84;"letBinding",86;"openOrLet",118];[";",-68;"EOF",-68];["(",-69;")",-69;"*",-69;"+",-69;",",-69;"-",-69;"->",-69;".",-69;";",-69;"=",-69;"ALWAYS_INFIX",-69;"EOF",-69;"IDENT",-69;"LITERAL",-69;"RHSEND",-69;"RRPAREN",-69;"WITH",-69;"[",-69;"[|",-69;"]",-69;"{",-69;"|",-69;"|]",-69;"}",-69];["(",-70;")",-70;"*",-70;"+",-70;",",-70;"-",-70;"->",-70;".",-70;";",-70;"=",-70;"ALWAYS_INFIX",-70;"EOF",-70;"IDENT",-70;"LITERAL",-70;"RHSEND",-70;"RRPAREN",-70;"WITH",-70;"[",-70;"[|",-70;"]",-70;"{",-70;"|",-70;"|]",-70;"}",-70];["IDENT",82;"LITERAL",83;"matchPattern",94;"patternAndGuard",133;"ruleClause",122];["RHSEND",-71;"|",-71];["RHSEND",-72;"|",-72];[")",-73;";",-73;"RRPAREN",-73;"]",-73;"|]",-73];[";",127;"RRPAREN",143];[";",127;"RRPAREN",156];["(",19;"+",97;"-",98;"ALWAYS_PREFIX",99;"FUN",63;"IDENT",52;"LET",67;"LITERAL",22;"MATCH",76;"[",71;"[|",7;"appExpr",149;"arrayExpr",23;"atomicExpr",119;"binaryExpr",129;"declExpr",128;"identExpr",24;"lambdaExpr",152;"letBinding",34;"listExpr",25;"matchExpr",153;"parenExpr",26;"prefix",150;"qualificationExpr",108;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",100;"revTupleExpr",130;"tupleExpr",154;"unaryExpr",112;"valueExpr",35;"{",106];[")",-74;";",-74;"RRPAREN",-74;"]",-74;"|]",-74];[")",-75;",",-75;";",-75;"EOF",-75;"RHSEND",-75;"RRPAREN",-75;"WITH",-75;"]",-75;"|",-75;"|]",-75;"}",-75];[")",-80;",",131;";",-80;"EOF",-80;"RHSEND",-80;"RRPAREN",-80;"WITH",-80;"]",-80;"|",-80;"|]",-80;"}",-80];["(",19;"+",97;"-",98;"ALWAYS_PREFIX",99;"IDENT",52;"LITERAL",22;"[",71;"[|",7;"appExpr",149;"arrayExpr",23;"atomicExpr",119;"binaryExpr",132;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",150;"qualificationExpr",108;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",100;"unaryExpr",112;"{",106];[")",-76;",",-76;";",-76;"EOF",-76;"RHSEND",-76;"RRPAREN",-76;"WITH",-76;"]",-76;"|",-76;"|]",-76;"}",-76];["->",134];["(",19;"+",97;"-",98;"ALWAYS_PREFIX",99;"IDENT",52;"LITERAL",22;"LLPAREN",142;"[",71;"[|",7;"appExpr",149;"arrayExpr",23;"atomicExpr",119;"binaryExpr",129;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",150;"qualificationExpr",108;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",100;"revTupleExpr",130;"tupleExpr",144;"tupleRhs",135;"unaryExpr",112;"{",106];["RHSEND",-77;"|",-77];["]",137];[")",-78;"*",-78;",",-78;"->",-78;"=",-78;">",-78;"IDENT",-78;"[",-78];[")",-79;"*",-79;",",-79;"->",-79;"=",-79;">",-79;"IDENT",-79;"[",-79];[")",-81;",",-81;"=",-81];["(",88;"IDENT",28;"atomicPattern",141;"parameterPattern",31];[")",-82;",",-82;"=",-82];["(",19;"+",97;"-",98;"ALWAYS_PREFIX",99;"FUN",63;"IDENT",52;"LET",67;"LITERAL",22;"MATCH",76;"[",71;"[|",7;"appExpr",149;"arrayExpr",23;"atomicExpr",119;"binaryExpr",129;"declExpr",124;"identExpr",24;"lambdaExpr",152;"letBinding",34;"listExpr",25;"matchExpr",153;"parenExpr",26;"prefix",150;"qualificationExpr",108;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",100;"revSequentialExpr",125;"revTupleExpr",130;"tupleExpr",154;"unaryExpr",112;"valueExpr",35;"{",106];[")",-83;";",-83;"EOF",-83;"RHSEND",-83;"RRPAREN",-83;"]",-83;"|",-83;"|]",-83;"}",-83];[")",-84;";",-84;"EOF",-84;"RHSEND",-84;"RRPAREN",-84;"]",-84;"|",-84;"|]",-84;"}",-84];["(",11;"IDENT",113;"TYPAR",14;"appType",4;"atomType",6;"longid",15;"revLongid",75];[",",-88;">",-88];["(",11;"IDENT",113;"TYPAR",14;"appType",3;"atomType",6;"funType",48;"longid",15;"revLongid",75;"tupleType",51;"typeArgument",148];[",",-89;">",-89];[")",-90;"*",-90;"+",-90;",",-90;"-",-90;"->",-90;";",-90;"=",-90;"ALWAYS_INFIX",-90;"EOF",-90;"RHSEND",-90;"RRPAREN",-90;"WITH",-90;"]",-90;"|",-90;"|]",-90;"}",-90];["(",19;"IDENT",52;"LITERAL",22;"[",71;"[|",7;"appExpr",151;"arrayExpr",23;"atomicExpr",119;"identExpr",24;"listExpr",25;"parenExpr",26;"qualificationExpr",108;"recdLiteralExpr",27;"revAppExpr",2;"revQualificationExpr",100;"{",106];[")",-91;"*",-91;"+",-91;",",-91;"-",-91;"->",-91;";",-91;"=",-91;"ALWAYS_INFIX",-91;"EOF",-91;"RHSEND",-91;"RRPAREN",-91;"WITH",-91;"]",-91;"|",-91;"|]",-91;"}",-91];[")",-92;";",-92;"EOF",-92;"RRPAREN",-92;"]",-92;"|]",-92;"}",-92];[")",-93;";",-93;"EOF",-93;"RRPAREN",-93;"]",-93;"|]",-93;"}",-93];[")",-94;";",-94;"EOF",-94;"RRPAREN",-94;"]",-94;"|]",-94;"}",-94];["(",19;"+",97;"-",98;"ALWAYS_PREFIX",99;"FUN",63;"IDENT",52;"LET",67;"LITERAL",22;"MATCH",76;"[",71;"[|",7;"appExpr",149;"arrayExpr",23;"atomicExpr",119;"binaryExpr",129;"declExpr",124;"identExpr",24;"lambdaExpr",152;"letBinding",34;"listExpr",25;"matchExpr",153;"parenExpr",26;"prefix",150;"qualificationExpr",108;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",100;"revSequentialExpr",126;"revTupleExpr",130;"tupleExpr",154;"unaryExpr",112;"valueExpr",35;"{",106];[")",-95;";",-95;"EOF",-95;"RRPAREN",-95;"]",-95;"|]",-95;"}",-95];[")",-96;";",-96;"EOF",-96;"RRPAREN",-96;"]",-96;"|]",-96;"}",-96]]
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
    ["arrayExpr";"[|";"revSequentialExpr";"|]"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(option<int>*Expr) list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
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
            fst s0, LiteralExpr(snd s0)
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
        let s0 = unbox<(option<int> * Either<string, Expr>) list> ss.[0]
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
    ["fieldBinding";"IDENT";"=";"valueRhs"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int>*Expr) list> ss.[2]
        let result:option<int>*RecordFiledBinding =
            fst s0, RecordFiledBinding(snd s0, snd(Expr.ofSequentialExpr s2))
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
    ["file";"MODULE";"longid";"revOpenOrLets";"EOF"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*string list> ss.[1]
        let s2 = unbox<(option<int>*Expr) list> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
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
    ["lambdaExpr";"FUN";"parameterPattern";"->";"tupleRhs"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Pattern> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<(option<int>*Expr) list> ss.[3]
        let result:option<int>*Expr =
            s0, LambdaExpr(snd s1, snd(Expr.ofSequentialExpr s3))
        box result)
    ["letBinding";"LET";"bindingPattern";"=";"valueRhs"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Pattern> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<(option<int>*Expr) list> ss.[3]
        let result:option<int>*Expr =
            s0, LetBindingExpr(snd s1, snd(Expr.ofSequentialExpr s3))
        box result)
    ["listExpr";"[";"]"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let result:option<int>*Expr =
            s0, ListExpr []
        box result)
    ["listExpr";"[";"revSequentialExpr";"]"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(option<int>*Expr) list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:option<int>*Expr =
            s0, ListExpr(snd (Expr.ofSequentialExpr s1))
        box result)
    ["longid";"revLongid"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*string) list> ss.[0]
        let result:option<int>*string list =
            let i,ls = s0 |> List.rev |> List.unzip
            i.[0], ls
        box result)
    ["matchExpr";"MATCH";"tupleExpr";"WITH";"opt_bar";"revRuleClauses";"RHSEND"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Expr> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let s4 = unbox<(option<int>*RuleClause) list> ss.[4]
        let s5 = unbox<option<int>> ss.[5]
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
    ["parenExpr";"(";"revSequentialExpr";")"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(option<int>*Expr) list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
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
    ["recdLiteralExpr";"{";"fieldBindings";"}"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(option<int>*RecordFiledBinding) list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
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
        let s0 = unbox<(option<int> * Either<string, Expr>) list> ss.[0]
        let s1 = unbox<option<int>*string> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let result:(option<int> * Either<string, Expr>) list =
            let s1 = fst s1,Left(snd s1)
            let s2 = fst s2,Right(snd s2)
            s2::s1::s0
        box result)
    ["revBinaryExpr";"unaryExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:(option<int> * Either<string, Expr>) list =
            [fst s0, Right(snd s0)]
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
    ["ruleClause";"patternAndGuard";"->";"tupleRhs"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Pattern*Expr option> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int>*Expr) list> ss.[2]
        let result:option<int>*RuleClause =
            let i,p,g = s0
            i, RuleClause(p, g, snd(Expr.ofSequentialExpr s2))
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
    ["tupleRhs";"LLPAREN";"revSequentialExpr";"RRPAREN"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(option<int>*Expr) list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:(option<int>*Expr) list =
            s1
        box result)
    ["tupleRhs";"tupleExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:(option<int>*Expr) list =
            [s0]
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
            fst s0, UnaryExpr(snd s0, snd s1)
        box result)
    ["valueExpr";"lambdaExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
    ["valueExpr";"matchExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
    ["valueExpr";"tupleExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
    ["valueRhs";"LLPAREN";"revSequentialExpr";"RRPAREN"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(option<int>*Expr) list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:(option<int>*Expr) list =
            s1
        box result)
    ["valueRhs";"valueExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:(option<int>*Expr) list =
            [s0]
        box result)
]
let unboxRoot =
    unbox<string list*Expr list>
let parser = ParseTable.from(rules, actions)