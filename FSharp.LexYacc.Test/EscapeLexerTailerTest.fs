namespace FSharp.LexYacc

open Xunit
open Xunit.Abstractions
open FSharp.xUnit
open FSharp.Idioms.Literal
open System.IO
open System.Text
open FSharp.LexYacc.Bootstrap

type EscapeLexerTailerTest(output: ITestOutputHelper) =

    [<Theory>]
    [<Natural(count = 36)>]
    member _.``unquote test``(i: int) =
        let rows = [ 
            // 基本字符
            "\".\"", "."
            "\"a\"", "a"
            "\"hello\"", "hello"
            
            // 反斜杠转义
            "\"\\\\\"", "\\"
            "\"\\\"\"", "\""
            
            // Unicode 转义
            "\"\\u0061\"", "a"  // Unicode 'a'
            "\"\\u0041\"", "A"  // Unicode 'A'
            "\"\\u0030\"", "0"  // Unicode '0'
            "\"\\u263A\"", "☺"  // Unicode 笑脸符号
            
            // 十六进制转义
            "\"\\x61\"", "a"    // 十六进制 'a'
            "\"\\x41\"", "A"    // 十六进制 'A'
            "\"\\x30\"", "0"    // 十六进制 '0'
            
            // 控制字符转义
            "\"\\a\"", "\a"     // 响铃
            "\"\\b\"", "\b"     // 退格
            "\"\\t\"", "\t"     // 水平制表符
            "\"\\n\"", "\n"     // 换行
            "\"\\v\"", "\v"     // 垂直制表符
            "\"\\f\"", "\f"     // 换页
            "\"\\r\"", "\r"     // 回车
            
            // 混合情况
            "\"Hello\\tWorld\\n\"", "Hello\tWorld\n"
            "\"Path: C:\\\\Users\\\\test\"", "Path: C:\\Users\\test"
            "\"Quote: \\\"text\\\"\"", "Quote: \"text\""
            "\"Unicode: \\u0048\\u0065\\u006C\\u006C\\u006F\"", "Unicode: Hello"
            "\"Mixed: \\x48\\x65\\x6C\\x6C\\x6F\"", "Mixed: Hello"
            "\"All escapes: \\a\\b\\t\\n\\v\\f\\r\"", "All escapes: \a\b\t\n\v\f\r"
            
            // 边界情况
            "\"\"", ""          // 空字符串
            "\"\\u0020\"", " "  // Unicode 空格
            "\"\\x20\"", " "    // 十六进制空格
            
            // 复杂组合
            "\"Line1\\nLine2\\r\\nLine3\"", "Line1\nLine2\r\nLine3"
            "\"Tab\\tSeparated\\tValues\"", "Tab\tSeparated\tValues"
            "\"Backslash: \\\\ Path: C:\\\\Windows\"", "Backslash: \\ Path: C:\\Windows"
            
            // 特殊字符序列
            "\"\\u00A9\"", "©"  // 版权符号
            "\"\\u20AC\"", "€"  // 欧元符号
            "\"\\u03A9\"", "Ω"  // 欧米茄符号
            
            // 大小写测试
            "\"\\u0061\\U0062\"", "a\\U0062"  // 注意：lexer 只支持小写 u，但测试小写情况
            "\"\\x41\\X42\"", "A\\X42"      // 注意：lexer 只支持小写 x，但测试小写情况
        ]

        output.WriteLine($"rows:{rows.Length}")
        let x, e = rows.[i]
        output.WriteLine(stringify x)
        let ls = x.ToCharArray() |> List.ofArray
        let y = EscapeLexerTailer.unquote ls
        Should.equal e y
