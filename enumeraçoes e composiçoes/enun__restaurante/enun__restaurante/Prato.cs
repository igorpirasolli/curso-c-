using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enun__restaurante
{
    internal class Prato
    {
        public string NomeDoPrato { get; set; }
        public TipoPrato Tipo { get; set; }
        public double Preco { get; set; }

        public Prato(string nomeDoPrato, TipoPrato tipo, double preco)
        {
            NomeDoPrato = nomeDoPrato;
            Tipo = tipo;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"{NomeDoPrato} ({Tipo}): R${Preco:F2}"; ;
        }
    }
}
