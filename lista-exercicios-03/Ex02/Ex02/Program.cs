namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 - Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.
            int n, i, maior = 0;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número: ");
                n = int.Parse(Console.ReadLine());
                if (n > maior)
                {
                    maior = n;
                }
            }
            Console.WriteLine("O maior número é o: " + maior);
        }
    }
}