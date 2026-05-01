module FSharp.Substance.Sample

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
