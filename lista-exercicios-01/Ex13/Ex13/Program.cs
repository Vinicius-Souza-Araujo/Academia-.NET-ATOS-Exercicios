namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioMinimo, precoCusto, precoVenda, numBicicletasVendidas, salarioEmpregado;

            Console.WriteLine("Digite o valor do salário minimo: ");
            salarioMinimo = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Digite o preço de custo  das bicicletas: ");
            precoCusto = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Digite o número de bicicletas vendidas: ");
            numBicicletasVendidas = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            precoVenda = (precoCusto + (precoCusto * 0.50));
            salarioEmpregado = (salarioMinimo * 2) + ((numBicicletasVendidas * precoVenda)*0.15);

            Console.WriteLine("Salário do empregado: " + salarioEmpregado);





        }
    }
}