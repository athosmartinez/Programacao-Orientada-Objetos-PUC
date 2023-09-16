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
        public string TitularConta { get; private set; }
        public double SaldoConta { get; private set; }

        public ContaBanco(string titularConta, double saldoConta)
        {
            TitularConta = titularConta;
            SaldoConta = saldoConta;
        }

        public void SetNumeroConta(int numeroConta)
        {
            this.NumeroConta = numeroConta;
        }

        public int GetNumeroConta() { return this.NumeroConta; }
    }
}
