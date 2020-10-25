using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBookBuilder
    {
        public Dictionary<string, Contacts> dictionary;
        public AddressBookBuilder()
        {
            this.dictionary = new Dictionary<string, Contacts>();
        }
    }
}
