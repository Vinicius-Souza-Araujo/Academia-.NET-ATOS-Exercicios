namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6.Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
            //ou seja, repita a leitura até que ela esteja correta(maior do que zero). 
            //Ao final, mostre a idade digitada.

            int idade = 0;

            while(true)
            {
                Console.Write("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (idade > 0)
                {
                    break;
                }
                Console.WriteLine("Idade deve ser maior do que zero, tente novamente...");
                Console.WriteLine("");
            }

            Console.WriteLine("Idade digitada: " + idade);
           
        }
    }
}