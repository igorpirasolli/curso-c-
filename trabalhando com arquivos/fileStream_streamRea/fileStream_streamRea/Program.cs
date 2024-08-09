using System;
using System.IO;

namespace fileStream_streamRea
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\igorf\OneDrive\Área de Trabalho\c# material\file1.txt";
            
            StreamReader streamReader = null;

            try
            {
                
                streamReader = File.OpenText(path);
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    Console.WriteLine(line);
                }

                
            }
            catch (IOException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
                
            }
        }
    }
}