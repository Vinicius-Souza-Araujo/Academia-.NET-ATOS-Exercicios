using System.Drawing;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio número 6 - Escreva um programa em C# e no Visual Studio
            //que leia os dados para o parafuso A e para o parafuso B, isto é,
            //o código, a quantidade de peças e o valor unitário de cada parafuso
            //e a porcentagem de IPI(única) a ser acrescentada.

            int codigoPa, codigoPb, quantiPa, quantiPb;
            double valorUnitPa, valorUnitPb, IpiPa, IpiPb;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Digite os dados do parafuso A: ");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Código: ");
            codigoPa = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade: ");
            quantiPa = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor unitário: ");
            valorUnitPa = double.Parse(Console.ReadLine());

            Console.WriteLine("IPI: ");
            IpiPa = double.Parse(Console.ReadLine());


            Console.WriteLine("-------------------------------");
            Console.WriteLine("Digite os dados do parafuso B: ");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Código: ");
            codigoPb = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade: ");
            quantiPb = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor unitário: ");
            valorUnitPb = double.Parse(Console.ReadLine());

            Console.WriteLine("IPI: ");
            IpiPb = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Dados dos parafusos A e B: ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");

            Console.WriteLine("parafuso A: ");
            Console.WriteLine("código:"+codigoPa+ " quantidade:"+quantiPa+" valor unitário:"+valorUnitPa+" IPI:"+IpiPa);

            Console.WriteLine("parafuso B: ");
            Console.WriteLine("código:" + codigoPb + " quantidade:" + quantiPb + " valor unitário:" + valorUnitPb + " IPI:" + IpiPb);



        }
    }
}