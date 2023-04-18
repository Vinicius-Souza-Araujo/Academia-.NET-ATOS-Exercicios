namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int[] somaLinha = new int[3];
            int[] somaCol = new int[3];

            //Leitura dos dados.
            for (int linha = 0; linha < matriz.GetLength(0); linha++) {

                for(int coluna = 0; coluna < matriz.GetLength(1); coluna ++) {

                    Console.WriteLine("Digite um valor para a linha " + linha + " coluna " + coluna + ": ");
                    matriz[linha,coluna] = int.Parse(Console.ReadLine());
                }
            }



            //Somando o valor das linhas e colunas.
            int i = 0, j;

            while (i < 3) {
                
                for(j = 0; j < 3; j++)
                {
                    somaLinha[i] = matriz[i,j] + somaLinha[i];
                    somaCol[i] = matriz[j,i] + somaCol[i];
                }

                i++;
            }

            Console.WriteLine();


            // Mostrando a matriz
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Exibindo resultado das somas.
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Somatorio linha " + i + " = " + somaLinha[i]);
            }
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Somatorio coluna " + i + " = " + somaCol[i]);
            }

        }
    }
}