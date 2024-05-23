namespace Koleksiyon_Soru_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle yazınız: ");
            string cumle = Console.ReadLine();

            List<char> sesliHarfler = new List<char> { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü', 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };
            List<char> cumleSesliHarfler = new List<char>();

            foreach (char harf in cumle)
            {
                if (sesliHarfler.Contains(harf))
                {
                    cumleSesliHarfler.Add(harf);
                }
            }

            cumleSesliHarfler.Sort();

            Console.WriteLine("Cümledeki sesli harfler:");
            foreach (char sesliHarf in cumleSesliHarfler)
            {
                Console.WriteLine(sesliHarf);
            }
        }
    }
}
