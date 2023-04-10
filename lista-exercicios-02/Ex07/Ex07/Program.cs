namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
            //O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por
            //exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.

            string palavra, frase;

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            Console.WriteLine("Digite uma palavra: ");
            palavra = Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine("A palavra " + palavra + " está dentro da frase " + frase);
            }
            else
            {
                Console.WriteLine("Palavra não encontrada!");
            }
        }
    }
}