Module mapreduce

    Sub Main()

        Dim somaDosParesAoQuadrado =
            Enumerable.Range(1, 100) _
                .Where(Function(x) x Mod 2 = 0) _
                .Select(Function(x) x ^ 2) _
                .Aggregate(Function(acc, x) acc + x)

        Console.WriteLine(somaDosParesAoQuadrado)

    End Sub

End Module
