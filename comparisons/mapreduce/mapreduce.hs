
somaDosParesAoQuadrado = 
    foldr (\acc x -> acc + x) 0
    $ map (\x -> x ^ 2)
    $ filter (\x -> x `mod` 2 == 0)
    $ [1..100] 

main = print somaDosParesAoQuadrado
