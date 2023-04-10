using System.Runtime.Intrinsics.Arm;

namespace Ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.

            int v1, v2, v3;

            Console.Write("Primeiro valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Segundo valor: ");
            v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Terceiro valor: ");
            v3 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int[] valores = { v1, v2, v3 };
            Array.Sort(valores);

            foreach (int valor in valores)
            {
                Console.Write(valor + " ");
            }
        }
    }
}