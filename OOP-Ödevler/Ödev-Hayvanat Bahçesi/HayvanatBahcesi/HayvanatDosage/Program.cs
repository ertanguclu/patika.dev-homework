namespace HayvanatDosage
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hayvan at = new Atlar("At", 250, 5);
            Hayvan kaplan = new Kedigiller("Kaplan", 150, 8);
            Hayvan fare = new Kemirgenler("Fare", 0.5, 1);


            Console.WriteLine($"At için dozaj: {at.GetDosage()} mL");
            Console.WriteLine($"At için yem verme zamanı: {at.GetFeedSchedule()}");

            Console.WriteLine();

            Console.WriteLine($"Kaplan için dozaj: {kaplan.GetDosage()} mL");
            Console.WriteLine($"Kaplan için yem verme zamanı: {kaplan.GetFeedSchedule()}");

            Console.WriteLine();

            Console.WriteLine($"Fare için dozaj: {fare.GetDosage()} mL");
            Console.WriteLine($"Fare için yem verme zamanı: {fare.GetFeedSchedule()}");
        }
    }
}
