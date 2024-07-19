namespace HayvanatDosage
{
    public class Hayvan
    {

        public string TurAdi { get; set; }
        public double Agirlik { get; set; }
        public int Yas { get; set; }


        public Hayvan(string turAdi, double agirlik, int yas)
        {
            TurAdi = turAdi;
            Agirlik = agirlik;
            Yas = yas;
        }


        public virtual double GetDosage()
        {

            return Agirlik * 0.02;
        }

        public virtual string GetFeedSchedule()
        {

            return "Günde iki kez yem veriniz.";
        }
    }
}
