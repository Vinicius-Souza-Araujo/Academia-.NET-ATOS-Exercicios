using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    internal class Aluno
    {
        private string _nome;
        private int _matricula;

        public Aluno()
        {
            
        }

        public string Nome {
            get { return _nome; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("O nome não pode ser vazio!");
                }
                else { _nome = value; }
            }
        }

        public int Matricula {
            get { return _matricula; }
            set {
                if(value <= 0)
                {
                    Console.WriteLine("Matricula só pode ser positiva!");
                }
                else
                {
                    _matricula = value;
                }
            }
        }
    }
}
