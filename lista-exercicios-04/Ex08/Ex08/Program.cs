namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = new double[5];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o valor para o vetor na posição " + i + ": ");
                vetor[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("");
            }


            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < 0)
                {
                    Console.Write(" | " + i);
                }

            }

        }
    }
}