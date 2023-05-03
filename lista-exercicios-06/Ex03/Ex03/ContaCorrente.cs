using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class ContaCorrente
    {
        public double saldo;


        public void definirSaldoInicial(double saldo)
        {

            this.saldo = saldo;

        }

        public void depositar(double deposito)
        {
            this.saldo = this.saldo + deposito;
        }

        public bool sacar(double saque)
        {
            if(this.saldo >= saque) { 
                this.saldo = this.saldo - saque;
                return true;
            }
            return false;
            
        }

        public void consultarSaldo()
        {
            Console.WriteLine("Saldo disponível: " + this.saldo);
        }

    }
}
