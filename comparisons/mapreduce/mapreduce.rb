
somaDosParesAoQuadrado = 
    (1..100)
    .find_all {|x|      x % 2 == 0}
    .map      {|x|      x ** 2}
    .inject   {|acc, x| acc + x}

puts somaDosParesAoQuadrado
 