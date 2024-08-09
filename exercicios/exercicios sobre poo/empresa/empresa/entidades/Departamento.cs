using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa.entidades
{
    internal class Departamento
    {
        public string Nome { get; set; }

        public List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();

        public Departamento()
        {
        }

        public Departamento(string nome)
        {
            Nome = nome;
        }

        public void AdicionarFuncionarios(Funcionario funcionarios)
        {
            Funcionarios.Add(funcionarios);
        }

        public void MostrarFuncionarios()
        {
            foreach (var funcionario in Funcionarios)
            {
                Console.WriteLine($"nome do funcionario: {funcionario.Nome}, salario: {funcionario.Salario}");
            }
        }
    }
}
