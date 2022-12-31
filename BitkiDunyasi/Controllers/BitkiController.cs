using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using BitkiDunyasi.Models;
using BitkiDunyasi.Migrations;

namespace BitkiDunyasi.Controllers
{
    public class BitkiController : Controller
    {
        ApplicationDbContext _bitkicontext = new ApplicationDbContext();
        // GET: BitkiController
        public ActionResult Index()
        {
            var bitkiler = _bitkicontext.Bitkiler;
            return View(bitkiler); ;
        }

        /*public IActionResult Details(int? id)
        {
            //foreach (var yz in k.Yazarlar)
            //{
            //    if (yz.YazarID == id)
            //    {
            //        var y = yz;
            //    }
            //}
            if (id is null)
            {
                TempData["hata"] = "Detay kısmı getirilemez";
                return View("Hata");
            }

            var y = k.Yazarlar.Include(x => x.Kitaplar).FirstOrDefault(x => x.YazarID == id);
            if (y is null)
            {
                TempData["hata"] = "Herhangi bir yazar bulunamadı";
                return View("Hata");
            }
            return View(y);
        }*/

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Bitki b)
        {
            if (ModelState.IsValid)
            {
                _bitkicontext.Add(b);
                _bitkicontext.SaveChanges();
                TempData["msj"] = b.bitkiAdi + " adlı bitki eklendi";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["hata"] = "Lütfen Gerekli alanları doldurunuz";
                return RedirectToAction("Create");
            }


        }
        [HttpPost]
        public IActionResult Edit(int? id, Bitki b)
        {
            if (id != b.BitkiID)
            {
                TempData["hata"] = "Güncelleme Yapılmaz";
                return View("Hata");
            }
            if (ModelState.IsValid)
            {
                _bitkicontext.Bitkiler.Update(b);
                _bitkicontext.SaveChanges();
                TempData["msj"] = b.bitkiAdi + " adlı bitki düzenlendi";
                return RedirectToAction("Index");
            }
            TempData["hata"] = "Lütfen verileri eksiksiz girin";
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id is null)
            {
                TempData["hata"] = "Düzenleme kısmı çalışamaz";
                return View("Hata");
            }
            var b = _bitkicontext.Bitkiler.FirstOrDefault(x => x.BitkiID == id);
            if (b is null)
            {
                TempData["hata"] = "Düzenlenece herhangi bir yazar yok";
                return View("Hata");

            }
            return View(b);
        }
        
        public IActionResult Delete(int? id)
        {
            if (id is null)
            {
                TempData["hata"] = "Silme kısmı çalışamaz";
                return View("Hata");
            }
            var yorum = _bitkicontext.Bitkiler.Include(x => x.Usercomments).FirstOrDefault(x => x.BitkiID == id);
            if (yorum is null)
            {
                TempData["hata"] = "Silinecek herhangi bir yazar yok";
                return View("Hata");

            }
            /*
            if (yorum.Usercomments.Count > 0)
            {
                TempData["hata"] = "Yazarın kitabı olduğundan silme işlemi yapılamaz";
                return View("Hata");
            }
            */
            //k.Remove(y);
            
            _bitkicontext.Bitkiler.Remove(yorum);
            _bitkicontext.SaveChanges();
            TempData["msj"] = yorum.bitkiAdi + " adlı bitki silindi";
            return RedirectToAction("Index");


        }
        
    }
}
