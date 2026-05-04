module FSharp.Substance.FSharpYacc
open FSharp.LexYacc
let stateSymbols: string[] = [|"";"file";"revAppExpr";"appType";"appType";"suffixType";"atomType";"[|";"revSequentialExpr";"opt_semicolon";"|]";"|]";"(";"typeArgument";")";"TYPAR";"longid";"<";"typeArguments";">";"(";")";"infix";")";"LITERAL";"arrayExpr";"identExpr";"listExpr";"parenExpr";"IDENT";":";"typeArgument";"parameterPattern";"revBinaryExpr";"tuplePattern";"letBinding";"valueExpr";"MODULE";"longid";"EOF";"revOpenOrLets";"opt_semicolon";"EOF";"funType";"->";"tupleType";"tupleType";"IDENT";"<";"typeArguments";">";"%";"&";"&&";"+";"+";"-";"-";"..";"/";"::";":?";":?>";"<<";"<>";"<|";"<||";"<|||";"=";">>";"@";"|>";"||";"||>";"|||";"|||>";"FUN";"parameterPattern";"->";"rhsBlock";"valueExpr";"RHSEND";"LET";"bindingPattern";"=";"rhsBlock";"valueExpr";"RHSEND";"[";"]";"revSequentialExpr";"opt_semicolon";"]";"revLongid";"OPEN";"longid";"letBinding";";";";";"(";"bindingPattern";")";"IDENT";"revSequentialExpr";"opt_semicolon";")";"!";"+";"-";"revQualificationExpr";".";"[";"tupleExpr";"]";"identExpr";"qualificationExpr";"qualificationExpr";"infix";"unaryExpr";"unaryExpr";"IDENT";".";"IDENT";"openOrLet";"openOrLet";"atomicExpr";"qualificationSuffix";"declExpr";"revSequentialExpr";"declExpr";"binaryExpr";"revTupleExpr";",";"binaryExpr";"LLPAREN";"opt_semicolon";"RRPAREN";"[";"]";"longid";"lambdaExpr";"atomicPattern";",";"atomicPattern";"*";"typeArgument";",";"typeArgument";"appExpr";"prefix";"appExpr";"lambdaExpr";"tupleExpr"|]
let actions: (string * int) list list = [["MODULE",37;"file",1];["",0];["%",-1;"&",-1;"&&",-1;"(",20;")",-1;"+",-1;",",-1;"-",-1;"..",-1;"/",-1;"::",-1;":?",-1;":?>",-1;";",-1;"<<",-1;"<>",-1;"<|",-1;"<||",-1;"<|||",-1;"=",-1;">>",-1;"@",-1;"IDENT",47;"LITERAL",24;"RHSEND",-1;"RRPAREN",-1;"[",88;"[|",7;"]",-1;"arrayExpr",25;"atomicExpr",125;"identExpr",26;"listExpr",27;"parenExpr",28;"qualificationExpr",116;"revQualificationExpr",109;"|>",-1;"|]",-1;"||",-1;"||>",-1;"|||",-1;"|||>",-1];[")",-93;"*",-93;",",-93;"->",-93;"=",-93;">",-93;"IDENT",120;"[",137;"longid",139;"revLongid",93;"suffixType",5];[")",-94;"*",-94;",",-94;"->",-94;"=",-94;">",-94;"IDENT",120;"[",137;"longid",139;"revLongid",93;"suffixType",5];[")",-2;"*",-2;",",-2;"->",-2;"=",-2;">",-2;"IDENT",-2;"[",-2];[")",-3;"*",-3;",",-3;"->",-3;"=",-3;">",-3;"IDENT",-3;"[",-3];["!",106;"(",20;"+",107;"-",108;"FUN",76;"IDENT",47;"LET",82;"LITERAL",24;"[",88;"[|",7;"appExpr",148;"arrayExpr",25;"atomicExpr",125;"binaryExpr",130;"declExpr",127;"identExpr",26;"lambdaExpr",151;"letBinding",35;"listExpr",27;"parenExpr",28;"prefix",149;"qualificationExpr",115;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",109;"revSequentialExpr",8;"revTupleExpr",131;"tupleExpr",152;"unaryExpr",119;"valueExpr",36;"|]",11];[";",98;"opt_semicolon",9;"|]",-61];["|]",10];["%",-4;"&",-4;"&&",-4;"(",-4;")",-4;"+",-4;",",-4;"-",-4;".",-4;"..",-4;"/",-4;"::",-4;":?",-4;":?>",-4;";",-4;"<<",-4;"<>",-4;"<|",-4;"<||",-4;"<|||",-4;"=",-4;">>",-4;"@",-4;"IDENT",-4;"LITERAL",-4;"RHSEND",-4;"RRPAREN",-4;"[",-4;"[|",-4;"]",-4;"|>",-4;"|]",-4;"||",-4;"||>",-4;"|||",-4;"|||>",-4];["%",-5;"&",-5;"&&",-5;"(",-5;")",-5;"+",-5;",",-5;"-",-5;".",-5;"..",-5;"/",-5;"::",-5;":?",-5;":?>",-5;";",-5;"<<",-5;"<>",-5;"<|",-5;"<||",-5;"<|||",-5;"=",-5;">>",-5;"@",-5;"IDENT",-5;"LITERAL",-5;"RHSEND",-5;"RRPAREN",-5;"[",-5;"[|",-5;"]",-5;"|>",-5;"|]",-5;"||",-5;"||>",-5;"|||",-5;"|||>",-5];["(",12;"IDENT",120;"TYPAR",15;"appType",3;"atomType",6;"funType",43;"longid",16;"revLongid",93;"tupleType",46;"typeArgument",13];[")",14];[")",-6;"*",-6;",",-6;"->",-6;"=",-6;">",-6;"IDENT",-6;"[",-6];[")",-7;"*",-7;",",-7;"->",-7;"=",-7;">",-7;"IDENT",-7;"[",-7];[")",-8;"*",-8;",",-8;"->",-8;"<",17;"=",-8;">",-8;"IDENT",-8;"[",-8];["(",12;"IDENT",120;"TYPAR",15;"appType",3;"atomType",6;"funType",43;"longid",16;"revLongid",93;"tupleType",46;"typeArgument",145;"typeArguments",18];[",",146;">",19];[")",-9;"*",-9;",",-9;"->",-9;"=",-9;">",-9;"IDENT",-9;"[",-9];["!",106;"%",51;"&",52;"&&",53;"(",20;")",21;"+",55;"-",57;"..",58;"/",59;"::",60;":?",61;":?>",62;"<<",63;"<>",64;"<|",65;"<||",66;"<|||",67;"=",68;">>",69;"@",70;"FUN",76;"IDENT",47;"LET",82;"LITERAL",24;"[",88;"[|",7;"appExpr",148;"arrayExpr",25;"atomicExpr",125;"binaryExpr",130;"declExpr",127;"identExpr",26;"infix",22;"lambdaExpr",151;"letBinding",35;"listExpr",27;"parenExpr",28;"prefix",149;"qualificationExpr",115;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",109;"revSequentialExpr",103;"revTupleExpr",131;"tupleExpr",152;"unaryExpr",119;"valueExpr",36;"|>",71;"||",72;"||>",73;"|||",74;"|||>",75];["%",-10;"&",-10;"&&",-10;"(",-10;")",-10;"+",-10;",",-10;"-",-10;".",-10;"..",-10;"/",-10;"::",-10;":?",-10;":?>",-10;";",-10;"<<",-10;"<>",-10;"<|",-10;"<||",-10;"<|||",-10;"=",-10;">>",-10;"@",-10;"IDENT",-10;"LITERAL",-10;"RHSEND",-10;"RRPAREN",-10;"[",-10;"[|",-10;"]",-10;"|>",-10;"|]",-10;"||",-10;"||>",-10;"|||",-10;"|||>",-10];[")",23];["%",-11;"&",-11;"&&",-11;"(",-11;")",-11;"+",-11;",",-11;"-",-11;".",-11;"..",-11;"/",-11;"::",-11;":?",-11;":?>",-11;";",-11;"<<",-11;"<>",-11;"<|",-11;"<||",-11;"<|||",-11;"=",-11;">>",-11;"@",-11;"IDENT",-11;"LITERAL",-11;"RHSEND",-11;"RRPAREN",-11;"[",-11;"[|",-11;"]",-11;"|>",-11;"|]",-11;"||",-11;"||>",-11;"|||",-11;"|||>",-11];["%",-12;"&",-12;"&&",-12;"(",-12;")",-12;"+",-12;",",-12;"-",-12;".",-12;"..",-12;"/",-12;"::",-12;":?",-12;":?>",-12;";",-12;"<<",-12;"<>",-12;"<|",-12;"<||",-12;"<|||",-12;"=",-12;">>",-12;"@",-12;"IDENT",-12;"LITERAL",-12;"RHSEND",-12;"RRPAREN",-12;"[",-12;"[|",-12;"]",-12;"|>",-12;"|]",-12;"||",-12;"||>",-12;"|||",-12;"|||>",-12];["%",-13;"&",-13;"&&",-13;"(",-13;")",-13;"+",-13;",",-13;"-",-13;".",-13;"..",-13;"/",-13;"::",-13;":?",-13;":?>",-13;";",-13;"<<",-13;"<>",-13;"<|",-13;"<||",-13;"<|||",-13;"=",-13;">>",-13;"@",-13;"IDENT",-13;"LITERAL",-13;"RHSEND",-13;"RRPAREN",-13;"[",-13;"[|",-13;"]",-13;"|>",-13;"|]",-13;"||",-13;"||>",-13;"|||",-13;"|||>",-13];["%",-14;"&",-14;"&&",-14;"(",-14;")",-14;"+",-14;",",-14;"-",-14;".",-14;"..",-14;"/",-14;"::",-14;":?",-14;":?>",-14;";",-14;"<<",-14;"<>",-14;"<|",-14;"<||",-14;"<|||",-14;"=",-14;">>",-14;"@",-14;"IDENT",-14;"LITERAL",-14;"RHSEND",-14;"RRPAREN",-14;"[",-14;"[|",-14;"]",-14;"|>",-14;"|]",-14;"||",-14;"||>",-14;"|||",-14;"|||>",-14];["%",-15;"&",-15;"&&",-15;"(",-15;")",-15;"+",-15;",",-15;"-",-15;".",-15;"..",-15;"/",-15;"::",-15;":?",-15;":?>",-15;";",-15;"<<",-15;"<>",-15;"<|",-15;"<||",-15;"<|||",-15;"=",-15;">>",-15;"@",-15;"IDENT",-15;"LITERAL",-15;"RHSEND",-15;"RRPAREN",-15;"[",-15;"[|",-15;"]",-15;"|>",-15;"|]",-15;"||",-15;"||>",-15;"|||",-15;"|||>",-15];["%",-16;"&",-16;"&&",-16;"(",-16;")",-16;"+",-16;",",-16;"-",-16;".",-16;"..",-16;"/",-16;"::",-16;":?",-16;":?>",-16;";",-16;"<<",-16;"<>",-16;"<|",-16;"<||",-16;"<|||",-16;"=",-16;">>",-16;"@",-16;"IDENT",-16;"LITERAL",-16;"RHSEND",-16;"RRPAREN",-16;"[",-16;"[|",-16;"]",-16;"|>",-16;"|]",-16;"||",-16;"||>",-16;"|||",-16;"|||>",-16];[")",-64;",",-64;":",30;"=",-64];["(",12;"IDENT",120;"TYPAR",15;"appType",3;"atomType",6;"funType",43;"longid",16;"revLongid",93;"tupleType",46;"typeArgument",31];[")",-17;",",-17;"=",-17];[")",-18;",",-18;"=",-18];["%",51;"&",52;"&&",53;")",-19;"+",54;",",-19;"-",56;"..",58;"/",59;"::",60;":?",61;":?>",62;";",-19;"<<",63;"<>",64;"<|",65;"<||",66;"<|||",67;"=",68;">>",69;"@",70;"RHSEND",-19;"RRPAREN",-19;"]",-19;"infix",117;"|>",71;"|]",-19;"||",72;"||>",73;"|||",74;"|||>",75];[")",-20;",",142;"=",-20];[")",-21;";",-21;"RRPAREN",-21;"]",-21;"|]",-21];[")",-22;";",-22;"RRPAREN",-22;"]",-22;"|]",-22];["IDENT",120;"longid",38;"revLongid",93];["EOF",39;"LET",82;"OPEN",94;"letBinding",96;"openOrLet",123;"revOpenOrLets",40];["",-23];[";",97;"EOF",-61;"opt_semicolon",41];["EOF",42];["",-24];[")",-95;",",-95;"->",44;"=",-95;">",-95];["(",12;"IDENT",120;"TYPAR",15;"appType",3;"atomType",6;"longid",16;"revLongid",93;"tupleType",45];[")",-25;"*",144;",",-25;"->",-25;"=",-25;">",-25];[")",-26;"*",144;",",-26;"->",-26;"=",-26;">",-26];["%",-27;"&",-27;"&&",-27;"(",-27;")",-27;"+",-27;",",-27;"-",-27;".",-27;"..",-27;"/",-27;"::",-27;":?",-27;":?>",-27;";",-27;"<",48;"<<",-27;"<>",-27;"<|",-27;"<||",-27;"<|||",-27;"=",-27;">>",-27;"@",-27;"IDENT",-27;"LITERAL",-27;"RHSEND",-27;"RRPAREN",-27;"[",-27;"[|",-27;"]",-27;"|>",-27;"|]",-27;"||",-27;"||>",-27;"|||",-27;"|||>",-27];["(",12;"IDENT",120;"TYPAR",15;"appType",3;"atomType",6;"funType",43;"longid",16;"revLongid",93;"tupleType",46;"typeArgument",145;"typeArguments",49];[",",146;">",50];["%",-28;"&",-28;"&&",-28;"(",-28;")",-28;"+",-28;",",-28;"-",-28;".",-28;"..",-28;"/",-28;"::",-28;":?",-28;":?>",-28;";",-28;"<<",-28;"<>",-28;"<|",-28;"<||",-28;"<|||",-28;"=",-28;">>",-28;"@",-28;"IDENT",-28;"LITERAL",-28;"RHSEND",-28;"RRPAREN",-28;"[",-28;"[|",-28;"]",-28;"|>",-28;"|]",-28;"||",-28;"||>",-28;"|||",-28;"|||>",-28];["!",-29;"(",-29;")",-29;"+",-29;"-",-29;"IDENT",-29;"LITERAL",-29;"[",-29;"[|",-29];["!",-30;"(",-30;")",-30;"+",-30;"-",-30;"IDENT",-30;"LITERAL",-30;"[",-30;"[|",-30];["!",-31;"(",-31;")",-31;"+",-31;"-",-31;"IDENT",-31;"LITERAL",-31;"[",-31;"[|",-31];["!",-32;"(",-32;"+",-32;"-",-32;"IDENT",-32;"LITERAL",-32;"[",-32;"[|",-32];["(",-67;")",-32;"IDENT",-67;"LITERAL",-67;"[",-67;"[|",-67];["!",-33;"(",-33;"+",-33;"-",-33;"IDENT",-33;"LITERAL",-33;"[",-33;"[|",-33];["(",-68;")",-33;"IDENT",-68;"LITERAL",-68;"[",-68;"[|",-68];["!",-34;"(",-34;")",-34;"+",-34;"-",-34;"IDENT",-34;"LITERAL",-34;"[",-34;"[|",-34];["!",-35;"(",-35;")",-35;"+",-35;"-",-35;"IDENT",-35;"LITERAL",-35;"[",-35;"[|",-35];["!",-36;"(",-36;")",-36;"+",-36;"-",-36;"IDENT",-36;"LITERAL",-36;"[",-36;"[|",-36];["!",-37;"(",-37;")",-37;"+",-37;"-",-37;"IDENT",-37;"LITERAL",-37;"[",-37;"[|",-37];["!",-38;"(",-38;")",-38;"+",-38;"-",-38;"IDENT",-38;"LITERAL",-38;"[",-38;"[|",-38];["!",-39;"(",-39;")",-39;"+",-39;"-",-39;"IDENT",-39;"LITERAL",-39;"[",-39;"[|",-39];["!",-40;"(",-40;")",-40;"+",-40;"-",-40;"IDENT",-40;"LITERAL",-40;"[",-40;"[|",-40];["!",-41;"(",-41;")",-41;"+",-41;"-",-41;"IDENT",-41;"LITERAL",-41;"[",-41;"[|",-41];["!",-42;"(",-42;")",-42;"+",-42;"-",-42;"IDENT",-42;"LITERAL",-42;"[",-42;"[|",-42];["!",-43;"(",-43;")",-43;"+",-43;"-",-43;"IDENT",-43;"LITERAL",-43;"[",-43;"[|",-43];["!",-44;"(",-44;")",-44;"+",-44;"-",-44;"IDENT",-44;"LITERAL",-44;"[",-44;"[|",-44];["!",-45;"(",-45;")",-45;"+",-45;"-",-45;"IDENT",-45;"LITERAL",-45;"[",-45;"[|",-45];["!",-46;"(",-46;")",-46;"+",-46;"-",-46;"IDENT",-46;"LITERAL",-46;"[",-46;"[|",-46];["!",-47;"(",-47;")",-47;"+",-47;"-",-47;"IDENT",-47;"LITERAL",-47;"[",-47;"[|",-47];["!",-48;"(",-48;")",-48;"+",-48;"-",-48;"IDENT",-48;"LITERAL",-48;"[",-48;"[|",-48];["!",-49;"(",-49;")",-49;"+",-49;"-",-49;"IDENT",-49;"LITERAL",-49;"[",-49;"[|",-49];["!",-50;"(",-50;")",-50;"+",-50;"-",-50;"IDENT",-50;"LITERAL",-50;"[",-50;"[|",-50];["!",-51;"(",-51;")",-51;"+",-51;"-",-51;"IDENT",-51;"LITERAL",-51;"[",-51;"[|",-51];["(",99;"IDENT",102;"parameterPattern",77];["->",78];["!",106;"(",20;"+",107;"-",108;"FUN",76;"IDENT",47;"LITERAL",24;"LLPAREN",134;"[",88;"[|",7;"appExpr",148;"arrayExpr",25;"atomicExpr",125;"binaryExpr",130;"identExpr",26;"lambdaExpr",151;"listExpr",27;"parenExpr",28;"prefix",149;"qualificationExpr",115;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",109;"revTupleExpr",131;"rhsBlock",79;"tupleExpr",152;"unaryExpr",119;"valueExpr",80];[")",-52;";",-52;"RHSEND",-52;"RRPAREN",-52;"]",-52;"|]",-52];["RHSEND",81];[")",-53;";",-53;"RHSEND",-53;"RRPAREN",-53;"]",-53;"|]",-53];["(",99;"IDENT",29;"atomicPattern",141;"bindingPattern",83;"parameterPattern",32;"tuplePattern",34];["=",84];["!",106;"(",20;"+",107;"-",108;"FUN",76;"IDENT",47;"LITERAL",24;"LLPAREN",134;"[",88;"[|",7;"appExpr",148;"arrayExpr",25;"atomicExpr",125;"binaryExpr",130;"identExpr",26;"lambdaExpr",151;"listExpr",27;"parenExpr",28;"prefix",149;"qualificationExpr",115;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",109;"revTupleExpr",131;"rhsBlock",85;"tupleExpr",152;"unaryExpr",119;"valueExpr",86];[")",-54;";",-54;"EOF",-54;"RRPAREN",-54;"]",-54;"|]",-54];["RHSEND",87];[")",-55;";",-55;"EOF",-55;"RRPAREN",-55;"]",-55;"|]",-55];["!",106;"(",20;"+",107;"-",108;"FUN",76;"IDENT",47;"LET",82;"LITERAL",24;"[",88;"[|",7;"]",89;"appExpr",148;"arrayExpr",25;"atomicExpr",125;"binaryExpr",130;"declExpr",127;"identExpr",26;"lambdaExpr",151;"letBinding",35;"listExpr",27;"parenExpr",28;"prefix",149;"qualificationExpr",115;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",109;"revSequentialExpr",90;"revTupleExpr",131;"tupleExpr",152;"unaryExpr",119;"valueExpr",36];["%",-56;"&",-56;"&&",-56;"(",-56;")",-56;"+",-56;",",-56;"-",-56;".",-56;"..",-56;"/",-56;"::",-56;":?",-56;":?>",-56;";",-56;"<<",-56;"<>",-56;"<|",-56;"<||",-56;"<|||",-56;"=",-56;">>",-56;"@",-56;"IDENT",-56;"LITERAL",-56;"RHSEND",-56;"RRPAREN",-56;"[",-56;"[|",-56;"]",-56;"|>",-56;"|]",-56;"||",-56;"||>",-56;"|||",-56;"|||>",-56];[";",98;"]",-61;"opt_semicolon",91];["]",92];["%",-57;"&",-57;"&&",-57;"(",-57;")",-57;"+",-57;",",-57;"-",-57;".",-57;"..",-57;"/",-57;"::",-57;":?",-57;":?>",-57;";",-57;"<<",-57;"<>",-57;"<|",-57;"<||",-57;"<|||",-57;"=",-57;">>",-57;"@",-57;"IDENT",-57;"LITERAL",-57;"RHSEND",-57;"RRPAREN",-57;"[",-57;"[|",-57;"]",-57;"|>",-57;"|]",-57;"||",-57;"||>",-57;"|||",-57;"|||>",-57];[")",-58;"*",-58;",",-58;"->",-58;".",121;";",-58;"<",-58;"=",-58;">",-58;"EOF",-58;"IDENT",-58;"LET",-58;"OPEN",-58;"[",-58];["IDENT",120;"longid",95;"revLongid",93];[";",-59;"EOF",-59];[";",-60;"EOF",-60];["EOF",-62;"LET",82;"OPEN",94;"letBinding",96;"openOrLet",124];["!",106;"(",20;")",-62;"+",107;"-",108;"FUN",76;"IDENT",47;"LET",82;"LITERAL",24;"RRPAREN",-62;"[",88;"[|",7;"]",-62;"appExpr",148;"arrayExpr",25;"atomicExpr",125;"binaryExpr",130;"declExpr",129;"identExpr",26;"lambdaExpr",151;"letBinding",35;"listExpr",27;"parenExpr",28;"prefix",149;"qualificationExpr",115;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",109;"revTupleExpr",131;"tupleExpr",152;"unaryExpr",119;"valueExpr",36;"|]",-62];["(",99;"IDENT",29;"atomicPattern",141;"bindingPattern",100;"parameterPattern",32;"tuplePattern",34];[")",101];[")",-63;",",-63;"->",-63;"=",-63];["->",-64];[")",-61;";",98;"opt_semicolon",104];[")",105];["%",-65;"&",-65;"&&",-65;"(",-65;")",-65;"+",-65;",",-65;"-",-65;".",-65;"..",-65;"/",-65;"::",-65;":?",-65;":?>",-65;";",-65;"<<",-65;"<>",-65;"<|",-65;"<||",-65;"<|||",-65;"=",-65;">>",-65;"@",-65;"IDENT",-65;"LITERAL",-65;"RHSEND",-65;"RRPAREN",-65;"[",-65;"[|",-65;"]",-65;"|>",-65;"|]",-65;"||",-65;"||>",-65;"|||",-65;"|||>",-65];["(",-66;"IDENT",-66;"LITERAL",-66;"[",-66;"[|",-66];["(",-67;"IDENT",-67;"LITERAL",-67;"[",-67;"[|",-67];["(",-68;"IDENT",-68;"LITERAL",-68;"[",-68;"[|",-68];["%",-69;"&",-69;"&&",-69;"(",-69;")",-69;"+",-69;",",-69;"-",-69;".",110;"..",-69;"/",-69;"::",-69;":?",-69;":?>",-69;";",-69;"<<",-69;"<>",-69;"<|",-69;"<||",-69;"<|||",-69;"=",-69;">>",-69;"@",-69;"IDENT",-69;"LITERAL",-69;"RHSEND",-69;"RRPAREN",-69;"[",-69;"[|",-69;"]",-69;"qualificationSuffix",126;"|>",-69;"|]",-69;"||",-69;"||>",-69;"|||",-69;"|||>",-69];["IDENT",47;"[",111;"identExpr",114];["!",106;"(",20;"+",107;"-",108;"IDENT",47;"LITERAL",24;"[",88;"[|",7;"appExpr",148;"arrayExpr",25;"atomicExpr",125;"binaryExpr",130;"identExpr",26;"listExpr",27;"parenExpr",28;"prefix",149;"qualificationExpr",115;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",109;"revTupleExpr",131;"tupleExpr",112;"unaryExpr",119];["]",113];["%",-70;"&",-70;"&&",-70;"(",-70;")",-70;"+",-70;",",-70;"-",-70;".",-70;"..",-70;"/",-70;"::",-70;":?",-70;":?>",-70;";",-70;"<<",-70;"<>",-70;"<|",-70;"<||",-70;"<|||",-70;"=",-70;">>",-70;"@",-70;"IDENT",-70;"LITERAL",-70;"RHSEND",-70;"RRPAREN",-70;"[",-70;"[|",-70;"]",-70;"|>",-70;"|]",-70;"||",-70;"||>",-70;"|||",-70;"|||>",-70];["%",-71;"&",-71;"&&",-71;"(",-71;")",-71;"+",-71;",",-71;"-",-71;".",-71;"..",-71;"/",-71;"::",-71;":?",-71;":?>",-71;";",-71;"<<",-71;"<>",-71;"<|",-71;"<||",-71;"<|||",-71;"=",-71;">>",-71;"@",-71;"IDENT",-71;"LITERAL",-71;"RHSEND",-71;"RRPAREN",-71;"[",-71;"[|",-71;"]",-71;"|>",-71;"|]",-71;"||",-71;"||>",-71;"|||",-71;"|||>",-71];["%",-72;"&",-72;"&&",-72;"(",-72;")",-72;"+",-72;",",-72;"-",-72;"..",-72;"/",-72;"::",-72;":?",-72;":?>",-72;";",-72;"<<",-72;"<>",-72;"<|",-72;"<||",-72;"<|||",-72;"=",-72;">>",-72;"@",-72;"IDENT",-72;"LITERAL",-72;"RHSEND",-72;"RRPAREN",-72;"[",-72;"[|",-72;"]",-72;"|>",-72;"|]",-72;"||",-72;"||>",-72;"|||",-72;"|||>",-72];["%",-73;"&",-73;"&&",-73;"(",-73;")",-73;"+",-73;",",-73;"-",-73;"..",-73;"/",-73;"::",-73;":?",-73;":?>",-73;";",-73;"<<",-73;"<>",-73;"<|",-73;"<||",-73;"<|||",-73;"=",-73;">>",-73;"@",-73;"IDENT",-73;"LITERAL",-73;"RHSEND",-73;"RRPAREN",-73;"[",-73;"[|",-73;"]",-73;"|>",-73;"|]",-73;"||",-73;"||>",-73;"|||",-73;"|||>",-73];["!",106;"(",20;"+",107;"-",108;"IDENT",47;"LITERAL",24;"[",88;"[|",7;"appExpr",148;"arrayExpr",25;"atomicExpr",125;"identExpr",26;"listExpr",27;"parenExpr",28;"prefix",149;"qualificationExpr",115;"revAppExpr",2;"revQualificationExpr",109;"unaryExpr",118];["%",-74;"&",-74;"&&",-74;")",-74;"+",-74;",",-74;"-",-74;"..",-74;"/",-74;"::",-74;":?",-74;":?>",-74;";",-74;"<<",-74;"<>",-74;"<|",-74;"<||",-74;"<|||",-74;"=",-74;">>",-74;"@",-74;"RHSEND",-74;"RRPAREN",-74;"]",-74;"|>",-74;"|]",-74;"||",-74;"||>",-74;"|||",-74;"|||>",-74];["%",-75;"&",-75;"&&",-75;")",-75;"+",-75;",",-75;"-",-75;"..",-75;"/",-75;"::",-75;":?",-75;":?>",-75;";",-75;"<<",-75;"<>",-75;"<|",-75;"<||",-75;"<|||",-75;"=",-75;">>",-75;"@",-75;"RHSEND",-75;"RRPAREN",-75;"]",-75;"|>",-75;"|]",-75;"||",-75;"||>",-75;"|||",-75;"|||>",-75];[")",-76;"*",-76;",",-76;"->",-76;".",-76;";",-76;"<",-76;"=",-76;">",-76;"EOF",-76;"IDENT",-76;"LET",-76;"OPEN",-76;"[",-76];["IDENT",122];[")",-77;"*",-77;",",-77;"->",-77;".",-77;";",-77;"<",-77;"=",-77;">",-77;"EOF",-77;"IDENT",-77;"LET",-77;"OPEN",-77;"[",-77];[";",-78;"EOF",-78];[";",-79;"EOF",-79];["%",-80;"&",-80;"&&",-80;"(",-80;")",-80;"+",-80;",",-80;"-",-80;".",-80;"..",-80;"/",-80;"::",-80;":?",-80;":?>",-80;";",-80;"<<",-80;"<>",-80;"<|",-80;"<||",-80;"<|||",-80;"=",-80;">>",-80;"@",-80;"IDENT",-80;"LITERAL",-80;"RHSEND",-80;"RRPAREN",-80;"[",-80;"[|",-80;"]",-80;"|>",-80;"|]",-80;"||",-80;"||>",-80;"|||",-80;"|||>",-80];["%",-81;"&",-81;"&&",-81;"(",-81;")",-81;"+",-81;",",-81;"-",-81;".",-81;"..",-81;"/",-81;"::",-81;":?",-81;":?>",-81;";",-81;"<<",-81;"<>",-81;"<|",-81;"<||",-81;"<|||",-81;"=",-81;">>",-81;"@",-81;"IDENT",-81;"LITERAL",-81;"RHSEND",-81;"RRPAREN",-81;"[",-81;"[|",-81;"]",-81;"|>",-81;"|]",-81;"||",-81;"||>",-81;"|||",-81;"|||>",-81];[")",-82;";",-82;"RRPAREN",-82;"]",-82;"|]",-82];[";",98;"RRPAREN",-61;"opt_semicolon",135];[")",-83;";",-83;"RRPAREN",-83;"]",-83;"|]",-83];[")",-84;",",-84;";",-84;"RHSEND",-84;"RRPAREN",-84;"]",-84;"|]",-84];[")",-89;",",132;";",-89;"RHSEND",-89;"RRPAREN",-89;"]",-89;"|]",-89];["!",106;"(",20;"+",107;"-",108;"FUN",76;"IDENT",47;"LITERAL",24;"[",88;"[|",7;"appExpr",148;"arrayExpr",25;"atomicExpr",125;"binaryExpr",133;"identExpr",26;"lambdaExpr",140;"listExpr",27;"parenExpr",28;"prefix",149;"qualificationExpr",115;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",109;"unaryExpr",119];[")",-85;",",-85;";",-85;"RHSEND",-85;"RRPAREN",-85;"]",-85;"|]",-85];["!",106;"(",20;"+",107;"-",108;"FUN",76;"IDENT",47;"LET",82;"LITERAL",24;"[",88;"[|",7;"appExpr",148;"arrayExpr",25;"atomicExpr",125;"binaryExpr",130;"declExpr",127;"identExpr",26;"lambdaExpr",151;"letBinding",35;"listExpr",27;"parenExpr",28;"prefix",149;"qualificationExpr",115;"revAppExpr",2;"revBinaryExpr",33;"revQualificationExpr",109;"revSequentialExpr",128;"revTupleExpr",131;"tupleExpr",152;"unaryExpr",119;"valueExpr",36];["RRPAREN",136];[")",-86;";",-86;"EOF",-86;"RHSEND",-86;"RRPAREN",-86;"]",-86;"|]",-86];["]",138];[")",-87;"*",-87;",",-87;"->",-87;"=",-87;">",-87;"IDENT",-87;"[",-87];[")",-88;"*",-88;",",-88;"->",-88;"=",-88;">",-88;"IDENT",-88;"[",-88];[")",-90;";",-90;"RHSEND",-90;"RRPAREN",-90;"]",-90;"|]",-90];[")",-91;",",-91;"=",-91];["(",99;"IDENT",29;"atomicPattern",143;"parameterPattern",32];[")",-92;",",-92;"=",-92];["(",12;"IDENT",120;"TYPAR",15;"appType",4;"atomType",6;"longid",16;"revLongid",93];[",",-96;">",-96];["(",12;"IDENT",120;"TYPAR",15;"appType",3;"atomType",6;"funType",43;"longid",16;"revLongid",93;"tupleType",46;"typeArgument",147];[",",-97;">",-97];["%",-98;"&",-98;"&&",-98;")",-98;"+",-98;",",-98;"-",-98;"..",-98;"/",-98;"::",-98;":?",-98;":?>",-98;";",-98;"<<",-98;"<>",-98;"<|",-98;"<||",-98;"<|||",-98;"=",-98;">>",-98;"@",-98;"RHSEND",-98;"RRPAREN",-98;"]",-98;"|>",-98;"|]",-98;"||",-98;"||>",-98;"|||",-98;"|||>",-98];["(",20;"IDENT",47;"LITERAL",24;"[",88;"[|",7;"appExpr",150;"arrayExpr",25;"atomicExpr",125;"identExpr",26;"listExpr",27;"parenExpr",28;"qualificationExpr",115;"revAppExpr",2;"revQualificationExpr",109];["%",-99;"&",-99;"&&",-99;")",-99;"+",-99;",",-99;"-",-99;"..",-99;"/",-99;"::",-99;":?",-99;":?>",-99;";",-99;"<<",-99;"<>",-99;"<|",-99;"<||",-99;"<|||",-99;"=",-99;">>",-99;"@",-99;"RHSEND",-99;"RRPAREN",-99;"]",-99;"|>",-99;"|]",-99;"||",-99;"||>",-99;"|||",-99;"|||>",-99];[")",-100;";",-100;"RHSEND",-100;"RRPAREN",-100;"]",-100;"|]",-100];[")",-101;";",-101;"RHSEND",-101;"RRPAREN",-101;"]",-101;"|]",-101]]
let rules: list<string list*(obj list->obj)> = [
    ["";"file"], (fun (ss:obj list) -> ss.[0])
    ["appExpr";"revAppExpr"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let result:option<int>*Expr =
            Expr.ofAppExpr s0
        box result)
    ["appType";"appType";"suffixType"], (fun(ss:obj list)->
        let s0 = unbox<(option<int> * TypeArgument)*((option<int> * SuffixType) list)> ss.[0]
        let s1 = unbox<option<int>*SuffixType> ss.[1]
        let result:(option<int> * TypeArgument)*((option<int> * SuffixType) list) =
            let hd,tl = s0
            hd,s1::tl 
        box result)
    ["appType";"atomType"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*TypeArgument> ss.[0]
        let result:(option<int> * TypeArgument)*((option<int> * SuffixType) list) =
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
    ["infix";"%"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "%"
        box result)
    ["infix";"&"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "&"
        box result)
    ["infix";"&&"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "&&"
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
    ["infix";".."], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, ".."
        box result)
    ["infix";"/"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "/"
        box result)
    ["infix";"::"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "::"
        box result)
    ["infix";":?"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, ":?"
        box result)
    ["infix";":?>"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, ":?>"
        box result)
    ["infix";"<<"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "<<"
        box result)
    ["infix";"<>"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "<>"
        box result)
    ["infix";"<|"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "<|"
        box result)
    ["infix";"<||"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "<||"
        box result)
    ["infix";"<|||"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "<|||"
        box result)
    ["infix";"="], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "="
        box result)
    ["infix";">>"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, ">>"
        box result)
    ["infix";"@"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "@"
        box result)
    ["infix";"|>"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "|>"
        box result)
    ["infix";"||"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "||"
        box result)
    ["infix";"||>"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "||>"
        box result)
    ["infix";"|||"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "|||"
        box result)
    ["infix";"|||>"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "|||>"
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
        let s0 = unbox<(option<int> * TypeArgument)*((option<int> * SuffixType) list)> ss.[0]
        let result:(option<int>*TypeArgument) list =
            [TypeArgument.ofApp s0]
        box result)
    ["tupleType";"tupleType";"*";"appType"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*TypeArgument) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int> * TypeArgument)*((option<int> * SuffixType) list)> ss.[2]
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