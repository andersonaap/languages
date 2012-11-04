
let somaDosParesAoQuadrado = 
    [1..100]
    |> Seq.filter (fun x     -> x % 2 = 0 )
    |> Seq.map    (fun x     -> x * x)
    |> Seq.reduce (fun acc x -> acc + x)

printfn "%A" somaDosParesAoQuadrado


