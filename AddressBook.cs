using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        public void AddContact(List<Address> contacts)
        {
            Console.WriteLine("Enter contact details:");
            Address contact = new Address();

            Console.Write("First Name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Address: ");
            contact.Addreses = Console.ReadLine();

            Console.Write("City: ");
            contact.City = Console.ReadLine();

            Console.Write("State: ");
            contact.State = Console.ReadLine();

            Console.Write("Zip: ");
            contact.Zip = Console.ReadLine();

            Console.Write("Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Email: ");
            contact.Email = Console.ReadLine();

            contacts.Add(contact);

            Console.WriteLine("Contact added successfully!");
        }
        public void ViewContacts(List<Address> contacts)
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"First Name: {contact.FirstName},Last Name: {contact.LastName},Address: {contact.Addreses},City: {contact.City},State: {contact.State},Zip: {contact.Zip},Phone Number: {contact.PhoneNumber},Email: {contact.Email}");
                
            }
        }
    }
}
