using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1.entidades
{
    internal class Empresa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();

        public Empresa(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        public void AdicionarFuncionarios( Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        public void MostrarFuncionarios()
        {
            {
                Console.WriteLine(Nome + ", " + Endereco);
                Console.WriteLine("funcionarios:");
                foreach (var funcionario in Funcionarios)
                {
                    Console.WriteLine($"funcionario adicionado: id: {funcionario.Id}, {funcionario.Nome}");
                }
            }
        }
        
    }
}
