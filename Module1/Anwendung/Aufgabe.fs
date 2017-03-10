module Aufgabe

open Function

// Aufgabe:
// - Die Zahlen von 0 -> 9
// - Inkrementiere jede Zahl um 1
// - Filtere die ungeraden Zahlen heraus
// - Ermittle die Summe der Zahlen

// für die Ermittlung des inkrementierten Wertes und ob ein Werte gerade ist oder nicht, 
// bitte die vorhandenen Funktionen verwenden

let werte = [0..9]

let summeOhneVerkettung = 
    List.sum(List.filter isEven (List.map add1 werte))

let summe = 
    werte
    |> List.map add1
    |> List.map add1
    |> List.map add1
    |> List.filter isEven
    |> List.sum