namespace stru_ct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            Console.WriteLine(p); // erro: variável não atribuída
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point(); // nao precisa de varialvel atribuida
            Console.WriteLine(p);
        }
    }
}