using System;
using System.IO;

string sourcePath = @"C:\Users\igorf\OneDrive\Área de Trabalho\c# material\file1.txt";
string targetPath = @"C:\Users\igorf\OneDrive\Área de Trabalho\c# material\file2.txt";

try
{
    string[] lines = File.ReadAllLines(sourcePath);

    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
    }
}
catch(IOException e )
{
    Console.WriteLine("an error ocurred");
    Console.WriteLine(e.Message);
}