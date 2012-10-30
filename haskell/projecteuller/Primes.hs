module Primes where

--http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes

eratosthenes n = 
    eratosthenes' 2 [x | x <- [2..n]]
    where
        eratosthenes' i ns
            | i ^ 2 > n = ns
            | otherwise = eratosthenes' nexti nextns
            where
                nexti     = head . filter (\a -> a > i) $ ns
                nextns    = filter (\a -> a `mod` i /= 0 || a == i) ns

-- main = print $ length . eratosthenes $ 110000
-- 10453
-- [Finished in 1.4s]

