using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produtos_ex.entidades
{
    internal class ImportedProduct : Product
    {
        public double CustomFree { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customFree) : base (name, price)
        {
            CustomFree = customFree;
        }

        public override string priceTag()
        {
            return $"{Name} {Price:c} (Customs fee : {totalPrice():c})";
        }

        public double totalPrice()
        {
            return Price + CustomFree;
        }
    }
}
