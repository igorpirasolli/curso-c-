namespace para_ms
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora Calc = new Calculadora();
            int a = 10;
            Calc.SomarNumeros(ref a);
            Console.WriteLine(a);
            
        }
    }
}