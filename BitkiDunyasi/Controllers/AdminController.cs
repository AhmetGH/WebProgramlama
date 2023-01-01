using BitkiDunyasi.Migrations;
using BitkiDunyasi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BitkiDunyasi.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private ApplicationDbContext _application;
        
        public AdminController(ApplicationDbContext application)
        {
            _application= application;
        }
        public IActionResult Index()
        {
            return View(_application.Users.ToList());
        }
    }
}
