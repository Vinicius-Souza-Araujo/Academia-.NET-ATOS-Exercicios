using System.Runtime.Intrinsics.X86;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio número 4 - Faça um programa em C# e no Visual Studio que
            //receba a data na forma DDMMAAAA e imprima na 
            //forma AAAAMMDD. Note que o dia, o mês e o ano devem ser
            //lidos em variáveis diferentes.

            string dia;
            string mes;
            string ano;
            string result;

            Console.WriteLine("Digite o dia: ");
            dia = Console.ReadLine();

            Console.WriteLine("Digite o mês: ");
            mes = Console.ReadLine();

            Console.WriteLine("Digite o ano: ");
            ano = Console.ReadLine();

            Console.WriteLine("Data: "+ano+"/"+mes+"/"+dia);


        }
    }
}