using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1.entidades
{
    internal class Gerente : Funcionario
    {
        public double BonusAnual { get; set; }
        public Gerente(string nome, int id, double salario, double bonusAnual) : base(nome, id, salario)
        {
            BonusAnual = bonusAnual;
        }

        public double CalcularSalarioAnual()
        {
            return  Salario * 12.0 ; 
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Salario anual {CalcularSalarioAnual():c}\nbonus anual {BonusAnual}");
        }







    }
}
