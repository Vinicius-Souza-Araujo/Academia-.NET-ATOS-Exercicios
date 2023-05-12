using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    internal class Autor
    {
        private string _nome;
        public Autor()
        {
            
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != "")
                {
                    _nome = value;
                }
                else { Console.WriteLine("O nome do autor não pode ser vazio!"); }

            }
        }

    }
}
