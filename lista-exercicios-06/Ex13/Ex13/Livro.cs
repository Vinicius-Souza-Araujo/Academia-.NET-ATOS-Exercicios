using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    internal class Livro
    {
        private string _titulo;
        private Autor _autor;

        public Livro()
        {
            
        }

        public string Titulo { get { return _titulo; } set { _titulo = value; } }
        public Autor Autor { get { return _autor; } set { _autor = value; } }

        public void MostrarDados()
        {
            Console.WriteLine("Titulo: " + _titulo);
            Console.WriteLine("Autor: " + _autor.Nome);
        }
    }
}
