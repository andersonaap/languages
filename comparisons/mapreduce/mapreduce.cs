using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var somaDosParesAoQuadrado =
            Enumerable.Range(1, 100)
                .Where(x => x % 2 == 0)
                .Select(x => x * x)
                .Aggregate((acc, x) => acc + x);

        Console.WriteLine(somaDosParesAoQuadrado);
    }
}
