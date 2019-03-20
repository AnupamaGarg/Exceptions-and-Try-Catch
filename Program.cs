using System;
using System.Collections.Generic;

namespace tryAndcatch
{
   class Program
{
    /*
        1. Add the required classes to make the following code compile.
        HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.

        2. Run the program and observe the exception.

        3. Add try/catch blocks in the appropriate locations to prevent the program from crashing
            Print meaningful error messages in the catch blocks.
    */

    static void Main(string[] args)
    {
        // Create a few contacts
        Contact bob = new Contact() {
            FirstName = "Bob", LastName = "Smith",
            Email = "bob.smith@email.com",
            Address = "100 Some Ln, Testville, TN 11111"
        };
        Contact sue = new Contact() {
            FirstName = "Sue", LastName = "Jones",
            Email = "sue.jones@email.com",
            Address = "322 Hard Way, Testville, TN 11111"
        };
        Contact juan = new Contact() {
            FirstName = "Juan", LastName = "Lopez",
            Email = "juan.lopez@email.com",
            Address = "888 Easy St, Testville, TN 11111"
        };


        // Create an AddressBook and add some contacts to it
        AddressBook addressBook = new AddressBook();
        try {
        addressBook.AddContact(bob);
        addressBook.AddContact(sue);
        addressBook.AddContact(juan);

        // Try to add a contact a second time
        addressBook.AddContact(sue);
        } catch(ArgumentException ex) {
            Console.WriteLine($"This Contact is already exists. Can not add again");
        }

        /* on executing the code without TRY AND CATCH following is the result
        Unhandled Exception: System.ArgumentException: An item with the same key has already been added. Key: sue.jones@email.com
   at System.Collections.Generic.Dictionary`2.TryInsert(TKey key, TValue value,InsertionBehavior behavior)
   at System.Collections.Generic.Dictionary`2.Add(TKey key, TValue value)
   at tryAndcatch.AddressBook.AddContact(Contact name) in C:\Users\dolly\workspace\csharp\exercises\tryAndcatch\AddressBook.cs:line 9
   at tryAndcatch.Program.Main(String[] args) in C:\Users\dolly\workspace\csharp\exercises\tryAndcatch\Program.cs:line 45
 */


        // Create a list of emails that match our Contacts
        List<string> emails = new List<string>() {
            "sue.jones@email.com",
            "juan.lopez@email.com",
            "bob.smith@email.com",
        };

        // Insert an email that does NOT match a Contact
        emails.Insert(1, "not.in.addressbook@email.com");


        //  Search the AddressBook by email and print the information about each Contact
        foreach (string email in emails)
            
        
        {    
            /*Console.WriteLine(email);*/
        try{
            Contact contact = addressBook.GetByEmail(email);
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Name: {contact.FullName}");
            Console.WriteLine($"Email: {contact.Email}");
            Console.WriteLine($"Address: {contact.Address}");
            } catch(KeyNotFoundException ex) {
                
            Console.WriteLine("---------------");
            Console.WriteLine("There is not contact with this email");
        }
        }
        /* ON EXECUTING THE CODE without TRY AND CATCH FOLLOWING IS HE EXECPTION
        Unhandled Exception: System.Collections.Generic.KeyNotFoundException: The given key 'not.in.addressbook@email.com' was not present in the dictionary.
   at System.Collections.Generic.Dictionary`2.get_Item(TKey key)
   at tryAndcatch.AddressBook.GetByEmail(String email) in C:\Users\dolly\workspace\csharp\exercises\tryAndcatch\AddressBook.cs:line 12
   at tryAndcatch.Program.Main(String[] args) in C:\Users\dolly\workspace\csharp\exercises\tryAndcatch\Program.cs:line 70
 */
    }
}
}
