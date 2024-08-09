using funcionario.entidades;

namespace funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario gerente = new Gerente("igor pirasoli", 2500.00, 500.00);
            gerente.MostrarDetalhes();
        }
    }
}