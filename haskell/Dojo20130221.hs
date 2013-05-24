--
-- fazer o ranqueamento das preferencias de preferencia de pizza
-- cada pessoa informa uma lista da pizzas de que gosta
-- retornar uma lista das pizzas na ordem de maior preferencia
--
import Data.List


ranking :: [[String]] -> [String]
ranking = 
  map fst
  . reverse
  . sortBy (\x y -> if snd x < snd y then LT else GT)
  . map (\x -> (head x, length x))
  . group
  . sort 
  . concat 


main = 
  print $ (ranking dado) == esperado
  where 
    dado     = [["Mussarela", "Calabresa"], ["Calabresa"], ["Portuguesa", "Mussarela", "Calabresa"]]
    esperado = ["Calabresa", "Mussarela", "Portuguesa"]