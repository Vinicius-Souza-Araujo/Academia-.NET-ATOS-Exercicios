namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite seu nome: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite a nota 1: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a nota 2: ");
            aluno.Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a nota 3: ");
            aluno.Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine();

           
            Console.WriteLine((aluno.VeriicarAprovacao() == true) ? "Aluno aprovado!" : "Aluno reprovado!");


        }
    }
}