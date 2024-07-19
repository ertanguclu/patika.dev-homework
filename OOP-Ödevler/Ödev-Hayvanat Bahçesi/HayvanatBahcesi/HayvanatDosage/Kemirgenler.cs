namespace HayvanatDosage
{
    public class Kemirgenler : Hayvan
    {
        public Kemirgenler(string turAdi, double agirlik, int yas) : base(turAdi, agirlik, yas)
        {
        }
        public override double GetDosage()
        {

            return Agirlik * 0.015;
        }


        public override string GetFeedSchedule()
        {

            return "Günde bir kez yem veriniz, sabah saatlerinde.";
        }
    }
}
