using composicaoDeObjetos.entities;
using composicaoDeObjetos.entities.Enum;
namespace composicaoDeObejtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter departament´s name: ");
            string depName = Console.ReadLine();
            Console.WriteLine("enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("level (junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Departament dept = new Departament(depName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"enter #{i + 1} contract data: ");
                Console.WriteLine(" (DD/MM/YYYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("value per hours: ");
                double valuePerHours = double.Parse(Console.ReadLine());
                Console.Write("duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHours, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string mesEano = Console.ReadLine();
            int mes = int.Parse(mesEano.Substring(0, 2));
            int ano = int.Parse(mesEano.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Departament: {worker.Departament.Name}");
            Console.WriteLine($"income for {mesEano}: {worker.Income(mes, ano)}");





        }
    }
}