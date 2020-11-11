using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using Address_Book;
namespace Address_Book
{
    public class addDetails : InAddDetails
    {
        /// <summary>
        /// UC-2
        /// Created a List to store the contacts 
        /// </summary>
        List<Person_Details> addressBook = new List<Person_Details>();
        public addDetails()
        {
            this.addressBook = new List<Person_Details>();
        }
        public void DisplayMenu()
        {
            Console.WriteLine("***Enter Your Choice***");
            Console.WriteLine("1.Add Details");
            Console.WriteLine("2.Display Details");
            Console.WriteLine("3.Edit contact");
            Console.WriteLine("4.Delete contact");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddContact();
                    break;
                case 2:
                    displayAddressBook();
                    break;
                case 3:
                    Console.WriteLine("Enter the phone number of the person you want to edit");
                    long number = Convert.ToInt32(Console.ReadLine());
                    EditContact(number);
                    break;
                case 4:
                    Console.WriteLine("Enter the phone number you want to delete");
                    long number1 = Convert.ToInt32(Console.ReadLine());
                    DeleteContact(number1);
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// AddContact method is used to add contacts to the list
        /// </summary>
        public void AddContact()
        {
            this.addressBook.Add(AddPerson());
            Console.WriteLine("Contact added successfully");
            Console.WriteLine("Do you want to continue YES/NO");
            string input = Console.ReadLine();
            if (input == "Y" || input == "YES" || input == "y" || input == "yes")
            {
                DisplayMenu();
            }
            else
            {
                Console.WriteLine("Thank you");
            }
        }
        /// <summary>
        /// AddPerson is used to read details from the user
        /// </summary>
        /// <returns>person details</returns>
        public Person_Details AddPerson()
        {
            Person_Details person = new Person_Details();
            Console.WriteLine("Enter First name ");
            person.FirstName = (Console.ReadLine());
            Console.WriteLine("Enter last name");
            person.LastName = Console.ReadLine();
            Console.WriteLine("Enter address");
            person.Address = Console.ReadLine();
            Console.WriteLine("Enter city");
            person.City = Console.ReadLine();
            Console.WriteLine("Enter state");
            person.State = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            person.ZipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter phoneNumber");
            person.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter EmailID");
            person.EmailId = Console.ReadLine();
            return person;
        }
        /// <summary>
        /// Display addresss book is used to display the details added in list
        /// </summary>
        public void displayAddressBook()
        {
            foreach (var element in addressBook)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Do you want to continue YES/NO");
            string input = Console.ReadLine();
            if (input == "Y" || input == "YES" || input == "y" || input == "yes")
            {
                DisplayMenu();
            }
            else
            {
                Console.WriteLine("Thank you");
            }
        }
        /// <summary>
        /// UC-3
        /// Edit contact method is used to edit the existing contact details 
        /// </summary>
        static int count = 0;
        public void EditContact(long phoneNumber)
        {
            Console.WriteLine(addressBook[phoneNumber]);
            Person_Details person= this.person;
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
                    break;
            }
        }
    }
}
