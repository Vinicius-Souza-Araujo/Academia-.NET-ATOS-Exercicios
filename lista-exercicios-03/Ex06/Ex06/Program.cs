namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6 - Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações
            //aplicadas para aquela turma.Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final
            //(média das notas das avaliações).

            int i,j, nAlunos, qtdAvaliacoes;
            double media, soma = 0, nota;

            Console.WriteLine("Número de alunos: ");
            nAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Quantidade de avaliações aplicadas: ");
            qtdAvaliacoes = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (i = 1; i <= nAlunos; i++)
            {
                media = 0;
                soma = 0;
                for (j = 1; j <= qtdAvaliacoes;j++)
                {
                    Console.WriteLine("Digite a " + j +"° nota do aluno " + i);
                    nota = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    soma = soma + nota;
                }

                media = soma / qtdAvaliacoes;

                Console.WriteLine("Nota final do aluno " + i + ": "+ media );
                Console.WriteLine();
            }
        }
    }
}