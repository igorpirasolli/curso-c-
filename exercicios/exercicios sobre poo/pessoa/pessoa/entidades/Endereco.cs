using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pessoa.entidades
{
    internal class Endereco
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco() { }

        public Endereco(string rua, string cidade, string estado)
        {
            Rua = rua;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
