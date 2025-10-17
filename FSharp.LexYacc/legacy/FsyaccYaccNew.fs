module FSharp.LexYacc.FsyaccYaccNew
let tokens = set ["%left";"%nonassoc";"%prec";"%right";":";"BRACES";"ID";"PERCENT_TYPE";"QUOTE";"|"]
let kernels = [[0,0];[0,1];[-1,1];[-2,1];[-3,1];[-5,1];[-6,1];[-6,2;-20,1];[-7,1];[-8,1;-10,3];[-8,1;-12,4];[-8,2];[-9,1;-10,1;-11,1;-12,1];[-9,2;-10,2;-11,2;-12,2;-27,1];[-11,3;-12,3;-19,1];[-14,1;-20,1];[-16,1];[-16,2];[-17,1];[-17,2;-20,1];[-18,1];[-19,2];[-20,2];[-21,1];[-22,1;-25,4];[-22,2];[-22,3];[-23,1];[-24,1];[-24,2];[-24,3];[-25,1];[-25,2];[-25,3];[-26,1];[-27,2];[-28,1];[-29,1]]
let kernelSymbols = ["";"file";"%left";"%nonassoc";"%right";"|";"PERCENT_TYPE";"require_symbols";"declaration";"declarations";"declarations";"declaration";"BRACES";"ruleGroups";"precedences";"require_symbols";"%prec";"ID";"assoc";"require_symbols";"precedence";"precedence";"symbol";"symbol";"ruleBodies";"|";"ruleBody";"ruleBody";"nullable_symbols";"prec_opt";"BRACES";"symbol";":";"bar_opt";"ruleGroup";"ruleGroup";"ID";"QUOTE"]
let actions = [["BRACES",12;"file",1];["",0];["ID",-1;"QUOTE",-1];["ID",-2;"QUOTE",-2];["ID",-3;"QUOTE",-3];["%prec",-5;"BRACES",-5;"ID",-5;"QUOTE",-5];["ID",36;"QUOTE",37;"require_symbols",7;"symbol",23];["",-6;"ID",36;"PERCENT_TYPE",-6;"QUOTE",37;"symbol",22];["",-7;"PERCENT_TYPE",-7];["",-10;"PERCENT_TYPE",6;"declaration",11];["",-12;"PERCENT_TYPE",6;"declaration",11];["",-8;"PERCENT_TYPE",-8];["ID",36;"QUOTE",37;"ruleGroup",34;"ruleGroups",13;"symbol",31];["",-9;"%left",2;"%nonassoc",3;"%right",4;"ID",36;"PERCENT_TYPE",6;"QUOTE",37;"assoc",18;"declaration",8;"declarations",9;"precedence",20;"precedences",14;"ruleGroup",35;"symbol",31];["",-11;"%left",2;"%nonassoc",3;"%right",4;"PERCENT_TYPE",6;"assoc",18;"declaration",8;"declarations",10;"precedence",21];["%prec",-14;"BRACES",-14;"ID",36;"QUOTE",37;"symbol",22];["ID",17];["BRACES",-16];["ID",36;"QUOTE",37;"require_symbols",19;"symbol",23];["",-17;"%left",-17;"%nonassoc",-17;"%right",-17;"ID",36;"PERCENT_TYPE",-17;"QUOTE",37;"symbol",22];["",-18;"%left",-18;"%nonassoc",-18;"%right",-18;"PERCENT_TYPE",-18];["",-19;"%left",-19;"%nonassoc",-19;"%right",-19;"PERCENT_TYPE",-19];["",-20;"%left",-20;"%nonassoc",-20;"%prec",-20;"%right",-20;"BRACES",-20;"ID",-20;"PERCENT_TYPE",-20;"QUOTE",-20];["",-21;"%left",-21;"%nonassoc",-21;"%prec",-21;"%right",-21;"BRACES",-21;"ID",-21;"PERCENT_TYPE",-21;"QUOTE",-21];["",-25;"%left",-25;"%nonassoc",-25;"%right",-25;"ID",-25;"PERCENT_TYPE",-25;"QUOTE",-25;"|",25];["%prec",-13;"BRACES",-13;"ID",36;"QUOTE",37;"nullable_symbols",28;"require_symbols",15;"ruleBody",26;"symbol",23];["",-22;"%left",-22;"%nonassoc",-22;"%right",-22;"ID",-22;"PERCENT_TYPE",-22;"QUOTE",-22;"|",-22];["",-23;"%left",-23;"%nonassoc",-23;"%right",-23;"ID",-23;"PERCENT_TYPE",-23;"QUOTE",-23;"|",-23];["%prec",16;"BRACES",-15;"prec_opt",29];["BRACES",30];["",-24;"%left",-24;"%nonassoc",-24;"%right",-24;"ID",-24;"PERCENT_TYPE",-24;"QUOTE",-24;"|",-24];[":",32];["%prec",-4;"BRACES",-4;"ID",-4;"QUOTE",-4;"bar_opt",33;"|",5];["%prec",-13;"BRACES",-13;"ID",36;"QUOTE",37;"nullable_symbols",28;"require_symbols",15;"ruleBodies",24;"ruleBody",27;"symbol",23];["",-26;"%left",-26;"%nonassoc",-26;"%right",-26;"ID",-26;"PERCENT_TYPE",-26;"QUOTE",-26];["",-27;"%left",-27;"%nonassoc",-27;"%right",-27;"ID",-27;"PERCENT_TYPE",-27;"QUOTE",-27];["",-28;"%left",-28;"%nonassoc",-28;"%prec",-28;"%right",-28;":",-28;"BRACES",-28;"ID",-28;"PERCENT_TYPE",-28;"QUOTE",-28];["",-29;"%left",-29;"%nonassoc",-29;"%prec",-29;"%right",-29;":",-29;"BRACES",-29;"ID",-29;"PERCENT_TYPE",-29;"QUOTE",-29]]
let rules : list<string list*(obj list->obj)> = [
    ["";"file"], fun(ss:obj list)-> ss.[0]
    ["assoc";"%left"], fun(ss:obj list)->
        let result:Associativity =
            LeftAssoc
        box result
    ["assoc";"%nonassoc"], fun(ss:obj list)->
        let result:Associativity =
            NonAssoc
        box result
    ["assoc";"%right"], fun(ss:obj list)->
        let result:Associativity =
            RightAssoc
        box result
    ["bar_opt"], fun(ss:obj list)->
        null
    ["bar_opt";"|"], fun(ss:obj list)->
        null
    ["declaration";"PERCENT_TYPE";"require_symbols"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s1 = unbox<string list> ss.[1]
        let result:DeclarationStatement =
            let symbols =
                s1
                |> List.rev
            DeclarationStatement.just(s0,symbols)
        box result
    ["declarations";"declaration"], fun(ss:obj list)->
        let s0 = unbox<DeclarationStatement> ss.[0]
        let result:DeclarationStatement list =
            [s0]
        box result
    ["declarations";"declarations";"declaration"], fun(ss:obj list)->
        let s0 = unbox<DeclarationStatement list> ss.[0]
        let s1 = unbox<DeclarationStatement> ss.[1]
        let result:DeclarationStatement list =
            s1::s0
        box result
    ["file";"BRACES";"ruleGroups"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s1 = unbox<RuleGroup list> ss.[1]
        let result:RawFsyaccFile =
            RawFsyaccFile.just(s0,List.rev s1,[],[])
        box result
    ["file";"BRACES";"ruleGroups";"declarations"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s1 = unbox<RuleGroup list> ss.[1]
        let s2 = unbox<DeclarationStatement list> ss.[2]
        let result:RawFsyaccFile =
            RawFsyaccFile.just(s0,List.rev s1,[],List.rev s2)
        box result
    ["file";"BRACES";"ruleGroups";"precedences"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s1 = unbox<RuleGroup list> ss.[1]
        let s2 = unbox<PrecedenceStatement list> ss.[2]
        let result:RawFsyaccFile =
            RawFsyaccFile.just(s0,List.rev s1,List.rev s2,[])
        box result
    ["file";"BRACES";"ruleGroups";"precedences";"declarations"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s1 = unbox<RuleGroup list> ss.[1]
        let s2 = unbox<PrecedenceStatement list> ss.[2]
        let s3 = unbox<DeclarationStatement list> ss.[3]
        let result:RawFsyaccFile =
            RawFsyaccFile.just(s0,List.rev s1,List.rev s2,List.rev s3)
        box result
    ["nullable_symbols"], fun(ss:obj list)->
        let result:string list =
            []
        box result
    ["nullable_symbols";"require_symbols"], fun(ss:obj list)->
        let s0 = unbox<string list> ss.[0]
        let result:string list =
            s0
        box result
    ["prec_opt"], fun(ss:obj list)->
        let result:string =
            ""
        box result
    ["prec_opt";"%prec";"ID"], fun(ss:obj list)->
        let s1 = unbox<string> ss.[1]
        let result:string =
            s1
        box result
    ["precedence";"assoc";"require_symbols"], fun(ss:obj list)->
        let s0 = unbox<Associativity> ss.[0]
        let s1 = unbox<string list> ss.[1]
        let result:PrecedenceStatement =
            let s1 = s1 |> List.rev
            PrecedenceStatement.just(s0,s1)
        box result
    ["precedences";"precedence"], fun(ss:obj list)->
        let s0 = unbox<PrecedenceStatement> ss.[0]
        let result:PrecedenceStatement list =
            [s0]
        box result
    ["precedences";"precedences";"precedence"], fun(ss:obj list)->
        let s0 = unbox<PrecedenceStatement list> ss.[0]
        let s1 = unbox<PrecedenceStatement> ss.[1]
        let result:PrecedenceStatement list =
            s1::s0
        box result
    ["require_symbols";"require_symbols";"symbol"], fun(ss:obj list)->
        let s0 = unbox<string list> ss.[0]
        let s1 = unbox<string> ss.[1]
        let result:string list =
            s1::s0
        box result
    ["require_symbols";"symbol"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let result:string list =
            [s0]
        box result
    ["ruleBodies";"ruleBodies";"|";"ruleBody"], fun(ss:obj list)->
        let s0 = unbox<RuleBody list> ss.[0]
        let s2 = unbox<RuleBody> ss.[2]
        let result:RuleBody list =
            s2::s0
        box result
    ["ruleBodies";"ruleBody"], fun(ss:obj list)->
        let s0 = unbox<RuleBody> ss.[0]
        let result:RuleBody list =
            [s0]
        box result
    ["ruleBody";"nullable_symbols";"prec_opt";"BRACES"], fun(ss:obj list)->
        let s0 = unbox<string list> ss.[0]
        let s1 = unbox<string> ss.[1]
        let s2 = unbox<string> ss.[2]
        let result:RuleBody =
            let s0 = s0 |> List.rev
            RuleBody.just( s0, s1, s2 )
        box result
    ["ruleGroup";"symbol";":";"bar_opt";"ruleBodies"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s3 = unbox<RuleBody list> ss.[3]
        let result:RuleGroup =
            let lhs = s0
            let bodies = List.rev s3
            RuleGroup.just(lhs, bodies)
        box result
    ["ruleGroups";"ruleGroup"], fun(ss:obj list)->
        let s0 = unbox<RuleGroup> ss.[0]
        let result:RuleGroup list =
            [s0]
        box result
    ["ruleGroups";"ruleGroups";"ruleGroup"], fun(ss:obj list)->
        let s0 = unbox<RuleGroup list> ss.[0]
        let s1 = unbox<RuleGroup> ss.[1]
        let result:RuleGroup list =
            s1::s0
        box result
    ["symbol";"ID"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let result:string =
            s0
        box result
    ["symbol";"QUOTE"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let result:string =
            s0
        box result
]
let unboxRoot =
    unbox<RawFsyaccFile>
let app: FSharp.LexYacc.ParseTableApp = {
    tokens        = tokens
    kernels       = kernels
    kernelSymbols = kernelSymbols
    actions       = actions
    rules         = rules
}