using System; // Importa o namespace System, necessário para usar a classe DateOnly.

namespace Questao3 // Namespace para a classe Funcionario.
{
    internal class Funcionario
    {
        // Propriedades da classe Funcionario.
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public Departamento Departamento { get; set; }
        public float Salario { get; set; }
        public DateOnly DataAdmissao { get; set; }

        // Construtor da classe Funcionario.
        public Funcionario(int matricula, string nome, Departamento departamento, float salario, DateOnly dataAdmissao)
        {
            Matricula = matricula;
            Nome = nome;
            Departamento = departamento;
            Salario = salario;
            DataAdmissao = dataAdmissao;
        }

        // Método estático para cadastrar funcionários.
        public static void CadastrarFuncionarios(Funcionario[] funcionarios, int n)
        {
            Console.WriteLine("Digite a matrícula do funcionário: ");
            int matricula = int.Parse(Console.ReadLine());

            // Solicita informações para preencher o cadastro do funcionário.
            Console.WriteLine("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o departamento do funcionário: Vendas, Closer, Financeiro, RH, TI");
            string departamentoEscolhido = Console.ReadLine().Trim();
            if (Enum.TryParse<Departamento>(departamentoEscolhido, true, out Departamento departamento))
            {
                Console.WriteLine("Departamento: " + departamento);

                Console.WriteLine("Digite o salário do funcionário: ");
                float salario = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a data de admissão do funcionário (formato: dd/MM/yyyy): ");
                string data = Console.ReadLine();

                if (DateOnly.TryParseExact(data, "dd/MM/yyyy", out DateOnly dataAdmissao))
                {
                    Console.WriteLine("Data de admissão: " + dataAdmissao);
                    Console.WriteLine("Funcionário " + (n + 1) + " cadastrado.");

                    // Cria uma nova instância de Funcionario e adiciona ao array.
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

        // Método estático para imprimir informações de funcionários por departamento.
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