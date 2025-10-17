namespace FSharp.Jsons

open System

type JsonStringToken =
    | QUOTE
    | BACKSLASH
    | CONTENT of char

module JsonStringToken =
    // 将十六进制字符转换为数值
    let hex_char_to_int c =
        match c with
        | _ when '0' <= c && c <= '9' -> int c - int '0'
        | _ when 'a' <= c && c <= 'f' -> int c - int 'a' + 10
        | _ when 'A' <= c && c <= 'F' -> int c - int 'A' + 10
        | _ -> failwith "Invalid hex digit"

    // 计算码点的主函数
    let getValue d1 d2 d3 d4 =
        let v1 = hex_char_to_int d1 in
        let v2 = hex_char_to_int d2 in
        let v3 = hex_char_to_int d3 in
        let v4 = hex_char_to_int d4 in
        v1 * 4096 + v2 * 256 + v3 * 16 + v4

    let getChar buff =
        let rec loop ls =
            match ls with
            | [ _; _; a; b; c; d ] -> char(getValue a b c d)
            | _ -> failwith "格式不对"
        loop buff
