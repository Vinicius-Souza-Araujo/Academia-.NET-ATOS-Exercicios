namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool primo;

            while (true)
            {
                Console.WriteLine("Digite um número: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (n == 0)
                {
                    break;
                }

                Console.WriteLine("O número " + n + " é " +  (n % 2 == 0 ? "par" : "ímpar"));

                primo = true;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                Console.WriteLine($"O número " + n + " é " + (primo ? "primo" : "não primo"));
                Console.WriteLine();
            }
        }
    }
}