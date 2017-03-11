module Option

open DU

let s = Some "string"
let i = Some 1
let f = Some 1.0

let c = Some (Circle(1.0)) // kann nullable nicht!

let matchForOption s = 
    match s with 
    | "Sure" -> Some(s)
    | _ -> None

let some  = matchForOption "Sure"
let none = matchForOption "Not"
