using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
namespace Address_Book
{
    public class addDetails : InAddDetails
    {
        /// <summary>
        /// Created a dictionary to store the contacts using phone number as a key 
        /// string as a value
        /// </summary>
        private static List<Person_Details> list = new List<Person_Details>();
        private static Dictionary<long, List<Person_Details>> addressBook = new Dictionary<long, List<Person_Details>>();
        private Person_Details person= null;
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
            list.Add(this.person);
            addressBook.Add(phoneNumber, list);
            Program.displayMenu();
        }
        public void displayAddressBook()
        {
            list.ForEach(num => Console.WriteLine(num + ", "));
        }
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
        public void DeleteContact(long phoneNumber)
        {
            //addressBook.Remove(phoneNumber);
        }
    }
}
