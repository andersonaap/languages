{-
http://projecteuler.net/problem=5

2520 is the smallest number that can be divided by each of the numbers 
from 1 to 10 without any remainder.
What is the smallest positive number that is evenly 
divisible by all of the numbers from 1 to 20?
-}
import Data.List

minmult' x ns
    | all (multof x) ns = x
    | otherwise         = minmult' (x + maximum ns) ns
    where
        multof n x = n `mod` x == 0

minmult ns = minmult' (maximum ns) ns


main = print $ minmult [1..20]

--232792560
--[Finished in 97.7s]
