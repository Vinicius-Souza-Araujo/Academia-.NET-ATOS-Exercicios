namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga
            //quantos dos elementos lidos estão abaixo, acima e na média.

            double[,] matrizA = new double[4, 4];
            double[,] matrizB = new double[4, 4];

            double contAcimaMediaA = 0;
            double contAbaixoMediaA = 0;
            double contNaMediaA = 0;

            double contAcimaMediaB = 0;
            double contAbaixoMediaB = 0;
            double contNaMediaB = 0;

            Random random = new Random();
            double numAleatorio, somaA = 0, somaB = 0, mediaA, mediaB;

            //Populando matriz A
            for (int linha = 0; linha < matrizA.GetLength(0); linha++)
            {

                for (int coluna = 0; coluna < matrizA.GetLength(1); coluna++)
                {
                    numAleatorio = Math.Round(random.NextDouble() * 10, 2);
                    matrizA[linha, coluna] = numAleatorio;
                    somaA = Math.Round(somaA + numAleatorio,2);


                }
            }

            mediaA = Math.Round((somaA / 16), 2);

            //Populando matriz B
            for (int linha = 0; linha < matrizB.GetLength(0); linha++)
            {

                for (int coluna = 0; coluna < matrizB.GetLength(1); coluna++)
                {
                    numAleatorio = Math.Round(random.NextDouble() * 10, 2);
                    matrizB[linha, coluna] = numAleatorio;
                    somaB = Math.Round(somaB + numAleatorio,2);

                }
            }

            mediaB = Math.Round((somaB / 16), 2);

            // Mostrando a matriz A
            for (int linha = 0; linha < matrizA.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matrizA.GetLength(1); coluna++)
                {
                    if (matrizA[linha, coluna] > mediaA) { contAcimaMediaA++; }
                    else if (matrizA[linha, coluna] < mediaA) { contAbaixoMediaA++; }
                    else { contNaMediaA++; }

                    Console.Write(matrizA[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Mostrando a matriz B
            for (int linha = 0; linha < matrizB.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matrizB.GetLength(1); coluna++)
                {
                    if (matrizB[linha, coluna] > mediaB) { contAcimaMediaB++; }
                    else if (matrizB[linha, coluna] < mediaB) { contAbaixoMediaB++; }
                    else { contNaMediaB++; }

                    Console.Write(matrizB[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Soma de todos os emelentos da matriz A: " + somaA);
            Console.WriteLine("Soma de todos os emelentos da matriz B: " + somaB);
            Console.WriteLine();
            Console.WriteLine("Media Matriz A: " + mediaA);
            Console.WriteLine("Media Matriz B: " + mediaB);
            Console.WriteLine();

            Console.WriteLine("Quantidade de valores acima da média da matriz A: " + contAcimaMediaA);
            Console.WriteLine("Quantidade de valores abaixo da média da matriz A: " + contAbaixoMediaA);
            Console.WriteLine("Quantidade de valores na média da matriz A: " + contNaMediaA);

            Console.WriteLine();

            Console.WriteLine("Quantidade de valores acima da média da matriz B: " + contAcimaMediaB);
            Console.WriteLine("Quantidade de valores abaixo da média da matriz B: " + contAbaixoMediaB);
            Console.WriteLine("Quantidade de valores na média da matriz B: " + contNaMediaB);

        }
    }
}