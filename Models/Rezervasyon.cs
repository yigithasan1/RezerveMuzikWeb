using System;

namespace RezerveMuzikWeb.Models
{
    
    public class Rezervasyon
    {
        public int Id { get; set; }
        public int KullaniciFkId { get; set; }
        public int OdaFkId { get; set; }
        public DateTime BaslangicTarihSaat { get; set; }
        public DateTime BitisTarihSaat { get; set; }
        public string Durum { get; set; }
    }
}
