using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagement.Properties
{
    class AddressBook
    {
        public class Contact
        {
            public string FirstName;
            public string LastName;
            public string Address;
            public string City;
            public string State;
            public long Pincode;
            public long PhoneNumber;
            public string Email;
        }
            List<Contact> contacts;
            public long AddressBook()
            {
                contacts = new List<Contact>();
            }
            public void AddContact()
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
                this.contacts.Add(contact);
                Console.WriteLine("Contact added Sucesfully...!");
            }
        }
    }

