using System.Net;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles.
            //Mostrar na tela qual dos professores tem o maior salário total.

            int horas1, horas2;
            double valorReceber1, valorReceber2, salarioP1, salarioP2;

            Console.Write("Digite a quantidade de horas aula do primeiro professor: ");
            horas1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a receber por hora do primeiro professor: ");
            valorReceber1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de horas aula do segundo professor: ");
            horas2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a receber por hora do segundo professor: ");
            valorReceber2 = double.Parse(Console.ReadLine());

            salarioP1 = horas1 * valorReceber1;
            salarioP2 = horas2 * valorReceber2;

            if(salarioP1 > salarioP2)
            {
                Console.WriteLine("O primeiro professor tem o maior salário!");
            }

            else if(salarioP2 > salarioP1) {
                Console.WriteLine("O segundo professor tem o maior salário!");
            }

            else
            {
                Console.WriteLine("Os salários são iguais!");
            }


        }
    }
}