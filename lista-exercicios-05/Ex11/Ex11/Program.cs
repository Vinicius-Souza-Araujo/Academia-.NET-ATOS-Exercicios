using System;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11) Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz
            //resultante da divisão dos elementos da matriz A pela soma dos seus indices.

            double[,] matrizA = new double[3, 3];
            double[,] matrizResult = new double[3, 3];
            Random random = new Random();
            double numAleatorio, soma;

            //Populando matriz A e MatrizResult
            for (int linha = 0; linha < matrizA.GetLength(0); linha++)
            {

                for (int coluna = 0; coluna < matrizA.GetLength(1); coluna++)
                {
                    numAleatorio = Math.Round(random.NextDouble() * 10, 2);
                    matrizA[linha, coluna] = numAleatorio;

                    if (linha == 0 && coluna == 0)
                    {
                        matrizResult[linha, coluna] = 0;
                    }
                    else {
                        soma = linha + coluna;
                        matrizResult[linha, coluna] = Math.Round(matrizA[linha, coluna] / soma, 2);
                    }
                    


                }
            }


            // Mostrando a matriz A
            for (int linha = 0; linha < matrizA.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matrizA.GetLength(1); coluna++)
                {
                    Console.Write(matrizA[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Mostrando a matriz Result
            for (int linha = 0; linha < matrizResult.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matrizResult.GetLength(1); coluna++)
                {
                    Console.Write(matrizResult[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

            
        }
    }
}