namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 20, cont = 0;
            int[] vetor = new int[tamanho];
            int[] vetor2 = new int[tamanho];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o valor para o vetor na posição " + i + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }

            for (int i = vetor2.Length - 1; i >= 0; i--)
            {
                vetor2[cont] = vetor[i];
                cont++;
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(" | " + vetor[i]);
            }

            Console.WriteLine("");

            for (int i = 0; i < vetor2.Length; i++)
            {  
                Console.Write(" | " + vetor2[i]);
            }

        }
    }
}