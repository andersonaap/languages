using System;
using System.Text;


class Universo
{
    public const int TamanhoX = 16;
    public const int TamanhoY = 18;

    private bool[,] _quadro;

    private Universo(bool[,] quadro)
    {
        _quadro = quadro;
    }

    public static Universo Vazio
    {
        get
        {
            var quadro = new bool[TamanhoX, TamanhoY];
            return new Universo(quadro);
        }
    }
    public static Universo Randomico
    {
        get
        {
            var random = new Random();

            var quadro = new bool[TamanhoX, TamanhoY];
            for (int x = 0; x < TamanhoX; x++)
            {
                for (int y = 0; y < TamanhoY; y++)
                {
                    if (random.Next(5) == 1)
                        quadro[x, y] = true;
                }
            }
            return new Universo(quadro);
        }
    }

    public static Universo Blinker
    {
        get
        {
            var quadro = new bool[TamanhoX, TamanhoY];
            quadro[3, 3] = true;
            quadro[3, 4] = true;
            quadro[3, 5] = true;
            return new Universo(quadro);
        }
    }
    public static Universo Toad
    {
        get
        {
            var quadro = new bool[TamanhoX, TamanhoY];
            quadro[3, 3] = true;
            quadro[3, 4] = true;
            quadro[3, 5] = true;
            quadro[4, 2] = true;
            quadro[4, 3] = true;
            quadro[4, 4] = true;
            return new Universo(quadro);
        }
    }
    public static Universo Glider
    {
        get
        {
            var quadro = new bool[TamanhoX, TamanhoY];
            quadro[3, 3] = true;
            quadro[4, 4] = true;
            quadro[4, 5] = true;
            quadro[5, 3] = true;
            quadro[5, 4] = true;
            return new Universo(quadro);
        }
    }
    public static Universo LWSS
    {
        get
        {
            var quadro = new bool[TamanhoX, TamanhoY];
            quadro[3, 3] = true;
            quadro[3, 6] = true;
            quadro[4, 7] = true;
            quadro[5, 3] = true;
            quadro[5, 7] = true;
            quadro[6, 4] = true;
            quadro[6, 5] = true;
            quadro[6, 6] = true;
            quadro[6, 7] = true;
            return new Universo(quadro);
        }
    }

    public void ProximaGeracao()
    {
        var proximoQuadro = new bool[TamanhoX, TamanhoY];
        for (int x = 0; x < TamanhoX; x++)
        {
            for (int y = 0; y < TamanhoY; y++)
            {
                var vizinhosVivos = QuantidadeVizinhosVivos(_quadro, x, y);

                if ((vizinhosVivos == 3)
                    || (_quadro[x, y] && vizinhosVivos == 2))
                    proximoQuadro[x, y] = true;
            }
        }
        _quadro = proximoQuadro;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        for (int x = 0; x < TamanhoX; x++)
        {
            for (int y = 0; y < TamanhoY; y++)
            {
                sb.Append(_quadro[x, y] ? '#' : '.');
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }

    private int QuantidadeVizinhosVivos(bool[,] quadro, int x, int y)
    {
        Func<int, int, int> normaliza = (indice, tamanho) =>
        {
            if (indice < 0) indice = tamanho - 1;
            if (indice == tamanho) indice = 0;
            return indice;
        };

        return
            (quadro[normaliza(x - 1, TamanhoX), normaliza(y - 1, TamanhoY)] ? 1 : 0) +
            (quadro[normaliza(x - 1, TamanhoX), normaliza(y - 0, TamanhoY)] ? 1 : 0) +
            (quadro[normaliza(x - 1, TamanhoX), normaliza(y + 1, TamanhoY)] ? 1 : 0) +
            (quadro[normaliza(x - 0, TamanhoX), normaliza(y - 1, TamanhoY)] ? 1 : 0) +
            (quadro[normaliza(x - 0, TamanhoX), normaliza(y + 1, TamanhoY)] ? 1 : 0) +
            (quadro[normaliza(x + 1, TamanhoX), normaliza(y - 1, TamanhoY)] ? 1 : 0) +
            (quadro[normaliza(x + 1, TamanhoX), normaliza(y - 0, TamanhoY)] ? 1 : 0) +
            (quadro[normaliza(x + 1, TamanhoX), normaliza(y + 1, TamanhoY)] ? 1 : 0);
    }
}

