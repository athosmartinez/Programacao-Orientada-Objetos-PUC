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
                    Console.WriteLine("O numero da conta do dependente é: " + NumeroCotaDependenteString);
                    DepedenteSocio dependenteSocio = new DepedenteSocio(NumeroContaDependente, socios, Nome, DataNascimento);
                    socios.Depedentes.Add(dependenteSocio);
                }
                else
                {
                    Console.WriteLine("Formato de data inválido.");
                }
            }
        }

        public static void RemoverDependente(int NumeroContaDependente, List<DepedenteSocio> dependentes)
        {
            string NumeroContaDependeteString = NumeroContaDependente.ToString() + "00";
            int NumeroContaDependenteCerto = int.Parse(NumeroContaDependeteString);
            for (int i = 0; i < dependentes.Count; i++)
            {
                if (dependentes[i].NumeroContaDependente == NumeroContaDependenteCerto)
                {
                    dependentes.RemoveAt(i);
                    Console.WriteLine("Dependente da " + NumeroContaDependenteCerto + " apagado com sucesso.");
                    return;
                }

            }
            Console.WriteLine("Nenhum dependente com esse numero de cota encontrado.");
        }
    }
}
