module DU


type Shape =
| Rectangle of width : float * length : float
| Circle of radius : float
| Square of side : float

let rectangle0 = Rectangle(1.0,1.0)
let circle0 = Circle(2.0)
let square0 = Square(3.0)

let rectangle1 = Rectangle(width = 1.3, length = 10.0) 

open Record
type DuExample =
| Empty
| Complex of ComplexNumber
| Coordinate of GeoCoord

let empty = Empty

// Erster Longitude ist der Name des Typ!
// Zweiter ist der name des Constructors
type Longitude = Longitude of float 
type Latitude = LatitudeConstructorFunction of float

let longitude = Longitude(9.993009567260742)
let latitude = LatitudeConstructorFunction(53.553260805869805)

// Der Compiler mag das nicht, es handelt sich um zwei Typen
// let gleich = longitude = latitude 

let area s = 
    match s with 
    | Rectangle (w,l) -> w*l
    | Circle(r) -> System.Math.PI*(r ** 2.0) 
    // Leaving out a union-case leads to a compilation error
    | Square(s) -> (s ** 2.0)
let circleArea   = area (Circle (5.0))
let rectangleArea = Rectangle(length = 5.0, width = 5.0) |> area