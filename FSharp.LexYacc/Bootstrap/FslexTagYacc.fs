module FSharp.LexYacc.Bootstrap.FslexTagYacc
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap
let actions: (string * int) list list = [["BRACES",35;"file",1];["",0];["ID",3];["=",4];["(",16;"ID",19;"QUOTE",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",5];["&",30;"*",31;"+",32;"?",33;"LET",-1;"RULE",-1;"|",34];["LET",2;"RULE",42;"definition",7;"ruler",36];["LET",-3;"RULE",-3];["ID",-4;"QUOTE",-4;"]",-4];["-",10;"ID",-5;"QUOTE",-5;"]",-5];["QUOTE",11];["ID",-6;"QUOTE",-6;"]",-6];["ID",-7;"QUOTE",-7;"]",-7];["ID",8;"QUOTE",9;"]",23;"elem",15];["ID",8;"QUOTE",9;"]",25;"elem",15];["ID",-8;"QUOTE",-8;"]",-8];["(",16;"ID",19;"QUOTE",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",17];["&",30;")",18;"*",31;"+",32;"?",33;"|",34];["&",-9;")",-9;"*",-9;"+",-9;"/",-9;"?",-9;"BRACES",-9;"LET",-9;"RULE",-9;"|",-9];["&",-10;")",-10;"*",-10;"+",-10;"/",-10;"?",-10;"BRACES",-10;"LET",-10;"RULE",-10;"|",-10];["&",-11;")",-11;"*",-11;"+",-11;"/",-11;"?",-11;"BRACES",-11;"LET",-11;"RULE",-11;"|",-11];["&",-12;")",-12;"*",-12;"+",-12;"/",-12;"?",-12;"BRACES",-12;"LET",-12;"RULE",-12;"|",-12];["ID",8;"QUOTE",9;"elem",12;"elems",13];["&",-13;")",-13;"*",-13;"+",-13;"/",-13;"?",-13;"BRACES",-13;"LET",-13;"RULE",-13;"|",-13];["ID",8;"QUOTE",9;"elem",12;"elems",14];["&",-14;")",-14;"*",-14;"+",-14;"/",-14;"?",-14;"BRACES",-14;"LET",-14;"RULE",-14;"|",-14];["&",-15;")",-15;"*",31;"+",32;"/",-15;"?",33;"BRACES",-15;"LET",-15;"RULE",-15;"|",-15];["&",30;")",-19;"*",31;"+",32;"/",-19;"?",33;"BRACES",-19;"LET",-19;"RULE",-19;"|",-19];["&",30;"*",31;"+",32;"/",39;"?",33;"BRACES",41;"|",34];["&",30;"*",31;"+",32;"?",33;"BRACES",40;"|",34];["(",16;"ID",19;"QUOTE",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",26];["&",-16;")",-16;"*",-16;"+",-16;"/",-16;"?",-16;"BRACES",-16;"LET",-16;"RULE",-16;"|",-16];["&",-17;")",-17;"*",-17;"+",-17;"/",-17;"?",-17;"BRACES",-17;"LET",-17;"RULE",-17;"|",-17];["&",-18;")",-18;"*",-18;"+",-18;"/",-18;"?",-18;"BRACES",-18;"LET",-18;"RULE",-18;"|",-18];["(",16;"ID",19;"QUOTE",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",27];["LET",-2;"RULE",-2;"definitions",6];["",-20];[":",43;"=",47;"ID",38];[":",-22;"=",-22;"ID",-22];["(",16;"ID",19;"QUOTE",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",29];["",-23;"(",-23;"ID",-23;"QUOTE",-23;"UNDERSCORE",-23;"[",-23;"[^",-23];["",-24;"(",-24;"ID",-24;"QUOTE",-24;"UNDERSCORE",-24;"[",-24;"[^",-24];[":",-21;"=",-21;"ID",-21;"parameters",37];["FUN_TYPE",44];["=",45];["(",16;"ID",19;"QUOTE",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",28;"rule",49;"rules",46];["",-25;"(",16;"ID",19;"QUOTE",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",28;"rule",50];["(",16;"ID",19;"QUOTE",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",28;"rule",49;"rules",48];["",-26;"(",16;"ID",19;"QUOTE",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",28;"rule",50];["",-27;"(",-27;"ID",-27;"QUOTE",-27;"UNDERSCORE",-27;"[",-27;"[^",-27];["",-28;"(",-28;"ID",-28;"QUOTE",-28;"UNDERSCORE",-28;"[",-28;"[^",-28]]
let rules: list<string list*(obj list->obj)> = [
    ["";"file"], fun (ss:obj list) -> ss.[0]
    ["definition";"LET";"ID";"=";"expr"], fun(ss:obj list)->
        let s1 = unbox<string> ss.[1]
        let s3 = unbox<ParsedRgx<string>> ss.[3]
        let result:string*ParsedRgx<string> =
            s1,s3
        box result
    ["definitions"], fun(ss:obj list)->
        let result:(string*ParsedRgx<string>)list =
            []
        box result
    ["definitions";"definitions";"definition"], fun(ss:obj list)->
        let s0 = unbox<(string*ParsedRgx<string>)list> ss.[0]
        let s1 = unbox<string*ParsedRgx<string>> ss.[1]
        let result:(string*ParsedRgx<string>)list =
            s1::s0
        box result
    ["elem";"ID"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let result:ParsedRgx<string> =
            ParsedRgxId s0
        box result
    ["elem";"QUOTE"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let result:ParsedRgx<string> =
            ParsedRgxSingle s0
        box result
    ["elem";"QUOTE";"-";"QUOTE"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s2 = unbox<string> ss.[2]
        let result:ParsedRgx<string> =
            ParsedRgxRange(s0,s2)
        box result
    ["elems";"elem"], fun(ss:obj list)->
        let s0 = unbox<ParsedRgx<string>> ss.[0]
        let result:ParsedRgx<string> list =
            [s0]
        box result
    ["elems";"elems";"elem"], fun(ss:obj list)->
        let s0 = unbox<ParsedRgx<string> list> ss.[0]
        let s1 = unbox<ParsedRgx<string>> ss.[1]
        let result:ParsedRgx<string> list =
            s1::s0
        box result
    ["expr";"(";"expr";")"], fun(ss:obj list)->
        let s1 = unbox<ParsedRgx<string>> ss.[1]
        let result:ParsedRgx<string> =
            s1
        box result
    ["expr";"ID"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let result:ParsedRgx<string> =
            ParsedRgxId s0
        box result
    ["expr";"QUOTE"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let result:ParsedRgx<string> =
            ParsedRgxSingle s0
        box result
    ["expr";"UNDERSCORE"], fun(ss:obj list)->
        let result:ParsedRgx<string> =
            ParsedRgxAny
        box result
    ["expr";"[";"elems";"]"], fun(ss:obj list)->
        let s1 = unbox<ParsedRgx<string> list> ss.[1]
        let result:ParsedRgx<string> =
            ParsedRgxClass s1
        box result
    ["expr";"[^";"elems";"]"], fun(ss:obj list)->
        let s1 = unbox<ParsedRgx<string> list> ss.[1]
        let result:ParsedRgx<string> =
            ParsedRgxNegClass s1
        box result
    ["expr";"expr";"&";"expr"], fun(ss:obj list)->
        let s0 = unbox<ParsedRgx<string>> ss.[0]
        let s2 = unbox<ParsedRgx<string>> ss.[2]
        let result:ParsedRgx<string> =
            ParsedRgxCat(s0,s2)
        box result
    ["expr";"expr";"*"], fun(ss:obj list)->
        let s0 = unbox<ParsedRgx<string>> ss.[0]
        let result:ParsedRgx<string> =
            ParsedRgxStar s0
        box result
    ["expr";"expr";"+"], fun(ss:obj list)->
        let s0 = unbox<ParsedRgx<string>> ss.[0]
        let result:ParsedRgx<string> =
            ParsedRgxPlus s0
        box result
    ["expr";"expr";"?"], fun(ss:obj list)->
        let s0 = unbox<ParsedRgx<string>> ss.[0]
        let result:ParsedRgx<string> =
            ParsedRgxOpt s0
        box result
    ["expr";"expr";"|";"expr"], fun(ss:obj list)->
        let s0 = unbox<ParsedRgx<string>> ss.[0]
        let s2 = unbox<ParsedRgx<string>> ss.[2]
        let result:ParsedRgx<string> =
            ParsedRgxAlt(s0,s2)
        box result
    ["file";"BRACES";"definitions";"ruler"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s1 = unbox<(string*ParsedRgx<string>)list> ss.[1]
        let s2 = unbox<Ruler<string>> ss.[2]
        let result:FslexFile<string> =
            FslexFile.just(s0, List.rev s1, s2)
        box result
    ["parameters"], fun(ss:obj list)->
        let result:string list =
            []
        box result
    ["parameters";"parameters";"ID"], fun(ss:obj list)->
        let s0 = unbox<string list> ss.[0]
        let s1 = unbox<string> ss.[1]
        let result:string list =
            s1::s0
        box result
    ["rule";"expr";"/";"expr";"BRACES"], fun(ss:obj list)->
        let s0 = unbox<ParsedRgx<string>> ss.[0]
        let s2 = unbox<ParsedRgx<string>> ss.[2]
        let s3 = unbox<string> ss.[3]
        let result:LexicalRule<string> =
            LexicalRule.just(s0,Some s2,s3)
        box result
    ["rule";"expr";"BRACES"], fun(ss:obj list)->
        let s0 = unbox<ParsedRgx<string>> ss.[0]
        let s1 = unbox<string> ss.[1]
        let result:LexicalRule<string> =
            LexicalRule.just(s0,None,s1)
        box result
    ["ruler";"RULE";"parameters";":";"FUN_TYPE";"=";"rules"], fun(ss:obj list)->
        let s1 = unbox<string list> ss.[1]
        let s3 = unbox<string> ss.[3]
        let s5 = unbox<LexicalRule<string> list> ss.[5]
        let result:Ruler<string> =
            Ruler.just(List.rev s1, s3, List.rev s5)
        box result
    ["ruler";"RULE";"parameters";"=";"rules"], fun(ss:obj list)->
        let s1 = unbox<string list> ss.[1]
        let s3 = unbox<LexicalRule<string> list> ss.[3]
        let result:Ruler<string> =
            Ruler.just(List.rev s1, "_", List.rev s3)
        box result
    ["rules";"rule"], fun(ss:obj list)->
        let s0 = unbox<LexicalRule<string>> ss.[0]
        let result:LexicalRule<string> list =
            [s0]
        box result
    ["rules";"rules";"rule"], fun(ss:obj list)->
        let s0 = unbox<LexicalRule<string> list> ss.[0]
        let s1 = unbox<LexicalRule<string>> ss.[1]
        let result:LexicalRule<string> list =
            s1::s0
        box result
]
let unboxRoot =
    unbox<FslexFile<string>>
let parser = ParseTable.from(rules, actions)