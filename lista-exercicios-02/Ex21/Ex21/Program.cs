namespace Ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorEntrada, valorSaida = 0;
            string unidadeEntrada, unidadeSaida;

            Console.WriteLine("Digite um valor:");
            valorEntrada = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Digite a unidade de medida do valor: (m, cm, in ou ft):");
            unidadeEntrada = Console.ReadLine().ToLower();
            Console.WriteLine("");

            Console.WriteLine("Digite a unidade de medida de saída (m, cm, in ou ft):");
            unidadeSaida = Console.ReadLine().ToLower();
            Console.WriteLine("");

            switch (unidadeEntrada)
            {
                case "m":
                    switch (unidadeSaida)
                    {
                        case "m":
                            valorSaida = valorEntrada;
                            break;
                        case "cm":
                            valorSaida = valorEntrada * 100;
                            break;
                        case "in":
                            valorSaida = valorEntrada * 39.37;
                            break;
                        case "ft":
                            valorSaida = valorEntrada * 3.281;
                            break;
                    }
                    break;
                case "cm":
                    switch (unidadeSaida)
                    {
                        case "m":
                            valorSaida = valorEntrada / 100;
                            break;
                        case "cm":
                            valorSaida = valorEntrada;
                            break;
                        case "in":
                            valorSaida = valorEntrada / 2.54;
                            break;
                        case "ft":
                            valorSaida = valorEntrada / 30.48;
                            break;
                    }
                    break;
                case "in":
                    switch (unidadeSaida)
                    {
                        case "m":
                            valorSaida = valorEntrada / 39.37;
                            break;
                        case "cm":
                            valorSaida = valorEntrada * 2.54;
                            break;
                        case "in":
                            valorSaida = valorEntrada;
                            break;
                        case "ft":
                            valorSaida = valorEntrada / 12;
                            break;
                    }
                    break;
                case "ft":
                    switch (unidadeSaida)
                    {
                        case "m":
                            valorSaida = valorEntrada / 3.281;
                            break;
                        case "cm":
                            valorSaida = valorEntrada * 30.48;
                            break;
                        case "in":
                            valorSaida = valorEntrada * 12;
                            break;
                        case "ft":
                            valorSaida = valorEntrada;
                            break;
                    }
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine(valorEntrada+unidadeEntrada+" equivalem a " +  valorSaida+unidadeSaida);
        }
    }
}