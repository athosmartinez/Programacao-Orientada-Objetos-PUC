using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Questao4;

namespace Questao4
{
    internal class DepedenteSocio
    {
        public int NumeroContaDependente { get; set; }
        public Socios Socio { get; set; }

        public string Nome { get; set; }
        public DateOnly DataNascimento { get; set; }

        public DepedenteSocio(int numeroContaDependente, Socios socio, string nome, DateOnly dataNascimento)
        {
            NumeroContaDependente = numeroContaDependente;
            Socio = socio;
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public static void AdicionarDependente(Socios socios)
        {
            Console.WriteLine("Digite o numero de dependentes que esse socio terá: ");
            int numeroDependentes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroDependentes; i++)
            {
                Console.WriteLine("Digite o nome do dependente: ");
                string Nome = Console.ReadLine();

                Console.WriteLine("Digite a data de nascimento do dependente: ");
                string DataNascimentoString = Console.ReadLine();

                if (DateOnly.TryParseExact(DataNascimentoString, "dd/MM/yyyy", out DateOnly DataNascimento))
                {
                    Console.WriteLine("O número da cota do Dependente é o número da cota do seu socio com o número 00 no final.");
                    string NumeroCotaDependenteString = socios.NumeroCota.ToString() + "00";
                    int NumeroContaDependente = int.Parse(NumeroCotaDependenteString);
                    Console.WriteLine("O numero da conta do dependenteé: " + NumeroCotaDependenteString);
                    DepedenteSocio dependenteSocio = new DepedenteSocio(NumeroContaDependente, socios, Nome, DataNascimento);
                }
                else
                {
                    Console.WriteLine("Formato de data inválido.");
                }
            }
        }

    }
}
