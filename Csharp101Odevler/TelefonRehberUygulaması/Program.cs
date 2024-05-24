namespace TelefonRehberUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();

            phoneBook.Initialize();

            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                Console.WriteLine("*******************************************");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        phoneBook.AddNewContact();
                        break;
                    case "2":
                        phoneBook.DeleteContact();
                        break;
                    case "3":
                        phoneBook.UpdateContact();
                        break;
                    case "4":
                        phoneBook.ListContacts();
                        break;
                    case "5":
                        phoneBook.SearchContacts();
                        break;
                    default:
                        Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }
    } 
}
