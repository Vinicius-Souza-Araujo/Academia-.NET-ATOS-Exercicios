using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    internal class Autor
    {
        private string _nome;

        public Autor()
        {
            
        }

        public string Nome { get { return _nome; } set { _nome = value; }  }
    }
}
