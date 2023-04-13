namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdHomens = 0;
            int qtdMulheres = 0;
            int qtdMenos30 = 0;
            int qtdMais60 = 0;
            int somaIdadeMulheres = 0;

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Digite o nome da pessoa " + i + ":");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o sexo da pessoa (M/F) " + i + ":");
                char sexo = char.Parse(Console.ReadLine().ToUpper());

                Console.WriteLine("Digite a idade da pessoa " + i + ":");
                int idade = int.Parse(Console.ReadLine());

                if (sexo == 'M')
                {
                    qtdHomens++;
                }
                else if (sexo == 'F')
                {
                    qtdMulheres++;
                    somaIdadeMulheres += idade;
                }

                if (idade < 30)
                {
                    qtdMenos30++;
                }
                else if (idade > 60)
                {
                    qtdMais60++;
                }
            }

            double mediaIdadeMulheres = (double)somaIdadeMulheres / qtdMulheres;

            Console.WriteLine("Número de pessoas do sexo masculino: " + qtdHomens);
            Console.WriteLine("Número de pessoas do sexo feminino: " + qtdMulheres);
            Console.WriteLine("Número de pessoas com idade inferior a 30 anos: " + qtdMenos30);
            Console.WriteLine("Número de pessoas com idade superior a 60 anos: " + qtdMais60);
            Console.WriteLine("Média de idade das mulheres: " + mediaIdadeMulheres);

        }
    }
}