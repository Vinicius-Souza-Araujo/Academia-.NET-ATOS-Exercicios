namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio número 7 - Escreva um programa em C# e no Visual Studio que leia o número
            //de um vendedor, o seu salário fixo, o total de vendas por ele efetuadas e o percentual
            //que ganha sobre o total de vendas. Calcule o salário total do vendedor.Escreva o número
            //do vendedor e o salário total do vendedor.

            string numVendedor;
            double salario, totalVenda, percentual, valorPercentutal;

            Console.WriteLine("Número do vendedor: ");
            numVendedor = Console.ReadLine();

            Console.WriteLine("Salário fixo do vendedor: ");
            salario =  double.Parse(Console.ReadLine());

            Console.WriteLine("Total vendido: ");
            totalVenda = double.Parse(Console.ReadLine());

            Console.WriteLine("Porcentagem ganha sobre a venda efetuada: ");
            percentual = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Número do vendedor: " + numVendedor);
            Console.WriteLine("Salário: " + salario);

            valorPercentutal = (totalVenda * percentual) / 100;
            Console.WriteLine("Comissão por venda: " + (valorPercentutal));

            Console.WriteLine("Salário + comissão: " + (salario+valorPercentutal));











        }
    }
}