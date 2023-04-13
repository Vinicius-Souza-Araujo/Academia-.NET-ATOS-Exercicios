namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 1; i <= 500; i++)
            {
                if(i % 2 == 0) { 
                soma = soma + i;
                }
            }

            Console.WriteLine("A soma de todos os números pares entre 1 e 500 é: " + soma);
        }
    }
}