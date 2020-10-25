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
                Console.WriteLine("1. Add Contact\n2. Display Contacts\n3. Edit Contact \n4. Delete Contact \n5. Exit");
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
                    case 4:
                        Console.WriteLine("Enter the first name of the contact that need to be deleted");
                        String firstName = Console.ReadLine();
                        addressBookBuilder.deleteContact(firstName);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter Valid Choice");
                        break;
                }
            }
        }
    }
}
