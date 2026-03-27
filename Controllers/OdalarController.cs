using Microsoft.AspNetCore.Mvc;
using RezerveMuzikWeb.Models;
using System.Collections.Generic;

namespace RezerveMuzikWeb.Controllers
{
    public class OdalarController : Controller
    {
        // Ana menüden "Stüdyolarımız" sekmesine tıklandığında bu metot çalışır
        public IActionResult Index()
        {
            // Veritabanı yerine geçici olarak 3 tane sahte stüdyo (oda) oluşturuyoruz
            var sahteOdalar = new List<Oda>
            {
                new Oda { Id = 1, OdaAdi = "Akustik Stüdyo", Kapasite = 3, SaatlikUcret = 250 },
                new Oda { Id = 2, OdaAdi = "Büyük Prova Odası", Kapasite = 8, SaatlikUcret = 400 },
                new Oda { Id = 3, OdaAdi = "Vokal Kayıt Odası", Kapasite = 2, SaatlikUcret = 350 }
            };

            // Bu listeyi, ekranda (View) gösterilmesi için gönderiyoruz
            return View(sahteOdalar);
        }
    }
}