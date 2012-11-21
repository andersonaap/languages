--
--http://www.haskell.org/haskellwiki/99_questions/1_to_10
--


-- Problem 1
-- Find the last element of a list. 
myLast = last

-- Problem 2 
-- Find the last but one element of a list. 
myButLast = last . init

-- Problem 3 
-- Find the K'th element of a list. The first element in the list is number 1. 
elementAt xs x = xs !! (x - 1)

-- Problem 4 
-- Find the number of elements of a list. 
myLength = length

-- Problem 5 
-- Reverse a list.
reverse' = reverse

-- Problem 6 
-- Find out whether a list is a palindrome. A palindrome can be read forward or backward; e.g. (x a m a x). 
isPalindrome xs = xs == reverse xs  

-- Problem 7 
-- Flatten a nested list structure. 
-- Transform a list, possibly holding lists as elements into a `flat' list by replacing each list with its elements (recursively). 
data NestedList a = Elem a | List [NestedList a]
flatten :: NestedList a -> [a]
flatten (Elem a)      = [a]
flatten (List [])     = []
flatten (List (x:xs)) = flatten x ++ flatten (List xs)


-- Problem 8 
-- Eliminate consecutive duplicates of list elements. 
-- If a list contains repeated elements they should be replaced with a single copy of the element. 
-- The order of the elements should not be changed. 
compress = foldr f []
    where f x []  = [x]
          f x xs  | head xs == x  = xs
                  | otherwise     = [x] ++ xs  

-- Problem 9 
-- Pack consecutive duplicates of list elements into sublists. 
-- If a list contains repeated elements they should be placed in separate sublists. 
pack = foldl f []
    where f []  x = [[x]]
          f xss x | head (last xss) == x = init xss ++ [last xss ++ [x]]
                  | otherwise            = xss ++ [[x]]

-- Problem 10 
-- Run-length encoding of a list. 
-- Use the result of problem P09 to implement the so-called run-length encoding data compression method. 
-- Consecutive duplicates of elements are encoded as lists (N E) where N is the number of duplicates of the element E. 

encode xs = map f (pack xs)
    where f x = (head x, length x)


main = do
    putStrLn . show $ myLast [1,2,3,4]
    putStrLn . show $ myLast ['x','y','z']

    putStrLn . show $ myButLast [1,2,3,4]
    putStrLn . show $ myButLast ['a'..'z']  

    putStrLn . show $ elementAt [1,2,3] 2
    putStrLn . show $ elementAt "haskell" 5

    putStrLn . show $ myLength [123, 456, 789]
    putStrLn . show $ myLength "Hello, world!"

    putStrLn . show $ reverse' "A man, a plan, a canal, panama!"
    putStrLn . show $ reverse' [1,2,3,4]

    putStrLn . show $ isPalindrome [1,2,3]
    putStrLn . show $ isPalindrome "madamimadam"
    putStrLn . show $ isPalindrome [1,2,4,8,16,8,4,2,1]

    putStrLn . show $ flatten (Elem 5)
    putStrLn . show $ flatten (List [Elem 1, List [Elem 2, List [Elem 3, Elem 4], Elem 5]])
    putStrLn $ (flatten (List [])) -- TODO: verify what happend here

    putStrLn . show $ compress ["a","a","a","a","b","c","c","a","a","d","e","e","e","e"]
    putStrLn . show $ pack ['a', 'a', 'a', 'a', 'b', 'c', 'c', 'a', 'a', 'd', 'e', 'e', 'e', 'e']
    putStrLn . show $ encode "aaaabccaadeeee"

