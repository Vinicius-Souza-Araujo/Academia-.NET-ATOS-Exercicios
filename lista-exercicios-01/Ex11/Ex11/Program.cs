using System.Runtime.ConstrainedExecution;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11) Escreva um algoritmo para ler o número de eleitores de um município,
            //o número de votos brancos, nulos e válidos. 
            //Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.

            int totalEleitores, validos, brancos, nulos;

            Console.WriteLine("Digite a quantidade de votos válidos: ");
            validos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de votos em branco: ");
            brancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de votos nulos: ");
            nulos = int.Parse(Console.ReadLine());

            totalEleitores = validos + brancos + nulos;

            Console.WriteLine("");
            Console.WriteLine("Total de votos: "+ totalEleitores);

            Console.WriteLine("Percentual de votos válidos: " + (validos * 100)/totalEleitores+"%");
            Console.WriteLine("Percentual de votos brancos: " + (brancos * 100) / totalEleitores + "%");
            Console.WriteLine("Percentual de votos válidos: " + (nulos * 100) / totalEleitores + "%");



        }
    }
}