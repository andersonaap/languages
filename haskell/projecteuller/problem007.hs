{-
http://projecteuler.net/problem=7

By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, 
we can see that the 6th prime is 13.
What is the 10 001st prime number?
-}
import Primes

primes = eratosthenes 110000

isPrime x = elem x $ primes

nextPrime x
    | isPrime next = next
    | otherwise    = nextPrime next
    where next = x + 1

nthPrime n = nthPrime' 1 2 n
    where
        nthPrime' i p n
            | i == n    = p
            | otherwise = nthPrime' (i + 1) (nextPrime p) n

main = do
    print $ nthPrime 10001

--104743
--[Finished in 18.1s]



-- [Not Finished]

