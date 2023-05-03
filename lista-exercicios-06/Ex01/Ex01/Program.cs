namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Digitar nome e idade");
            Console.WriteLine("2 - Digitar idade");
            string opcao = Console.ReadLine();
            Console.WriteLine("");

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Idade: ");
                    idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Pessoa pessoa = new Pessoa(nome, idade);
                    break;

                case "2":
                    Console.WriteLine("Idade: ");
                    idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    pessoa = new Pessoa(idade);
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;

            }
        }
    }
}