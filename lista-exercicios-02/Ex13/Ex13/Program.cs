namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13 - Tendo como dado de entrada a altura(h) de uma pessoa, construa um programa no VS que calcule
            //seu peso ideal, utilizando as seguintes fórmulas:
            //Para homens: (72.7 * h) - 58
            //Para mulheres: (62.1 * h) - 44.7

            double altura;
            char opcao;
            double pesoIdeal;

            Console.WriteLine("Digite sua altura em metros: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Digite (M) para masculino ou (F) para feminino: ");
            opcao = char.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 'M' :
                    pesoIdeal = (72.70 * altura) - 58;
                    Console.WriteLine("Seu peso ideal é: " + pesoIdeal + " kg");
                    break;
                case 'F':
                    pesoIdeal = (62.10 * altura) - 44.70;
                    Console.WriteLine("Seu peso ideal é: " + pesoIdeal + " kg");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        }
    }
}