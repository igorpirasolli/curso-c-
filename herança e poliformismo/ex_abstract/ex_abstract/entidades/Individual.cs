using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_abstract.entidades
{
    internal class Individual : TaxPayer
    {
        public double HealtExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healtExpenditures) : base (name, healtExpenditures)
        {
            HealtExpenditures = healtExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome >= 20000.0)
            {
               return AnualIncome * 0.25 - HealtExpenditures * 0.5;

            }
            else
            {
                return AnualIncome * 0.15 - HealtExpenditures * 0.5;
            }
           
        }
    }
}
