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
