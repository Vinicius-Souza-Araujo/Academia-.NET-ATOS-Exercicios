namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[20];
            int[] vetor2 = new int[20];
            int i;

            for (i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite um valor para a posição " + (i + 1) + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }

            for (i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == 0)
                {
                    vetor2[i] = 2;
                }
                else
                {
                    vetor2[i] = vetor[i];
                }
            }

            Console.WriteLine("Vetor de entrada: ");
            for (i = 0; i < vetor.Length ; i++)
            {
                Console.Write(vetor[i] + " | ");
            }

            Console.WriteLine("");

            Console.WriteLine("Vetor de saída: ");
            for (i = 0; i < vetor.Length ; i++)
            {
                Console.Write(vetor2[i] + " | ");
            }


        }
    }
}