using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4.entidades
{
    interface IVeiculo
    {
        double CalcularCusto(int dias);
        string ObterDetalhes();
    }
}
