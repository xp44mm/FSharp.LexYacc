module FSharp.Substance.FSharpYacc
open FSharp.LexYacc
let stateSymbols: string[] = [|"";"file";"revAppExpr";"appType";"appType";"suffixType";"atomType";"[|";"sequentialExpr";"|]";"|]";"(";"typeArgument";")";"TYPAR";"longid";"<";"typeArguments";">";"(";")";"infix";")";"IDENT";"<";"typeArguments";">";"LITERAL";"arrayExpr";"listExpr";"parenExpr";"IDENT";":";"typeArgument";"parameterPattern";"revBinaryExpr";"tuplePattern";"DUMMY";"OPEN";"longid";"letBinding";"valueExpr";"MODULE";"longid";"rhsBlock";"EOF";"funType";"->";"tupleType";"tupleType";"%";"&";"&&";"+";"+";"-";"-";"..";"/";"::";":?";":?>";"<<";"<>";"<|";"<||";"<|||";"=";">>";"@";"|>";"||";"||>";"|||";"|||>";"FUN";"parameterPattern";"->";"rhsBlock";"valueExpr";"RHSEND";"LET";"bindingPattern";"=";"rhsBlock";"valueExpr";"RHSEND";"[";"]";"sequentialExpr";"]";"revLongid";"(";"bindingPattern";")";"IDENT";"sequentialExpr";")";"!";"+";"-";"revQualificationExpr";".";"IDENT";"<";"typeArguments";">";"[";"tupleExpr";"]";"qualificationExpr";"qualificationExpr";"infix";"unaryExpr";"unaryExpr";"IDENT";".";"IDENT";"atomicExpr";"qualificationSuffix";"declExpr";"revSequentialExpr";";";"declExpr";"binaryExpr";"revTupleExpr";",";"binaryExpr";"LLPAREN";"sequentialExpr";"RRPAREN";"[";"]";"longid";"lambdaExpr";"atomicPattern";",";"atomicPattern";"*";"typeArgument";",";"typeArgument";"appExpr";"prifix";"appExpr";"lambdaExpr";"tupleExpr"|]
let actions: (string * int) list list = [["MODULE",42;"file",1];["",0];["%",-1;"&",-1;"&&",-1;"(",19;")",-1;"+",-1;",",-1;"-",-1;"..",-1;"/",-1;"::",-1;":?",-1;":?>",-1;";",-1;"<<",-1;"<>",-1;"<|",-1;"<||",-1;"<|||",-1;"=",-1;">>",-1;"@",-1;"IDENT",23;"LITERAL",27;"RHSEND",-1;"RRPAREN",-1;"[",87;"[|",7;"]",-1;"arrayExpr",28;"atomicExpr",118;"listExpr",29;"parenExpr",30;"qualificationExpr",111;"revQualificationExpr",101;"|>",-1;"|]",-1;"||",-1;"||>",-1;"|||",-1;"|||>",-1];[")",-89;"*",-89;",",-89;"->",-89;"=",-89;">",-89;"IDENT",115;"[",131;"longid",133;"revLongid",91;"suffixType",5];[")",-90;"*",-90;",",-90;"->",-90;"=",-90;">",-90;"IDENT",115;"[",131;"longid",133;"revLongid",91;"suffixType",5];[")",-2;"*",-2;",",-2;"->",-2;"=",-2;">",-2;"IDENT",-2;"[",-2];[")",-3;"*",-3;",",-3;"->",-3;"=",-3;">",-3;"IDENT",-3;"[",-3];["!",98;"(",19;"+",99;"-",100;"DUMMY",37;"FUN",75;"IDENT",23;"LET",81;"LITERAL",27;"OPEN",38;"[",87;"[|",7;"appExpr",142;"arrayExpr",28;"atomicExpr",118;"binaryExpr",124;"declExpr",120;"lambdaExpr",145;"letBinding",40;"listExpr",29;"parenExpr",30;"prifix",143;"qualificationExpr",110;"revAppExpr",2;"revBinaryExpr",35;"revQualificationExpr",101;"revSequentialExpr",121;"revTupleExpr",125;"sequentialExpr",8;"tupleExpr",146;"unaryExpr",114;"valueExpr",41;"|]",10];["|]",9];["%",-4;"&",-4;"&&",-4;"(",-4;")",-4;"+",-4;",",-4;"-",-4;".",-4;"..",-4;"/",-4;"::",-4;":?",-4;":?>",-4;";",-4;"<<",-4;"<>",-4;"<|",-4;"<||",-4;"<|||",-4;"=",-4;">>",-4;"@",-4;"IDENT",-4;"LITERAL",-4;"RHSEND",-4;"RRPAREN",-4;"[",-4;"[|",-4;"]",-4;"|>",-4;"|]",-4;"||",-4;"||>",-4;"|||",-4;"|||>",-4];["%",-5;"&",-5;"&&",-5;"(",-5;")",-5;"+",-5;",",-5;"-",-5;".",-5;"..",-5;"/",-5;"::",-5;":?",-5;":?>",-5;";",-5;"<<",-5;"<>",-5;"<|",-5;"<||",-5;"<|||",-5;"=",-5;">>",-5;"@",-5;"IDENT",-5;"LITERAL",-5;"RHSEND",-5;"RRPAREN",-5;"[",-5;"[|",-5;"]",-5;"|>",-5;"|]",-5;"||",-5;"||>",-5;"|||",-5;"|||>",-5];["(",11;"IDENT",115;"TYPAR",14;"appType",3;"atomType",6;"funType",46;"longid",15;"revLongid",91;"tupleType",49;"typeArgument",12];[")",13];[")",-6;"*",-6;",",-6;"->",-6;"=",-6;">",-6;"IDENT",-6;"[",-6];[")",-7;"*",-7;",",-7;"->",-7;"=",-7;">",-7;"IDENT",-7;"[",-7];[")",-8;"*",-8;",",-8;"->",-8;"<",16;"=",-8;">",-8;"IDENT",-8;"[",-8];["(",11;"IDENT",115;"TYPAR",14;"appType",3;"atomType",6;"funType",46;"longid",15;"revLongid",91;"tupleType",49;"typeArgument",139;"typeArguments",17];[",",140;">",18];[")",-9;"*",-9;",",-9;"->",-9;"=",-9;">",-9;"IDENT",-9;"[",-9];["!",98;"%",50;"&",51;"&&",52;"(",19;")",20;"+",54;"-",56;"..",57;"/",58;"::",59;":?",60;":?>",61;"<<",62;"<>",63;"<|",64;"<||",65;"<|||",66;"=",67;">>",68;"@",69;"DUMMY",37;"FUN",75;"IDENT",23;"LET",81;"LITERAL",27;"OPEN",38;"[",87;"[|",7;"appExpr",142;"arrayExpr",28;"atomicExpr",118;"binaryExpr",124;"declExpr",120;"infix",21;"lambdaExpr",145;"letBinding",40;"listExpr",29;"parenExpr",30;"prifix",143;"qualificationExpr",110;"revAppExpr",2;"revBinaryExpr",35;"revQualificationExpr",101;"revSequentialExpr",121;"revTupleExpr",125;"sequentialExpr",96;"tupleExpr",146;"unaryExpr",114;"valueExpr",41;"|>",70;"||",71;"||>",72;"|||",73;"|||>",74];["%",-10;"&",-10;"&&",-10;"(",-10;")",-10;"+",-10;",",-10;"-",-10;".",-10;"..",-10;"/",-10;"::",-10;":?",-10;":?>",-10;";",-10;"<<",-10;"<>",-10;"<|",-10;"<||",-10;"<|||",-10;"=",-10;">>",-10;"@",-10;"IDENT",-10;"LITERAL",-10;"RHSEND",-10;"RRPAREN",-10;"[",-10;"[|",-10;"]",-10;"|>",-10;"|]",-10;"||",-10;"||>",-10;"|||",-10;"|||>",-10];[")",22];["%",-11;"&",-11;"&&",-11;"(",-11;")",-11;"+",-11;",",-11;"-",-11;".",-11;"..",-11;"/",-11;"::",-11;":?",-11;":?>",-11;";",-11;"<<",-11;"<>",-11;"<|",-11;"<||",-11;"<|||",-11;"=",-11;">>",-11;"@",-11;"IDENT",-11;"LITERAL",-11;"RHSEND",-11;"RRPAREN",-11;"[",-11;"[|",-11;"]",-11;"|>",-11;"|]",-11;"||",-11;"||>",-11;"|||",-11;"|||>",-11];["%",-12;"&",-12;"&&",-12;"(",-12;")",-12;"+",-12;",",-12;"-",-12;".",-12;"..",-12;"/",-12;"::",-12;":?",-12;":?>",-12;";",-12;"<",24;"<<",-12;"<>",-12;"<|",-12;"<||",-12;"<|||",-12;"=",-12;">>",-12;"@",-12;"IDENT",-12;"LITERAL",-12;"RHSEND",-12;"RRPAREN",-12;"[",-12;"[|",-12;"]",-12;"|>",-12;"|]",-12;"||",-12;"||>",-12;"|||",-12;"|||>",-12];["(",11;"IDENT",115;"TYPAR",14;"appType",3;"atomType",6;"funType",46;"longid",15;"revLongid",91;"tupleType",49;"typeArgument",139;"typeArguments",25];[",",140;">",26];["%",-13;"&",-13;"&&",-13;"(",-13;")",-13;"+",-13;",",-13;"-",-13;".",-13;"..",-13;"/",-13;"::",-13;":?",-13;":?>",-13;";",-13;"<<",-13;"<>",-13;"<|",-13;"<||",-13;"<|||",-13;"=",-13;">>",-13;"@",-13;"IDENT",-13;"LITERAL",-13;"RHSEND",-13;"RRPAREN",-13;"[",-13;"[|",-13;"]",-13;"|>",-13;"|]",-13;"||",-13;"||>",-13;"|||",-13;"|||>",-13];["%",-14;"&",-14;"&&",-14;"(",-14;")",-14;"+",-14;",",-14;"-",-14;".",-14;"..",-14;"/",-14;"::",-14;":?",-14;":?>",-14;";",-14;"<<",-14;"<>",-14;"<|",-14;"<||",-14;"<|||",-14;"=",-14;">>",-14;"@",-14;"IDENT",-14;"LITERAL",-14;"RHSEND",-14;"RRPAREN",-14;"[",-14;"[|",-14;"]",-14;"|>",-14;"|]",-14;"||",-14;"||>",-14;"|||",-14;"|||>",-14];["%",-15;"&",-15;"&&",-15;"(",-15;")",-15;"+",-15;",",-15;"-",-15;".",-15;"..",-15;"/",-15;"::",-15;":?",-15;":?>",-15;";",-15;"<<",-15;"<>",-15;"<|",-15;"<||",-15;"<|||",-15;"=",-15;">>",-15;"@",-15;"IDENT",-15;"LITERAL",-15;"RHSEND",-15;"RRPAREN",-15;"[",-15;"[|",-15;"]",-15;"|>",-15;"|]",-15;"||",-15;"||>",-15;"|||",-15;"|||>",-15];["%",-16;"&",-16;"&&",-16;"(",-16;")",-16;"+",-16;",",-16;"-",-16;".",-16;"..",-16;"/",-16;"::",-16;":?",-16;":?>",-16;";",-16;"<<",-16;"<>",-16;"<|",-16;"<||",-16;"<|||",-16;"=",-16;">>",-16;"@",-16;"IDENT",-16;"LITERAL",-16;"RHSEND",-16;"RRPAREN",-16;"[",-16;"[|",-16;"]",-16;"|>",-16;"|]",-16;"||",-16;"||>",-16;"|||",-16;"|||>",-16];["%",-17;"&",-17;"&&",-17;"(",-17;")",-17;"+",-17;",",-17;"-",-17;".",-17;"..",-17;"/",-17;"::",-17;":?",-17;":?>",-17;";",-17;"<<",-17;"<>",-17;"<|",-17;"<||",-17;"<|||",-17;"=",-17;">>",-17;"@",-17;"IDENT",-17;"LITERAL",-17;"RHSEND",-17;"RRPAREN",-17;"[",-17;"[|",-17;"]",-17;"|>",-17;"|]",-17;"||",-17;"||>",-17;"|||",-17;"|||>",-17];[")",-60;",",-60;":",32;"=",-60];["(",11;"IDENT",115;"TYPAR",14;"appType",3;"atomType",6;"funType",46;"longid",15;"revLongid",91;"tupleType",49;"typeArgument",33];[")",-18;",",-18;"=",-18];[")",-19;",",-19;"=",-19];["%",50;"&",51;"&&",52;")",-20;"+",53;",",-20;"-",55;"..",57;"/",58;"::",59;":?",60;":?>",61;";",-20;"<<",62;"<>",63;"<|",64;"<||",65;"<|||",66;"=",67;">>",68;"@",69;"RHSEND",-20;"RRPAREN",-20;"]",-20;"infix",112;"|>",70;"|]",-20;"||",71;"||>",72;"|||",73;"|||>",74];[")",-21;",",136;"=",-21];[")",-22;";",-22;"RRPAREN",-22;"]",-22;"|]",-22];["IDENT",115;"longid",39;"revLongid",91];[")",-23;";",-23;"RRPAREN",-23;"]",-23;"|]",-23];[")",-24;";",-24;"RRPAREN",-24;"]",-24;"|]",-24];[")",-25;";",-25;"RRPAREN",-25;"]",-25;"|]",-25];["IDENT",115;"longid",43;"revLongid",91];["LLPAREN",128;"rhsBlock",44];["EOF",45];["",-26];[")",-91;",",-91;"->",47;"=",-91;">",-91];["(",11;"IDENT",115;"TYPAR",14;"appType",3;"atomType",6;"longid",15;"revLongid",91;"tupleType",48];[")",-27;"*",138;",",-27;"->",-27;"=",-27;">",-27];[")",-28;"*",138;",",-28;"->",-28;"=",-28;">",-28];["!",-29;"(",-29;")",-29;"+",-29;"-",-29;"IDENT",-29;"LITERAL",-29;"[",-29;"[|",-29];["!",-30;"(",-30;")",-30;"+",-30;"-",-30;"IDENT",-30;"LITERAL",-30;"[",-30;"[|",-30];["!",-31;"(",-31;")",-31;"+",-31;"-",-31;"IDENT",-31;"LITERAL",-31;"[",-31;"[|",-31];["!",-32;"(",-32;"+",-32;"-",-32;"IDENT",-32;"LITERAL",-32;"[",-32;"[|",-32];["(",-63;")",-32;"IDENT",-63;"LITERAL",-63;"[",-63;"[|",-63];["!",-33;"(",-33;"+",-33;"-",-33;"IDENT",-33;"LITERAL",-33;"[",-33;"[|",-33];["(",-64;")",-33;"IDENT",-64;"LITERAL",-64;"[",-64;"[|",-64];["!",-34;"(",-34;")",-34;"+",-34;"-",-34;"IDENT",-34;"LITERAL",-34;"[",-34;"[|",-34];["!",-35;"(",-35;")",-35;"+",-35;"-",-35;"IDENT",-35;"LITERAL",-35;"[",-35;"[|",-35];["!",-36;"(",-36;")",-36;"+",-36;"-",-36;"IDENT",-36;"LITERAL",-36;"[",-36;"[|",-36];["!",-37;"(",-37;")",-37;"+",-37;"-",-37;"IDENT",-37;"LITERAL",-37;"[",-37;"[|",-37];["!",-38;"(",-38;")",-38;"+",-38;"-",-38;"IDENT",-38;"LITERAL",-38;"[",-38;"[|",-38];["!",-39;"(",-39;")",-39;"+",-39;"-",-39;"IDENT",-39;"LITERAL",-39;"[",-39;"[|",-39];["!",-40;"(",-40;")",-40;"+",-40;"-",-40;"IDENT",-40;"LITERAL",-40;"[",-40;"[|",-40];["!",-41;"(",-41;")",-41;"+",-41;"-",-41;"IDENT",-41;"LITERAL",-41;"[",-41;"[|",-41];["!",-42;"(",-42;")",-42;"+",-42;"-",-42;"IDENT",-42;"LITERAL",-42;"[",-42;"[|",-42];["!",-43;"(",-43;")",-43;"+",-43;"-",-43;"IDENT",-43;"LITERAL",-43;"[",-43;"[|",-43];["!",-44;"(",-44;")",-44;"+",-44;"-",-44;"IDENT",-44;"LITERAL",-44;"[",-44;"[|",-44];["!",-45;"(",-45;")",-45;"+",-45;"-",-45;"IDENT",-45;"LITERAL",-45;"[",-45;"[|",-45];["!",-46;"(",-46;")",-46;"+",-46;"-",-46;"IDENT",-46;"LITERAL",-46;"[",-46;"[|",-46];["!",-47;"(",-47;")",-47;"+",-47;"-",-47;"IDENT",-47;"LITERAL",-47;"[",-47;"[|",-47];["!",-48;"(",-48;")",-48;"+",-48;"-",-48;"IDENT",-48;"LITERAL",-48;"[",-48;"[|",-48];["!",-49;"(",-49;")",-49;"+",-49;"-",-49;"IDENT",-49;"LITERAL",-49;"[",-49;"[|",-49];["!",-50;"(",-50;")",-50;"+",-50;"-",-50;"IDENT",-50;"LITERAL",-50;"[",-50;"[|",-50];["!",-51;"(",-51;")",-51;"+",-51;"-",-51;"IDENT",-51;"LITERAL",-51;"[",-51;"[|",-51];["(",92;"IDENT",95;"parameterPattern",76];["->",77];["!",98;"(",19;"+",99;"-",100;"FUN",75;"IDENT",23;"LITERAL",27;"LLPAREN",128;"[",87;"[|",7;"appExpr",142;"arrayExpr",28;"atomicExpr",118;"binaryExpr",124;"lambdaExpr",145;"listExpr",29;"parenExpr",30;"prifix",143;"qualificationExpr",110;"revAppExpr",2;"revBinaryExpr",35;"revQualificationExpr",101;"revTupleExpr",125;"rhsBlock",78;"tupleExpr",146;"unaryExpr",114;"valueExpr",79];[")",-52;";",-52;"RHSEND",-52;"RRPAREN",-52;"]",-52;"|]",-52];["RHSEND",80];[")",-53;";",-53;"RHSEND",-53;"RRPAREN",-53;"]",-53;"|]",-53];["(",92;"IDENT",31;"atomicPattern",135;"bindingPattern",82;"parameterPattern",34;"tuplePattern",36];["=",83];["!",98;"(",19;"+",99;"-",100;"FUN",75;"IDENT",23;"LITERAL",27;"LLPAREN",128;"[",87;"[|",7;"appExpr",142;"arrayExpr",28;"atomicExpr",118;"binaryExpr",124;"lambdaExpr",145;"listExpr",29;"parenExpr",30;"prifix",143;"qualificationExpr",110;"revAppExpr",2;"revBinaryExpr",35;"revQualificationExpr",101;"revTupleExpr",125;"rhsBlock",84;"tupleExpr",146;"unaryExpr",114;"valueExpr",85];[")",-54;";",-54;"RRPAREN",-54;"]",-54;"|]",-54];["RHSEND",86];[")",-55;";",-55;"RRPAREN",-55;"]",-55;"|]",-55];["!",98;"(",19;"+",99;"-",100;"DUMMY",37;"FUN",75;"IDENT",23;"LET",81;"LITERAL",27;"OPEN",38;"[",87;"[|",7;"]",88;"appExpr",142;"arrayExpr",28;"atomicExpr",118;"binaryExpr",124;"declExpr",120;"lambdaExpr",145;"letBinding",40;"listExpr",29;"parenExpr",30;"prifix",143;"qualificationExpr",110;"revAppExpr",2;"revBinaryExpr",35;"revQualificationExpr",101;"revSequentialExpr",121;"revTupleExpr",125;"sequentialExpr",89;"tupleExpr",146;"unaryExpr",114;"valueExpr",41];["%",-56;"&",-56;"&&",-56;"(",-56;")",-56;"+",-56;",",-56;"-",-56;".",-56;"..",-56;"/",-56;"::",-56;":?",-56;":?>",-56;";",-56;"<<",-56;"<>",-56;"<|",-56;"<||",-56;"<|||",-56;"=",-56;">>",-56;"@",-56;"IDENT",-56;"LITERAL",-56;"RHSEND",-56;"RRPAREN",-56;"[",-56;"[|",-56;"]",-56;"|>",-56;"|]",-56;"||",-56;"||>",-56;"|||",-56;"|||>",-56];["]",90];["%",-57;"&",-57;"&&",-57;"(",-57;")",-57;"+",-57;",",-57;"-",-57;".",-57;"..",-57;"/",-57;"::",-57;":?",-57;":?>",-57;";",-57;"<<",-57;"<>",-57;"<|",-57;"<||",-57;"<|||",-57;"=",-57;">>",-57;"@",-57;"IDENT",-57;"LITERAL",-57;"RHSEND",-57;"RRPAREN",-57;"[",-57;"[|",-57;"]",-57;"|>",-57;"|]",-57;"||",-57;"||>",-57;"|||",-57;"|||>",-57];[")",-58;"*",-58;",",-58;"->",-58;".",116;";",-58;"<",-58;"=",-58;">",-58;"IDENT",-58;"LLPAREN",-58;"RRPAREN",-58;"[",-58;"]",-58;"|]",-58];["(",92;"IDENT",31;"atomicPattern",135;"bindingPattern",93;"parameterPattern",34;"tuplePattern",36];[")",94];[")",-59;",",-59;"->",-59;"=",-59];["->",-60];[")",97];["%",-61;"&",-61;"&&",-61;"(",-61;")",-61;"+",-61;",",-61;"-",-61;".",-61;"..",-61;"/",-61;"::",-61;":?",-61;":?>",-61;";",-61;"<<",-61;"<>",-61;"<|",-61;"<||",-61;"<|||",-61;"=",-61;">>",-61;"@",-61;"IDENT",-61;"LITERAL",-61;"RHSEND",-61;"RRPAREN",-61;"[",-61;"[|",-61;"]",-61;"|>",-61;"|]",-61;"||",-61;"||>",-61;"|||",-61;"|||>",-61];["(",-62;"IDENT",-62;"LITERAL",-62;"[",-62;"[|",-62];["(",-63;"IDENT",-63;"LITERAL",-63;"[",-63;"[|",-63];["(",-64;"IDENT",-64;"LITERAL",-64;"[",-64;"[|",-64];["%",-65;"&",-65;"&&",-65;"(",-65;")",-65;"+",-65;",",-65;"-",-65;".",102;"..",-65;"/",-65;"::",-65;":?",-65;":?>",-65;";",-65;"<<",-65;"<>",-65;"<|",-65;"<||",-65;"<|||",-65;"=",-65;">>",-65;"@",-65;"IDENT",-65;"LITERAL",-65;"RHSEND",-65;"RRPAREN",-65;"[",-65;"[|",-65;"]",-65;"qualificationSuffix",119;"|>",-65;"|]",-65;"||",-65;"||>",-65;"|||",-65;"|||>",-65];["IDENT",103;"[",107];["%",-66;"&",-66;"&&",-66;"(",-66;")",-66;"+",-66;",",-66;"-",-66;".",-66;"..",-66;"/",-66;"::",-66;":?",-66;":?>",-66;";",-66;"<",104;"<<",-66;"<>",-66;"<|",-66;"<||",-66;"<|||",-66;"=",-66;">>",-66;"@",-66;"IDENT",-66;"LITERAL",-66;"RHSEND",-66;"RRPAREN",-66;"[",-66;"[|",-66;"]",-66;"|>",-66;"|]",-66;"||",-66;"||>",-66;"|||",-66;"|||>",-66];["(",11;"IDENT",115;"TYPAR",14;"appType",3;"atomType",6;"funType",46;"longid",15;"revLongid",91;"tupleType",49;"typeArgument",139;"typeArguments",105];[",",140;">",106];["%",-67;"&",-67;"&&",-67;"(",-67;")",-67;"+",-67;",",-67;"-",-67;".",-67;"..",-67;"/",-67;"::",-67;":?",-67;":?>",-67;";",-67;"<<",-67;"<>",-67;"<|",-67;"<||",-67;"<|||",-67;"=",-67;">>",-67;"@",-67;"IDENT",-67;"LITERAL",-67;"RHSEND",-67;"RRPAREN",-67;"[",-67;"[|",-67;"]",-67;"|>",-67;"|]",-67;"||",-67;"||>",-67;"|||",-67;"|||>",-67];["!",98;"(",19;"+",99;"-",100;"IDENT",23;"LITERAL",27;"[",87;"[|",7;"appExpr",142;"arrayExpr",28;"atomicExpr",118;"binaryExpr",124;"listExpr",29;"parenExpr",30;"prifix",143;"qualificationExpr",110;"revAppExpr",2;"revBinaryExpr",35;"revQualificationExpr",101;"revTupleExpr",125;"tupleExpr",108;"unaryExpr",114];["]",109];["%",-68;"&",-68;"&&",-68;"(",-68;")",-68;"+",-68;",",-68;"-",-68;".",-68;"..",-68;"/",-68;"::",-68;":?",-68;":?>",-68;";",-68;"<<",-68;"<>",-68;"<|",-68;"<||",-68;"<|||",-68;"=",-68;">>",-68;"@",-68;"IDENT",-68;"LITERAL",-68;"RHSEND",-68;"RRPAREN",-68;"[",-68;"[|",-68;"]",-68;"|>",-68;"|]",-68;"||",-68;"||>",-68;"|||",-68;"|||>",-68];["%",-69;"&",-69;"&&",-69;"(",-69;")",-69;"+",-69;",",-69;"-",-69;"..",-69;"/",-69;"::",-69;":?",-69;":?>",-69;";",-69;"<<",-69;"<>",-69;"<|",-69;"<||",-69;"<|||",-69;"=",-69;">>",-69;"@",-69;"IDENT",-69;"LITERAL",-69;"RHSEND",-69;"RRPAREN",-69;"[",-69;"[|",-69;"]",-69;"|>",-69;"|]",-69;"||",-69;"||>",-69;"|||",-69;"|||>",-69];["%",-70;"&",-70;"&&",-70;"(",-70;")",-70;"+",-70;",",-70;"-",-70;"..",-70;"/",-70;"::",-70;":?",-70;":?>",-70;";",-70;"<<",-70;"<>",-70;"<|",-70;"<||",-70;"<|||",-70;"=",-70;">>",-70;"@",-70;"IDENT",-70;"LITERAL",-70;"RHSEND",-70;"RRPAREN",-70;"[",-70;"[|",-70;"]",-70;"|>",-70;"|]",-70;"||",-70;"||>",-70;"|||",-70;"|||>",-70];["!",98;"(",19;"+",99;"-",100;"IDENT",23;"LITERAL",27;"[",87;"[|",7;"appExpr",142;"arrayExpr",28;"atomicExpr",118;"listExpr",29;"parenExpr",30;"prifix",143;"qualificationExpr",110;"revAppExpr",2;"revQualificationExpr",101;"unaryExpr",113];["%",-71;"&",-71;"&&",-71;")",-71;"+",-71;",",-71;"-",-71;"..",-71;"/",-71;"::",-71;":?",-71;":?>",-71;";",-71;"<<",-71;"<>",-71;"<|",-71;"<||",-71;"<|||",-71;"=",-71;">>",-71;"@",-71;"RHSEND",-71;"RRPAREN",-71;"]",-71;"|>",-71;"|]",-71;"||",-71;"||>",-71;"|||",-71;"|||>",-71];["%",-72;"&",-72;"&&",-72;")",-72;"+",-72;",",-72;"-",-72;"..",-72;"/",-72;"::",-72;":?",-72;":?>",-72;";",-72;"<<",-72;"<>",-72;"<|",-72;"<||",-72;"<|||",-72;"=",-72;">>",-72;"@",-72;"RHSEND",-72;"RRPAREN",-72;"]",-72;"|>",-72;"|]",-72;"||",-72;"||>",-72;"|||",-72;"|||>",-72];[")",-73;"*",-73;",",-73;"->",-73;".",-73;";",-73;"<",-73;"=",-73;">",-73;"IDENT",-73;"LLPAREN",-73;"RRPAREN",-73;"[",-73;"]",-73;"|]",-73];["IDENT",117];[")",-74;"*",-74;",",-74;"->",-74;".",-74;";",-74;"<",-74;"=",-74;">",-74;"IDENT",-74;"LLPAREN",-74;"RRPAREN",-74;"[",-74;"]",-74;"|]",-74];["%",-75;"&",-75;"&&",-75;"(",-75;")",-75;"+",-75;",",-75;"-",-75;".",-75;"..",-75;"/",-75;"::",-75;":?",-75;":?>",-75;";",-75;"<<",-75;"<>",-75;"<|",-75;"<||",-75;"<|||",-75;"=",-75;">>",-75;"@",-75;"IDENT",-75;"LITERAL",-75;"RHSEND",-75;"RRPAREN",-75;"[",-75;"[|",-75;"]",-75;"|>",-75;"|]",-75;"||",-75;"||>",-75;"|||",-75;"|||>",-75];["%",-76;"&",-76;"&&",-76;"(",-76;")",-76;"+",-76;",",-76;"-",-76;".",-76;"..",-76;"/",-76;"::",-76;":?",-76;":?>",-76;";",-76;"<<",-76;"<>",-76;"<|",-76;"<||",-76;"<|||",-76;"=",-76;">>",-76;"@",-76;"IDENT",-76;"LITERAL",-76;"RHSEND",-76;"RRPAREN",-76;"[",-76;"[|",-76;"]",-76;"|>",-76;"|]",-76;"||",-76;"||>",-76;"|||",-76;"|||>",-76];[")",-77;";",-77;"RRPAREN",-77;"]",-77;"|]",-77];[")",-82;";",122;"RRPAREN",-82;"]",-82;"|]",-82];["!",98;"(",19;"+",99;"-",100;"DUMMY",37;"FUN",75;"IDENT",23;"LET",81;"LITERAL",27;"OPEN",38;"[",87;"[|",7;"appExpr",142;"arrayExpr",28;"atomicExpr",118;"binaryExpr",124;"declExpr",123;"lambdaExpr",145;"letBinding",40;"listExpr",29;"parenExpr",30;"prifix",143;"qualificationExpr",110;"revAppExpr",2;"revBinaryExpr",35;"revQualificationExpr",101;"revTupleExpr",125;"tupleExpr",146;"unaryExpr",114;"valueExpr",41];[")",-78;";",-78;"RRPAREN",-78;"]",-78;"|]",-78];[")",-79;",",-79;";",-79;"RHSEND",-79;"RRPAREN",-79;"]",-79;"|]",-79];[")",-85;",",126;";",-85;"RHSEND",-85;"RRPAREN",-85;"]",-85;"|]",-85];["!",98;"(",19;"+",99;"-",100;"FUN",75;"IDENT",23;"LITERAL",27;"[",87;"[|",7;"appExpr",142;"arrayExpr",28;"atomicExpr",118;"binaryExpr",127;"lambdaExpr",134;"listExpr",29;"parenExpr",30;"prifix",143;"qualificationExpr",110;"revAppExpr",2;"revBinaryExpr",35;"revQualificationExpr",101;"unaryExpr",114];[")",-80;",",-80;";",-80;"RHSEND",-80;"RRPAREN",-80;"]",-80;"|]",-80];["!",98;"(",19;"+",99;"-",100;"DUMMY",37;"FUN",75;"IDENT",23;"LET",81;"LITERAL",27;"OPEN",38;"[",87;"[|",7;"appExpr",142;"arrayExpr",28;"atomicExpr",118;"binaryExpr",124;"declExpr",120;"lambdaExpr",145;"letBinding",40;"listExpr",29;"parenExpr",30;"prifix",143;"qualificationExpr",110;"revAppExpr",2;"revBinaryExpr",35;"revQualificationExpr",101;"revSequentialExpr",121;"revTupleExpr",125;"sequentialExpr",129;"tupleExpr",146;"unaryExpr",114;"valueExpr",41];["RRPAREN",130];[")",-81;";",-81;"EOF",-81;"RHSEND",-81;"RRPAREN",-81;"]",-81;"|]",-81];["]",132];[")",-83;"*",-83;",",-83;"->",-83;"=",-83;">",-83;"IDENT",-83;"[",-83];[")",-84;"*",-84;",",-84;"->",-84;"=",-84;">",-84;"IDENT",-84;"[",-84];[")",-86;";",-86;"RHSEND",-86;"RRPAREN",-86;"]",-86;"|]",-86];[")",-87;",",-87;"=",-87];["(",92;"IDENT",31;"atomicPattern",137;"parameterPattern",34];[")",-88;",",-88;"=",-88];["(",11;"IDENT",115;"TYPAR",14;"appType",4;"atomType",6;"longid",15;"revLongid",91];[",",-92;">",-92];["(",11;"IDENT",115;"TYPAR",14;"appType",3;"atomType",6;"funType",46;"longid",15;"revLongid",91;"tupleType",49;"typeArgument",141];[",",-93;">",-93];["%",-94;"&",-94;"&&",-94;")",-94;"+",-94;",",-94;"-",-94;"..",-94;"/",-94;"::",-94;":?",-94;":?>",-94;";",-94;"<<",-94;"<>",-94;"<|",-94;"<||",-94;"<|||",-94;"=",-94;">>",-94;"@",-94;"RHSEND",-94;"RRPAREN",-94;"]",-94;"|>",-94;"|]",-94;"||",-94;"||>",-94;"|||",-94;"|||>",-94];["(",19;"IDENT",23;"LITERAL",27;"[",87;"[|",7;"appExpr",144;"arrayExpr",28;"atomicExpr",118;"listExpr",29;"parenExpr",30;"qualificationExpr",110;"revAppExpr",2;"revQualificationExpr",101];["%",-95;"&",-95;"&&",-95;")",-95;"+",-95;",",-95;"-",-95;"..",-95;"/",-95;"::",-95;":?",-95;":?>",-95;";",-95;"<<",-95;"<>",-95;"<|",-95;"<||",-95;"<|||",-95;"=",-95;">>",-95;"@",-95;"RHSEND",-95;"RRPAREN",-95;"]",-95;"|>",-95;"|]",-95;"||",-95;"||>",-95;"|||",-95;"|||>",-95];[")",-96;";",-96;"RHSEND",-96;"RRPAREN",-96;"]",-96;"|]",-96];[")",-97;";",-97;"RHSEND",-97;"RRPAREN",-97;"]",-97;"|]",-97]]
let rules: list<string list*(obj list->obj)> = [
    ["";"file"], fun (ss:obj list) -> ss.[0]
    ["appExpr";"revAppExpr"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let result:option<int>*Expr =
            Expr.ofAppExpr s0
        box result
    ["appType";"appType";"suffixType"], fun(ss:obj list)->
        let s0 = unbox<(option<int> * TypeArgument)*((option<int> * SuffixType) list)> ss.[0]
        let s1 = unbox<option<int>*SuffixType> ss.[1]
        let result:(option<int> * TypeArgument)*((option<int> * SuffixType) list) =
            let hd,tl = s0
            hd,s1::tl 
        box result
    ["appType";"atomType"], fun(ss:obj list)->
        let s0 = unbox<option<int>*TypeArgument> ss.[0]
        let result:(option<int> * TypeArgument)*((option<int> * SuffixType) list) =
            s0,[]
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
    ["atomType";"(";"typeArgument";")"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*TypeArgument> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:option<int>*TypeArgument =
            fst s1, ParenType(snd s1)
        box result
    ["atomType";"TYPAR"], fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let result:option<int>*TypeArgument =
            fst s0, Typar(snd s0)
        box result
    ["atomType";"longid"], fun(ss:obj list)->
        let s0 = unbox<option<int>*string list> ss.[0]
        let result:option<int>*TypeArgument =
            fst s0, NamedType(snd s0)
        box result
    ["atomType";"longid";"<";"typeArguments";">"], fun(ss:obj list)->
        let s0 = unbox<option<int>*string list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int>*TypeArgument) list> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*TypeArgument =
            let s2 = s2 |> List.map snd |> List.rev
            fst s0, GenericType(snd s0, s2 )
        box result
    ["atomicExpr";"(";")"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let result:option<int>*Expr =
            s0, LiteralExpr Literal.UNIT
        box result
    ["atomicExpr";"(";"infix";")"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*string> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:option<int>*Expr =
            s0, OperatorSectionExpr(snd s1)
        box result
    ["atomicExpr";"IDENT"], fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let result:option<int>*Expr =
            fst s0, IdentExpr(snd s0)
        box result
    ["atomicExpr";"IDENT";"<";"typeArguments";">"], fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int>*TypeArgument) list> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*Expr =
            let targs = s2 |> List.map snd |> List.rev
            fst s0, TypeApplicationExpr(snd s0,targs) 
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
    ["atomicExpr";"parenExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result
    ["atomicPattern";"IDENT";":";"typeArgument"], fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*TypeArgument> ss.[2]
        let result:option<int>*Pattern =
            fst s0, TypeAnnotationPattern(snd s0, snd s2)
        box result
    ["atomicPattern";"parameterPattern"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Pattern> ss.[0]
        let result:option<int>*Pattern =
            s0
        box result
    ["binaryExpr";"revBinaryExpr"], fun(ss:obj list)->
        let s0 = unbox<((option<int>*string)*(option<int>*Expr)) list> ss.[0]
        let result:option<int>*Expr =
            Expr.ofBinaryExpr s0
        box result
    ["bindingPattern";"tuplePattern"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*Pattern)list> ss.[0]
        let result:option<int>*Pattern =
            Pattern.ofTuplePattern s0
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
    ["declExpr";"letBinding"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result
    ["declExpr";"valueExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result
    ["file";"MODULE";"longid";"rhsBlock";"EOF"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*string list> ss.[1]
        let s2 = unbox<option<int>*Expr list> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:string list*Expr list =
            snd s1, snd s2
        box result
    ["funType";"funType";"->";"tupleType"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*TypeArgument) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int>*TypeArgument) list> ss.[2]
        let result:(option<int>*TypeArgument) list =
            let s2 = TypeArgument.ofTuple s2
            s2::s0
        box result
    ["funType";"tupleType"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*TypeArgument) list> ss.[0]
        let result:(option<int>*TypeArgument) list =
            let s0 = TypeArgument.ofTuple s0
            [s0]
        box result
    ["infix";"%"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "%"
        box result
    ["infix";"&"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "&"
        box result
    ["infix";"&&"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "&&"
        box result
    ["infix";"+"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "+"
        box result
    ["infix";"-"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "-"
        box result
    ["infix";".."], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, ".."
        box result
    ["infix";"/"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "/"
        box result
    ["infix";"::"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "::"
        box result
    ["infix";":?"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, ":?"
        box result
    ["infix";":?>"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, ":?>"
        box result
    ["infix";"<<"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "<<"
        box result
    ["infix";"<>"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "<>"
        box result
    ["infix";"<|"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "<|"
        box result
    ["infix";"<||"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "<||"
        box result
    ["infix";"<|||"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "<|||"
        box result
    ["infix";"="], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "="
        box result
    ["infix";">>"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, ">>"
        box result
    ["infix";"@"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "@"
        box result
    ["infix";"|>"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "|>"
        box result
    ["infix";"||"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "||"
        box result
    ["infix";"||>"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "||>"
        box result
    ["infix";"|||"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "|||"
        box result
    ["infix";"|||>"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "|||>"
        box result
    ["lambdaExpr";"FUN";"parameterPattern";"->";"rhsBlock"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Pattern> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>*Expr list> ss.[3]
        let result:option<int>*Expr =
            s0, LambdaExpr(snd s1, snd s3)
        box result
    ["lambdaExpr";"FUN";"parameterPattern";"->";"valueExpr";"RHSEND"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Pattern> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>*Expr> ss.[3]
        let s4 = unbox<option<int>> ss.[4]
        let result:option<int>*Expr =
            s0, LambdaExpr(snd s1, [snd s3])
        box result
    ["letBinding";"LET";"bindingPattern";"=";"rhsBlock"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Pattern> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>*Expr list> ss.[3]
        let result:option<int>*Expr =
            s0, LetBindingExpr(snd s1, snd s3)
        box result
    ["letBinding";"LET";"bindingPattern";"=";"valueExpr";"RHSEND"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Pattern> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>*Expr> ss.[3]
        let s4 = unbox<option<int>> ss.[4]
        let result:option<int>*Expr =
            s0, LetBindingExpr(snd s1, [snd s3])
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
    ["parameterPattern";"(";"bindingPattern";")"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Pattern> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:option<int>*Pattern =
            s0, snd s1
        box result
    ["parameterPattern";"IDENT"], fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let result:option<int>*Pattern =
            fst s0, IdentPattern(snd s0)
        box result
    ["parenExpr";"(";"sequentialExpr";")"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Expr list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:option<int>*Expr =
            s0, ParenExpr(snd s1)
        box result
    ["prifix";"!"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "!"
        box result
    ["prifix";"+"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "+"
        box result
    ["prifix";"-"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0, "-"
        box result
    ["qualificationExpr";"revQualificationExpr"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let result:option<int>*Expr =
            Expr.ofQualification(s0)
        box result
    ["qualificationSuffix";".";"IDENT"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*string> ss.[1]
        let result:option<int>*Expr =
            s0, IdentExpr(snd s1)
        box result
    ["qualificationSuffix";".";"IDENT";"<";"typeArguments";">"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*string> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<(option<int>*TypeArgument) list> ss.[3]
        let s4 = unbox<option<int>> ss.[4]
        let result:option<int>*Expr =
            let targs = s3 |> List.map snd |> List.rev
            s0, TypeApplicationExpr(snd s1,targs) 
        box result
    ["qualificationSuffix";".";"[";"tupleExpr";"]"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*Expr =
            s2
        box result
    ["revAppExpr";"qualificationExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:(option<int>*Expr) list =
            [s0]
        box result
    ["revAppExpr";"revAppExpr";"qualificationExpr"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let s1 = unbox<option<int>*Expr> ss.[1]
        let result:(option<int>*Expr) list =
            s1::s0
        box result
    ["revBinaryExpr";"revBinaryExpr";"infix";"unaryExpr"], fun(ss:obj list)->
        let s0 = unbox<((option<int>*string)*(option<int>*Expr)) list> ss.[0]
        let s1 = unbox<option<int>*string> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let result:((option<int>*string)*(option<int>*Expr)) list =
            (s1,s2)::s0
        box result
    ["revBinaryExpr";"unaryExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:((option<int>*string)*(option<int>*Expr)) list =
            [(None,""),s0]
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
    ["revQualificationExpr";"atomicExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:(option<int>*Expr) list =
            [s0]
        box result
    ["revQualificationExpr";"revQualificationExpr";"qualificationSuffix"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let s1 = unbox<option<int>*Expr> ss.[1]
        let result:(option<int>*Expr) list =
            s1::s0
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
    ["revTupleExpr";"binaryExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:(option<int>*Expr) list =
            [s0]
        box result
    ["revTupleExpr";"revTupleExpr";",";"binaryExpr"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let result:(option<int>*Expr) list =
            s2::s0
        box result
    ["rhsBlock";"LLPAREN";"sequentialExpr";"RRPAREN"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Expr list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:option<int>*Expr list =
            s1
        box result
    ["sequentialExpr";"revSequentialExpr"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let result:option<int>*Expr list =
            Expr.ofSequentialExpr s0
        box result
    ["suffixType";"[";"]"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let result:option<int>*SuffixType =
            s0, ArrayTypeSuffix 0
        box result
    ["suffixType";"longid"], fun(ss:obj list)->
        let s0 = unbox<option<int>*string list> ss.[0]
        let result:option<int>*SuffixType =
            fst s0, IdentSuffix(snd s0)
        box result
    ["tupleExpr";"revTupleExpr"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let result:option<int>*Expr =
            Expr.ofTupleExpr s0
        box result
    ["tupleExpr";"revTupleExpr";",";"lambdaExpr"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let result:option<int>*Expr =
            Expr.ofTupleLambdaExpr s0 s2
        box result
    ["tuplePattern";"atomicPattern"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Pattern> ss.[0]
        let result:(option<int>*Pattern)list =
            [s0]
        box result
    ["tuplePattern";"tuplePattern";",";"atomicPattern"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*Pattern)list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Pattern> ss.[2]
        let result:(option<int>*Pattern)list =
            s2::s0
        box result
    ["tupleType";"appType"], fun(ss:obj list)->
        let s0 = unbox<(option<int> * TypeArgument)*((option<int> * SuffixType) list)> ss.[0]
        let result:(option<int>*TypeArgument) list =
            [TypeArgument.ofApp s0]
        box result
    ["tupleType";"tupleType";"*";"appType"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*TypeArgument) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int> * TypeArgument)*((option<int> * SuffixType) list)> ss.[2]
        let result:(option<int>*TypeArgument) list =
            TypeArgument.ofApp s2::s0
        box result
    ["typeArgument";"funType"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*TypeArgument) list> ss.[0]
        let result:option<int>*TypeArgument =
            TypeArgument.ofFun s0
        box result
    ["typeArguments";"typeArgument"], fun(ss:obj list)->
        let s0 = unbox<option<int>*TypeArgument> ss.[0]
        let result:(option<int>*TypeArgument) list =
            [s0]
        box result
    ["typeArguments";"typeArguments";",";"typeArgument"], fun(ss:obj list)->
        let s0 = unbox<(option<int>*TypeArgument) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*TypeArgument> ss.[2]
        let result:(option<int>*TypeArgument) list =
            s2::s0
        box result
    ["unaryExpr";"appExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result
    ["unaryExpr";"prifix";"appExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let s1 = unbox<option<int>*Expr> ss.[1]
        let result:option<int>*Expr =
            let indent, op = s0
            indent, UnaryExpr(op, snd s1)
        box result
    ["valueExpr";"lambdaExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result
    ["valueExpr";"tupleExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result
]
let unboxRoot =
    unbox<string list*Expr list>
let parser = ParseTable.from(rules, actions)
