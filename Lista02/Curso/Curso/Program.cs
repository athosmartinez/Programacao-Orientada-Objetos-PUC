using Curso; // Importando o namespace onde estão as classes

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitando ao usuário o nome do curso
            Console.WriteLine("Informe o nome do curso:");
            string nomeDoCurso = Console.ReadLine();

            // Criando uma instância da classe MeuCurso (curso)
            MeuCurso curso = new MeuCurso
            {
                Identificador = 1, // Definindo o identificador do curso
                Nome = nomeDoCurso // Definindo o nome do curso com base na entrada do usuário
            };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nInforme os detalhes da disciplina {i + 1}:");
                Disciplina disciplina = new Disciplina(); // Criando uma instância da classe Disciplina

                // Preenchendo os detalhes da disciplina com a entrada do usuário
                Console.Write("Código da Disciplina: ");
                disciplina.Codigo = int.Parse(Console.ReadLine());

                Console.Write("Nome da Disciplina: ");
                disciplina.Nome = Console.ReadLine();

                Console.Write("Número da Sala: ");
                disciplina.Sala = int.Parse(Console.ReadLine());

                Console.Write("Número do Prédio: ");
                disciplina.Predio = int.Parse(Console.ReadLine());

                Console.Write("Número de Alunos Matriculados: ");
                disciplina.NumeroAlunosMatriculados = int.Parse(Console.ReadLine());

                // Loop para adicionar alunos à disciplina
                for (int j = 0; j < disciplina.NumeroAlunosMatriculados; j++)
                {
                    Console.WriteLine($"\nInforme os detalhes do aluno {j + 1} da disciplina {i + 1}:");
                    Aluno aluno = new Aluno(); // Criando uma instância da classe Aluno

                    // Preenchendo os detalhes do aluno com a entrada do usuário
                    Console.Write("Matrícula do Aluno: ");
                    aluno.Matricula = int.Parse(Console.ReadLine());

                    Console.Write("Nome do Aluno: ");
                    aluno.Nome = Console.ReadLine();

                    Console.Write("Data de Nascimento do Aluno (yyyy-MM-dd): ");
                    string dataNascimentoAlunoS = Console.ReadLine();
                    DateOnly.TryParseExact(dataNascimentoAlunoS, "dd/MM/yyyy", out DateOnly dataNascimentoAluno);
                    aluno.DataNascimento = dataNascimentoAluno;

                    // Adicionando o aluno à lista de alunos da disciplina
                    disciplina.Alunos.Add(aluno);
                }

                // Adicionando a disciplina à lista de disciplinas do curso
                curso.Disciplinas.Add(disciplina);
            }

            // Informando que o curso foi criado com sucesso
            Console.WriteLine("\nCurso criado com sucesso!\n");

            // Chamando o método para imprimir os detalhes do curso e suas disciplinas
            curso.ImprimirDetalhes();
        }
    }
}
