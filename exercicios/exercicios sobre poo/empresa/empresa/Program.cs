using empresa.entidades;

namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario ("João", 3000.00 );
            Funcionario func2 = new Funcionario ("Maria",4000.00 );

            // Criar departamento e adicionar funcionários
            Departamento depto = new Departamento ("TI");
            depto.AdicionarFuncionarios(func1);
            depto.AdicionarFuncionarios(func2);

            // Criar empresa e adicionar departamento
            Empresa empresa = new Empresa { Nome = "TechCorp" };
            empresa.AdicionarDepartamento(depto);


            empresa.MostrarDepartamento();
            

        }
    }
}