using System;
using product_manager;


namespace ContactList {
    class Program {
        static void Main(string[] args) {
            Contacts contact = new Contacts();
            Console.WriteLine("Welcome to the contact list application!");
            contact.firstName = MyConsole.getString("enter first name: ");
            contact.lastName = MyConsole.getString("enter last name: ");
            contact.email = MyConsole.getString("enter email: ");
            contact.phoneNumber = MyConsole.getInt("enter phoneNumber: ");
            currentContactMessage();
            ListOfContacts(contact.firstName, contact.lastName, contact.email, contact.phoneNumber);

        }
        public static void ListOfContacts(string firstName, string lastName, string email, int phoneNumber) {
            Contacts contactList = new Contacts(firstName, lastName, email, phoneNumber);
            Console.WriteLine("name" + " " + contactList.firstName + contactList.lastName);
            Console.WriteLine("email" + " " + contactList.email);
            Console.WriteLine("phoneNumber" + " " + contactList.phoneNumber);
        }

        public static void currentContactMessage() {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("---- Current Contact -----------------------");
            Console.WriteLine("--------------------------------------------");
        }
    }
}
