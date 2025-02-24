let x = 10
let y = 20

let add x y = 
    let sum = x + y
    (x, y, sum)

let (x', y', result) = add x y
printf "%d %d %d" x' y' result