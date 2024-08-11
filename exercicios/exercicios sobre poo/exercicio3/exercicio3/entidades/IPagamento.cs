using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3.entidades
{
    interface IPagamento
    {
        void ProcessarPagamento(double valor);
        void CancelarPagamento(double valor);
    }
}
