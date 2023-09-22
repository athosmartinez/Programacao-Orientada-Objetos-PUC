using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    static class Banco
    {
        private static List<ContaBanco> contas = new List<ContaBanco>();
        private static int quantidadeContas = 0;

        public static int QuantidadeContas
        {
            get
            {
                return quantidadeContas;
            }
        }
        public static double SaldoTotal
        {
            get
            {
                double SaldoTotal = 0;
                foreach (ContaBanco conta in contas)
                {
                    SaldoTotal += conta.SaldoConta;
                }
                return SaldoTotal;
            }
        }

        public static bool ValidarNumeroConta(int numeroConta)
        {
            return numeroConta >= 1 && numeroConta <= 999;
        }

        public static ContaBanco CriarConta(int numeroConta, double saldoIncial)
        {
            if(quantidadeContas >= 10)
            {
                Console.WriteLine("Número máximo de contas atigido.");
                return null;
            }
            if(!ValidarNumeroConta(numeroConta))
            {
                Console.WriteLine("Numero de conta inválido!");
                return null;

            }

            ContaBanco novaConta = new ContaBanco(numeroConta, saldoIncial);
            contas.Add(novaConta);
            quantidadeContas++;
            return novaConta;
        }
    }
}
