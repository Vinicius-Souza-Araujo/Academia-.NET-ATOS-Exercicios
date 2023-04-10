using System.Xml.Linq;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
            //se a média das duas notas for maior ou igual a 7,0.
            //Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
            //é a média entre a nota do exame e a média das 2 notas.
            //Se esta média final for maior ou igual a 5, 0, o programa deve escrever “Aprovado”, caso contrário deve
            //escrever “Reprovado”.

            double n1, n2, media, nExame, mediaFinal;

            Console.Write("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());

            media = (n1 + n2) / 2;

            if (media >= 7.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Digite a nota do exame: ");
                nExame = double.Parse(Console.ReadLine());
                mediaFinal = (media + nExame) / 2;

                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aprovado");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                }
            }
        }
    }
}