namespace RezerveMuzikWeb.Models
{
    public class Oda
    {
        public int Id { get; set; }
        public string OdaAdi { get; set; }
        public decimal SaatlikUcret { get; set; }
        public int Kapasite { get; set; }
    }
}