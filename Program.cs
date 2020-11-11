using System;
namespace Address_Book
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to Address Book---");
            addDetails newDetails = new addDetails();
            newDetails.DisplayMenu();
        }
    }
}