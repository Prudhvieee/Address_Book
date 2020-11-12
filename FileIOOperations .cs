using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

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
        public void WriteCSVFile(List<Person_Details> data)
        {
            string path = @"E:\Studies\Bridgelabz\Fellowship--.NET\Project's\Address_Book\utility\data.csv";
            using (var writer = new StreamWriter(path))
            using (var csvWrite = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                Console.WriteLine("Data Writing done successfully from Contact.csv file");
                csvWrite.WriteRecords(data);
            }
        }
        public void ImplementCSVDataHandling()
        {
            string path = @"E:\Studies\Bridgelabz\Fellowship--.NET\Project's\Address_Book\utility\data.csv";
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Person_Details>().ToList();
                Console.WriteLine("Data Reading done successfully from Contact.csv file");
                foreach (Person_Details contact in records)
                {
                    Console.Write(" "+contact.FirstName);
                    Console.Write(" "+contact.LastName);
                    Console.Write(" "+contact.Address);
                    Console.Write(" "+contact.City);
                    Console.Write(" "+contact.State);
                    Console.Write(" "+contact.ZipCode);
                    Console.Write(" "+contact.PhoneNumber);
                    Console.Write(" "+contact.EmailId);
                    Console.Write("\n");
                }
            }
        }
    }
}
