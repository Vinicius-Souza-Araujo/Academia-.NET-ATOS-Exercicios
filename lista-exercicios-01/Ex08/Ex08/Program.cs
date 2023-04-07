using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
            //A fórmula da conversão é F = (9 * C + 160) / 5.

            double valor;

            Console.Write("Digite o valor em graus Celcius: ");

            valor = double.Parse(Console.ReadLine());
            double conveterFahrenheit = (9 * valor + 160)/5;
            Console.Write(valor+"°C é igual a "+ conveterFahrenheit+ "°F");
        }
    }
}