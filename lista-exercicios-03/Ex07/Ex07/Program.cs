namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7 Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por 
            //um usuário.Apresente o resultado.

            int n, pares = 0, impares = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Quantidade de números pares: " + pares);
            Console.WriteLine("Quantidade de números ímpares: " + impares );
        }
    }
}