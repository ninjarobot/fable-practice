let s = "Hello World!"

let chars = s |> Seq.map(fun c -> int(c) + 13 |> char) |> Array.ofSeq |> System.String
printfn "Rot13 : %s %s" s chars
