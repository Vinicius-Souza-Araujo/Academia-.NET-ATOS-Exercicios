namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Escreva um algoritmo para calcular o fatorial de um número.
            int n, fatorial;
            Console.WriteLine("Digite um número inteiro:");
            n = int.Parse(Console.ReadLine());
            fatorial = 1;
            for (int i = 1; i <= n; i++)
            {
                fatorial *= i;
            }
            Console.WriteLine("O fatorial de " + n + " é " + fatorial);

        }
    }
}