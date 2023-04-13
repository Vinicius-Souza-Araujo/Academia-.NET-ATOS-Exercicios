namespace Ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b, expoente, resultado;

            Console.Write("Digite a base: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Digite o expoente: ");
            expoente = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            resultado = Math.Pow(b, expoente);

            Console.WriteLine(b + " elevado a " + expoente + " resulta em " + resultado);
        }
    }
}