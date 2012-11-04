
somaDosParesAoQuadrado =            \
    reduce(lambda acc, x: acc + x,  \
    map(lambda x: x ** 2,           \
    filter(lambda x: x % 2 == 0,    \
    range(1, 101))))

print somaDosParesAoQuadrado