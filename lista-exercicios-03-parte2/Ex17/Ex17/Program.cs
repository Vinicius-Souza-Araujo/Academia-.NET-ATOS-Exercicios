namespace Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, quadrado;

            for (i = 15; i <= 200; i++)
            {
                quadrado = i * i;
                Console.WriteLine("O quadrado de " + i + " é " + quadrado);
            }
        }
    }
}