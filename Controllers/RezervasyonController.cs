using Microsoft.AspNetCore.Mvc;
using RezerveMuzikWeb.Models;
using System;
using System.Collections.Generic;

namespace RezerveMuzikWeb.Controllers
{
    public class RezervasyonController : Controller
    {
        // 1. Sayfayı ilk açtığımızda çalışan metot (Şu anki ekranımız)
        public IActionResult Index()
        {
            // Sayfa hata vermesin diye şimdilik tabloya boş bir liste gönderiyoruz
            var sahteRezervasyonlar = new List<Rezervasyon>();
            return View(sahteRezervasyonlar);
        }

        // 2. DİKKAT: Butona basıldığında form buraya postalanır (gönderilir)!
        [HttpPost]
        public IActionResult RezerveEt(int OdaId, DateTime BaslangicZamani, DateTime BitisZamani, List<int> SecilenEkipmanlar)
        {
            // BURASI SİHİRİN GERÇEKLEŞTİĞİ YER!
            // HTML'de checkboxların "name" özelliğine "SecilenEkipmanlar" yazdığımız için, 
            // C# otomatik olarak işaretlenen tüm değerleri (1, 2, 4 gibi) yakalayıp bu listeye doldurur.

            // Şimdilik veritabanına kaydetmiyoruz, sadece doğru yakaladık mı diye ekrana basarak test ediyoruz:

            string mesaj = $"--- TEST SONUÇLARI ---\n" +
                           $"Oda ID: {OdaId} başarıyla yakalandı.\n" +
                           $"Tarihler: {BaslangicZamani} ile {BitisZamani} arası.\n" +
                           $"Seçilen Ekipman Sayısı: {SecilenEkipmanlar.Count} adet.\n";

            if (SecilenEkipmanlar.Count > 0)
            {
                mesaj += "Seçilen Ekipman ID'leri: " + string.Join(", ", SecilenEkipmanlar);
            }
            else
            {
                mesaj += "Hiç ekstra ekipman seçilmedi.";
            }

            // Sadece test amaçlı düz yazı döndürüyoruz
            return Content(mesaj);
        }
    }
}