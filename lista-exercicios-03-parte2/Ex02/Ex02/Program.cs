using System.Runtime.ConstrainedExecution;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja
            //informar um outro número. Caso positivo, o programa em VS deve ser repetido.

            //Exemplo:

            //Digite um número inteiro positivo: 8
            //Numero digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.
            //Deseja informar outro número(s/ n)? S
            //Digite um número inteiro positivo: 12
            //Numero digitado: 20
            //Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.
            //Deseja informar outro número(s/ n)? N

            int i, n = 0;
            char op;

            while(true)
            {

                Console.WriteLine("Digite um número inteiro positivo e diferente de 0: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (n > -1 && n != 0)
                {

                    Console.WriteLine("Número digitado: " + n);
                    Console.WriteLine();

                    Console.WriteLine("Números inteiros pares entre 1 e " + n + ": ");
                    for (i = 1; i < n; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }

                    Console.WriteLine("");

                    Console.WriteLine("Deseja informar outro número(s/ n)?");
                    op = char.Parse(Console.ReadLine().ToLower());
                    Console.WriteLine("");
                    if (op == 's')
                    {
                        continue;
                    }
                    else if(op == 'n')
                    {
                        break;
                    }

                }

                Console.WriteLine("Valor incorreto!");
            }
        }
    }
}