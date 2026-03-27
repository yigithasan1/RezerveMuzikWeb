using Microsoft.AspNetCore.Mvc;
using RezerveMuzikWeb.Models;
using System.Collections.Generic;

namespace RezerveMuzikWeb.Controllers
{
    public class EkipmanlarController : Controller
    {
        public IActionResult Index()
        {
            // Veritabanı bağlanana kadar kullanacağımız sahte ekipman listesi
            var sahteEkipmanlar = new List<Ekipman>
            {
                new Ekipman { Id = 1, EkipmanAdi = "Fender Stratocaster Elektro Gitar", SaatlikKiraUcreti = 100 },
                new Ekipman { Id = 2, EkipmanAdi = "Marshall 100W Amfi", SaatlikKiraUcreti = 80 },
                new Ekipman { Id = 3, EkipmanAdi = "Shure SM58 Mikrofon", SaatlikKiraUcreti = 50 },
                new Ekipman { Id = 4, EkipmanAdi = "Yamaha Bateri Seti", SaatlikKiraUcreti = 150 }
            };

            // Kargoyu View'a fırlat
            return View(sahteEkipmanlar);
        }
    }
}