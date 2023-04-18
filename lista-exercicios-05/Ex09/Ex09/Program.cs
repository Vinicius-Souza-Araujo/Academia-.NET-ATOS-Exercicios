using static System.Net.Mime.MediaTypeNames;

namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9) Leia uma matriz 3x3.Em seguida, solicite um número qualquer ao usuário
            //e pesquise na matriz se o número existe. Caso, seja verdade imprima a
            //mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.
            
            int[,] matriz = new int[3, 3];
            Random random = new Random();
            int numAleatorio, num;
            string mensagem= "Número inexistente";

           //Populando matriz
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {

                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    numAleatorio = random.Next(0, 100);
                    matriz[linha, coluna] = numAleatorio;

                }
            }


            Console.WriteLine("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();


            // Verificando se número existe na matriz
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if (matriz[linha, coluna] == num) { mensagem = "O número existe no vetor"; }
                    
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

            Console.WriteLine(mensagem);
        }
    }
}