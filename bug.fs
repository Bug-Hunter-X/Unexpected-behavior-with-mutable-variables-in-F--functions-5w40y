let mutable x = 10

let addOne x = x + 1

let y = addOne x

printfn "%d" y //This will print 11

x <- 20 //this will change value of x but it won't change y

printfn "%d" y //This will still print 11