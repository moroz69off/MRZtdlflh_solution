﻿module TDLib.CodeGen.Utils

open System
open System.IO
open System.Reflection
open Xunit

type Case =
    | LowerCase
    | UpperCase

let toCamelCase (str: string) case =
    let chars = str.ToCharArray()
    let rec proc lst i f skip =
        if i = chars.Length then
            lst
        else
            if skip then
                proc lst (i + 1) Char.ToUpperInvariant false
            else
                let c = chars.[i]
                if c = '_' then
                    proc lst i (fun c -> c) true
                else
                    proc (lst @ [f(c)]) (i + 1) (fun c -> c) false
    let func = if case = UpperCase then Char.ToUpperInvariant else Char.ToLowerInvariant
    String(Array.ofList(proc [] 0 func false))
    
let readResource res = seq {
    let assembly = Assembly.GetExecutingAssembly()
    use stream = assembly.GetManifestResourceStream("TDLib.CodeGen." + res)
    use reader = new StreamReader(stream)
    while not reader.EndOfStream do
        yield reader.ReadLine()
}

   
[<Fact>]
let ``toCamelCase converts string to upper camel case``() =
    let snake = "foo_bar"
    let camel = toCamelCase snake UpperCase
    Assert.Equal("FooBar", camel)
    
[<Fact>]
let ``toCamelCase converts string to lower camel case``() =
    let snake = "foo_bar"
    let camel = toCamelCase snake LowerCase
    Assert.Equal("fooBar", camel)

[<Fact>]
let ``toCamelCase converts first char to upper case``() =
    let str = "fooBar"
    let camel = toCamelCase str UpperCase
    Assert.Equal("FooBar", camel)
    
[<Fact>]
let ``readResource reads file from embedded resources``() =
    let lines = readResource "Object.tpl"
    let first = Seq.head lines
    Assert.Equal("using System;", first)
