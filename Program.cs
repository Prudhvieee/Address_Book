using System;

namespace Address_Book
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to Address Book---");
            addDetails newAddDetails = new addDetails();
            newAddDetails.CreateMultipleAddressBook();
        }
        
    }
}
