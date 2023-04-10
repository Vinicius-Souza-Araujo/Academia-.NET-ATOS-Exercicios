using System.Drawing;
using System.Net;
using System;

namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
            //diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
            //Se o valor diário for menor que 65, avisá - lo que corre risco de hipoglicemia
            //Se o valor diário for maior que 250, avisá - lo que corre risco de hiperglicemia.
            //Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados.E se a média for
            //menor que 80, avisá - lo que é preciso diminuir 2 unidades de insulina.Se a média for maior que
            //150, avisá - lo que será necessário adicionar 2 unidades de insulina.

            double glicemia1, glicemia2, glicemia3, media;
            

            Console.WriteLine("Digite o valor da primeira medição:");
            glicemia1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da segunda medição:");
            glicemia2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da terceira medição:");
            glicemia3 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            if (glicemia1 < 65 || glicemia2 < 65 || glicemia3 < 65)
            {
                Console.WriteLine("Risco de hipoglicemia!");
            }

            if (glicemia1 > 250 || glicemia2 > 250 || glicemia3 > 250)
            {
                Console.WriteLine("Risco de hiperglicemia!");
            }

            media = (glicemia1 + glicemia2 + glicemia3) / 3;

            Console.WriteLine("");

            if (media < 80) {
                Console.WriteLine("É preciso diminuir 2 unidades de insulina!");
            } 
            else if (media > 150)
            {
                Console.WriteLine("Será necessário adicionar 2 unidades de insulina!");
            }
        }
    }
}