using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BitkiDunyasi.Migrations;
using BitkiDunyasi.Models;

namespace BitkiDunyasi.Controllers
{

	public class CallBitkiApi : Controller
	{
		public async Task<IActionResult> Index()
		{
			List<Bitki> Bitkiler = new List<Bitki>();
			var hhtc = new HttpClient();
			var response = await hhtc.GetAsync("https://localhost:44343/api/BitkiApi");
			string resString = await response.Content.ReadAsStringAsync();
			Bitkiler = JsonConvert.DeserializeObject<List<Bitki>>(resString);
			return View(Bitkiler);
		}
	}
}
