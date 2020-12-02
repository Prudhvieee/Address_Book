using System;
namespace Address_Book
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Asks the user to select the choice
            Console.WriteLine("---Welcome to Address Book---");
            addDetails newDetails = new addDetails();
            newDetails.CreateMultipleAddressBook();
        }
    }
}