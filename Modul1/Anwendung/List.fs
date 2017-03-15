module List

let leer = []

let list0 = 3::2::1::leer

let list1 = [6;5;4]

let list2 = list1 @ list0

// let list3 = list0 :: list1

let f l = 
    match l with
    | [] -> "Leere Liste"
    | h::t -> 
        sprintf "Erster Element ist %A und Liste hat noch %i Elemente" h (List.length t)


