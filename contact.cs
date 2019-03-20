using System;
namespace tryAndcatch
{
        class Contact
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Email {get;set;}
        public string Address {get;set;}

        public string FullName {get {return $"{FirstName} {LastName}";}}

        public Contact(string firstname, string email, string address) {
            FirstName = firstname;
            Email = email;
            Address = address;
        }

        public Contact()
        {
        }
    }
}