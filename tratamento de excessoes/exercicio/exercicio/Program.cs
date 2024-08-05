using exercicio.entidades;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter account data: ");
                Console.Write("number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("holder: ");
                string holder = Console.ReadLine();
                Console.Write("initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("withdraw limit: ");
                double limitWithdraw = double.Parse(Console.ReadLine());

                Console.Write("enter amount for witshdraw: ");
                double amount = double.Parse(Console.ReadLine());

                Account conta = new Account(number, holder, balance, limitWithdraw);
                conta.withDraw(amount);

                Console.WriteLine(conta);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}