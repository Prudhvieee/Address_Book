using System;
using System.Collections.Generic;
using System.IO;
namespace Address_Book
{
    public class FileIOOperations
    {
        string path = @"E:\Studies\Bridgelabz\Fellowship--.NET\Project's\Address_Book\Log.txt";
        public void WriteToFile(List<Person_Details> data)
        {
            if (File.Exists(path))
            {
                using (StreamWriter streamWriter = File.AppendText(path))
                {
                    foreach (var contact in data)
                    {
                        streamWriter.WriteLine(contact);
                    }
                    streamWriter.Close();
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No file");
            }
            Console.WriteLine("\nSuccessfully added to Text file.");
        }
        public void ReadFromFile()
        {
            Console.WriteLine("Below are Contents of Text File");
            string lines = File.ReadAllText(path);
            Console.WriteLine(lines);
        }
    }
}
