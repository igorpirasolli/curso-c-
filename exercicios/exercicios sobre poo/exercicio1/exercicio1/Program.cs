

using exercicio1.entidades;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario("carlos souza", 1, 1500.0);
            Funcionario funcionario2 = new Funcionario("ana lima", 2, 2500.0);
            Funcionario funcionario3 = new Funcionario("joao pedro", 3, 3500.0);

            Empresa empresa = new Empresa("softscore", "rua queluz");
            empresa.AdicionarFuncionarios(funcionario1);
            empresa.AdicionarFuncionarios(funcionario2);
            empresa.AdicionarFuncionarios(funcionario3);

            empresa.MostrarFuncionarios();

            Funcionario gerente = new Gerente("carlos souza", 1, 1500.0, 20.000);
            Funcionario desenvolvedor = new Desenvolvedor("ana lima", 2, 2500.0, "C#");
            Funcionario estagiario = new Estagiario("joao pedro", 3, 3500.0, 6);

            Console.WriteLine("funcionarios: ");
            
            gerente.Mostrar();
            desenvolvedor.Mostrar();
            estagiario.Mostrar();

        }
    }
}