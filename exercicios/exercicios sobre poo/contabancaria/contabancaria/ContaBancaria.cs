using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contabancaria
{
    internal class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string titular, double saldo)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void sacar(double valor)
        {
            Saldo -= valor;
        }

        public void mostrarSaldo()
        {
            Console.WriteLine($"meu saldo: {Saldo}");
        }
    }
}
