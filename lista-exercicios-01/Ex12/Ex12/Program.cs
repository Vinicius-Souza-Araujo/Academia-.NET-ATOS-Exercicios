using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça.Sabendo - se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a
            //marcação do odômetro(marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total(R$) recebido
            //            dos passageiros.Calcule e escreva a média do consumo em Km / l e o lucro líquido do dia.

            //Fórmulas: Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia
            //                Média do consumo = Total quilometragem / quantidade de combustível gasto

            //Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)

            double totalQuilometragem, odometroFinalDia, odometroInicioDia, mediaConsumo, combustivelGasto, lucroDia, valorTotalRecebido;

            Console.WriteLine("Digite a marcação do odômetro no inicio do dia: ");
            odometroInicioDia = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Digite a marcação do odômetro no final do dia: ");
            odometroFinalDia = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Digite o número de litros de combustível gasto: ");
            combustivelGasto = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Digite o valor total recebido de todos os passageiros: ");
            valorTotalRecebido = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            totalQuilometragem = odometroFinalDia - odometroInicioDia;
            mediaConsumo = totalQuilometragem / combustivelGasto;

            Console.WriteLine("Média de consumo: "+ mediaConsumo);

            lucroDia = valorTotalRecebido - (combustivelGasto * 6.90);

            Console.WriteLine("Lucro líquido do dia: " + lucroDia);




        }
    }
}