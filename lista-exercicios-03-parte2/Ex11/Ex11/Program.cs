namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdAlunos = 0;
            double nota, soma = 0, notaMaisAlta = 0, notaMaisBaixa = 0;

            do
            {
                Console.WriteLine("Digite a nota do aluno ou -1 para encerrar: ");
                nota = double.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (nota != -1)
                {
                    qtdAlunos++;
                    soma = soma + nota;

                    if (qtdAlunos == 1)
                    {
                        notaMaisAlta = nota;
                        notaMaisBaixa = nota;
                    }
                    else
                    {
                        if (nota > notaMaisAlta)
                        {
                            notaMaisAlta = nota;
                        }

                        if (nota < notaMaisBaixa)
                        {
                            notaMaisBaixa = nota;
                        }
                    }
                }
            } while (nota != -1);

            double mediaTurma = soma / qtdAlunos;

            Console.WriteLine("Nota mais alta: " + notaMaisAlta);
            Console.WriteLine("Nota mais baixa: " + notaMaisBaixa);
            Console.WriteLine("Média da turma: " + mediaTurma);
            Console.WriteLine("Quantidade de alunos: " + qtdAlunos);
        }
    }
}