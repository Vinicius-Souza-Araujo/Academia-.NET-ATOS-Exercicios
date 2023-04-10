using static System.Net.Mime.MediaTypeNames;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
            //Área do triangulo = (base * altura) / 2;
            //Teste se a base ou a altura digitada não foi igual a zero.

            double baseT, alturaT, Area;


            Console.WriteLine("Altura: ");
            alturaT = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (alturaT == 0)
            {
                Console.WriteLine("Altura igual a zero!");
            }
            else
            {
                Console.WriteLine("Base: ");
                baseT = double.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (baseT == 0)
                {
                    Console.WriteLine("Base igual a zero!");
                }
                else
                {
                    Area = (baseT * alturaT) / 2;
                    Console.WriteLine("Area: " + Area);
                }
            }
        }
    }
}