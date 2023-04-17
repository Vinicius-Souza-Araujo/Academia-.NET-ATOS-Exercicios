namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            int[] vetor = new int[50];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o valor para o vetor na posição " + i + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }

            while (true)
            {
                Console.WriteLine("Digite um código (0 - Encerrar programa, 1 - Mostrar vetor ou 2 - Mostrar vetor em ordem inversa): ");
                codigo = int.Parse(Console.ReadLine());
                Console.WriteLine();

                
                if(codigo == 0) { 
                    break;
                }
                else if(codigo == 1)
                {
                    for (int i = 0; i < vetor.Length; i++)
                    {
                        Console.Write(" | " + vetor[i]);
                    }

                    Console.WriteLine("");

                    
                }

                else if (codigo == 2)
                {
                    for (int i = vetor.Length - 1; i >= 0; i--)
                    {
                        Console.Write(" | " + vetor[i]);
                    }
                }

                    Console.WriteLine("");
            }
            
           
        }
    }
}