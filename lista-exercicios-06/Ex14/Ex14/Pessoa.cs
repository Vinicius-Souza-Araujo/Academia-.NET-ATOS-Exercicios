using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    internal class Pessoa
    {
        private string _nome;
        private int _idade;
        private float _altura;

        public Pessoa()
        {
            
        }

        public string Nome { get { return _nome; } set {  _nome = value; } }
        public int Idade { get { return _idade; } set { _idade = value; } }
        public float Altura { get { return _altura; } set { _altura = value; } }

        public void ImprimePessoa()
        {
                Console.WriteLine("Nome: " + _nome);
                Console.WriteLine("Idade: " + _idade);
                Console.WriteLine("Altura: " + _altura);
        }
    }
}
