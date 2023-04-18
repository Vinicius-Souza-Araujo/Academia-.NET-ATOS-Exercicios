using System.Reflection;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!


            int[,] matriz = new int[4, 4];
            int[] armazenaDiagonal = new int[4];
            //Leitura dos dados.
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {

                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {

                    Console.WriteLine("Digite um valor para a linha " + linha + " coluna " + coluna + ": ");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            //Armazenando os valores que estão na diagonal principal.
            int i = 0, j = 0;
          
                for (i = 0; i < 4; i++)
                {

                    for (j = 0; j < 4; j++) {
                        if(i == j)
                        {
                            armazenaDiagonal[i] = matriz[i, j];
                            break;
                        }
                    
                    }
                    
                    
                }


            //Mostrando  os valores que estão na diagonal principal.

            Console.WriteLine("Valores que estão na diagonal principal");
            Console.WriteLine("");

            string espaco = " ";
            for (i = 0; i < armazenaDiagonal.Length; i++)
            {
                Console.WriteLine((espaco = espaco + "  ") + armazenaDiagonal[i]);
                 
            }


            
        }
    }
}