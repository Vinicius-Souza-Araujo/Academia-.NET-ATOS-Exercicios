namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 5, num, cont = 0;
            int[] vetor = new int[tamanho];
            int[] auxiliar = new int[tamanho];



            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o valor para o vetor na posição " + i + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == num) { 
                    Console.WriteLine("Esse número " + num + " existe na posição " + i + " do vetor.");
                    cont++;
                }

            }

            if(cont == 0) { Console.WriteLine("O número fornecido não existe no vetor!"); }

        }
    }
}