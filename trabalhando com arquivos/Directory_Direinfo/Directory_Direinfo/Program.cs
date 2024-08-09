using System;
using System.IO;
using System.Collections.Generic;

string path = @"C:\Users\igorf\OneDrive\Área de Trabalho\myfolder";

try
{
    IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine($"Folders");
    foreach ( string folderName in folder )
    {
        Console.WriteLine(folderName);
    }
    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("files: ");
    foreach ( string file in files ) { Console.WriteLine(file); }

    Directory.CreateDirectory(@"C:\Users\igorf\OneDrive\Área de Trabalho\myfolder\newfolder");
    Directory.CreateDirectory(path + @"\igor");
}
catch (IOException e)
{
    Console.WriteLine("an error ocurred");
    Console.WriteLine(e.Message);
}