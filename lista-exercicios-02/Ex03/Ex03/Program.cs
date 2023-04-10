namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 - Escrever um algoritmo para ler quatro valores inteiros, calcular
            //    a sua média, e escrever na tela os que são superiores à média.

            double n1, n2, n3, n4, media;

            Console.WriteLine("Nota 1:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Nota 2:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Nota 3:");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Nota 4:");
            n4 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("Média: " + media);
            Console.WriteLine("");
            Console.WriteLine("Notas superiores a média: ");
            if (n1 > media) { Console.WriteLine(n1); };
            if (n2 > media) { Console.WriteLine(n2); };
            if (n3 > media) { Console.WriteLine(n3); };
            if (n4 > media) { Console.WriteLine(n4); };
        }
    }
}