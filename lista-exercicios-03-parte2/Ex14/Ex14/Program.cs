namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double potencia;
            int i;

            for (i = 0; i <= 10; i++)
            {
                potencia = Math.Pow(2, i);
                Console.WriteLine("2 elevado a " + i + " = " + potencia);
            }
        }
    }
}