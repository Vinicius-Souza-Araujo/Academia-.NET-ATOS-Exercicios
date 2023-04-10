namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo, numeroHoras;
            double salario, extra = 0;

            Console.Write("Digite o código do operário: ");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Digite o número de horas trabalhadas: ");
            numeroHoras = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (numeroHoras > 50)
            {
                extra = (numeroHoras - 50) * 20.0;
                salario = 50 * 10 + extra;
            }
            else
            {
                salario = numeroHoras * 10;
            }

            Console.WriteLine("Salário total: R$ " + salario);
            Console.WriteLine("Salário excedente: R$ " + extra);
        }
    }
}