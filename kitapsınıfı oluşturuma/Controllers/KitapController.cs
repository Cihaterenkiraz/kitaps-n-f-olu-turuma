using kitapsınıfı_oluşturuma.Models;
using Microsoft.AspNetCore.Mvc;

namespace kitapsınıfı_oluşturuma.Controllers
{
    public class KitapController : Controller
    {
        public IActionResult Index()
        {
            Kitap kitap = new Kitap();
            {
                kitap.Id = 1;
                kitap.Ad = " A'da Z'ye WEB Tabanlı Uygulama";
                kitap.Yazar = " Turgay Tugay Bilgin ";
                kitap.YayinEvi = "Kodlab";
                kitap.Kategori = "Bigisayar";
            }

            Kitap kitap1 = new Kitap();
            {
                kitap1.Id = 1;
                kitap1.Ad = " A'dan Z'ye WEB Tabanlı Uygulama ";
                kitap1.Yazar = " Turgay Tugay Bilgin";
                kitap1.YayinEvi = "Kodlab";
                kitap1.Kategori = "Bigisayar";
            }

            Kitap kitap2 = new Kitap();
            {
                kitap2.Id = 1;
                kitap2.Ad = " A'dan Z'ye WEB Tabanlı Uygulama";
                kitap2.Yazar = "Turgay Tugay Bilgin ";
                kitap2.YayinEvi = "Kodlab";
                kitap2.Kategori = "Bigisayar";
            }

            Kitap kitap3 = new Kitap();
            {
                kitap3.Id = 1;
                kitap3.Ad = " A'dan Z'ye WEB Tabanlı Uygulama";
                kitap3.Yazar = " Turgay Tugay Bilgin";
                kitap3.YayinEvi = "Kodlab";
                kitap3.Kategori = "Bigisayar";
            }

            ViewData["Roman"] = "Roman";
            ViewData["Klasik"] = "Klasik";
            TempData["Bilgisayar"] = "Bilgisayar";

            List<Kitap> kitaplar = new List<Kitap>();
            kitaplar.Add(kitap);
            kitaplar.Add(kitap1);
            kitaplar.Add(kitap2);
            kitaplar.Add(kitap3);

            return View(kitaplar);
        }
    }
}
