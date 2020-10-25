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
            Console.WriteLine("1. Add Contact");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    addressBookBuilder.addContact();
                    break;
                default:
                    Console.WriteLine("Enter Valid Choice");
                    break;
            }
        }
    }
}
