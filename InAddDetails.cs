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
    }
}
