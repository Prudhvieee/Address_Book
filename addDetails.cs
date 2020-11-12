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
        public List<Person_Details> addressBook;
        Dictionary<string, Person_Details> contacts = new Dictionary<string, Person_Details>();
        public static Dictionary<Person_Details, string> CitywiseContact = new Dictionary<Person_Details, string>();
        public static Dictionary<Person_Details, string> StatewiseContact = new Dictionary<Person_Details, string>();

        public addDetails()
        {
            this.addressBook = new List<Person_Details>();
        }
        /// <summary>
        /// AddContact method is used to add contacts to the list
        /// </summary>
        public void AddContact()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter First Name of Contact ");
                Person_Details person = new Person_Details();
                string firstName = Console.ReadLine();
                //if (this.contacts.ContainsKey(firstName))
                //{
                //    Console.WriteLine("A contact already exist with this name, try again!\n");
                //    AddContact();
                //    return;
                //}
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
                this.addressBook.Add(person);
                FileIOOperations fileIOOperations = new FileIOOperations();
                fileIOOperations.WriteToFile(addressBook);
                fileIOOperations.WriteCSVFile(addressBook);
                CitywiseContact[person] = person.City;
                StatewiseContact[person] = person.State;
                this.contacts.Add(person.FirstName, person);
                Console.WriteLine("Do you want to continue YES/NO");
                string input = Console.ReadLine();
                if (input == "Y" || input == "YES" || input == "y" || input == "yes")
                {
                    MultipleAddressBook multipleAddress = new MultipleAddressBook();
                    multipleAddress.DisplayMenu();
                }
                else
                {
                    flag = false;
                    Console.WriteLine("Thank you");
                }
            }
            //FileIOOperations fileIOOperations = new FileIOOperations();
            //fileIOOperations.WriteToFile(addressBook);
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
                MultipleAddressBook multipleAddress = new MultipleAddressBook();
                multipleAddress.DisplayMenu();
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
            foreach (Person_Details P in this.addressBook)
            {
                if (phoneNumber.Equals(P.PhoneNumber))
                {
                    count++;
                    Console.WriteLine("\n\t\t\tData found\n");
                    Console.WriteLine("\n\t\t\tEnter the choice which you want to edit");
                    Console.WriteLine("\t\t\t1.Firstname \n\t\t\t2.lastname\n\t\t\t3.city\n\t\t\t4.State\n\t\t\t5.zip\n\t\t\t6.EmailId\n");
                    int editChoice = Convert.ToInt32(Console.ReadLine());
                    switch (editChoice)
                    {
                        case 1:
                            Console.WriteLine("Enter the new first name");
                            string firstName = Console.ReadLine();
                            P.FirstName = firstName;
                            Console.WriteLine("Updated successfully");
                            break;
                        case 2:
                            Console.WriteLine("Enter the new Last name");
                            string lastName = Console.ReadLine();
                            P.LastName = lastName;
                            Console.WriteLine("Updated successfully");
                            break;
                        case 3:
                            Console.WriteLine("Enter the new city name");
                            string city = Console.ReadLine();
                            P.City = city;
                            Console.WriteLine("Updated successfully");
                            break;
                        case 4:
                            Console.WriteLine("Enter the new state name");
                            string state = Console.ReadLine();
                            P.State = state;
                            Console.WriteLine("Updated successfully");
                            break;
                        case 5:
                            Console.WriteLine("Enter zip");
                            int zip = Convert.ToInt32(Console.ReadLine());
                            P.ZipCode = zip;
                            Console.WriteLine("Updated successfully");
                            break;
                        case 6:
                            Console.WriteLine("Enter email id");
                            string email = Console.ReadLine();
                            P.EmailId = email;
                            Console.WriteLine("Updated successfully");
                            break;
                        default:
                            Console.WriteLine("\t\t\tSomething went wrong\n" + "\t\t\tTry again later");
                            break;
                    }
                }
            }
            if (count == 0)
                Console.WriteLine("\n\t\t\tData not found");
            Console.WriteLine("Do you want to continue YES/NO");
            string input = Console.ReadLine();
            if (input == "Y" || input == "YES" || input == "y" || input == "yes")
            {
                MultipleAddressBook multipleAddress = new MultipleAddressBook();
                multipleAddress.DisplayMenu();
            }
            else
            {
                Console.WriteLine("Thank you");
            }
        }
        /// <summary>
        /// Deletes the person details based on lastname
        /// </summary>
        public void DeleteContact(long phoneNumber)
        {
            int count = 0;
            int index = 0;
            List<Person_Details> ToRemove = new List<Person_Details>();
            //P is the person object and using list as iterator
            foreach (Person_Details P in addressBook)
            {
                if (phoneNumber.Equals(P.PhoneNumber))
                {
                    //index gets index value of the person to be deleted
                    index = addressBook.IndexOf(P);
                    Console.WriteLine("\n\t\t\tData found\n\n\t\t\tData Removed");
                    ToRemove.Add(P);
                    count++;
                }
            }
            addressBook.RemoveAt(index);
            //P is the person object and using list as iterator
            foreach (Person_Details P in addressBook)
            {
                Console.WriteLine(P.ToString());
            }
            if (count == 0)
                Console.WriteLine("\n\t\t\tNo such data found");
            Console.WriteLine("Do you want to continue YES/NO");
            string input = Console.ReadLine();
            if (input == "Y" || input == "YES" || input == "y" || input == "yes")
            {
                MultipleAddressBook multipleAddress = new MultipleAddressBook();
                multipleAddress.DisplayMenu();
            }
            else
            {
                Console.WriteLine("Thank you");
            }
        }
        /// <summary>
        /// Display person details based on city or state
        /// </summary>
        public static void ViewPersonByCityOrState()
        {
            int choice;
            Console.WriteLine("1.View Person Contact By City \n2.View Person Contact By State");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the City Name");
                    string city = Console.ReadLine();
                    List<Person_Details> contactListInGivenCity = new List<Person_Details>();
                    //Adds person detals of particular person to contactListInGivenCity list
                    foreach (KeyValuePair<Person_Details, string> kvp in CitywiseContact)
                    {
                        if (kvp.Value.Equals(city))
                            contactListInGivenCity.Add(kvp.Key);
                    }
                    //Prints details of person in particular state
                    foreach (Person_Details contact in contactListInGivenCity)
                    {
                        Console.WriteLine(contact);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the State Name");
                    string state = Console.ReadLine();
                    List<Person_Details> contactListInGivenState = new List<Person_Details>();
                    //Adds person detals of particular person to StatewiseContactMap list
                    foreach (KeyValuePair<Person_Details, string> kvp in StatewiseContact)
                    {
                        if (kvp.Value.Equals(state))
                            contactListInGivenState.Add(kvp.Key);
                    }
                    //Prints details of person in particular state
                    foreach (Person_Details contact in contactListInGivenState)
                    {
                        Console.WriteLine(contact);
                    }
                    break;
            }
        }
    }
}
