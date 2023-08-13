using Questao3;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de funcionarios que você ira cadastrar: ");
            int n = int.Parse(Console.ReadLine());

            Funcionario[] funcionarios = new Funcionario[n];

            for (int i = 0; i < n; i++)
            {
                Funcionario.CadastrarFuncionarios(funcionarios, i);
            }

            Console.WriteLine("Digite o nome do departamento no qual você deseja saber os funcionarios: ");
            string departamentoEscolhido = Console.ReadLine().Trim();
            if (Enum.TryParse<Departamento>(departamentoEscolhido, true, out Departamento departamento))
            {
                Funcionario.ImprimirFuncionario(departamento, funcionarios);
            }
            else
            {
                Console.WriteLine("Departamento não existente.");
            }
        }
    }
}

