namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome completo da pessoa: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("O IMC de " + nome.ToUpper() +  " é " + imc);

            if (imc < 18)
            {
                Console.WriteLine("Situação: Baixo peso");
            }
            else if (imc >= 18 && imc < 25)
            {
                Console.WriteLine("Situação: Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Situação: Sobrepeso");
            }
            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("Situação: Obesidade");
            }
            else
            {
                Console.WriteLine("Situação: Obesidade grau sério");
            }
        }
    }
}