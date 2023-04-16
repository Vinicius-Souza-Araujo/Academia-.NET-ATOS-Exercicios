namespace Ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mediaSalarioPopu, mediaNfilhos, maiorSalario = 0, salario, somaSalario = 0, somaFilhos = 0, percentualPessoasAteCem;

            int nPessoas = 0, nPessoasAteCem = 0, nFilhos = 0;


            while (true)
            {
                Console.Write("Digite o salário para iniciar ou digite um número negativo para encerrar: ");

                salario = double.Parse(Console.ReadLine());

                if (salario < 0){ break; }


                Console.Write("Digite o número de filhos: ");
                nFilhos = int.Parse(Console.ReadLine());


                somaSalario += salario;
                somaFilhos += nFilhos;

                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                }

                if (salario <= 100)
                {
                    nPessoasAteCem++;
                }

                nPessoas++;
            }

            mediaSalarioPopu = somaSalario / (double)nPessoas;
            mediaNfilhos = somaFilhos / (double)nPessoas;
            percentualPessoasAteCem = ((double)nPessoasAteCem/ nPessoas)*100;

            Console.WriteLine("Média salarial da população: " + mediaSalarioPopu);
            Console.WriteLine("Média de filhos: " + mediaNfilhos);
            Console.WriteLine("Maior salário: " + maiorSalario);
            Console.WriteLine("Percentual de pessoas com salário até R$100,00: " + percentualPessoasAteCem + "%");

        }
    }
}