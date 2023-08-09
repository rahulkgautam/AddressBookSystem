using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");
            Dictionary<string, List<Address>> addressBooks = new Dictionary<string, List<Address>>();
            var book = new AddressBook();
            try
            {
                while (true){
                    Console.WriteLine("1. Add a contact");
                    Console.WriteLine("2. View contacts");
                    Console.WriteLine("3. Edit contacts");
                    Console.WriteLine("4. Delete contacts");
                    Console.WriteLine("5. Search Person by State or City");
                    Console.WriteLine("6. Exit");

                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            book.AddContact(addressBooks);
                            break;
                        case 2:
                            book.ViewContacts(addressBooks);
                            break;
                        case 3:
                            book.EditContact(addressBooks);
                            break;
                        case 4:
                            book.DeleteContact(addressBooks);
                            break;
                        case 5:
                            book.SearchPerson(addressBooks);
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter Valid Number");
            }
        }
    }
}
