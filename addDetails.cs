using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
namespace Address_Book
{
    public class addDetails : InAddDetails
    {

        private static Dictionary<long, Person_Details> list = new Dictionary<long, Person_Details>();
        /// <summary>
        /// Created a dictionary to store the address book using string-name as a key 
        /// details as a value
        /// </summary>
        private static Dictionary<string, addDetails> addressBook = new Dictionary<string, addDetails>();
        private Person_Details person = null;

        public void CreateMultipleAddressBook()
        {
            Console.WriteLine("Enter your Choice");
            Console.WriteLine("1.Add Address Book");
            Console.WriteLine("2.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the Name of Address Book");
                    string name = Console.ReadLine();
                    if (addressBook.ContainsKey(name))
                    {
                        Console.WriteLine("Address book with same name is already exists.\n Try with new name");
                    }
                    else
                    {
                        addDetails AddAddressBook = new addDetails();
                        addressBook.Add(name, AddAddressBook);
                        Console.WriteLine($"Address Book with {name} is Created...");
                        AddAddressBook.displayMenu();
                    }
                    break;
                default:
                    break;
            }
        }
        public void displayMenu()
        {
            Console.WriteLine("\nEnter Your Choice\n");
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
        public void AddContact()
        {
            Console.WriteLine("Enter First name ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter city");
            string city = Console.ReadLine();
            Console.WriteLine("Enter state");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            int zipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter phoneNumber");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter EmailID");
            string emailId = Console.ReadLine();
            this.person = new Person_Details(firstName, lastName, address, city, state, zipCode, phoneNumber, emailId);
            list.Add(phoneNumber, this.person);
            displayMenu();
        }
        public void displayAddressBook()
        {
            //Console.WriteLine($"Address book name {name}");
            //list.ForEach(Detail => Console.WriteLine(Detail));
            foreach (var detail in list)
            {
                Console.WriteLine(detail);
            }
            displayMenu();
        }
        public void EditContact(long phoneNumber)
        {
            bool check = true;
            if (list.ContainsKey(phoneNumber))
            {
                var person = list[phoneNumber];
                while (check)
                {

                    Console.WriteLine("Enter your choice for editing: ");
                    Console.WriteLine("1.FirstName 2.LastName 3.Address 4.city 5.State 6.Zipcode 7.EmailId");
                    long choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the first name ");
                            string firstName = Console.ReadLine();
                            person.FirstName = firstName;
                            break;
                        case 2:
                            Console.WriteLine("Enter last name");
                            string lastName = Console.ReadLine();
                            person.LastName = lastName;
                            break;
                        case 3:
                            Console.WriteLine("Enter address");
                            string address = Console.ReadLine();
                            person.Adderss = address;
                            break;
                        case 4:
                            Console.WriteLine("Enter city");
                            string city = Console.ReadLine();
                            person.City = city;
                            break;
                        case 5:
                            Console.WriteLine("Enter state");
                            string state = Console.ReadLine();
                            person.State = state;
                            break;
                        case 6:
                            Console.WriteLine("Enter Zip Code");
                            int zipCode = Convert.ToInt32(Console.ReadLine());
                            person.ZipCode = zipCode;
                            break;
                        case 7:
                            Console.WriteLine("Enter EmailID");
                            string emailId = Console.ReadLine();
                            person.EmailId = emailId;
                            break;
                        default:
                            check = false;
                            break;
                    }
                }
            }
            displayMenu();
        }
        public void DeleteContact(long phoneNumber)
        {
            list.Remove(phoneNumber);
            Console.WriteLine("contact removed successfully.");
            displayMenu();
        }
    }
}
