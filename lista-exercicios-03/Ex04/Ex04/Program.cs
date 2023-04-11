namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 - Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida
            //calcule a potência de x elevado na y sem utilizar a função pow.

            int x, y, result = 1;

            Console.WriteLine("Digite o valor de x: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de y: ");
            y = int.Parse(Console.ReadLine());

            for (int i = 1; i <= y; i++)
            {
                result = x * result;
            }

            Console.WriteLine("A potência de x elevado a y é: " + result);
        }
    }
}