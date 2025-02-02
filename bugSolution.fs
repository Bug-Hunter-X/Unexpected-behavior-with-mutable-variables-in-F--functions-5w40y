let mutable x = 10

let addOne x = x + 1

let y = addOne x

printfn "%d" y //This will print 11

//Solution: Return the new value
let addOneAndReturnNewValue x = x + 1

let z = addOneAndReturnNewValue x

printfn "%d" z //This will print 11

x <- z //Update x with new value

printfn "%d" x //this will print 11

//Alternative: Using ref

let mutable xRef = ref 10

let addOneRef (xRef:int ref) = xRef := !xRef + 1

addOneRef xRef

printfn "%d" !xRef //This will print 11

//Another alternative by passing the variable as ref
let addOneRef2 (xRef:int ref) = xRef := !xRef + 1

let xRef2 = ref 10

addOneRef2 xRef2

printfn "%d" !xRef2 //this will print 11