namespace valor_nulo
{
    class Program {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;
            
            //GetValueOrDefault()
            Console.WriteLine(x.GetValueOrDefault(10.0));
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //hasvalue
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else 
            { 
                Console.WriteLine("x é um valor nulo ");  
            }
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("y é um valor nulo");
            }

        }
    }
}