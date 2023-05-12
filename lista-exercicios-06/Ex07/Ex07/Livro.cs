using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    internal class Livro
    {
        private string _titulo;
        private Autor _autor;

        public Livro()
        {
            
        }

        public string Titulo {
            get { return _titulo; }
            set {
                if (value != "")
                {
                    _titulo = value;
                }
                else { Console.WriteLine("O titulo não pode ser vazio!"); }

            }
        }

        public Autor Autor { get { return _autor; } set { _autor = value; } }
    }
}
