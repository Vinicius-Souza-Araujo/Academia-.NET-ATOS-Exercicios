using System.Security.Cryptography.X509Certificates;

namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Livro livro = new Livro();
            Console.WriteLine("Digite o titulo do livro: ");
            livro.Titulo = Console.ReadLine();
            Console.WriteLine();

            livro.Autor = new Autor();
            Console.WriteLine("Digite o nome do autor: ");
            livro.Autor.Nome = Console.ReadLine();
            Console.WriteLine();

            livro.MostrarDados();




        }
    }
}