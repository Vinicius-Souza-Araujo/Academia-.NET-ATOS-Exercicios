namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10 - Faça um programa no VS que receba dados de dois atletas(nome, idade e altura).
            //O programa deve mostrar os dados do atleta mais novo e mais alto.

            
            string nome1, nome2;
            int idade1, idade2;
            double altura1, altura2;

        
            Console.WriteLine("Dados do primeiro atleta:");
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            idade1 = int.Parse(Console.ReadLine());
            Console.Write("Altura em metros: ");
            altura1 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Dados do segundo atleta:");
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            idade2 = int.Parse(Console.ReadLine());
            Console.Write("Altura em metros: ");
            altura2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");


            if (idade1 < idade2)
            {
                Console.WriteLine("Atleta mais novo: " + nome1);
                Console.WriteLine("Idade: " + idade1 + "anos");
            }
            else if (idade1 > idade2)
            {
                Console.WriteLine("Atleta mais novo: " + nome2);
                Console.WriteLine("Idade: " + idade2 + "anos");
            }
            else
            {
                Console.WriteLine("Os atletas têm a mesma idade.");
            }

            
            if (altura1 > altura2)
            {
                Console.WriteLine("Atleta mais alto: " + nome1);
                Console.WriteLine("Altura: " + altura1 + "m");
            }
            else if (altura1 < altura2)
            {
                Console.WriteLine("Atleta mais alto: " + nome2);
                Console.WriteLine("Altura: " + altura2 + "m");
            }
            else
            {
                Console.WriteLine("Os atletas têm a mesma altura.");
            }
        }
    }
}