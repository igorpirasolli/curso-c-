using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2.entidades
{
    internal class Midia
    {
        public string Titulo { get; set; }
        public int Ano { get; set; }

        public Midia(string titulo, int ano)
        {
            Titulo = titulo;
            Ano = ano;
        }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"titulo: {Titulo}" +
                $"\nAno: {Ano}");
        }
    }
}
