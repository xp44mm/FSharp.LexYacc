module FSharp.Substance.FSharpYacc0
open FSharp.LexYacc
open FSharp.Idioms
let stateSymbols: string[] = [|"";"file";":?";"tupleType";"AS";"IDENT";"TuplePattern";"AS";"IDENT";"AtomicPattern";"AtomicPattern";"revAppPattern";"(";"DisjunctivePattern";")";"LITERAL";"[";"revElementPatterns";"]";"[|";"revElementPatterns";"|]";"longid";"{";"revFieldPatterns";"}";"revConjunctivePattern";"revConsPattern";"revDisjunctivePattern";"revTuplePattern";"binaryExpr";":";"typeArgument";":";"tupleType";"revAppExpr";"appType";"appType";"suffixType";"atomType";"[|";"revSequentialExpr";"|]";"|]";"(";"typeArgument";")";"TYPAR";"longid";"<";"typeArguments";">";"(";"infix";")";"LITERAL";"arrayExpr";"identExpr";"listExpr";"parenExpr";"recdLiteralExpr";"revBinaryExpr";"bindKeyword";"opt_rec";"opt_mutable";"bindPattern";"=";"valueRhs";"AND";"AND_BANG";"LET";"LET_BANG";"USE";"USE_BANG";"revAppPattern";"opt_topReturnTypeWithTypeConstraints";"FOR";"AliasPattern";"IN";"binaryExpr";"DO";"valueRhs";"bindExpr";"produceKeyword";"valueExpr";"qualificationExpr";"<-";"valueRhs";"valueExpr";"whileKeyword";"binaryExpr";"DO";"valueRhs";"IDENT";"=";"valueRhs";"fieldBinding";"fieldBindings";";";"fieldBinding";"IDENT";"=";"TuplePattern";"MODULE";"longid";"EOF";"revOpenOrLets";"EOF";"funType";"->";"tupleType";"tupleType";"FUNCTION";"opt_bar";"revRuleClauses";"RHSEND";"IDENT";"<";"typeArguments";">";"revIfParts";"RHSEND";"*";"+";"+";"-";"-";"=";"ALWAYS_INFIX";"FUN";"AppPattern";"->";"tupleRhs";"[";"]";"revSequentialExpr";"]";"revLongid";"matchKeyword";"tupleExpr";"WITH";"opt_bar";"revRuleClauses";"RHSEND";"MATCH";"MATCH_BANG";"OPEN";"longid";"bindExpr";"|";"MUTABLE";"REC";":";"typeArgument";"revSequentialExpr";")";"DisjunctivePattern";"WHEN";"binaryExpr";"+";"-";"ALWAYS_PREFIX";"DO_BANG";"RETURN";"RETURN_BANG";"YIELD";"YIELD_BANG";"revQualificationExpr";".";"[";"tupleExpr";"]";"identExpr";"{";"}";"qualificationExpr";"qualificationExpr";"NamedPattern";"AtomicPattern";"AtomicPattern";"infix";"unaryExpr";"unaryExpr";"AliasPattern";"&";"AliasPattern";"::";"unaryPattern";"unaryPattern";"ConjunctivePattern";"|";"ConjunctivePattern";"TuplePattern";";";"TuplePattern";"fieldPattern";";";"fieldPattern";"IF";"thenPart";"ELIF";"thenPart";"ELSE";"valueRhs";"IDENT";".";"IDENT";"openOrLet";";";"openOrLet";"atomicExpr";"qualificationSuffix";"revRuleClauses";"|";"ruleClause";"ruleClause";"declExpr";"revSequentialExpr";"revSequentialExpr";";";"declExpr";"annotatedExpr";"revTupleExpr";",";"annotatedExpr";"ConsPattern";",";"ConsPattern";"patternAndGuard";"->";"tupleRhs";"[";"]";"longid";"binaryExpr";"THEN";"valueRhs";"TRY";"tupleRhs";"FINALLY";"tupleRhs";"WITH";"opt_bar";"RHSEND";"LLPAREN";"RRPAREN";"tupleExpr";"*";"typeArgument";",";"typeArgument";"appExpr";"prefix";"appExpr";"AppPattern";"annotatedPattern";"functionExpr";"ifExpr";"lambdaExpr";"matchExpr";"tryFinallyExpr";"tryWithExpr";"tupleExpr";"LLPAREN";"RRPAREN";"valueExpr";"WHILE";"WHILE_BANG"|]
let actions: (string * int) list list = [["MODULE",103;"file",1];["",0];["(",44;"IDENT",204;"TYPAR",47;"appType",36;"atomType",39;"longid",48;"revLongid",137;"tupleType",3];["&",-1;")",-1;"*",247;"->",-1;"AS",4;"IN",-1;"WHEN",-1;"|",-1];["IDENT",5];["&",-2;")",-2;"->",-2;"IN",-2;"WHEN",-2;"|",-2];["&",-3;")",-3;"->",-3;"AS",7;"IN",-3;"WHEN",-3;"|",-3];["IDENT",8];["&",-4;")",-4;"->",-4;"IN",-4;"WHEN",-4;"|",-4];["->",-5];["&",-5;")",-5;",",-5;"->",-5;":",33;"::",-5;";",-5;"AS",-5;"IN",-5;"WHEN",-5;"]",-5;"|",-5;"|]",-5;"}",-5];["&",-6;"(",12;")",-6;",",-6;"->",-6;"::",-6;";",-6;"AS",-6;"AtomicPattern",179;"IDENT",204;"IN",-6;"LITERAL",15;"WHEN",-6;"[",16;"[|",19;"]",-6;"longid",22;"revLongid",137;"{",23;"|",-6;"|]",-6;"}",-6];["(",12;":?",2;"AliasPattern",183;"AppPattern",254;"AtomicPattern",10;"ConjunctivePattern",189;"ConsPattern",225;"DisjunctivePattern",13;"IDENT",204;"LITERAL",15;"NamedPattern",177;"TuplePattern",6;"[",16;"[|",19;"annotatedPattern",255;"longid",22;"revAppPattern",11;"revConjunctivePattern",26;"revConsPattern",27;"revDisjunctivePattern",28;"revLongid",137;"revTuplePattern",29;"unaryPattern",188;"{",23];[")",14];["&",-7;"(",-7;")",-7;",",-7;"->",-7;":",-7;"::",-7;";",-7;"=",-7;"AS",-7;"IDENT",-7;"IN",-7;"LITERAL",-7;"WHEN",-7;"[",-7;"[|",-7;"]",-7;"{",-7;"|",-7;"|]",-7;"}",-7];["&",-8;"(",-8;")",-8;",",-8;"->",-8;":",-8;"::",-8;";",-8;"=",-8;"AS",-8;"IDENT",-8;"IN",-8;"LITERAL",-8;"WHEN",-8;"[",-8;"[|",-8;"]",-8;"{",-8;"|",-8;"|]",-8;"}",-8];["(",12;"AppPattern",254;"AtomicPattern",10;"ConsPattern",225;"IDENT",204;"LITERAL",15;"NamedPattern",177;"TuplePattern",192;"[",16;"[|",19;"annotatedPattern",255;"longid",22;"revAppPattern",11;"revConsPattern",27;"revElementPatterns",17;"revLongid",137;"revTuplePattern",29;"unaryPattern",188;"{",23];[";",193;"]",18];["&",-9;"(",-9;")",-9;",",-9;"->",-9;":",-9;"::",-9;";",-9;"=",-9;"AS",-9;"IDENT",-9;"IN",-9;"LITERAL",-9;"WHEN",-9;"[",-9;"[|",-9;"]",-9;"{",-9;"|",-9;"|]",-9;"}",-9];["(",12;"AppPattern",254;"AtomicPattern",10;"ConsPattern",225;"IDENT",204;"LITERAL",15;"NamedPattern",177;"TuplePattern",192;"[",16;"[|",19;"annotatedPattern",255;"longid",22;"revAppPattern",11;"revConsPattern",27;"revElementPatterns",20;"revLongid",137;"revTuplePattern",29;"unaryPattern",188;"{",23];[";",193;"|]",21];["&",-10;"(",-10;")",-10;",",-10;"->",-10;":",-10;"::",-10;";",-10;"=",-10;"AS",-10;"IDENT",-10;"IN",-10;"LITERAL",-10;"WHEN",-10;"[",-10;"[|",-10;"]",-10;"{",-10;"|",-10;"|]",-10;"}",-10];["&",-11;"(",-11;")",-11;",",-11;"->",-11;":",-11;"::",-11;";",-11;"=",-11;"AS",-11;"IDENT",-11;"IN",-11;"LITERAL",-11;"WHEN",-11;"[",-11;"[|",-11;"]",-11;"{",-11;"|",-11;"|]",-11;"}",-11];["IDENT",100;"fieldPattern",195;"revFieldPatterns",24];[";",196;"}",25];["&",-12;"(",-12;")",-12;",",-12;"->",-12;":",-12;"::",-12;";",-12;"=",-12;"AS",-12;"IDENT",-12;"IN",-12;"LITERAL",-12;"WHEN",-12;"[",-12;"[|",-12;"]",-12;"{",-12;"|",-12;"|]",-12;"}",-12];["&",184;")",-13;"->",-13;"WHEN",-13;"|",-13];["&",-14;")",-14;",",-14;"->",-14;"::",186;";",-14;"AS",-14;"IN",-14;"WHEN",-14;"]",-14;"|",-14;"|]",-14;"}",-14];[")",-15;"->",-15;"WHEN",-15;"|",190];["&",-16;")",-16;",",226;"->",-16;";",-16;"AS",-16;"IN",-16;"WHEN",-16;"]",-16;"|",-16;"|]",-16;"}",-16];[")",-17;",",-17;":",31;";",-17;"ELIF",-17;"ELSE",-17;"EOF",-17;"FINALLY",-17;"RHSEND",-17;"RRPAREN",-17;"WITH",-17;"]",-17;"|",-17;"|]",-17;"}",-17];["(",44;"IDENT",204;"TYPAR",47;"appType",36;"atomType",39;"funType",108;"longid",48;"revLongid",137;"tupleType",111;"typeArgument",32];[")",-18;",",-18;";",-18;"ELIF",-18;"ELSE",-18;"EOF",-18;"FINALLY",-18;"RHSEND",-18;"RRPAREN",-18;"WITH",-18;"]",-18;"|",-18;"|]",-18;"}",-18];["(",44;"IDENT",204;"TYPAR",47;"appType",36;"atomType",39;"longid",48;"revLongid",137;"tupleType",34];["&",-19;")",-19;"*",247;",",-19;"->",-19;"::",-19;";",-19;"AS",-19;"IN",-19;"WHEN",-19;"]",-19;"|",-19;"|]",-19;"}",-19];["(",52;")",-20;"*",-20;"+",-20;",",-20;"-",-20;"->",-20;":",-20;";",-20;"=",-20;"ALWAYS_INFIX",-20;"DO",-20;"ELIF",-20;"ELSE",-20;"EOF",-20;"FINALLY",-20;"IDENT",116;"LITERAL",55;"RHSEND",-20;"RRPAREN",-20;"THEN",-20;"WITH",-20;"[",133;"[|",40;"]",-20;"arrayExpr",56;"atomicExpr",210;"identExpr",57;"listExpr",58;"parenExpr",59;"qualificationExpr",176;"recdLiteralExpr",60;"revQualificationExpr",167;"{",173;"|",-20;"|]",-20;"}",-20];["&",-142;")",-142;"*",-142;",",-142;"->",-142;"::",-142;";",-142;"=",-142;">",-142;"AS",-142;"ELIF",-142;"ELSE",-142;"EOF",-142;"FINALLY",-142;"IDENT",204;"IN",-142;"RHSEND",-142;"RRPAREN",-142;"WHEN",-142;"WITH",-142;"[",231;"]",-142;"longid",233;"revLongid",137;"suffixType",38;"|",-142;"|]",-142;"}",-142];["&",-143;")",-143;"*",-143;",",-143;"->",-143;"::",-143;";",-143;"=",-143;">",-143;"AS",-143;"ELIF",-143;"ELSE",-143;"EOF",-143;"FINALLY",-143;"IDENT",204;"IN",-143;"RHSEND",-143;"RRPAREN",-143;"WHEN",-143;"WITH",-143;"[",231;"]",-143;"longid",233;"revLongid",137;"suffixType",38;"|",-143;"|]",-143;"}",-143];["&",-21;")",-21;"*",-21;",",-21;"->",-21;"::",-21;";",-21;"=",-21;">",-21;"AS",-21;"ELIF",-21;"ELSE",-21;"EOF",-21;"FINALLY",-21;"IDENT",-21;"IN",-21;"RHSEND",-21;"RRPAREN",-21;"WHEN",-21;"WITH",-21;"[",-21;"]",-21;"|",-21;"|]",-21;"}",-21];["&",-22;")",-22;"*",-22;",",-22;"->",-22;"::",-22;";",-22;"=",-22;">",-22;"AS",-22;"ELIF",-22;"ELSE",-22;"EOF",-22;"FINALLY",-22;"IDENT",-22;"IN",-22;"RHSEND",-22;"RRPAREN",-22;"WHEN",-22;"WITH",-22;"[",-22;"]",-22;"|",-22;"|]",-22;"}",-22];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"AND",68;"AND_BANG",69;"DO_BANG",162;"FOR",76;"FUN",129;"FUNCTION",112;"IDENT",116;"IF",198;"LET",70;"LET_BANG",71;"LITERAL",55;"MATCH",144;"MATCH_BANG",145;"RETURN",163;"RETURN_BANG",164;"TRY",237;"USE",72;"USE_BANG",73;"WHILE",266;"WHILE_BANG",267;"YIELD",165;"YIELD_BANG",166;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"bindExpr",82;"bindKeyword",62;"declExpr",216;"functionExpr",256;"identExpr",57;"ifExpr",257;"lambdaExpr",258;"listExpr",58;"matchExpr",259;"matchKeyword",138;"parenExpr",59;"prefix",252;"produceKeyword",83;"qualificationExpr",85;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revIfParts",120;"revQualificationExpr",167;"revSequentialExpr",41;"revTupleExpr",222;"tryFinallyExpr",260;"tryWithExpr",261;"tupleExpr",262;"unaryExpr",182;"valueExpr",88;"whileKeyword",89;"{",173;"|]",43];[";",219;"|]",42];["(",-23;")",-23;"*",-23;"+",-23;",",-23;"-",-23;"->",-23;".",-23;":",-23;";",-23;"<-",-23;"=",-23;"ALWAYS_INFIX",-23;"DO",-23;"ELIF",-23;"ELSE",-23;"EOF",-23;"FINALLY",-23;"IDENT",-23;"LITERAL",-23;"RHSEND",-23;"RRPAREN",-23;"THEN",-23;"WITH",-23;"[",-23;"[|",-23;"]",-23;"{",-23;"|",-23;"|]",-23;"}",-23];["(",-24;")",-24;"*",-24;"+",-24;",",-24;"-",-24;"->",-24;".",-24;":",-24;";",-24;"<-",-24;"=",-24;"ALWAYS_INFIX",-24;"DO",-24;"ELIF",-24;"ELSE",-24;"EOF",-24;"FINALLY",-24;"IDENT",-24;"LITERAL",-24;"RHSEND",-24;"RRPAREN",-24;"THEN",-24;"WITH",-24;"[",-24;"[|",-24;"]",-24;"{",-24;"|",-24;"|]",-24;"}",-24];["(",44;"IDENT",204;"TYPAR",47;"appType",36;"atomType",39;"funType",108;"longid",48;"revLongid",137;"tupleType",111;"typeArgument",45];[")",46];["&",-25;")",-25;"*",-25;",",-25;"->",-25;"::",-25;";",-25;"=",-25;">",-25;"AS",-25;"ELIF",-25;"ELSE",-25;"EOF",-25;"FINALLY",-25;"IDENT",-25;"IN",-25;"RHSEND",-25;"RRPAREN",-25;"WHEN",-25;"WITH",-25;"[",-25;"]",-25;"|",-25;"|]",-25;"}",-25];["&",-26;")",-26;"*",-26;",",-26;"->",-26;"::",-26;";",-26;"=",-26;">",-26;"AS",-26;"ELIF",-26;"ELSE",-26;"EOF",-26;"FINALLY",-26;"IDENT",-26;"IN",-26;"RHSEND",-26;"RRPAREN",-26;"WHEN",-26;"WITH",-26;"[",-26;"]",-26;"|",-26;"|]",-26;"}",-26];["&",-27;")",-27;"*",-27;",",-27;"->",-27;"::",-27;";",-27;"<",49;"=",-27;">",-27;"AS",-27;"ELIF",-27;"ELSE",-27;"EOF",-27;"FINALLY",-27;"IDENT",-27;"IN",-27;"RHSEND",-27;"RRPAREN",-27;"WHEN",-27;"WITH",-27;"[",-27;"]",-27;"|",-27;"|]",-27;"}",-27];["(",44;"IDENT",204;"TYPAR",47;"appType",36;"atomType",39;"funType",108;"longid",48;"revLongid",137;"tupleType",111;"typeArgument",248;"typeArguments",50];[",",249;">",51];["&",-28;")",-28;"*",-28;",",-28;"->",-28;"::",-28;";",-28;"=",-28;">",-28;"AS",-28;"ELIF",-28;"ELSE",-28;"EOF",-28;"FINALLY",-28;"IDENT",-28;"IN",-28;"RHSEND",-28;"RRPAREN",-28;"WHEN",-28;"WITH",-28;"[",-28;"]",-28;"|",-28;"|]",-28;"}",-28];["(",52;"*",122;"+",124;"-",126;"=",127;"ALWAYS_INFIX",128;"ALWAYS_PREFIX",161;"AND",68;"AND_BANG",69;"DO_BANG",162;"FOR",76;"FUN",129;"FUNCTION",112;"IDENT",116;"IF",198;"LET",70;"LET_BANG",71;"LITERAL",55;"MATCH",144;"MATCH_BANG",145;"RETURN",163;"RETURN_BANG",164;"TRY",237;"USE",72;"USE_BANG",73;"WHILE",266;"WHILE_BANG",267;"YIELD",165;"YIELD_BANG",166;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"bindExpr",82;"bindKeyword",62;"declExpr",216;"functionExpr",256;"identExpr",57;"ifExpr",257;"infix",53;"lambdaExpr",258;"listExpr",58;"matchExpr",259;"matchKeyword",138;"parenExpr",59;"prefix",252;"produceKeyword",83;"qualificationExpr",85;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revIfParts",120;"revQualificationExpr",167;"revSequentialExpr",154;"revTupleExpr",222;"tryFinallyExpr",260;"tryWithExpr",261;"tupleExpr",262;"unaryExpr",182;"valueExpr",88;"whileKeyword",89;"{",173];[")",54];["(",-29;")",-29;"*",-29;"+",-29;",",-29;"-",-29;"->",-29;".",-29;":",-29;";",-29;"<-",-29;"=",-29;"ALWAYS_INFIX",-29;"DO",-29;"ELIF",-29;"ELSE",-29;"EOF",-29;"FINALLY",-29;"IDENT",-29;"LITERAL",-29;"RHSEND",-29;"RRPAREN",-29;"THEN",-29;"WITH",-29;"[",-29;"[|",-29;"]",-29;"{",-29;"|",-29;"|]",-29;"}",-29];["(",-30;")",-30;"*",-30;"+",-30;",",-30;"-",-30;"->",-30;".",-30;":",-30;";",-30;"<-",-30;"=",-30;"ALWAYS_INFIX",-30;"DO",-30;"ELIF",-30;"ELSE",-30;"EOF",-30;"FINALLY",-30;"IDENT",-30;"LITERAL",-30;"RHSEND",-30;"RRPAREN",-30;"THEN",-30;"WITH",-30;"[",-30;"[|",-30;"]",-30;"{",-30;"|",-30;"|]",-30;"}",-30];["(",-31;")",-31;"*",-31;"+",-31;",",-31;"-",-31;"->",-31;".",-31;":",-31;";",-31;"<-",-31;"=",-31;"ALWAYS_INFIX",-31;"DO",-31;"ELIF",-31;"ELSE",-31;"EOF",-31;"FINALLY",-31;"IDENT",-31;"LITERAL",-31;"RHSEND",-31;"RRPAREN",-31;"THEN",-31;"WITH",-31;"[",-31;"[|",-31;"]",-31;"{",-31;"|",-31;"|]",-31;"}",-31];["(",-32;")",-32;"*",-32;"+",-32;",",-32;"-",-32;"->",-32;".",-32;":",-32;";",-32;"<-",-32;"=",-32;"ALWAYS_INFIX",-32;"DO",-32;"ELIF",-32;"ELSE",-32;"EOF",-32;"FINALLY",-32;"IDENT",-32;"LITERAL",-32;"RHSEND",-32;"RRPAREN",-32;"THEN",-32;"WITH",-32;"[",-32;"[|",-32;"]",-32;"{",-32;"|",-32;"|]",-32;"}",-32];["(",-33;")",-33;"*",-33;"+",-33;",",-33;"-",-33;"->",-33;".",-33;":",-33;";",-33;"<-",-33;"=",-33;"ALWAYS_INFIX",-33;"DO",-33;"ELIF",-33;"ELSE",-33;"EOF",-33;"FINALLY",-33;"IDENT",-33;"LITERAL",-33;"RHSEND",-33;"RRPAREN",-33;"THEN",-33;"WITH",-33;"[",-33;"[|",-33;"]",-33;"{",-33;"|",-33;"|]",-33;"}",-33];["(",-34;")",-34;"*",-34;"+",-34;",",-34;"-",-34;"->",-34;".",-34;":",-34;";",-34;"<-",-34;"=",-34;"ALWAYS_INFIX",-34;"DO",-34;"ELIF",-34;"ELSE",-34;"EOF",-34;"FINALLY",-34;"IDENT",-34;"LITERAL",-34;"RHSEND",-34;"RRPAREN",-34;"THEN",-34;"WITH",-34;"[",-34;"[|",-34;"]",-34;"{",-34;"|",-34;"|]",-34;"}",-34];["(",-35;")",-35;"*",-35;"+",-35;",",-35;"-",-35;"->",-35;".",-35;":",-35;";",-35;"<-",-35;"=",-35;"ALWAYS_INFIX",-35;"DO",-35;"ELIF",-35;"ELSE",-35;"EOF",-35;"FINALLY",-35;"IDENT",-35;"LITERAL",-35;"RHSEND",-35;"RRPAREN",-35;"THEN",-35;"WITH",-35;"[",-35;"[|",-35;"]",-35;"{",-35;"|",-35;"|]",-35;"}",-35];[")",-36;"*",122;"+",123;",",-36;"-",125;"->",-36;":",-36;";",-36;"=",127;"ALWAYS_INFIX",128;"DO",-36;"ELIF",-36;"ELSE",-36;"EOF",-36;"FINALLY",-36;"RHSEND",-36;"RRPAREN",-36;"THEN",-36;"WITH",-36;"]",-36;"infix",180;"|",-36;"|]",-36;"}",-36];["MUTABLE",-81;"NamedPattern",-81;"REC",151;"opt_rec",63];["MUTABLE",150;"NamedPattern",-79;"opt_mutable",64];["NamedPattern",177;"bindPattern",65;"revAppPattern",74];["=",66];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"FUN",129;"FUNCTION",112;"IDENT",116;"IF",198;"LITERAL",55;"LLPAREN",263;"MATCH",144;"MATCH_BANG",145;"TRY",237;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"functionExpr",256;"identExpr",57;"ifExpr",257;"lambdaExpr",258;"listExpr",58;"matchExpr",259;"matchKeyword",138;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revIfParts",120;"revQualificationExpr",167;"revTupleExpr",222;"tryFinallyExpr",260;"tryWithExpr",261;"tupleExpr",262;"unaryExpr",182;"valueExpr",265;"valueRhs",67;"{",173];[")",-37;";",-37;"EOF",-37;"RRPAREN",-37;"]",-37;"|]",-37];["MUTABLE",-38;"NamedPattern",-38;"REC",-38];["MUTABLE",-39;"NamedPattern",-39;"REC",-39];["MUTABLE",-40;"NamedPattern",-40;"REC",-40];["MUTABLE",-41;"NamedPattern",-41;"REC",-41];["MUTABLE",-42;"NamedPattern",-42;"REC",-42];["MUTABLE",-43;"NamedPattern",-43;"REC",-43];["(",12;":",152;"=",-83;"AtomicPattern",179;"IDENT",204;"LITERAL",15;"[",16;"[|",19;"longid",22;"opt_topReturnTypeWithTypeConstraints",75;"revLongid",137;"{",23];["=",-44];["(",12;":?",2;"AliasPattern",77;"AppPattern",254;"AtomicPattern",10;"ConsPattern",225;"IDENT",204;"LITERAL",15;"NamedPattern",177;"TuplePattern",6;"[",16;"[|",19;"annotatedPattern",255;"longid",22;"revAppPattern",11;"revConsPattern",27;"revLongid",137;"revTuplePattern",29;"unaryPattern",188;"{",23];["IN",78];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"IDENT",116;"LITERAL",55;"[",133;"[|",40;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",79;"identExpr",57;"listExpr",58;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revQualificationExpr",167;"unaryExpr",182;"{",173];["DO",80];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"FUN",129;"FUNCTION",112;"IDENT",116;"IF",198;"LITERAL",55;"LLPAREN",263;"MATCH",144;"MATCH_BANG",145;"TRY",237;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"functionExpr",256;"identExpr",57;"ifExpr",257;"lambdaExpr",258;"listExpr",58;"matchExpr",259;"matchKeyword",138;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revIfParts",120;"revQualificationExpr",167;"revTupleExpr",222;"tryFinallyExpr",260;"tryWithExpr",261;"tupleExpr",262;"unaryExpr",182;"valueExpr",265;"valueRhs",81;"{",173];[")",-45;";",-45;"RRPAREN",-45;"]",-45;"|]",-45];[")",-46;";",-46;"RRPAREN",-46;"]",-46;"|]",-46];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"FUN",129;"FUNCTION",112;"IDENT",116;"IF",198;"LITERAL",55;"MATCH",144;"MATCH_BANG",145;"TRY",237;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"functionExpr",256;"identExpr",57;"ifExpr",257;"lambdaExpr",258;"listExpr",58;"matchExpr",259;"matchKeyword",138;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revIfParts",120;"revQualificationExpr",167;"revTupleExpr",222;"tryFinallyExpr",260;"tryWithExpr",261;"tupleExpr",262;"unaryExpr",182;"valueExpr",84;"{",173];[")",-47;";",-47;"RRPAREN",-47;"]",-47;"|]",-47];["(",-100;")",-100;"*",-100;"+",-100;",",-100;"-",-100;":",-100;";",-100;"<-",86;"=",-100;"ALWAYS_INFIX",-100;"IDENT",-100;"LITERAL",-100;"RRPAREN",-100;"[",-100;"[|",-100;"]",-100;"{",-100;"|]",-100];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"FUN",129;"FUNCTION",112;"IDENT",116;"IF",198;"LITERAL",55;"LLPAREN",263;"MATCH",144;"MATCH_BANG",145;"TRY",237;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"functionExpr",256;"identExpr",57;"ifExpr",257;"lambdaExpr",258;"listExpr",58;"matchExpr",259;"matchKeyword",138;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revIfParts",120;"revQualificationExpr",167;"revTupleExpr",222;"tryFinallyExpr",260;"tryWithExpr",261;"tupleExpr",262;"unaryExpr",182;"valueExpr",265;"valueRhs",87;"{",173];[")",-48;";",-48;"RRPAREN",-48;"]",-48;"|]",-48];[")",-49;";",-49;"RRPAREN",-49;"]",-49;"|]",-49];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"IDENT",116;"LITERAL",55;"[",133;"[|",40;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",90;"identExpr",57;"listExpr",58;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revQualificationExpr",167;"unaryExpr",182;"{",173];["DO",91];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"FUN",129;"FUNCTION",112;"IDENT",116;"IF",198;"LITERAL",55;"LLPAREN",263;"MATCH",144;"MATCH_BANG",145;"TRY",237;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"functionExpr",256;"identExpr",57;"ifExpr",257;"lambdaExpr",258;"listExpr",58;"matchExpr",259;"matchKeyword",138;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revIfParts",120;"revQualificationExpr",167;"revTupleExpr",222;"tryFinallyExpr",260;"tryWithExpr",261;"tupleExpr",262;"unaryExpr",182;"valueExpr",265;"valueRhs",92;"{",173];[")",-50;";",-50;"RRPAREN",-50;"]",-50;"|]",-50];["=",94];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"FUN",129;"FUNCTION",112;"IDENT",116;"IF",198;"LITERAL",55;"LLPAREN",263;"MATCH",144;"MATCH_BANG",145;"TRY",237;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"functionExpr",256;"identExpr",57;"ifExpr",257;"lambdaExpr",258;"listExpr",58;"matchExpr",259;"matchKeyword",138;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revIfParts",120;"revQualificationExpr",167;"revTupleExpr",222;"tryFinallyExpr",260;"tryWithExpr",261;"tupleExpr",262;"unaryExpr",182;"valueExpr",265;"valueRhs",95;"{",173];[";",-51;"}",-51];[";",-52;"}",-52];[";",98;"}",174];["IDENT",93;"fieldBinding",99];[";",-53;"}",-53];["=",101];["(",12;"AppPattern",254;"AtomicPattern",10;"ConsPattern",225;"IDENT",204;"LITERAL",15;"NamedPattern",177;"TuplePattern",102;"[",16;"[|",19;"annotatedPattern",255;"longid",22;"revAppPattern",11;"revConsPattern",27;"revLongid",137;"revTuplePattern",29;"unaryPattern",188;"{",23];[";",-54;"}",-54];["IDENT",204;"longid",104;"revLongid",137];["AND",68;"AND_BANG",69;"EOF",105;"LET",70;"LET_BANG",71;"OPEN",146;"USE",72;"USE_BANG",73;"bindExpr",148;"bindKeyword",62;"openOrLet",207;"revOpenOrLets",106];["",-55];[";",208;"EOF",107];["",-56];[")",-144;",",-144;"->",109;";",-144;"=",-144;">",-144;"ELIF",-144;"ELSE",-144;"EOF",-144;"FINALLY",-144;"RHSEND",-144;"RRPAREN",-144;"WITH",-144;"]",-144;"|",-144;"|]",-144;"}",-144];["(",44;"IDENT",204;"TYPAR",47;"appType",36;"atomType",39;"longid",48;"revLongid",137;"tupleType",110];[")",-57;"*",247;",",-57;"->",-57;";",-57;"=",-57;">",-57;"ELIF",-57;"ELSE",-57;"EOF",-57;"FINALLY",-57;"RHSEND",-57;"RRPAREN",-57;"WITH",-57;"]",-57;"|",-57;"|]",-57;"}",-57];[")",-58;"*",247;",",-58;"->",-58;";",-58;"=",-58;">",-58;"ELIF",-58;"ELSE",-58;"EOF",-58;"FINALLY",-58;"RHSEND",-58;"RRPAREN",-58;"WITH",-58;"]",-58;"|",-58;"|]",-58;"}",-58];["(",-77;":?",-77;"IDENT",-77;"LITERAL",-77;"NamedPattern",-77;"[",-77;"[|",-77;"opt_bar",113;"{",-77;"|",149];["(",12;":?",2;"AliasPattern",183;"AppPattern",254;"AtomicPattern",10;"ConjunctivePattern",189;"ConsPattern",225;"DisjunctivePattern",156;"IDENT",204;"LITERAL",15;"NamedPattern",177;"TuplePattern",6;"[",16;"[|",19;"annotatedPattern",255;"longid",22;"patternAndGuard",228;"revAppPattern",11;"revConjunctivePattern",26;"revConsPattern",27;"revDisjunctivePattern",28;"revLongid",137;"revRuleClauses",114;"revTuplePattern",29;"ruleClause",215;"unaryPattern",188;"{",23];["RHSEND",115;"|",213];[")",-59;";",-59;"ELIF",-59;"ELSE",-59;"EOF",-59;"RHSEND",-59;"RRPAREN",-59;"]",-59;"|]",-59;"}",-59];["(",-60;")",-60;"*",-60;"+",-60;",",-60;"-",-60;"->",-60;".",-60;":",-60;";",-60;"<",117;"<-",-60;"=",-60;"ALWAYS_INFIX",-60;"DO",-60;"ELIF",-60;"ELSE",-60;"EOF",-60;"FINALLY",-60;"IDENT",-60;"LITERAL",-60;"RHSEND",-60;"RRPAREN",-60;"THEN",-60;"WITH",-60;"[",-60;"[|",-60;"]",-60;"{",-60;"|",-60;"|]",-60;"}",-60];["(",44;"IDENT",204;"TYPAR",47;"appType",36;"atomType",39;"funType",108;"longid",48;"revLongid",137;"tupleType",111;"typeArgument",248;"typeArguments",118];[",",249;">",119];["(",-61;")",-61;"*",-61;"+",-61;",",-61;"-",-61;"->",-61;".",-61;":",-61;";",-61;"<-",-61;"=",-61;"ALWAYS_INFIX",-61;"DO",-61;"ELIF",-61;"ELSE",-61;"EOF",-61;"FINALLY",-61;"IDENT",-61;"LITERAL",-61;"RHSEND",-61;"RRPAREN",-61;"THEN",-61;"WITH",-61;"[",-61;"[|",-61;"]",-61;"{",-61;"|",-61;"|]",-61;"}",-61];["ELIF",200;"ELSE",202;"RHSEND",121];[")",-62;";",-62;"ELIF",-62;"ELSE",-62;"EOF",-62;"RHSEND",-62;"RRPAREN",-62;"]",-62;"|]",-62;"}",-62];["(",-63;")",-63;"+",-63;"-",-63;"ALWAYS_PREFIX",-63;"IDENT",-63;"LITERAL",-63;"[",-63;"[|",-63;"{",-63];["(",-64;"+",-64;"-",-64;"ALWAYS_PREFIX",-64;"IDENT",-64;"LITERAL",-64;"[",-64;"[|",-64;"{",-64];["(",-88;")",-64;"IDENT",-88;"LITERAL",-88;"[",-88;"[|",-88;"{",-88];["(",-65;"+",-65;"-",-65;"ALWAYS_PREFIX",-65;"IDENT",-65;"LITERAL",-65;"[",-65;"[|",-65;"{",-65];["(",-89;")",-65;"IDENT",-89;"LITERAL",-89;"[",-89;"[|",-89;"{",-89];["(",-66;")",-66;"+",-66;"-",-66;"ALWAYS_PREFIX",-66;"IDENT",-66;"LITERAL",-66;"[",-66;"[|",-66;"{",-66];["(",-67;")",-67;"+",-67;"-",-67;"ALWAYS_PREFIX",-67;"IDENT",-67;"LITERAL",-67;"[",-67;"[|",-67;"{",-67];["(",12;"AppPattern",130;"AtomicPattern",9;"IDENT",204;"LITERAL",15;"NamedPattern",177;"[",16;"[|",19;"longid",22;"revAppPattern",11;"revLongid",137;"{",23];["->",131];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"IDENT",116;"LITERAL",55;"LLPAREN",244;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"identExpr",57;"listExpr",58;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revQualificationExpr",167;"revTupleExpr",222;"tupleExpr",246;"tupleRhs",132;"unaryExpr",182;"{",173];[")",-68;";",-68;"ELIF",-68;"ELSE",-68;"EOF",-68;"RHSEND",-68;"RRPAREN",-68;"]",-68;"|]",-68;"}",-68];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"AND",68;"AND_BANG",69;"DO_BANG",162;"FOR",76;"FUN",129;"FUNCTION",112;"IDENT",116;"IF",198;"LET",70;"LET_BANG",71;"LITERAL",55;"MATCH",144;"MATCH_BANG",145;"RETURN",163;"RETURN_BANG",164;"TRY",237;"USE",72;"USE_BANG",73;"WHILE",266;"WHILE_BANG",267;"YIELD",165;"YIELD_BANG",166;"[",133;"[|",40;"]",134;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"bindExpr",82;"bindKeyword",62;"declExpr",216;"functionExpr",256;"identExpr",57;"ifExpr",257;"lambdaExpr",258;"listExpr",58;"matchExpr",259;"matchKeyword",138;"parenExpr",59;"prefix",252;"produceKeyword",83;"qualificationExpr",85;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revIfParts",120;"revQualificationExpr",167;"revSequentialExpr",135;"revTupleExpr",222;"tryFinallyExpr",260;"tryWithExpr",261;"tupleExpr",262;"unaryExpr",182;"valueExpr",88;"whileKeyword",89;"{",173];["(",-69;")",-69;"*",-69;"+",-69;",",-69;"-",-69;"->",-69;".",-69;":",-69;";",-69;"<-",-69;"=",-69;"ALWAYS_INFIX",-69;"DO",-69;"ELIF",-69;"ELSE",-69;"EOF",-69;"FINALLY",-69;"IDENT",-69;"LITERAL",-69;"RHSEND",-69;"RRPAREN",-69;"THEN",-69;"WITH",-69;"[",-69;"[|",-69;"]",-69;"{",-69;"|",-69;"|]",-69;"}",-69];[";",219;"]",136];["(",-70;")",-70;"*",-70;"+",-70;",",-70;"-",-70;"->",-70;".",-70;":",-70;";",-70;"<-",-70;"=",-70;"ALWAYS_INFIX",-70;"DO",-70;"ELIF",-70;"ELSE",-70;"EOF",-70;"FINALLY",-70;"IDENT",-70;"LITERAL",-70;"RHSEND",-70;"RRPAREN",-70;"THEN",-70;"WITH",-70;"[",-70;"[|",-70;"]",-70;"{",-70;"|",-70;"|]",-70;"}",-70];["&",-71;"(",-71;")",-71;"*",-71;",",-71;"->",-71;".",205;":",-71;"::",-71;";",-71;"<",-71;"=",-71;">",-71;"AND",-71;"AND_BANG",-71;"AS",-71;"ELIF",-71;"ELSE",-71;"EOF",-71;"FINALLY",-71;"IDENT",-71;"IN",-71;"LET",-71;"LET_BANG",-71;"LITERAL",-71;"OPEN",-71;"RHSEND",-71;"RRPAREN",-71;"USE",-71;"USE_BANG",-71;"WHEN",-71;"WITH",-71;"[",-71;"[|",-71;"]",-71;"{",-71;"|",-71;"|]",-71;"}",-71];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"IDENT",116;"LITERAL",55;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"identExpr",57;"listExpr",58;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revQualificationExpr",167;"revTupleExpr",222;"tupleExpr",139;"unaryExpr",182;"{",173];["WITH",140];["(",-77;":?",-77;"IDENT",-77;"LITERAL",-77;"NamedPattern",-77;"[",-77;"[|",-77;"opt_bar",141;"{",-77;"|",149];["(",12;":?",2;"AliasPattern",183;"AppPattern",254;"AtomicPattern",10;"ConjunctivePattern",189;"ConsPattern",225;"DisjunctivePattern",156;"IDENT",204;"LITERAL",15;"NamedPattern",177;"TuplePattern",6;"[",16;"[|",19;"annotatedPattern",255;"longid",22;"patternAndGuard",228;"revAppPattern",11;"revConjunctivePattern",26;"revConsPattern",27;"revDisjunctivePattern",28;"revLongid",137;"revRuleClauses",142;"revTuplePattern",29;"ruleClause",215;"unaryPattern",188;"{",23];["RHSEND",143;"|",213];[")",-72;";",-72;"ELIF",-72;"ELSE",-72;"EOF",-72;"RHSEND",-72;"RRPAREN",-72;"]",-72;"|]",-72;"}",-72];["(",-73;"+",-73;"-",-73;"ALWAYS_PREFIX",-73;"IDENT",-73;"LITERAL",-73;"[",-73;"[|",-73;"{",-73];["(",-74;"+",-74;"-",-74;"ALWAYS_PREFIX",-74;"IDENT",-74;"LITERAL",-74;"[",-74;"[|",-74;"{",-74];["IDENT",204;"longid",147;"revLongid",137];[";",-75;"EOF",-75];[";",-76;"EOF",-76];["(",-78;":?",-78;"IDENT",-78;"LITERAL",-78;"NamedPattern",-78;"[",-78;"[|",-78;"{",-78];["NamedPattern",-80];["MUTABLE",-82;"NamedPattern",-82];["(",44;"IDENT",204;"TYPAR",47;"appType",36;"atomType",39;"funType",108;"longid",48;"revLongid",137;"tupleType",111;"typeArgument",153];["=",-84];[")",155;";",219];["(",-85;")",-85;"*",-85;"+",-85;",",-85;"-",-85;"->",-85;".",-85;":",-85;";",-85;"<-",-85;"=",-85;"ALWAYS_INFIX",-85;"DO",-85;"ELIF",-85;"ELSE",-85;"EOF",-85;"FINALLY",-85;"IDENT",-85;"LITERAL",-85;"RHSEND",-85;"RRPAREN",-85;"THEN",-85;"WITH",-85;"[",-85;"[|",-85;"]",-85;"{",-85;"|",-85;"|]",-85;"}",-85];["->",-86;"WHEN",157];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"IDENT",116;"LITERAL",55;"[",133;"[|",40;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",158;"identExpr",57;"listExpr",58;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revQualificationExpr",167;"unaryExpr",182;"{",173];["->",-87];["(",-88;"IDENT",-88;"LITERAL",-88;"[",-88;"[|",-88;"{",-88];["(",-89;"IDENT",-89;"LITERAL",-89;"[",-89;"[|",-89;"{",-89];["(",-90;"IDENT",-90;"LITERAL",-90;"[",-90;"[|",-90;"{",-90];["(",-91;"+",-91;"-",-91;"ALWAYS_PREFIX",-91;"FUN",-91;"FUNCTION",-91;"IDENT",-91;"IF",-91;"LITERAL",-91;"MATCH",-91;"MATCH_BANG",-91;"TRY",-91;"[",-91;"[|",-91;"{",-91];["(",-92;"+",-92;"-",-92;"ALWAYS_PREFIX",-92;"FUN",-92;"FUNCTION",-92;"IDENT",-92;"IF",-92;"LITERAL",-92;"MATCH",-92;"MATCH_BANG",-92;"TRY",-92;"[",-92;"[|",-92;"{",-92];["(",-93;"+",-93;"-",-93;"ALWAYS_PREFIX",-93;"FUN",-93;"FUNCTION",-93;"IDENT",-93;"IF",-93;"LITERAL",-93;"MATCH",-93;"MATCH_BANG",-93;"TRY",-93;"[",-93;"[|",-93;"{",-93];["(",-94;"+",-94;"-",-94;"ALWAYS_PREFIX",-94;"FUN",-94;"FUNCTION",-94;"IDENT",-94;"IF",-94;"LITERAL",-94;"MATCH",-94;"MATCH_BANG",-94;"TRY",-94;"[",-94;"[|",-94;"{",-94];["(",-95;"+",-95;"-",-95;"ALWAYS_PREFIX",-95;"FUN",-95;"FUNCTION",-95;"IDENT",-95;"IF",-95;"LITERAL",-95;"MATCH",-95;"MATCH_BANG",-95;"TRY",-95;"[",-95;"[|",-95;"{",-95];["(",-96;")",-96;"*",-96;"+",-96;",",-96;"-",-96;"->",-96;".",168;":",-96;";",-96;"<-",-96;"=",-96;"ALWAYS_INFIX",-96;"DO",-96;"ELIF",-96;"ELSE",-96;"EOF",-96;"FINALLY",-96;"IDENT",-96;"LITERAL",-96;"RHSEND",-96;"RRPAREN",-96;"THEN",-96;"WITH",-96;"[",-96;"[|",-96;"]",-96;"qualificationSuffix",211;"{",-96;"|",-96;"|]",-96;"}",-96];["IDENT",116;"[",169;"identExpr",172];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"IDENT",116;"LITERAL",55;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"identExpr",57;"listExpr",58;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revQualificationExpr",167;"revTupleExpr",222;"tupleExpr",170;"unaryExpr",182;"{",173];["]",171];["(",-97;")",-97;"*",-97;"+",-97;",",-97;"-",-97;"->",-97;".",-97;":",-97;";",-97;"<-",-97;"=",-97;"ALWAYS_INFIX",-97;"DO",-97;"ELIF",-97;"ELSE",-97;"EOF",-97;"FINALLY",-97;"IDENT",-97;"LITERAL",-97;"RHSEND",-97;"RRPAREN",-97;"THEN",-97;"WITH",-97;"[",-97;"[|",-97;"]",-97;"{",-97;"|",-97;"|]",-97;"}",-97];["(",-98;")",-98;"*",-98;"+",-98;",",-98;"-",-98;"->",-98;".",-98;":",-98;";",-98;"<-",-98;"=",-98;"ALWAYS_INFIX",-98;"DO",-98;"ELIF",-98;"ELSE",-98;"EOF",-98;"FINALLY",-98;"IDENT",-98;"LITERAL",-98;"RHSEND",-98;"RRPAREN",-98;"THEN",-98;"WITH",-98;"[",-98;"[|",-98;"]",-98;"{",-98;"|",-98;"|]",-98;"}",-98];["IDENT",93;"fieldBinding",96;"fieldBindings",97];["(",-99;")",-99;"*",-99;"+",-99;",",-99;"-",-99;"->",-99;".",-99;":",-99;";",-99;"<-",-99;"=",-99;"ALWAYS_INFIX",-99;"DO",-99;"ELIF",-99;"ELSE",-99;"EOF",-99;"FINALLY",-99;"IDENT",-99;"LITERAL",-99;"RHSEND",-99;"RRPAREN",-99;"THEN",-99;"WITH",-99;"[",-99;"[|",-99;"]",-99;"{",-99;"|",-99;"|]",-99;"}",-99];["(",-100;")",-100;"*",-100;"+",-100;",",-100;"-",-100;"->",-100;":",-100;";",-100;"=",-100;"ALWAYS_INFIX",-100;"DO",-100;"ELIF",-100;"ELSE",-100;"EOF",-100;"FINALLY",-100;"IDENT",-100;"LITERAL",-100;"RHSEND",-100;"RRPAREN",-100;"THEN",-100;"WITH",-100;"[",-100;"[|",-100;"]",-100;"{",-100;"|",-100;"|]",-100;"}",-100];["(",-101;")",-101;"*",-101;"+",-101;",",-101;"-",-101;"->",-101;":",-101;";",-101;"=",-101;"ALWAYS_INFIX",-101;"DO",-101;"ELIF",-101;"ELSE",-101;"EOF",-101;"FINALLY",-101;"IDENT",-101;"LITERAL",-101;"RHSEND",-101;"RRPAREN",-101;"THEN",-101;"WITH",-101;"[",-101;"[|",-101;"]",-101;"{",-101;"|",-101;"|]",-101;"}",-101];["(",12;"AtomicPattern",178;"IDENT",204;"LITERAL",15;"[",16;"[|",19;"longid",22;"revLongid",137;"{",23];["&",-102;"(",-102;")",-102;",",-102;"->",-102;":",-102;"::",-102;";",-102;"=",-102;"AS",-102;"IDENT",-102;"IN",-102;"LITERAL",-102;"WHEN",-102;"[",-102;"[|",-102;"]",-102;"{",-102;"|",-102;"|]",-102;"}",-102];["&",-103;"(",-103;")",-103;",",-103;"->",-103;":",-103;"::",-103;";",-103;"=",-103;"AS",-103;"IDENT",-103;"IN",-103;"LITERAL",-103;"WHEN",-103;"[",-103;"[|",-103;"]",-103;"{",-103;"|",-103;"|]",-103;"}",-103];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"IDENT",116;"LITERAL",55;"[",133;"[|",40;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"identExpr",57;"listExpr",58;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revQualificationExpr",167;"unaryExpr",181;"{",173];[")",-104;"*",-104;"+",-104;",",-104;"-",-104;"->",-104;":",-104;";",-104;"=",-104;"ALWAYS_INFIX",-104;"DO",-104;"ELIF",-104;"ELSE",-104;"EOF",-104;"FINALLY",-104;"RHSEND",-104;"RRPAREN",-104;"THEN",-104;"WITH",-104;"]",-104;"|",-104;"|]",-104;"}",-104];[")",-105;"*",-105;"+",-105;",",-105;"-",-105;"->",-105;":",-105;";",-105;"=",-105;"ALWAYS_INFIX",-105;"DO",-105;"ELIF",-105;"ELSE",-105;"EOF",-105;"FINALLY",-105;"RHSEND",-105;"RRPAREN",-105;"THEN",-105;"WITH",-105;"]",-105;"|",-105;"|]",-105;"}",-105];["&",-106;")",-106;"->",-106;"WHEN",-106;"|",-106];["(",12;":?",2;"AliasPattern",185;"AppPattern",254;"AtomicPattern",10;"ConsPattern",225;"IDENT",204;"LITERAL",15;"NamedPattern",177;"TuplePattern",6;"[",16;"[|",19;"annotatedPattern",255;"longid",22;"revAppPattern",11;"revConsPattern",27;"revLongid",137;"revTuplePattern",29;"unaryPattern",188;"{",23];["&",-107;")",-107;"->",-107;"WHEN",-107;"|",-107];["(",12;"AppPattern",254;"AtomicPattern",10;"IDENT",204;"LITERAL",15;"NamedPattern",177;"[",16;"[|",19;"annotatedPattern",255;"longid",22;"revAppPattern",11;"revLongid",137;"unaryPattern",187;"{",23];["&",-108;")",-108;",",-108;"->",-108;"::",-108;";",-108;"AS",-108;"IN",-108;"WHEN",-108;"]",-108;"|",-108;"|]",-108;"}",-108];["&",-109;")",-109;",",-109;"->",-109;"::",-109;";",-109;"AS",-109;"IN",-109;"WHEN",-109;"]",-109;"|",-109;"|]",-109;"}",-109];[")",-110;"->",-110;"WHEN",-110;"|",-110];["(",12;":?",2;"AliasPattern",183;"AppPattern",254;"AtomicPattern",10;"ConjunctivePattern",191;"ConsPattern",225;"IDENT",204;"LITERAL",15;"NamedPattern",177;"TuplePattern",6;"[",16;"[|",19;"annotatedPattern",255;"longid",22;"revAppPattern",11;"revConjunctivePattern",26;"revConsPattern",27;"revLongid",137;"revTuplePattern",29;"unaryPattern",188;"{",23];[")",-111;"->",-111;"WHEN",-111;"|",-111];[";",-112;"]",-112;"|]",-112];["(",12;"AppPattern",254;"AtomicPattern",10;"ConsPattern",225;"IDENT",204;"LITERAL",15;"NamedPattern",177;"TuplePattern",194;"[",16;"[|",19;"annotatedPattern",255;"longid",22;"revAppPattern",11;"revConsPattern",27;"revLongid",137;"revTuplePattern",29;"unaryPattern",188;"{",23];[";",-113;"]",-113;"|]",-113];[";",-114;"}",-114];["IDENT",100;"fieldPattern",197];[";",-115;"}",-115];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"IDENT",116;"LITERAL",55;"[",133;"[|",40;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",234;"identExpr",57;"listExpr",58;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revQualificationExpr",167;"thenPart",199;"unaryExpr",182;"{",173];["ELIF",-116;"ELSE",-116;"RHSEND",-116];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"IDENT",116;"LITERAL",55;"[",133;"[|",40;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",234;"identExpr",57;"listExpr",58;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revQualificationExpr",167;"thenPart",201;"unaryExpr",182;"{",173];["ELIF",-117;"ELSE",-117;"RHSEND",-117];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"FUN",129;"FUNCTION",112;"IDENT",116;"IF",198;"LITERAL",55;"LLPAREN",263;"MATCH",144;"MATCH_BANG",145;"TRY",237;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"functionExpr",256;"identExpr",57;"ifExpr",257;"lambdaExpr",258;"listExpr",58;"matchExpr",259;"matchKeyword",138;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revIfParts",120;"revQualificationExpr",167;"revTupleExpr",222;"tryFinallyExpr",260;"tryWithExpr",261;"tupleExpr",262;"unaryExpr",182;"valueExpr",265;"valueRhs",203;"{",173];["ELIF",-118;"ELSE",-118;"RHSEND",-118];["&",-119;"(",-119;")",-119;"*",-119;",",-119;"->",-119;".",-119;":",-119;"::",-119;";",-119;"<",-119;"=",-119;">",-119;"AND",-119;"AND_BANG",-119;"AS",-119;"ELIF",-119;"ELSE",-119;"EOF",-119;"FINALLY",-119;"IDENT",-119;"IN",-119;"LET",-119;"LET_BANG",-119;"LITERAL",-119;"OPEN",-119;"RHSEND",-119;"RRPAREN",-119;"USE",-119;"USE_BANG",-119;"WHEN",-119;"WITH",-119;"[",-119;"[|",-119;"]",-119;"{",-119;"|",-119;"|]",-119;"}",-119];["IDENT",206];["&",-120;"(",-120;")",-120;"*",-120;",",-120;"->",-120;".",-120;":",-120;"::",-120;";",-120;"<",-120;"=",-120;">",-120;"AND",-120;"AND_BANG",-120;"AS",-120;"ELIF",-120;"ELSE",-120;"EOF",-120;"FINALLY",-120;"IDENT",-120;"IN",-120;"LET",-120;"LET_BANG",-120;"LITERAL",-120;"OPEN",-120;"RHSEND",-120;"RRPAREN",-120;"USE",-120;"USE_BANG",-120;"WHEN",-120;"WITH",-120;"[",-120;"[|",-120;"]",-120;"{",-120;"|",-120;"|]",-120;"}",-120];[";",-121;"EOF",-121];["AND",68;"AND_BANG",69;"LET",70;"LET_BANG",71;"OPEN",146;"USE",72;"USE_BANG",73;"bindExpr",148;"bindKeyword",62;"openOrLet",209];[";",-122;"EOF",-122];["(",-123;")",-123;"*",-123;"+",-123;",",-123;"-",-123;"->",-123;".",-123;":",-123;";",-123;"<-",-123;"=",-123;"ALWAYS_INFIX",-123;"DO",-123;"ELIF",-123;"ELSE",-123;"EOF",-123;"FINALLY",-123;"IDENT",-123;"LITERAL",-123;"RHSEND",-123;"RRPAREN",-123;"THEN",-123;"WITH",-123;"[",-123;"[|",-123;"]",-123;"{",-123;"|",-123;"|]",-123;"}",-123];["(",-124;")",-124;"*",-124;"+",-124;",",-124;"-",-124;"->",-124;".",-124;":",-124;";",-124;"<-",-124;"=",-124;"ALWAYS_INFIX",-124;"DO",-124;"ELIF",-124;"ELSE",-124;"EOF",-124;"FINALLY",-124;"IDENT",-124;"LITERAL",-124;"RHSEND",-124;"RRPAREN",-124;"THEN",-124;"WITH",-124;"[",-124;"[|",-124;"]",-124;"{",-124;"|",-124;"|]",-124;"}",-124];["RHSEND",243;"|",213];["(",12;":?",2;"AliasPattern",183;"AppPattern",254;"AtomicPattern",10;"ConjunctivePattern",189;"ConsPattern",225;"DisjunctivePattern",156;"IDENT",204;"LITERAL",15;"NamedPattern",177;"TuplePattern",6;"[",16;"[|",19;"annotatedPattern",255;"longid",22;"patternAndGuard",228;"revAppPattern",11;"revConjunctivePattern",26;"revConsPattern",27;"revDisjunctivePattern",28;"revLongid",137;"revTuplePattern",29;"ruleClause",214;"unaryPattern",188;"{",23];["RHSEND",-125;"|",-125];["RHSEND",-126;"|",-126];[")",-127;";",-127;"RRPAREN",-127;"]",-127;"|]",-127];[";",219;"RRPAREN",245];[";",219;"RRPAREN",264];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"AND",68;"AND_BANG",69;"DO_BANG",162;"FOR",76;"FUN",129;"FUNCTION",112;"IDENT",116;"IF",198;"LET",70;"LET_BANG",71;"LITERAL",55;"MATCH",144;"MATCH_BANG",145;"RETURN",163;"RETURN_BANG",164;"TRY",237;"USE",72;"USE_BANG",73;"WHILE",266;"WHILE_BANG",267;"YIELD",165;"YIELD_BANG",166;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"bindExpr",82;"bindKeyword",62;"declExpr",220;"functionExpr",256;"identExpr",57;"ifExpr",257;"lambdaExpr",258;"listExpr",58;"matchExpr",259;"matchKeyword",138;"parenExpr",59;"prefix",252;"produceKeyword",83;"qualificationExpr",85;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revIfParts",120;"revQualificationExpr",167;"revTupleExpr",222;"tryFinallyExpr",260;"tryWithExpr",261;"tupleExpr",262;"unaryExpr",182;"valueExpr",88;"whileKeyword",89;"{",173];[")",-128;";",-128;"RRPAREN",-128;"]",-128;"|]",-128];[")",-129;",",-129;";",-129;"ELIF",-129;"ELSE",-129;"EOF",-129;"FINALLY",-129;"RHSEND",-129;"RRPAREN",-129;"WITH",-129;"]",-129;"|",-129;"|]",-129;"}",-129];[")",-139;",",223;";",-139;"ELIF",-139;"ELSE",-139;"EOF",-139;"FINALLY",-139;"RHSEND",-139;"RRPAREN",-139;"WITH",-139;"]",-139;"|",-139;"|]",-139;"}",-139];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"IDENT",116;"LITERAL",55;"[",133;"[|",40;"annotatedExpr",224;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"identExpr",57;"listExpr",58;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revQualificationExpr",167;"unaryExpr",182;"{",173];[")",-130;",",-130;";",-130;"ELIF",-130;"ELSE",-130;"EOF",-130;"FINALLY",-130;"RHSEND",-130;"RRPAREN",-130;"WITH",-130;"]",-130;"|",-130;"|]",-130;"}",-130];["&",-131;")",-131;",",-131;"->",-131;";",-131;"AS",-131;"IN",-131;"WHEN",-131;"]",-131;"|",-131;"|]",-131;"}",-131];["(",12;"AppPattern",254;"AtomicPattern",10;"ConsPattern",227;"IDENT",204;"LITERAL",15;"NamedPattern",177;"[",16;"[|",19;"annotatedPattern",255;"longid",22;"revAppPattern",11;"revConsPattern",27;"revLongid",137;"unaryPattern",188;"{",23];["&",-132;")",-132;",",-132;"->",-132;";",-132;"AS",-132;"IN",-132;"WHEN",-132;"]",-132;"|",-132;"|]",-132;"}",-132];["->",229];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"IDENT",116;"LITERAL",55;"LLPAREN",244;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"identExpr",57;"listExpr",58;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revQualificationExpr",167;"revTupleExpr",222;"tupleExpr",246;"tupleRhs",230;"unaryExpr",182;"{",173];["RHSEND",-133;"|",-133];["]",232];["&",-134;")",-134;"*",-134;",",-134;"->",-134;"::",-134;";",-134;"=",-134;">",-134;"AS",-134;"ELIF",-134;"ELSE",-134;"EOF",-134;"FINALLY",-134;"IDENT",-134;"IN",-134;"RHSEND",-134;"RRPAREN",-134;"WHEN",-134;"WITH",-134;"[",-134;"]",-134;"|",-134;"|]",-134;"}",-134];["&",-135;")",-135;"*",-135;",",-135;"->",-135;"::",-135;";",-135;"=",-135;">",-135;"AS",-135;"ELIF",-135;"ELSE",-135;"EOF",-135;"FINALLY",-135;"IDENT",-135;"IN",-135;"RHSEND",-135;"RRPAREN",-135;"WHEN",-135;"WITH",-135;"[",-135;"]",-135;"|",-135;"|]",-135;"}",-135];["THEN",235];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"FUN",129;"FUNCTION",112;"IDENT",116;"IF",198;"LITERAL",55;"LLPAREN",263;"MATCH",144;"MATCH_BANG",145;"TRY",237;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"functionExpr",256;"identExpr",57;"ifExpr",257;"lambdaExpr",258;"listExpr",58;"matchExpr",259;"matchKeyword",138;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revIfParts",120;"revQualificationExpr",167;"revTupleExpr",222;"tryFinallyExpr",260;"tryWithExpr",261;"tupleExpr",262;"unaryExpr",182;"valueExpr",265;"valueRhs",236;"{",173];["ELIF",-136;"ELSE",-136;"RHSEND",-136];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"IDENT",116;"LITERAL",55;"LLPAREN",244;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"identExpr",57;"listExpr",58;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revQualificationExpr",167;"revTupleExpr",222;"tupleExpr",246;"tupleRhs",238;"unaryExpr",182;"{",173];["FINALLY",239;"WITH",241];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"IDENT",116;"LITERAL",55;"LLPAREN",244;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"identExpr",57;"listExpr",58;"parenExpr",59;"prefix",252;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revQualificationExpr",167;"revTupleExpr",222;"tupleExpr",246;"tupleRhs",240;"unaryExpr",182;"{",173];[")",-137;";",-137;"ELIF",-137;"ELSE",-137;"EOF",-137;"RHSEND",-137;"RRPAREN",-137;"]",-137;"|]",-137;"}",-137];["(",-77;":?",-77;"IDENT",-77;"LITERAL",-77;"NamedPattern",-77;"[",-77;"[|",-77;"opt_bar",242;"{",-77;"|",149];["(",12;":?",2;"AliasPattern",183;"AppPattern",254;"AtomicPattern",10;"ConjunctivePattern",189;"ConsPattern",225;"DisjunctivePattern",156;"IDENT",204;"LITERAL",15;"NamedPattern",177;"TuplePattern",6;"[",16;"[|",19;"annotatedPattern",255;"longid",22;"patternAndGuard",228;"revAppPattern",11;"revConjunctivePattern",26;"revConsPattern",27;"revDisjunctivePattern",28;"revLongid",137;"revRuleClauses",212;"revTuplePattern",29;"ruleClause",215;"unaryPattern",188;"{",23];[")",-138;";",-138;"ELIF",-138;"ELSE",-138;"EOF",-138;"RHSEND",-138;"RRPAREN",-138;"]",-138;"|]",-138;"}",-138];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"AND",68;"AND_BANG",69;"DO_BANG",162;"FOR",76;"FUN",129;"FUNCTION",112;"IDENT",116;"IF",198;"LET",70;"LET_BANG",71;"LITERAL",55;"MATCH",144;"MATCH_BANG",145;"RETURN",163;"RETURN_BANG",164;"TRY",237;"USE",72;"USE_BANG",73;"WHILE",266;"WHILE_BANG",267;"YIELD",165;"YIELD_BANG",166;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"bindExpr",82;"bindKeyword",62;"declExpr",216;"functionExpr",256;"identExpr",57;"ifExpr",257;"lambdaExpr",258;"listExpr",58;"matchExpr",259;"matchKeyword",138;"parenExpr",59;"prefix",252;"produceKeyword",83;"qualificationExpr",85;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revIfParts",120;"revQualificationExpr",167;"revSequentialExpr",217;"revTupleExpr",222;"tryFinallyExpr",260;"tryWithExpr",261;"tupleExpr",262;"unaryExpr",182;"valueExpr",88;"whileKeyword",89;"{",173];[")",-140;";",-140;"ELIF",-140;"ELSE",-140;"EOF",-140;"FINALLY",-140;"RHSEND",-140;"RRPAREN",-140;"WITH",-140;"]",-140;"|",-140;"|]",-140;"}",-140];[")",-141;";",-141;"ELIF",-141;"ELSE",-141;"EOF",-141;"FINALLY",-141;"RHSEND",-141;"RRPAREN",-141;"WITH",-141;"]",-141;"|",-141;"|]",-141;"}",-141];["(",44;"IDENT",204;"TYPAR",47;"appType",37;"atomType",39;"longid",48;"revLongid",137];[",",-145;">",-145];["(",44;"IDENT",204;"TYPAR",47;"appType",36;"atomType",39;"funType",108;"longid",48;"revLongid",137;"tupleType",111;"typeArgument",250];[",",-146;">",-146];[")",-147;"*",-147;"+",-147;",",-147;"-",-147;"->",-147;":",-147;";",-147;"=",-147;"ALWAYS_INFIX",-147;"DO",-147;"ELIF",-147;"ELSE",-147;"EOF",-147;"FINALLY",-147;"RHSEND",-147;"RRPAREN",-147;"THEN",-147;"WITH",-147;"]",-147;"|",-147;"|]",-147;"}",-147];["(",52;"IDENT",116;"LITERAL",55;"[",133;"[|",40;"appExpr",253;"arrayExpr",56;"atomicExpr",210;"identExpr",57;"listExpr",58;"parenExpr",59;"qualificationExpr",175;"recdLiteralExpr",60;"revAppExpr",35;"revQualificationExpr",167;"{",173];[")",-148;"*",-148;"+",-148;",",-148;"-",-148;"->",-148;":",-148;";",-148;"=",-148;"ALWAYS_INFIX",-148;"DO",-148;"ELIF",-148;"ELSE",-148;"EOF",-148;"FINALLY",-148;"RHSEND",-148;"RRPAREN",-148;"THEN",-148;"WITH",-148;"]",-148;"|",-148;"|]",-148;"}",-148];["&",-149;")",-149;",",-149;"->",-149;"::",-149;";",-149;"AS",-149;"IN",-149;"WHEN",-149;"]",-149;"|",-149;"|]",-149;"}",-149];["&",-150;")",-150;",",-150;"->",-150;"::",-150;";",-150;"AS",-150;"IN",-150;"WHEN",-150;"]",-150;"|",-150;"|]",-150;"}",-150];[")",-151;";",-151;"ELIF",-151;"ELSE",-151;"EOF",-151;"RHSEND",-151;"RRPAREN",-151;"]",-151;"|]",-151;"}",-151];[")",-152;";",-152;"ELIF",-152;"ELSE",-152;"EOF",-152;"RHSEND",-152;"RRPAREN",-152;"]",-152;"|]",-152;"}",-152];[")",-153;";",-153;"ELIF",-153;"ELSE",-153;"EOF",-153;"RHSEND",-153;"RRPAREN",-153;"]",-153;"|]",-153;"}",-153];[")",-154;";",-154;"ELIF",-154;"ELSE",-154;"EOF",-154;"RHSEND",-154;"RRPAREN",-154;"]",-154;"|]",-154;"}",-154];[")",-155;";",-155;"ELIF",-155;"ELSE",-155;"EOF",-155;"RHSEND",-155;"RRPAREN",-155;"]",-155;"|]",-155;"}",-155];[")",-156;";",-156;"ELIF",-156;"ELSE",-156;"EOF",-156;"RHSEND",-156;"RRPAREN",-156;"]",-156;"|]",-156;"}",-156];[")",-157;";",-157;"ELIF",-157;"ELSE",-157;"EOF",-157;"RHSEND",-157;"RRPAREN",-157;"]",-157;"|]",-157;"}",-157];["(",52;"+",159;"-",160;"ALWAYS_PREFIX",161;"AND",68;"AND_BANG",69;"DO_BANG",162;"FOR",76;"FUN",129;"FUNCTION",112;"IDENT",116;"IF",198;"LET",70;"LET_BANG",71;"LITERAL",55;"MATCH",144;"MATCH_BANG",145;"RETURN",163;"RETURN_BANG",164;"TRY",237;"USE",72;"USE_BANG",73;"WHILE",266;"WHILE_BANG",267;"YIELD",165;"YIELD_BANG",166;"[",133;"[|",40;"annotatedExpr",221;"appExpr",251;"arrayExpr",56;"atomicExpr",210;"binaryExpr",30;"bindExpr",82;"bindKeyword",62;"declExpr",216;"functionExpr",256;"identExpr",57;"ifExpr",257;"lambdaExpr",258;"listExpr",58;"matchExpr",259;"matchKeyword",138;"parenExpr",59;"prefix",252;"produceKeyword",83;"qualificationExpr",85;"recdLiteralExpr",60;"revAppExpr",35;"revBinaryExpr",61;"revIfParts",120;"revQualificationExpr",167;"revSequentialExpr",218;"revTupleExpr",222;"tryFinallyExpr",260;"tryWithExpr",261;"tupleExpr",262;"unaryExpr",182;"valueExpr",88;"whileKeyword",89;"{",173];[")",-158;";",-158;"ELIF",-158;"ELSE",-158;"EOF",-158;"RHSEND",-158;"RRPAREN",-158;"]",-158;"|]",-158;"}",-158];[")",-159;";",-159;"ELIF",-159;"ELSE",-159;"EOF",-159;"RHSEND",-159;"RRPAREN",-159;"]",-159;"|]",-159;"}",-159];["(",-160;"+",-160;"-",-160;"ALWAYS_PREFIX",-160;"IDENT",-160;"LITERAL",-160;"[",-160;"[|",-160;"{",-160];["(",-161;"+",-161;"-",-161;"ALWAYS_PREFIX",-161;"IDENT",-161;"LITERAL",-161;"[",-161;"[|",-161;"{",-161]]
let rules: list<string list*(obj list->obj)> = [
    ["";"file"], (fun (ss:obj list) -> ss.[0])
    ["AliasPattern";":?";"tupleType"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(option<int>*TypeArgument) list> ss.[1]
        let result:int option*Pattern =
            let _, tt = TypeArgument.ofTuple s1
            s0, DynamicTypeTestPattern(tt,"") 
        box result)
    ["AliasPattern";":?";"tupleType";"AS";"IDENT"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(option<int>*TypeArgument) list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>*string> ss.[3]
        let result:int option*Pattern =
            let _, tt = TypeArgument.ofTuple s1
            s0, DynamicTypeTestPattern(tt, snd s3)
        box result)
    ["AliasPattern";"TuplePattern"], (fun(ss:obj list)->
        let s0 = unbox<int option*Pattern> ss.[0]
        let result:int option*Pattern =
            s0
        box result)
    ["AliasPattern";"TuplePattern";"AS";"IDENT"], (fun(ss:obj list)->
        let s0 = unbox<int option*Pattern> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*string> ss.[2]
        let result:int option*Pattern =
            fst s0, AliasPattern(snd s0,snd s2)
        box result)
    ["AppPattern";"AtomicPattern"], (fun(ss:obj list)->
        let s0 = unbox<int option*Pattern> ss.[0]
        let result:int option*Pattern =
            s0
        box result)
    ["AppPattern";"revAppPattern"], (fun(ss:obj list)->
        let s0 = unbox<(int option*Pattern)list> ss.[0]
        let result:int option*Pattern =
            Pattern.toAppPattern s0
        box result)
    ["AtomicPattern";"(";"DisjunctivePattern";")"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<int option*Pattern> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:int option*Pattern =
            s0, snd s1
        box result)
    ["AtomicPattern";"LITERAL"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Literal> ss.[0]
        let result:int option*Pattern =
            fst s0, LiteralPattern(snd s0)
        box result)
    ["AtomicPattern";"[";"revElementPatterns";"]"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(int option*Pattern)list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:int option*Pattern =
            s0,ListPattern(s1 |> List.map snd |> List.rev)
        box result)
    ["AtomicPattern";"[|";"revElementPatterns";"|]"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(int option*Pattern)list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:int option*Pattern =
            s0,ArrayPattern(s1 |> List.map snd |> List.rev)
        box result)
    ["AtomicPattern";"longid"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string list> ss.[0]
        let result:int option*Pattern =
            fst s0, NamedPattern(snd s0, [])
        box result)
    ["AtomicPattern";"{";"revFieldPatterns";"}"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(int option*(string*Pattern))list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:int option*Pattern =
            s0,RecordPattern(s1 |> List.map snd |> List.rev)
        box result)
    ["ConjunctivePattern";"revConjunctivePattern"], (fun(ss:obj list)->
        let s0 = unbox<(int option*Pattern)list> ss.[0]
        let result:int option*Pattern =
            Pattern.toConjunctivePattern(List.rev s0)
        box result)
    ["ConsPattern";"revConsPattern"], (fun(ss:obj list)->
        let s0 = unbox<(int option*Pattern)list> ss.[0]
        let result:int option*Pattern =
            Pattern.toConsPattern s0
        box result)
    ["DisjunctivePattern";"revDisjunctivePattern"], (fun(ss:obj list)->
        let s0 = unbox<(int option*Pattern)list> ss.[0]
        let result:int option*Pattern =
            Pattern.toDisjunctivePattern(List.rev s0)
        box result)
    ["TuplePattern";"revTuplePattern"], (fun(ss:obj list)->
        let s0 = unbox<(int option*Pattern)list> ss.[0]
        let result:int option*Pattern =
            Pattern.toTuplePattern s0
        box result)
    ["annotatedExpr";"binaryExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
        box result)
    ["annotatedExpr";"binaryExpr";":";"typeArgument"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*TypeArgument> ss.[2]
        let result:option<int>*Expr =
            fst s0, TypeAnnotatedExpr(snd s0, snd s2)
        box result)
    ["annotatedPattern";"AtomicPattern";":";"tupleType"], (fun(ss:obj list)->
        let s0 = unbox<int option*Pattern> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int>*TypeArgument) list> ss.[2]
        let result:int option*Pattern =
            fst s0, TypeAnnotatedPattern(snd s0, snd(TypeArgument.ofTuple s2))
        box result)
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
    ["binaryExpr";"revBinaryExpr"], (fun(ss:obj list)->
        let s0 = unbox<(option<int> * Either<string, Expr>) list> ss.[0]
        let result:option<int>*Expr =
            Expr.ofBinaryExpr s0
        box result)
    ["bindExpr";"bindKeyword";"opt_rec";"opt_mutable";"bindPattern";"=";"valueRhs"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let s1 = unbox<option<int>*string option> ss.[1]
        let s2 = unbox<option<int>*string option> ss.[2]
        let s3 = unbox<int option*Pattern> ss.[3]
        let s4 = unbox<option<int>> ss.[4]
        let s5 = unbox<(option<int>*Expr) list> ss.[5]
        let result:option<int>*Expr =
            let opts =
                [
                    snd s1
                    snd s2
                ]
                |> List.choose id
            fst s0, LetBindingExpr(snd s0, opts, snd s3, snd(Expr.ofSequentialExpr s5))
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
    ["bindPattern";"revAppPattern";"opt_topReturnTypeWithTypeConstraints"], (fun(ss:obj list)->
        null)
    ["declExpr";"FOR";"AliasPattern";"IN";"binaryExpr";"DO";"valueRhs"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<int option*Pattern> ss.[1]
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
    ["fieldPattern";"IDENT";"=";"TuplePattern"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<int option*Pattern> ss.[2]
        let result:int option*(string*Pattern) =
            fst s0, (snd s0, snd s2)
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
    ["functionExpr";"FUNCTION";"opt_bar";"revRuleClauses";"RHSEND"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int>*RuleClause) list> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let result:option<int>*Expr =
            s0, FunctionExpr(s2 |> List.rev |> List.map snd)
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
    ["lambdaExpr";"FUN";"AppPattern";"->";"tupleRhs"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<int option*Pattern> ss.[1]
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
    ["matchExpr";"matchKeyword";"tupleExpr";"WITH";"opt_bar";"revRuleClauses";"RHSEND"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*string> ss.[0]
        let s1 = unbox<option<int>*Expr> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let s4 = unbox<(option<int>*RuleClause) list> ss.[4]
        let s5 = unbox<option<int>> ss.[5]
        let result:option<int>*Expr =
            fst s0, MatchExpr(snd s0, snd s1, s4 |> List.rev |> List.map snd)
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
    ["opt_mutable"], (fun(ss:obj list)->
        let result:option<int>*string option =
            None,None
        box result)
    ["opt_mutable";"MUTABLE"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string option =
            s0, Some "mutable"
        box result)
    ["opt_rec"], (fun(ss:obj list)->
        let result:option<int>*string option =
            None,None
        box result)
    ["opt_rec";"REC"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let result:option<int>*string option =
            s0, Some "rec"
        box result)
    ["opt_topReturnTypeWithTypeConstraints"], (fun(ss:obj list)->
        let result:option<int>*TypeArgument option =
            None, None
        box result)
    ["opt_topReturnTypeWithTypeConstraints";":";"typeArgument"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*TypeArgument> ss.[1]
        let result:option<int>*TypeArgument option =
            s0, Some(snd s1)
        box result)
    ["parenExpr";"(";"revSequentialExpr";")"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(option<int>*Expr) list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let result:option<int>*Expr =
            s0, ParenExpr(snd (Expr.ofSequentialExpr s1))
        box result)
    ["patternAndGuard";"DisjunctivePattern"], (fun(ss:obj list)->
        let s0 = unbox<int option*Pattern> ss.[0]
        let result:option<int>*Pattern*Expr option =
            fst s0, snd s0, None
        box result)
    ["patternAndGuard";"DisjunctivePattern";"WHEN";"binaryExpr"], (fun(ss:obj list)->
        let s0 = unbox<int option*Pattern> ss.[0]
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
    ["revAppPattern";"NamedPattern";"AtomicPattern"], (fun(ss:obj list)->
        let s0 = unbox<int option*Pattern> ss.[0]
        let s1 = unbox<int option*Pattern> ss.[1]
        let result:(int option*Pattern)list =
            [s1;s0]
        box result)
    ["revAppPattern";"revAppPattern";"AtomicPattern"], (fun(ss:obj list)->
        let s0 = unbox<(int option*Pattern)list> ss.[0]
        let s1 = unbox<int option*Pattern> ss.[1]
        let result:(int option*Pattern)list =
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
    ["revConjunctivePattern";"AliasPattern"], (fun(ss:obj list)->
        let s0 = unbox<int option*Pattern> ss.[0]
        let result:(int option*Pattern)list =
            [s0]
        box result)
    ["revConjunctivePattern";"revConjunctivePattern";"&";"AliasPattern"], (fun(ss:obj list)->
        let s0 = unbox<(int option*Pattern)list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<int option*Pattern> ss.[2]
        let result:(int option*Pattern)list =
            s2::s0
        box result)
    ["revConsPattern";"revConsPattern";"::";"unaryPattern"], (fun(ss:obj list)->
        let s0 = unbox<(int option*Pattern)list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<int option*Pattern> ss.[2]
        let result:(int option*Pattern)list =
            s2::s0
        box result)
    ["revConsPattern";"unaryPattern"], (fun(ss:obj list)->
        let s0 = unbox<int option*Pattern> ss.[0]
        let result:(int option*Pattern)list =
            [s0]
        box result)
    ["revDisjunctivePattern";"ConjunctivePattern"], (fun(ss:obj list)->
        let s0 = unbox<int option*Pattern> ss.[0]
        let result:(int option*Pattern)list =
            [s0]
        box result)
    ["revDisjunctivePattern";"revDisjunctivePattern";"|";"ConjunctivePattern"], (fun(ss:obj list)->
        let s0 = unbox<(int option*Pattern)list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<int option*Pattern> ss.[2]
        let result:(int option*Pattern)list =
            s2::s0
        box result)
    ["revElementPatterns";"TuplePattern"], (fun(ss:obj list)->
        let s0 = unbox<int option*Pattern> ss.[0]
        let result:(int option*Pattern)list =
            [s0]
        box result)
    ["revElementPatterns";"revElementPatterns";";";"TuplePattern"], (fun(ss:obj list)->
        let s0 = unbox<(int option*Pattern)list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<int option*Pattern> ss.[2]
        let result:(int option*Pattern)list =
            s2::s0
        box result)
    ["revFieldPatterns";"fieldPattern"], (fun(ss:obj list)->
        let s0 = unbox<int option*(string*Pattern)> ss.[0]
        let result:(int option*(string*Pattern))list =
            [s0]
        box result)
    ["revFieldPatterns";"revFieldPatterns";";";"fieldPattern"], (fun(ss:obj list)->
        let s0 = unbox<(int option*(string*Pattern))list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<int option*(string*Pattern)> ss.[2]
        let result:(int option*(string*Pattern))list =
            s2::s0
        box result)
    ["revIfParts";"IF";"thenPart"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<option<int>*IfBranch> ss.[1]
        let result:(option<int>*IfBranch) list =
            [s0, snd s1]
        box result)
    ["revIfParts";"revIfParts";"ELIF";"thenPart"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*IfBranch) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*IfBranch> ss.[2]
        let result:(option<int>*IfBranch) list =
            (s1, snd s2) :: s0
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
    ["revTupleExpr";"annotatedExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:(option<int>*Expr) list =
            [s0]
        box result)
    ["revTupleExpr";"revTupleExpr";",";"annotatedExpr"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<option<int>*Expr> ss.[2]
        let result:(option<int>*Expr) list =
            s2::s0
        box result)
    ["revTuplePattern";"ConsPattern"], (fun(ss:obj list)->
        let s0 = unbox<int option*Pattern> ss.[0]
        let result:(int option*Pattern)list =
            [s0]
        box result)
    ["revTuplePattern";"revTuplePattern";",";"ConsPattern"], (fun(ss:obj list)->
        let s0 = unbox<(int option*Pattern)list> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<int option*Pattern> ss.[2]
        let result:(int option*Pattern)list =
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
    ["thenPart";"binaryExpr";"THEN";"valueRhs"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let s1 = unbox<option<int>> ss.[1]
        let s2 = unbox<(option<int>*Expr) list> ss.[2]
        let result:option<int>*IfBranch =
            fst s0, IfBranch(Some(snd s0), snd(Expr.ofSequentialExpr s2))
        box result)
    ["tryFinallyExpr";"TRY";"tupleRhs";"FINALLY";"tupleRhs"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(option<int>*Expr) list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<(option<int>*Expr) list> ss.[3]
        let result:option<int>*Expr =
            s0, TryFinallyExpr(s1 |> List.rev |> List.map snd, s3 |> List.rev |> List.map snd)
        box result)
    ["tryWithExpr";"TRY";"tupleRhs";"WITH";"opt_bar";"revRuleClauses";"RHSEND"], (fun(ss:obj list)->
        let s0 = unbox<option<int>> ss.[0]
        let s1 = unbox<(option<int>*Expr) list> ss.[1]
        let s2 = unbox<option<int>> ss.[2]
        let s3 = unbox<option<int>> ss.[3]
        let s4 = unbox<(option<int>*RuleClause) list> ss.[4]
        let s5 = unbox<option<int>> ss.[5]
        let result:option<int>*Expr =
            s0, TryWithExpr(s1 |> List.rev |> List.map snd, s4 |> List.rev |> List.map snd)
        box result)
    ["tupleExpr";"revTupleExpr"], (fun(ss:obj list)->
        let s0 = unbox<(option<int>*Expr) list> ss.[0]
        let result:option<int>*Expr =
            Expr.ofTupleExpr s0
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
    ["unaryPattern";"AppPattern"], (fun(ss:obj list)->
        let s0 = unbox<int option*Pattern> ss.[0]
        let result:int option*Pattern =
            s0
        box result)
    ["unaryPattern";"annotatedPattern"], (fun(ss:obj list)->
        let s0 = unbox<int option*Pattern> ss.[0]
        let result:int option*Pattern =
            s0
        box result)
    ["valueExpr";"functionExpr"], (fun(ss:obj list)->
        let s0 = unbox<option<int>*Expr> ss.[0]
        let result:option<int>*Expr =
            s0
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
    ["valueExpr";"tryFinallyExpr"], (fun(ss:obj list)->
        null)
    ["valueExpr";"tryWithExpr"], (fun(ss:obj list)->
        null)
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
