using turma.entidades;

namespace turma
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("igor pirasoli", 2024);
            Aluno aluno2 = new Aluno("isabelle pirasoli", 2025);

            Turma turma = new Turma("os peaky blinders");
            turma.AdicionarAlunos(aluno1);
            turma.AdicionarAlunos(aluno2);

            turma.MostrarAlunos();
        }
    }
}