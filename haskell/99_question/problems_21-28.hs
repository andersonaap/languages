import Data.List

-- Problem 21
-- Insert an element at a given position into a list.
insertAt e xs     1 = e:xs
insertAt e (x:xs) n = x:insertAt e xs (n - 1)

-- Problem 22
-- Create a list containing all integers within a given range.
range b e | b <= e    = b:range (b + 1) e
          | otherwise = []

-- Problem 28
-- Sorting a list of lists according to length of sublists
-- a) We suppose that a list contains elements that are lists themselves. 
-- The objective is to sort the elements of this list according to their length. 
-- E.g. short lists first, longer lists later, or vice versa.
-- b) Again, we suppose that a list contains elements that are lists themselves. 
-- But this time the objective is to sort the elements of this list according to their length frequency; 
-- i.e., in the default, where sorting is done ascendingly, 
-- lists with rare lengths are placed first, others with a more frequent length come later.
lsort = sortBy f
    where f a b  | length a < length b = LT
                 | length a > length b = GT
                 | otherwise           = EQ

lfsort xs = sortBy f xs
    where cnt sz = foldl (\acc x -> if length x == sz then acc + 1 else acc) 0 xs
          f a b  | cnt (length a) < cnt (length b) = LT
                 | cnt (length a) > cnt (length b) = GT
                 | otherwise                       = EQ



main = do
    print $ insertAt 'X' "abcd" 2
    print $ range 4 9
    print $ lsort ["abc","de","fgh","de","ijkl","mn","o"]
    print $ lfsort ["abc", "de", "fgh", "de", "ijkl", "mn", "o"]