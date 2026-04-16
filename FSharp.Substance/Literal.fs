namespace FSharp.Substance

open FSharp.LexYacc.Bootstrap

type Literal =
    | UNIT
    | NULL
    | TRUE
    | FALSE
    | INT8 of int8
    | INT16 of int16
    | INT32 of int32
    | INT64 of int64
    | UINT8 of uint8
    | UINT16 of uint16
    | UINT32 of uint32
    | UINT64 of uint64
    | FLOAT of float
    | SINGLE of single
    | CHAR of char
    | STRING of string

    static member private parseFloat(buff: char list) =
        let str = System.String(List.toArray buff)
        match
            System.Double.TryParse(
                str,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture
            )
        with
        | (true, v) -> v
        | _ -> failwithf "Invalid float literal: %s" str

    // 解析整数（无后缀，默认int32）
    static member int32(buff: char list) =
        let str = System.String(List.toArray buff)
        INT32(int32 str)

    // 解析带后缀的整数
    static member int8(buff: char list) =
        // 移除后缀 'y'
        let numericPart = buff |> List.take(buff.Length - 1)
        let str = System.String(List.toArray numericPart)

        // 检测进制
        match str with
        | s when s.StartsWith("0x") || s.StartsWith("0X") ->
            let hexStr = s.Substring(2)
            INT8(System.Convert.ToSByte(hexStr, 16))
        | s when s.StartsWith("0o") || s.StartsWith("0O") ->
            let octStr = s.Substring(2)
            INT8(System.Convert.ToSByte(octStr, 8))
        | s when s.StartsWith("0b") || s.StartsWith("0B") ->
            let binStr = s.Substring(2)
            INT8(System.Convert.ToSByte(binStr, 2))
        | _ -> INT8(sbyte str)

    static member int16(buff: char list) =
        let numericPart = buff |> List.take(buff.Length - 1)
        let str = System.String(List.toArray numericPart)

        match str with
        | s when s.StartsWith("0x") || s.StartsWith("0X") ->
            let hexStr = s.Substring(2)
            INT16(System.Convert.ToInt16(hexStr, 16))
        | s when s.StartsWith("0o") || s.StartsWith("0O") ->
            let octStr = s.Substring(2)
            INT16(System.Convert.ToInt16(octStr, 8))
        | s when s.StartsWith("0b") || s.StartsWith("0B") ->
            let binStr = s.Substring(2)
            INT16(System.Convert.ToInt16(binStr, 2))
        | _ -> INT16(int16 str)

    static member int64(buff: char list) =
        let numericPart = buff |> List.take(buff.Length - 1)
        let str = System.String(List.toArray numericPart)

        match str with
        | s when s.StartsWith("0x") || s.StartsWith("0X") ->
            let hexStr = s.Substring(2)
            INT64(System.Convert.ToInt64(hexStr, 16))
        | s when s.StartsWith("0o") || s.StartsWith("0O") ->
            let octStr = s.Substring(2)
            INT64(System.Convert.ToInt64(octStr, 8))
        | s when s.StartsWith("0b") || s.StartsWith("0B") ->
            let binStr = s.Substring(2)
            INT64(System.Convert.ToInt64(binStr, 2))
        | _ -> INT64(int64 str)

    // 无符号整数
    static member uint8(buff: char list) =
        // 移除后缀 'uy'
        let numericPart = buff |> List.take(buff.Length - 2)
        let str = System.String(List.toArray numericPart)

        match str with
        | s when s.StartsWith("0x") || s.StartsWith("0X") ->
            let hexStr = s.Substring(2)
            UINT8(System.Convert.ToByte(hexStr, 16))
        | s when s.StartsWith("0o") || s.StartsWith("0O") ->
            let octStr = s.Substring(2)
            UINT8(System.Convert.ToByte(octStr, 8))
        | s when s.StartsWith("0b") || s.StartsWith("0B") ->
            let binStr = s.Substring(2)
            UINT8(System.Convert.ToByte(binStr, 2))
        | _ -> UINT8(byte str)

    static member uint16(buff: char list) =
        let numericPart = buff |> List.take(buff.Length - 2)
        let str = System.String(List.toArray numericPart)

        match str with
        | s when s.StartsWith("0x") || s.StartsWith("0X") ->
            let hexStr = s.Substring(2)
            UINT16(System.Convert.ToUInt16(hexStr, 16))
        | s when s.StartsWith("0o") || s.StartsWith("0O") ->
            let octStr = s.Substring(2)
            UINT16(System.Convert.ToUInt16(octStr, 8))
        | s when s.StartsWith("0b") || s.StartsWith("0B") ->
            let binStr = s.Substring(2)
            UINT16(System.Convert.ToUInt16(binStr, 2))
        | _ -> UINT16(uint16 str)

    static member uint32(buff: char list) =
        // 处理 'u' 或 'ul' 后缀
        let len = buff.Length
        let numericPart =
            if
                len >= 2
                && buff.[len - 2] = 'u'
                && buff.[len - 1] = 'l'
            then
                buff |> List.take(len - 2)
            elif len >= 1 && buff.[len - 1] = 'u' then
                buff |> List.take(len - 1)
            else
                buff

        let str = System.String(List.toArray numericPart)

        match str with
        | s when s.StartsWith("0x") || s.StartsWith("0X") ->
            let hexStr = s.Substring(2)
            UINT32(System.Convert.ToUInt32(hexStr, 16))
        | s when s.StartsWith("0o") || s.StartsWith("0O") ->
            let octStr = s.Substring(2)
            UINT32(System.Convert.ToUInt32(octStr, 8))
        | s when s.StartsWith("0b") || s.StartsWith("0B") ->
            let binStr = s.Substring(2)
            UINT32(System.Convert.ToUInt32(binStr, 2))
        | _ -> UINT32(uint32 str)

    static member uint64(buff: char list) =
        // 处理 'uL'/'UL'/'ul' 等后缀
        let len = buff.Length
        let numericPart =
            if
                len >= 2
                && (buff.[len - 2] = 'u' || buff.[len - 2] = 'U')
                && (buff.[len - 1] = 'l' || buff.[len - 1] = 'L')
            then
                buff |> List.take(len - 2)
            else
                buff

        let str = System.String(List.toArray numericPart)

        match str with
        | s when s.StartsWith("0x") || s.StartsWith("0X") ->
            let hexStr = s.Substring(2)
            UINT64(System.Convert.ToUInt64(hexStr, 16))
        | s when s.StartsWith("0o") || s.StartsWith("0O") ->
            let octStr = s.Substring(2)
            UINT64(System.Convert.ToUInt64(octStr, 8))
        | s when s.StartsWith("0b") || s.StartsWith("0B") ->
            let binStr = s.Substring(2)
            UINT64(System.Convert.ToUInt64(binStr, 2))
        | _ -> UINT64(uint64 str)

    static member float(buff: char list) =
        let str = System.String(List.toArray buff)
        FLOAT(Literal.parseFloat buff)

    static member single(buff: char list) = SINGLE 0f

    static member char(buff: char list) =
        
        let buff =
            buff
            |> List.tail
            |> List.take(buff.Length - 2)

        if buff.Length = 1 then
            CHAR buff.[0]
        else
            buff
            |> EscapeLexerTailer.unquote
            |> Seq.head
            |> CHAR

    static member string(buff: char list) = STRING(EscapeLexerTailer.unquote buff)
