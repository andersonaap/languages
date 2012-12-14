
main = do
    
    print $ foldr (++) "a" ["c", "b"] 
    --                     <---------
    --              (c ++ (b ++ (a)))

    print $ foldl (++) "a" ["b", "c"]
    --                     --------->
    --              (((a) ++ b) ++ c)

    print $ foldr1 (++) ["a", "b", "c"]
    print $ foldl1 (++) ["a", "b", "c"]
