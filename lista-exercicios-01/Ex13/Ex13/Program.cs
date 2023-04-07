namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
            //preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
            //vendidas pelo vendedor, calcule e mostre: o salário do empregado
            
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
