namespace properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("tv", 500.00, 10);

            p.Preco = 600.00;
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
            Console.ReadLine();
        }
    }
}