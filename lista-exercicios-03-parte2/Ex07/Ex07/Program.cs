using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7.Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa.
            //A cada solicitação, teste se o usuário informou um valor válido. 
            //Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
            //informe que ele está incorreto e saia do programa em VS.
            //Se o nome for lido corretamente, solicite a idade.Se ela for incorreta(menor ou igual a zero),
            //informe que está errada e saia.Se estiver correta, solicite o salário.
            //Se ele estiver incorreto(menor ou igual a zero), informe que está incorreto e saia.
            //Se estiver correto, mostre todos os valores lidos.

            string nome;
            int idade;
            double salario;

            
            while (true) {
                //Validando nome
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("");

                if (nome.Contains("0") ||  nome.Contains("1") || nome.Contains("2") ||
                    nome.Contains("3") || nome.Contains("4")  || nome.Contains("5") ||
                    nome.Contains("6") || nome.Contains("7")  || nome.Contains("8") ||
                    nome.Contains("9")) {

                    Console.WriteLine("Nome inválido!");
                    break;
                    
                }
                
                else if(nome == "" || nome == " " )
                {
                    Console.WriteLine("Nome inválido!");
                    break;
                    
                }

                //Validando idade

                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (idade <= 0)
                {
                    Console.WriteLine("idade inválida!");
                    break;
                }


                // Validando salário

                Console.WriteLine("Digite seu salário: ");
                salario = double.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (salario <= 0)
                {
                    Console.WriteLine("Salário inválido!");
                    break;
                }

                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Salário: " + salario);
                break;


            }

        }   
    }
}


