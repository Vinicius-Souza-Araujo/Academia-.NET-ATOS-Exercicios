namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double metrosQuadrados, litrosNecessarios, latasNecessarias, precoTotal; ;
            

            Console.WriteLine("Tamanho em metros quadrados da área a ser pintada:");
            metrosQuadrados = int.Parse(Console.ReadLine());

            litrosNecessarios = Math.Ceiling(metrosQuadrados / 3);
            latasNecessarias = Math.Ceiling(litrosNecessarios / 18);

            precoTotal = latasNecessarias * 80;
            Console.WriteLine("Quantidade de latas de tinta necessárias: " + latasNecessarias);
            Console.WriteLine("Preço total: R$ " + precoTotal);
        }
    }
}