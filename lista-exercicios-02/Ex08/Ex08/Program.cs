namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
            //Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5 % do total de vendas.
            //Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7 % do total de vendas.
            //E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10 % do
            //total de vendas.

            int codigo;
            string nome;
            double salarioBase, totalVendas, comissao, salarioFinal;

            Console.Write("Digite o código do funcionário: ");
            codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do funcionário: ");
            nome = Console.ReadLine();

            Console.Write("Digite o salário base do funcionário: ");
            salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Digite o total de vendas do funcionário: ");
            totalVendas = double.Parse(Console.ReadLine());

            comissao = 0;

            if (totalVendas > 500 && totalVendas <= 1000)
            {
                comissao = totalVendas * 0.05;
            }
            else if (totalVendas > 1000 && totalVendas <= 5000)
            {
                comissao = totalVendas * 0.07;
            }
            else if (totalVendas > 5000)
            {
                comissao = totalVendas * 0.10;
            }

            salarioFinal = salarioBase + comissao;

            Console.WriteLine("");
            Console.WriteLine("Código: "+ codigo);
            Console.WriteLine("Nome" + nome);
            Console.WriteLine("Salário: " + salarioBase);
            Console.WriteLine("Total de vendas: " + totalVendas);
            Console.WriteLine("Comissão: " + comissao);
            Console.WriteLine("Salário + Comissão: " + salarioFinal);
        }
    }
}