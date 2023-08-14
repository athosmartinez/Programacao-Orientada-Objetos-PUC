using Questao3; // Importa o namespace Questao3, que contém a enumeração Departamento.
using System; // Importa o namespace System, necessário para usar a classe Console.

namespace MyApp // Namespace do aplicativo (pode variar de acordo com o nome do projeto).
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de funcionários que você irá cadastrar: ");
            int n = int.Parse(Console.ReadLine());

            Funcionario[] funcionarios = new Funcionario[n];

            for (int i = 0; i < n; i++)
            {
                Funcionario.CadastrarFuncionarios(funcionarios, i);
            }

            Console.WriteLine("Digite o nome do departamento no qual você deseja saber os funcionários: ");
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
