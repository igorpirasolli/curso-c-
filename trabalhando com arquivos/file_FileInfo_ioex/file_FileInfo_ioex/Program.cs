using System;
using System.IO;

namespace file_FileInfo_ioex
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\igorf\OneDrive\Área de Trabalho\c# material\file1.txt";
            string targetPath = @"C:\Users\igorf\OneDrive\Área de Trabalho\c# material\file2.txt";

            try
            {
                //FileInfo fileInfo = new FileInfo(sourcePath);
                //fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine($"{line}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("an error ocurred");
                Console.WriteLine(e.Message);
                
            }
        }
    }
}