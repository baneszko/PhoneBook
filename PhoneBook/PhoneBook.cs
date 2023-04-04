using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class PhoneBook
    {
        // inicjalizacja listy kontaktów jako pustej listy, inaczej wyrzuca wyjątek
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        // dodawanie elementów
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        // wyświetlanie kontaktu na podstawie numeru
        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.Number == number);

            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }

        // wyświetlanie wszystkich kontaktów
        public void DisplayAllContacts()
        {
            DisplayContactsDetails(Contacts);
        }

        // wyświetlanie kontaktów, które pasują do wyszukiwanej przez użytkownika klasy
        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);
        }
    }
}
