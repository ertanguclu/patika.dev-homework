namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.soru
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            // Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            //Console.WriteLine("***** Soru 1 *****");
            //Console.Write("Girmek istediğiniz sayı adedini giriniz: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n < 0)
            //{
            //    Console.WriteLine("Lütfen pozitif bir sayı giriniz!");
            //}
            //else
            //{
            //    int[] numbers = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"{i + 1}. sayıyı giriniz: ");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        if (sayi > 0)
            //        {
            //            numbers[i] = sayi;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
            //            i--;
            //        }              
            //    }
            //    Console.WriteLine("Çift Sayılar:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (numbers[i] % 2 == 0)
            //        {
            //            Console.WriteLine(numbers[i]);
            //        }
            //    }

            //}
            //------------------------------------------------------------------//
            //2.soru
            // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            // Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            //Console.WriteLine("***** Soru 2 *****");
            //int n;
            //do
            //{
            //    Console.Write("Girmek istediğiniz sayı adedini giriniz: ");
            //    n = Convert.ToInt32(Console.ReadLine());

            //    if (n <= 0)
            //    {
            //        Console.WriteLine("Lütfen pozitif bir sayı giriniz!");
            //    }
            //}
            //while (n <= 0);
            //int m;
            //do
            //{
            //    Console.Write("Bölünecek sayıyı giriniz: ");
            //    m = Convert.ToInt32(Console.ReadLine());

            //    if (m <= 0)
            //    {
            //        Console.WriteLine("Lütfen pozitif bir sayı giriniz!");
            //    }
            //}
            //while (m <= 0);
            //int[] numbers = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"{i + 1}. sayıyı giriniz: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    while (sayi <= 0) 
            //    {
            //        Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
            //        Console.Write($"{i + 1}. sayıyı giriniz: ");
            //        sayi = Convert.ToInt32(Console.ReadLine());
            //    }
            //    numbers[i] = sayi;
            //}

            //Console.WriteLine($"{m} sayısına tam bölünen ya da eşit olan sayılar:");
            //for (int i = 0; i < n; i++)
            //{
            //    if (numbers[i] % m == 0 || numbers[i] == m)
            //    {
            //        Console.WriteLine($"Tam Bölünen veya eşit Sayılar: {numbers[i]}");
            //    }
            //}
            //------------------------------------------------------------------//
            //3.soru
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
            // Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            //Console.WriteLine("***** Soru 3 *****");
            //int n;
            //do
            //{
            //    Console.Write("Girmek istediğiniz kelime adedini giriniz: ");
            //    n = Convert.ToInt32(Console.ReadLine());

            //    if (n <= 0)
            //    {
            //        Console.WriteLine("Lütfen pozitif bir sayı giriniz!");
            //    }
            //}
            //while (n <= 0);
            //string[] words = new string[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"{i + 1}. kelimeyi giriniz: ");
            //    string kelime = Console.ReadLine();
            //    words[i] = kelime;
            //}
            //Console.WriteLine("Girilen kelimelerin tersten yazılışı:");
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(words[i]);
            //}
            //------------------------------------------------------------------//
            //4.soru
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.WriteLine("***** Soru 4 *****");
            Console.Write("Bir cümle yazınız: ");

            string cumle = Console.ReadLine();
            string sadeceHarfler = cumle.Replace(" ", "");

            int kelimeSayisi = cumle.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int harfSayisi = sadeceHarfler.Length;

            Console.WriteLine($"Cümledeki toplam kelime sayısı: {kelimeSayisi}");
            Console.WriteLine($"Cümledeki toplam harf sayısı: {harfSayisi}");



        }
    }
}
