namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pCasa, pFora, diferenca, pCasa2, pFora2;

            Console.WriteLine("Digite a pontuação do time da casa: ");
            pCasa = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Digite a pontuação do time de fora: ");
            pFora = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (pFora - pCasa >= 2 ) {
                Console.WriteLine("O time de fora já se classificou!");
            }
            else
            {
                Console.WriteLine("Os dois times se enfrentarão em um novo jogo!");
                Console.WriteLine("");

                Console.WriteLine("Digite a pontuação do time da casa neste segundo jogo: ");
                pCasa2 = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Digite a pontuação do time de fora neste segundo jogo: ");
                pFora2 = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (pFora2 >= pCasa2)
                {
                    Console.WriteLine("O time de fora passou de fase!");
                }
                else
                {
                    Console.WriteLine("O time de casa passou de fase!");
                }

            }


        }
    }
}