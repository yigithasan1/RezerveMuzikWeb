using Microsoft.AspNetCore.Mvc;
using RezerveMuzikWeb.Models;
using System;
using System.Collections.Generic;

namespace RezerveMuzikWeb.Controllers
{
    public class RezervasyonController : Controller
    {
        // MOCK DATA: Veritabanı bağlanana kadar verileri hafızada tutacağımız geçici liste.
        // Uygulama kapanana kadar veriler burada yaşar.
        private static List<Rezervasyon> mockRezervasyonlar = new List<Rezervasyon>
        {
            new Rezervasyon { Id = 1, KullaniciFkId = 1, OdaFkId = 1, BaslangicTarihSaat = DateTime.Now.AddDays(1), BitisTarihSaat = DateTime.Now.AddDays(1).AddHours(2), Durum = "Onaylandı" }
        };

        // 1. LİSTELEME EKRANI (Kullanıcı "Rezervasyon" sekmesine tıklayınca burası çalışır)
        public IActionResult Index()
        {
            // Elimizdeki listeyi View'a (Ekrana) gönderiyoruz.
            return View(mockRezervasyonlar);
        }

        // 2. KAYIT EKLEME İŞLEMİ (Kullanıcı formdaki butona basınca burası çalışır)
        [HttpPost]
        public IActionResult Ekle(Rezervasyon yeniKayıt)
        {
            // Formdan gelen veriye otomatik bir ID atıyoruz.
            yeniKayıt.Id = mockRezervasyonlar.Count + 1;
            yeniKayıt.KullaniciFkId = 1; // Giriş/Kayıt sistemi yapana kadar herkesi 1 numaralı kullanıcı sayıyoruz.
            yeniKayıt.Durum = "Beklemede"; // İlk kayıt anında durum beklemede olur.

            // Yeni kaydı sahte veritabanımıza (listemize) ekliyoruz.
            mockRezervasyonlar.Add(yeniKayıt);

            // Kayıt bitince sayfayı yenileyip tekrar listeleme (Index) ekranına yönlendiriyoruz.
            return RedirectToAction("Index");
        }
    }
}