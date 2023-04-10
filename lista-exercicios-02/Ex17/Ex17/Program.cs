namespace Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l1, l2, l3;

            Console.WriteLine("Lado 1: ");
            l1 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Lado 2: ");
            l2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Lado 3: ");
            l3 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (l1 < l2 + l3 && l2 < l1 + l3 && l3 < l1 + l2)
            {
                if (l1 == l2 && l2 == l3)
                {
                    Console.WriteLine("Triângulo Equilátero!");
                }
                else if (l1 == l2 || l2 == l3 || l1 == l3)
                {
                    Console.WriteLine("Triângulo Isósceles.");
                }
                else
                {
                    Console.WriteLine("Triângulo Escaleno.");
                }

            }
            else { Console.WriteLine("Não é um triângulo"); }
        }
    }
}