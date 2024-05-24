using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOUygulaması
{
    public class TodoBoard
    {
        private Dictionary<TodoLine, List<TodoCard>> board;
        private Dictionary<int, string> teamMembers;

        public TodoBoard()
        {
            board = new Dictionary<TodoLine, List<TodoCard>>();
            teamMembers = new Dictionary<int, string>();
        }
        public void AddTeamMember(int memberId, string memberName)
        {
            teamMembers.Add(memberId, memberName);
        }
        public void InitializeDefaultCards()
        {
            board[TodoLine.TODO] = new List<TodoCard>
        {
            new TodoCard { Title = "Yazılım 1", Content = "Patika", AssignedTo = "Ertan", Size = TodoSize.M, Line = TodoLine.TODO },
            new TodoCard { Title = "Yazılım 2", Content = "Frontend", AssignedTo = "Eray", Size = TodoSize.S, Line = TodoLine.TODO },
            new TodoCard { Title = "Yazılım 3", Content = "Backend", AssignedTo = "Adem", Size = TodoSize.L, Line = TodoLine.TODO }
        };

            board[TodoLine.IN_PROGRESS] = new List<TodoCard>
        {
            new TodoCard { Title = "Yazılım 4", Content = "Mobil", AssignedTo = "Ertan", Size = TodoSize.XS, Line = TodoLine.IN_PROGRESS }
        };

            board[TodoLine.DONE] = new List<TodoCard>();
        }

        public void ListBoard()
        {
            foreach (var line in board)
            {
                Console.WriteLine($"{line.Key} Line");
                Console.WriteLine("************************");
                foreach (var card in line.Value)
                {
                    Console.WriteLine($"Başlık      : {card.Title}");
                    Console.WriteLine($"İçerik      : {card.Content}");
                    Console.WriteLine($"Atanan Kişi : {card.AssignedTo}");
                    Console.WriteLine($"Büyüklük    : {card.Size}");
                    Console.WriteLine("-");
                }
            }
        }

        public void AddCard()
        {
            Console.WriteLine("Başlık Giriniz:");
            string title = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz:");
            string content = Console.ReadLine();


            Console.WriteLine("Takım Üyeleri:");
            foreach (var member in teamMembers)
            {
                Console.WriteLine($"ID: {member.Key}, İsim: {member.Value}");
            }
            Console.Write("Kartı atamak istediğiniz takım üyesinin ID'sini giriniz: ");
            int memberId = int.Parse(Console.ReadLine());


            if (!teamMembers.ContainsKey(memberId))
            {
                Console.WriteLine("Hatalı bir takım üyesi ID'si girdiniz.");
                return;
            }

            string assignedTo = teamMembers[memberId];


            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            int sizeChoice = int.Parse(Console.ReadLine());


            if (sizeChoice < 1 || sizeChoice > 5)
            {
                Console.WriteLine("Hatalı bir büyüklük seçimi yaptınız.");
                return;
            }

            TodoSize size = (TodoSize)sizeChoice;

           
            TodoCard newCard = new TodoCard
            {
                Title = title,
                Content = content,
                AssignedTo = assignedTo,
                Size = size,
                Line = TodoLine.TODO
            };

            board[TodoLine.TODO].Add(newCard);
            Console.WriteLine("Kart başarıyla eklendi.");
        }

        public void DeleteCard()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string title = Console.ReadLine();

            bool cardFound = false;
            foreach (var line in board)
            {
                var cardToRemove = line.Value.FirstOrDefault(card => card.Title.Equals(title));
                if (cardToRemove != null)
                {
                    cardFound = true;
                    line.Value.Remove(cardToRemove);
                    Console.WriteLine($"{title} başlıklı kart silindi.");
                }
            }

            if (!cardFound)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            }
        }

        public void MoveCard()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string title = Console.ReadLine();

            TodoCard cardToMove = null;
            foreach (var line in board)
            {
                cardToMove = line.Value.FirstOrDefault(card => card.Title.Equals(title));
                if (cardToMove != null)
                {
                    break;
                }
            }

            if (cardToMove == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * İşlemi sonlandırmak için : (1)");
                Console.WriteLine(" * Yeniden denemek için : (2)");

                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    return;
                }
                else if (choice == 2)
                {
                    UpdateCard();
                    return;
                }
                else
                {
                    Console.WriteLine("Hatalı bir seçim yaptınız. İşlem sonlandırılıyor.");
                    return;
                }
            }

            Console.WriteLine("Bulunan Kart Bilgileri:");
            Console.WriteLine("**************************************");
            Console.WriteLine($"Başlık      : {cardToMove.Title}");
            Console.WriteLine($"İçerik      : {cardToMove.Content}");
            Console.WriteLine($"Atanan Kişi : {cardToMove.AssignedTo}");
            Console.WriteLine($"Büyüklük    : {cardToMove.Size}");
            Console.WriteLine($"Line        : {cardToMove.Line}");

            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: (1) TODO, (2) IN PROGRESS, (3) DONE");
            int lineChoice = int.Parse(Console.ReadLine());

            if (lineChoice < 1 || lineChoice > 3)
            {
                Console.WriteLine("Hatalı bir seçim yaptınız!");
                return;
            }

            TodoLine newLine = (TodoLine)(lineChoice - 1);
            if (cardToMove.Line != newLine)
            {
                board[cardToMove.Line].Remove(cardToMove);
                cardToMove.Line = newLine;
                board[newLine].Add(cardToMove);
                Console.WriteLine($"{cardToMove.Title} başlıklı kart başarıyla {newLine} Line'a taşındı.");
            }
            else
            {
                Console.WriteLine("Kart zaten seçtiğiniz Lineda.");
            }
            ListBoard();
        }
        public void UpdateCard()
        {
            Console.WriteLine("Öncelikle güncellemek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string title = Console.ReadLine();

            TodoCard cardToUpdate = null;
            foreach (var line in board)
            {
                cardToUpdate = line.Value.FirstOrDefault(card => card.Title.Equals(title));
                if (cardToUpdate != null)
                {
                    break;
                }
            }

            if (cardToUpdate == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                return;
            }

            Console.WriteLine("Yeni Başlık (Eski: " + cardToUpdate.Title + "):");
            string newTitle = Console.ReadLine();
            Console.WriteLine("Yeni İçerik (Eski: " + cardToUpdate.Content + "):");
            string newContent = Console.ReadLine();

            
            Console.WriteLine("Takım Üyeleri:");
            foreach (var member in teamMembers)
            {
                Console.WriteLine($"ID: {member.Key}, İsim: {member.Value}");
            }
            Console.Write("Yeni Atanan Kişi (Eski: " + cardToUpdate.AssignedTo + "): ");
            int memberId = int.Parse(Console.ReadLine());

            
            if (!teamMembers.ContainsKey(memberId))
            {
                Console.WriteLine("Hatalı bir takım üyesi ID'si girdiniz.");
                return;
            }

            string newAssignedTo = teamMembers[memberId];

            Console.WriteLine("Yeni Büyüklük (Eski: " + cardToUpdate.Size + "):");
            Console.WriteLine("Büyüklük Seçiniz:");
            Console.WriteLine("(1) XS");
            Console.WriteLine("(2) S");
            Console.WriteLine("(3) M");
            Console.WriteLine("(4) L");
            Console.WriteLine("(5) XL");
            int newSizeChoice = int.Parse(Console.ReadLine());
            TodoSize newSize = (TodoSize)newSizeChoice;

            
            cardToUpdate.Title = newTitle;
            cardToUpdate.Content = newContent;
            cardToUpdate.AssignedTo = newAssignedTo;
            cardToUpdate.Size = newSize;

            Console.WriteLine("Kart başarıyla güncellendi.");
        }
    }
}
