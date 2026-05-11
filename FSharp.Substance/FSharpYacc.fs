module FSharp.Substance.FSharpYacc
open FSharp.LexYacc
let stateSymbols: string[] = [|"";"file";"revAppExpr";"appType";"appType";"suffixType";"atomType";"[|";"revSequentialExpr";"opt_semicolon";"|]";"|]";"(";"typeArgument";")";"TYPAR";"longid";"<";"typeArguments";">";"(";")";"infix";")";"LITERAL";"arrayExpr";"identExpr";"listExpr";"parenExpr";"IDENT";":";"typeArgument";"parameterPattern";"revBinaryExpr";"tuplePattern";"letBinding";"matchExpr";"valueExpr";"MODULE";"longid";"EOF";"revOpenOrLets";"opt_semicolon";"EOF";"funType";"->";"tupleType";"tupleType";"IDENT";"<";"typeArguments";">";"*";"+";"+";"-";"-";"=";"ALWAYS_INFIX";"FUN";"parameterPattern";"->";"LLPAREN";"revSequentialExpr";"opt_semicolon";"RRPAREN";"valueExpr";"RHSEND";"LET";"bindingPattern";"=";"LLPAREN";"revSequentialExpr";"opt_semicolon";"RRPAREN";"valueExpr";"RHSEND";"[";"]";"revSequentialExpr";"opt_semicolon";"]";"revLongid";"MATCH";"tupleExpr";"WITH";"opt_bar";"revRuleClauses";"IDENT";"LITERAL";"OPEN";"longid";"letBinding";"|";";";";";"(";"bindingPattern";")";"IDENT";"revSequentialExpr";"opt_semicolon";")";"matchPattern";"WHEN";"binaryExpr";"!";"+";"-";"ALWAYS_PREFIX";"revQualificationExpr";".";"[";"tupleExpr";"]";"identExpr";"qualificationExpr";"qualificationExpr";"infix";"unaryExpr";"unaryExpr";"IDENT";".";"IDENT";"openOrLet";"openOrLet";"atomicExpr";"qualificationSuffix";"|";"ruleClause";"ruleClause";"declExpr";"revSequentialExpr";"declExpr";"binaryExpr";"revTupleExpr";",";"binaryExpr";"patternAndGuard";"->";"LLPAREN";"opt_semicolon";"RRPAREN";"valueExpr";"RHSEND";"[";"]";"longid";"atomicPattern";",";"atomicPattern";"*";"typeArgument";",";"typeArgument";"appExpr";"prefix";"appExpr";"lambdaExpr";"tupleExpr"|]
let actions: (string * int) list list = [["MODULE",38;"file",1];["",0];["(",20;")",-1;"*",-1;"+",-1;",",-1;"-",-1;"->",-1;";",-1;"=",-1;"ALWAYS_INFIX",-1;"IDENT",48;"LITERAL",24;"RHSEND",-1;"RRPAREN",-1;"WITH",-1;"[",77;"[|",7;"]",-1;"arrayExpr",25;"atomicExpr",126;"identExpr",26;"listExpr",27;"parenExpr",28;"qualificationExpr",117;"revQualificationExpr",110;"|]",-1];[")",-86;"*",-86;",",-86;"->",-86;"=",-86;">",-86;"IDENT",121;"[",145;"longid",147;"revLongid",82;"suffixType",5];[")",-87;"*",-87;",",-87;"->",-87;"=",-87;">",-87;"IDENT",121;"[",145;"longid",147;"revLongid",82;"suffixType",5];[")",-2;"*",-2;",",-2;"->",-2;"=",-2;">",-2;"IDENT",-2;"[",-2];[")",-3;"*",-3;",",-3;"->",-3;"=",-3;">",-3;"IDENT",-3;"[",-3];["!",106;"(",20;"+",107;"-",108;"ALWAYS_PREFIX",109;"FUN",59;"IDENT",48;"LET",68;"LITERAL",24;"MATCH",83;"[",77;"[|",7;"appExpr",155;"arrayExpr",25;"atomicExpr",126;"binaryExpr",134;"declExpr",131;"identExpr",26;"lambdaExpr",158;"letBinding",35;"listExpr",27;"matchExpr",36;"parenExpr",28;"prefix",156;"qualificationExpr",116;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",110;"revSequentialExpr",8;"revTupleExpr",135;"tupleExpr",159;"unaryExpr",120;"valueExpr",37;"|]",11];[";",95;"opt_semicolon",9;"|]",-49];["|]",10];["(",-4;")",-4;"*",-4;"+",-4;",",-4;"-",-4;"->",-4;".",-4;";",-4;"=",-4;"ALWAYS_INFIX",-4;"IDENT",-4;"LITERAL",-4;"RHSEND",-4;"RRPAREN",-4;"WITH",-4;"[",-4;"[|",-4;"]",-4;"|]",-4];["(",-5;")",-5;"*",-5;"+",-5;",",-5;"-",-5;"->",-5;".",-5;";",-5;"=",-5;"ALWAYS_INFIX",-5;"IDENT",-5;"LITERAL",-5;"RHSEND",-5;"RRPAREN",-5;"WITH",-5;"[",-5;"[|",-5;"]",-5;"|]",-5];["(",12;"IDENT",121;"TYPAR",15;"appType",3;"atomType",6;"funType",44;"longid",16;"revLongid",82;"tupleType",47;"typeArgument",13];[")",14];[")",-6;"*",-6;",",-6;"->",-6;"=",-6;">",-6;"IDENT",-6;"[",-6];[")",-7;"*",-7;",",-7;"->",-7;"=",-7;">",-7;"IDENT",-7;"[",-7];[")",-8;"*",-8;",",-8;"->",-8;"<",17;"=",-8;">",-8;"IDENT",-8;"[",-8];["(",12;"IDENT",121;"TYPAR",15;"appType",3;"atomType",6;"funType",44;"longid",16;"revLongid",82;"tupleType",47;"typeArgument",152;"typeArguments",18];[",",153;">",19];[")",-9;"*",-9;",",-9;"->",-9;"=",-9;">",-9;"IDENT",-9;"[",-9];["!",106;"(",20;")",21;"*",52;"+",54;"-",56;"=",57;"ALWAYS_INFIX",58;"ALWAYS_PREFIX",109;"FUN",59;"IDENT",48;"LET",68;"LITERAL",24;"MATCH",83;"[",77;"[|",7;"appExpr",155;"arrayExpr",25;"atomicExpr",126;"binaryExpr",134;"declExpr",131;"identExpr",26;"infix",22;"lambdaExpr",158;"letBinding",35;"listExpr",27;"matchExpr",36;"parenExpr",28;"prefix",156;"qualificationExpr",116;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",110;"revSequentialExpr",100;"revTupleExpr",135;"tupleExpr",159;"unaryExpr",120;"valueExpr",37];["(",-10;")",-10;"*",-10;"+",-10;",",-10;"-",-10;"->",-10;".",-10;";",-10;"=",-10;"ALWAYS_INFIX",-10;"IDENT",-10;"LITERAL",-10;"RHSEND",-10;"RRPAREN",-10;"WITH",-10;"[",-10;"[|",-10;"]",-10;"|]",-10];[")",23];["(",-11;")",-11;"*",-11;"+",-11;",",-11;"-",-11;"->",-11;".",-11;";",-11;"=",-11;"ALWAYS_INFIX",-11;"IDENT",-11;"LITERAL",-11;"RHSEND",-11;"RRPAREN",-11;"WITH",-11;"[",-11;"[|",-11;"]",-11;"|]",-11];["(",-12;")",-12;"*",-12;"+",-12;",",-12;"-",-12;"->",-12;".",-12;";",-12;"=",-12;"ALWAYS_INFIX",-12;"IDENT",-12;"LITERAL",-12;"RHSEND",-12;"RRPAREN",-12;"WITH",-12;"[",-12;"[|",-12;"]",-12;"|]",-12];["(",-13;")",-13;"*",-13;"+",-13;",",-13;"-",-13;"->",-13;".",-13;";",-13;"=",-13;"ALWAYS_INFIX",-13;"IDENT",-13;"LITERAL",-13;"RHSEND",-13;"RRPAREN",-13;"WITH",-13;"[",-13;"[|",-13;"]",-13;"|]",-13];["(",-14;")",-14;"*",-14;"+",-14;",",-14;"-",-14;"->",-14;".",-14;";",-14;"=",-14;"ALWAYS_INFIX",-14;"IDENT",-14;"LITERAL",-14;"RHSEND",-14;"RRPAREN",-14;"WITH",-14;"[",-14;"[|",-14;"]",-14;"|]",-14];["(",-15;")",-15;"*",-15;"+",-15;",",-15;"-",-15;"->",-15;".",-15;";",-15;"=",-15;"ALWAYS_INFIX",-15;"IDENT",-15;"LITERAL",-15;"RHSEND",-15;"RRPAREN",-15;"WITH",-15;"[",-15;"[|",-15;"]",-15;"|]",-15];["(",-16;")",-16;"*",-16;"+",-16;",",-16;"-",-16;"->",-16;".",-16;";",-16;"=",-16;"ALWAYS_INFIX",-16;"IDENT",-16;"LITERAL",-16;"RHSEND",-16;"RRPAREN",-16;"WITH",-16;"[",-16;"[|",-16;"]",-16;"|]",-16];[")",-52;",",-52;":",30;"=",-52];["(",12;"IDENT",121;"TYPAR",15;"appType",3;"atomType",6;"funType",44;"longid",16;"revLongid",82;"tupleType",47;"typeArgument",31];[")",-17;",",-17;"=",-17];[")",-18;",",-18;"=",-18];[")",-19;"*",52;"+",53;",",-19;"-",55;"->",-19;";",-19;"=",57;"ALWAYS_INFIX",58;"RHSEND",-19;"RRPAREN",-19;"WITH",-19;"]",-19;"infix",118;"|]",-19];[")",-20;",",149;"=",-20];[")",-21;";",-21;"RRPAREN",-21;"]",-21;"|]",-21];[")",-22;";",-22;"RRPAREN",-22;"]",-22;"|]",-22];[")",-23;";",-23;"RRPAREN",-23;"]",-23;"|]",-23];["IDENT",121;"longid",39;"revLongid",82];["EOF",40;"LET",68;"OPEN",90;"letBinding",92;"openOrLet",124;"revOpenOrLets",41];["",-24];[";",94;"EOF",-49;"opt_semicolon",42];["EOF",43];["",-25];[")",-88;",",-88;"->",45;"=",-88;">",-88];["(",12;"IDENT",121;"TYPAR",15;"appType",3;"atomType",6;"longid",16;"revLongid",82;"tupleType",46];[")",-26;"*",151;",",-26;"->",-26;"=",-26;">",-26];[")",-27;"*",151;",",-27;"->",-27;"=",-27;">",-27];["(",-28;")",-28;"*",-28;"+",-28;",",-28;"-",-28;"->",-28;".",-28;";",-28;"<",49;"=",-28;"ALWAYS_INFIX",-28;"IDENT",-28;"LITERAL",-28;"RHSEND",-28;"RRPAREN",-28;"WITH",-28;"[",-28;"[|",-28;"]",-28;"|]",-28];["(",12;"IDENT",121;"TYPAR",15;"appType",3;"atomType",6;"funType",44;"longid",16;"revLongid",82;"tupleType",47;"typeArgument",152;"typeArguments",50];[",",153;">",51];["(",-29;")",-29;"*",-29;"+",-29;",",-29;"-",-29;"->",-29;".",-29;";",-29;"=",-29;"ALWAYS_INFIX",-29;"IDENT",-29;"LITERAL",-29;"RHSEND",-29;"RRPAREN",-29;"WITH",-29;"[",-29;"[|",-29;"]",-29;"|]",-29];["!",-30;"(",-30;")",-30;"+",-30;"-",-30;"ALWAYS_PREFIX",-30;"IDENT",-30;"LITERAL",-30;"[",-30;"[|",-30];["!",-31;"(",-31;"+",-31;"-",-31;"ALWAYS_PREFIX",-31;"IDENT",-31;"LITERAL",-31;"[",-31;"[|",-31];["(",-57;")",-31;"IDENT",-57;"LITERAL",-57;"[",-57;"[|",-57];["!",-32;"(",-32;"+",-32;"-",-32;"ALWAYS_PREFIX",-32;"IDENT",-32;"LITERAL",-32;"[",-32;"[|",-32];["(",-58;")",-32;"IDENT",-58;"LITERAL",-58;"[",-58;"[|",-58];["!",-33;"(",-33;")",-33;"+",-33;"-",-33;"ALWAYS_PREFIX",-33;"IDENT",-33;"LITERAL",-33;"[",-33;"[|",-33];["!",-34;"(",-34;")",-34;"+",-34;"-",-34;"ALWAYS_PREFIX",-34;"IDENT",-34;"LITERAL",-34;"[",-34;"[|",-34];["(",96;"IDENT",99;"parameterPattern",60];["->",61];["!",106;"(",20;"+",107;"-",108;"ALWAYS_PREFIX",109;"FUN",59;"IDENT",48;"LITERAL",24;"LLPAREN",62;"[",77;"[|",7;"appExpr",155;"arrayExpr",25;"atomicExpr",126;"binaryExpr",134;"identExpr",26;"lambdaExpr",158;"listExpr",27;"parenExpr",28;"prefix",156;"qualificationExpr",116;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",110;"revTupleExpr",135;"tupleExpr",159;"unaryExpr",120;"valueExpr",66];["!",106;"(",20;"+",107;"-",108;"ALWAYS_PREFIX",109;"FUN",59;"IDENT",48;"LET",68;"LITERAL",24;"MATCH",83;"[",77;"[|",7;"appExpr",155;"arrayExpr",25;"atomicExpr",126;"binaryExpr",134;"declExpr",131;"identExpr",26;"lambdaExpr",158;"letBinding",35;"listExpr",27;"matchExpr",36;"parenExpr",28;"prefix",156;"qualificationExpr",116;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",110;"revSequentialExpr",63;"revTupleExpr",135;"tupleExpr",159;"unaryExpr",120;"valueExpr",37];[";",95;"RRPAREN",-49;"opt_semicolon",64];["RRPAREN",65];[")",-35;";",-35;"RHSEND",-35;"RRPAREN",-35;"]",-35;"|]",-35];["RHSEND",67];[")",-36;";",-36;"RHSEND",-36;"RRPAREN",-36;"]",-36;"|]",-36];["(",96;"IDENT",29;"atomicPattern",148;"bindingPattern",69;"parameterPattern",32;"tuplePattern",34];["=",70];["!",106;"(",20;"+",107;"-",108;"ALWAYS_PREFIX",109;"FUN",59;"IDENT",48;"LITERAL",24;"LLPAREN",71;"[",77;"[|",7;"appExpr",155;"arrayExpr",25;"atomicExpr",126;"binaryExpr",134;"identExpr",26;"lambdaExpr",158;"listExpr",27;"parenExpr",28;"prefix",156;"qualificationExpr",116;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",110;"revTupleExpr",135;"tupleExpr",159;"unaryExpr",120;"valueExpr",75];["!",106;"(",20;"+",107;"-",108;"ALWAYS_PREFIX",109;"FUN",59;"IDENT",48;"LET",68;"LITERAL",24;"MATCH",83;"[",77;"[|",7;"appExpr",155;"arrayExpr",25;"atomicExpr",126;"binaryExpr",134;"declExpr",131;"identExpr",26;"lambdaExpr",158;"letBinding",35;"listExpr",27;"matchExpr",36;"parenExpr",28;"prefix",156;"qualificationExpr",116;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",110;"revSequentialExpr",72;"revTupleExpr",135;"tupleExpr",159;"unaryExpr",120;"valueExpr",37];[";",95;"RRPAREN",-49;"opt_semicolon",73];["RRPAREN",74];[")",-37;";",-37;"EOF",-37;"RRPAREN",-37;"]",-37;"|]",-37];["RHSEND",76];[")",-38;";",-38;"EOF",-38;"RRPAREN",-38;"]",-38;"|]",-38];["!",106;"(",20;"+",107;"-",108;"ALWAYS_PREFIX",109;"FUN",59;"IDENT",48;"LET",68;"LITERAL",24;"MATCH",83;"[",77;"[|",7;"]",78;"appExpr",155;"arrayExpr",25;"atomicExpr",126;"binaryExpr",134;"declExpr",131;"identExpr",26;"lambdaExpr",158;"letBinding",35;"listExpr",27;"matchExpr",36;"parenExpr",28;"prefix",156;"qualificationExpr",116;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",110;"revSequentialExpr",79;"revTupleExpr",135;"tupleExpr",159;"unaryExpr",120;"valueExpr",37];["(",-39;")",-39;"*",-39;"+",-39;",",-39;"-",-39;"->",-39;".",-39;";",-39;"=",-39;"ALWAYS_INFIX",-39;"IDENT",-39;"LITERAL",-39;"RHSEND",-39;"RRPAREN",-39;"WITH",-39;"[",-39;"[|",-39;"]",-39;"|]",-39];[";",95;"]",-49;"opt_semicolon",80];["]",81];["(",-40;")",-40;"*",-40;"+",-40;",",-40;"-",-40;"->",-40;".",-40;";",-40;"=",-40;"ALWAYS_INFIX",-40;"IDENT",-40;"LITERAL",-40;"RHSEND",-40;"RRPAREN",-40;"WITH",-40;"[",-40;"[|",-40;"]",-40;"|]",-40];[")",-41;"*",-41;",",-41;"->",-41;".",122;";",-41;"<",-41;"=",-41;">",-41;"EOF",-41;"IDENT",-41;"LET",-41;"OPEN",-41;"[",-41];["!",106;"(",20;"+",107;"-",108;"ALWAYS_PREFIX",109;"IDENT",48;"LITERAL",24;"[",77;"[|",7;"appExpr",155;"arrayExpr",25;"atomicExpr",126;"binaryExpr",134;"identExpr",26;"listExpr",27;"parenExpr",28;"prefix",156;"qualificationExpr",116;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",110;"revTupleExpr",135;"tupleExpr",84;"unaryExpr",120];["WITH",85];["IDENT",-47;"LITERAL",-47;"opt_bar",86;"|",93];["IDENT",88;"LITERAL",89;"matchPattern",103;"patternAndGuard",138;"revRuleClauses",87;"ruleClause",130];[")",-42;";",-42;"RRPAREN",-42;"]",-42;"|",128;"|]",-42];["->",-43;"WHEN",-43];["->",-44;"WHEN",-44];["IDENT",121;"longid",91;"revLongid",82];[";",-45;"EOF",-45];[";",-46;"EOF",-46];["IDENT",-48;"LITERAL",-48];["EOF",-50;"LET",68;"OPEN",90;"letBinding",92;"openOrLet",125];["!",106;"(",20;")",-50;"+",107;"-",108;"ALWAYS_PREFIX",109;"FUN",59;"IDENT",48;"LET",68;"LITERAL",24;"MATCH",83;"RRPAREN",-50;"[",77;"[|",7;"]",-50;"appExpr",155;"arrayExpr",25;"atomicExpr",126;"binaryExpr",134;"declExpr",133;"identExpr",26;"lambdaExpr",158;"letBinding",35;"listExpr",27;"matchExpr",36;"parenExpr",28;"prefix",156;"qualificationExpr",116;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",110;"revTupleExpr",135;"tupleExpr",159;"unaryExpr",120;"valueExpr",37;"|]",-50];["(",96;"IDENT",29;"atomicPattern",148;"bindingPattern",97;"parameterPattern",32;"tuplePattern",34];[")",98];[")",-51;",",-51;"->",-51;"=",-51];["->",-52];[")",-49;";",95;"opt_semicolon",101];[")",102];["(",-53;")",-53;"*",-53;"+",-53;",",-53;"-",-53;"->",-53;".",-53;";",-53;"=",-53;"ALWAYS_INFIX",-53;"IDENT",-53;"LITERAL",-53;"RHSEND",-53;"RRPAREN",-53;"WITH",-53;"[",-53;"[|",-53;"]",-53;"|]",-53];["->",-54;"WHEN",104];["!",106;"(",20;"+",107;"-",108;"ALWAYS_PREFIX",109;"IDENT",48;"LITERAL",24;"[",77;"[|",7;"appExpr",155;"arrayExpr",25;"atomicExpr",126;"binaryExpr",105;"identExpr",26;"listExpr",27;"parenExpr",28;"prefix",156;"qualificationExpr",116;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",110;"unaryExpr",120];["->",-55];["(",-56;"IDENT",-56;"LITERAL",-56;"[",-56;"[|",-56];["(",-57;"IDENT",-57;"LITERAL",-57;"[",-57;"[|",-57];["(",-58;"IDENT",-58;"LITERAL",-58;"[",-58;"[|",-58];["(",-59;"IDENT",-59;"LITERAL",-59;"[",-59;"[|",-59];["(",-60;")",-60;"*",-60;"+",-60;",",-60;"-",-60;"->",-60;".",111;";",-60;"=",-60;"ALWAYS_INFIX",-60;"IDENT",-60;"LITERAL",-60;"RHSEND",-60;"RRPAREN",-60;"WITH",-60;"[",-60;"[|",-60;"]",-60;"qualificationSuffix",127;"|]",-60];["IDENT",48;"[",112;"identExpr",115];["!",106;"(",20;"+",107;"-",108;"ALWAYS_PREFIX",109;"IDENT",48;"LITERAL",24;"[",77;"[|",7;"appExpr",155;"arrayExpr",25;"atomicExpr",126;"binaryExpr",134;"identExpr",26;"listExpr",27;"parenExpr",28;"prefix",156;"qualificationExpr",116;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",110;"revTupleExpr",135;"tupleExpr",113;"unaryExpr",120];["]",114];["(",-61;")",-61;"*",-61;"+",-61;",",-61;"-",-61;"->",-61;".",-61;";",-61;"=",-61;"ALWAYS_INFIX",-61;"IDENT",-61;"LITERAL",-61;"RHSEND",-61;"RRPAREN",-61;"WITH",-61;"[",-61;"[|",-61;"]",-61;"|]",-61];["(",-62;")",-62;"*",-62;"+",-62;",",-62;"-",-62;"->",-62;".",-62;";",-62;"=",-62;"ALWAYS_INFIX",-62;"IDENT",-62;"LITERAL",-62;"RHSEND",-62;"RRPAREN",-62;"WITH",-62;"[",-62;"[|",-62;"]",-62;"|]",-62];["(",-63;")",-63;"*",-63;"+",-63;",",-63;"-",-63;"->",-63;";",-63;"=",-63;"ALWAYS_INFIX",-63;"IDENT",-63;"LITERAL",-63;"RHSEND",-63;"RRPAREN",-63;"WITH",-63;"[",-63;"[|",-63;"]",-63;"|]",-63];["(",-64;")",-64;"*",-64;"+",-64;",",-64;"-",-64;"->",-64;";",-64;"=",-64;"ALWAYS_INFIX",-64;"IDENT",-64;"LITERAL",-64;"RHSEND",-64;"RRPAREN",-64;"WITH",-64;"[",-64;"[|",-64;"]",-64;"|]",-64];["!",106;"(",20;"+",107;"-",108;"ALWAYS_PREFIX",109;"IDENT",48;"LITERAL",24;"[",77;"[|",7;"appExpr",155;"arrayExpr",25;"atomicExpr",126;"identExpr",26;"listExpr",27;"parenExpr",28;"prefix",156;"qualificationExpr",116;"revAppExpr",2;"revQualificationExpr",110;"unaryExpr",119];[")",-65;"*",-65;"+",-65;",",-65;"-",-65;"->",-65;";",-65;"=",-65;"ALWAYS_INFIX",-65;"RHSEND",-65;"RRPAREN",-65;"WITH",-65;"]",-65;"|]",-65];[")",-66;"*",-66;"+",-66;",",-66;"-",-66;"->",-66;";",-66;"=",-66;"ALWAYS_INFIX",-66;"RHSEND",-66;"RRPAREN",-66;"WITH",-66;"]",-66;"|]",-66];[")",-67;"*",-67;",",-67;"->",-67;".",-67;";",-67;"<",-67;"=",-67;">",-67;"EOF",-67;"IDENT",-67;"LET",-67;"OPEN",-67;"[",-67];["IDENT",123];[")",-68;"*",-68;",",-68;"->",-68;".",-68;";",-68;"<",-68;"=",-68;">",-68;"EOF",-68;"IDENT",-68;"LET",-68;"OPEN",-68;"[",-68];[";",-69;"EOF",-69];[";",-70;"EOF",-70];["(",-71;")",-71;"*",-71;"+",-71;",",-71;"-",-71;"->",-71;".",-71;";",-71;"=",-71;"ALWAYS_INFIX",-71;"IDENT",-71;"LITERAL",-71;"RHSEND",-71;"RRPAREN",-71;"WITH",-71;"[",-71;"[|",-71;"]",-71;"|]",-71];["(",-72;")",-72;"*",-72;"+",-72;",",-72;"-",-72;"->",-72;".",-72;";",-72;"=",-72;"ALWAYS_INFIX",-72;"IDENT",-72;"LITERAL",-72;"RHSEND",-72;"RRPAREN",-72;"WITH",-72;"[",-72;"[|",-72;"]",-72;"|]",-72];["IDENT",88;"LITERAL",89;"matchPattern",103;"patternAndGuard",138;"ruleClause",129];[")",-73;";",-73;"RRPAREN",-73;"]",-73;"|",-73;"|]",-73];[")",-74;";",-74;"RRPAREN",-74;"]",-74;"|",-74;"|]",-74];[")",-75;";",-75;"RRPAREN",-75;"]",-75;"|]",-75];[";",95;"RRPAREN",-49;"opt_semicolon",141];[")",-76;";",-76;"RRPAREN",-76;"]",-76;"|]",-76];[")",-77;",",-77;";",-77;"RHSEND",-77;"RRPAREN",-77;"WITH",-77;"]",-77;"|]",-77];[")",-83;",",136;";",-83;"RHSEND",-83;"RRPAREN",-83;"WITH",-83;"]",-83;"|]",-83];["!",106;"(",20;"+",107;"-",108;"ALWAYS_PREFIX",109;"IDENT",48;"LITERAL",24;"[",77;"[|",7;"appExpr",155;"arrayExpr",25;"atomicExpr",126;"binaryExpr",137;"identExpr",26;"listExpr",27;"parenExpr",28;"prefix",156;"qualificationExpr",116;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",110;"unaryExpr",120];[")",-78;",",-78;";",-78;"RHSEND",-78;"RRPAREN",-78;"WITH",-78;"]",-78;"|]",-78];["->",139];["!",106;"(",20;"+",107;"-",108;"ALWAYS_PREFIX",109;"FUN",59;"IDENT",48;"LITERAL",24;"LLPAREN",140;"[",77;"[|",7;"appExpr",155;"arrayExpr",25;"atomicExpr",126;"binaryExpr",134;"identExpr",26;"lambdaExpr",158;"listExpr",27;"parenExpr",28;"prefix",156;"qualificationExpr",116;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",110;"revTupleExpr",135;"tupleExpr",159;"unaryExpr",120;"valueExpr",143];["!",106;"(",20;"+",107;"-",108;"ALWAYS_PREFIX",109;"FUN",59;"IDENT",48;"LET",68;"LITERAL",24;"MATCH",83;"[",77;"[|",7;"appExpr",155;"arrayExpr",25;"atomicExpr",126;"binaryExpr",134;"declExpr",131;"identExpr",26;"lambdaExpr",158;"letBinding",35;"listExpr",27;"matchExpr",36;"parenExpr",28;"prefix",156;"qualificationExpr",116;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",110;"revSequentialExpr",132;"revTupleExpr",135;"tupleExpr",159;"unaryExpr",120;"valueExpr",37];["RRPAREN",142];[")",-79;";",-79;"RRPAREN",-79;"]",-79;"|",-79;"|]",-79];["RHSEND",144];[")",-80;";",-80;"RRPAREN",-80;"]",-80;"|",-80;"|]",-80];["]",146];[")",-81;"*",-81;",",-81;"->",-81;"=",-81;">",-81;"IDENT",-81;"[",-81];[")",-82;"*",-82;",",-82;"->",-82;"=",-82;">",-82;"IDENT",-82;"[",-82];[")",-84;",",-84;"=",-84];["(",96;"IDENT",29;"atomicPattern",150;"parameterPattern",32];[")",-85;",",-85;"=",-85];["(",12;"IDENT",121;"TYPAR",15;"appType",4;"atomType",6;"longid",16;"revLongid",82];[",",-89;">",-89];["(",12;"IDENT",121;"TYPAR",15;"appType",3;"atomType",6;"funType",44;"longid",16;"revLongid",82;"tupleType",47;"typeArgument",154];[",",-90;">",-90];[")",-91;"*",-91;"+",-91;",",-91;"-",-91;"->",-91;";",-91;"=",-91;"ALWAYS_INFIX",-91;"RHSEND",-91;"RRPAREN",-91;"WITH",-91;"]",-91;"|]",-91];["(",20;"IDENT",48;"LITERAL",24;"[",77;"[|",7;"appExpr",157;"arrayExpr",25;"atomicExpr",126;"identExpr",26;"listExpr",27;"parenExpr",28;"qualificationExpr",116;"revAppExpr",2;"revQualificationExpr",110];[")",-92;"*",-92;"+",-92;",",-92;"-",-92;"->",-92;";",-92;"=",-92;"ALWAYS_INFIX",-92;"RHSEND",-92;"RRPAREN",-92;"WITH",-92;"]",-92;"|]",-92];[")",-93;";",-93;"RHSEND",-93;"RRPAREN",-93;"]",-93;"|]",-93];[")",-94;";",-94;"RHSEND",-94;"RRPAREN",-94;"]",-94;"|]",-94]]
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
            i, RuleClause.just p g r
        box result)
    ["ruleClause";"patternAndGuard";"->";"valueExpr";"RHSEND"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Pattern*Expr option> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*RuleClause =
            let i,p,g = s0
            i, RuleClause.just p g [snd s2]
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