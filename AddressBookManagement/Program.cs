using AddressBookManagement.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook address = new AddressBook();
            Console.WriteLine("Enter 1 to Add a new contact");
            int result = int.Parse(Console.ReadLine());
            switch (result)
            {
                case 1: 
                    address.AddContact(); 
                    break;
                default: 
              
                    break;
            }
        }
    }
}
