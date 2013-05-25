using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase.");
        var frase = Console.ReadLine();
        var quantidadePalavras = ContaPalavras(frase);
        Console.WriteLine("A frase tem {0} palavreas", quantidadePalavras);
    }

    private static int ContaPalavras(string frase)
    {
        return
            frase
                .Aggregate(
                    " "
                    , (acc, x) => char.IsLetter(acc.Last()) && char.IsLetter(x) ? acc : acc += x.ToString()
                    , acc => acc.Count(x => char.IsLetter(x))
                );
    }
}
