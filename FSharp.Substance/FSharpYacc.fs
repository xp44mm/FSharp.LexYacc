module FSharp.Substance.FSharpYacc
open FSharp.LexYacc
open FSharp.Idioms
let stateSymbols: string[] = [|"";"file";"revAppExpr";"appType";"appType";"suffixType";"atomType";"[|";"revSequentialExpr";"|]";"|]";"(";"typeArgument";")";"TYPAR";"longid";"<";"typeArguments";">";"(";"infix";")";"LITERAL";"arrayExpr";"identExpr";"listExpr";"parenExpr";"recdLiteralExpr";"IDENT";":";"typeArgument";"parameterPattern";"revBinaryExpr";"bindKeyword";"bindingPattern";"=";"valueRhs";"AND";"AND_BANG";"LET";"LET_BANG";"USE";"USE_BANG";"tuplePattern";"FOR";"parameterPattern";"IN";"binaryExpr";"DO";"valueRhs";"bindExpr";"produceKeyword";"valueExpr";"qualificationExpr";"<-";"valueRhs";"valueExpr";"whileKeyword";"binaryExpr";"DO";"valueRhs";"IDENT";"=";"valueRhs";"fieldBinding";"fieldBindings";";";"fieldBinding";"MODULE";"longid";"EOF";"revOpenOrLets";"EOF";"funType";"->";"tupleType";"tupleType";"IDENT";"<";"typeArguments";">";"revIfParts";"RHSEND";"*";"+";"+";"-";"-";"=";"ALWAYS_INFIX";"FUN";"parameterPattern";"->";"tupleRhs";"[";"]";"revSequentialExpr";"]";"revLongid";"patternAndGuard";"->";"tupleRhs";"FUNCTION";"opt_bar";"revMatchClauses";"RHSEND";"matchKeyword";"tupleExpr";"WITH";"opt_bar";"revMatchClauses";"RHSEND";"MATCH";"MATCH_BANG";"IDENT";"LITERAL";"OPEN";"longid";"bindExpr";"|";"(";"bindingPattern";")";"IDENT";"revSequentialExpr";")";"matchPattern";"WHEN";"binaryExpr";"+";"-";"ALWAYS_PREFIX";"DO_BANG";"RETURN";"RETURN_BANG";"YIELD";"YIELD_BANG";"revQualificationExpr";".";"[";"tupleExpr";"]";"identExpr";"{";"}";"qualificationExpr";"qualificationExpr";"infix";"unaryExpr";"unaryExpr";"IF";"binaryExpr";"THEN";"valueRhs";"ELIF";"binaryExpr";"THEN";"valueRhs";"ELSE";"valueRhs";"IDENT";".";"IDENT";"matchClause";"|";"matchClause";"openOrLet";";";"openOrLet";"atomicExpr";"qualificationSuffix";"declExpr";"revSequentialExpr";"revSequentialExpr";";";"declExpr";"binaryExpr";"revTupleExpr";",";"binaryExpr";"[";"]";"longid";"atomicPattern";",";"atomicPattern";"LLPAREN";"RRPAREN";"tupleExpr";"*";"typeArgument";",";"typeArgument";"appExpr";"prefix";"appExpr";"ifExpr";"lambdaExpr";"matchExpr";"tupleExpr";"LLPAREN";"RRPAREN";"valueExpr";"WHILE";"WHILE_BANG"|]
let actions: (string * int) list list = [["MODULE",68;"file",1];["",0];["(",19;")",-1;"*",-1;"+",-1;",",-1;"-",-1;"->",-1;";",-1;"=",-1;"ALWAYS_INFIX",-1;"DO",-1;"ELIF",-1;"ELSE",-1;"EOF",-1;"IDENT",77;"LITERAL",22;"RHSEND",-1;"RRPAREN",-1;"THEN",-1;"WITH",-1;"[",94;"[|",7;"]",-1;"arrayExpr",23;"atomicExpr",169;"identExpr",24;"listExpr",25;"parenExpr",26;"qualificationExpr",146;"recdLiteralExpr",27;"revQualificationExpr",137;"{",143;"|",-1;"|]",-1;"}",-1];[")",-107;"*",-107;",",-107;"->",-107;"=",-107;">",-107;"IDENT",160;"[",180;"longid",182;"revLongid",98;"suffixType",5];[")",-108;"*",-108;",",-108;"->",-108;"=",-108;">",-108;"IDENT",160;"[",180;"longid",182;"revLongid",98;"suffixType",5];[")",-2;"*",-2;",",-2;"->",-2;"=",-2;">",-2;"IDENT",-2;"[",-2];[")",-3;"*",-3;",",-3;"->",-3;"=",-3;">",-3;"IDENT",-3;"[",-3];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"AND",37;"AND_BANG",38;"DO_BANG",132;"FOR",44;"FUN",90;"FUNCTION",102;"IDENT",77;"IF",150;"LET",39;"LET_BANG",40;"LITERAL",22;"MATCH",112;"MATCH_BANG",113;"RETURN",133;"RETURN_BANG",134;"USE",41;"USE_BANG",42;"WHILE",203;"WHILE_BANG",204;"YIELD",135;"YIELD_BANG",136;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"bindExpr",50;"bindKeyword",33;"declExpr",171;"identExpr",24;"ifExpr",196;"lambdaExpr",197;"listExpr",25;"matchExpr",198;"matchKeyword",106;"parenExpr",26;"prefix",194;"produceKeyword",51;"qualificationExpr",53;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revIfParts",81;"revQualificationExpr",137;"revSequentialExpr",8;"revTupleExpr",177;"tupleExpr",199;"unaryExpr",149;"valueExpr",56;"whileKeyword",57;"{",143;"|]",10];[";",174;"|]",9];["(",-4;")",-4;"*",-4;"+",-4;",",-4;"-",-4;"->",-4;".",-4;";",-4;"<-",-4;"=",-4;"ALWAYS_INFIX",-4;"DO",-4;"ELIF",-4;"ELSE",-4;"EOF",-4;"IDENT",-4;"LITERAL",-4;"RHSEND",-4;"RRPAREN",-4;"THEN",-4;"WITH",-4;"[",-4;"[|",-4;"]",-4;"{",-4;"|",-4;"|]",-4;"}",-4];["(",-5;")",-5;"*",-5;"+",-5;",",-5;"-",-5;"->",-5;".",-5;";",-5;"<-",-5;"=",-5;"ALWAYS_INFIX",-5;"DO",-5;"ELIF",-5;"ELSE",-5;"EOF",-5;"IDENT",-5;"LITERAL",-5;"RHSEND",-5;"RRPAREN",-5;"THEN",-5;"WITH",-5;"[",-5;"[|",-5;"]",-5;"{",-5;"|",-5;"|]",-5;"}",-5];["(",11;"IDENT",160;"TYPAR",14;"appType",3;"atomType",6;"funType",73;"longid",15;"revLongid",98;"tupleType",76;"typeArgument",12];[")",13];[")",-6;"*",-6;",",-6;"->",-6;"=",-6;">",-6;"IDENT",-6;"[",-6];[")",-7;"*",-7;",",-7;"->",-7;"=",-7;">",-7;"IDENT",-7;"[",-7];[")",-8;"*",-8;",",-8;"->",-8;"<",16;"=",-8;">",-8;"IDENT",-8;"[",-8];["(",11;"IDENT",160;"TYPAR",14;"appType",3;"atomType",6;"funType",73;"longid",15;"revLongid",98;"tupleType",76;"typeArgument",190;"typeArguments",17];[",",191;">",18];[")",-9;"*",-9;",",-9;"->",-9;"=",-9;">",-9;"IDENT",-9;"[",-9];["(",19;"*",83;"+",85;"-",87;"=",88;"ALWAYS_INFIX",89;"ALWAYS_PREFIX",131;"AND",37;"AND_BANG",38;"DO_BANG",132;"FOR",44;"FUN",90;"FUNCTION",102;"IDENT",77;"IF",150;"LET",39;"LET_BANG",40;"LITERAL",22;"MATCH",112;"MATCH_BANG",113;"RETURN",133;"RETURN_BANG",134;"USE",41;"USE_BANG",42;"WHILE",203;"WHILE_BANG",204;"YIELD",135;"YIELD_BANG",136;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"bindExpr",50;"bindKeyword",33;"declExpr",171;"identExpr",24;"ifExpr",196;"infix",20;"lambdaExpr",197;"listExpr",25;"matchExpr",198;"matchKeyword",106;"parenExpr",26;"prefix",194;"produceKeyword",51;"qualificationExpr",53;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revIfParts",81;"revQualificationExpr",137;"revSequentialExpr",124;"revTupleExpr",177;"tupleExpr",199;"unaryExpr",149;"valueExpr",56;"whileKeyword",57;"{",143];[")",21];["(",-10;")",-10;"*",-10;"+",-10;",",-10;"-",-10;"->",-10;".",-10;";",-10;"<-",-10;"=",-10;"ALWAYS_INFIX",-10;"DO",-10;"ELIF",-10;"ELSE",-10;"EOF",-10;"IDENT",-10;"LITERAL",-10;"RHSEND",-10;"RRPAREN",-10;"THEN",-10;"WITH",-10;"[",-10;"[|",-10;"]",-10;"{",-10;"|",-10;"|]",-10;"}",-10];["(",-11;")",-11;"*",-11;"+",-11;",",-11;"-",-11;"->",-11;".",-11;";",-11;"<-",-11;"=",-11;"ALWAYS_INFIX",-11;"DO",-11;"ELIF",-11;"ELSE",-11;"EOF",-11;"IDENT",-11;"LITERAL",-11;"RHSEND",-11;"RRPAREN",-11;"THEN",-11;"WITH",-11;"[",-11;"[|",-11;"]",-11;"{",-11;"|",-11;"|]",-11;"}",-11];["(",-12;")",-12;"*",-12;"+",-12;",",-12;"-",-12;"->",-12;".",-12;";",-12;"<-",-12;"=",-12;"ALWAYS_INFIX",-12;"DO",-12;"ELIF",-12;"ELSE",-12;"EOF",-12;"IDENT",-12;"LITERAL",-12;"RHSEND",-12;"RRPAREN",-12;"THEN",-12;"WITH",-12;"[",-12;"[|",-12;"]",-12;"{",-12;"|",-12;"|]",-12;"}",-12];["(",-13;")",-13;"*",-13;"+",-13;",",-13;"-",-13;"->",-13;".",-13;";",-13;"<-",-13;"=",-13;"ALWAYS_INFIX",-13;"DO",-13;"ELIF",-13;"ELSE",-13;"EOF",-13;"IDENT",-13;"LITERAL",-13;"RHSEND",-13;"RRPAREN",-13;"THEN",-13;"WITH",-13;"[",-13;"[|",-13;"]",-13;"{",-13;"|",-13;"|]",-13;"}",-13];["(",-14;")",-14;"*",-14;"+",-14;",",-14;"-",-14;"->",-14;".",-14;";",-14;"<-",-14;"=",-14;"ALWAYS_INFIX",-14;"DO",-14;"ELIF",-14;"ELSE",-14;"EOF",-14;"IDENT",-14;"LITERAL",-14;"RHSEND",-14;"RRPAREN",-14;"THEN",-14;"WITH",-14;"[",-14;"[|",-14;"]",-14;"{",-14;"|",-14;"|]",-14;"}",-14];["(",-15;")",-15;"*",-15;"+",-15;",",-15;"-",-15;"->",-15;".",-15;";",-15;"<-",-15;"=",-15;"ALWAYS_INFIX",-15;"DO",-15;"ELIF",-15;"ELSE",-15;"EOF",-15;"IDENT",-15;"LITERAL",-15;"RHSEND",-15;"RRPAREN",-15;"THEN",-15;"WITH",-15;"[",-15;"[|",-15;"]",-15;"{",-15;"|",-15;"|]",-15;"}",-15];["(",-16;")",-16;"*",-16;"+",-16;",",-16;"-",-16;"->",-16;".",-16;";",-16;"<-",-16;"=",-16;"ALWAYS_INFIX",-16;"DO",-16;"ELIF",-16;"ELSE",-16;"EOF",-16;"IDENT",-16;"LITERAL",-16;"RHSEND",-16;"RRPAREN",-16;"THEN",-16;"WITH",-16;"[",-16;"[|",-16;"]",-16;"{",-16;"|",-16;"|]",-16;"}",-16];[")",-65;",",-65;":",29;"=",-65];["(",11;"IDENT",160;"TYPAR",14;"appType",3;"atomType",6;"funType",73;"longid",15;"revLongid",98;"tupleType",76;"typeArgument",30];[")",-17;",",-17;"=",-17];[")",-18;",",-18;"=",-18];[")",-19;"*",83;"+",84;",",-19;"-",86;"->",-19;";",-19;"=",88;"ALWAYS_INFIX",89;"DO",-19;"ELIF",-19;"ELSE",-19;"EOF",-19;"RHSEND",-19;"RRPAREN",-19;"THEN",-19;"WITH",-19;"]",-19;"infix",147;"|",-19;"|]",-19;"}",-19];["(",120;"IDENT",28;"atomicPattern",183;"bindingPattern",34;"parameterPattern",31;"tuplePattern",43];["=",35];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"FUN",90;"FUNCTION",102;"IDENT",77;"IF",150;"LITERAL",22;"LLPAREN",200;"MATCH",112;"MATCH_BANG",113;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"identExpr",24;"ifExpr",196;"lambdaExpr",197;"listExpr",25;"matchExpr",198;"matchKeyword",106;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revIfParts",81;"revQualificationExpr",137;"revTupleExpr",177;"tupleExpr",199;"unaryExpr",149;"valueExpr",202;"valueRhs",36;"{",143];[")",-20;";",-20;"EOF",-20;"RRPAREN",-20;"]",-20;"|]",-20];["(",-21;"IDENT",-21];["(",-22;"IDENT",-22];["(",-23;"IDENT",-23];["(",-24;"IDENT",-24];["(",-25;"IDENT",-25];["(",-26;"IDENT",-26];[")",-27;",",184;"=",-27];["(",120;"IDENT",123;"parameterPattern",45];["IN",46];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"IDENT",77;"LITERAL",22;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",47;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",137;"unaryExpr",149;"{",143];["DO",48];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"FUN",90;"FUNCTION",102;"IDENT",77;"IF",150;"LITERAL",22;"LLPAREN",200;"MATCH",112;"MATCH_BANG",113;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"identExpr",24;"ifExpr",196;"lambdaExpr",197;"listExpr",25;"matchExpr",198;"matchKeyword",106;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revIfParts",81;"revQualificationExpr",137;"revTupleExpr",177;"tupleExpr",199;"unaryExpr",149;"valueExpr",202;"valueRhs",49;"{",143];[")",-28;";",-28;"RRPAREN",-28;"]",-28;"|]",-28];[")",-29;";",-29;"RRPAREN",-29;"]",-29;"|]",-29];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"FUN",90;"FUNCTION",102;"IDENT",77;"IF",150;"LITERAL",22;"MATCH",112;"MATCH_BANG",113;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"identExpr",24;"ifExpr",196;"lambdaExpr",197;"listExpr",25;"matchExpr",198;"matchKeyword",106;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revIfParts",81;"revQualificationExpr",137;"revTupleExpr",177;"tupleExpr",199;"unaryExpr",149;"valueExpr",52;"{",143];[")",-30;";",-30;"RRPAREN",-30;"]",-30;"|]",-30];["(",-81;")",-81;"*",-81;"+",-81;",",-81;"-",-81;";",-81;"<-",54;"=",-81;"ALWAYS_INFIX",-81;"IDENT",-81;"LITERAL",-81;"RRPAREN",-81;"[",-81;"[|",-81;"]",-81;"{",-81;"|]",-81];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"FUN",90;"FUNCTION",102;"IDENT",77;"IF",150;"LITERAL",22;"LLPAREN",200;"MATCH",112;"MATCH_BANG",113;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"identExpr",24;"ifExpr",196;"lambdaExpr",197;"listExpr",25;"matchExpr",198;"matchKeyword",106;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revIfParts",81;"revQualificationExpr",137;"revTupleExpr",177;"tupleExpr",199;"unaryExpr",149;"valueExpr",202;"valueRhs",55;"{",143];[")",-31;";",-31;"RRPAREN",-31;"]",-31;"|]",-31];[")",-32;";",-32;"RRPAREN",-32;"]",-32;"|]",-32];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"IDENT",77;"LITERAL",22;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",58;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",137;"unaryExpr",149;"{",143];["DO",59];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"FUN",90;"FUNCTION",102;"IDENT",77;"IF",150;"LITERAL",22;"LLPAREN",200;"MATCH",112;"MATCH_BANG",113;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"identExpr",24;"ifExpr",196;"lambdaExpr",197;"listExpr",25;"matchExpr",198;"matchKeyword",106;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revIfParts",81;"revQualificationExpr",137;"revTupleExpr",177;"tupleExpr",199;"unaryExpr",149;"valueExpr",202;"valueRhs",60;"{",143];[")",-33;";",-33;"RRPAREN",-33;"]",-33;"|]",-33];["=",62];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"FUN",90;"FUNCTION",102;"IDENT",77;"IF",150;"LITERAL",22;"LLPAREN",200;"MATCH",112;"MATCH_BANG",113;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"identExpr",24;"ifExpr",196;"lambdaExpr",197;"listExpr",25;"matchExpr",198;"matchKeyword",106;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revIfParts",81;"revQualificationExpr",137;"revTupleExpr",177;"tupleExpr",199;"unaryExpr",149;"valueExpr",202;"valueRhs",63;"{",143];[";",-34;"}",-34];[";",-35;"}",-35];[";",66;"}",144];["IDENT",61;"fieldBinding",67];[";",-36;"}",-36];["IDENT",160;"longid",69;"revLongid",98];["AND",37;"AND_BANG",38;"EOF",70;"LET",39;"LET_BANG",40;"OPEN",116;"USE",41;"USE_BANG",42;"bindExpr",118;"bindKeyword",33;"openOrLet",166;"revOpenOrLets",71];["",-37];[";",167;"EOF",72];["",-38];[")",-109;",",-109;"->",74;"=",-109;">",-109];["(",11;"IDENT",160;"TYPAR",14;"appType",3;"atomType",6;"longid",15;"revLongid",98;"tupleType",75];[")",-39;"*",189;",",-39;"->",-39;"=",-39;">",-39];[")",-40;"*",189;",",-40;"->",-40;"=",-40;">",-40];["(",-41;")",-41;"*",-41;"+",-41;",",-41;"-",-41;"->",-41;".",-41;";",-41;"<",78;"<-",-41;"=",-41;"ALWAYS_INFIX",-41;"DO",-41;"ELIF",-41;"ELSE",-41;"EOF",-41;"IDENT",-41;"LITERAL",-41;"RHSEND",-41;"RRPAREN",-41;"THEN",-41;"WITH",-41;"[",-41;"[|",-41;"]",-41;"{",-41;"|",-41;"|]",-41;"}",-41];["(",11;"IDENT",160;"TYPAR",14;"appType",3;"atomType",6;"funType",73;"longid",15;"revLongid",98;"tupleType",76;"typeArgument",190;"typeArguments",79];[",",191;">",80];["(",-42;")",-42;"*",-42;"+",-42;",",-42;"-",-42;"->",-42;".",-42;";",-42;"<-",-42;"=",-42;"ALWAYS_INFIX",-42;"DO",-42;"ELIF",-42;"ELSE",-42;"EOF",-42;"IDENT",-42;"LITERAL",-42;"RHSEND",-42;"RRPAREN",-42;"THEN",-42;"WITH",-42;"[",-42;"[|",-42;"]",-42;"{",-42;"|",-42;"|]",-42;"}",-42];["ELIF",154;"ELSE",158;"RHSEND",82];[")",-43;";",-43;"ELIF",-43;"ELSE",-43;"EOF",-43;"RHSEND",-43;"RRPAREN",-43;"]",-43;"|]",-43;"}",-43];["(",-44;")",-44;"+",-44;"-",-44;"ALWAYS_PREFIX",-44;"IDENT",-44;"LITERAL",-44;"[",-44;"[|",-44;"{",-44];["(",-45;"+",-45;"-",-45;"ALWAYS_PREFIX",-45;"IDENT",-45;"LITERAL",-45;"[",-45;"[|",-45;"{",-45];["(",-69;")",-45;"IDENT",-69;"LITERAL",-69;"[",-69;"[|",-69;"{",-69];["(",-46;"+",-46;"-",-46;"ALWAYS_PREFIX",-46;"IDENT",-46;"LITERAL",-46;"[",-46;"[|",-46;"{",-46];["(",-70;")",-46;"IDENT",-70;"LITERAL",-70;"[",-70;"[|",-70;"{",-70];["(",-47;")",-47;"+",-47;"-",-47;"ALWAYS_PREFIX",-47;"IDENT",-47;"LITERAL",-47;"[",-47;"[|",-47;"{",-47];["(",-48;")",-48;"+",-48;"-",-48;"ALWAYS_PREFIX",-48;"IDENT",-48;"LITERAL",-48;"[",-48;"[|",-48;"{",-48];["(",120;"IDENT",123;"parameterPattern",91];["->",92];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"IDENT",77;"LITERAL",22;"LLPAREN",186;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",137;"revTupleExpr",177;"tupleExpr",188;"tupleRhs",93;"unaryExpr",149;"{",143];[")",-49;";",-49;"ELIF",-49;"ELSE",-49;"EOF",-49;"RHSEND",-49;"RRPAREN",-49;"]",-49;"|]",-49;"}",-49];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"AND",37;"AND_BANG",38;"DO_BANG",132;"FOR",44;"FUN",90;"FUNCTION",102;"IDENT",77;"IF",150;"LET",39;"LET_BANG",40;"LITERAL",22;"MATCH",112;"MATCH_BANG",113;"RETURN",133;"RETURN_BANG",134;"USE",41;"USE_BANG",42;"WHILE",203;"WHILE_BANG",204;"YIELD",135;"YIELD_BANG",136;"[",94;"[|",7;"]",95;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"bindExpr",50;"bindKeyword",33;"declExpr",171;"identExpr",24;"ifExpr",196;"lambdaExpr",197;"listExpr",25;"matchExpr",198;"matchKeyword",106;"parenExpr",26;"prefix",194;"produceKeyword",51;"qualificationExpr",53;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revIfParts",81;"revQualificationExpr",137;"revSequentialExpr",96;"revTupleExpr",177;"tupleExpr",199;"unaryExpr",149;"valueExpr",56;"whileKeyword",57;"{",143];["(",-50;")",-50;"*",-50;"+",-50;",",-50;"-",-50;"->",-50;".",-50;";",-50;"<-",-50;"=",-50;"ALWAYS_INFIX",-50;"DO",-50;"ELIF",-50;"ELSE",-50;"EOF",-50;"IDENT",-50;"LITERAL",-50;"RHSEND",-50;"RRPAREN",-50;"THEN",-50;"WITH",-50;"[",-50;"[|",-50;"]",-50;"{",-50;"|",-50;"|]",-50;"}",-50];[";",174;"]",97];["(",-51;")",-51;"*",-51;"+",-51;",",-51;"-",-51;"->",-51;".",-51;";",-51;"<-",-51;"=",-51;"ALWAYS_INFIX",-51;"DO",-51;"ELIF",-51;"ELSE",-51;"EOF",-51;"IDENT",-51;"LITERAL",-51;"RHSEND",-51;"RRPAREN",-51;"THEN",-51;"WITH",-51;"[",-51;"[|",-51;"]",-51;"{",-51;"|",-51;"|]",-51;"}",-51];[")",-52;"*",-52;",",-52;"->",-52;".",161;";",-52;"<",-52;"=",-52;">",-52;"AND",-52;"AND_BANG",-52;"EOF",-52;"IDENT",-52;"LET",-52;"LET_BANG",-52;"OPEN",-52;"USE",-52;"USE_BANG",-52;"[",-52];["->",100];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"IDENT",77;"LITERAL",22;"LLPAREN",186;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",137;"revTupleExpr",177;"tupleExpr",188;"tupleRhs",101;"unaryExpr",149;"{",143];["RHSEND",-53;"|",-53];["IDENT",-62;"LITERAL",-62;"opt_bar",103;"|",119];["IDENT",114;"LITERAL",115;"matchClause",163;"matchPattern",126;"patternAndGuard",99;"revMatchClauses",104];["RHSEND",105;"|",164];[")",-54;";",-54;"ELIF",-54;"ELSE",-54;"EOF",-54;"RHSEND",-54;"RRPAREN",-54;"]",-54;"|]",-54;"}",-54];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"IDENT",77;"LITERAL",22;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",137;"revTupleExpr",177;"tupleExpr",107;"unaryExpr",149;"{",143];["WITH",108];["IDENT",-62;"LITERAL",-62;"opt_bar",109;"|",119];["IDENT",114;"LITERAL",115;"matchClause",163;"matchPattern",126;"patternAndGuard",99;"revMatchClauses",110];["RHSEND",111;"|",164];[")",-55;";",-55;"ELIF",-55;"ELSE",-55;"EOF",-55;"RHSEND",-55;"RRPAREN",-55;"]",-55;"|]",-55;"}",-55];["(",-56;"+",-56;"-",-56;"ALWAYS_PREFIX",-56;"IDENT",-56;"LITERAL",-56;"[",-56;"[|",-56;"{",-56];["(",-57;"+",-57;"-",-57;"ALWAYS_PREFIX",-57;"IDENT",-57;"LITERAL",-57;"[",-57;"[|",-57;"{",-57];["->",-58;"WHEN",-58];["->",-59;"WHEN",-59];["IDENT",160;"longid",117;"revLongid",98];[";",-60;"EOF",-60];[";",-61;"EOF",-61];["IDENT",-63;"LITERAL",-63];["(",120;"IDENT",28;"atomicPattern",183;"bindingPattern",121;"parameterPattern",31;"tuplePattern",43];[")",122];[")",-64;",",-64;"->",-64;"=",-64;"IN",-64];["->",-65;"IN",-65];[")",125;";",174];["(",-66;")",-66;"*",-66;"+",-66;",",-66;"-",-66;"->",-66;".",-66;";",-66;"<-",-66;"=",-66;"ALWAYS_INFIX",-66;"DO",-66;"ELIF",-66;"ELSE",-66;"EOF",-66;"IDENT",-66;"LITERAL",-66;"RHSEND",-66;"RRPAREN",-66;"THEN",-66;"WITH",-66;"[",-66;"[|",-66;"]",-66;"{",-66;"|",-66;"|]",-66;"}",-66];["->",-67;"WHEN",127];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"IDENT",77;"LITERAL",22;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",128;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",137;"unaryExpr",149;"{",143];["->",-68];["(",-69;"IDENT",-69;"LITERAL",-69;"[",-69;"[|",-69;"{",-69];["(",-70;"IDENT",-70;"LITERAL",-70;"[",-70;"[|",-70;"{",-70];["(",-71;"IDENT",-71;"LITERAL",-71;"[",-71;"[|",-71;"{",-71];["(",-72;"+",-72;"-",-72;"ALWAYS_PREFIX",-72;"FUN",-72;"FUNCTION",-72;"IDENT",-72;"IF",-72;"LITERAL",-72;"MATCH",-72;"MATCH_BANG",-72;"[",-72;"[|",-72;"{",-72];["(",-73;"+",-73;"-",-73;"ALWAYS_PREFIX",-73;"FUN",-73;"FUNCTION",-73;"IDENT",-73;"IF",-73;"LITERAL",-73;"MATCH",-73;"MATCH_BANG",-73;"[",-73;"[|",-73;"{",-73];["(",-74;"+",-74;"-",-74;"ALWAYS_PREFIX",-74;"FUN",-74;"FUNCTION",-74;"IDENT",-74;"IF",-74;"LITERAL",-74;"MATCH",-74;"MATCH_BANG",-74;"[",-74;"[|",-74;"{",-74];["(",-75;"+",-75;"-",-75;"ALWAYS_PREFIX",-75;"FUN",-75;"FUNCTION",-75;"IDENT",-75;"IF",-75;"LITERAL",-75;"MATCH",-75;"MATCH_BANG",-75;"[",-75;"[|",-75;"{",-75];["(",-76;"+",-76;"-",-76;"ALWAYS_PREFIX",-76;"FUN",-76;"FUNCTION",-76;"IDENT",-76;"IF",-76;"LITERAL",-76;"MATCH",-76;"MATCH_BANG",-76;"[",-76;"[|",-76;"{",-76];["(",-77;")",-77;"*",-77;"+",-77;",",-77;"-",-77;"->",-77;".",138;";",-77;"<-",-77;"=",-77;"ALWAYS_INFIX",-77;"DO",-77;"ELIF",-77;"ELSE",-77;"EOF",-77;"IDENT",-77;"LITERAL",-77;"RHSEND",-77;"RRPAREN",-77;"THEN",-77;"WITH",-77;"[",-77;"[|",-77;"]",-77;"qualificationSuffix",170;"{",-77;"|",-77;"|]",-77;"}",-77];["IDENT",77;"[",139;"identExpr",142];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"IDENT",77;"LITERAL",22;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",137;"revTupleExpr",177;"tupleExpr",140;"unaryExpr",149;"{",143];["]",141];["(",-78;")",-78;"*",-78;"+",-78;",",-78;"-",-78;"->",-78;".",-78;";",-78;"<-",-78;"=",-78;"ALWAYS_INFIX",-78;"DO",-78;"ELIF",-78;"ELSE",-78;"EOF",-78;"IDENT",-78;"LITERAL",-78;"RHSEND",-78;"RRPAREN",-78;"THEN",-78;"WITH",-78;"[",-78;"[|",-78;"]",-78;"{",-78;"|",-78;"|]",-78;"}",-78];["(",-79;")",-79;"*",-79;"+",-79;",",-79;"-",-79;"->",-79;".",-79;";",-79;"<-",-79;"=",-79;"ALWAYS_INFIX",-79;"DO",-79;"ELIF",-79;"ELSE",-79;"EOF",-79;"IDENT",-79;"LITERAL",-79;"RHSEND",-79;"RRPAREN",-79;"THEN",-79;"WITH",-79;"[",-79;"[|",-79;"]",-79;"{",-79;"|",-79;"|]",-79;"}",-79];["IDENT",61;"fieldBinding",64;"fieldBindings",65];["(",-80;")",-80;"*",-80;"+",-80;",",-80;"-",-80;"->",-80;".",-80;";",-80;"<-",-80;"=",-80;"ALWAYS_INFIX",-80;"DO",-80;"ELIF",-80;"ELSE",-80;"EOF",-80;"IDENT",-80;"LITERAL",-80;"RHSEND",-80;"RRPAREN",-80;"THEN",-80;"WITH",-80;"[",-80;"[|",-80;"]",-80;"{",-80;"|",-80;"|]",-80;"}",-80];["(",-81;")",-81;"*",-81;"+",-81;",",-81;"-",-81;"->",-81;";",-81;"=",-81;"ALWAYS_INFIX",-81;"DO",-81;"ELIF",-81;"ELSE",-81;"EOF",-81;"IDENT",-81;"LITERAL",-81;"RHSEND",-81;"RRPAREN",-81;"THEN",-81;"WITH",-81;"[",-81;"[|",-81;"]",-81;"{",-81;"|",-81;"|]",-81;"}",-81];["(",-82;")",-82;"*",-82;"+",-82;",",-82;"-",-82;"->",-82;";",-82;"=",-82;"ALWAYS_INFIX",-82;"DO",-82;"ELIF",-82;"ELSE",-82;"EOF",-82;"IDENT",-82;"LITERAL",-82;"RHSEND",-82;"RRPAREN",-82;"THEN",-82;"WITH",-82;"[",-82;"[|",-82;"]",-82;"{",-82;"|",-82;"|]",-82;"}",-82];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"IDENT",77;"LITERAL",22;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revQualificationExpr",137;"unaryExpr",148;"{",143];[")",-83;"*",-83;"+",-83;",",-83;"-",-83;"->",-83;";",-83;"=",-83;"ALWAYS_INFIX",-83;"DO",-83;"ELIF",-83;"ELSE",-83;"EOF",-83;"RHSEND",-83;"RRPAREN",-83;"THEN",-83;"WITH",-83;"]",-83;"|",-83;"|]",-83;"}",-83];[")",-84;"*",-84;"+",-84;",",-84;"-",-84;"->",-84;";",-84;"=",-84;"ALWAYS_INFIX",-84;"DO",-84;"ELIF",-84;"ELSE",-84;"EOF",-84;"RHSEND",-84;"RRPAREN",-84;"THEN",-84;"WITH",-84;"]",-84;"|",-84;"|]",-84;"}",-84];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"IDENT",77;"LITERAL",22;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",151;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",137;"unaryExpr",149;"{",143];["THEN",152];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"FUN",90;"FUNCTION",102;"IDENT",77;"IF",150;"LITERAL",22;"LLPAREN",200;"MATCH",112;"MATCH_BANG",113;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"identExpr",24;"ifExpr",196;"lambdaExpr",197;"listExpr",25;"matchExpr",198;"matchKeyword",106;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revIfParts",81;"revQualificationExpr",137;"revTupleExpr",177;"tupleExpr",199;"unaryExpr",149;"valueExpr",202;"valueRhs",153;"{",143];["ELIF",-85;"ELSE",-85;"RHSEND",-85];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"IDENT",77;"LITERAL",22;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",155;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",137;"unaryExpr",149;"{",143];["THEN",156];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"FUN",90;"FUNCTION",102;"IDENT",77;"IF",150;"LITERAL",22;"LLPAREN",200;"MATCH",112;"MATCH_BANG",113;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"identExpr",24;"ifExpr",196;"lambdaExpr",197;"listExpr",25;"matchExpr",198;"matchKeyword",106;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revIfParts",81;"revQualificationExpr",137;"revTupleExpr",177;"tupleExpr",199;"unaryExpr",149;"valueExpr",202;"valueRhs",157;"{",143];["ELIF",-86;"ELSE",-86;"RHSEND",-86];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"FUN",90;"FUNCTION",102;"IDENT",77;"IF",150;"LITERAL",22;"LLPAREN",200;"MATCH",112;"MATCH_BANG",113;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"identExpr",24;"ifExpr",196;"lambdaExpr",197;"listExpr",25;"matchExpr",198;"matchKeyword",106;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revIfParts",81;"revQualificationExpr",137;"revTupleExpr",177;"tupleExpr",199;"unaryExpr",149;"valueExpr",202;"valueRhs",159;"{",143];["ELIF",-87;"ELSE",-87;"RHSEND",-87];[")",-88;"*",-88;",",-88;"->",-88;".",-88;";",-88;"<",-88;"=",-88;">",-88;"AND",-88;"AND_BANG",-88;"EOF",-88;"IDENT",-88;"LET",-88;"LET_BANG",-88;"OPEN",-88;"USE",-88;"USE_BANG",-88;"[",-88];["IDENT",162];[")",-89;"*",-89;",",-89;"->",-89;".",-89;";",-89;"<",-89;"=",-89;">",-89;"AND",-89;"AND_BANG",-89;"EOF",-89;"IDENT",-89;"LET",-89;"LET_BANG",-89;"OPEN",-89;"USE",-89;"USE_BANG",-89;"[",-89];["RHSEND",-90;"|",-90];["IDENT",114;"LITERAL",115;"matchClause",165;"matchPattern",126;"patternAndGuard",99];["RHSEND",-91;"|",-91];[";",-92;"EOF",-92];["AND",37;"AND_BANG",38;"LET",39;"LET_BANG",40;"OPEN",116;"USE",41;"USE_BANG",42;"bindExpr",118;"bindKeyword",33;"openOrLet",168];[";",-93;"EOF",-93];["(",-94;")",-94;"*",-94;"+",-94;",",-94;"-",-94;"->",-94;".",-94;";",-94;"<-",-94;"=",-94;"ALWAYS_INFIX",-94;"DO",-94;"ELIF",-94;"ELSE",-94;"EOF",-94;"IDENT",-94;"LITERAL",-94;"RHSEND",-94;"RRPAREN",-94;"THEN",-94;"WITH",-94;"[",-94;"[|",-94;"]",-94;"{",-94;"|",-94;"|]",-94;"}",-94];["(",-95;")",-95;"*",-95;"+",-95;",",-95;"-",-95;"->",-95;".",-95;";",-95;"<-",-95;"=",-95;"ALWAYS_INFIX",-95;"DO",-95;"ELIF",-95;"ELSE",-95;"EOF",-95;"IDENT",-95;"LITERAL",-95;"RHSEND",-95;"RRPAREN",-95;"THEN",-95;"WITH",-95;"[",-95;"[|",-95;"]",-95;"{",-95;"|",-95;"|]",-95;"}",-95];[")",-96;";",-96;"RRPAREN",-96;"]",-96;"|]",-96];[";",174;"RRPAREN",187];[";",174;"RRPAREN",201];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"AND",37;"AND_BANG",38;"DO_BANG",132;"FOR",44;"FUN",90;"FUNCTION",102;"IDENT",77;"IF",150;"LET",39;"LET_BANG",40;"LITERAL",22;"MATCH",112;"MATCH_BANG",113;"RETURN",133;"RETURN_BANG",134;"USE",41;"USE_BANG",42;"WHILE",203;"WHILE_BANG",204;"YIELD",135;"YIELD_BANG",136;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"bindExpr",50;"bindKeyword",33;"declExpr",175;"identExpr",24;"ifExpr",196;"lambdaExpr",197;"listExpr",25;"matchExpr",198;"matchKeyword",106;"parenExpr",26;"prefix",194;"produceKeyword",51;"qualificationExpr",53;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revIfParts",81;"revQualificationExpr",137;"revTupleExpr",177;"tupleExpr",199;"unaryExpr",149;"valueExpr",56;"whileKeyword",57;"{",143];[")",-97;";",-97;"RRPAREN",-97;"]",-97;"|]",-97];[")",-98;",",-98;";",-98;"ELIF",-98;"ELSE",-98;"EOF",-98;"RHSEND",-98;"RRPAREN",-98;"WITH",-98;"]",-98;"|",-98;"|]",-98;"}",-98];[")",-102;",",178;";",-102;"ELIF",-102;"ELSE",-102;"EOF",-102;"RHSEND",-102;"RRPAREN",-102;"WITH",-102;"]",-102;"|",-102;"|]",-102;"}",-102];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"IDENT",77;"LITERAL",22;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",179;"identExpr",24;"listExpr",25;"parenExpr",26;"prefix",194;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revQualificationExpr",137;"unaryExpr",149;"{",143];[")",-99;",",-99;";",-99;"ELIF",-99;"ELSE",-99;"EOF",-99;"RHSEND",-99;"RRPAREN",-99;"WITH",-99;"]",-99;"|",-99;"|]",-99;"}",-99];["]",181];[")",-100;"*",-100;",",-100;"->",-100;"=",-100;">",-100;"IDENT",-100;"[",-100];[")",-101;"*",-101;",",-101;"->",-101;"=",-101;">",-101;"IDENT",-101;"[",-101];[")",-103;",",-103;"=",-103];["(",120;"IDENT",28;"atomicPattern",185;"parameterPattern",31];[")",-104;",",-104;"=",-104];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"AND",37;"AND_BANG",38;"DO_BANG",132;"FOR",44;"FUN",90;"FUNCTION",102;"IDENT",77;"IF",150;"LET",39;"LET_BANG",40;"LITERAL",22;"MATCH",112;"MATCH_BANG",113;"RETURN",133;"RETURN_BANG",134;"USE",41;"USE_BANG",42;"WHILE",203;"WHILE_BANG",204;"YIELD",135;"YIELD_BANG",136;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"bindExpr",50;"bindKeyword",33;"declExpr",171;"identExpr",24;"ifExpr",196;"lambdaExpr",197;"listExpr",25;"matchExpr",198;"matchKeyword",106;"parenExpr",26;"prefix",194;"produceKeyword",51;"qualificationExpr",53;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revIfParts",81;"revQualificationExpr",137;"revSequentialExpr",172;"revTupleExpr",177;"tupleExpr",199;"unaryExpr",149;"valueExpr",56;"whileKeyword",57;"{",143];[")",-105;";",-105;"ELIF",-105;"ELSE",-105;"EOF",-105;"RHSEND",-105;"RRPAREN",-105;"]",-105;"|",-105;"|]",-105;"}",-105];[")",-106;";",-106;"ELIF",-106;"ELSE",-106;"EOF",-106;"RHSEND",-106;"RRPAREN",-106;"]",-106;"|",-106;"|]",-106;"}",-106];["(",11;"IDENT",160;"TYPAR",14;"appType",4;"atomType",6;"longid",15;"revLongid",98];[",",-110;">",-110];["(",11;"IDENT",160;"TYPAR",14;"appType",3;"atomType",6;"funType",73;"longid",15;"revLongid",98;"tupleType",76;"typeArgument",192];[",",-111;">",-111];[")",-112;"*",-112;"+",-112;",",-112;"-",-112;"->",-112;";",-112;"=",-112;"ALWAYS_INFIX",-112;"DO",-112;"ELIF",-112;"ELSE",-112;"EOF",-112;"RHSEND",-112;"RRPAREN",-112;"THEN",-112;"WITH",-112;"]",-112;"|",-112;"|]",-112;"}",-112];["(",19;"IDENT",77;"LITERAL",22;"[",94;"[|",7;"appExpr",195;"arrayExpr",23;"atomicExpr",169;"identExpr",24;"listExpr",25;"parenExpr",26;"qualificationExpr",145;"recdLiteralExpr",27;"revAppExpr",2;"revQualificationExpr",137;"{",143];[")",-113;"*",-113;"+",-113;",",-113;"-",-113;"->",-113;";",-113;"=",-113;"ALWAYS_INFIX",-113;"DO",-113;"ELIF",-113;"ELSE",-113;"EOF",-113;"RHSEND",-113;"RRPAREN",-113;"THEN",-113;"WITH",-113;"]",-113;"|",-113;"|]",-113;"}",-113];[")",-114;";",-114;"ELIF",-114;"ELSE",-114;"EOF",-114;"RHSEND",-114;"RRPAREN",-114;"]",-114;"|]",-114;"}",-114];[")",-115;";",-115;"ELIF",-115;"ELSE",-115;"EOF",-115;"RHSEND",-115;"RRPAREN",-115;"]",-115;"|]",-115;"}",-115];[")",-116;";",-116;"ELIF",-116;"ELSE",-116;"EOF",-116;"RHSEND",-116;"RRPAREN",-116;"]",-116;"|]",-116;"}",-116];[")",-117;";",-117;"ELIF",-117;"ELSE",-117;"EOF",-117;"RHSEND",-117;"RRPAREN",-117;"]",-117;"|]",-117;"}",-117];["(",19;"+",129;"-",130;"ALWAYS_PREFIX",131;"AND",37;"AND_BANG",38;"DO_BANG",132;"FOR",44;"FUN",90;"FUNCTION",102;"IDENT",77;"IF",150;"LET",39;"LET_BANG",40;"LITERAL",22;"MATCH",112;"MATCH_BANG",113;"RETURN",133;"RETURN_BANG",134;"USE",41;"USE_BANG",42;"WHILE",203;"WHILE_BANG",204;"YIELD",135;"YIELD_BANG",136;"[",94;"[|",7;"appExpr",193;"arrayExpr",23;"atomicExpr",169;"binaryExpr",176;"bindExpr",50;"bindKeyword",33;"declExpr",171;"identExpr",24;"ifExpr",196;"lambdaExpr",197;"listExpr",25;"matchExpr",198;"matchKeyword",106;"parenExpr",26;"prefix",194;"produceKeyword",51;"qualificationExpr",53;"recdLiteralExpr",27;"revAppExpr",2;"revBinaryExpr",32;"revIfParts",81;"revQualificationExpr",137;"revSequentialExpr",173;"revTupleExpr",177;"tupleExpr",199;"unaryExpr",149;"valueExpr",56;"whileKeyword",57;"{",143];[")",-118;";",-118;"ELIF",-118;"ELSE",-118;"EOF",-118;"RHSEND",-118;"RRPAREN",-118;"]",-118;"|]",-118;"}",-118];[")",-119;";",-119;"ELIF",-119;"ELSE",-119;"EOF",-119;"RHSEND",-119;"RRPAREN",-119;"]",-119;"|]",-119;"}",-119];["(",-120;"+",-120;"-",-120;"ALWAYS_PREFIX",-120;"IDENT",-120;"LITERAL",-120;"[",-120;"[|",-120;"{",-120];["(",-121;"+",-121;"-",-121;"ALWAYS_PREFIX",-121;"IDENT",-121;"LITERAL",-121;"[",-121;"[|",-121;"{",-121]]
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
            fst s0, TypeAnnotatedPattern(NamedPattern([snd s0],[]), snd s2)
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
    ["bindExpr";"bindKeyword";"bindingPattern";"=";"valueRhs"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let s1 = unbox<option<int>*Pattern> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<(option<int>*Expr) list> ss.[3]
        let result:option<int>*Expr =
            fst s0, LetBindingExpr(snd s0, [], snd s1, snd(Expr.ofSequentialExpr s3))
        box result)
    ["bindKeyword";"AND"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0,"and"
        box result)
    ["bindKeyword";"AND_BANG"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0,"and!"
        box result)
    ["bindKeyword";"LET"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0,"let"
        box result)
    ["bindKeyword";"LET_BANG"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0,"let!"
        box result)
    ["bindKeyword";"USE"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0,"use"
        box result)
    ["bindKeyword";"USE_BANG"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0,"use!"
        box result)
    ["bindingPattern";"tuplePattern"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*Pattern)list> ss.[0]
        let result:option<int>*Pattern =
            Pattern.toTuplePattern s0
        box result)
    ["declExpr";"FOR";"parameterPattern";"IN";"binaryExpr";"DO";"valueRhs"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Pattern> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>*Expr> ss.[3]
        let s4 = unbox<option<int>> ss.[4]
        let s5 = unbox<(option<int>*Expr) list> ss.[5]
        let result:option<int>*Expr =
            s0,ForExpr(snd s1, snd s3, snd(Expr.ofSequentialExpr s5))
        box result)
    ["declExpr";"bindExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
    ["declExpr";"produceKeyword";"valueExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let s1 = unbox<option<int>*Expr> ss.[1]
        let result:option<int>*Expr =
            fst s0, ProduceExpr(snd s0, snd s1)
        box result)
    ["declExpr";"qualificationExpr";"<-";"valueRhs"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int>*Expr) list> ss.[2]
        let result:option<int>*Expr =
            fst s0, AssignmentExpr(snd s0, snd(Expr.ofSequentialExpr s2))
        box result)
    ["declExpr";"valueExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
    ["declExpr";"whileKeyword";"binaryExpr";"DO";"valueRhs"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let s1 = unbox<option<int>*Expr> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<(option<int>*Expr) list> ss.[3]
        let result:option<int>*Expr =
            fst s0, WhileExpr(snd s0, snd s1, snd(Expr.ofSequentialExpr s3))
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
    ["ifExpr";"revIfParts";"RHSEND"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*IfBranch) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let result:option<int>*Expr =
            Expr.ofIfExpr s0
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
    ["matchClause";"patternAndGuard";"->";"tupleRhs"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Pattern*Expr option> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int>*Expr) list> ss.[2]
        let result:option<int>*RuleClause =
            let i,p,g = s0
            i, RuleClause(p, g, snd(Expr.ofSequentialExpr s2))
        box result)
    ["matchExpr";"FUNCTION";"opt_bar";"revMatchClauses";"RHSEND"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int>*RuleClause) list> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*Expr =
            let ruleClauses = s2 |> List.map snd |> List.rev
            s0, FunctionExpr ruleClauses
        box result)
    ["matchExpr";"matchKeyword";"tupleExpr";"WITH";"opt_bar";"revMatchClauses";"RHSEND"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let s1 = unbox<option<int>*Expr> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let s4 = unbox<(option<int>*RuleClause) list> ss.[4]
        let s5 = unbox<option<int>> ss.[5]
        let result:option<int>*Expr =
            let ruleClauses = s4 |> List.map snd |> List.rev
            fst s0, MatchExpr(snd s0,snd s1, ruleClauses)
        box result)
    ["matchKeyword";"MATCH"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0,"match"
        box result)
    ["matchKeyword";"MATCH_BANG"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0,"match!"
        box result)
    ["matchPattern";"IDENT"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let result:option<int>*Pattern =
            fst s0, NamedPattern([snd s0],[])
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
    ["openOrLet";"bindExpr"], (fun(ss:obj list)->
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
            fst s0, NamedPattern([snd s0],[])
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
            fst s0, snd s0, None
        box result)
    ["patternAndGuard";"matchPattern";"WHEN";"binaryExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Pattern> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let result:option<int>*Pattern*Expr option =
            fst s0, snd s0, Some(snd s2)
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
    ["produceKeyword";"DO_BANG"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0,"do!"
        box result)
    ["produceKeyword";"RETURN"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0,"return"
        box result)
    ["produceKeyword";"RETURN_BANG"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0,"return!"
        box result)
    ["produceKeyword";"YIELD"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0,"yield"
        box result)
    ["produceKeyword";"YIELD_BANG"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0,"yield!"
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
    ["revIfParts";"IF";"binaryExpr";"THEN";"valueRhs"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*Expr> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<(option<int>*Expr) list> ss.[3]
        let result:(option<int>*IfBranch) list =
            let branch = IfBranch(Some(snd s1), snd(Expr.ofSequentialExpr s3))
            [s0, branch]
        box result)
    ["revIfParts";"revIfParts";"ELIF";"binaryExpr";"THEN";"valueRhs"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*IfBranch) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let s4 = unbox<(option<int>*Expr) list> ss.[4]
        let result:(option<int>*IfBranch) list =
            let branch = IfBranch(Some(snd s2), snd(Expr.ofSequentialExpr s4))
            (s1, branch) :: s0
        box result)
    ["revIfParts";"revIfParts";"ELSE";"valueRhs"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*IfBranch) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int>*Expr) list> ss.[2]
        let result:(option<int>*IfBranch) list =
            let branch = IfBranch(None, snd(Expr.ofSequentialExpr s2))
            (s1, branch) :: s0
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
    ["revMatchClauses";"matchClause"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*RuleClause> ss.[0]
        let result:(option<int>*RuleClause) list =
            [s0]
        box result)
    ["revMatchClauses";"revMatchClauses";"|";"matchClause"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*RuleClause) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*RuleClause> ss.[2]
        let result:(option<int>*RuleClause) list =
            s2::s0
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
    ["valueExpr";"ifExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
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
    ["whileKeyword";"WHILE"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0,"while"
        box result)
    ["whileKeyword";"WHILE_BANG"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string =
            s0,"while!"
        box result)
]
let unboxRoot =
    unbox<string list*Expr list>
let parser = ParseTable.from(rules, actions)
