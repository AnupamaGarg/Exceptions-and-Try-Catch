using System.Collections.Generic;

namespace tryAndcatch
{
    class AddressBook
    {
        public  Dictionary<string, Contact> contacts {get;set;} = new Dictionary<string, Contact>();
        public void AddContact(Contact name){
            contacts.Add(name.Email, name);
        }
        public Contact GetByEmail(string email){
            return contacts[email];
        }
    }
}