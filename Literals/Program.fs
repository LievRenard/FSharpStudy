// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

let a = 1
let b = 2.0
let c = 10f

printfn "%A" a
printfn $"{b}"
printfn "%A" c

let type1 = c.GetType()
printfn "%A" type1

let numbers = (0x9F, 0o77, 0b1010)
printfn "%A" numbers
numbers.GetType() |> printfn "%A"