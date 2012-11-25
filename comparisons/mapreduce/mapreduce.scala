

object mapreduce {
    def main(args: Array[String]) {

        val somaDosParesAoQuadrado =
            (1 until 101)
            .filter(_ % 2 == 0)
            .map(x => x * x)
            .reduceRight(_ + _)

        println(somaDosParesAoQuadrado)
    }
}