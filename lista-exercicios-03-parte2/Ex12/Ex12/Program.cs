namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma = soma + i;
            }

            Console.WriteLine("A soma dos 100 primeiros números inteiros é: " + soma);
        }
    }
}