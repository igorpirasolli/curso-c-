using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produtos_ex.entidades
{
    internal class UsedProduct : Product
    {
        public DateTime Date { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime date) : base (name, price)
        {
            Date = date;
        }

        public override string priceTag()
        {
            return $"{Name} (used) {Price:c} (manufacture date: {Date.ToString("dd/MM/yyyy")}) ";
        }
    }
}
