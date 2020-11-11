using System;
namespace Address_Book
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Asks the user to select the choice
            Console.WriteLine("---Welcome to Address Book---");
            Console.WriteLine("***Enter Your Choice***");
            Console.WriteLine("1.Add Details");
            Console.WriteLine("2.Display Details");
            int choice = Convert.ToInt32(Console.ReadLine());
            addDetails details = new addDetails();
            switch (choice)
            {
                case 1:
                    details.AddContact();
                    details.displayAddressBook();
                    break;
                case 2:
                    details.displayAddressBook();
                    break;
                default:
                    break;
            }
        }
    }
}