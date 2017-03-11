module Tuple

type IntTuple = int * int
let intTuple = 1,1

type IntStringTuple = int * string // every int 'times' every string
let intStringTuple  = 1,"string"

type TripleIntTuple = int * int * int
let tripleIntTuple = 1,2,3

type Complex = float * float
let complex  = 1.0,1.0

type Composition = IntStringTuple * Complex
let composition  = intStringTuple,complex

let cFirst,cSecond = complex
let kFirst,kSecond = composition

let complexZweite = 1.0,1.0
let complexDritte = 2.0,1.0

let matchTuple c = 
    match c with
    | 0.0,0.0 -> "0.0,0.0"
    | 1.0,1.0 -> "0.0,0.0"
    | 1.0,2.0 -> "1.0,1.0"
    | 1.0,_ -> "1.0,Irgendwas"
    | _,_ -> "sonst"

let c = matchTuple (1.0,1.0)

open System
let showParseResult result = 
    match result with
    | true,value -> sprintf "Geparster Wert ist %s" (value.ToString())
    | false,_ -> "Wert könnte nicht geparst werden" 

let tryParseResult = Int32.TryParse "Irgendwas" |> showParseResult
let tryParseResult' = Int32.TryParse "1" |> showParseResult
