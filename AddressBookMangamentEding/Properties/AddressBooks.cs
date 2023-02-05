using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMangamentEding.Properties
{
    internal class AddressBooks
    {
        List<Contact> contacts;
        public AddressBooks()
        {
            contacts = new List<Contact>();
        }
        public void AddContact()
        {
            Contact contact = TakeInputsForContact();
            this.contacts.Add(contact);
            Console.WriteLine("Contact added Sucesfully...!");
        }
        public Contact TakeInputsForContact()
        {
            Console.Write("Enter FirstName: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter lastName: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter phoneNumber: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter city: ");
            string city = Console.ReadLine();
            Console.Write("Enter state: ");
            string state = Console.ReadLine();
            Console.Write("Enter zip: ");
            string pincode = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            Console.Write("Enter Email Adress: ");
            string email = Console.ReadLine();
            Contact contact = new Contact()
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = long.Parse(phoneNumber),
                City = city,
                State = state,
                Pincode = long.Parse(pincode),
                Address = address,
                Email = email
            };
            return contact;
        }
        public void EditContact()
        {
            Console.WriteLine("Enter the FistName of the contact to edit that contact");
            string fName = Console.ReadLine();
            Contact contact = null;
            foreach (var con in contacts)
            {
                if (con.FirstName.Equals(fName))
                {
                    contact = con; break;
                }
            }
            if (contact == null)
            {
                Console.WriteLine("there is no contact with given FirstName...!");
                return;
            }
            contact = TakeInputsForContact();
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].FirstName.Equals(fName))
                {
                    contacts[i] = contact; break;
                }
            }
            Console.WriteLine("Contact Edited successfully");
            return;
        }
    }
}
