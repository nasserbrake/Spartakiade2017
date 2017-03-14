module Option

open DU

let s = Some "string"
let i = Some 1
let f = Some 1.0

let c = Some (Circle(1.0)) // kann nullable nicht!

let matchForOption s = 
    match s with 
    | Some t -> t // t beinhaltet den im option vorhandenen Wert, es ist eine Art der Zerlegung
    | _ -> "Keine Option"

// 
let some  = matchForOption (Some "Sure")
let none = matchForOption None

// Macht man normalerweise nie!
let noneString = Option<string>.None
// let length = noneString.Length // None hat keinen Length, es ist nämlich kein String!

let parseInt numberAsText = 
    let parsed = System.Int32.TryParse numberAsText                        // Parse value
    match parsed with
    | true,x -> Some x
    | _ -> None

let ``add ten using module functions`` numberAsText =
    // Parse Wert
    let parsed = parseInt numberAsText                          
    // Wenn gerade dann gebe den option weiter sonst none
    let even = Option.filter (fun x -> x % 2 = 0) parsed        
    // Wenn Wert existiert, dann addiere 10 und gib zurück als Option, sonst none
    // Beachte die Verwendung des Pipe (|>) Operators
    let added = Option.bind (fun x -> x + 10 |> Some ) even     
    added  
