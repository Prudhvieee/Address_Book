using System;

namespace Address_Book
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to Address Book---");
            Console.WriteLine("***Enter Your Choice***");
            Console.WriteLine("1.Add Details");
            Console.WriteLine("2.Display Details");
            Console.WriteLine("3.Edit contact");
            Console.WriteLine("4.Delete contact");
            int choice = Convert.ToInt32(Console.ReadLine());
            addDetails details = new addDetails();
            switch (choice)
            {
                case 1:
                    details.AddContact();
                    break;
                case 2:
                    details.displayAddressBook();
                    break;
                case 3:
                    Console.WriteLine("Enter the phone number of the person you want to edit");
                    long number = Convert.ToInt32(Console.ReadLine());
                    details.EditContact(number);
                    break;
                case 4:
                    Console.WriteLine("Enter the phone number of the person you want to delete");
                    long number1 = Convert.ToInt32(Console.ReadLine());
                    details.DeleteContact(number1);
                    break;
                default:
                    break;
            }
        }
    }
}
