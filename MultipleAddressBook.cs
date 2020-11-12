using System;
using System.Collections.Generic;

namespace Address_Book
{
    public class MultipleAddressBook
    {
        /// <summary>
        /// multipleAddressBook is  used to store All AddressBooks created
        /// which can be accessed with the help of their name
        /// </summary>
        private Dictionary<string, addDetails> multipleAddressBook = new Dictionary<string, addDetails>();
        /// <summary>
        /// multipleBook function asks user about which activity to be done
        /// </summary>
        public void DisplayMenu()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. New addressbook\n" + "2. open existing\n" + "3. EditPerson\n"
                       + "4. DeletePerson\n" + "5. ViewPersonByCityOrState\n" + "6. ReadFromFile\n7.Read data from csv file\n8.Read JSON file\n9.close address book");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        AddAddressBook();
                        break;
                    case 2:
                        AddContactsInAddressBook();
                        break;
                    case 3:
                        EditContactsOfAddressBook();
                        break;
                    case 4:
                        DeleteContactsOfAddressBook();
                        break;
                    case 5:
                        addDetails.ViewPersonByCityOrState();
                        break;
                    case 6:
                        FileIOOperations fileIOOperations1 = new FileIOOperations();
                        fileIOOperations1.ReadFromFile();
                        break;
                    case 7:
                        FileIOOperations fileIOOperations2 = new FileIOOperations();
                        fileIOOperations2.ImplementCSVDataHandling();
                        break;
                    case 8:
                        FileIOOperations fileIOOperations3 = new FileIOOperations();
                        fileIOOperations3.ReadJsonFile();
                        break;
                    case 9:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Wrong data received select again");
                        break;
                }
            }
        }
        /// <summary>
        /// AddAddressBook function is called when user want to create new AddressBook
        /// </summary>
        public void AddAddressBook()
        {
            Console.WriteLine("\nEnter Name for the New Address Book");
            string name = Console.ReadLine();
            if (multipleAddressBook.ContainsKey(name))
            {
                Console.WriteLine("Address Book Already exist with this name");
            }
            else
            {
                addDetails addressBook = new addDetails();
                multipleAddressBook.Add(name, addressBook);
            }
        }
        /// <summary>
        /// AddContactsInAddressBook is called when user ask to enter new contact details in any AddressBook
        /// </summary>
        public void AddContactsInAddressBook()
        {
            Console.WriteLine("\nEnter Name of address book to add new contact");
            string name = Console.ReadLine();
            if (!multipleAddressBook.ContainsKey(name))
            {
                Console.WriteLine("No address book found with this name");
                Console.WriteLine("Please Enter Valid Name from following names:");
                foreach (KeyValuePair<string, addDetails> tempPair in multipleAddressBook)
                {
                    Console.WriteLine(tempPair.Key);
                }
            }
            else
            {
                addDetails addressBook = multipleAddressBook[name];
                addressBook.AddContact();
            }
        }
        /// <summary>
        /// EditDetailsOfAddressBook is called when a user ask to modify Contact details in a AddressBook
        /// </summary>
        public void EditContactsOfAddressBook()
        {
            Console.WriteLine("\nEnter Name of address book to modify contact details");
            string name = Console.ReadLine();
            if (!multipleAddressBook.ContainsKey(name))
            {
                Console.WriteLine("No address book found with this name");
                Console.WriteLine("Please Enter Valid Name from following names:");
                foreach (KeyValuePair<string, addDetails> tempPair in multipleAddressBook)
                {
                    Console.WriteLine(tempPair.Key);
                }
            }
            else
            {
                addDetails addressBook = multipleAddressBook[name];
                Console.WriteLine("Enter the phone number of the person you want to edit");
                long number = Convert.ToInt32(Console.ReadLine());
                addressBook.EditContact(number);
            }
        }
        /// <summary>
        /// DeleteContactsOfAddressBook is called when user want to delete a particular contact from a AddressBook
        /// </summary>
        public void DeleteContactsOfAddressBook()
        {
            Console.WriteLine("\nEnter Name of address book to delete contact details");
            string name = Console.ReadLine();
            if (!multipleAddressBook.ContainsKey(name))
            {
                Console.WriteLine("No address book found with this name");
                Console.WriteLine("Please Enter Valid Name from following names:");
                foreach (KeyValuePair<string, addDetails> tempPair in multipleAddressBook)
                {
                    Console.WriteLine(tempPair.Key);
                }
            }
            else
            {
                addDetails addressBook = multipleAddressBook[name];
                Console.WriteLine("Enter the phone number you want to delete");
                long number1 = Convert.ToInt32(Console.ReadLine());
                addressBook.DeleteContact(number1);
            }
        }
    }
}