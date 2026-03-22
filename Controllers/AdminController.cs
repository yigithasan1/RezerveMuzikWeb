using Microsoft.AspNetCore.Mvc;

namespace RezerveMuzikWeb.Controllers
{
    // Bu Controller sadece "Admin" yetkisine sahip kişilerin sayfalarını barındırır.
    public class AdminController : Controller
    {
        // Admin Paneli Ana Sayfası
        public IActionResult Index()
        {
            return View();
        }

        // Admin'in odaları ekleyip sildiği sayfa (Ödevde klasör yapısı görünsün diye ekliyoruz)
        public IActionResult OdaYonetimi()
        {
            return View();
        }
    }
}
