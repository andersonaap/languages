{-
http://projecteuler.net/problem=7

By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, 
we can see that the 6th prime is 13.
What is the 10 001st prime number?
-}
import Primes

main =
    print $ eratosthenes 110000 !! (10001 - 1)

--104743
--[Finished in 1.3s]
