namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 
            int i;
            Console.WriteLine("Digite um número");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine(i + " é " + (i % 2 == 0 ? "par" : "impar"));
        }
    }
}