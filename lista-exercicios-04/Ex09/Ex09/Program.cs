namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0, k = 0, menor, posicao;
            int[] vetor = new int[10];
            int[] auxiliar = new int[10];

            for (i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite um valor para a posição " + (i + 1) + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }


            for (i = 0; i < vetor.Length; i++)
            {
                menor = vetor[i];
                posicao = i;

                for (j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < menor)
                    {
                        menor = vetor[j];
                        posicao = j;
                    }
                }

                auxiliar[i] = menor;
                vetor[posicao] = vetor[i];
                vetor[i] = menor;
            }

            
            for (k = 0; k < 10; k++)
            {
                
                Console.Write(auxiliar[k] + " | ");
            }
        }
            
    }
}