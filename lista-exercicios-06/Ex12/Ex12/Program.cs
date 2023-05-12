namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            Carro carro = new Carro();
            Console.WriteLine("Simulador de carro!");
            Console.WriteLine();

            Console.WriteLine("Modelo do carro: ");
            carro.Modelo = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Ano do carro: ");
            carro.Ano = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Velocidade atual: " + carro.Velocidade);

                
                Console.WriteLine();
                Console.WriteLine(" 1 - Acelerar carro ");
                Console.WriteLine(" 2 - Frear carro ");
                Console.WriteLine(" 3 - Sair do simulador ");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    carro.Acelerar();
                }

                else if(opcao == 2)
                {
                    carro.Frear();
                }

                else if(opcao == 3){ break; }
            }
        }
    }
}