using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_meto_selados.entidades
{
      internal class SavingsAccount : Account // se eu colocar o "sealed no lugar do internal, essa classe nao vai poder ser herdada"
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) // essa classe nao vai poder ser herdada por outra subclasse
        {
            base.Withdraw(amount);
            Balance -= Balance - 2;
        }
    }
}
