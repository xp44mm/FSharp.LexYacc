module FSharp.LexYacc.Hexadecimal

// 将十六进制字符转换为数值
let hex_char_to_int c =
    match c with
    | _ when '0' <= c && c <= '9' -> int c - int '0'
    | _ when 'a' <= c && c <= 'f' -> int c - int 'a' + 10
    | _ when 'A' <= c && c <= 'F' -> int c - int 'A' + 10
    | _ -> failwithf "Invalid hex digit: %c" c

// 计算任意位数十六进制字符的码点
let getValue (hexChars: char list) =
    hexChars
    |> List.fold (fun acc c -> acc * 16 + hex_char_to_int c) 0

let getChar n buff =
    buff
    |> List.take n
    |> getValue
    |> char

