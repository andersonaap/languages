using System;

class Program
{
    static void Main(string[] args)
    {
        var universo = Universo.Vazio;

        while (true)
	    {
            Console.Clear();
            Console.WriteLine(universo.ToString());
            Console.WriteLine();
            Console.WriteLine("(1) Randomico");
            Console.WriteLine("(2) Blinker");
            Console.WriteLine("(3) Toad");
            Console.WriteLine("(4) Glider");
            Console.WriteLine("(5) Lightweight Spaceship");
            Console.WriteLine("Escolha a forma ou outra tecla para proxima geracao");
            Console.WriteLine("<ESC> para encerrar");

            var tecla = Console.ReadKey(true);

            if (tecla.Key == ConsoleKey.Escape)
                break;

            switch (tecla.KeyChar)
            {
                case '1': universo = Universo.Randomico; break;
                case '2': universo = Universo.Blinker; break;
                case '3': universo = Universo.Toad; break;
                case '4': universo = Universo.Glider; break;
                case '5': universo = Universo.LWSS; break;
                default: universo.ProximaGeracao(); break;
            } 
        }
    }
}
