namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[5];


            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o valor para o vetor na posição " + i + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }

            for (int i = 0; i < vetor.Length; i++)
            {  
                Console.Write(" | " + vetor[i]);
            }

            Console.WriteLine("");

            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                Console.Write(" | " + vetor[i]);
            }


        
        }
    }
}