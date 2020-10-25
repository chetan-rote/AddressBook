using System;

namespace AddressBook
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            AddressBookBuilder addressBookBuilder = new AddressBookBuilder();
            while (true)
            {
                Console.WriteLine("1. Add Contact\n2. Display Contacts\n3. Edit Contact");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBookBuilder.addContact();
                        break;
                    case 2:
                        addressBookBuilder.displayContacts();
                        break;
                    case 3:
                        Console.WriteLine("Enter the first name of the contact that need to be changed");
                        String firstNameSearch = Console.ReadLine();
                        addressBookBuilder.editContact(firstNameSearch);
                        break;
                    default:
                        Console.WriteLine("Enter Valid Choice");
                        break;
                }
            }
        }
    }
}
