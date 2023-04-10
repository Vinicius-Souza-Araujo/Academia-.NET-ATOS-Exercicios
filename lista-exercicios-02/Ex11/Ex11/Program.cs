using System.Runtime.Intrinsics.X86;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis(uma para hora e outra para minutos).
            //O programa deve exibir se a hora digitada está ou não válida. 
            //Lembre que usaremos o padrão de hora com 24h, de 0 a 23.

            int hora, minuto;

            Console.Write("Digite a hora de 0 a 23: ");
            hora = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Digite os minutos de 0 a 59: ");
            minuto = int.Parse(Console.ReadLine());

            if (hora >= 0 && hora <= 23 && minuto >= 0 && minuto <= 59)
            {
                Console.WriteLine("");
                Console.WriteLine("Hora válida!");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Hora inválida!");
            }
        }
    }
}