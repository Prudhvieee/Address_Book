using System;
using System.Collections.Generic;
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
        /// <summary>
        /// AddContact method is used to add contacts to the list
        /// </summary>
        public void AddContact()
        {
            this.addressBook.Add(AddPerson());
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
        }
    }
}
