using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        public void AddContact(Dictionary<string, List<Address>> addressBooks)
        {
            List<Address> contacts = null;
            PrintAllAddressBook(addressBooks);
            Console.WriteLine("Enter Address Book Name");
            string addressBookName = Console.ReadLine();
            if (!addressBooks.ContainsKey(addressBookName)){
                contacts = new List<Address>();
            }
            else{
                foreach (var addressBook in addressBooks){
                    if (addressBook.Key.Contains(addressBookName)){
                        contacts = addressBook.Value;
                        break;
                    }
                }
            }
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
                if(!addressBooks.ContainsKey(addressBookName))
                    addressBooks.Add(addressBookName, contacts);
                Console.WriteLine("Contact added successfully!");
                AddMultipleContact(addressBooks);
            }
            catch (Exception ex){
                Console.WriteLine("Please Enter valid Data");
            }
        }
        public void ViewContacts(Dictionary<string, List<Address>> addressBooks)
        {
            PrintAllAddressBook(addressBooks);
            Console.WriteLine("Enter your Address Book Name");
            string addressBookName = Console.ReadLine();
            if (!addressBooks.ContainsKey(addressBookName)){
                Console.WriteLine("Please Enter Valid Address Book Name");
                return;
            }
            foreach (var addressBook in addressBooks){
                if (addressBook.Key == addressBookName){
                    if (addressBook.Value.Count == 0){
                        Console.WriteLine("First Add at list One Contact ...Empty");
                        break;
                    }
                    foreach (var contact in addressBook.Value){
                        Console.WriteLine($"First Name: {contact.FirstName},Last Name: {contact.LastName},Address: {contact.Addreses},City: {contact.City},State: {contact.State},Zip: {contact.Zip},Phone Number: {contact.PhoneNumber},Email: {contact.Email}");
                    }
                }
            }
        }
        public void EditContact(Dictionary<string, List<Address>> addressBooks)
        {
            try {
                List<Address> contacts = null;
                PrintAllAddressBook(addressBooks);
                Console.WriteLine("Enter your Address Book Name");
                string addressBookName = Console.ReadLine();
                if (!addressBooks.ContainsKey(addressBookName)){
                    Console.WriteLine("Please Enter Valid Address Book Name");
                    return;
                }
                foreach (var addressBook in addressBooks){
                    if (addressBook.Key == addressBookName){
                        contacts = addressBook.Value;
                        break;
                    }
                }                
                if (contacts.Count == 0){
                    Console.WriteLine("First Add at list One Contact ...Empty");
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
                    Console.WriteLine("First Add at list One Contact ...Empty");
            }
            catch (Exception ex){
                Console.WriteLine("Please Enter valid Data");
            }
            
        }
        public void DeleteContact(Dictionary<string, List<Address>> addressBooks)
        {
            try
            {
                List<Address> contacts = null;
                PrintAllAddressBook(addressBooks);
                Console.WriteLine("Enter your Address Book Name");
                string addressBookName = Console.ReadLine();
                if (!addressBooks.ContainsKey(addressBookName)){
                    Console.WriteLine("Please Enter Valid Address Book Name");
                    return;
                }
                foreach (var addressBook in addressBooks){
                    if (addressBook.Key == addressBookName){
                        contacts = addressBook.Value;
                        break;
                    }
                }
                if (contacts.Count == 0){
                    Console.WriteLine("First Add at list One Contact ...Empty");
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
                    Console.WriteLine("First Add at list One Contact ...Empty");
            }
            catch (Exception ex){
                Console.WriteLine("Please Enter Valid ");
            }
        }
        public void PrintAllAddressBook(Dictionary<string, List<Address>> addressBooks){
            int count = 1;
            Console.WriteLine("===========++++Total Address Book++++=============");
            foreach (var addressBook in addressBooks){
                Console.WriteLine("{0} {1} ", count, addressBook.Key);
                count++;
            }
        }
        public void AddMultipleContact(Dictionary<string, List<Address>> addressBooks)
        {
            Console.WriteLine("Do want add new Contact Press (Y/N)");
            string addNewCustomer = Console.ReadLine().ToLower();
            if (addNewCustomer == "y")
                AddContact(addressBooks);
        }
    }
}
