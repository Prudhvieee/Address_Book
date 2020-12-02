using System;
using System.Collections.Generic;
namespace Address_Book
{
    public class addDetails : InAddDetails
    {
        /// <summary>
        /// UC-2
        /// Created a List to store the contacts 
        /// </summary>
        List<Person_Details> addressBook = new List<Person_Details>();
        Dictionary<string, addDetails> contacts = new Dictionary<string, addDetails>();
        public addDetails()
        {
            this.addressBook = new List<Person_Details>();
        }
        public void DisplayMenu()
        {
            Console.WriteLine("***Enter Your Choice***");
            Console.WriteLine("1.Add Details\n2.Display Details\n3.Edit contact\n4.Delete contact\n5.Exit");
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
                case 5:
                    return;
                default:
                    break;
            }
        }
        public void CreateMultipleAddressBook()
        {
            while (true)
            {
                Console.WriteLine("Enter your Choice");
                Console.WriteLine("1.Add Address Book");
                Console.WriteLine("2.Exit");

                String choice = Console.ReadLine();
                int choice1 = Convert.ToInt32(choice);
                switch (choice1)
                {
                    case 1:
                        Console.WriteLine("Enter the Name of Address Book");
                        string name = Console.ReadLine();
                        if (contacts.ContainsKey(name))
                        {
                            Console.WriteLine("Already exists...");
                        }
                        else
                        {
                            addDetails details = new addDetails();
                            contacts.Add(name, details);
                            Console.WriteLine("Address Book is Created...");
                            details.DisplayMenu();
                        }
                        break;
                    case 2:
                        return;
                }
            }
        }
        /// <summary>
        /// AddContact method is used to add contacts to the list
        /// </summary>
        public void AddContact()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter First Name");
                string firstName = Console.ReadLine();
                if (this.contacts.ContainsKey(firstName))
                {
                    Console.WriteLine("A contact already exist with this name, try again!\n");
                    AddContact();
                    return;
                }
                Person_Details person = new Person_Details();
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
                Console.WriteLine("Do you want to continue YES/NO");
                string input = Console.ReadLine();
                if (input == "Y" || input == "YES" || input == "y" || input == "yes")
                {
                    DisplayMenu();
                }
                else
                {
                    flag = false;
                    Console.WriteLine("Thank you");
                }
            }
        }
        /// <summary>
        /// Display addresss book is used to display the details added in list
        /// </summary>
        public void displayAddressBook()
        {
            if (addressBook.Count == 0)
            {
                Console.WriteLine("No Contacts");
            }
            else
            {
                foreach (var element in addressBook)
                {
                    Console.WriteLine(element);
                }
            }
            Console.WriteLine("Do you want to continue YES/NO");
            string input = Console.ReadLine();
            if (input == "Y" || input == "YES" || input == "y" || input == "yes")
            {
                DisplayMenu();
            }
            else if (input == "N" || input == "NO" || input == "n" || input == "no")
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
                DisplayMenu();
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
            if (count == 0)
                Console.WriteLine("\n\t\t\tNo such data found");
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
    }
}
