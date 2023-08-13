using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    internal class Funcionario
    {

        public int Matricula { get; set; }
        public string Nome { get; set; }
        public Departamento Departamento { get; set; }
        public float Salario { get; set; }
        public DateOnly DataAdmissao { get; set; }

        public Funcionario(int matricula, string nome, Departamento departamento, float salario, DateOnly dataAdmissao)
        {
            Matricula = matricula;
            Nome = nome;
            Departamento = departamento;
            Salario = salario;
            DataAdmissao = dataAdmissao;
        }

        public static void CadastrarFuncionarios(Funcionario[] funcionarios, int n)
        {
            Console.WriteLine("Digite a matricula do funcionario: ");
            int matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do funcionario: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o departamento do funcionario: Vendas, Closer, Financeiro, RH, TI");
            string departamentoEscolhido = Console.ReadLine().Trim();
            if (Enum.TryParse<Departamento>(departamentoEscolhido, true, out Departamento departamento))
            {
                Console.WriteLine("Departamento: " + departamento);

                Console.WriteLine("Digite o salario do funcionario: ");
                float salario = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a data de admissão do funcionario: ");
                string data = Console.ReadLine();

                if (DateOnly.TryParseExact(data, "dd/MM/yyyy", out DateOnly dataAdmissao))
                {
                    Console.WriteLine("Data de admissão: " + dataAdmissao);
                    Console.WriteLine("Funcionario: " + (n + 1) + " cadastrado.");

                    funcionarios[n] = new Funcionario(matricula, nome, departamento, salario, dataAdmissao);
                }
                else
                {
                    Console.WriteLine("Formato de data inválido.");
                }
            }
            else
            {
                Console.WriteLine("Departamento inválido.");
            }
        }
        public static void ImprimirFuncionario(Departamento departamento, Funcionario[] funcionarios)
        {
            foreach (var funcionario in funcionarios)
            {
                if (funcionario != null && funcionario.Departamento == departamento)
                {
                    Console.WriteLine($"Matrícula: {funcionario.Matricula}, Nome: {funcionario.Nome}, Salário: {funcionario.Salario}, Data de Admissão: {funcionario.DataAdmissao}");
                }
            }
        }
    }
}




