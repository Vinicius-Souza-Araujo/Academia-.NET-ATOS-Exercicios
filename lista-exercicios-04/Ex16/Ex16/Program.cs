namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //   16.Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva.Crie, 
         //   a seguir, um vetor para cada uma das operações:
	        //A união de X com Y
	        //A diferença entre X e Y
	        //A interseção entre X e Y
         //   Escreva o vetor resultado de cada uma das operações.

            int tamanho = 10, cont = 0;
            int[] x = new int[tamanho];
            int[] y = new int[tamanho];
            int[] resultUniao = new int[tamanho*2];
            int[] resultDiferenca = new int[tamanho];
            int[] resultIntersecao = new int[tamanho];

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Digite o valor para o vetor X na posição " + i + ": ");
                x[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }

            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine("Digite o valor para o vetor Y na posição " + i + ": ");
                y[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }

            x.CopyTo(resultUniao, 0);
            y.CopyTo(resultUniao, 10); ;

            for (int i = 0; i < resultDiferenca.Length; i++)
            {
                if (x[i] > y[i])
                {
                    resultDiferenca[i] = x[i] - y[i];
                }
                else if(y[i] > x[i])
                {
                    resultDiferenca[i] = y[i] - x[i];
                }

                else
                {
                    resultDiferenca[i] = 0;
                }
            }

            for (int i = 0; i < resultIntersecao.Length; i++)
            {
                for (int j = 0; j < resultIntersecao.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        resultIntersecao[cont++] = x[i];
                        break;
                    }
                }
            }


            Console.Write("Vetor X: ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(" | " + x[i]);
            }

            Console.WriteLine("");

            Console.Write("Vetor Y: ");
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write(" | " + y[i]);
            }

            Console.WriteLine("");

            Console.Write("Vetor da União: ");
            for (int i = 0; i < resultUniao.Length; i++)
            {
                Console.Write(" | " + resultUniao[i]);
            }

            Console.WriteLine("");

            Console.Write("Vetor da Diferença: ");
            for (int i = 0; i < resultDiferenca.Length; i++)
            {
                Console.Write(" | " + resultDiferenca[i]);
            }

            Console.WriteLine("");

            Console.Write("Vetor da Interseção: ");
            for (int i = 0; i < resultIntersecao.Length; i++)
            {

                Console.Write(" | " + resultIntersecao[i]);
            }
            
        }
    }
}