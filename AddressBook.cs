using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        public void AddContact(List<Address> contacts)
        {
            try
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
                contact.Zip = Convert.ToInt32(Console.ReadLine());
                Console.Write("Phone Number: ");
                contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.Write("Email: ");
                contact.Email = Console.ReadLine();
                contacts.Add(contact);
                Console.WriteLine("Contact added successfully!");
                AddNewContact(contacts);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter valid Data");
            }
        }
        public void ViewContacts(List<Address> contacts)
        {
            if (contacts.Count == 0){
                Console.WriteLine("First Add At list one contact....Empty");
                return;
            }
            foreach (var contact in contacts){
                Console.WriteLine($"First Name: {contact.FirstName},Last Name: {contact.LastName},Address: {contact.Addreses},City: {contact.City},State: {contact.State},Zip: {contact.Zip},Phone Number: {contact.PhoneNumber},Email: {contact.Email}");
                
            }
        }
        public void EditContact(List<Address> contacts)
        {
            try {
                if (contacts.Count == 0) {
                    Console.WriteLine("First Add At list one contact....Empty");
                    return;
                 }
                Console.WriteLine("Enter Your First Name");
                var firstName = Console.ReadLine();
                if (contacts != null){
                    Address contact = contacts.Find((a) => a.FirstName == firstName);
                    if (contact == null)
                    {
                        Console.WriteLine("Your FirstName No match!!! Enter please try Again");
                        return;
                    }

                    Console.Write("Last Name: ");
                    contact.LastName = Console.ReadLine();
                    Console.Write("Address: ");
                    contact.Addreses = Console.ReadLine();
                    Console.Write("City: ");
                    contact.City = Console.ReadLine();
                    Console.Write("State: ");
                    contact.State = Console.ReadLine();
                    Console.Write("Zip: ");
                    contact.Zip = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Phone Number: ");
                    contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Email: ");
                    contact.Email = Console.ReadLine();
                    Console.WriteLine("Contact Edited successfully!");
                }
                else
                    Console.WriteLine("First Add one at list contact ...Empty");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter valid Data");
            }
            
        }
        public void DeleteContact(List<Address> contacts)
        {
            try
            {
                if (contacts.Count == 0){
                    Console.WriteLine("First Add At list one contact....Empty");
                    return;
                }
                Console.WriteLine("Enter Your First Name");
                var firstName = Console.ReadLine();
                if (contacts != null){
                    Address contact = contacts.Find((a) => a.FirstName == firstName);
                    if (contact == null){
                        Console.WriteLine("Your FirstName No match!!! Enter please try Again");
                        return;
                    }
                    var index = contacts.IndexOf(contact);
                    contacts.RemoveAt(index);
                    Console.WriteLine("Deleted Successfully Contact");
                }
                else
                    Console.WriteLine("First Add one at list contact ...Empty");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter Valid ");
            }
        }
        public void AddNewContact(List<Address> contacts)
        {
            Console.WriteLine("Do you want add new Contact Press(Y/N)");
            string addNewContact = Console.ReadLine().ToLower();
            if (addNewContact == "y")
                AddContact(contacts);
        }
    }
}
