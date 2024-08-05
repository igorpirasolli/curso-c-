using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produtos_ex.entidades
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ImportedProduct ImportedProduct { get; set; }
        public UsedProduct Used { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag()
        {
            return $"{Name} {Price:c}";
        }
    }
}
