using System;
using System.Collections.Generic;

namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };

            // Adicionando elementos
            numeros.Add(60);
            numeros.AddRange(new int[] { 70, 80, 90 });

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            // Acessando elementos
            Console.WriteLine($"Primeiro número: {numeros[0]}");
            Console.WriteLine($"Último número: {numeros[numeros.Count - 1]}");

            numeros[1] = 25;

            // Removendo elementos
            numeros.Remove(30);
            numeros.RemoveAt(2);

            // Verificando a presença de um elemento
            bool contemVinte = numeros.Contains(20);
            Console.WriteLine($"A lista contém o número 20: {contemVinte}");

            // Ordenando a lista
            numeros.Sort();
            Console.WriteLine("Lista ordenada:");

            // Iterando sobre a lista
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine($"quantidade de elementos {numeros.Count}");
            numeros.Clear();
            Console.WriteLine($"A lista tem {numeros.Count} elementos após limpar.");
        }
    }
}