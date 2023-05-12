namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            p.Nome = nome;

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            p.Idade = idade;

            
        }
    }
}