using System;
using System.Collections.Generic;
using System.Text;
using Address_Book;

namespace Address_Book
{
    public interface InAddDetails
    {
        /// <summary>
        /// addContact method is used to add person details to address book
        /// </summary>
        public void AddContact();
        /// <summary>
        /// displayAddressBook method is used to display the contact details present in the address book
        /// </summary>
        public void displayAddressBook();
        /// <summary>
        /// editContact method is used to edit the contact
        /// </summary>
        public void EditContact(long phoneNumber);
        /// <summary>
        /// deleteContact method is used to the contact using phone number as a key
        /// </summary>
        /// <param name="phoneNumber"></param>
        public void DeleteContact(long phoneNumber);
        /// <summary>
        /// Search contact method is used to search contact
        /// </summary>
        public void searchContact();
        public void ViewContact();
    }
}
