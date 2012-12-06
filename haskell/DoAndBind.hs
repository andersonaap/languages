
f_do :: IO ()
f_do =
    do x <- return "hello"
       y <- return "world"
       print $ x ++ y
       return ()

f_bind :: IO ()
f_bind =
    return "hello" >>= \x ->
    return "world" >>= \y ->
    print (x ++ y) >>
    return ()

main :: IO ()
main = f_do >> f_bind
