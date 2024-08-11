using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1.entidades
{
    internal  class Funcionario
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public double Salario { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, int id, double salario)
        {
            Nome = nome;
            Id = id;
            Salario = salario;
        }
        
        public virtual void Mostrar()
        {
            Console.WriteLine($"{Nome}, id: {Id}");
        }
        
            
        


    }
}
