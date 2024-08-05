using ex_abstract.entidades;

namespace ex_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"tax payer #{i + 1} data:");
                Console.Write("individual or company (i/c): ");
                char resp = char.Parse(Console.ReadLine());

                Console.Write("name: ");
                string name = Console.ReadLine();
                Console.Write("anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (resp == 'i')
                {
                    Console.Write("health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }

                else
                {
                    Console.Write("number of employees: ");
                    int numerOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numerOfEmployees));
                }

            }
            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("taxed paid:");
            foreach (TaxPayer taxPayer in list)
            {
                double tax = taxPayer.Tax();
                Console.WriteLine($"{taxPayer.Name}: {tax:c}");
                sum += tax;
            }
            Console.WriteLine($"Total taxes: {sum:c}");
        }
    }
}