using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2.entidades
{
    internal class Musica : Midia
    {
        public string Artista { get; set; }

        public int Duracao { get; set; }

        public Musica(string titulo, int ano, string artista, int duracao) : base(titulo, ano)
        {
            Artista = artista;
            Duracao = duracao;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Artista: {Artista}\n" +
                $"duraçao: {Duracao} segundos");
        }
    }
}
