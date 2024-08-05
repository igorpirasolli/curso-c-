using exercicio.entidades.excessoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio.entidades
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public double WithDrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withDraw)
        {

            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDraw;
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }

        public void withDraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }
            if (Balance < amount)
            {
                throw new DomainException("Withdraw error: Not enough balance");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return $"New balance: {Balance:c}";
        }


    }
}
