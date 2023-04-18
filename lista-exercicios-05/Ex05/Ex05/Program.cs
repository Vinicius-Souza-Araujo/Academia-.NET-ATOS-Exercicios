using System;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) Leia duas matrizes 2x3 de números double.
            //Imprima a soma destas duas matrizes.

            double[,] matriz = new double[2, 3];
            double[,] matriz2 = new double[2, 3];
            double[,] matrizSoma = new double[2, 3];

            Random random = new Random();
            double numAleatorio;

            //Populando matriz
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {

                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    numAleatorio = Math.Round(random.NextDouble() * 10,2);
                    matriz[linha, coluna] = numAleatorio;

                }
            }

            //Populando matriz 2
            for (int linha = 0; linha < matriz2.GetLength(0); linha++)
            {

                for (int coluna = 0; coluna < matriz2.GetLength(1); coluna++)
                {
                    numAleatorio = Math.Round(random.NextDouble()*10, 2);
                    matriz2[linha, coluna] = numAleatorio;

                }
            }


            // Mostrando a matriz
            Console.WriteLine("Matriz 1");
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            // Mostrando a matriz 2
            Console.WriteLine("Matriz 2");
            for (int linha = 0; linha < matriz2.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz2.GetLength(1); coluna++)
                {
                    Console.Write(matriz2[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //Somando matriz 1 + matriz 2 e adicionando os resultados a matriz soma
            for (int linha = 0; linha < matrizSoma.GetLength(0); linha++)
            {

                for (int coluna = 0; coluna < matrizSoma.GetLength(1); coluna++)
                {
                    matrizSoma[linha, coluna] = Math.Round(matriz[linha,coluna] + matriz2[linha,coluna],2);

                }
            }

            // Mostrando a matriz soma
            Console.WriteLine("Matriz resultante da soma: matriz 1 + matriz 2");
            for (int linha = 0; linha < matrizSoma.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matrizSoma.GetLength(1); coluna++)
                {
                    Console.Write(matrizSoma[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}