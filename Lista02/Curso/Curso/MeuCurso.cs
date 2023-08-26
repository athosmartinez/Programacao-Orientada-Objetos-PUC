using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    internal class MeuCurso
    {

        public int Identificador { get; set; }
        public string Nome { get; set; }
        public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();

        public MeuCurso()
        {
        }

        public void ImprimirDetalhes()
        {
            Console.WriteLine($"Curso: {Nome}");
            Console.WriteLine("Disciplinas:");

            foreach (var disciplina in Disciplinas)
            {
                Console.WriteLine($"  Código: {disciplina.Codigo}");
                Console.WriteLine($"  Nome: {disciplina.Nome}");
                Console.WriteLine($"  Sala: {disciplina.Sala}");
                Console.WriteLine($"  Prédio: {disciplina.Predio}");
                Console.WriteLine($"  Número de Alunos Matriculados: {disciplina.NumeroAlunosMatriculados}");
                Console.WriteLine("  Alunos Matriculados:");

                foreach (var aluno in disciplina.Alunos)
                {
                    Console.WriteLine($"    Matrícula: {aluno.Matricula}");
                    Console.WriteLine($"    Nome: {aluno.Nome}");
                    Console.WriteLine($"    Data de Nascimento: {aluno.DataNascimento.ToShortDateString()}");
                }
            }
        }
    }
}
