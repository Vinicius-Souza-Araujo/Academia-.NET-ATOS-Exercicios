using System.Net;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize
            //a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.
            int tamanho = 20;
            int[] vetor = new int[tamanho];
            int[] vetor2 = new int[tamanho];
            int[] vetor3 = new int[tamanho];

            for (int i = 0; i < vetor.Length; i++) {

                Console.WriteLine("Digite para o vetor 1 um valor na posição "+ i + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Digite para o vetor 2 um valor na posição " + i + ": ");
                vetor2[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                vetor3[i] = vetor[i] + vetor2[i]; 
            }

            Console.WriteLine("Resultado das Somas de vetor1 e vetor2 nas mesmas posições: ");
            Console.WriteLine("");
            for (int i = 0; i < vetor3.Length; i++)
            {
                Console.WriteLine(vetor3[i]);
            }

                
        }
    }
}