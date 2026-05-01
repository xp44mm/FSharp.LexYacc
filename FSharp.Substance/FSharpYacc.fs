module FSharp.Substance.FSharpYacc
open FSharp.LexYacc
let stateSymbols: string[] = [|"";"file";"revAppExpr";"appType";"appType";"suffixType";"atomType";"[|";"sequentialExpr";"|]";"|]";"(";"typeArgument";")";"TYPAR";"longid";"<";"typeArguments";">";"(";")";"infix";")";"LITERAL";"arrayExpr";"identExpr";"listExpr";"parenExpr";"IDENT";":";"typeArgument";"parameterPattern";"revBinaryExpr";"tuplePattern";"DUMMY";"OPEN";"longid";"letBinding";"valueExpr";"MODULE";"longid";"rhsBlock";"EOF";"funType";"->";"tupleType";"tupleType";"IDENT";"<";"typeArguments";">";"%";"&";"&&";"+";"+";"-";"-";"..";"/";"::";":?";":?>";"<<";"<>";"<|";"<||";"<|||";"=";">>";"@";"|>";"||";"||>";"|||";"|||>";"FUN";"parameterPattern";"->";"rhsBlock";"valueExpr";"RHSEND";"LET";"bindingPattern";"=";"rhsBlock";"valueExpr";"RHSEND";"[";"]";"sequentialExpr";"]";"revLongid";"(";"bindingPattern";")";"IDENT";"sequentialExpr";")";"!";"+";"-";"revQualificationExpr";".";"[";"tupleExpr";"]";"identExpr";"qualificationExpr";"qualificationExpr";"infix";"unaryExpr";"unaryExpr";"IDENT";".";"IDENT";"atomicExpr";"qualificationSuffix";"declExpr";"revSequentialExpr";";";"declExpr";"binaryExpr";"revTupleExpr";",";"binaryExpr";"LLPAREN";"sequentialExpr";"RRPAREN";"[";"]";"longid";"lambdaExpr";"atomicPattern";",";"atomicPattern";"*";"typeArgument";",";"typeArgument";"appExpr";"prifix";"appExpr";"lambdaExpr";"tupleExpr"|]
let actions: (string * int) list list = [["MODULE",39;"file",1];["",0];["%",-1;"&",-1;"&&",-1;"(",19;")",-1;"+",-1;",",-1;"-",-1;"..",-1;"/",-1;"::",-1;":?",-1;":?>",-1;";",-1;"<<",-1;"<>",-1;"<|",-1;"<||",-1;"<|||",-1;"=",-1;">>",-1;"@",-1;"IDENT",47;"LITERAL",23;"RHSEND",-1;"RRPAREN",-1;"[",88;"[|",7;"]",-1;"arrayExpr",24;"atomicExpr",116;"identExpr",25;"listExpr",26;"parenExpr",27;"qualificationExpr",109;"revQualificationExpr",102;"|>",-1;"|]",-1;"||",-1;"||>",-1;"|||",-1;"|||>",-1];[")",-89;"*",-89;",",-89;"->",-89;"=",-89;">",-89;"IDENT",113;"[",129;"longid",131;"revLongid",92;"suffixType",5];[")",-90;"*",-90;",",-90;"->",-90;"=",-90;">",-90;"IDENT",113;"[",129;"longid",131;"revLongid",92;"suffixType",5];[")",-2;"*",-2;",",-2;"->",-2;"=",-2;">",-2;"IDENT",-2;"[",-2];[")",-3;"*",-3;",",-3;"->",-3;"=",-3;">",-3;"IDENT",-3;"[",-3];["!",99;"(",19;"+",100;"-",101;"DUMMY",34;"FUN",76;"IDENT",47;"LET",82;"LITERAL",23;"OPEN",35;"[",88;"[|",7;"appExpr",140;"arrayExpr",24;"atomicExpr",116;"binaryExpr",122;"declExpr",118;"identExpr",25;"lambdaExpr",143;"letBinding",37;"listExpr",26;"parenExpr",27;"prifix",141;"qualificationExpr",108;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",102;"revSequentialExpr",119;"revTupleExpr",123;"sequentialExpr",8;"tupleExpr",144;"unaryExpr",112;"valueExpr",38;"|]",10];["|]",9];["%",-4;"&",-4;"&&",-4;"(",-4;")",-4;"+",-4;",",-4;"-",-4;".",-4;"..",-4;"/",-4;"::",-4;":?",-4;":?>",-4;";",-4;"<<",-4;"<>",-4;"<|",-4;"<||",-4;"<|||",-4;"=",-4;">>",-4;"@",-4;"IDENT",-4;"LITERAL",-4;"RHSEND",-4;"RRPAREN",-4;"[",-4;"[|",-4;"]",-4;"|>",-4;"|]",-4;"||",-4;"||>",-4;"|||",-4;"|||>",-4];["%",-5;"&",-5;"&&",-5;"(",-5;")",-5;"+",-5;",",-5;"-",-5;".",-5;"..",-5;"/",-5;"::",-5;":?",-5;":?>",-5;";",-5;"<<",-5;"<>",-5;"<|",-5;"<||",-5;"<|||",-5;"=",-5;">>",-5;"@",-5;"IDENT",-5;"LITERAL",-5;"RHSEND",-5;"RRPAREN",-5;"[",-5;"[|",-5;"]",-5;"|>",-5;"|]",-5;"||",-5;"||>",-5;"|||",-5;"|||>",-5];["(",11;"IDENT",113;"TYPAR",14;"appType",3;"atomType",6;"funType",43;"longid",15;"revLongid",92;"tupleType",46;"typeArgument",12];[")",13];[")",-6;"*",-6;",",-6;"->",-6;"=",-6;">",-6;"IDENT",-6;"[",-6];[")",-7;"*",-7;",",-7;"->",-7;"=",-7;">",-7;"IDENT",-7;"[",-7];[")",-8;"*",-8;",",-8;"->",-8;"<",16;"=",-8;">",-8;"IDENT",-8;"[",-8];["(",11;"IDENT",113;"TYPAR",14;"appType",3;"atomType",6;"funType",43;"longid",15;"revLongid",92;"tupleType",46;"typeArgument",137;"typeArguments",17];[",",138;">",18];[")",-9;"*",-9;",",-9;"->",-9;"=",-9;">",-9;"IDENT",-9;"[",-9];["!",99;"%",51;"&",52;"&&",53;"(",19;")",20;"+",55;"-",57;"..",58;"/",59;"::",60;":?",61;":?>",62;"<<",63;"<>",64;"<|",65;"<||",66;"<|||",67;"=",68;">>",69;"@",70;"DUMMY",34;"FUN",76;"IDENT",47;"LET",82;"LITERAL",23;"OPEN",35;"[",88;"[|",7;"appExpr",140;"arrayExpr",24;"atomicExpr",116;"binaryExpr",122;"declExpr",118;"identExpr",25;"infix",21;"lambdaExpr",143;"letBinding",37;"listExpr",26;"parenExpr",27;"prifix",141;"qualificationExpr",108;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",102;"revSequentialExpr",119;"revTupleExpr",123;"sequentialExpr",97;"tupleExpr",144;"unaryExpr",112;"valueExpr",38;"|>",71;"||",72;"||>",73;"|||",74;"|||>",75];["%",-10;"&",-10;"&&",-10;"(",-10;")",-10;"+",-10;",",-10;"-",-10;".",-10;"..",-10;"/",-10;"::",-10;":?",-10;":?>",-10;";",-10;"<<",-10;"<>",-10;"<|",-10;"<||",-10;"<|||",-10;"=",-10;">>",-10;"@",-10;"IDENT",-10;"LITERAL",-10;"RHSEND",-10;"RRPAREN",-10;"[",-10;"[|",-10;"]",-10;"|>",-10;"|]",-10;"||",-10;"||>",-10;"|||",-10;"|||>",-10];[")",22];["%",-11;"&",-11;"&&",-11;"(",-11;")",-11;"+",-11;",",-11;"-",-11;".",-11;"..",-11;"/",-11;"::",-11;":?",-11;":?>",-11;";",-11;"<<",-11;"<>",-11;"<|",-11;"<||",-11;"<|||",-11;"=",-11;">>",-11;"@",-11;"IDENT",-11;"LITERAL",-11;"RHSEND",-11;"RRPAREN",-11;"[",-11;"[|",-11;"]",-11;"|>",-11;"|]",-11;"||",-11;"||>",-11;"|||",-11;"|||>",-11];["%",-12;"&",-12;"&&",-12;"(",-12;")",-12;"+",-12;",",-12;"-",-12;".",-12;"..",-12;"/",-12;"::",-12;":?",-12;":?>",-12;";",-12;"<<",-12;"<>",-12;"<|",-12;"<||",-12;"<|||",-12;"=",-12;">>",-12;"@",-12;"IDENT",-12;"LITERAL",-12;"RHSEND",-12;"RRPAREN",-12;"[",-12;"[|",-12;"]",-12;"|>",-12;"|]",-12;"||",-12;"||>",-12;"|||",-12;"|||>",-12];["%",-13;"&",-13;"&&",-13;"(",-13;")",-13;"+",-13;",",-13;"-",-13;".",-13;"..",-13;"/",-13;"::",-13;":?",-13;":?>",-13;";",-13;"<<",-13;"<>",-13;"<|",-13;"<||",-13;"<|||",-13;"=",-13;">>",-13;"@",-13;"IDENT",-13;"LITERAL",-13;"RHSEND",-13;"RRPAREN",-13;"[",-13;"[|",-13;"]",-13;"|>",-13;"|]",-13;"||",-13;"||>",-13;"|||",-13;"|||>",-13];["%",-14;"&",-14;"&&",-14;"(",-14;")",-14;"+",-14;",",-14;"-",-14;".",-14;"..",-14;"/",-14;"::",-14;":?",-14;":?>",-14;";",-14;"<<",-14;"<>",-14;"<|",-14;"<||",-14;"<|||",-14;"=",-14;">>",-14;"@",-14;"IDENT",-14;"LITERAL",-14;"RHSEND",-14;"RRPAREN",-14;"[",-14;"[|",-14;"]",-14;"|>",-14;"|]",-14;"||",-14;"||>",-14;"|||",-14;"|||>",-14];["%",-15;"&",-15;"&&",-15;"(",-15;")",-15;"+",-15;",",-15;"-",-15;".",-15;"..",-15;"/",-15;"::",-15;":?",-15;":?>",-15;";",-15;"<<",-15;"<>",-15;"<|",-15;"<||",-15;"<|||",-15;"=",-15;">>",-15;"@",-15;"IDENT",-15;"LITERAL",-15;"RHSEND",-15;"RRPAREN",-15;"[",-15;"[|",-15;"]",-15;"|>",-15;"|]",-15;"||",-15;"||>",-15;"|||",-15;"|||>",-15];["%",-16;"&",-16;"&&",-16;"(",-16;")",-16;"+",-16;",",-16;"-",-16;".",-16;"..",-16;"/",-16;"::",-16;":?",-16;":?>",-16;";",-16;"<<",-16;"<>",-16;"<|",-16;"<||",-16;"<|||",-16;"=",-16;">>",-16;"@",-16;"IDENT",-16;"LITERAL",-16;"RHSEND",-16;"RRPAREN",-16;"[",-16;"[|",-16;"]",-16;"|>",-16;"|]",-16;"||",-16;"||>",-16;"|||",-16;"|||>",-16];[")",-61;",",-61;":",29;"=",-61];["(",11;"IDENT",113;"TYPAR",14;"appType",3;"atomType",6;"funType",43;"longid",15;"revLongid",92;"tupleType",46;"typeArgument",30];[")",-17;",",-17;"=",-17];[")",-18;",",-18;"=",-18];["%",51;"&",52;"&&",53;")",-19;"+",54;",",-19;"-",56;"..",58;"/",59;"::",60;":?",61;":?>",62;";",-19;"<<",63;"<>",64;"<|",65;"<||",66;"<|||",67;"=",68;">>",69;"@",70;"RHSEND",-19;"RRPAREN",-19;"]",-19;"infix",110;"|>",71;"|]",-19;"||",72;"||>",73;"|||",74;"|||>",75];[")",-20;",",134;"=",-20];[")",-21;";",-21;"RRPAREN",-21;"]",-21;"|]",-21];["IDENT",113;"longid",36;"revLongid",92];[")",-22;";",-22;"RRPAREN",-22;"]",-22;"|]",-22];[")",-23;";",-23;"RRPAREN",-23;"]",-23;"|]",-23];[")",-24;";",-24;"RRPAREN",-24;"]",-24;"|]",-24];["IDENT",113;"longid",40;"revLongid",92];["LLPAREN",126;"rhsBlock",41];["EOF",42];["",-25];[")",-91;",",-91;"->",44;"=",-91;">",-91];["(",11;"IDENT",113;"TYPAR",14;"appType",3;"atomType",6;"longid",15;"revLongid",92;"tupleType",45];[")",-26;"*",136;",",-26;"->",-26;"=",-26;">",-26];[")",-27;"*",136;",",-27;"->",-27;"=",-27;">",-27];["%",-28;"&",-28;"&&",-28;"(",-28;")",-28;"+",-28;",",-28;"-",-28;".",-28;"..",-28;"/",-28;"::",-28;":?",-28;":?>",-28;";",-28;"<",48;"<<",-28;"<>",-28;"<|",-28;"<||",-28;"<|||",-28;"=",-28;">>",-28;"@",-28;"IDENT",-28;"LITERAL",-28;"RHSEND",-28;"RRPAREN",-28;"[",-28;"[|",-28;"]",-28;"|>",-28;"|]",-28;"||",-28;"||>",-28;"|||",-28;"|||>",-28];["(",11;"IDENT",113;"TYPAR",14;"appType",3;"atomType",6;"funType",43;"longid",15;"revLongid",92;"tupleType",46;"typeArgument",137;"typeArguments",49];[",",138;">",50];["%",-29;"&",-29;"&&",-29;"(",-29;")",-29;"+",-29;",",-29;"-",-29;".",-29;"..",-29;"/",-29;"::",-29;":?",-29;":?>",-29;";",-29;"<<",-29;"<>",-29;"<|",-29;"<||",-29;"<|||",-29;"=",-29;">>",-29;"@",-29;"IDENT",-29;"LITERAL",-29;"RHSEND",-29;"RRPAREN",-29;"[",-29;"[|",-29;"]",-29;"|>",-29;"|]",-29;"||",-29;"||>",-29;"|||",-29;"|||>",-29];["!",-30;"(",-30;")",-30;"+",-30;"-",-30;"IDENT",-30;"LITERAL",-30;"[",-30;"[|",-30];["!",-31;"(",-31;")",-31;"+",-31;"-",-31;"IDENT",-31;"LITERAL",-31;"[",-31;"[|",-31];["!",-32;"(",-32;")",-32;"+",-32;"-",-32;"IDENT",-32;"LITERAL",-32;"[",-32;"[|",-32];["!",-33;"(",-33;"+",-33;"-",-33;"IDENT",-33;"LITERAL",-33;"[",-33;"[|",-33];["(",-64;")",-33;"IDENT",-64;"LITERAL",-64;"[",-64;"[|",-64];["!",-34;"(",-34;"+",-34;"-",-34;"IDENT",-34;"LITERAL",-34;"[",-34;"[|",-34];["(",-65;")",-34;"IDENT",-65;"LITERAL",-65;"[",-65;"[|",-65];["!",-35;"(",-35;")",-35;"+",-35;"-",-35;"IDENT",-35;"LITERAL",-35;"[",-35;"[|",-35];["!",-36;"(",-36;")",-36;"+",-36;"-",-36;"IDENT",-36;"LITERAL",-36;"[",-36;"[|",-36];["!",-37;"(",-37;")",-37;"+",-37;"-",-37;"IDENT",-37;"LITERAL",-37;"[",-37;"[|",-37];["!",-38;"(",-38;")",-38;"+",-38;"-",-38;"IDENT",-38;"LITERAL",-38;"[",-38;"[|",-38];["!",-39;"(",-39;")",-39;"+",-39;"-",-39;"IDENT",-39;"LITERAL",-39;"[",-39;"[|",-39];["!",-40;"(",-40;")",-40;"+",-40;"-",-40;"IDENT",-40;"LITERAL",-40;"[",-40;"[|",-40];["!",-41;"(",-41;")",-41;"+",-41;"-",-41;"IDENT",-41;"LITERAL",-41;"[",-41;"[|",-41];["!",-42;"(",-42;")",-42;"+",-42;"-",-42;"IDENT",-42;"LITERAL",-42;"[",-42;"[|",-42];["!",-43;"(",-43;")",-43;"+",-43;"-",-43;"IDENT",-43;"LITERAL",-43;"[",-43;"[|",-43];["!",-44;"(",-44;")",-44;"+",-44;"-",-44;"IDENT",-44;"LITERAL",-44;"[",-44;"[|",-44];["!",-45;"(",-45;")",-45;"+",-45;"-",-45;"IDENT",-45;"LITERAL",-45;"[",-45;"[|",-45];["!",-46;"(",-46;")",-46;"+",-46;"-",-46;"IDENT",-46;"LITERAL",-46;"[",-46;"[|",-46];["!",-47;"(",-47;")",-47;"+",-47;"-",-47;"IDENT",-47;"LITERAL",-47;"[",-47;"[|",-47];["!",-48;"(",-48;")",-48;"+",-48;"-",-48;"IDENT",-48;"LITERAL",-48;"[",-48;"[|",-48];["!",-49;"(",-49;")",-49;"+",-49;"-",-49;"IDENT",-49;"LITERAL",-49;"[",-49;"[|",-49];["!",-50;"(",-50;")",-50;"+",-50;"-",-50;"IDENT",-50;"LITERAL",-50;"[",-50;"[|",-50];["!",-51;"(",-51;")",-51;"+",-51;"-",-51;"IDENT",-51;"LITERAL",-51;"[",-51;"[|",-51];["!",-52;"(",-52;")",-52;"+",-52;"-",-52;"IDENT",-52;"LITERAL",-52;"[",-52;"[|",-52];["(",93;"IDENT",96;"parameterPattern",77];["->",78];["!",99;"(",19;"+",100;"-",101;"FUN",76;"IDENT",47;"LITERAL",23;"LLPAREN",126;"[",88;"[|",7;"appExpr",140;"arrayExpr",24;"atomicExpr",116;"binaryExpr",122;"identExpr",25;"lambdaExpr",143;"listExpr",26;"parenExpr",27;"prifix",141;"qualificationExpr",108;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",102;"revTupleExpr",123;"rhsBlock",79;"tupleExpr",144;"unaryExpr",112;"valueExpr",80];[")",-53;";",-53;"RHSEND",-53;"RRPAREN",-53;"]",-53;"|]",-53];["RHSEND",81];[")",-54;";",-54;"RHSEND",-54;"RRPAREN",-54;"]",-54;"|]",-54];["(",93;"IDENT",28;"atomicPattern",133;"bindingPattern",83;"parameterPattern",31;"tuplePattern",33];["=",84];["!",99;"(",19;"+",100;"-",101;"FUN",76;"IDENT",47;"LITERAL",23;"LLPAREN",126;"[",88;"[|",7;"appExpr",140;"arrayExpr",24;"atomicExpr",116;"binaryExpr",122;"identExpr",25;"lambdaExpr",143;"listExpr",26;"parenExpr",27;"prifix",141;"qualificationExpr",108;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",102;"revTupleExpr",123;"rhsBlock",85;"tupleExpr",144;"unaryExpr",112;"valueExpr",86];[")",-55;";",-55;"RRPAREN",-55;"]",-55;"|]",-55];["RHSEND",87];[")",-56;";",-56;"RRPAREN",-56;"]",-56;"|]",-56];["!",99;"(",19;"+",100;"-",101;"DUMMY",34;"FUN",76;"IDENT",47;"LET",82;"LITERAL",23;"OPEN",35;"[",88;"[|",7;"]",89;"appExpr",140;"arrayExpr",24;"atomicExpr",116;"binaryExpr",122;"declExpr",118;"identExpr",25;"lambdaExpr",143;"letBinding",37;"listExpr",26;"parenExpr",27;"prifix",141;"qualificationExpr",108;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",102;"revSequentialExpr",119;"revTupleExpr",123;"sequentialExpr",90;"tupleExpr",144;"unaryExpr",112;"valueExpr",38];["%",-57;"&",-57;"&&",-57;"(",-57;")",-57;"+",-57;",",-57;"-",-57;".",-57;"..",-57;"/",-57;"::",-57;":?",-57;":?>",-57;";",-57;"<<",-57;"<>",-57;"<|",-57;"<||",-57;"<|||",-57;"=",-57;">>",-57;"@",-57;"IDENT",-57;"LITERAL",-57;"RHSEND",-57;"RRPAREN",-57;"[",-57;"[|",-57;"]",-57;"|>",-57;"|]",-57;"||",-57;"||>",-57;"|||",-57;"|||>",-57];["]",91];["%",-58;"&",-58;"&&",-58;"(",-58;")",-58;"+",-58;",",-58;"-",-58;".",-58;"..",-58;"/",-58;"::",-58;":?",-58;":?>",-58;";",-58;"<<",-58;"<>",-58;"<|",-58;"<||",-58;"<|||",-58;"=",-58;">>",-58;"@",-58;"IDENT",-58;"LITERAL",-58;"RHSEND",-58;"RRPAREN",-58;"[",-58;"[|",-58;"]",-58;"|>",-58;"|]",-58;"||",-58;"||>",-58;"|||",-58;"|||>",-58];[")",-59;"*",-59;",",-59;"->",-59;".",114;";",-59;"<",-59;"=",-59;">",-59;"IDENT",-59;"LLPAREN",-59;"RRPAREN",-59;"[",-59;"]",-59;"|]",-59];["(",93;"IDENT",28;"atomicPattern",133;"bindingPattern",94;"parameterPattern",31;"tuplePattern",33];[")",95];[")",-60;",",-60;"->",-60;"=",-60];["->",-61];[")",98];["%",-62;"&",-62;"&&",-62;"(",-62;")",-62;"+",-62;",",-62;"-",-62;".",-62;"..",-62;"/",-62;"::",-62;":?",-62;":?>",-62;";",-62;"<<",-62;"<>",-62;"<|",-62;"<||",-62;"<|||",-62;"=",-62;">>",-62;"@",-62;"IDENT",-62;"LITERAL",-62;"RHSEND",-62;"RRPAREN",-62;"[",-62;"[|",-62;"]",-62;"|>",-62;"|]",-62;"||",-62;"||>",-62;"|||",-62;"|||>",-62];["(",-63;"IDENT",-63;"LITERAL",-63;"[",-63;"[|",-63];["(",-64;"IDENT",-64;"LITERAL",-64;"[",-64;"[|",-64];["(",-65;"IDENT",-65;"LITERAL",-65;"[",-65;"[|",-65];["%",-66;"&",-66;"&&",-66;"(",-66;")",-66;"+",-66;",",-66;"-",-66;".",103;"..",-66;"/",-66;"::",-66;":?",-66;":?>",-66;";",-66;"<<",-66;"<>",-66;"<|",-66;"<||",-66;"<|||",-66;"=",-66;">>",-66;"@",-66;"IDENT",-66;"LITERAL",-66;"RHSEND",-66;"RRPAREN",-66;"[",-66;"[|",-66;"]",-66;"qualificationSuffix",117;"|>",-66;"|]",-66;"||",-66;"||>",-66;"|||",-66;"|||>",-66];["IDENT",47;"[",104;"identExpr",107];["!",99;"(",19;"+",100;"-",101;"IDENT",47;"LITERAL",23;"[",88;"[|",7;"appExpr",140;"arrayExpr",24;"atomicExpr",116;"binaryExpr",122;"identExpr",25;"listExpr",26;"parenExpr",27;"prifix",141;"qualificationExpr",108;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",102;"revTupleExpr",123;"tupleExpr",105;"unaryExpr",112];["]",106];["%",-67;"&",-67;"&&",-67;"(",-67;")",-67;"+",-67;",",-67;"-",-67;".",-67;"..",-67;"/",-67;"::",-67;":?",-67;":?>",-67;";",-67;"<<",-67;"<>",-67;"<|",-67;"<||",-67;"<|||",-67;"=",-67;">>",-67;"@",-67;"IDENT",-67;"LITERAL",-67;"RHSEND",-67;"RRPAREN",-67;"[",-67;"[|",-67;"]",-67;"|>",-67;"|]",-67;"||",-67;"||>",-67;"|||",-67;"|||>",-67];["%",-68;"&",-68;"&&",-68;"(",-68;")",-68;"+",-68;",",-68;"-",-68;".",-68;"..",-68;"/",-68;"::",-68;":?",-68;":?>",-68;";",-68;"<<",-68;"<>",-68;"<|",-68;"<||",-68;"<|||",-68;"=",-68;">>",-68;"@",-68;"IDENT",-68;"LITERAL",-68;"RHSEND",-68;"RRPAREN",-68;"[",-68;"[|",-68;"]",-68;"|>",-68;"|]",-68;"||",-68;"||>",-68;"|||",-68;"|||>",-68];["%",-69;"&",-69;"&&",-69;"(",-69;")",-69;"+",-69;",",-69;"-",-69;"..",-69;"/",-69;"::",-69;":?",-69;":?>",-69;";",-69;"<<",-69;"<>",-69;"<|",-69;"<||",-69;"<|||",-69;"=",-69;">>",-69;"@",-69;"IDENT",-69;"LITERAL",-69;"RHSEND",-69;"RRPAREN",-69;"[",-69;"[|",-69;"]",-69;"|>",-69;"|]",-69;"||",-69;"||>",-69;"|||",-69;"|||>",-69];["%",-70;"&",-70;"&&",-70;"(",-70;")",-70;"+",-70;",",-70;"-",-70;"..",-70;"/",-70;"::",-70;":?",-70;":?>",-70;";",-70;"<<",-70;"<>",-70;"<|",-70;"<||",-70;"<|||",-70;"=",-70;">>",-70;"@",-70;"IDENT",-70;"LITERAL",-70;"RHSEND",-70;"RRPAREN",-70;"[",-70;"[|",-70;"]",-70;"|>",-70;"|]",-70;"||",-70;"||>",-70;"|||",-70;"|||>",-70];["!",99;"(",19;"+",100;"-",101;"IDENT",47;"LITERAL",23;"[",88;"[|",7;"appExpr",140;"arrayExpr",24;"atomicExpr",116;"identExpr",25;"listExpr",26;"parenExpr",27;"prifix",141;"qualificationExpr",108;"revAppExpr",2;"revQualificationExpr",102;"unaryExpr",111];["%",-71;"&",-71;"&&",-71;")",-71;"+",-71;",",-71;"-",-71;"..",-71;"/",-71;"::",-71;":?",-71;":?>",-71;";",-71;"<<",-71;"<>",-71;"<|",-71;"<||",-71;"<|||",-71;"=",-71;">>",-71;"@",-71;"RHSEND",-71;"RRPAREN",-71;"]",-71;"|>",-71;"|]",-71;"||",-71;"||>",-71;"|||",-71;"|||>",-71];["%",-72;"&",-72;"&&",-72;")",-72;"+",-72;",",-72;"-",-72;"..",-72;"/",-72;"::",-72;":?",-72;":?>",-72;";",-72;"<<",-72;"<>",-72;"<|",-72;"<||",-72;"<|||",-72;"=",-72;">>",-72;"@",-72;"RHSEND",-72;"RRPAREN",-72;"]",-72;"|>",-72;"|]",-72;"||",-72;"||>",-72;"|||",-72;"|||>",-72];[")",-73;"*",-73;",",-73;"->",-73;".",-73;";",-73;"<",-73;"=",-73;">",-73;"IDENT",-73;"LLPAREN",-73;"RRPAREN",-73;"[",-73;"]",-73;"|]",-73];["IDENT",115];[")",-74;"*",-74;",",-74;"->",-74;".",-74;";",-74;"<",-74;"=",-74;">",-74;"IDENT",-74;"LLPAREN",-74;"RRPAREN",-74;"[",-74;"]",-74;"|]",-74];["%",-75;"&",-75;"&&",-75;"(",-75;")",-75;"+",-75;",",-75;"-",-75;".",-75;"..",-75;"/",-75;"::",-75;":?",-75;":?>",-75;";",-75;"<<",-75;"<>",-75;"<|",-75;"<||",-75;"<|||",-75;"=",-75;">>",-75;"@",-75;"IDENT",-75;"LITERAL",-75;"RHSEND",-75;"RRPAREN",-75;"[",-75;"[|",-75;"]",-75;"|>",-75;"|]",-75;"||",-75;"||>",-75;"|||",-75;"|||>",-75];["%",-76;"&",-76;"&&",-76;"(",-76;")",-76;"+",-76;",",-76;"-",-76;".",-76;"..",-76;"/",-76;"::",-76;":?",-76;":?>",-76;";",-76;"<<",-76;"<>",-76;"<|",-76;"<||",-76;"<|||",-76;"=",-76;">>",-76;"@",-76;"IDENT",-76;"LITERAL",-76;"RHSEND",-76;"RRPAREN",-76;"[",-76;"[|",-76;"]",-76;"|>",-76;"|]",-76;"||",-76;"||>",-76;"|||",-76;"|||>",-76];[")",-77;";",-77;"RRPAREN",-77;"]",-77;"|]",-77];[")",-82;";",120;"RRPAREN",-82;"]",-82;"|]",-82];["!",99;"(",19;"+",100;"-",101;"DUMMY",34;"FUN",76;"IDENT",47;"LET",82;"LITERAL",23;"OPEN",35;"[",88;"[|",7;"appExpr",140;"arrayExpr",24;"atomicExpr",116;"binaryExpr",122;"declExpr",121;"identExpr",25;"lambdaExpr",143;"letBinding",37;"listExpr",26;"parenExpr",27;"prifix",141;"qualificationExpr",108;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",102;"revTupleExpr",123;"tupleExpr",144;"unaryExpr",112;"valueExpr",38];[")",-78;";",-78;"RRPAREN",-78;"]",-78;"|]",-78];[")",-79;",",-79;";",-79;"RHSEND",-79;"RRPAREN",-79;"]",-79;"|]",-79];[")",-85;",",124;";",-85;"RHSEND",-85;"RRPAREN",-85;"]",-85;"|]",-85];["!",99;"(",19;"+",100;"-",101;"FUN",76;"IDENT",47;"LITERAL",23;"[",88;"[|",7;"appExpr",140;"arrayExpr",24;"atomicExpr",116;"binaryExpr",125;"identExpr",25;"lambdaExpr",132;"listExpr",26;"parenExpr",27;"prifix",141;"qualificationExpr",108;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",102;"unaryExpr",112];[")",-80;",",-80;";",-80;"RHSEND",-80;"RRPAREN",-80;"]",-80;"|]",-80];["!",99;"(",19;"+",100;"-",101;"DUMMY",34;"FUN",76;"IDENT",47;"LET",82;"LITERAL",23;"OPEN",35;"[",88;"[|",7;"appExpr",140;"arrayExpr",24;"atomicExpr",116;"binaryExpr",122;"declExpr",118;"identExpr",25;"lambdaExpr",143;"letBinding",37;"listExpr",26;"parenExpr",27;"prifix",141;"qualificationExpr",108;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",102;"revSequentialExpr",119;"revTupleExpr",123;"sequentialExpr",127;"tupleExpr",144;"unaryExpr",112;"valueExpr",38];["RRPAREN",128];[")",-81;";",-81;"EOF",-81;"RHSEND",-81;"RRPAREN",-81;"]",-81;"|]",-81];["]",130];[")",-83;"*",-83;",",-83;"->",-83;"=",-83;">",-83;"IDENT",-83;"[",-83];[")",-84;"*",-84;",",-84;"->",-84;"=",-84;">",-84;"IDENT",-84;"[",-84];[")",-86;";",-86;"RHSEND",-86;"RRPAREN",-86;"]",-86;"|]",-86];[")",-87;",",-87;"=",-87];["(",93;"IDENT",28;"atomicPattern",135;"parameterPattern",31];[")",-88;",",-88;"=",-88];["(",11;"IDENT",113;"TYPAR",14;"appType",4;"atomType",6;"longid",15;"revLongid",92];[",",-92;">",-92];["(",11;"IDENT",113;"TYPAR",14;"appType",3;"atomType",6;"funType",43;"longid",15;"revLongid",92;"tupleType",46;"typeArgument",139];[",",-93;">",-93];["%",-94;"&",-94;"&&",-94;")",-94;"+",-94;",",-94;"-",-94;"..",-94;"/",-94;"::",-94;":?",-94;":?>",-94;";",-94;"<<",-94;"<>",-94;"<|",-94;"<||",-94;"<|||",-94;"=",-94;">>",-94;"@",-94;"RHSEND",-94;"RRPAREN",-94;"]",-94;"|>",-94;"|]",-94;"||",-94;"||>",-94;"|||",-94;"|||>",-94];["(",19;"IDENT",47;"LITERAL",23;"[",88;"[|",7;"appExpr",142;"arrayExpr",24;"atomicExpr",116;"identExpr",25;"listExpr",26;"parenExpr",27;"qualificationExpr",108;"revAppExpr",2;"revQualificationExpr",102];["%",-95;"&",-95;"&&",-95;")",-95;"+",-95;",",-95;"-",-95;"..",-95;"/",-95;"::",-95;":?",-95;":?>",-95;";",-95;"<<",-95;"<>",-95;"<|",-95;"<||",-95;"<|||",-95;"=",-95;">>",-95;"@",-95;"RHSEND",-95;"RRPAREN",-95;"]",-95;"|>",-95;"|]",-95;"||",-95;"||>",-95;"|||",-95;"|||>",-95];[")",-96;";",-96;"RHSEND",-96;"RRPAREN",-96;"]",-96;"|]",-96];[")",-97;";",-97;"RHSEND",-97;"RRPAREN",-97;"]",-97;"|]",-97]]
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
    ["atomicExpr";"identExpr"], fun(ss:obj list)->
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
    ["identExpr";"IDENT"], fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let result:option<int>*Expr =
            fst s0, IdentExpr(snd s0)
        box result
    ["identExpr";"IDENT";"<";"typeArguments";">"], fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int>*TypeArgument) list> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*Expr =
            let targs = s2 |> List.map snd |> List.rev
            fst s0, TypeApplicationExpr(snd s0,targs) 
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
    ["qualificationSuffix";".";"[";"tupleExpr";"]"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*Expr =
            s2
        box result
    ["qualificationSuffix";".";"identExpr"], fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Expr> ss.[1]
        let result:option<int>*Expr =
            s1
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