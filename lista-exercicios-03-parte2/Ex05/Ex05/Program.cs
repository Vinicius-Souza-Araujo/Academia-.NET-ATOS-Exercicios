namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int votosJoao = 0;
            int votosZeca = 0;
            int votosBranco = 0;
            int votosNulos = 0;
            int tVotos = 0;

            while (true)
            {
                Console.WriteLine("Digite o voto: JOAO, ZECA,BRANCO ou qualquer coisa para NULO e FIM para encerrar");
                string voto = Console.ReadLine();

                if (voto.ToUpper() == "FIM")
                {
                    break;
                }
                else if (voto.ToUpper() == "JOAO")
                {
                    votosJoao++;
                }
                else if (voto.ToUpper() == "ZECA")
                {
                    votosZeca++;
                }
                else if (voto.ToUpper() == "BRANCO")
                {
                    votosBranco++;
                }
                else
                {
                   votosNulos++;
                }

                tVotos++;
            }

            if (votosJoao > votosZeca)

            {
                Console.WriteLine();
                Console.WriteLine("João é o vencedor!");
                
            }
            else if (votosZeca > votosJoao)
            {
                Console.WriteLine();
                Console.WriteLine("Zeca é o vencedor!");
                
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Houve um empate!");
                
            }

            Console.WriteLine();
            Console.WriteLine("Total de votos: " + tVotos);
            Console.WriteLine("Votos em João: " + votosJoao);
            Console.WriteLine("Votos em Zeca: " + votosZeca);
            Console.WriteLine("Votos em branco: " + votosBranco);
            Console.WriteLine("Votos nulos: " + votosNulos);
        }
    }
}