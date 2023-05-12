using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    internal class Produto
    {
        private string _nome;
        private Fabricante _fabricante;
        private double _preco;

        public Produto()
        {
            
        }

        public string Nome { get { return _nome; } set {

                if (value == "") {
                    Console.WriteLine("Valor do nome do produto não pode ser vazio!");
                }
                else
                {
                    _nome = value;
                }
                
            }
        }

        public Fabricante Fabricante { get {  return _fabricante; } set {  _fabricante = value; } }

        public double Preco { get {  return _preco; } set { if (value > 0) { _preco = value; } } }
    }
}
