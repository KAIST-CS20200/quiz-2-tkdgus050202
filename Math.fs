module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.

let f n =
  if n%2UL =1UL then
    3UL*n + 1UL
  else n/2UL

let collatz (n: int32) : int32  =
  let rec iter num (n: uint64) = 
    let result = f (uint64 n)
    if result = 1UL then int32 num
    else iter (num+1) (uint64 result)
  iter 1 (uint64 n)
   
