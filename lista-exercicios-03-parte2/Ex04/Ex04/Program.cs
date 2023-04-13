namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Em uma cidadezinha do interior há dois candidatos para prefeito(JOAO e ZECA).
            //Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
            //Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA. 
            //Você também pode aceitar votos em branco(palavra BRANCO).O programa em VS termina quando o usuário
            //escrever FIM.Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número
            //de votos em branco.

            int votosJoao = 0;
            int votosZeca = 0;
            int votosBranco = 0;

            while (true)
            {
                Console.WriteLine("Digite o voto: JOAO, ZECA ou BRANCO e FIM para encerrar ");
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
                    Console.WriteLine("Voto inválido.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Votos em João: " + votosJoao);
            Console.WriteLine("Votos em Zeca: " + votosZeca);
            Console.WriteLine("Votos em branco: " + votosBranco);
        }
    }
}