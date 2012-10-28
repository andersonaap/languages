{-
http://projecteuler.net/problem=4

A palindromic number reads the same both ways. 
The largest palindrome made from the product of two 2-digit numbers is 9009 = 91  99.
Find the largest palindrome made from the product of two 3-digit numbers.
-}

isP x = show x == (reverse . show) x

lp' 1 1 = 1
lp' a 1
    | isP a       = max (lp' (a - 1) (a - 1)) a
    | otherwise   = lp' (a - 1) (a - 1)
lp' a b 
    | isP (a * b) = max (lp' (a - 1) (a - 1)) (a * b)
    | otherwise   = lp' a (b - 1)

lp x = lp' x x

main = print $ lp 999

-- 906609
-- [Finished in 1.4s]
