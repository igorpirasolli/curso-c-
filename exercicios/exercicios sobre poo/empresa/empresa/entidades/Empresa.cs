using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa.entidades
{
    internal class Empresa
    {
        public string Nome { get; set; }

        public List<Departamento> Departamentos { get; set; } = new List<Departamento>();

        public Empresa()
        {
        }

        public Empresa(string nome)
        {
            Nome = nome;
        }

        public void AdicionarDepartamento(Departamento departamento)
        {
            Departamentos.Add(departamento);
        }

        public void MostrarDepartamento()
        {
            Console.WriteLine($"nome da empresa: {Nome}");
            foreach (var departamento in Departamentos)
            {
                Console.WriteLine($"nome do departamento: {departamento.Nome}");
                departamento.MostrarFuncionarios();
            }
        }
    }
}
