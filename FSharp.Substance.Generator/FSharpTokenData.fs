module FSharp.Substance.FSharpTokenData

open FSharp.LexYacc

open FSharp.Idioms.Literal
open FSharp.Reflection

//只需列出与 union case 名不同的符号名称
let symbols =
    [
        FSharpToken.BAR, "|"
        FSharpToken.BAR_RBRACE, "|}"
        FSharpToken.BAR_RBRACK, "|]"
        FSharpToken.BAR_RPAREN, "|)"
        FSharpToken.COLON, ":"
        FSharpToken.COMMA, ","
        FSharpToken.DOT, "."
        FSharpToken.EQUALS, "="
        FSharpToken.EXCLAM, "!"
        FSharpToken.GREATER, ">"
        FSharpToken.GREATER_GREATER, ">>"
        FSharpToken.LARROW, "<-"
        FSharpToken.LBRACE, "{"
        FSharpToken.LBRACE_BAR, "{|"
        FSharpToken.LBRACK, "["
        FSharpToken.LBRACK_BAR, "[|"
        FSharpToken.LESS, "<"
        FSharpToken.LESS_LESS, "<<"
        FSharpToken.LPAREN, "("
        FSharpToken.LPAREN_BAR, "(|"
        FSharpToken.MINUS, "-"
        FSharpToken.PLUS, "+"
        FSharpToken.RARROW, "->"
        FSharpToken.RBRACE, "}"
        FSharpToken.RBRACK, "]"
        FSharpToken.RPAREN, ")"
        FSharpToken.SEMICOLON, ";"
        FSharpToken.STAR, "*"
    ]

/// 根据符号得到其名称
let nameofsymbols =
    symbols
    |> List.map(fun (tok, symbol) -> symbol, Light.getTag tok)
    |> Map.ofList

//FSharpToken.AMP, "&"
//FSharpToken.AMP_AMP, "&&"
//FSharpToken.AMP_AMP_AMP, "&&&"
//FSharpToken.AT, "@"
//FSharpToken.BAR_BAR, "||"
//FSharpToken.BAR_BAR_BAR, "|||"
//FSharpToken.BAR_BAR_BAR_GREATER, "|||>"
//FSharpToken.BAR_BAR_GREATER, "||>"
//FSharpToken.CARET_CARET_CARET, "^^^"
//FSharpToken.COLON_COLON, "::"
//FSharpToken.COLON_QMARK, ":?"
//FSharpToken.COLON_QMARK_GREATER, ":?>"
//FSharpToken.DIV, "/"
//FSharpToken.DOT_DOT, ".."
//FSharpToken.DOT_DOT_DOT, "..."
//FSharpToken.GREATER_GREATER_GREATER, ">>>"
//FSharpToken.HASH, "#"
//FSharpToken.LESS_BAR_BAR, "<||"
//FSharpToken.LESS_BAR_BAR_BAR, "<|||"
//FSharpToken.LESS_GREATER, "<>"
//FSharpToken.LESS_LESS_LESS, "<<<"
//FSharpToken.LPIPE, "<|"
//FSharpToken.PERCENT, "%"
//FSharpToken.RPIPE, "|>"
//FSharpToken.STAR_STAR, "**"
//FSharpToken.TILDE_TILDE_TILDE, "~~~"
