let x = 1
let y = 2
let z = fun () -> x + y
printf "%d" (z())
x <- 3
printf "%d" (z()) // z will print 4 because it is a function that recalculates on every call