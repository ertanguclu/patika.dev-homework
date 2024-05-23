using System.Collections;

namespace Koleksiyon_Soru_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            int asalSayac = 0;
            int asalOlmayanSayac = 0;

            Console.WriteLine("Klavyeden 20 adet pozitif sayı giriniz:");

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int sayi) && sayi > 0)
                {
                    if (AsalMi(sayi))
                    {
                        asalSayilar.Add(sayi);
                        asalSayac++;
                    }
                    else
                    {
                        asalOlmayanSayilar.Add(sayi);
                        asalOlmayanSayac++;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş! Pozitif bir tam sayı giriniz.");
                    i--; 
                }
            }

            
            asalSayilar.Sort();
            asalSayilar.Reverse();
            Console.WriteLine("Asal Sayılar:");
            foreach (int sayi in asalSayilar)
            {
                Console.WriteLine(sayi);
            }

           
            asalOlmayanSayilar.Sort();
            asalOlmayanSayilar.Reverse();
            Console.WriteLine("Asal Olmayan Sayılar:");
            foreach (int sayi in asalOlmayanSayilar)
            {
                Console.WriteLine(sayi);
            }

            
            Console.WriteLine($"Asal Sayıların Sayısı: {asalSayac}");
            Console.WriteLine($"Asal Olmayan Sayıların Sayısı: {asalOlmayanSayac}");

            double asalOrtalama = asalSayilar.Count > 0 ? Ortalama(asalSayilar) : 0;
            double asalOlmayanOrtalama = asalOlmayanSayilar.Count > 0 ? Ortalama(asalOlmayanSayilar) : 0;

            Console.WriteLine($"Asal Sayıların Ortalaması: {asalOrtalama}");
            Console.WriteLine($"Asal Olmayan Sayıların Ortalaması: {asalOlmayanOrtalama}");
        }

        static bool AsalMi(int sayi)
        {
            if (sayi <= 1)
                return false;
            if (sayi <= 3)
                return true;
            if (sayi % 2 == 0 || sayi % 3 == 0)
                return false;
            for (int i = 5; i * i <= sayi; i += 6)
            {
                if (sayi % i == 0 || sayi % (i + 2) == 0)
                    return false;
            }
            return true;
        }

        static double Ortalama(ArrayList list)
        {
            int toplam = 0;
            foreach (int sayi in list)
            {
                toplam += sayi;
            }
            return (double)toplam / list.Count;
        }
    }
}
