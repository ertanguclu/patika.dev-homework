namespace TODOUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TodoBoard board = new TodoBoard();
            board.InitializeDefaultCards();
            board.AddTeamMember(1, "Ertan");
            board.AddTeamMember(2, "Eray");
            board.AddTeamMember(3, "Adem");

            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listeleme");
                Console.WriteLine("(2) Kart Ekle");
                Console.WriteLine("(3) Kart Sil");
                Console.WriteLine("(4) Kart Taşı");
                Console.WriteLine("(5) Kart Güncelle");
                Console.WriteLine("*******************************************");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        board.ListBoard();
                        break;
                    case "2":
                        board.AddCard();
                        break;
                    case "3":
                        board.DeleteCard();
                        break;
                    case "4":
                        board.MoveCard();
                        break;
                    case "5":
                        board.UpdateCard();
                        break;
                    default:
                        Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }
    }
}
