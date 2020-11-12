using System;
namespace Address_Book
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to Address Book---");
            MultipleAddressBook multipleAddress = new MultipleAddressBook();
            multipleAddress.DisplayMenu();
        }
    }
}