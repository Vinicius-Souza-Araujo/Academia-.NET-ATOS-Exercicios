using System;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n;
            string parOuImpar, opcao;
            

            while (true) {

                do
                {
                    Console.WriteLine(" Digite um número inteiro: ");
                    n = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                while (!(n % 1 == 0));



                parOuImpar = (n % 2 == 0) ? "par" : "ímpar";
                Console.WriteLine(n + " é " + parOuImpar);
                Console.WriteLine("");

                Console.WriteLine("Deseja repetir o programa? Digite sim para repetir ou qualquer coisa para encerrar!");
                opcao = Console.ReadLine().ToLower();

                if (opcao != "sim" ) {
                    break;
                }

            }




        }
    }
}