module FSharp.LexYacc.FslexTagYaccNew
open FSharp.LexYacc
let tokens = set ["%%";"&";"(";")";"*";"+";"-";"/";"=";"?";"BRACES";"ID";"LET";"QUOTE";"UNDERSCORE";"[";"[^";"]";"|"]
let kernels = [[0,0];[0,1];[-1,1];[-1,2];[-1,3];[-1,4;-15,1;-16,1;-17,1;-18,1;-19,1];[-2,1];[-3,1;-20,2];[-3,2];[-4,1];[-5,1;-6,1];[-6,2];[-6,3];[-7,1];[-8,1;-13,2];[-8,1;-14,2];[-8,2];[-9,1];[-9,2;-15,1;-16,1;-17,1;-18,1;-19,1];[-9,3];[-10,1];[-11,1];[-12,1];[-13,1];[-13,3];[-14,1];[-14,3];[-15,1;-15,3;-16,1;-17,1;-18,1;-19,1];[-15,1;-16,1;-17,1;-18,1;-19,1;-19,3];[-15,1;-16,1;-17,1;-18,1;-19,1;-22,1;-23,1];[-15,1;-16,1;-17,1;-18,1;-19,1;-22,3];[-15,2];[-16,2];[-17,2];[-18,2];[-19,2];[-20,1;-21,1];[-20,3];[-20,4;-25,1];[-21,2;-25,1];[-22,2];[-22,4];[-23,2];[-24,1];[-25,2]]
let kernelSymbols = ["";"file";"LET";"ID";"=";"expr";"definition";"definitions";"definition";"ID";"QUOTE";"-";"QUOTE";"elem";"elems";"elems";"elem";"(";"expr";")";"ID";"QUOTE";"UNDERSCORE";"[";"]";"[^";"]";"expr";"expr";"expr";"expr";"&";"*";"+";"?";"|";"BRACES";"%%";"rules";"rules";"/";"BRACES";"BRACES";"rule";"rule"]
let actions = [["BRACES",36;"file",1];["",0];["ID",3];["=",4];["(",17;"ID",20;"QUOTE",21;"UNDERSCORE",22;"[",23;"[^",25;"expr",5];["%%",-1;"&",31;"*",32;"+",33;"?",34;"LET",-1;"|",35];["%%",-2;"LET",-2];["%%",37;"LET",2;"definition",8];["%%",-3;"LET",-3];["ID",-4;"QUOTE",-4;"]",-4];["-",11;"ID",-5;"QUOTE",-5;"]",-5];["QUOTE",12];["ID",-6;"QUOTE",-6;"]",-6];["ID",-7;"QUOTE",-7;"]",-7];["ID",9;"QUOTE",10;"]",24;"elem",16];["ID",9;"QUOTE",10;"]",26;"elem",16];["ID",-8;"QUOTE",-8;"]",-8];["(",17;"ID",20;"QUOTE",21;"UNDERSCORE",22;"[",23;"[^",25;"expr",18];["&",31;")",19;"*",32;"+",33;"?",34;"|",35];["%%",-9;"&",-9;")",-9;"*",-9;"+",-9;"/",-9;"?",-9;"BRACES",-9;"LET",-9;"|",-9];["%%",-10;"&",-10;")",-10;"*",-10;"+",-10;"/",-10;"?",-10;"BRACES",-10;"LET",-10;"|",-10];["%%",-11;"&",-11;")",-11;"*",-11;"+",-11;"/",-11;"?",-11;"BRACES",-11;"LET",-11;"|",-11];["%%",-12;"&",-12;")",-12;"*",-12;"+",-12;"/",-12;"?",-12;"BRACES",-12;"LET",-12;"|",-12];["ID",9;"QUOTE",10;"elem",13;"elems",14];["%%",-13;"&",-13;")",-13;"*",-13;"+",-13;"/",-13;"?",-13;"BRACES",-13;"LET",-13;"|",-13];["ID",9;"QUOTE",10;"elem",13;"elems",15];["%%",-14;"&",-14;")",-14;"*",-14;"+",-14;"/",-14;"?",-14;"BRACES",-14;"LET",-14;"|",-14];["%%",-15;"&",-15;")",-15;"*",32;"+",33;"/",-15;"?",34;"BRACES",-15;"LET",-15;"|",-15];["%%",-19;"&",31;")",-19;"*",32;"+",33;"/",-19;"?",34;"BRACES",-19;"LET",-19;"|",-19];["&",31;"*",32;"+",33;"/",40;"?",34;"BRACES",42;"|",35];["&",31;"*",32;"+",33;"?",34;"BRACES",41;"|",35];["(",17;"ID",20;"QUOTE",21;"UNDERSCORE",22;"[",23;"[^",25;"expr",27];["%%",-16;"&",-16;")",-16;"*",-16;"+",-16;"/",-16;"?",-16;"BRACES",-16;"LET",-16;"|",-16];["%%",-17;"&",-17;")",-17;"*",-17;"+",-17;"/",-17;"?",-17;"BRACES",-17;"LET",-17;"|",-17];["%%",-18;"&",-18;")",-18;"*",-18;"+",-18;"/",-18;"?",-18;"BRACES",-18;"LET",-18;"|",-18];["(",17;"ID",20;"QUOTE",21;"UNDERSCORE",22;"[",23;"[^",25;"expr",28];["(",17;"ID",20;"LET",2;"QUOTE",21;"UNDERSCORE",22;"[",23;"[^",25;"definition",6;"definitions",7;"expr",29;"rule",43;"rules",39];["(",17;"ID",20;"QUOTE",21;"UNDERSCORE",22;"[",23;"[^",25;"expr",29;"rule",43;"rules",38];["",-20;"(",17;"ID",20;"QUOTE",21;"UNDERSCORE",22;"[",23;"[^",25;"expr",29;"rule",44];["",-21;"(",17;"ID",20;"QUOTE",21;"UNDERSCORE",22;"[",23;"[^",25;"expr",29;"rule",44];["(",17;"ID",20;"QUOTE",21;"UNDERSCORE",22;"[",23;"[^",25;"expr",30];["",-22;"(",-22;"ID",-22;"QUOTE",-22;"UNDERSCORE",-22;"[",-22;"[^",-22];["",-23;"(",-23;"ID",-23;"QUOTE",-23;"UNDERSCORE",-23;"[",-23;"[^",-23];["",-24;"(",-24;"ID",-24;"QUOTE",-24;"UNDERSCORE",-24;"[",-24;"[^",-24];["",-25;"(",-25;"ID",-25;"QUOTE",-25;"UNDERSCORE",-25;"[",-25;"[^",-25]]
let rules : list<string list*(obj list->obj)> = [
    ["";"file"], fun(ss:obj list)-> ss.[0]
    ["definition";"LET";"ID";"=";"expr"], fun(ss:obj list)->
        let s1 = unbox<string> ss.[1]
        let s3 = unbox<ParsedRgx<string>> ss.[3]
        let result:string*ParsedRgx<string> =
            s1,s3
        box result
    ["definitions";"definition"], fun(ss:obj list)->
        let s0 = unbox<string*ParsedRgx<string>> ss.[0]
        let result:(string*ParsedRgx<string>)list =
            [s0]
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
    ["file";"BRACES";"definitions";"%%";"rules"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s1 = unbox<(string*ParsedRgx<string>)list> ss.[1]
        let s3 = unbox<LexicalRule<string> list> ss.[3]
        let result:FslexFile<string> =
            FslexFile.just(s0,List.rev s1,List.rev s3)
        box result
    ["file";"BRACES";"rules"], fun(ss:obj list)->
        let s0 = unbox<string> ss.[0]
        let s1 = unbox<LexicalRule<string> list> ss.[1]
        let result:FslexFile<string> =
            FslexFile.just(s0,[],List.rev s1)
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
let app: FSharp.LexYacc.ParseTableApp = {
    tokens        = tokens
    kernels       = kernels
    kernelSymbols = kernelSymbols
    actions       = actions
    rules         = rules
}