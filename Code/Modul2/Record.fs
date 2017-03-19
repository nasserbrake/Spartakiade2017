module Record

type ComplexNumber = { Real: float; Imaginary: float; }
type GeoCoord = { Lat: float; Long: float; }

let complexNumber = { Real = 1.0; Imaginary = 1.0; }
let hamburg       = { Lat = 53.55326; Long = 9.99300; }

let complexNumber0 = { ComplexNumber.Real = 1.0; Imaginary = 1.0; }

let { Real = real0;  Imaginary = imaginary; } = complexNumber // Alle Member
let { Real = real1; } = complexNumber // Einzelne
let real2 = complexNumber.Real // Point Style ist auch möglich für einen Wert

let complexNumber1 = { complexNumber with Imaginary = 3.0 }

let matchRecord c = 
    match c with 
    | { Real = 1.0; Imaginary = 1.0; } -> "Real = 1.0 & Imaginary = 1.0"
    | { Real = 1.0 } -> "Real = 1.0"
    | { Imaginary = 2.0 } -> "Imaginary = 2.0"
    | _ -> "sonst"