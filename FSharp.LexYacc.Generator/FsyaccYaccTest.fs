namespace FSharp.LexYacc

open Xunit
open System.IO
open System.Text
open FSharp.LexYacc
open FSharp.LexYacc.Bootstrap

type FsyaccYaccTest(output: ITestOutputHelper) as this =
    let name = 
        let x = this.GetType().Name
        x.Substring(0, x.Length - 4)

    [<Fact>] // (Skip = "FsyaccFsyacc")
    member _.``生成FsyaccFsyacc文件``() =
        let srcPath =
            Path.Combine(__SOURCE_DIRECTORY__, "fsyacc.fsyacc")

        let text = File.ReadAllText(srcPath, Encoding.UTF8)
        let rawFsyacc = FsyaccCompiler.compile text
        let flatFsyacc = FlatFsyaccFile.from rawFsyacc

        let yaccFile = FsyaccFilePrinter.from flatFsyacc
        let src = yaccFile.printYaccModule(flatFsyacc.header)
        //output.WriteLine(src)

        let path =
            Path.Combine(Dir.bootstrap, name + ".fs")
        File.WriteAllText(path, src, Encoding.UTF8)
        output.WriteLine($"output:\r\n{path}")
        ()
