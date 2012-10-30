{-
http://projecteuler.net/problem=7

By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, 
we can see that the 6th prime is 13.
What is the 10 001st prime number?
-}

isPrime 1 = True
isPrime x = isPrime' (x - 1) x
    where 
        isPrime' i x 
            | i == 1         = True
            | x `mod` i == 0 = False
            | otherwise      = isPrime' (i - 1) x

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

-- [Not Finished]

