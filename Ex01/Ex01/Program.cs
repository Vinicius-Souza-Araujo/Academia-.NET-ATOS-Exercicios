namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio número 1 - Escreva um programa em C# e no Visual Studio
            //para calcular a média aritmética entre dois números quaisquer.

            double valor1;
            double valor2;
            double media;

            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            media = (valor1+valor2)/2;
            Console.WriteLine("O resultado da média aritmética é: "+media);

        }
    }
}