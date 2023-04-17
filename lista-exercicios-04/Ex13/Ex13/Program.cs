namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int max = 100;
            int[] vetor = new int[max];
            int cont2 = 0, cont4 = 0, cont8 = 0, num = 0, tamanho = 0;

            
            

            for (int i = 0; i < max; i++)
            {
                while (true) {
                    Console.Write("Digite um valor para o vetor ou -1 para parar: ");
                    num = int.Parse(Console.ReadLine());

                    if(num < -1) { 
                        Console.WriteLine("Valor não permitido tente novamente...");
                    }
                    else { break; }
                    

                }
                

             
                if(num == -1) {
                    break;

                }

                else { 
                    vetor[i] = num;
                    tamanho = i;
                }
                

            }

           for (int i = 0;i <= tamanho; i++)
            {
                if (vetor[i] == 2) { cont2++; }
                if (vetor[i] == 4) { cont4++; }
                if (vetor[i] == 8) { cont8++; }
            }


            Console.WriteLine();
            Console.WriteLine("Quantidade de números 2: " + cont2);
            Console.WriteLine("Quantidade de números 4: " + cont4);
            Console.WriteLine("Quantidade de números 8: " + cont8);




        }
    }
}