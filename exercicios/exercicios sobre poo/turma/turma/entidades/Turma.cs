using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turma.entidades
{
    internal class Turma
    {
        public string NomeTurma { get; set; }
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();

        public Turma()
        {
        }

        public Turma(string nomeTurma)
        {
            NomeTurma = nomeTurma;
        }

        public void AdicionarAlunos(Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        public void MostrarAlunos()
        {
            Console.WriteLine($"nome da turma: {NomeTurma}");
            foreach (var aluno in Alunos)
            {
                Console.WriteLine($"aluno: {aluno.Nome}, Matricula: {aluno.Matricula}");
            }
        }
    }
}
