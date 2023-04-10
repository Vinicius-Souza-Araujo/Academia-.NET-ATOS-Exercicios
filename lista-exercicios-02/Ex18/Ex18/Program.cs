namespace Ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

            int v1, v2, v3;
            int maiorValor;

           
            Console.Write("Primeiro valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Segundo valor: ");
            v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Terceiro valor: ");
            v3 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
           
            maiorValor = v1;
            if (v2 > maiorValor)
            {
                maiorValor = v2;
            }
            if (v3 > maiorValor)
            {
                maiorValor = v3;
            }

            Console.WriteLine("Maior valor: " + maiorValor);
        }
    }
}