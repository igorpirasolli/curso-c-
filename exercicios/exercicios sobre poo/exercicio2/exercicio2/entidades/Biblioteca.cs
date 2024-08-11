using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2.entidades
{
    internal class Biblioteca
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public List<Midia> ListaDeMidias { get; set; } = new List<Midia>();

        public Biblioteca(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        public void AdicionarMidia(Midia midia)
        {
            ListaDeMidias.Add(midia);
        }

        public void MostrarMidias()
        {
            Console.WriteLine($"nome da biblioteca: {Nome}\n" +
                $"endereço: {Endereco}");
            Console.WriteLine("--------------------------------------------");
            foreach (var midi in ListaDeMidias)
            {
                midi.ExibirDetalhes();
                Console.WriteLine("----------------------------------------");
            }
        }
    }
}
