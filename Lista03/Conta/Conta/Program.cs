using System;
using Conta;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBanco conta1 = Banco.CriarConta(1, 1000.0);
            ContaBanco conta2 = Banco.CriarConta(2, 2000.0);
            ContaBanco conta3 = Banco.CriarConta(3, 3000.0);

            if (conta1 != null)
            {
                conta1.Depositar(500.0);
                conta1.Sacar(200.0);
            }

            if (conta2 != null)
            {
                conta2.Depositar(1000.0);
                conta2.Sacar(300.0);
            }

            if (conta3 != null)
            {
                conta3.Depositar(1500.0);
                conta3.Sacar(600.0);
            }

            Console.WriteLine("Quantidade de contas: " + Banco.QuantidadeContas);
            Console.WriteLine("Saldo total: " + Banco.SaldoTotal);
            Console.WriteLine($"Pode criar ainda {10 - Banco.QuantidadeContas} contas.");

        }
    }
}