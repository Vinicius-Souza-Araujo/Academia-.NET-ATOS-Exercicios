using static System.Net.Mime.MediaTypeNames;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool parar = false;
            string opcao;
            double saldo, deposito, saque;
            ContaCorrente conta = new ContaCorrente();

            while (true)

            {
                Console.WriteLine("1 - Definir Saldo Inicial ");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Sacar");
                Console.WriteLine("4 - Sair");
                opcao = Console.ReadLine();
                Console.WriteLine("");

                switch (opcao)
                {
                    
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Digite o saldo: ");
                        saldo = double.Parse(Console.ReadLine());
                        conta.definirSaldoInicial(saldo);
                        Console.WriteLine("");
                        conta.consultarSaldo();
                        Console.WriteLine("");

                    break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Digite o valor do deposito: ");
                        deposito = double.Parse(Console.ReadLine());
                        conta.depositar(deposito);
                        Console.WriteLine("");
                        conta.consultarSaldo();
                        Console.WriteLine("");
                    break;


                    case "3":
                        Console.Clear();
                        Console.WriteLine("Digite o valor do saque: ");
                        saque = double.Parse(Console.ReadLine());
                        if (conta.sacar(saque))
                        {
                            Console.WriteLine("");
                            conta.consultarSaldo();
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Saldo insuficiente para o saque!");
                            conta.consultarSaldo();
                            Console.WriteLine("");
                        }
                        
                    break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Até mais!");
                        parar = true;
                    break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida! Tente novamente...");
                        Console.WriteLine("");
                        break;

                }

                if (parar == true)
                {
                    break;
                }
            }
        }
    }
}