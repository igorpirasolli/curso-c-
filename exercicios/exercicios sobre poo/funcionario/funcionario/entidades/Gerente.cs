using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario.entidades
{
    internal class Gerente : Funcionario
    {
        

        public double Bonus { get; set; }

        public Gerente(string nome, double salario, double bonus) : base(nome, salario)
        {
            Bonus = bonus;
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"o funcionario e agora gerente {Nome}, tem o salario de {Salario:c}, mas com a promoçao, ele ganha um bonus de {Bonus:c}");
        }



    }
}
