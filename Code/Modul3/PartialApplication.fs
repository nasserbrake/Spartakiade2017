module PartialApplication

let add x y = x + y
let add5  = add 5

let mit3Params a b c =  a + b + c 
let mit2Params = mit3Params 1 2

let compose f g x = f (g x)  
let times n x = n * x
let multiply2 = times 2
let add1Multiply2 = add5 >> multiply2