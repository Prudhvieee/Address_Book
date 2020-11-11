using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Address_Book
{
    public class FileOperationsIO
    {
         string path = @"E:\Studies\Bridgelabz\Fellowship--.NET\Project's\Address_Book\log.txt";
    //    public void WriteToFile(Dictionary<string, Person_Details> AddressBook)
    //    {
    //        if (File.Exists(path))
    //        {
    //            using StreamWriter writer = new StreamWriter(path, true);
    //            foreach (addDetails addressBookobj in addressBook.Values)
    //            {
    //                foreach (addDetails contact in addressBookobj.addressBook.Values)
    //                {
    //                    writer.WriteLine(contact.ToString());
    //                }
    //            }
    //            Console.WriteLine("\nSuccessfully added to Text file.");
    //            writer.Close();
    //        }
    //        else
    //        {
    //            Console.WriteLine("File does'nt exists");
    //        }
    //    }
    //    public void ReadFromFile()
    //    {
    //        Console.WriteLine("Below are Contents of Text File");
    //        string lines = File.ReadAllText(path);
    //        Console.WriteLine(lines);
    //    }
    }
}
