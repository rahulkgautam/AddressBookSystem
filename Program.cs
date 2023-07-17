using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");
            List<Address> contacts = new List<Address>();
            var book = new AddressBook();
            while (true)
            {
                Console.WriteLine("1. Add a contact");
                Console.WriteLine("2. View contacts");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        book.AddContact(contacts);
                        break;
                    case 2:
                        book.ViewContacts(contacts);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
