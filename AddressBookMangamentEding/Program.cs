using AddressBookMangamentEding.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMangamentEding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A to Add new contact\nEnter E to edit a contact");
            char ch = Console.ReadLine().ToUpper()[0];
            AddressBooks addressBooks = new AddressBooks();
            switch (ch)
            {
                case 'A':
                    addressBooks.AddContact();
                    break;
                case 'E':
                    addressBooks.EditContact();
                    break;
                default:
                    break;
            }
        }
    }
}
