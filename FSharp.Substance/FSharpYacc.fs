module FSharp.Substance.FSharpYacc
open FSharp.LexYacc
let stateSymbols: string[] = [|"";"file";"revAppExpr";"appType";"appType";"suffixType";"atomType";"[|";"revSequentialExpr";"opt_semicolon";"|]";"|]";"(";"typeArgument";")";"TYPAR";"longid";"<";"typeArguments";">";"(";"infix";")";"LITERAL";"arrayExpr";"identExpr";"listExpr";"parenExpr";"recdLiteralExpr";"IDENT";":";"typeArgument";"parameterPattern";"revBinaryExpr";"tuplePattern";"letBinding";"valueExpr";"IDENT";"=";"LLPAREN";"revSequentialExpr";"opt_semicolon";"RRPAREN";"valueExpr";"RHSEND";"fieldBinding";"fieldBindings";";";"fieldBinding";"MODULE";"longid";"EOF";"revOpenOrLets";"opt_semicolon";"EOF";"funType";"->";"tupleType";"tupleType";"IDENT";"<";"typeArguments";">";"*";"+";"+";"-";"-";"=";"ALWAYS_INFIX";"FUN";"parameterPattern";"->";"LLPAREN";"revSequentialExpr";"opt_semicolon";"RRPAREN";"valueExpr";"RHSEND";"LET";"bindingPattern";"=";"LLPAREN";"revSequentialExpr";"opt_semicolon";"RRPAREN";"valueExpr";"RHSEND";"[";"]";"revSequentialExpr";"opt_semicolon";"]";"revLongid";"MATCH";"tupleExpr";"WITH";"opt_bar";"revRuleClauses";"IDENT";"LITERAL";"OPEN";"longid";"letBinding";"|";";";";";"(";"bindingPattern";")";"IDENT";"revSequentialExpr";"opt_semicolon";")";"matchPattern";"WHEN";"binaryExpr";"+";"-";"ALWAYS_PREFIX";"revQualificationExpr";".";"[";"tupleExpr";"]";"identExpr";"{";"opt_semicolon";"}";"qualificationExpr";"qualificationExpr";"infix";"unaryExpr";"unaryExpr";"IDENT";".";"IDENT";"openOrLet";"openOrLet";"atomicExpr";"qualificationSuffix";"|";"ruleClause";"ruleClause";"declExpr";"revSequentialExpr";"declExpr";"binaryExpr";"revTupleExpr";",";"binaryExpr";"patternAndGuard";"->";"LLPAREN";"opt_semicolon";"RRPAREN";"valueExpr";"RHSEND";"[";"]";"longid";"atomicPattern";",";"atomicPattern";"*";"typeArgument";",";"typeArgument";"appExpr";"prefix";"appExpr";"lambdaExpr";"matchExpr";"tupleExpr"|]
let actions: (string * int) list list = [["MODULE",49;"file",1];["",0];["(",20;")",-1;"*",-1;"+",-1;",",-1;"-",-1;"->",-1;";",-1;"=",-1;"ALWAYS_INFIX",-1;"IDENT",59;"LITERAL",23;"RHSEND",-1;"RRPAREN",-1;"WITH",-1;"[",88;"[|",7;"]",-1;"arrayExpr",24;"atomicExpr",139;"identExpr",25;"listExpr",26;"parenExpr",27;"qualificationExpr",130;"recdLiteralExpr",28;"revQualificationExpr",120;"{",126;"|]",-1];[")",-89;"*",-89;",",-89;"->",-89;"=",-89;">",-89;"IDENT",134;"[",158;"longid",160;"revLongid",93;"suffixType",5];[")",-90;"*",-90;",",-90;"->",-90;"=",-90;">",-90;"IDENT",134;"[",158;"longid",160;"revLongid",93;"suffixType",5];[")",-2;"*",-2;",",-2;"->",-2;"=",-2;">",-2;"IDENT",-2;"[",-2];[")",-3;"*",-3;",",-3;"->",-3;"=",-3;">",-3;"IDENT",-3;"[",-3];["(",20;"+",117;"-",118;"ALWAYS_PREFIX",119;"FUN",70;"IDENT",59;"LET",79;"LITERAL",23;"MATCH",94;"[",88;"[|",7;"appExpr",168;"arrayExpr",24;"atomicExpr",139;"binaryExpr",147;"declExpr",144;"identExpr",25;"lambdaExpr",171;"letBinding",35;"listExpr",26;"matchExpr",172;"parenExpr",27;"prefix",169;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",120;"revSequentialExpr",8;"revTupleExpr",148;"tupleExpr",173;"unaryExpr",133;"valueExpr",36;"{",126;"|]",11];[";",106;"opt_semicolon",9;"|]",-52];["|]",10];["(",-4;")",-4;"*",-4;"+",-4;",",-4;"-",-4;"->",-4;".",-4;";",-4;"=",-4;"ALWAYS_INFIX",-4;"IDENT",-4;"LITERAL",-4;"RHSEND",-4;"RRPAREN",-4;"WITH",-4;"[",-4;"[|",-4;"]",-4;"{",-4;"|]",-4];["(",-5;")",-5;"*",-5;"+",-5;",",-5;"-",-5;"->",-5;".",-5;";",-5;"=",-5;"ALWAYS_INFIX",-5;"IDENT",-5;"LITERAL",-5;"RHSEND",-5;"RRPAREN",-5;"WITH",-5;"[",-5;"[|",-5;"]",-5;"{",-5;"|]",-5];["(",12;"IDENT",134;"TYPAR",15;"appType",3;"atomType",6;"funType",55;"longid",16;"revLongid",93;"tupleType",58;"typeArgument",13];[")",14];[")",-6;"*",-6;",",-6;"->",-6;"=",-6;">",-6;"IDENT",-6;"[",-6];[")",-7;"*",-7;",",-7;"->",-7;"=",-7;">",-7;"IDENT",-7;"[",-7];[")",-8;"*",-8;",",-8;"->",-8;"<",17;"=",-8;">",-8;"IDENT",-8;"[",-8];["(",12;"IDENT",134;"TYPAR",15;"appType",3;"atomType",6;"funType",55;"longid",16;"revLongid",93;"tupleType",58;"typeArgument",165;"typeArguments",18];[",",166;">",19];[")",-9;"*",-9;",",-9;"->",-9;"=",-9;">",-9;"IDENT",-9;"[",-9];["(",20;"*",63;"+",65;"-",67;"=",68;"ALWAYS_INFIX",69;"ALWAYS_PREFIX",119;"FUN",70;"IDENT",59;"LET",79;"LITERAL",23;"MATCH",94;"[",88;"[|",7;"appExpr",168;"arrayExpr",24;"atomicExpr",139;"binaryExpr",147;"declExpr",144;"identExpr",25;"infix",21;"lambdaExpr",171;"letBinding",35;"listExpr",26;"matchExpr",172;"parenExpr",27;"prefix",169;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",120;"revSequentialExpr",111;"revTupleExpr",148;"tupleExpr",173;"unaryExpr",133;"valueExpr",36;"{",126];[")",22];["(",-10;")",-10;"*",-10;"+",-10;",",-10;"-",-10;"->",-10;".",-10;";",-10;"=",-10;"ALWAYS_INFIX",-10;"IDENT",-10;"LITERAL",-10;"RHSEND",-10;"RRPAREN",-10;"WITH",-10;"[",-10;"[|",-10;"]",-10;"{",-10;"|]",-10];["(",-11;")",-11;"*",-11;"+",-11;",",-11;"-",-11;"->",-11;".",-11;";",-11;"=",-11;"ALWAYS_INFIX",-11;"IDENT",-11;"LITERAL",-11;"RHSEND",-11;"RRPAREN",-11;"WITH",-11;"[",-11;"[|",-11;"]",-11;"{",-11;"|]",-11];["(",-12;")",-12;"*",-12;"+",-12;",",-12;"-",-12;"->",-12;".",-12;";",-12;"=",-12;"ALWAYS_INFIX",-12;"IDENT",-12;"LITERAL",-12;"RHSEND",-12;"RRPAREN",-12;"WITH",-12;"[",-12;"[|",-12;"]",-12;"{",-12;"|]",-12];["(",-13;")",-13;"*",-13;"+",-13;",",-13;"-",-13;"->",-13;".",-13;";",-13;"=",-13;"ALWAYS_INFIX",-13;"IDENT",-13;"LITERAL",-13;"RHSEND",-13;"RRPAREN",-13;"WITH",-13;"[",-13;"[|",-13;"]",-13;"{",-13;"|]",-13];["(",-14;")",-14;"*",-14;"+",-14;",",-14;"-",-14;"->",-14;".",-14;";",-14;"=",-14;"ALWAYS_INFIX",-14;"IDENT",-14;"LITERAL",-14;"RHSEND",-14;"RRPAREN",-14;"WITH",-14;"[",-14;"[|",-14;"]",-14;"{",-14;"|]",-14];["(",-15;")",-15;"*",-15;"+",-15;",",-15;"-",-15;"->",-15;".",-15;";",-15;"=",-15;"ALWAYS_INFIX",-15;"IDENT",-15;"LITERAL",-15;"RHSEND",-15;"RRPAREN",-15;"WITH",-15;"[",-15;"[|",-15;"]",-15;"{",-15;"|]",-15];["(",-16;")",-16;"*",-16;"+",-16;",",-16;"-",-16;"->",-16;".",-16;";",-16;"=",-16;"ALWAYS_INFIX",-16;"IDENT",-16;"LITERAL",-16;"RHSEND",-16;"RRPAREN",-16;"WITH",-16;"[",-16;"[|",-16;"]",-16;"{",-16;"|]",-16];[")",-55;",",-55;":",30;"=",-55];["(",12;"IDENT",134;"TYPAR",15;"appType",3;"atomType",6;"funType",55;"longid",16;"revLongid",93;"tupleType",58;"typeArgument",31];[")",-17;",",-17;"=",-17];[")",-18;",",-18;"=",-18];[")",-19;"*",63;"+",64;",",-19;"-",66;"->",-19;";",-19;"=",68;"ALWAYS_INFIX",69;"RHSEND",-19;"RRPAREN",-19;"WITH",-19;"]",-19;"infix",131;"|]",-19];[")",-20;",",162;"=",-20];[")",-21;";",-21;"RRPAREN",-21;"]",-21;"|]",-21];[")",-22;";",-22;"RRPAREN",-22;"]",-22;"|]",-22];["=",38];["(",20;"+",117;"-",118;"ALWAYS_PREFIX",119;"FUN",70;"IDENT",59;"LITERAL",23;"LLPAREN",39;"MATCH",94;"[",88;"[|",7;"appExpr",168;"arrayExpr",24;"atomicExpr",139;"binaryExpr",147;"identExpr",25;"lambdaExpr",171;"listExpr",26;"matchExpr",172;"parenExpr",27;"prefix",169;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",120;"revTupleExpr",148;"tupleExpr",173;"unaryExpr",133;"valueExpr",43;"{",126];["(",20;"+",117;"-",118;"ALWAYS_PREFIX",119;"FUN",70;"IDENT",59;"LET",79;"LITERAL",23;"MATCH",94;"[",88;"[|",7;"appExpr",168;"arrayExpr",24;"atomicExpr",139;"binaryExpr",147;"declExpr",144;"identExpr",25;"lambdaExpr",171;"letBinding",35;"listExpr",26;"matchExpr",172;"parenExpr",27;"prefix",169;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",120;"revSequentialExpr",40;"revTupleExpr",148;"tupleExpr",173;"unaryExpr",133;"valueExpr",36;"{",126];[";",106;"RRPAREN",-52;"opt_semicolon",41];["RRPAREN",42];[";",-23;"}",-23];["RHSEND",44];[";",-24;"}",-24];[";",-25;"}",-25];[";",47;"opt_semicolon",127;"}",-52];["IDENT",37;"fieldBinding",48;"}",-53];[";",-26;"}",-26];["IDENT",134;"longid",50;"revLongid",93];["EOF",51;"LET",79;"OPEN",101;"letBinding",103;"openOrLet",137;"revOpenOrLets",52];["",-27];[";",105;"EOF",-52;"opt_semicolon",53];["EOF",54];["",-28];[")",-91;",",-91;"->",56;"=",-91;">",-91];["(",12;"IDENT",134;"TYPAR",15;"appType",3;"atomType",6;"longid",16;"revLongid",93;"tupleType",57];[")",-29;"*",164;",",-29;"->",-29;"=",-29;">",-29];[")",-30;"*",164;",",-30;"->",-30;"=",-30;">",-30];["(",-31;")",-31;"*",-31;"+",-31;",",-31;"-",-31;"->",-31;".",-31;";",-31;"<",60;"=",-31;"ALWAYS_INFIX",-31;"IDENT",-31;"LITERAL",-31;"RHSEND",-31;"RRPAREN",-31;"WITH",-31;"[",-31;"[|",-31;"]",-31;"{",-31;"|]",-31];["(",12;"IDENT",134;"TYPAR",15;"appType",3;"atomType",6;"funType",55;"longid",16;"revLongid",93;"tupleType",58;"typeArgument",165;"typeArguments",61];[",",166;">",62];["(",-32;")",-32;"*",-32;"+",-32;",",-32;"-",-32;"->",-32;".",-32;";",-32;"=",-32;"ALWAYS_INFIX",-32;"IDENT",-32;"LITERAL",-32;"RHSEND",-32;"RRPAREN",-32;"WITH",-32;"[",-32;"[|",-32;"]",-32;"{",-32;"|]",-32];["(",-33;")",-33;"+",-33;"-",-33;"ALWAYS_PREFIX",-33;"IDENT",-33;"LITERAL",-33;"[",-33;"[|",-33;"{",-33];["(",-34;"+",-34;"-",-34;"ALWAYS_PREFIX",-34;"IDENT",-34;"LITERAL",-34;"[",-34;"[|",-34;"{",-34];["(",-59;")",-34;"IDENT",-59;"LITERAL",-59;"[",-59;"[|",-59;"{",-59];["(",-35;"+",-35;"-",-35;"ALWAYS_PREFIX",-35;"IDENT",-35;"LITERAL",-35;"[",-35;"[|",-35;"{",-35];["(",-60;")",-35;"IDENT",-60;"LITERAL",-60;"[",-60;"[|",-60;"{",-60];["(",-36;")",-36;"+",-36;"-",-36;"ALWAYS_PREFIX",-36;"IDENT",-36;"LITERAL",-36;"[",-36;"[|",-36;"{",-36];["(",-37;")",-37;"+",-37;"-",-37;"ALWAYS_PREFIX",-37;"IDENT",-37;"LITERAL",-37;"[",-37;"[|",-37;"{",-37];["(",107;"IDENT",110;"parameterPattern",71];["->",72];["(",20;"+",117;"-",118;"ALWAYS_PREFIX",119;"FUN",70;"IDENT",59;"LITERAL",23;"LLPAREN",73;"MATCH",94;"[",88;"[|",7;"appExpr",168;"arrayExpr",24;"atomicExpr",139;"binaryExpr",147;"identExpr",25;"lambdaExpr",171;"listExpr",26;"matchExpr",172;"parenExpr",27;"prefix",169;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",120;"revTupleExpr",148;"tupleExpr",173;"unaryExpr",133;"valueExpr",77;"{",126];["(",20;"+",117;"-",118;"ALWAYS_PREFIX",119;"FUN",70;"IDENT",59;"LET",79;"LITERAL",23;"MATCH",94;"[",88;"[|",7;"appExpr",168;"arrayExpr",24;"atomicExpr",139;"binaryExpr",147;"declExpr",144;"identExpr",25;"lambdaExpr",171;"letBinding",35;"listExpr",26;"matchExpr",172;"parenExpr",27;"prefix",169;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",120;"revSequentialExpr",74;"revTupleExpr",148;"tupleExpr",173;"unaryExpr",133;"valueExpr",36;"{",126];[";",106;"RRPAREN",-52;"opt_semicolon",75];["RRPAREN",76];[")",-38;";",-38;"RHSEND",-38;"RRPAREN",-38;"]",-38;"|]",-38];["RHSEND",78];[")",-39;";",-39;"RHSEND",-39;"RRPAREN",-39;"]",-39;"|]",-39];["(",107;"IDENT",29;"atomicPattern",161;"bindingPattern",80;"parameterPattern",32;"tuplePattern",34];["=",81];["(",20;"+",117;"-",118;"ALWAYS_PREFIX",119;"FUN",70;"IDENT",59;"LITERAL",23;"LLPAREN",82;"MATCH",94;"[",88;"[|",7;"appExpr",168;"arrayExpr",24;"atomicExpr",139;"binaryExpr",147;"identExpr",25;"lambdaExpr",171;"listExpr",26;"matchExpr",172;"parenExpr",27;"prefix",169;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",120;"revTupleExpr",148;"tupleExpr",173;"unaryExpr",133;"valueExpr",86;"{",126];["(",20;"+",117;"-",118;"ALWAYS_PREFIX",119;"FUN",70;"IDENT",59;"LET",79;"LITERAL",23;"MATCH",94;"[",88;"[|",7;"appExpr",168;"arrayExpr",24;"atomicExpr",139;"binaryExpr",147;"declExpr",144;"identExpr",25;"lambdaExpr",171;"letBinding",35;"listExpr",26;"matchExpr",172;"parenExpr",27;"prefix",169;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",120;"revSequentialExpr",83;"revTupleExpr",148;"tupleExpr",173;"unaryExpr",133;"valueExpr",36;"{",126];[";",106;"RRPAREN",-52;"opt_semicolon",84];["RRPAREN",85];[")",-40;";",-40;"EOF",-40;"RRPAREN",-40;"]",-40;"|]",-40];["RHSEND",87];[")",-41;";",-41;"EOF",-41;"RRPAREN",-41;"]",-41;"|]",-41];["(",20;"+",117;"-",118;"ALWAYS_PREFIX",119;"FUN",70;"IDENT",59;"LET",79;"LITERAL",23;"MATCH",94;"[",88;"[|",7;"]",89;"appExpr",168;"arrayExpr",24;"atomicExpr",139;"binaryExpr",147;"declExpr",144;"identExpr",25;"lambdaExpr",171;"letBinding",35;"listExpr",26;"matchExpr",172;"parenExpr",27;"prefix",169;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",120;"revSequentialExpr",90;"revTupleExpr",148;"tupleExpr",173;"unaryExpr",133;"valueExpr",36;"{",126];["(",-42;")",-42;"*",-42;"+",-42;",",-42;"-",-42;"->",-42;".",-42;";",-42;"=",-42;"ALWAYS_INFIX",-42;"IDENT",-42;"LITERAL",-42;"RHSEND",-42;"RRPAREN",-42;"WITH",-42;"[",-42;"[|",-42;"]",-42;"{",-42;"|]",-42];[";",106;"]",-52;"opt_semicolon",91];["]",92];["(",-43;")",-43;"*",-43;"+",-43;",",-43;"-",-43;"->",-43;".",-43;";",-43;"=",-43;"ALWAYS_INFIX",-43;"IDENT",-43;"LITERAL",-43;"RHSEND",-43;"RRPAREN",-43;"WITH",-43;"[",-43;"[|",-43;"]",-43;"{",-43;"|]",-43];[")",-44;"*",-44;",",-44;"->",-44;".",135;";",-44;"<",-44;"=",-44;">",-44;"EOF",-44;"IDENT",-44;"LET",-44;"OPEN",-44;"[",-44];["(",20;"+",117;"-",118;"ALWAYS_PREFIX",119;"IDENT",59;"LITERAL",23;"[",88;"[|",7;"appExpr",168;"arrayExpr",24;"atomicExpr",139;"binaryExpr",147;"identExpr",25;"listExpr",26;"parenExpr",27;"prefix",169;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",120;"revTupleExpr",148;"tupleExpr",95;"unaryExpr",133;"{",126];["WITH",96];["IDENT",-50;"LITERAL",-50;"opt_bar",97;"|",104];["IDENT",99;"LITERAL",100;"matchPattern",114;"patternAndGuard",151;"revRuleClauses",98;"ruleClause",143];[")",-45;";",-45;"RHSEND",-45;"RRPAREN",-45;"]",-45;"|",141;"|]",-45];["->",-46;"WHEN",-46];["->",-47;"WHEN",-47];["IDENT",134;"longid",102;"revLongid",93];[";",-48;"EOF",-48];[";",-49;"EOF",-49];["IDENT",-51;"LITERAL",-51];["EOF",-53;"LET",79;"OPEN",101;"letBinding",103;"openOrLet",138];["(",20;")",-53;"+",117;"-",118;"ALWAYS_PREFIX",119;"FUN",70;"IDENT",59;"LET",79;"LITERAL",23;"MATCH",94;"RRPAREN",-53;"[",88;"[|",7;"]",-53;"appExpr",168;"arrayExpr",24;"atomicExpr",139;"binaryExpr",147;"declExpr",146;"identExpr",25;"lambdaExpr",171;"letBinding",35;"listExpr",26;"matchExpr",172;"parenExpr",27;"prefix",169;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",120;"revTupleExpr",148;"tupleExpr",173;"unaryExpr",133;"valueExpr",36;"{",126;"|]",-53];["(",107;"IDENT",29;"atomicPattern",161;"bindingPattern",108;"parameterPattern",32;"tuplePattern",34];[")",109];[")",-54;",",-54;"->",-54;"=",-54];["->",-55];[")",-52;";",106;"opt_semicolon",112];[")",113];["(",-56;")",-56;"*",-56;"+",-56;",",-56;"-",-56;"->",-56;".",-56;";",-56;"=",-56;"ALWAYS_INFIX",-56;"IDENT",-56;"LITERAL",-56;"RHSEND",-56;"RRPAREN",-56;"WITH",-56;"[",-56;"[|",-56;"]",-56;"{",-56;"|]",-56];["->",-57;"WHEN",115];["(",20;"+",117;"-",118;"ALWAYS_PREFIX",119;"IDENT",59;"LITERAL",23;"[",88;"[|",7;"appExpr",168;"arrayExpr",24;"atomicExpr",139;"binaryExpr",116;"identExpr",25;"listExpr",26;"parenExpr",27;"prefix",169;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",120;"unaryExpr",133;"{",126];["->",-58];["(",-59;"IDENT",-59;"LITERAL",-59;"[",-59;"[|",-59;"{",-59];["(",-60;"IDENT",-60;"LITERAL",-60;"[",-60;"[|",-60;"{",-60];["(",-61;"IDENT",-61;"LITERAL",-61;"[",-61;"[|",-61;"{",-61];["(",-62;")",-62;"*",-62;"+",-62;",",-62;"-",-62;"->",-62;".",121;";",-62;"=",-62;"ALWAYS_INFIX",-62;"IDENT",-62;"LITERAL",-62;"RHSEND",-62;"RRPAREN",-62;"WITH",-62;"[",-62;"[|",-62;"]",-62;"qualificationSuffix",140;"{",-62;"|]",-62];["IDENT",59;"[",122;"identExpr",125];["(",20;"+",117;"-",118;"ALWAYS_PREFIX",119;"IDENT",59;"LITERAL",23;"[",88;"[|",7;"appExpr",168;"arrayExpr",24;"atomicExpr",139;"binaryExpr",147;"identExpr",25;"listExpr",26;"parenExpr",27;"prefix",169;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",120;"revTupleExpr",148;"tupleExpr",123;"unaryExpr",133;"{",126];["]",124];["(",-63;")",-63;"*",-63;"+",-63;",",-63;"-",-63;"->",-63;".",-63;";",-63;"=",-63;"ALWAYS_INFIX",-63;"IDENT",-63;"LITERAL",-63;"RHSEND",-63;"RRPAREN",-63;"WITH",-63;"[",-63;"[|",-63;"]",-63;"{",-63;"|]",-63];["(",-64;")",-64;"*",-64;"+",-64;",",-64;"-",-64;"->",-64;".",-64;";",-64;"=",-64;"ALWAYS_INFIX",-64;"IDENT",-64;"LITERAL",-64;"RHSEND",-64;"RRPAREN",-64;"WITH",-64;"[",-64;"[|",-64;"]",-64;"{",-64;"|]",-64];["IDENT",37;"fieldBinding",45;"fieldBindings",46];["}",128];["(",-65;")",-65;"*",-65;"+",-65;",",-65;"-",-65;"->",-65;".",-65;";",-65;"=",-65;"ALWAYS_INFIX",-65;"IDENT",-65;"LITERAL",-65;"RHSEND",-65;"RRPAREN",-65;"WITH",-65;"[",-65;"[|",-65;"]",-65;"{",-65;"|]",-65];["(",-66;")",-66;"*",-66;"+",-66;",",-66;"-",-66;"->",-66;";",-66;"=",-66;"ALWAYS_INFIX",-66;"IDENT",-66;"LITERAL",-66;"RHSEND",-66;"RRPAREN",-66;"WITH",-66;"[",-66;"[|",-66;"]",-66;"{",-66;"|]",-66];["(",-67;")",-67;"*",-67;"+",-67;",",-67;"-",-67;"->",-67;";",-67;"=",-67;"ALWAYS_INFIX",-67;"IDENT",-67;"LITERAL",-67;"RHSEND",-67;"RRPAREN",-67;"WITH",-67;"[",-67;"[|",-67;"]",-67;"{",-67;"|]",-67];["(",20;"+",117;"-",118;"ALWAYS_PREFIX",119;"IDENT",59;"LITERAL",23;"[",88;"[|",7;"appExpr",168;"arrayExpr",24;"atomicExpr",139;"identExpr",25;"listExpr",26;"parenExpr",27;"prefix",169;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revQualificationExpr",120;"unaryExpr",132;"{",126];[")",-68;"*",-68;"+",-68;",",-68;"-",-68;"->",-68;";",-68;"=",-68;"ALWAYS_INFIX",-68;"RHSEND",-68;"RRPAREN",-68;"WITH",-68;"]",-68;"|]",-68];[")",-69;"*",-69;"+",-69;",",-69;"-",-69;"->",-69;";",-69;"=",-69;"ALWAYS_INFIX",-69;"RHSEND",-69;"RRPAREN",-69;"WITH",-69;"]",-69;"|]",-69];[")",-70;"*",-70;",",-70;"->",-70;".",-70;";",-70;"<",-70;"=",-70;">",-70;"EOF",-70;"IDENT",-70;"LET",-70;"OPEN",-70;"[",-70];["IDENT",136];[")",-71;"*",-71;",",-71;"->",-71;".",-71;";",-71;"<",-71;"=",-71;">",-71;"EOF",-71;"IDENT",-71;"LET",-71;"OPEN",-71;"[",-71];[";",-72;"EOF",-72];[";",-73;"EOF",-73];["(",-74;")",-74;"*",-74;"+",-74;",",-74;"-",-74;"->",-74;".",-74;";",-74;"=",-74;"ALWAYS_INFIX",-74;"IDENT",-74;"LITERAL",-74;"RHSEND",-74;"RRPAREN",-74;"WITH",-74;"[",-74;"[|",-74;"]",-74;"{",-74;"|]",-74];["(",-75;")",-75;"*",-75;"+",-75;",",-75;"-",-75;"->",-75;".",-75;";",-75;"=",-75;"ALWAYS_INFIX",-75;"IDENT",-75;"LITERAL",-75;"RHSEND",-75;"RRPAREN",-75;"WITH",-75;"[",-75;"[|",-75;"]",-75;"{",-75;"|]",-75];["IDENT",99;"LITERAL",100;"matchPattern",114;"patternAndGuard",151;"ruleClause",142];[")",-76;";",-76;"RHSEND",-76;"RRPAREN",-76;"]",-76;"|",-76;"|]",-76];[")",-77;";",-77;"RHSEND",-77;"RRPAREN",-77;"]",-77;"|",-77;"|]",-77];[")",-78;";",-78;"RRPAREN",-78;"]",-78;"|]",-78];[";",106;"RRPAREN",-52;"opt_semicolon",154];[")",-79;";",-79;"RRPAREN",-79;"]",-79;"|]",-79];[")",-80;",",-80;";",-80;"RHSEND",-80;"RRPAREN",-80;"WITH",-80;"]",-80;"|]",-80];[")",-86;",",149;";",-86;"RHSEND",-86;"RRPAREN",-86;"WITH",-86;"]",-86;"|]",-86];["(",20;"+",117;"-",118;"ALWAYS_PREFIX",119;"IDENT",59;"LITERAL",23;"[",88;"[|",7;"appExpr",168;"arrayExpr",24;"atomicExpr",139;"binaryExpr",150;"identExpr",25;"listExpr",26;"parenExpr",27;"prefix",169;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",120;"unaryExpr",133;"{",126];[")",-81;",",-81;";",-81;"RHSEND",-81;"RRPAREN",-81;"WITH",-81;"]",-81;"|]",-81];["->",152];["(",20;"+",117;"-",118;"ALWAYS_PREFIX",119;"FUN",70;"IDENT",59;"LITERAL",23;"LLPAREN",153;"MATCH",94;"[",88;"[|",7;"appExpr",168;"arrayExpr",24;"atomicExpr",139;"binaryExpr",147;"identExpr",25;"lambdaExpr",171;"listExpr",26;"matchExpr",172;"parenExpr",27;"prefix",169;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",120;"revTupleExpr",148;"tupleExpr",173;"unaryExpr",133;"valueExpr",156;"{",126];["(",20;"+",117;"-",118;"ALWAYS_PREFIX",119;"FUN",70;"IDENT",59;"LET",79;"LITERAL",23;"MATCH",94;"[",88;"[|",7;"appExpr",168;"arrayExpr",24;"atomicExpr",139;"binaryExpr",147;"declExpr",144;"identExpr",25;"lambdaExpr",171;"letBinding",35;"listExpr",26;"matchExpr",172;"parenExpr",27;"prefix",169;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",120;"revSequentialExpr",145;"revTupleExpr",148;"tupleExpr",173;"unaryExpr",133;"valueExpr",36;"{",126];["RRPAREN",155];[")",-82;";",-82;"RHSEND",-82;"RRPAREN",-82;"]",-82;"|",-82;"|]",-82];["RHSEND",157];[")",-83;";",-83;"RHSEND",-83;"RRPAREN",-83;"]",-83;"|",-83;"|]",-83];["]",159];[")",-84;"*",-84;",",-84;"->",-84;"=",-84;">",-84;"IDENT",-84;"[",-84];[")",-85;"*",-85;",",-85;"->",-85;"=",-85;">",-85;"IDENT",-85;"[",-85];[")",-87;",",-87;"=",-87];["(",107;"IDENT",29;"atomicPattern",163;"parameterPattern",32];[")",-88;",",-88;"=",-88];["(",12;"IDENT",134;"TYPAR",15;"appType",4;"atomType",6;"longid",16;"revLongid",93];[",",-92;">",-92];["(",12;"IDENT",134;"TYPAR",15;"appType",3;"atomType",6;"funType",55;"longid",16;"revLongid",93;"tupleType",58;"typeArgument",167];[",",-93;">",-93];[")",-94;"*",-94;"+",-94;",",-94;"-",-94;"->",-94;";",-94;"=",-94;"ALWAYS_INFIX",-94;"RHSEND",-94;"RRPAREN",-94;"WITH",-94;"]",-94;"|]",-94];["(",20;"IDENT",59;"LITERAL",23;"[",88;"[|",7;"appExpr",170;"arrayExpr",24;"atomicExpr",139;"identExpr",25;"listExpr",26;"parenExpr",27;"qualificationExpr",129;"recdLiteralExpr",28;"revAppExpr",2;"revQualificationExpr",120;"{",126];[")",-95;"*",-95;"+",-95;",",-95;"-",-95;"->",-95;";",-95;"=",-95;"ALWAYS_INFIX",-95;"RHSEND",-95;"RRPAREN",-95;"WITH",-95;"]",-95;"|]",-95];[")",-96;";",-96;"RHSEND",-96;"RRPAREN",-96;"]",-96;"|]",-96];[")",-97;";",-97;"RHSEND",-97;"RRPAREN",-97;"]",-97;"|]",-97];[")",-98;";",-98;"RHSEND",-98;"RRPAREN",-98;"]",-98;"|]",-98]]
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
]
let unboxRoot =
    unbox<string list*Expr list>
let parser = ParseTable.from(rules, actions)