using produtos_ex.entidades;

namespace produtos_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"product #{i + 1} data: ");
                Console.Write("Commom, used or imported: ");
                char productType = char.Parse(Console.ReadLine());
                Console.Write("name: ");
                string name = Console.ReadLine();
                Console.Write("price: ");
                double price = double.Parse(Console.ReadLine());
                if (productType == 'i')
                {
                    Console.Write("customs free: ");
                    double customFree = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, customFree));
                }
                else if (productType == 'u')
                {
                    Console.Write("manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Price tags");
            foreach (Product product in products)
            {

                Console.WriteLine(product.priceTag());
            }
        }
    }
}