using exercicio3.entidades;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            IPagamento cartaoDeCredito = new CartaoDeCredito();
            cartaoDeCredito.ProcessarPagamento(100.00);
            cartaoDeCredito.CancelarPagamento(100.00);

            IPagamento paypal = new Paypal();
            paypal.ProcessarPagamento(100.00);
            paypal.CancelarPagamento(100.00);

            IPagamento tranferenciaBancaria = new TransferenciaBancaria();
            tranferenciaBancaria.ProcessarPagamento(100.00);
            tranferenciaBancaria.CancelarPagamento(100.00);
        }
    }
}