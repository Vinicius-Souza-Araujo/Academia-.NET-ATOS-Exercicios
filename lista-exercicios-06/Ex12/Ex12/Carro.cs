using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class Carro
    {
        private string _modelo;
        private int _ano;
        private int _velocidade;

        public Carro()
        {
            
        }

        public string Modelo { get { return _modelo; } set { _modelo = value; } }
        public int Ano { get { return _ano; } set { _ano = value; } }
        public int Velocidade { get {  return _velocidade; } set { _velocidade = value; } }

        public void Acelerar() { 
            _velocidade = _velocidade + 10;
        }

        public void Frear()
        {
            if(_velocidade > 0)
            {
                _velocidade = _velocidade - 10;
            }
            
        }
        
    }
}
