using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2.entidades
{
    internal class Filme : Midia
    {
        public string Diretor { get; set; }
        public int Duracao { get; set; }

        public Filme(string titulo, int ano, string diretor, int duracao) : base(titulo, ano)
        {
            Diretor = diretor;
            Duracao = duracao;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"diretor: {Diretor}\n" +
                $"Duraçao: {Duracao} minutos");
        }
    }
}
