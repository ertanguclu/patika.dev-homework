namespace Koleksiyon_Soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];

            Console.WriteLine("Klavyeden 20 adet sayı giriniz:");

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int sayi))
                {
                    sayilar[i] = sayi;
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş! Tam sayı giriniz.");
                    i--; 
                }
            }

            Array.Sort(sayilar);

            int enKucukToplam = 0;
            int enBuyukToplam = 0;

            Console.WriteLine("En küçük 3 sayı:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sayilar[i]);
                enKucukToplam += sayilar[i];
            }

            Console.WriteLine("En büyük 3 sayı:");
            for (int i = sayilar.Length - 1; i >= sayilar.Length - 3; i--)
            {
                Console.WriteLine(sayilar[i]);
                enBuyukToplam += sayilar[i];
            }

            double enKucukOrtalama = (double)enKucukToplam / 3;
            double enBuyukOrtalama = (double)enBuyukToplam / 3;

            Console.WriteLine($"En küçük 3 sayının ortalaması: {enKucukOrtalama}");
            Console.WriteLine($"En büyük 3 sayının ortalaması: {enBuyukOrtalama}");
            Console.WriteLine($"En küçük 3 sayının toplamı: {enKucukToplam}");
            Console.WriteLine($"En büyük 3 sayının toplamı: {enBuyukToplam}");
        }
    }
}
