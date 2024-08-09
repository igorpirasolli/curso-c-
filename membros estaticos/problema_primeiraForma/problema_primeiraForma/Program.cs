namespace problema_primeiraForma
{
    class Program
    {
        static double pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("entre com o valor do raio:");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circunferencia(raio);
            Console.WriteLine($"circunferencia : {circ}");

            double volume = Volume(raio);
            Console.WriteLine($"Volume: {volume:n}");



        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0 * pi * Math.Pow(raio, 3);
        }

        static double Circunferencia(double raio)
        {
            return 2 * pi * raio;
        }
    }
}