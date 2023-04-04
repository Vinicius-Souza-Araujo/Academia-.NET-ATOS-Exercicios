namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio número 5 - Escreva um programa em C# e no Visual Studio para calcular
            //o consumo médio de um automóvel (medido em Km/ l), sendo que são conhecidos
            //a distância total percorrida e o volume de combustível consumido para percorrê-la
            //(medido em l).

            double distancia;
            double volume;
            double consumoMedio;

            Console.Write("Informe a distância total percorrida em Km: ");
            distancia = double.Parse(Console.ReadLine());

            Console.Write("Informe o volume de combustível consumido em litros: ");
            volume = double.Parse(Console.ReadLine());

            consumoMedio = distancia / volume;

            Console.WriteLine(" O consumo médio do automóvel foi de "+ consumoMedio+"Km/l.");
        }
    }
}