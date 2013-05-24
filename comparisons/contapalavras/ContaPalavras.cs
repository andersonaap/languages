using System;

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
        var quantidadePalavras = 0;
        var caracterAnterior = ' ';
        foreach (var caracterAtual in frase)
        {
            if (!char.IsLetter(caracterAnterior) && char.IsLetter(caracterAtual))
                quantidadePalavras++;

            caracterAnterior = caracterAtual;
        }
        return quantidadePalavras;
    }
}
