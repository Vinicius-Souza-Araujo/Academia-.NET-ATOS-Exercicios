namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então
            //mostre na tela a quantidade de números pares e ímpares.

            int[] vetor = new int[10];
            int par = 0, impar = 0;

            for(int i = 0; i < vetor.Length; i++)

            {
                Console.WriteLine("Digite um valor para a posição " + (i+1) + ": " );
                vetor[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }

            for(int i = 0;i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0) {
                    
                    par++;
                }
                else
                {
                    impar++;
                }
                
            }

            Console.WriteLine("Quantidade de números pares: " + par);
            Console.WriteLine("Quantidade de números impares: " + impar);
        }
    }
}