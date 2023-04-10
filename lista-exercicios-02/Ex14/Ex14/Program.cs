namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14 - Faça um programa que peça o tamanho de um arquivo para download(em MB) e a velocidade de um
            //link de Internet(em Mbps). Em seguida, calcule e informe o tempo aproximado de download
            //do arquivo usando este link(em minutos).

            double tamanho, vel, tempo, velMB, tempoM;
            int seg;
            Console.WriteLine("Digite o tamanho do arquivo");
            tamanho = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a velocidade do link");
            vel = double.Parse(Console.ReadLine());
            velMB = vel * 0.125;
            tempo = tamanho / velMB;
            Console.WriteLine("O tempo em segundos é = " + tempo);
            tempoM = tempo / 60;
            seg = (int)tempo % 60;
            Console.WriteLine("O tempo em minutos é = " + (int)tempoM + " e " + seg + " segundos");


        }
    }
}