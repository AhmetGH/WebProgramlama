using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BitkiDunyasi.Models;
using BitkiDunyasi.Migrations;

namespace BitkiDunyasi.Controllers
{
    public class BitkiController : Controller
    {

        ApplicationDbContext k = new ApplicationDbContext();
        // GET: BitkiController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BitkiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BitkiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BitkiController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BitkiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BitkiController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BitkiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BitkiController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
