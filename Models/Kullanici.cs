namespace RezerveMuzikWeb.Models
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public int RolFkId { get; set; } // Hani veritabanında Admin/Müzisyen ayırmıştık ya, işte o!
    }
}