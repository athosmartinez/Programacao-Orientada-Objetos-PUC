using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    internal class ContaBanco
    {
        private int NumeroConta { get; set; }
        public double SaldoConta { get; private set; }

        public ContaBanco(int numeroConta, double saldoConta)
        {
            NumeroConta = numeroConta;
            SaldoConta = saldoConta;
        }

        public int GetNumeroConta() { return this.NumeroConta; }

        public double GetNumeroSaldo() { return this.SaldoConta; }

        public void Depositar(double valor)
        {
            SaldoConta += valor;
        }

        public void Sacar(double valor)
        {
            if(valor <= SaldoConta)
            {
                SaldoConta -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }


    }
}
