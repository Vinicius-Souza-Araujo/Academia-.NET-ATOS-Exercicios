namespace Ex20
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int contFeminino = 0, maiorIdade = 0, idade, corOlhos = 0, corCabelos = 0;
            char sexo=' ';

            while (true)
            {
                Console.WriteLine("Digite sua idade para iniciar ou um número negativo para sair: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (idade < 0) { break; }

                if (idade > maiorIdade){ maiorIdade = idade; }


                while (sexo != 'M'  && sexo!='F') { 

                    Console.WriteLine("Digite seu sexo sendo (M) - Masculino ou (F) - Feminino: ");
                    sexo = char.Parse(Console.ReadLine().ToUpper());
                    Console.WriteLine();

                    if (sexo != 'M' && sexo != 'F') { Console.WriteLine("Opção inválida tente novamente..."); }

                    
                }



                while (corOlhos  < 1 || corOlhos > 3) {

                    Console.WriteLine("Digite a cor dos seus olhos sendo: ");
                    Console.WriteLine("1 - Azuis, 2 - Verdes ou 3 - Castanhos: ");
                    corOlhos = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (corOlhos < 1 || corOlhos > 3 ) { Console.WriteLine("Opção inválida tente novamente..."); }
                    
                }

                while (corCabelos < 1 || corCabelos > 3)
                {

                    Console.WriteLine("Digite a cor dos seus cabelos sendo: ");
                    Console.WriteLine("1 - Louros, 2 - Castanhos ou 3 - Pretos: ");
                    corCabelos = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (corCabelos < 1 || corCabelos > 3) { Console.WriteLine("Opção inválida tente novamente..."); }

                }


                if (sexo == 'F' && (idade >= 18 && idade <= 35) && corOlhos == 2 && corCabelos == 1 ) { contFeminino++; };

                corOlhos = 0;
                corCabelos = 0;
                sexo = ' ';
            }

            Console.WriteLine("Maior idade: " + maiorIdade);
            Console.WriteLine();
            Console.WriteLine("Indivíduos do sexo feminino cuja idade está entre está entre 18 e 35 anos inclusive e que tenham olhos verdes e cabelos louros: " + contFeminino);
            
        }
    }
}