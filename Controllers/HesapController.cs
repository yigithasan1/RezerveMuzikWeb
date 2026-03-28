using Microsoft.AspNetCore.Mvc;

namespace RezerveMuzikWeb.Controllers
{
    public class HesapController : Controller
    {
        // Menüdeki "Giriş Yap" butonuna tıklandığında bu metot çalışır
        public IActionResult Giris()
        {
            // Kullanıcıya giriş yapması için boş bir form (View) gönderir
            return View();
        }
    }
}