namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado calcular a média de idade de n pessoas.
            int n;
            double media, idade, soma = 0;
            Console.WriteLine("Digite o valor de N: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite sua idade pessoa " + i);
                idade = int.Parse(Console.ReadLine());
                soma = idade + soma;
            }

            media = soma / n;

            Console.WriteLine("A media das idades é " + media);
        }
    }
}