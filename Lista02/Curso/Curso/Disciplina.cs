using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    internal class Disciplina
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Sala { get; set; }
        public int Predio { get; set; }
        public int NumeroAlunosMatriculados { get; set; }
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();
    }

}

