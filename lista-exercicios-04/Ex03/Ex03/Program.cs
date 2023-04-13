using System;
using System.Net;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Escreva um algoritmo que leia os valores para um vetor de 20 elementos
            //e então mostre na tela o índice da posição dos valores correspondentes a números primos.

            int[] vetor = new int[4];
            int contador = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("informe um valor para a posição " + i + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }

            Console.WriteLine("Índices das posições que contem valores que são números primos: ");
            Console.WriteLine("");

            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j <= vetor[i]; j++ ) {

                    if (vetor[i] % (j + 1) == 0)
                    {
                        contador = contador + 1;

                    }
                }

                if (contador == 2)
                {
                    Console.WriteLine(i);
                }

                contador = 0;
            }


        }
    }
}