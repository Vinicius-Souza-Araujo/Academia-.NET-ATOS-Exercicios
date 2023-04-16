namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            for (int linha = 0; linha < matriz.GetLength(0); linha++) {
                for(int coluna = 0; coluna < matriz.GetLength(1); coluna ++) {
                    Console.WriteLine("Digite um valor para a linha " + linha + " coluna " + coluna + ": ");
                    matriz[linha,coluna] = int.Parse(Console.ReadLine());
                }
            }

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }



        }
    }
}