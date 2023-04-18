using System.Reflection;
using System.Runtime.Serialization.Formatters;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //4) Popule uma matriz 5x5 e informe:
            //-Quantos números são pares
            //- Quantos números são impares
            //- Quantos números são positivos
            //- Quantos números são negativos
            //- Quantos zeros existem!

            int[,] matriz = new int[5, 5];
            Random random = new Random();
            int numAleatorio, contPar = 0, contImpar = 0, contPosit = 0, contNegat = 0, contZero = 0;

            //Populando matriz
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {

                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    numAleatorio = random.Next(-100,100);
                    matriz[linha, coluna] = numAleatorio;

                    if (numAleatorio % 2 == 0 && numAleatorio != 0) { contPar++; }
                    if(numAleatorio % 2 != 0) { contImpar++; }
                    if (numAleatorio > 0) { contPosit++; }
                    if (numAleatorio < 0) { contNegat++; }
                    if(numAleatorio == 0) { contZero++; }
                   
                }
            }


            // Mostrando a matriz
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Pares: " + contPar);
            Console.WriteLine("Impares: " + contImpar);
            Console.WriteLine("Positivos: " + contPosit);
            Console.WriteLine("Neagativos: " + contNegat);
            Console.WriteLine("Zeros: " + contZero);

        }
    }
}