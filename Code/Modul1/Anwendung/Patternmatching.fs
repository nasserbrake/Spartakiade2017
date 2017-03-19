module Patternmatching

let matchInt x = 
    match x with
    | 0 -> "Null"
    | 1 -> "Eins"
    | _ -> "Sonst"

let matchIntAndOr x = 
    match x with
    | 0 | 1 | 2 -> "0 oder 1 oder 2"
    | x when x > 2 && x < 100 -> "Between 2 and 100"  // when ist ein Guard
    | _ -> "sonst"

let pmList l = 
    match l with
    | [] -> "Leer"
    | h::t -> "  "