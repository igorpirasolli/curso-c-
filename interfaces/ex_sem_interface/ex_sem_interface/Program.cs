using ex_sem_interface.entidades;
using ex_sem_interface.servicos;
using System.Globalization;

namespace ex_sem_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter rental data:");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();

            Console.Write("pickup(dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime end = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("enter price per hours");
            double hours = double.Parse(Console.ReadLine());
            Console.Write("enter price per day: ");
            double day = double.Parse(Console.ReadLine());

            
            
            RentalService rentalService = new RentalService(hours, day);
            CarRental carRental = new CarRental(start, end, new Vehicle(carModel));

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Invoice);



        }
    }
}