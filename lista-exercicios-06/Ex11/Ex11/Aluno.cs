using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    internal class Aluno
    {
        private string _nome;
        private double _nota1;
        private double _nota2;
        private double _nota3;

        public Aluno()
        {
            
        }

        public string Nome { get { return _nome; } set { _nome = value; } }
        public double Nota1 { get { return _nota1; } set { _nota1 = value; } }
        public double Nota2 { get { return _nota2; } set { _nota2 = value; } }
        public double Nota3 { get { return _nota3; } set { _nota3 = value; } }

        public bool VeriicarAprovacao() {
            double media = (_nota1 + _nota2 + _nota3) / 3; 

            if (media >= 6)
            {
                return true;
            }
            return false;
        }
    }
}
