using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3.entidades
{
    internal class Paypal : IPagamento
    {
        public void CancelarPagamento(double valor)
        {
            Console.WriteLine($"cancelando pagamento de {valor:c} com Paypal");
            
        }

        public void ProcessarPagamento(double valor)
        {
            Console.WriteLine($"processando pagamento de {valor:c} com PayPal");
        }
    }
}
