{-
http://projecteuler.net/problem=3

The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143 ?
-}

isPrime 1 = True
isPrime x = isPrime' (x - 1) x
    where 
        isPrime' i x 
            | i == 1         = True
            | x `mod` i == 0 = False
            | otherwise      = isPrime' (i - 1) x

isFactor n x = n `mod` x == 0 


main = print 
    . maximum
    . filter isPrime
    . filter (isFactor 600851475143)
    $ [1..to]
    where 
        to = truncate . sqrt $ 600851475143

-- 6857
-- [Finished in 2.8s]
  
