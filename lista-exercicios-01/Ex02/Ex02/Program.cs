namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio número 2 -  Escreva um programa em C# e no Visual Studio
            //para calcular a média aritmética entre quatro números quaisquer.

            double valor1;
            double valor2;
            double valor3;
            double valor4;
            double media;

            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            valor3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto valor: ");
            valor4 = double.Parse(Console.ReadLine());

            media = (valor1+valor2+valor3+valor4)/4;
            Console.WriteLine("O resultado da média aritmética é: "+media);

        }
    }
}