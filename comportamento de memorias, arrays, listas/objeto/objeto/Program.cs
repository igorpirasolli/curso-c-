using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numero = 42;
        string texto = "Olá, mundo!";
        DateTime data = DateTime.Now;

        // Boxing
        object objNumero = numero;
        object objTexto = texto;
        object objData = data;

        // Utilizando métodos da classe object
        Console.WriteLine(objNumero.ToString());  // Output: 42
        Console.WriteLine(objTexto.ToString());   // Output: Olá, mundo!
        Console.WriteLine(objData.ToString());    // Output: Data e hora atuais

        // Unboxing
        int desboxadoNumero = (int)objNumero;
        string desboxadoTexto = (string)objTexto;
        DateTime desboxadoData = (DateTime)objData;

        Console.WriteLine($"Número desboxado: {desboxadoNumero}");
        Console.WriteLine($"Texto desboxado: {desboxadoTexto}");
        Console.WriteLine($"Data desboxada: {desboxadoData}");
    }
}
