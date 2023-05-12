using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    internal class ContaBancaria
    {
        private int _numeroConta;
        private string _titular;
        private double _saldo;
        private double _limite;

        public ContaBancaria()
        {
            
        }

        public int NumeroConta { get { return _numeroConta; } set { _numeroConta = value; } }

        public string Titular { 
            get {  
                return _titular;
            } 
            set {
                if (!string.IsNullOrEmpty(value)) {
                    _titular = value.ToUpper();
                }
            } 
        }

        public double Saldo { get {  return _saldo; } }

        public double Limite {
            get {  
                return _limite;
            } 
            set {
                if (value > 0) { _limite = value; }
            }
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo = valor + _saldo;
            }
            else
            {
                Console.WriteLine("Depósito não efetuado!");
            }

        }

        public bool Sacar(double valor)
        {
            if(valor <= (_saldo + Limite ))
            {
                _saldo = _saldo - valor;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
