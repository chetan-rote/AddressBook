using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBookBuilder
    {
        /// <summary>
        /// The dictionary
        /// </summary>
        public Dictionary<string, Contacts> dictionary;
        public AddressBookBuilder()
        {
            this.dictionary = new Dictionary<string, Contacts>();
        }
        /// <summary>
        /// Adds the new contact.
        /// </summary>
        public void addContact()
        {
            string FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email;
            Console.WriteLine("Enter First Name : ");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Enter City : ");
            City = Console.ReadLine();
            Console.WriteLine("Enter State : ");
            State = Console.ReadLine();
            Console.WriteLine("Enter Zip code : ");
            Zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number : ");
            PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            Email = Console.ReadLine();
            Contacts contact = new Contacts(FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email);
            dictionary.Add(FirstName, contact);
        }        
    }
}
