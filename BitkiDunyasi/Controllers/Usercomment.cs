using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using BitkiDunyasi.Migrations;
using BitkiDunyasi.Models;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace BitkiDunyasi.Controllers
{
    public class Usercomment : Controller
	{
		ApplicationDbContext _context = new ApplicationDbContext();
		public IActionResult Createcomment()
		{
			ViewData["UsercommentID"] = new SelectList(_context.Bitkiler, "BitkiID", "bitkiAdi");
			return View();
		}

		// POST
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Createcomment([Bind("UsercommentID,kullaniciYorumu,BitkiID")] Usercomment yorum)
		{
			if (ModelState.IsValid)
			{
				_context.Add(yorum);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			//ViewData["BitkiID"] = new SelectList(_context.Bitkiler, "BitkiID", "bitkiAdi", yorum.BitkiID);
			return View();
		}

		public async Task<IActionResult> Index()
		{
			var yorumContext = _context.Usercomments.Include(k => k.Bitki);
			return View(await yorumContext.ToListAsync());
		}

		// GET: 
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var yorum = await _context.Usercomments
				.Include(k => k.Bitki)
				.FirstOrDefaultAsync(m => m.UsercommentID == id);
			if (yorum == null)
			{
				return NotFound();
			}

			return View(yorum);
		}
		
	}
}
