using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Boxing
        int numero = 123;
        object caixa = numero;  // Boxing
        Console.WriteLine($"Valor boxado: {caixa}");

        // Unboxing
        int desboxado = (int)caixa;  // Unboxing
        Console.WriteLine($"Valor desboxado: {desboxado}");

        // Tentativa de unboxing incorreto
        try
        {
            object texto = "Este é um texto";
            int numeroIncorreto = (int)texto;  // Isso causará uma exceção InvalidCastException
        }
        catch (InvalidCastException ex)
        {
            Console.WriteLine($"Erro de conversão: {ex.Message}");
        }
    }
}
