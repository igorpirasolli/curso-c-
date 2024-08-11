using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2.entidades
{
    internal class Livro : Midia
    {
        public string Autor { get; set; }
        public int Paginas { get; set; }

        public Livro(string titulo, int ano, string autor, int paginas) : base(titulo, ano) 
        {
            Autor = autor;
            Paginas = paginas;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"autor: {Autor}\n" +
                $"numero de paginas: {Paginas}");
        }
    }
}
