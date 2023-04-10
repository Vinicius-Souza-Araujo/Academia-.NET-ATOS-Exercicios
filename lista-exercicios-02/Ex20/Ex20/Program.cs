using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace Ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
            //plus: você pode gerar o número de forma randomica(função random c#).

            Random random = new Random();
            int nSecreto = random.Next(1, 51);
            int tentativas = 3;

            Console.WriteLine("Jogo de adivinhação do número secreto!");
            Console.WriteLine("Você tem 3 chances para adivinhar o número secreto, que está entre 1 e 50.");

            while (tentativas > 0)
            {
                Console.WriteLine("Tentativa " + (4 - tentativas) + ":");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == nSecreto)
                {
                    Console.WriteLine("Parabéns, você acertou o número secreto!");
                    return;
                }
                else if (opcao < nSecreto)
                {
                    Console.WriteLine("O número é maior.");
                }
                else
                {
                    Console.WriteLine("O número é menor.");
                }

                tentativas--;
            }

            Console.WriteLine("Fim de jogo! Você não conseguiu adivinhar o número secreto, que era " + nSecreto + ".");
        }
    }
}