using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberUygulaması
{
    public class PhoneBook
    {
        private List<Contact> contacts;

        public void Initialize()
        {
            contacts = new List<Contact>()
            {
            new Contact { Name = "Ahmet", Surname = "Yılmaz", PhoneNumber = "5553452128" },
            new Contact { Name = "Ayşe", Surname = "Güzel", PhoneNumber = "5553452190" },
            new Contact { Name = "Mehmet", Surname = "Yaşar", PhoneNumber = "5553452180" },
            new Contact { Name = "Fatma", Surname = "Okur", PhoneNumber = "5553452160" },
            new Contact { Name = "Ali", Surname = "Çelik", PhoneNumber = "5553452176" }
            };
        }

        public void AddNewContact()
        {
            Console.WriteLine("Lütfen isim giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz:");
            string phoneNumber = Console.ReadLine();

            contacts.Add(new Contact { Name = name, Surname = surname, PhoneNumber = phoneNumber });

            Console.WriteLine("Kişi rehbere eklendi.");
        }

        public void DeleteContact()
        {
            Console.WriteLine("Lütfen silmek istediğiniz kişinin adını veya soyadını giriniz:");
            string searchQuery = Console.ReadLine();

            Contact contactToDelete = contacts.FirstOrDefault(c => c.Name.Equals(searchQuery, StringComparison.OrdinalIgnoreCase) || c.Surname.Equals(searchQuery, StringComparison.OrdinalIgnoreCase));

            if (contactToDelete == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                return;
            }

            Console.WriteLine($"{contactToDelete.Name} isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n)");
            string confirmation = Console.ReadLine();

            if (confirmation.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                contacts.Remove(contactToDelete);
                Console.WriteLine("Kişi rehberden silindi.");
            }
            else
            {
                Console.WriteLine("Silme işlemi iptal edildi.");
            }
        }

        public void UpdateContact()
        {
            Console.WriteLine("Lütfen güncellemek istediğiniz kişinin adını veya soyadını giriniz:");
            string searchQuery = Console.ReadLine();

            Contact contactToUpdate = contacts.FirstOrDefault(c => c.Name.Equals(searchQuery, StringComparison.OrdinalIgnoreCase) || c.Surname.Equals(searchQuery, StringComparison.OrdinalIgnoreCase));

            if (contactToUpdate == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                return;
            }

            Console.WriteLine($"{contactToUpdate.Name} isimli kişinin yeni bilgilerini giriniz:");
            Console.WriteLine("Lütfen yeni isim giriniz:");
            string newName = Console.ReadLine();
            Console.WriteLine("Lütfen yeni soyisim giriniz:");
            string newSurname = Console.ReadLine();
            Console.WriteLine("Lütfen yeni telefon numarası giriniz:");
            string newPhoneNumber = Console.ReadLine();

            contactToUpdate.Name = newName;
            contactToUpdate.Surname = newSurname;
            contactToUpdate.PhoneNumber = newPhoneNumber;

            Console.WriteLine("Kişi bilgileri güncellendi.");
        }

        public void ListContacts()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"isim: {contact.Name} Soyisim: {contact.Surname} Telefon Numarası: {contact.PhoneNumber}");
            }
        }

        public void SearchContacts()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz:");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            string searchType = Console.ReadLine();
            switch (searchType)
            {
                case "1":
                    Console.WriteLine("Lütfen aramak istediğiniz kişinin adını veya soyadını giriniz:");
                    string nameOrSurname = Console.ReadLine();
                    var resultsByNameOrSurname = contacts.Where(c => c.Name.Contains(nameOrSurname, StringComparison.OrdinalIgnoreCase) || c.Surname.Contains(nameOrSurname, StringComparison.OrdinalIgnoreCase)).ToList();
                    PrintSearchResults(resultsByNameOrSurname);
                    break;
                case "2":
                    Console.WriteLine("Lütfen aramak istediğiniz telefon numarasını giriniz:");
                    string phoneNumber = Console.ReadLine();
                    var resultsByPhoneNumber = contacts.Where(c => c.PhoneNumber.Contains(phoneNumber)).ToList();
                    PrintSearchResults(resultsByPhoneNumber);
                    break;
                default:
                    Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen tekrar deneyin.");
                    break;
            }
        }

        private void PrintSearchResults(List<Contact> results)
        {
            if (results.Count == 0)
            {
                Console.WriteLine("Arama sonuçlarına uygun veri bulunamadı.");
                return;
            }

            Console.WriteLine("Arama Sonuçlarınız:");
            Console.WriteLine("**********************************************");
            foreach (var contact in results)
            {
                Console.WriteLine($"isim: {contact.Name} Soyisim: {contact.Surname} Telefon Numarası: {contact.PhoneNumber}");
            }
        }
    }
}

