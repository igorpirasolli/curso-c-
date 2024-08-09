using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa.entidades
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }
    }
}
