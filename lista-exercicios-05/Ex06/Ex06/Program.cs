namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0 - 9.
            //Após isso determine o maior número da matriz.
            //Random random = new Random();
            //int randomNumber = random.Next(0, 100);

            int[,] matriz = new int[4, 4];
            int numMaior = 0;
            Random random = new Random();
            int numAleatorio;

            //Populando matriz
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {

                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    numAleatorio = random.Next(0, 9);
                    matriz[linha, coluna] = numAleatorio;

                    if (numMaior < matriz[linha, coluna]) { numMaior = matriz[linha, coluna]; }

                }
            }

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
            Console.WriteLine("Maior número: " + numMaior);

            
        }
    }
}