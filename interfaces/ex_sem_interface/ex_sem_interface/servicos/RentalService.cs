using ex_sem_interface.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ex_sem_interface.servicos
{
    internal class RentalService
    {
        public double PricePerHours { get; private set; }
        public double PricePerDay { get; set; }

        private BrazilTaxService BrazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHours, double pricePerDay)
        {
            PricePerHours = pricePerHours;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice (CarRental carRental)
        {
            TimeSpan Duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (Duration.TotalHours <= 12.0 )
            {
                basicPayment = PricePerHours * Math.Ceiling(Duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(Duration.TotalDays);
            }

            double tax = BrazilTaxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
