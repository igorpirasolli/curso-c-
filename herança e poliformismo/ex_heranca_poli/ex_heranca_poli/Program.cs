using ex_heranca_poli.entidades;

namespace ex_heranca_poli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"employee #{i + 1} data:");
                Console.Write("outsourced (y/n): ");
                char outsourced = char.Parse(Console.ReadLine());

                Console.Write("name: ");
                string name = Console.ReadLine();
                Console.Write("hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("value per hours: ");
                double valuePerHours = double.Parse(Console.ReadLine());

                if (outsourced.Equals('y'))
                {
                    Console.Write("additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    Employee employee = new OutsourcedEmployee(name, hours, valuePerHours, additionalCharge);
                    employees.Add(employee);
                    //list.Add(new OutsourcedEmployee(name, hours, valuePerHours, additionalCharge); poderia ser assim tambem

                }
                else
                {
                    Employee employee = new Employee(name, hours, valuePerHours);
                    employees.Add(employee);
                    //list.Add(new Employee(name, hours, valuePerHours); poderia ser assim
                }
            }
            Console.WriteLine();
            Console.WriteLine("Payments:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name} - {employee.payment():c}");
            }

        }
    }
}