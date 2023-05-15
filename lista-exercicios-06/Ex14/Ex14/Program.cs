namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            bool validar = true;
            Agenda agenda = new Agenda();
            string nome;

            while (validar)
            {

                Console.WriteLine(" ");
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine(" ");
                Console.WriteLine(" 1 - Adicionar pessoa.");
                Console.WriteLine(" 2 - Deletar pessoa.");
                Console.WriteLine(" 3 - Buscar pessoa.");
                Console.WriteLine(" 4 - Imprimir agenda.");
                Console.WriteLine("Qualquer outro número para sair");
                Console.WriteLine(" ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                switch (opcao)
                {

                    case 1:
                        Pessoa pessoa = new Pessoa();

                        Console.WriteLine("Nome: ");
                        pessoa.Nome = Console.ReadLine();
                        Console.WriteLine(" ");

                        Console.WriteLine("Idade: ");
                        pessoa.Idade = int.Parse(Console.ReadLine());
                        Console.WriteLine(" ");

                        Console.WriteLine("Altura: ");
                        pessoa.Altura = float.Parse(Console.ReadLine());
                        Console.WriteLine(" ");

                        agenda.ArmazenaPesssoa(pessoa);

                        break;

                    case 2:
                        Console.WriteLine("Nome: ");
                        nome = Console.ReadLine();
                        
                        agenda.RemovePessoa(nome);


                        break;

                    case 3:

                        Console.WriteLine("Nome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine(" ");

                        Pessoa p = agenda.BuscaPessoa(nome);
                        if(p != null)
                        {
                            p.ImprimePessoa();

                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada!");
                            Console.WriteLine(" ");
                        }

                        break;

                    case 4:

                        agenda.ImprimeAgenda();

                        break;


                    default:
                        validar = false;
                        break;
                }

            }
        }
    }
}