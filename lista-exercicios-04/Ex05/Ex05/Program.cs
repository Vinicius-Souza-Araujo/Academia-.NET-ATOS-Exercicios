namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.

            int[] vetor = new int[80];
            int menor = 0;
            int posicao = 0;

            for (int i = 0; i < vetor.Length; i++)
            {

                Console.WriteLine("Digite para o vetor um valor na posição " + i + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if(i == 0) {
                    menor = vetor[i];
                    posicao = i;
                }

                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    posicao = i;
                }
            }

            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Posição do menor valor: " + posicao);
        }
    }
}