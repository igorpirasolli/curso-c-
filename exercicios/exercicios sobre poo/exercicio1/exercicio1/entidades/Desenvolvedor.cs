using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1.entidades
{
    internal class Desenvolvedor : Funcionario
    {
        public string LinguagemPrincipal { get; set; }

        public Desenvolvedor(string nome, int id, double salario, string linguagemPrincipal) : base(nome, id, salario)
        {
            LinguagemPrincipal = linguagemPrincipal;
        }

        public double CalcularSalarioAnual()
        {
            return Salario * 12.0;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"salario anual: {CalcularSalarioAnual():c}\nLinguagem principal: {LinguagemPrincipal}");
        }
    }
}
