using System;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8) Ler uma matriz com 4x4 de inteiros e mostrar os números
            //na ordem direta e inversa a que foram lidos.

            int[,] matriz = new int[4, 4];
            Random random = new Random();
            int numAleatorio;

            //Populando matriz
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {

                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    numAleatorio = random.Next(0, 100);
                    matriz[linha, coluna] = numAleatorio;

                }
            }


            // Mostrando a matriz da esquerda para direita
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            

            // Mostrando a matriz da direita para esquerda
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = matriz.GetLength(1) - 1; coluna >= 0; coluna--)
                {
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}