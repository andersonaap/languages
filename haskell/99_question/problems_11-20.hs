--
-- http://www.haskell.org/haskellwiki/99_questions/11_to_20
--



-- Problem 14
-- Duplicate the elements of a list.
dupli []     = []
dupli (x:xs) = x:x:dupli xs

-- Problem 15
-- Replicate the elements of a list a given number of times.
repli []     n = []
repli (x:xs) n = replicate n x ++ repli xs n

-- Problem 16
-- Drop every N'th element from a list.
dropEvery xs n | length xs > n = take (n - 1) xs ++ dropEvery (drop n xs) n
               | otherwise     = take (n - 1) xs

-- Problem 17
-- Split a list into two parts; the length of the first part is given.
-- Do not use any predefined predicates.
split xs n = f (xs, "")
    where f (a1, a2) | length a1 > n = f (init a1, last a1:a2)
                     | otherwise     = (a1, a2)


main = do
    print $ dupli [1, 2, 3]
    print $ repli "abc" 3
    print $ dropEvery "abcdefghik" 3
    print $ split "abcdefghik" 3



