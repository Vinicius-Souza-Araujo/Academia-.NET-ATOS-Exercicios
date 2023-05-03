using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Aluno
    {
        public string nome;
        public int matricula;
        public string dataNasc;
        public int anoIngressou;

        public Aluno(string nome, int matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }

        public Aluno(string dataNasc)
        {
            this.dataNasc = dataNasc;
        }

        public Aluno(string nome, string dataNasc, int anoIngressou)
        {
            this.nome = nome;
            this.dataNasc = dataNasc;
            this.anoIngressou = anoIngressou;
        }

        public void exibirDados()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Matricula: " + this.matricula);
            Console.WriteLine("Data de Nascimento: " + this.dataNasc);
            Console.WriteLine("Ano em que o aluno ingressou na faculdade: " + this.anoIngressou);
            Console.WriteLine("");
        }
    }
}
