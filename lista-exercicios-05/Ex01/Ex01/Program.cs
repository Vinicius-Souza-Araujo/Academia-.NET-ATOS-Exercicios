namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int[,] matriz = new int[5, 3];
            for (int linha = 0; linha < 5; linha++)
            {
                Console.WriteLine("Digite um valor para a primeira coluna: ");
                matriz[linha, 0] = int.Parse(Console.ReadLine());
                matriz[linha, 1] = matriz[linha, 0] + 10;
                matriz[linha, 2] = matriz[linha, 0] * 2;
            }

            for(int linha = 0;linha < 5; linha++)
            {
                for(int coluna =  0; coluna < 3; coluna++)
                {
                    Console.Write(matriz[linha,coluna] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}