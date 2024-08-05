using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_heranca_poli.entidades
{
    internal class OutsourcedEmployee : Employee
    {
        public double AddtionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHours, double addtionalCharge) : base(name, hours, valuePerHours)
        {
            AddtionalCharge = addtionalCharge;
        }

        public override double payment()
        {
            return base.payment() + 1.1 * AddtionalCharge;

        }
    }
}
