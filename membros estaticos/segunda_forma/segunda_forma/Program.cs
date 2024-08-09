namespace segunda_forma
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circunferencia = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferencia = {circunferencia:n}");
            Console.WriteLine($"Volume = {volume:n}");
            Console.WriteLine($"pi = {Calculadora.pi}");


        }
    }
}