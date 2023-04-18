using System;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde
            //cada elemento de C é a subtração do elemento correspondente de A com B.

            int[,] matrizA = new int[3, 3];
            int[,] matrizB = new int[3, 3];
            int[,] matrizC = new int[3, 3];
            Random random = new Random();
            int numAleatorio;

            //Populando matriz A
            for (int linha = 0; linha < matrizA.GetLength(0); linha++)
            {

                for (int coluna = 0; coluna < matrizA.GetLength(1); coluna++)
                {
                    numAleatorio = random.Next(0, 100);
                    matrizA[linha, coluna] = numAleatorio;

                   
                }
            }


            //Populando matriz B
            for (int linha = 0; linha < matrizB.GetLength(0); linha++)
            {

                for (int coluna = 0; coluna < matrizB.GetLength(1); coluna++)
                {
                    numAleatorio = random.Next(0, 100);
                    matrizB[linha, coluna] = numAleatorio;


                }
            }

            //Populando matriz C com a bubtração de A - B
            for (int linha = 0; linha < matrizC.GetLength(0); linha++)
            {

                for (int coluna = 0; coluna < matrizC.GetLength(1); coluna++)
                {
                    
                    matrizC[linha, coluna] = matrizA[linha, coluna] - matrizB[linha, coluna];


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


            // Mostrando a matriz B
            for (int linha = 0; linha < matrizB.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matrizB.GetLength(1); coluna++)
                {
                    Console.Write(matrizB[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            // Mostrando a matriz C
            Console.WriteLine("Matriz A - Matriz B é igual a: ");
            for (int linha = 0; linha < matrizC.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matrizC.GetLength(1); coluna++)
                {
                    Console.Write(matrizC[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}