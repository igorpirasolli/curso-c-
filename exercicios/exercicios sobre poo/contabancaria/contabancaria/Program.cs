namespace contabancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria(2024, "igor pirasoli", 2500.00);
            conta.Depositar(500.00);
            conta.mostrarSaldo();
            conta.sacar(200.00);
            conta.mostrarSaldo();
        }
    }
}