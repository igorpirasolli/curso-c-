using metodos_abstratos.entidades.Enun;
using metodos_abstratos.entidades;

namespace metodos_abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the number of sahpes: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"shape #{i + 1} data: ");
                Console.Write("rectangule or Circle (r/c): ");
                char respost = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (respost == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    list.Add(new Rectangulo(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(radius, color));
                }
                Console.WriteLine();

            }

            Console.WriteLine();
            Console.WriteLine("Shape Areas: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine($"{shape.Area():n}");
            }
        }
    }
}