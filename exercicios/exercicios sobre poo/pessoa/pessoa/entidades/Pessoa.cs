using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pessoa.entidades
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set;}

        public Endereco Endereco { get; set; }

        public Pessoa(string nome, int idade, Endereco endereco)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Nome: {Nome}, idade: {Idade}\n" +
                $"Rua: {Endereco.Rua}, Cidade: {Endereco.Cidade} e estado: {Endereco.Estado}");
        }
    }
}
