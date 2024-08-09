using System;
using System.IO;

namespace usingg
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\igorf\OneDrive\Área de Trabalho\c# material\file1.txt";
            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine("an error ocurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}