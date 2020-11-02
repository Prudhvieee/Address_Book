using System;
using System.Collections.Generic;
using System.Text;
using Address_Book;
namespace Address_Book
{
    public class addDetails : InAddDetails
    {
        /// <summary>
        /// Created a dictionary to store the contacts using phone number as a key 
        /// string as a value
        /// </summary>
        private readonly IDictionary<long, Person_Details> addressBook = new Dictionary<long, Person_Details>();
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
            this.addressBook.Add(phoneNumber, this.person);
        }
        public void displayAddressBook()
        {
            foreach (var element in addressBook)
            {
                Console.WriteLine(element);
            }
        }
    }
}
