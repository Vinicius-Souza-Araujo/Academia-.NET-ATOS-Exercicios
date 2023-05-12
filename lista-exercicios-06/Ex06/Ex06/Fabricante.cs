using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    internal class Fabricante
    {
        private string _nome;
        private string _endereco;
        private string _cidade;

        public Fabricante()
        {
        }

        public string Nome
        {
            get { return _nome; }
            set
            {

                if (value == "")
                {
                    Console.WriteLine("Valor do nome do fabricante não pode ser vazio!");
                }
                else
                {
                    _nome = value;
                }

            }
        }
        public string Endereco { get; set; }
        public string Cidade { get; set;}
    }
}
