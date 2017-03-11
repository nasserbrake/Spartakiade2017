// So schreibe ich ein Kommentar

(* 
So schreibe ich ein mehrzeiliges Kommentar
*)

// Einfachste mögliche Deklaration
let a = 1

// Deklaration mit Einrücken, und wieder ohne Return
let b = 
    1

let c = 
    // Körper der Funktion ist eingerückt mit Leerzeichen (kein Tab)
    let d = b + 3
    // Return ist nicht notwendig
    d

// F# ist eine .net Sprache, Ich habe Zugriff auf die Runtime Bibliotheken 
System.Console.WriteLine(sprintf "Wert ist %i" c)