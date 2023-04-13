using System.ComponentModel;
using System.Drawing;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados
            //(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
            //Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

            //Exemplo:
            //Digite um número inteiro positivo: -8
            //Valor incorreto!
            //Digite um número inteiro positivo: 8
            //Numero digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.

            int i, n = 0;

            while(true)  {

                Console.WriteLine("Digite um número inteiro positivo e diferente de 0: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if(n > -1 && n != 0) {

                    Console.WriteLine("Número digitado: "+ n);
                    Console.WriteLine();

                    Console.WriteLine("Números inteiros pares entre 1 e " + n + ": ");
                    for (i = 1; i < n; i++ )
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }


                    break;
                }

                Console.WriteLine("Valor incorreto!");
            }
            



        }
    }
}