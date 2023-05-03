using System;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar uma classe chamada Aluno com 3 construtores, sendo que o
            //primeiro recebe o nome e a matrícula do aluno,
            //o segundo recebe apenas a data de nascimento do aluno
            //e o terceiro construtor recebe o nome do aluno,
            //a data de nascimento e o ano em que o aluno ingressou na faculdade.
            //Crie uma classe principal, com 3 objetos, cada um instanciando a classe com
            //um construtor diferente.

            Aluno aluno = new Aluno("Ricardo",45879324);

            Aluno aluno2 = new Aluno("04/08/1980");

            Aluno aluno3 = new Aluno("Maria","05/10/1982",2021);

            aluno.exibirDados();
            aluno2.exibirDados();
            aluno3.exibirDados();


        }
    }
}