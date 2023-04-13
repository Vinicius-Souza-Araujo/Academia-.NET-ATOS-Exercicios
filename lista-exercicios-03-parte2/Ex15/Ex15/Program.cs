namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;

            Console.WriteLine("Nota 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Nota 2: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Nota 3: ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Nota 4: ");
            n4 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            media = ((n1*2) + (n2*1) + (n3*2) + (n4*4))/9;

            if(media >= 7)
            {
                Console.WriteLine("Resultado da média: " + media);
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Resultado da média: " + media);
                Console.WriteLine("Reprovado!");
            }
        }
    }
}