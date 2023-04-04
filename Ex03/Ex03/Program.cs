namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)


        {
            //Exercicio número 3 - Escreva a seqüência de atribuições, em forma de programa em C#
            //e no Visual Studio, para trocar entre 
            //si os valores de duas variáveis A e B.

            Console.WriteLine("---------------------");
            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------");
            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine("Valor de B: " + b);

            int auxiliar = a;
            a = b;
            b = auxiliar;
            Console.WriteLine("---------------------");
            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine("Valor de B: " + b);
            Console.WriteLine("---------------------");
        }
    }
}