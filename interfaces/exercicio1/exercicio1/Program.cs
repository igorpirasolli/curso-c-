using exercicio1.entidades;
using exercicio1.entidades.Enums;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ishape s1 = new Circle { Radius = 2.0, Color = Color.White };
            Ishape s2 = new Rectangle { Width = 3.5, Height = 4.2, Color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}