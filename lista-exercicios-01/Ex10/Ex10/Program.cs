namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor, resto, nota;
            int[] notas = { 100, 50, 20, 10, 5, 2, 1 };

            Console.Write("Digite a quantia solicitada: ");
            valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Notas:");
            for (int i = 0; i < notas.Length; i++)
            {
                nota = notas[i];
                resto = valor % nota;

                if (valor >= nota)
                {
                    Console.WriteLine(nota+ " : " + (valor / nota));
                    valor = resto;
                }
            }


        }
    }
}