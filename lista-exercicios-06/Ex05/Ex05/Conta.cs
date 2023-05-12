using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    internal class Conta
    {
        private int _numero;
        private double _saldo;
        private double _limite;

        public int Numero { get { return _numero; } }

        public double Saldo { 
            get {  
                return _saldo;
            } 
            set {
                if (value >= 0) { _saldo = value; }
                
            }
        }

        public double Limite { 
            get {
                return _limite; 
            } set {
                if (value > 0) { _limite = value; }
                 
            } 
        }
    }
}
