using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class Pessoa
    {
        private string _nome;
        private int _idade;

        public Pessoa()
        {
        }

        public string Nome
        {

            get
            {
                return _nome;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("O nome não pode ser vazio!");
                }
                else { _nome = value; }
            }

        }
        public int Idade { 
            
            get { return _idade; }

            set { 
                if (value <= 0) {
                    Console.WriteLine("A idade não pode ser 0 ou menor que 0!");
                }
                else { _idade = value; }
               
            }
        }

               

    }
}
