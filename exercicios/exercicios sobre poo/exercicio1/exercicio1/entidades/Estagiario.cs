using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1.entidades
{
    internal class Estagiario : Funcionario
    {
        public int Duracao { get; set; }

        public Estagiario(string nome, int id, double salario, int duracao) : base(nome, id, salario)
        {
            Duracao = duracao;
        }
        public double CalcularSalarioAnual()
        {
            return Salario * 12.0;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"salario anual: {CalcularSalarioAnual():c}\nduraçao do estagio: {Duracao} meses");
        }
    }
}
