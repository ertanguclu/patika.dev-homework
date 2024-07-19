namespace HayvanatDosage
{
    public class Atlar : Hayvan
    {
        public Atlar(string turAdi, double agirlik, int yas) : base(turAdi, agirlik, yas)
        {
        }


        public override double GetDosage()
        {

            return Agirlik * 0.03;
        }


        public override string GetFeedSchedule()
        {

            return "Sabah ve akşam saatlerinde yem veriniz.";
        }
    }
}
