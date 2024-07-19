namespace HayvanatDosage
{
    internal class Kedigiller : Hayvan
    {
        public Kedigiller(string turAdi, double agirlik, int yas) : base(turAdi, agirlik, yas)
        {
        }


        public override double GetDosage()
        {

            return Agirlik * 0.01;
        }


        public override string GetFeedSchedule()
        {

            return "Günde bir kez yem veriniz.";
        }
    }
}
