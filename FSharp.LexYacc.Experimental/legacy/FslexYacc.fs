module FSharp.LexYacc.Experimental.FslexYacc
open FSharp.LexYacc
open FSharp.LexYacc.Experimental
let tokens = set ["&";"(";")";"*";"+";"-";"/";"=";"?";"APOSTROPHE";"BRACES";"COLON_AND_FUNTYPE";"ID";"LET";"RULE";"UNDERSCORE";"[";"[^";"]";"|"]
let kernels = [[0,0];[0,1];[-1,1];[-1,2];[-1,3];[-1,4;-15,1;-16,1;-17,1;-18,1;-19,1];[-3,1;-20,2];[-3,2];[-4,1;-5,1];[-5,2];[-5,3];[-6,1];[-7,1];[-8,1;-13,2];[-8,1;-14,2];[-8,2];[-9,1];[-9,2;-15,1;-16,1;-17,1;-18,1;-19,1];[-9,3];[-10,1];[-11,1];[-12,1];[-13,1];[-13,3];[-14,1];[-14,3];[-15,1;-15,3;-16,1;-17,1;-18,1;-19,1];[-15,1;-16,1;-17,1;-18,1;-19,1;-19,3];[-15,1;-16,1;-17,1;-18,1;-19,1;-23,1;-24,1];[-15,1;-16,1;-17,1;-18,1;-19,1;-23,3];[-15,2];[-16,2];[-17,2];[-18,2];[-19,2];[-20,1];[-20,3];[-22,1;-25,2;-26,2];[-22,2];[-23,2];[-23,4];[-24,2];[-25,1;-26,1];[-25,3];[-25,4;-28,1];[-26,3];[-26,4];[-26,5;-28,1];[-27,1];[-28,2]]
let kernelSymbols = ["";"file";"LET";"ID";"=";"expr";"definitions";"definition";"APOSTROPHE";"-";"APOSTROPHE";"ID";"elem";"elems";"elems";"elem";"(";"expr";")";"APOSTROPHE";"ID";"UNDERSCORE";"[";"]";"[^";"]";"expr";"expr";"expr";"expr";"&";"*";"+";"?";"|";"BRACES";"ruler";"parameters";"ID";"/";"BRACES";"BRACES";"RULE";"=";"rules";"COLON_AND_FUNTYPE";"=";"rules";"rule";"rule"]
let actions = [["BRACES",35;"file",1];["",0];["ID",3];["=",4];["(",16;"APOSTROPHE",19;"ID",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",5];["&",30;"*",31;"+",32;"?",33;"LET",-1;"RULE",-1;"|",34];["LET",2;"RULE",42;"definition",7;"ruler",36];["LET",-3;"RULE",-3];["-",9;"APOSTROPHE",-4;"ID",-4;"]",-4];["APOSTROPHE",10];["APOSTROPHE",-5;"ID",-5;"]",-5];["APOSTROPHE",-6;"ID",-6;"]",-6];["APOSTROPHE",-7;"ID",-7;"]",-7];["APOSTROPHE",8;"ID",11;"]",23;"elem",15];["APOSTROPHE",8;"ID",11;"]",25;"elem",15];["APOSTROPHE",-8;"ID",-8;"]",-8];["(",16;"APOSTROPHE",19;"ID",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",17];["&",30;")",18;"*",31;"+",32;"?",33;"|",34];["&",-9;")",-9;"*",-9;"+",-9;"/",-9;"?",-9;"BRACES",-9;"LET",-9;"RULE",-9;"|",-9];["&",-10;")",-10;"*",-10;"+",-10;"/",-10;"?",-10;"BRACES",-10;"LET",-10;"RULE",-10;"|",-10];["&",-11;")",-11;"*",-11;"+",-11;"/",-11;"?",-11;"BRACES",-11;"LET",-11;"RULE",-11;"|",-11];["&",-12;")",-12;"*",-12;"+",-12;"/",-12;"?",-12;"BRACES",-12;"LET",-12;"RULE",-12;"|",-12];["APOSTROPHE",8;"ID",11;"elem",12;"elems",13];["&",-13;")",-13;"*",-13;"+",-13;"/",-13;"?",-13;"BRACES",-13;"LET",-13;"RULE",-13;"|",-13];["APOSTROPHE",8;"ID",11;"elem",12;"elems",14];["&",-14;")",-14;"*",-14;"+",-14;"/",-14;"?",-14;"BRACES",-14;"LET",-14;"RULE",-14;"|",-14];["&",-15;")",-15;"*",31;"+",32;"/",-15;"?",33;"BRACES",-15;"LET",-15;"RULE",-15;"|",-15];["&",30;")",-19;"*",31;"+",32;"/",-19;"?",33;"BRACES",-19;"LET",-19;"RULE",-19;"|",-19];["&",30;"*",31;"+",32;"/",39;"?",33;"BRACES",41;"|",34];["&",30;"*",31;"+",32;"?",33;"BRACES",40;"|",34];["(",16;"APOSTROPHE",19;"ID",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",26];["&",-16;")",-16;"*",-16;"+",-16;"/",-16;"?",-16;"BRACES",-16;"LET",-16;"RULE",-16;"|",-16];["&",-17;")",-17;"*",-17;"+",-17;"/",-17;"?",-17;"BRACES",-17;"LET",-17;"RULE",-17;"|",-17];["&",-18;")",-18;"*",-18;"+",-18;"/",-18;"?",-18;"BRACES",-18;"LET",-18;"RULE",-18;"|",-18];["(",16;"APOSTROPHE",19;"ID",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",27];["LET",-2;"RULE",-2;"definitions",6];["",-20];["=",43;"COLON_AND_FUNTYPE",45;"ID",38];["=",-22;"COLON_AND_FUNTYPE",-22;"ID",-22];["(",16;"APOSTROPHE",19;"ID",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",29];["",-23;"(",-23;"APOSTROPHE",-23;"ID",-23;"UNDERSCORE",-23;"[",-23;"[^",-23];["",-24;"(",-24;"APOSTROPHE",-24;"ID",-24;"UNDERSCORE",-24;"[",-24;"[^",-24];["=",-21;"COLON_AND_FUNTYPE",-21;"ID",-21;"parameters",37];["(",16;"APOSTROPHE",19;"ID",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",28;"rule",48;"rules",44];["",-25;"(",16;"APOSTROPHE",19;"ID",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",28;"rule",49];["=",46];["(",16;"APOSTROPHE",19;"ID",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",28;"rule",48;"rules",47];["",-26;"(",16;"APOSTROPHE",19;"ID",20;"UNDERSCORE",21;"[",22;"[^",24;"expr",28;"rule",49];["",-27;"(",-27;"APOSTROPHE",-27;"ID",-27;"UNDERSCORE",-27;"[",-27;"[^",-27];["",-28;"(",-28;"APOSTROPHE",-28;"ID",-28;"UNDERSCORE",-28;"[",-28;"[^",-28]]
let rules : list<string list*(obj list->obj)> = [
    ["";"file"], fun(ss:obj list)-> ss.[0]
    ["definition";"LET";"ID";"=";"expr"], fun(ss:obj list)->
        let s1 = unbox<string> ss.[1]
        let s3 = unbox<ParsedRgx<char>> ss.[3]
        let result:string*ParsedRgx<char> =
            s1,s3
        box result
    ["definitions"], fun(ss:obj list)->
        let result:(string*ParsedRgx<char>)list =
            []
        box result
    ["definitions";"definitions";"definition"], fun(ss:obj list)->
        let s0 = unbox<(string*ParsedRgx<char>)list> ss.[0]
        let s1 = unbox<string*ParsedRgx<char>> ss.[1]
        let result:(string*ParsedRgx<char>)list =
            s1::s0
        box result
    ["elem";"APOSTROPHE"], fun(ss:obj list)->
        let s0 = unbox<char> ss.[0]
        let result:ParsedRgx<char> =
            ParsedRgxSingle s0
        box result
    ["elem";"APOSTROPHE";"-";"APOSTROPHE"], fun(ss:obj list)->
        let s0 = unbox<char> ss.[0]
        let s2 = unbox<char> ss.[2]
        let result:ParsedRgx<char> =
            ParsedRgxRange(s0,s2)
        box result
    ["elem";"ID"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let result:ParsedRgx<char> =
            ParsedRgxId s0
        box result
    ["elems";"elem"], fun(ss:obj list)->
        let s0 = unbox<ParsedRgx<char>> ss.[0]
        let result:ParsedRgx<char> list =
            [s0]
        box result
    ["elems";"elems";"elem"], fun(ss:obj list)->
        let s0 = unbox<ParsedRgx<char> list> ss.[0]
        let s1 = unbox<ParsedRgx<char>> ss.[1]
        let result:ParsedRgx<char> list =
            s1::s0
        box result
    ["expr";"(";"expr";")"], fun(ss:obj list)->
        let s1 = unbox<ParsedRgx<char>> ss.[1]
        let result:ParsedRgx<char> =
            s1
        box result
    ["expr";"APOSTROPHE"], fun(ss:obj list)->
        let s0 = unbox<char> ss.[0]
        let result:ParsedRgx<char> =
            ParsedRgxSingle s0
        box result
    ["expr";"ID"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let result:ParsedRgx<char> =
            ParsedRgxId s0
        box result
    ["expr";"UNDERSCORE"], fun(ss:obj list)->
        let result:ParsedRgx<char> =
            ParsedRgxAny
        box result
    ["expr";"[";"elems";"]"], fun(ss:obj list)->
        let s1 = unbox<ParsedRgx<char> list> ss.[1]
        let result:ParsedRgx<char> =
            ParsedRgxClass s1
        box result
    ["expr";"[^";"elems";"]"], fun(ss:obj list)->
        let s1 = unbox<ParsedRgx<char> list> ss.[1]
        let result:ParsedRgx<char> =
            ParsedRgxNegClass s1
        box result
    ["expr";"expr";"&";"expr"], fun(ss:obj list)->
        let s0 = unbox<ParsedRgx<char>> ss.[0]
        let s2 = unbox<ParsedRgx<char>> ss.[2]
        let result:ParsedRgx<char> =
            ParsedRgxCat(s0,s2)
        box result
    ["expr";"expr";"*"], fun(ss:obj list)->
        let s0 = unbox<ParsedRgx<char>> ss.[0]
        let result:ParsedRgx<char> =
            ParsedRgxStar s0
        box result
    ["expr";"expr";"+"], fun(ss:obj list)->
        let s0 = unbox<ParsedRgx<char>> ss.[0]
        let result:ParsedRgx<char> =
            ParsedRgxPlus s0
        box result
    ["expr";"expr";"?"], fun(ss:obj list)->
        let s0 = unbox<ParsedRgx<char>> ss.[0]
        let result:ParsedRgx<char> =
            ParsedRgxOpt s0
        box result
    ["expr";"expr";"|";"expr"], fun(ss:obj list)->
        let s0 = unbox<ParsedRgx<char>> ss.[0]
        let s2 = unbox<ParsedRgx<char>> ss.[2]
        let result:ParsedRgx<char> =
            ParsedRgxAlt(s0,s2)
        box result
    ["file";"BRACES";"definitions";"ruler"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s1 = unbox<(string*ParsedRgx<char>)list> ss.[1]
        let s2 = unbox<Ruler<char>> ss.[2]
        let result:FslexFile<char> =
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
        let s0 = unbox<ParsedRgx<char>> ss.[0]
        let s2 = unbox<ParsedRgx<char>> ss.[2]
        let s3 = unbox<string> ss.[3]
        let result:LexicalRule<char> =
            LexicalRule.just(s0,Some s2,s3)
        box result
    ["rule";"expr";"BRACES"], fun(ss:obj list)->
        let s0 = unbox<ParsedRgx<char>> ss.[0]
        let s1 = unbox<string> ss.[1]
        let result:LexicalRule<char> =
            LexicalRule.just(s0,None,s1)
        box result
    ["ruler";"RULE";"parameters";"=";"rules"], fun(ss:obj list)->
        let s1 = unbox<string list> ss.[1]
        let s3 = unbox<LexicalRule<char> list> ss.[3]
        let result:Ruler<char> =
            Ruler.just(List.rev s1, "", List.rev s3)
        box result
    ["ruler";"RULE";"parameters";"COLON_AND_FUNTYPE";"=";"rules"], fun(ss:obj list)->
        let s1 = unbox<string list> ss.[1]
        let s2 = unbox<string> ss.[2]
        let s4 = unbox<LexicalRule<char> list> ss.[4]
        let result:Ruler<char> =
            Ruler.just(List.rev s1,s2,List.rev s4)
        box result
    ["rules";"rule"], fun(ss:obj list)->
        let s0 = unbox<LexicalRule<char>> ss.[0]
        let result:LexicalRule<char> list =
            [s0]
        box result
    ["rules";"rules";"rule"], fun(ss:obj list)->
        let s0 = unbox<LexicalRule<char> list> ss.[0]
        let s1 = unbox<LexicalRule<char>> ss.[1]
        let result:LexicalRule<char> list =
            s1::s0
        box result
]
let unboxRoot =
    unbox<FslexFile<char>>
let app: FSharp.LexYacc.ParseTableApp = {
    tokens        = tokens
    kernels       = kernels
    kernelSymbols = kernelSymbols
    actions       = actions
    rules         = rules
}